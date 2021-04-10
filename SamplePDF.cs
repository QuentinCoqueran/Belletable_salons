using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.IO;

namespace ppe1
{
    public partial class SamplePDF : Form
    {
        public SamplePDF()
        {
            InitializeComponent();
            create();
        }

        static void create()
        {
            PdfDocument document = new PdfDocument();

            document.Info.Title = "Dylan 1 PDF";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            gfx.DrawString("informations de l'utilisateur", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);
            const string filename = "BadgeUtilisateur.pdf";

            document.Save(filename);

            Process.Start(filename);
        }
    }
}
