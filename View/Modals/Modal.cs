using System.Diagnostics;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.Modals
{
    public partial class Modal : MasterForm
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public int Mode { get; set; }
        public const int MODE_INFO      = 0;
        public const int MODE_WARN      = 1;
        public const int MODE_ERROR     = 2;
        public const int MODE_CONFIRM   = 3;
        public DialogResult CloseAction { get; private set; } = DialogResult.None;

        public Modal()
        {
            InitializeComponent();
        }

        public Modal(string message, string title, int mode)
        {
            InitializeComponent();

            Message     = message;
            Title       = title;
            Mode        = mode;

            ModalMessage.Text = Message;
            ModalTitle.Text = Title;

            switch (Mode)
            {
                case MODE_WARN:
                    ModalIcon.Image = Properties.Resources.modal_icon_warn;
                    break;

                case MODE_ERROR:
                    ModalIcon.Image = Properties.Resources.modal_icon_error;
                    break;

                case MODE_CONFIRM:
                    ModalIcon.Image = Properties.Resources.modal_icon_confirm;
                    ModalCancelButton.Visible = true;
                    break;

                case MODE_INFO:
                default:
                    ModalIcon.Image = Properties.Resources.modal_icon_info;
                    break;
            }
        }

        private void ModalOkButton_Click(object sender, System.EventArgs e)
        {
            CloseAction = DialogResult.OK;
            Close();
        }

        private void ModalCancelButton_Click(object sender, System.EventArgs e)
        {
            CloseAction = DialogResult.Cancel;
            Close();
        }

        private void ModalClose_Click(object sender, System.EventArgs e)
        {
            CloseAction = DialogResult.None;
            Close();
        }

        private void Modal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Ensure the DialogResult is set before the form closes
            if (CloseAction != DialogResult.None)
                this.DialogResult = CloseAction;

            base.OnFormClosing(e);
        }
    }
}
