using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using UNHS_Attendance_Encoder_Net48.App.Data_Containers;
using UNHS_Attendance_Encoder_Net48.App.Security;
using UNHS_Attendance_Encoder_Net48.Controller_Services;
using UNHS_Attendance_Encoder_Net48.Data_Containers;
using UNHS_Attendance_Encoder_Net48.Modals;
using UNHS_Attendance_Encoder_Net48.View.Modals;
using UNHS_Attendance_Encoder_Net48.View.Screens;

namespace UNHS_Attendance_Encoder_Net48
{
    public partial class MainEditor : MasterForm
    {
        public Form Initiator { get; set; }
        private string EditorProjectName;
        private Dictionary<string, AttendanceItem> attendanceItems;

        private int currentlySelectedRowIdx = -1;
        private string currentRowKey = string.Empty;
        private bool isRemovingRow = false; // Flag to track row removal

        public MainEditor(Form initiator)
        {
            attendanceItems = new Dictionary<string, AttendanceItem>();
            EditorProjectName = $"Attendance-{DateTime.Today:MM-dd-yyyy}";

            Initiator = initiator;

            InitializeComponent();
        }

        private void MainEditor_Load(object sender, EventArgs e)
        {
            if (!AuthManager.CheckAuth())
            {
                Close();
                Initiator?.Show();

                return;
            }

            LblLoggedUser.Text = AuthManager.User.Displayname;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(privateFonts.Families[Constants.PrimaryFontMediumIndex], 9);
            dataGridView1.Rows.Clear();
            dataGridView1.RowTemplate.MinimumHeight = 30;

            SetProjectTitle(EditorProjectName);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var prompt = "You will be redirected to the login screen when you log out. Any unsaved progress will be lost. Continue?";
            Alert.Confirm(prompt, "Confirm Logout", onOK: () =>
            {
                AuthManager.Logout();
                Initiator?.Show();
                Close();
            });
        }

        private void WindowBtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void WindowBtnClose_Click(object sender, EventArgs e)
        {
            var prompt = "You are about to exit the editor. You will be logged out of your account, and the editor will be closed. Any unsaved progress will be lost. Continue?";
            Alert.Confirm(prompt, "Confirm Logout", onOK: () =>
            {
                AuthManager.Logout();
                Application.Exit();
            });
        }
    
        private void SetProjectTitle(string title)
        {
            EditorProjectName = title;
            LblProjectTitle.Text = EditorProjectName;

            var centerX = (WindowTitleBar.Width / 2) - (LblProjectTitle.Width / 2);
            var centerY = (WindowTitleBar.Height / 2) - (LblProjectTitle.Height / 2);
            
            LblProjectTitle.Location = new Point(centerX, centerY);
        }

        private void AppendAttendanceData(AttendanceItem attendanceItem)
        {
            if (attendanceItem == null)
                return;

            var rowKey = ShortGuid.Make();
            currentRowKey = rowKey;
            attendanceItems.Add(rowKey, attendanceItem);

            // Grab the new row!
            DataGridViewRow row = new DataGridViewRow
            {
                Height = 30
            };

            row.CreateCells(dataGridView1);
            SetRowData(row, attendanceItem, rowKey);
            
            dataGridView1.Rows.Add(row);
        }

        private void UpdateAttendanceRowData(AttendanceItem attendanceItem)
        {
            if (attendanceItem == null)
                return;

            if (dataGridView1.CurrentRow == null)
            {
                Alert.Danger("An error has occurred while trying to load the record data. Please try again later.");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[currentlySelectedRowIdx];
            attendanceItems[currentRowKey] = attendanceItem;
            SetRowData(row, attendanceItem, currentRowKey);
        }

        private void SetRowData(DataGridViewRow row, AttendanceItem attendanceItem, string rowKey = "")
        {
            // Add the data
            if (!string.IsNullOrEmpty(rowKey))
                row.Cells[dataGridView1.Columns["RowKey"].Index].Value = rowKey;

            row.Cells[dataGridView1.Columns["EmployeeID"].Index].Value = attendanceItem.EmployeeID;
            row.Cells[dataGridView1.Columns["CreatedAt" ].Index].Value = DateTime.Parse(attendanceItem.DateCreated).ToString("MMM dd, yyyy");
            row.Cells[dataGridView1.Columns["TimeIn"    ].Index].Value = ToFriendly12HourTime(attendanceItem.TimeIn);
            row.Cells[dataGridView1.Columns["LunchStart"].Index].Value = ToFriendly12HourTime(attendanceItem.LunchFrom);
            row.Cells[dataGridView1.Columns["LunchEnd"  ].Index].Value = ToFriendly12HourTime(attendanceItem.LunchTo);
            row.Cells[dataGridView1.Columns["TimeOut"   ].Index].Value = ToFriendly12HourTime(attendanceItem.TimeOut);
            row.Cells[dataGridView1.Columns["Duration"  ].Index].Value = ToFriendlyTimeDuration(attendanceItem.Duration);
            row.Cells[dataGridView1.Columns["Undertime" ].Index].Value = ToFriendlyTimeDuration(attendanceItem.Undertime);
            row.Cells[dataGridView1.Columns["Overtime"  ].Index].Value = ToFriendlyTimeDuration(attendanceItem.Overtime);
            row.Cells[dataGridView1.Columns["Late"      ].Index].Value = ToFriendlyTimeDuration(attendanceItem.Late);
            row.Cells[dataGridView1.Columns["WeekNo"    ].Index].Value = attendanceItem.Week;
            row.Cells[dataGridView1.Columns["Status"    ].Index].Value = attendanceItem.Status;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ReindexEntryNumbers();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ReindexEntryNumbers();
        }

        private void ReindexEntryNumbers()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["EntryNo"].Value = (i + 1).ToString();
            }
        }

        private string ToFriendly12HourTime(string timestamp)
        {
            DateTime dateTime = DateTime.ParseExact(timestamp, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            // Check if the time is 00:00:00
            if (dateTime.TimeOfDay == TimeSpan.Zero)
            {
                return "00:00";
            }

            // Convert to 12-hour format
            string time12HourFormat = dateTime.ToString("hh:mm tt");
            return time12HourFormat;
        }

        private string ToFriendlyTimeDuration(string timestamp)
        {
            DateTime dateTime = DateTime.ParseExact(timestamp, "HH:mm:ss", CultureInfo.InvariantCulture);

            // Extract the hour and minute components
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;

            // Format as "hh h mm m"
            string formattedTime = $"{hour}h {minute}m";
            return formattedTime;
        }

        private void toolbarBtnInsert_Click(object sender, EventArgs e)
        {
            var addAttendanceDialog = new AddAttendanceDialog();
            addAttendanceDialog.FormClosing += (s, o) =>
            {
                var data = addAttendanceDialog.AttendanceData;
                AppendAttendanceData(data);
            };

            addAttendanceDialog.ShowDialog();
        }

        private void toolbarBtnClearRows_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                Alert.Warning("There are no records to clear.");
                return;
            }

            Alert.Confirm("Do you wish to clear the table?", "Clear Datatable", onOK: () =>
            {
                dataGridView1.Rows.Clear();
                attendanceItems.Clear();
                currentlySelectedRowIdx = -1;
                currentRowKey = string.Empty;
                Alert.Info("The table has been cleared.");
            });
        }

        private void toolbarBtnRemoveRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                Alert.Warning("There are no records to remove.");
                return;
            }

            // Check if the cached index is valid
            if (currentlySelectedRowIdx >= 0 && currentlySelectedRowIdx < dataGridView1.Rows.Count)
            {
                var rowKey = dataGridView1.Rows[currentlySelectedRowIdx].Cells["RowKey"].Value.ToString();
                var rowEntry = dataGridView1.Rows[currentlySelectedRowIdx].Cells["EntryNo"].Value.ToString();

                Alert.Confirm($"Do you wish to remove the record with entry number #{rowEntry}?", "Clear Datatable", onOK: () =>
                {
                    // Temporarily disable SelectionChanged event
                    isRemovingRow = true;

                    // Remove the row at the cached index
                    dataGridView1.Rows.RemoveAt(currentlySelectedRowIdx);

                    // Optionally, reset the cached index
                    currentlySelectedRowIdx = -1; // Or any default value indicating no selection
                    currentRowKey = string.Empty;
                    dataGridView1.ClearSelection();

                    // Re-enable SelectionChanged event
                    isRemovingRow = false;

                    if (attendanceItems.ContainsKey(rowKey))
                        attendanceItems.Remove(rowKey);
                });
            }
            else
            {
                // Handle the case where the index is invalid (e.g., show a message)
                Alert.Info("Please select a record from the table then click on \"Delete\" at the toolbar menu to remove a record.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!isRemovingRow && dataGridView1.CurrentRow != null)
            {
                currentlySelectedRowIdx = dataGridView1.CurrentRow.Index;
            }
        }

        private void toolbarBtnEditRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                Alert.Warning("There are no records to edit.");
                return;
            }

            // Check if the cached index is valid
            if (currentlySelectedRowIdx >= 0 && currentlySelectedRowIdx < dataGridView1.Rows.Count)
            {
                var rowKey = dataGridView1.Rows[currentlySelectedRowIdx].Cells["RowKey"].Value.ToString();

                if (!string.IsNullOrEmpty(rowKey) && attendanceItems.ContainsKey(rowKey))
                {
                    var rowData = attendanceItems[rowKey];

                    var edit = new AddAttendanceDialog(mode: 1, attendanceDataEdit: rowData);
                    edit.FormClosing += (s, v) =>
                    {
                        if (edit.AttendanceData == null)
                            return;

                        var data = edit.AttendanceData;
                        UpdateAttendanceRowData(data);
                    };
                    edit.ShowDialog();
                }
            }
            else
            {
                // Handle the case where the index is invalid (e.g., show a message)
                Alert.Info("Please select a record from the table then click on \"Edit\" at the toolbar menu to edit a record.");
            }
        }

        private async void toolbarBtnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                Alert.Warning("There are no records to export.");
                return;
            }

            var outputFolder = Path.Combine(Constants.DataFolder, "exports");
            var actionStatus = -1;

            // Create an instance of the dialog form
            var overlay = new OverlayForm(this);
            var loading = new LoadingDialog()
            {
                StartPosition = FormStartPosition.Manual,
            };

            try
            {
                var outputFile = Path.Combine(outputFolder, $"{EditorProjectName}.csv");
                var canceled = false;

                if (!Directory.Exists(outputFolder))
                    Directory.CreateDirectory(outputFolder);

                if (File.Exists(outputFile))
                {
                    Alert.Confirm("An existing CSV files has been found. Do you wish to overwrite this file?", "Export CSV", onCancel: () =>
                    {
                        canceled = true;
                    });
                }

                if (canceled)
                {
                    return;
                }
                overlay.Show();
                loading.Show();

                loading.Location = new Point(
                    this.Location.X + (this.Width - loading.Width) / 2,
                    this.Location.Y + (this.Height - loading.Height) / 2
                );

                // Write the dictionary to a CSV file using CsvHelper and the custom mapping
                using (var writer = new StreamWriter(outputFile))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.Context.RegisterClassMap<AttendanceItemCsvMap>(); // Register the custom mapping class
                    csv.WriteHeader<AttendanceItem>();
                    csv.NextRecord();

                    foreach (var attendanceItem in attendanceItems.Values)
                    {
                        csv.WriteRecord(attendanceItem);
                        csv.NextRecord();
                    }
                }

                actionStatus = 0;
            }
            catch (IOException)
            {
                actionStatus = 1;
            }
            catch (Exception)
            {
                actionStatus = 2;
            }
            finally
            {
                // Wait asynchronously for 3 seconds without freezing UI
                await Task.Delay(3000);

                loading.Close();
                overlay.Close();

                switch (actionStatus)
                {
                    case 0:
                        Alert.Info("The CSV file has been successfully created!", "Success");
                        Process.Start("explorer.exe", outputFolder);
                        break;

                    case 1:
                        Alert.Danger("We're unable to write the output CSV file due to an error. Please move the application somewhere accessible.", "File Error");
                        break;

                    case 2:
                        Alert.Danger($"An error is preventing ${Constants.FriendlyAppName} from creating the file.", "Critical Error");
                        break;
                }

                this.Enabled = true; // Ensure the form is enabled again
            }
        }

        private void toolbarBtnNew_Click(object sender, EventArgs e)
        {
            Alert.Confirm("You are about to start a new project. Any unsaved changes will be lost. Continue?", onOK: () =>
            {
                ResetEditor();
                var prompt = new NewProjectDialog();
                var result = prompt.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(prompt.ProjectName))
                    {
                        Alert.Danger("Oops! Please choose a valid project name.");
                        return;
                    }

                    HandleCreateNewProject(prompt.ProjectName);
                }
            });
        }

        private void HandleCreateNewProject(string projectName)
        {
            bool cancelled = false;

            if (File.Exists(projectName))
            {
                Alert.Confirm($"A project with the name {projectName} already exists. Continue with this name and overwrite?", onCancel: () =>
                {
                    cancelled = true;
                });
            }

            if (cancelled)
                return;

            try
            {
                ResetEditor();
                var create = ProjectFile.Save(attendanceItems, projectName);

                if (!create)
                    throw new Exception();

                SetProjectTitle(projectName);
                Alert.Info($"Project {projectName} has been successfully created. You may now start encoding.", "Project Created");
            }
            catch (Exception)
            {
                Alert.Danger("Sorry, we're unable to create the project due to a technical error. Please try again later.");
            }
        }
        private void ResetEditor()
        {
            var defaultProjName = $"Attendance-{DateTime.Today:MM-dd-yyyy}";
            SetProjectTitle(defaultProjName);

            attendanceItems.Clear();
            currentlySelectedRowIdx = -1;
            currentRowKey = string.Empty;
            isRemovingRow = false;
            dataGridView1.Rows.Clear();
        }

        private void toolbarBtnSave_Click(object sender, EventArgs e)
        {
            var save = ProjectFile.Save(attendanceItems, EditorProjectName);

            if (!save)
            {
                Alert.Danger("Sorry, we're unable to save the project due to a technical error. Please try again later.");
                return;
            }

            Alert.Info($"Project state has been successfully saved. You may continue editing.", "Project Saved");
        }
    }
}
