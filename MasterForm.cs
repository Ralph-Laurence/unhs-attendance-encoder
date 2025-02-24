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
using UNHS_Attendance_Encoder_Net48.Data_Containers;

namespace UNHS_Attendance_Encoder_Net48
{
    public partial class MasterForm : Form
    {
        protected readonly PrivateFontCollection privateFonts;

        public MasterForm()
        {
            privateFonts = new PrivateFontCollection();

            // Load the custom font
            LoadCustomFont(Constants.PrimaryFont);
            LoadCustomFont(Constants.PrimaryFontMedium);

            // Set the default font for the application
            this.Font = new Font(privateFonts.Families[Constants.PrimaryFontIndex], 10); // Replace "10" with your desired size
        }

        protected void LoadCustomFont(string fontFileName)
        {
            // Get the embedded resource stream
            var asm                  = Assembly.GetExecutingAssembly();
            string resourceName      = $"{asm.GetName().Name}.Assets.Fonts.{fontFileName}";
            using (Stream fontStream = asm.GetManifestResourceStream(resourceName))
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
