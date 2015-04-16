using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using MessagingToolkit.QRCode.Codec;

using System.Windows.Forms;

namespace Voting_System.Backend
{
    class Scanner
    {
        public void Encode(string path)
        {
            //"C:/Users/SATLP850132/Desktop/election15.txt"
            var code = File.ReadAllText(path);
            QRCodeEncoder enc = new QRCodeEncoder();
            Bitmap qrcode = enc.Encode(code);

            PictureBox pb = new PictureBox();
            pb.Image = qrcode as Image;
            pb.Show();
        }

        public void Decode()
        {
        }
    }
}
