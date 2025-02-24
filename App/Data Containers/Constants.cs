using System.IO;
using System;

namespace UNHS_Attendance_Encoder_Net48.Data_Containers
{
    internal class Constants
    {
        public const string FriendlyAppName = "UNHS Attendance Encoder";
        public static string DataFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appdata");
        public const string PrimaryFont = "Poppins-Regular.ttf";
        public const string PrimaryFontMedium = "Poppins-Medium.ttf";
        public const int PrimaryFontIndex = 0;
        public const int PrimaryFontMediumIndex = 1;
    }
}
