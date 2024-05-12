using System;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace FinTrack.NewFolder
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            // Attach event handler to the "regulations" button
            button3.Click += Button3_Click;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Generate a PDF document with some sample content

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close the settings formmm !!!: to open overview

            this.Close();

        }
    }
}
