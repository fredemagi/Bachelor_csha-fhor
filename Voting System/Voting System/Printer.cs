using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Printing;

using System.Windows.Forms;
using System.Drawing;

namespace Voting_System
{
    public class Printer
    {
        
        private string _output;
        private PaperSize _size = new PaperSize("Custom", 800, 200);


        /// <summary>
        /// Set output.
        /// </summary>
        /// <param name="output">Path of output to be set.</param>
        public void SetOutput(string output)
        {
            _output = output;
        }


    
        /// <summary>
        /// Print a string (in this case to the screen).
        /// </summary>
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
        

        private void PrintVoteEvent(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(_output, new Font("Courier New", 32), Brushes.Black, 20, 20);
        }

    }
}
