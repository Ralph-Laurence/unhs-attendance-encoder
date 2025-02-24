using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.Controller_Services;
using UNHS_Attendance_Encoder_Net48.Data_Containers;

namespace UNHS_Attendance_Encoder_Net48
{
    public partial class LoginForm : MasterForm
    {
        private readonly List<LoginCarouselData> m_carouselContent;
        private readonly LoginService controller;
        private Image[] scrollSpyImages;
        private int m_carouselIndex = 0;
        
        public LoginForm()
        {
            controller = new LoginService(this);

            scrollSpyImages = new Image[3]
            {
                Properties.Resources.scrollspy_login_0,
                Properties.Resources.scrollspy_login_1,
                Properties.Resources.scrollspy_login_2,
            };

            m_carouselContent = new List<LoginCarouselData>()
            {
                { new LoginCarouselData(Properties.Resources.icn_login_carousel_0, "Works Offline", "Create attendance records even without an active internet connection.") },
                { new LoginCarouselData(Properties.Resources.icn_login_carousel_1, "Save Locally",  "Export a local copy of the record as a Comma-Separated Values (*.csv) file.") },
                { new LoginCarouselData(Properties.Resources.icn_login_carousel_2, "Synchronize",   "Send the record to the main server when the internet is restored or when you are online.") },
            };

            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            LblVersionString.Text = $"Version {version} alpha";

            BtnLogin.Enabled = true;
        }

        private void BtnIcnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            RequestLogin();
        }

        private void InputLoginField_KeyUp(object sender, KeyEventArgs e)
        {
            var hasFocus = InputUsername.Focused || InputPassword.Focused;

            if (hasFocus && e.KeyCode == Keys.Enter)
            {
                RequestLogin();

                // Bring the focus again on title text
                ActiveControl = LoginH3;
            }
        }

        private void RequestLogin()
        {
            controller.Login(InputUsername.Text, InputPassword.Text);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            var carouselItem = m_carouselContent[m_carouselIndex];

            // Change scroll spy every 3sec (3000ms tick)
            CarouselPictureBox.Image = carouselItem.Thumbnail;
            CarouselTitle.Text = carouselItem.Title;
            CarouselDescription.Text = carouselItem.Description;

            // Update the scrollspy indicator
            ScrollSpy.Image = scrollSpyImages[m_carouselIndex];

            // Scroll to the next carousel index
            m_carouselIndex++;

            // Go back to the first carousel index
            if (m_carouselIndex > 2)
                m_carouselIndex = 0;
        }
    }
}
