using System;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.View.Modals
{
    public partial class LoadingDialog : MasterForm
    {
        public LoadingDialog()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.ContainerControl |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor
                          , true);
        }

        private void LoadingDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
