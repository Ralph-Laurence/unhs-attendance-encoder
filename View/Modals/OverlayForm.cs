using System.Drawing;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.View.Modals
{
    public class OverlayForm : Form
    {
        public OverlayForm(Form parent)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.5; // Semi-transparent
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.Owner = parent; // Ensure it's always on top of the parent
            this.Bounds = parent.Bounds; // Cover the entire form
            this.TopMost = true;
        }
    }

}
