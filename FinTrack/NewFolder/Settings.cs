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
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Regulations Document";
            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 14, XFontStyle.Bold);

            // Add content to the PDF
            gfx.DrawString("Company Regulations", font, XBrushes.Black,
                           new XRect(0, 0, page.Width, page.Height),
                           XStringFormats.TopCenter);

            // Add additional text or information here as needed
            gfx.DrawString("1. Follow safety protocols.\n2. Respect deadlines.\n3. Abide by company values.",
                           new XFont("Verdana", 12, XFontStyle.Regular),
                           XBrushes.Black, new XRect(40, 60, page.Width, page.Height),
                           XStringFormats.TopLeft);

            // Save the PDF file to a path (in this case, saving to the project directory)
            string filePath = "regulations.pdf";
            pdf.Save(filePath);

            // Inform the user of the generated PDF file
            MessageBox.Show($"The regulations PDF has been created at: {filePath}", "PDF Created",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
