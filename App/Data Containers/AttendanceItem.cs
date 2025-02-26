using System;

namespace UNHS_Attendance_Encoder_Net48.App.Data_Containers
{
    [Serializable]
    public class AttendanceItem
    {
        public string EmployeeID { get; set; }
        public string DateCreated { get; set; }
        public string DateUpdated { get; set; }
        public string TimeIn { get; set; }
        public string LunchFrom { get; set; }
        public string LunchTo { get; set; }
        public string TimeOut { get; set; }
        public string Late { get; set; }
        public string Undertime { get; set; }
        public string Overtime { get; set; }
        public string Duration { get; set; }
        public string Status { get; set; }
        public int Week { get; set; }
    }
}
