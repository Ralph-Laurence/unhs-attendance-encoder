using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.View.Modals
{
    public partial class Help : MasterForm
    {
        public Help()
        {
            InitializeComponent();
        }

        private void ModalClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
