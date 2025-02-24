using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.Controller_Services;

namespace UNHS_Attendance_Encoder_Net48
{
    public abstract class AuthenticatedForm : MasterForm
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!AuthManager.CheckAuth())
            {
                var loginForm = new LoginForm();
                var dialog = MessageBox.Show("You may need to login first to have access.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dialog == DialogResult.OK)
                {
                    loginForm.Show();
                    this.Close(); // Close the form if the user is not authenticated
                }
            }
        }
    }

}
