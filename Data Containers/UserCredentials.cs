using System;

namespace UNHS_Attendance_Encoder_Net48.Data_Containers
{
    [Serializable]
    internal class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Alias    { get; set; }
    }
}
