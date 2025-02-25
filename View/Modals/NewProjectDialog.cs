using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.View.Modals
{
    public partial class NewProjectDialog : MasterForm
    {
        public string ProjectName;
        public DialogResult CloseAction { get; set; } = DialogResult.None;

        public NewProjectDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            ProjectName = inputProjectName.Text;
            CloseAction = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            CloseAction = DialogResult.Cancel;
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
