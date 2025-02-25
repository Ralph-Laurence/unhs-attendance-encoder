using System;

namespace UNHS_Attendance_Encoder_Net48.App.Security
{
    internal class ShortGuid
    {
        public static string Make()
        {
            Guid guid = Guid.NewGuid();
            string shortGuid = Convert.ToBase64String(guid.ToByteArray())
                .Replace("/", "_") // Replace characters that are not URL-friendly
                .Replace("+", "-")
                .Substring(0, 6); // Take the first 6 characters
            return shortGuid;
        }
    }
}
