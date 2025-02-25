using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using UNHS_Attendance_Encoder_Net48.App.Data_Containers;
using UNHS_Attendance_Encoder_Net48.Data_Containers;

namespace UNHS_Attendance_Encoder_Net48.View.Screens
{
    public partial class AddAttendanceDialog : MasterForm
    {
        public DialogResult CloseAction { get; private set; } = DialogResult.None;
        private DateTime defaultTime  = DateTime.Today.Add(new TimeSpan(0, 0, 0)); // Set default time to 00:00
        private const string zeroTime = "00:00:00";
        public AttendanceItem AttendanceData { get; private set; }
        public int Mode { get; private set; } // 0 - create, 1 - update
        public AttendanceItem AttendanceDataEdit { get; private set; }

        public AddAttendanceDialog(int mode = 0, AttendanceItem attendanceDataEdit = null)
        {
            InitializeComponent();

            Mode = mode;
            AttendanceDataEdit = attendanceDataEdit;
        }

        private void AddAttendanceDialog_Load(object sender, EventArgs e)
        {
            inputLunchFrom.Value    = defaultTime;
            inputLunchTo.Value      = defaultTime;
            inputTimeOut.Value      = defaultTime;
            inputDate.Value         = DateTime.Today;

            if (Mode == 1 && AttendanceDataEdit != null)
                LoadFrom(AttendanceDataEdit);
        }

        private void WindowBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelAdd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDoneAdd_Click(object sender, EventArgs e)
        {
            var passed = ValidateInputs();

            if (!passed)
            {
                return;
            }

            BuildAttendanceData();

            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.txt");
                var content = JsonConvert.SerializeObject(AttendanceData, Formatting.Indented);

                File.WriteAllText(path, content);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to write file contents");
            }

            CloseAction = DialogResult.OK;
            Close();
        }

        private void ShowError(string message)
        {
            ErrorLabel.ForeColor = ColorTranslator.FromHtml("#7D0000");
            ErrorLabel.Text = message;
        }

        private void ShowSuccess()
        {
            ErrorLabel.ForeColor = ColorTranslator.FromHtml("#007E7E");
            ErrorLabel.Text = "All entries look good.";
        }

        private bool ValidateInputs()
        {
            DateTime? timeIn    = GetDateTimePickerValue(inputTimeIn);
            DateTime? lunchFrom = GetDateTimePickerValue(inputLunchFrom);
            DateTime? lunchEnd  = GetDateTimePickerValue(inputLunchTo);
            DateTime? timeOut   = GetDateTimePickerValue(inputTimeOut);

            // Rule: Employee ID cannot be empty
            if (string.IsNullOrEmpty(inputEmployeeID.Text))
            {
                ShowError("Employee ID cannot be empty.");
                return false;
            }

            // Rule: Date cannot be a future date
            if (inputDate.Value.Date > DateTime.Today)
            {
                ShowError("Date cannot be a future date.");
                return false;
            }

            // Rule: Lunch From must be greater than Time In
            if (timeIn.HasValue && lunchFrom.HasValue && lunchFrom <= timeIn)
            {
                ShowError("Lunch From must be greater than Time In.");
                return false;
            }

            // Rule: Lunch End must be greater than Lunch From
            if (lunchFrom.HasValue && lunchEnd.HasValue && lunchEnd <= lunchFrom)
            {
                ShowError("Lunch End must be greater than Lunch From.");
                return false;
            }
            else if (!lunchFrom.HasValue && lunchEnd.HasValue)
            {
                ShowError("Please provide a value for 'Lunch From' before entering 'Lunch End'.");
                return false;
            }

            // Rule: Time Out must be greater than Lunch End
            if (lunchEnd.HasValue && timeOut.HasValue && timeOut <= lunchEnd)
            {
                ShowError("Time Out must be greater than Lunch End.");
                return false;
            }

            ShowSuccess();
            return true;
        }

        private void BuildAttendanceData()
        {
            // var timeInDate  = inputDate.Value.ToString("yyyy-MM-dd");
            var timeIn      = GetCombinedDateTime(inputDate, inputTimeIn);
            var lunchFrom   = GetCombinedDateTime(inputDate, inputLunchFrom);
            var lunchTo     = GetCombinedDateTime(inputDate, inputLunchTo);
            var timeOut     = GetCombinedDateTime(inputDate, inputTimeOut);
            
            AttendanceData = new AttendanceItem
            {
                EmployeeID  = inputEmployeeID.Text,
                DateCreated = timeIn,
                TimeIn      = timeIn,
                LunchFrom   = lunchFrom,
                LunchTo     = lunchTo,
                TimeOut     = timeOut,
                Late        = zeroTime,
                Undertime   = zeroTime,
                Overtime    = zeroTime,
                Duration    = zeroTime,
                Week        = GetWeekNumber(inputDate.Value),
            };

            // Calculate the late time in which are made past 7:30 AM

            if (DateTime.TryParse(timeIn, out var parsedTimeIn))
            {
                var lateThreshold = parsedTimeIn.Date.AddHours(7).AddMinutes(30); // 7:30 AM

                if (parsedTimeIn > lateThreshold)
                {
                    var lateDuration = parsedTimeIn - lateThreshold;
                    AttendanceData.Late = lateDuration.ToString(@"hh\:mm\:ss");
                }

                if (inputTimeIn.Value != defaultTime)
                    AttendanceData.Status = "Present";
            }

            if (inputLunchFrom.Value != defaultTime)
            {
                AttendanceData.Status = "Lunch Break";
            }

            if (inputLunchTo.Value != defaultTime)
            {
                AttendanceData.Status = "Present";
            }

            // Calculate the overtime, undertime and time duration
            // which are all dependent on the time out

            if (inputTimeOut.Value == defaultTime)
            {
                // AttendanceData.Status = "Absent";
                return;
            }

            if (DateTime.TryParse(timeOut, out var parsedTimeOut))
            {
                // All TimeOut(s) made after 5:30 PM are considered overtime

                var overtimeThreshold = parsedTimeOut.Date.AddHours(17).AddMinutes(30); // 5:30 PM

                if (parsedTimeOut > overtimeThreshold)
                {
                    var overtime = parsedTimeOut - overtimeThreshold;
                    AttendanceData.Overtime = overtime.ToString(@"hh\:mm\:ss");
                }

                // All TimeOut(s) made before 5:00 PM are considered undertime

                var undertimeThreshold = parsedTimeOut.Date.AddHours(17); // 5:00 PM

                if (parsedTimeOut < undertimeThreshold)
                {
                    var undertime = undertimeThreshold - parsedTimeOut;
                    AttendanceData.Undertime = undertime.ToString(@"hh\:mm\:ss");
                }

                // Calculate total duration excluding lunch break

                if (DateTime.TryParse(lunchFrom, out var parsedLunchFrom) && DateTime.TryParse(lunchTo, out var parsedLunchTo))
                {
                    var totalDuration = (parsedTimeOut - parsedTimeIn) - (parsedLunchTo - parsedLunchFrom);
                    AttendanceData.Duration = totalDuration.ToString(@"hh\:mm\:ss");
                }
                else
                {
                    var totalDuration = parsedTimeOut - parsedTimeIn;
                    AttendanceData.Duration = totalDuration.ToString(@"hh\:mm\:ss");
                }
            }
        }

        // Method to combine date and time values into a single formatted string
        private string GetCombinedDateTime(DateTimePicker datePicker, DateTimePicker timePicker)
        {
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string time = timePicker.Value.ToString("HH:mm");

            return $"{date} {time}:00";
        }

        private DateTime? GetDateTimePickerValue(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Value.TimeOfDay == TimeSpan.Zero)
            {
                return null; // Return null for default value (00:00)
            }
            
            return dateTimePicker.Value;
        }

        private int GetWeekNumber(DateTime inputDate)
        {
            int weekNumber = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                inputDate,
                CalendarWeekRule.FirstDay,
                DayOfWeek.Sunday);

            return weekNumber;
        }

        private void inputTimeIn_ValueChanged(object sender, EventArgs e)
        {
            var timeIn = inputTimeIn.Value;
            var lateThreshold = timeIn.Date.AddHours(7).AddMinutes(30); // 7:30 AM

            if (timeIn > lateThreshold)
            {
                var lateDuration = timeIn - lateThreshold;
                LblLateIndicator.Text = $"{lateDuration.Hours}h {lateDuration.Minutes}m";
            }
            else
            {
                LblLateIndicator.Text = zeroTime;
            }
        }

        private void inputTimeOut_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(GetCombinedDateTime(inputDate, inputTimeOut), out var parsedTimeOut))
            {
                // All TimeOut(s) made after 5:30 PM are considered overtime

                var overtimeThreshold = parsedTimeOut.Date.AddHours(17).AddMinutes(30); // 5:30 PM

                if (parsedTimeOut > overtimeThreshold)
                {
                    var overtime = parsedTimeOut - overtimeThreshold;
                    LblOvertimeIndicator.Text = $"{overtime.Hours}h {overtime.Minutes}m";
                }
                else
                {
                    LblOvertimeIndicator.Text = zeroTime;
                }

                // All TimeOut(s) made before 5:00 PM are considered undertime

                var undertimeThreshold = parsedTimeOut.Date.AddHours(17); // 5:00 PM

                if (parsedTimeOut < undertimeThreshold)
                {
                    var undertime = undertimeThreshold - parsedTimeOut;
                    LblUndertimeIndicator.Text = $"{undertime.Hours}h {undertime.Minutes}m";
                }
                else
                {
                    LblUndertimeIndicator.Text = zeroTime;
                }
            }
        }
    
        public void LoadFrom(AttendanceItem item)
        {
            inputEmployeeID.Text = item.EmployeeID;

            var dateCreated = ParseTimestamp(item.DateCreated, inputDate.CustomFormat);

            if (dateCreated != null)
                inputDate.Value = (DateTime)dateCreated;

            var timeIn = ParseTimestamp(item.TimeIn, Constants.TimestampFormat);
            
            if (timeIn != null)
                inputTimeIn.Value = (DateTime)timeIn;

            var timeOut = ParseTimestamp(item.TimeOut, Constants.TimestampFormat);

            if (timeOut != null)
                inputTimeOut.Value = (DateTime)timeOut;

            var lunchFrom = ParseTimestamp(item.LunchFrom, Constants.TimestampFormat);

            if (lunchFrom != null)
                inputLunchFrom.Value = (DateTime)lunchFrom;

            var lunchTo = ParseTimestamp(item.LunchTo, Constants.TimestampFormat);

            if (lunchTo != null)
                inputLunchTo.Value = (DateTime)lunchTo;
        }

        private DateTime? ParseTimestamp(string plain, string format)
        {
            if (DateTime.TryParseExact(plain, format, null, DateTimeStyles.None, out var parsedTime))
            {
                return parsedTime;
            }

            return null;
        }

        private void dateTimePicker_Leave(object sender, EventArgs e)
        {
            // FOrce update the datepickers on leave as it has no default behaviour of doing so
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            dateTimePicker.Update();

            //ActiveControl = label1;
            //DateTimePicker dateTimePicker = (DateTimePicker)sender;

            //ActiveControl = dateTimePicker;
            //// Update your logic here
            //var selectedTime = dateTimePicker.Value;
            //Debug.WriteLine(selectedTime);
        }

        private void OnDateTimerPicker_ForceUpdate(object sender, KeyEventArgs e)
        {
            
        }
    }
}
