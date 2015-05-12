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
       
        private Image _QRcode;
        private PaperSize _sizeQR = new PaperSize("Custom QR", 200, 200);


        /// <summary>
        /// Setting QR code.
        /// </summary>
        /// <param name="QRcode"></param>
        public void SetQR(Image QRcode)
        {
            _QRcode = QRcode;
        }


        /// <summary>
        /// Print QR code.
        /// </summary>
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

        private void PrintQREvent(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_QRcode, new Point(10, 10));
        }
    }
}
