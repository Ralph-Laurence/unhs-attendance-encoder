using System.Drawing;

namespace UNHS_Attendance_Encoder_Net48.Data_Containers
{
    internal class LoginCarouselData
    {
        public Image Thumbnail;
        public string Title;
        public string Description;

        public LoginCarouselData(Image thumbnail, string title, string description)
        {
            Thumbnail = thumbnail;
            Title = title;
            Description = description;
        }
    }
}
