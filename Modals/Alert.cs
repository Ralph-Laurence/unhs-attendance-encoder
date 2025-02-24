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

        private static void Show(string message, string title, int mode)
        {
            var modal = new Modal(message, title, mode);
            modal.ShowDialog();
        }
    }
}
