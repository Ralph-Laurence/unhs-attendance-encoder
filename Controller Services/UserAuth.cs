using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.Data_Containers;

namespace UNHS_Attendance_Encoder_Net48.Controller_Services
{
    internal class UserAuth
    {
        public const string CredentialsFileName = "session.auth";
        private static UserCredentials currentUser;

        public static string GetSessionAuthPath()
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(currentDirectory, CredentialsFileName);

            return filePath;
        }

        public static bool CacheAuthFile()
        {
            try
            {
                var filePath = GetSessionAuthPath();

                // Create a default user account
                if (!File.Exists(filePath))
                {
                    SaveCredentials(new UserCredentials
                    {
                        Username = "sudo",
                        Password = "root",
                        Alias    = "Admin0",
                    });
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void CheckAuth(string username, string password, out UserCredentials authenticated)
        {
            authenticated = null;
            var credentials = LoadCredentials();

            if (credentials != null
                && credentials.Username.Equals(username)
                && credentials.Password.Equals(password))
            {
                currentUser = credentials;
                authenticated = credentials;
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }
        }

        public static void SaveCredentials(UserCredentials credentials)
        {
            var formatter = new BinaryFormatter();
            var filePath = GetSessionAuthPath();

            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, credentials);
            }
        }

        public static UserCredentials LoadCredentials()
        {
            var formatter = new BinaryFormatter();
            var filePath = GetSessionAuthPath();

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                return (UserCredentials)formatter.Deserialize(stream);
            }
        }

        public static bool Login(string username, string password)
        {
            try
            {
                CheckAuth(username, password, out UserCredentials authenticated);
                SaveCredentials(authenticated);
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                // MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void Logout()
        {
            currentUser.Username = null;
            currentUser.Password = null;

            SaveCredentials(currentUser);
            currentUser = null;
        }

        public static bool IsAuthenticated()
        {
            return currentUser != null;
        }
    }
}
