using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Printing;

using System.Windows.Forms;
using System.Drawing;


//For documentation for this class, see project "Voting System".

namespace Voting_System
{
    public class Printer
    {
        // adjust picture to paper
        // print QR code
        // print vote

        private Image _QRcode;
        private string _output;
        private string _printer;
        private PaperSize _size = new PaperSize("Custom", 800, 200);
        private PaperSize _sizeQR = new PaperSize("Custom QR", 2200, 1200);

        public void SetQR(Image QRcode)
        {
            _QRcode = QRcode;
        }

        public void SetOutput(string output)
        {
            _output = output;
        }

        public void SetPrinter(string printer)
        {
            _printer = printer;
        }

        private Image BitmapToImage(Bitmap bmp)
        {
            Image img = (Image)bmp;
            return img;
        }

        public void Print()
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Ballot Marker Vote Print";
            pd.DefaultPageSettings.PaperSize = _size;

            pd.PrintPage += new PrintPageEventHandler(PrintVoteEvent);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();

        }

        public void PrintQR()
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "QR Code Print";
            pd.DefaultPageSettings.PaperSize = _sizeQR;

            pd.PrintPage += new PrintPageEventHandler(PrintQREvent);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        private void PrintVoteEvent(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(_output, new Font("Courier New", 32), Brushes.Black, 20, 20);
        }

        private void PrintQREvent(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_QRcode, new Point(10, 10));
        }
    }
}
