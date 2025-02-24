using System.Collections.Generic;
using System.Linq;
using UNHS_Attendance_Encoder_Net48.App.Data_Containers;
using UNHS_Attendance_Encoder_Net48.App.Models;
using UNHS_Attendance_Encoder_Net48.App.Security;

namespace UNHS_Attendance_Encoder_Net48.Controller_Services
{
    internal class AuthManager
    {
        public static bool Login(string username, string password)
        {
            bool isAuthenticated = false;

            var db = new DBHelper();
            var user = db.Where<User>("users", new Dictionary<string, object>
            {
                { "username", username }
            })
            .FirstOrDefault();

            // Assume that a user exists...
            if (user != null)
            {
                // Test the password
                var verifyPassword = Password.Verify(password, user.Password);

                if (verifyPassword)
                {
                    Session.AuthenticatedUser = user;
                    isAuthenticated = true;
                }
            }

            return isAuthenticated;
        }

        public static bool CheckAuth() => Session.AuthenticatedUser != null;
        public static void Logout() => Session.AuthenticatedUser = null;

        public static User User => Session.AuthenticatedUser;
    }
}
