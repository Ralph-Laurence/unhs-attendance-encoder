using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.Data_Containers;
using UNHS_Attendance_Encoder_Net48.Modals;

namespace UNHS_Attendance_Encoder_Net48.Controller_Services
{
    internal class LoginService
    {
        public Form Initiator {  get; set; }

        public LoginService(Form initiator = null)
        {
            if (initiator != null)
                Initiator = initiator;
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                Alert.Warning("Please enter your username!", "Login");
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                Alert.Warning("Please enter your password!", "Login");
                return false;
            }

            var result = AuthManager.Login(username, password);

            if (!result)
            {
                Alert.Danger("Incorrect username or password! Please try again.", "Login");
                return false;
            }

            var editor = new MainEditor();
            editor.Show();

            Initiator.Hide();
            return true;
        }
    }
}
