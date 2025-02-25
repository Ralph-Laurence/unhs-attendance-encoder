using System;
using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.Controller_Services;
using UNHS_Attendance_Encoder_Net48.View.Modals;
using UNHS_Attendance_Encoder_Net48.View.Screens;

namespace UNHS_Attendance_Encoder_Net48
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // sudo => root
            // user => 1234
            var db = new DBHelper();

            if (!db.Initialize())
                return;

            Application.Run(new LoginForm());
        }
    }
}
