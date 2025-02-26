using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UNHS_Attendance_Encoder_Net48.Data_Containers;

namespace UNHS_Attendance_Encoder_Net48.App.Data_Containers
{
    public class ProjectFile
    {
        public static string ProjectFolder => Path.Combine(Constants.DataFolder, "projects");
        public static bool Save(Dictionary<string, AttendanceItem> dataSource, string projectName)
        {
            try
            {
                var json = JsonConvert.SerializeObject(dataSource, Formatting.Indented);

                var outputFile = Path.Combine(ProjectFolder, $"{projectName}.json");

                if (!Directory.Exists(ProjectFolder))
                    Directory.CreateDirectory(ProjectFolder);

                File.WriteAllText(outputFile, json);
                return true;
            }
            catch (Exception)
            {
               return false;
            }
        }

        public static Dictionary<string, AttendanceItem> Load(string projectName)
        {
            try
            {
                var projectFile = Path.Combine(ProjectFolder, $"{projectName}.json");

                if (!File.Exists(projectFile))
                    return null;

                var projectJson = File.ReadAllText(projectFile);

                if (string.IsNullOrEmpty(projectJson))
                    return null;

                var obj = JsonConvert.DeserializeObject<Dictionary<string, AttendanceItem>>(projectJson);

                return obj;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
