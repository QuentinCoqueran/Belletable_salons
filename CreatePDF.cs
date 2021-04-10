using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.IO;

namespace ppe1
{
    class CreatePDF
    {
        public static void generatePDF()
        {
            PdfDocument document = new PdfDocument();

            document.Info.Title = "Quentin 1 PDF";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Code 128", 20);
            gfx.DrawString("informations de l'utilisateur", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);
            const string filename = "BadgeUtilisateur.pdf";
            document.Save(filename);
            Process.Start(filename);
        }
    }
}
