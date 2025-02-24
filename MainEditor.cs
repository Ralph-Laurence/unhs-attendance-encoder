using System;
using System.Drawing;
using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.Controller_Services;
using UNHS_Attendance_Encoder_Net48.Data_Containers;
using UNHS_Attendance_Encoder_Net48.Modals;

namespace UNHS_Attendance_Encoder_Net48
{
    public partial class MainEditor : MasterForm
    {
        public Form Initiator { get; set; }

        public MainEditor()
        {
            InitializeComponent();
        }

        private void MainEditor_Load(object sender, EventArgs e)
        {
            if (!AuthManager.CheckAuth())
            {
                Close();
                Initiator?.Show();

                return;
            }

            LblLoggedUser.Text = AuthManager.User.Displayname;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(privateFonts.Families[Constants.PrimaryFontMediumIndex], 9);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var prompt = "You will be redirected to the login screen when you log out. Any unsaved progress will be lost. Continue?";
            Alert.Confirm(prompt, "Confirm Logout", onOK: () =>
            {
                AuthManager.Logout();
                Initiator?.Show();
            });
        }

        private void WindowBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
