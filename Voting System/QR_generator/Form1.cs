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

namespace QR_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void generate_button_Click(object sender, EventArgs e)
        {
            var path = path_textbox.Text;
            var encoder = new QRCodeEncoder();
            var code = encoder.Encode(path);
            pictureBox1.Image = code;
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG|*.png|JPEG|*.jpeg|BMP|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }
        
    }
}
