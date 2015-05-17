using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class Login_scanner_window : Form
    {

        private IBarcodeReader _barcodeReader;
        private WebCamera _webCamera;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _mediaConnector;
        private ImageProcesserHandler _imageProcesserHandler;
        private FrameCapture _frameCapture;
        private List<DetectedBarcode> _barcodelist; 
        private string path;

        private Voting_Screen v;
        
        /// <summary>
        /// Initializes components for login-scanner-window and components for webcam-use.
        /// </summary>
        public Login_scanner_window()
        {
            InitializeComponent();
            
            _imageProvider = new DrawingImageProvider();
            _mediaConnector = new MediaConnector();
            _barcodeReader = ImageProcesserFactory.CreateBarcodeReader();
            _imageProcesserHandler = new ImageProcesserHandler();
            _frameCapture = new FrameCapture();
            _barcodelist = new List<DetectedBarcode>();
            _videoViewer.BackColor = Color.Black;
            state_textbox.Text = "OFFLINE";
            state_textbox.TextAlign = HorizontalAlignment.Center;
            detectStatus_textbox.Text = "SØGER IKKE";
            detectStatus_textbox.TextAlign = HorizontalAlignment.Center;
            disconnect_button.Enabled = false;
        }


        /// <summary>
        /// Connect to the webcam and detect QR codes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            _webCamera = WebCamera.GetDefaultDevice();
            connect_button.Enabled = false;
            disconnect_button.Enabled = true;

            if (_webCamera != null)
            {
                //Setup webcam.
                _mediaConnector.Connect(_webCamera, _imageProvider);
                _videoViewer.SetImageProvider(_imageProvider);
                _webCamera.Start();
                _videoViewer.Start();
                state_textbox.Text = @"ONLINE";
                detectStatus_textbox.Text = @"SØGER EFTER QR KODE";

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
                    MessageBox.Show(@"Der opstod en fejl: " + ex.Message);
                }

            }

            else
            {
                MessageBox.Show(@"Kunne ikke finde et webcam. Sørg for, at det er 
                installeret korrekt og sat til og prøv så igen", @"Der opstod en fel!");

            }
        }


        /// <summary>
        /// Disconnect to webcam.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disconnect_button_Click(object sender, EventArgs e)
        {
            disconnect_button.Enabled = false;
            connect_button.Enabled = true;
            state_textbox.Text = "OFFLINE";
            detectStatus_textbox.Text = "";
            DisconnectCamera();
            
        }


        /// <summary>
        /// Occurs when a barcode has been detected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarcodeReaderOnDetectionOccurred(object sender, BarcodeDetectedEventArgs e)
        {
            
            InvokeVotingScreen(() =>
        {
            if (e == null)
            {
                return;
            }

            DisconnectCamera();
            _barcodelist.Add(e.DetectedBarcode);
            var element = _barcodelist.Last();
            path = element.Content;

            try
            {
                _barcodelist.Clear();
                List<StringValue> lst = new List<StringValue>();
                UTF8Encoding utf8 = new UTF8Encoding();

                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        var temp = utf8.GetString(utf8.GetBytes(line));
                        lst.Add(new StringValue(temp));
                    }
                }
               
                
                this.Hide();
                Voting_Screen.getInstance().list = lst;
                Voting_Screen.getInstance().Sourcelist();
                Voting_Screen.getInstance().ShowDialog();

                this.Dispose();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(@"Forkert QR kode. Prøv igen eller kontakt en administrator.", @"Der opstod en fejl!");
            }
                

        });
            
        }


        /// <summary>
        /// Inner class that serves as holding a line containg information about party name and letter from a file.
        /// </summary>
        public class StringValue
        {
            public StringValue(string s)
            {
                _value = s;
            }
            public string Value { get { return _value; } set { _value = value; } }
            string _value;
        }


        /// <summary>
        /// Helper method for executing embedded method using a lampba expression. This is to ensure that no errors occur. 
        /// </summary>
        /// <param name="action">Embedded method to be called when this method is called.</param>
        private void InvokeVotingScreen(Action action)
        {
            BeginInvoke(action);
        }


        /// <summary>
        /// Helper method to disconnect webcam.
        /// </summary>
        private void DisconnectCamera()
        {
            _mediaConnector.Disconnect(_webCamera, _imageProvider);
            _webCamera.Stop();
            _videoViewer.Stop();
        }
    }   
 }
    

