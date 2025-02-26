using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using UNHS_Attendance_Encoder_Net48.App.Data_Containers;
using UNHS_Attendance_Encoder_Net48.Modals;

namespace UNHS_Attendance_Encoder_Net48.View.Modals
{
    public partial class ProjectBrowser : MasterForm
    {
        private List<string> files = new List<string>();
        public string ProjectName;
        public DialogResult CloseAction { get; set; } = DialogResult.None;

        public ProjectBrowser()
        {
            InitializeComponent();
        }

        private void ProjectBrowser_Load(object sender, EventArgs e)
        {
            LblProjectFolder.Text = $"Project Folder: {ProjectFile.ProjectFolder}";

            LoadProjectFiles(ProjectFile.ProjectFolder);
        }

        private void LoadProjectFiles(string folderPath)
        {
            try
            {
                // Get all JSON files in the specified folder
                string[] jsonFiles = Directory.GetFiles(folderPath, "*.json");
                
                if (jsonFiles.Length < 1)
                {
                    btnLoad.Enabled = false;
                    return;
                }

                // Populate ListBox with the filenames
                foreach (string file in jsonFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    // string fullName = Path.GetFileName(file);
                    listBox1.Items.Add(fileName);
                    files.Add(fileName);
                    //files.Add(fullName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Alert.Danger("A problem has occurred while retrieving the list of project files.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseAction = DialogResult.Cancel;
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                // Get the selected project name
                ProjectName = files[listBox1.SelectedIndex];
            }

            CloseAction = DialogResult.OK;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Ensure the DialogResult is set before the form closes
            if (CloseAction != DialogResult.None)
                this.DialogResult = CloseAction;

            base.OnFormClosing(e);
        }

        private void ModalClose_Click(object sender, System.EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
