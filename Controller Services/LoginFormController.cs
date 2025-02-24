using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.Data_Containers;

namespace UNHS_Attendance_Encoder_Net48.Controller_Services
{
    internal class LoginFormController
    {
        // Perform checks then return a status code
        public int Begin()
        {
            // Make sure that there exists an authentication file
            var check1 = UserAuth.CacheAuthFile();

            if (!check1)
                return StatusCodes.ERROR_ACCESS_DENIED;

            // Allow the user to be redirected to login screen
            var check2 = UserAuth.IsAuthenticated();

            if (!check2)
                return StatusCodes.ERROR_NOT_AUTHENTICATED;

            // If all checks passed, its safe to assume that the user is authenticated
            return StatusCodes.ACTION_SUCCESS;
        }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var result = UserAuth.Login(username, password);

            if (!result)
            {
                MessageBox.Show("Incorrect username or password! Please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var editor = new MainEditor();
            editor.Show();
            return true;
        }
    }
}
