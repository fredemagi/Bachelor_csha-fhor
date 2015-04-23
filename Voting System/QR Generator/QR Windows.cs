using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Generator
{
    public partial class QR_Windows : Form
    {
        public QR_Windows()
        {
            InitializeComponent();
        }


        public static void Main(string[] args)
        {
            QR_Windows qr = new QR_Windows();
            qr.InitializeComponent();
        }
    }
}
