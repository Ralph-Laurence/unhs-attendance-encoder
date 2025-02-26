using System;
using System.IO;
using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.Controller_Services;
using UNHS_Attendance_Encoder_Net48.Data_Containers;
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

            // Create the main folders: 
            var exportsPath = Path.Combine(Constants.DataFolder, "exports");
            var projectsPath = Path.Combine(Constants.DataFolder, "projects");

            if (!Directory.Exists(exportsPath))
                Directory.CreateDirectory(exportsPath);

            if (!Directory.Exists (projectsPath))
                Directory.CreateDirectory (projectsPath);

            // sudo => root
            // user => 1234
            var db = new DBHelper();

            if (!db.Initialize())
                return;

            Application.Run(new LoginForm());
        }
    }
}
