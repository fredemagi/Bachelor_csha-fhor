using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Printer printer = new Printer();
            printer.SetOutput("Helle Thorning Schmidt [ A ]");
            printer.Print();

            Image qr = Image.FromFile("C:/Users/SATLP850132/Pictures/336739.jpg");
            printer.SetQR(qr);
            printer.PrintQR();
        }
    }
}
