using CsvHelper.Configuration;

namespace UNHS_Attendance_Encoder_Net48.App.Data_Containers
{
    public class AttendanceItemCsvMap : ClassMap<AttendanceItem>
    {
        public AttendanceItemCsvMap()
        {
            Map(m => m.EmployeeID).Name("emp_fk_id");
            Map(m => m.DateCreated).Name("created_at");
            Map(m => m.TimeIn).Name("time_in");
            Map(m => m.LunchFrom).Name("lunch_start");
            Map(m => m.LunchTo).Name("lunch_end");
            Map(m => m.TimeOut).Name("time_out");
            Map(m => m.Late).Name("late");
            Map(m => m.Undertime).Name("undertime");
            Map(m => m.Overtime).Name("overtime");
            Map(m => m.Duration).Name("duration");
            Map(m => m.Status).Name("status");
            Map(m => m.Week).Name("week_no");
        }
    }
}
