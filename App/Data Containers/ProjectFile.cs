using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UNHS_Attendance_Encoder_Net48.Data_Containers;

namespace UNHS_Attendance_Encoder_Net48.App.Data_Containers
{
    public class ProjectFile
    {
        public static bool Save(Dictionary<string, AttendanceItem> dataSource, string projectName)
        {
            try
            {
                var json = JsonConvert.SerializeObject(dataSource, Formatting.Indented);

                var outputFolder = Path.Combine(Constants.DataFolder, "projects");
                var outputFile = Path.Combine(outputFolder, $"{projectName}.json");

                if (!Directory.Exists(outputFolder))
                    Directory.CreateDirectory(outputFolder);

                File.WriteAllText(outputFile, json);
                return true;
            }
            catch (Exception)
            {
               return false;
            }
        }
    }
}
