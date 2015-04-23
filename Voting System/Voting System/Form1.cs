using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozeki.Media.MediaHandlers;
using Ozeki.Media.MediaHandlers.Video;
using Ozeki.Media.MediaHandlers.Video.CV;
using Ozeki.Media.MediaHandlers.Video.CV.BarcodeData;
using Ozeki.Media.MediaHandlers.Video.CV.ImageTools;
using Ozeki.Media.Video.Controls;

namespace Voting_System
{
    public partial class Form1 : Form
    {

        private IBarcodeReader _barcodeReader;
        private WebCamera _webCamera;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _mediaConnector;
        private List<DetectedBarcode> _barcodesList;
        private ImageProcesserHandler _imageProcesserHandler;
        private FrameCapture _frameCapture;
        private Object _lock = new Object();
        


        public Form1()
        {
            InitializeComponent();

           
            
            _imageProvider = new DrawingImageProvider();
            _mediaConnector = new MediaConnector();
            _barcodeReader = ImageProcesserFactory.CreateBarcodeReader();
            _barcodesList = new List<DetectedBarcode>();
            _imageProcesserHandler = new ImageProcesserHandler();
            _frameCapture = new FrameCapture();
            _barcodesList = new List<DetectedBarcode>();
            _videoViewer.BackColor = Color.Black;
            state_textbox.Text = "OFFLINE";
            state_textbox.TextAlign = HorizontalAlignment.Center;
            detectStatus_textbox.Text = "NOT DETECTING";
            detectStatus_textbox.TextAlign = HorizontalAlignment.Center;
            disconnect_button.Enabled = false;
            startDetecting_button.Enabled = false;
            
        }



       

        private void button1_Click(object sender, EventArgs e)
        {
            //Koden nedenunder skal bruges til at gemme QC scanneren og åbne Voting-formen
            //this.Hide();    
            //var vs = new Voting_Screen();
            //vs.ShowDialog();
            
            _webCamera = WebCamera.GetDefaultDevice();
            connect_button.Enabled = false;
            disconnect_button.Enabled = true;
            startDetecting_button.Enabled = true;
            

            if (_webCamera != null)
            {
                _mediaConnector.Connect(_webCamera, _imageProvider);
                _videoViewer.SetImageProvider(_imageProvider);
                _webCamera.Start();
                _videoViewer.Start();
                state_textbox.Text = "ONLINE";
            }

            else
            {
                MessageBox.Show("Couldn't find a webcam. Make sure you have installed the driver correctly," +
                                " or plugged in the webcam and then try again.", "Error!");

            }
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            disconnect_button.Enabled = false;
            startDetecting_button.Enabled = false;
            connect_button.Enabled = true;
            state_textbox.Text = "OFFLINE";
            detectStatus_textbox.Text = "";
            DisconnectCamera();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            detectStatus_textbox.Text = "DETECTING QR CODE";
            
            try
            {
                
                _barcodeReader.DetectionOccurred += BarcodeReaderOnDetectionOccurred;

                _imageProcesserHandler.AddProcesser(_barcodeReader);
                _frameCapture.SetInterval(5);
                _mediaConnector.Connect(_webCamera, _frameCapture);
                _mediaConnector.Connect(_frameCapture, _imageProcesserHandler);
                _frameCapture.Start();

            }

            catch (Exception ex)
            {
                MessageBox.Show(@"Error occured: " + ex.Message);
            }





           /* Printer printer = new Printer();
            printer.SetOutput("Helle Thorning Schmidt [ A ]");
            printer.Print();

            Image qr = Image.FromFile("C:/Users/SATLP850132/Pictures/336739.jpg");
            printer.SetQR(qr);
            printer.PrintQR();*/

        }

        private void BarcodeReaderOnDetectionOccurred(object sender, BarcodeDetectedEventArgs e)
        {
            
            InvokeVotingScreen(() =>
        {
            if (e == null)
            {
                return;
            }


            _barcodesList.Add(e.DetectedBarcode);

            var element = _barcodesList.First();


            if(element.Content.Contains("http://www.youtube.com"))  //SKAL ÆNDRES TIL VALIDERING GENERELT!
            {       
                DisconnectCamera();
                _barcodesList.Clear();
                MessageBox.Show("Detection successful. You will now be directed to the Voting Screen.", "QR found!");
                this.Hide();
                var v = new Voting_Screen();
                v.ShowDialog();
            }

            
                

           
        });


        


        }

        private void InvokeVotingScreen(Action action)
        {
            BeginInvoke(action);
        }


        private void DisconnectCamera()
        {
            _mediaConnector.Disconnect(_webCamera, _imageProvider);
            _webCamera.Stop();
            _videoViewer.Stop();
        }

    }
           
            
           // System.Diagnostics.Process.Start(bla.Content);  <-- Hvis der skal åbnes en browser fra QR link
            
            
            
 }
    

