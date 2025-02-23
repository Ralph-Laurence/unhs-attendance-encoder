using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNHS_Attendance_Encoder_Net48
{
    public partial class MasterForm : Form
    {
        private readonly PrivateFontCollection privateFonts;

        public MasterForm()
        {
            privateFonts = new PrivateFontCollection();

            // Load the custom font
            LoadCustomFont("Poppins-Regular.ttf");

            // Set the default font for the application
            this.Font = new Font(privateFonts.Families[0], 10); // Replace "10" with your desired size
        }

        private void LoadCustomFont(string fontFileName)
        {
            // Get the embedded resource stream
            string resourceName = $"UNHS_Attendance_Encoder_Net48.Assets.Fonts.{fontFileName}";
            using (Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (fontStream != null)
                {
                    byte[] fontData = new byte[fontStream.Length];
                    fontStream.Read(fontData, 0, (int)fontStream.Length);

                    // Allocate memory for the font data
                    IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                    Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                    // Add the font to the PrivateFontCollection
                    privateFonts.AddMemoryFont(fontPtr, fontData.Length);

                    // Free the allocated memory
                    Marshal.FreeCoTaskMem(fontPtr);
                }
                else
                {
                    throw new FileNotFoundException($"Font file {fontFileName} not found as embedded resource.");
                }
            }
        }
    }
}
