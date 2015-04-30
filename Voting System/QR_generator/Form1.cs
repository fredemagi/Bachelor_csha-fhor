using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using Voting_System;

namespace QR_generator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes an instance of the QR Generator.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            path_textbox.Text = "";
            generate_button.Enabled = false;
            save_button.Enabled = false;
            print_qr_code_button.Enabled = false;
        }

        
        /// <summary>
        /// Generates a QR code based on the input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_button_Click(object sender, EventArgs e)
        {
            var path = path_textbox.Text;
            var encoder = new QRCodeEncoder();
            var code = encoder.Encode(path);
            pictureBox1.Image = code;
            save_button.Enabled = true;
            print_qr_code_button.Enabled = true;
        }


        /// <summary>
        /// Save a QR code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG|*.png|JPEG|*.jpeg|BMP|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }


        /// <summary>
        /// Print a QR code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_qr_code_button_Click(object sender, EventArgs e)
        {
            Printer printer = new Printer();
            printer.SetQR(pictureBox1.Image);
            printer.PrintQR();
        }


        /// <summary>
        /// Enables generate-button when textbox is not empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void path_textbox_TextChanged(object sender, EventArgs e)
        {
            if (path_textbox.Text != "")
            {
                generate_button.Enabled = true;
            }

            else
            {
                generate_button.Enabled = false;
            }
            
        }
        
    }
}




