using System;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48.Modals
{
    internal class Alert
    {
        public static void Info(string message, string title = "Information")
        {
            Show(message, title, Modal.MODE_INFO);
        }

        public static void Warning(string message, string title = "Warning")
        {
            Show(message, title, Modal.MODE_WARN);
        }

        public static void Danger(string message, string title = "Failure")
        {
            Show(message, title, Modal.MODE_ERROR);
        }

        public static void Confirm(string question, string title = "Confirmation", Action onOK = null, Action onCancel = null)
        {
            var modal    = new Modal(question, title, Modal.MODE_CONFIRM);
            var dialogResult = modal.ShowDialog();

            switch (dialogResult)
            {
                case DialogResult.OK:
                    onOK?.Invoke();
                    break;

                case DialogResult.Cancel:
                    onCancel?.Invoke();
                    break;
            }
        }

        private static void Show(string message, string title, int mode)
        {
            var modal = new Modal(message, title, mode);
            modal.ShowDialog();
        }
    }
}
