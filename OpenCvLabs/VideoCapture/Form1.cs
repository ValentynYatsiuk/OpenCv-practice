using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace VideoCapture
{
    public partial class Form1 : Form
    {
        private Emgu.CV.VideoCapture _capture = null;
        private bool _captureInProgress;
        private Mat _frame;

        private string facePath;
        private CascadeClassifier face;
        private Rectangle[] faceDetected;

        private int tick_count = 0;

        public Form1()
        {
            facePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "haarcascade_frontalface_default.xml");
            face = new CascadeClassifier(facePath);

            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                _capture = new Emgu.CV.VideoCapture(2);
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            _frame = new Mat();
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);
            }
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            tick_count++;

            var dstMat = new Mat();
            var frame = _capture.QueryFrame();
            CvInvoke.Resize(frame, dstMat, new Size(640, 480), interpolation: Inter.Cubic);
            Image<Bgr, Byte> currentframe = dstMat.ToImage<Bgr, byte>();

            if (tick_count == 1 || tick_count > 5)
            {
                detectFace(currentframe);

                if (tick_count != 1)
                {
                    tick_count = 0;
                }
            }
            else
            {
                foreach (Rectangle faceFound in faceDetected)
                {
                    currentframe.Draw(faceFound, new Bgr(Color.Cyan), 2);
                }
                imageBox1.Image = currentframe;
            }
        }

        private void detectFace(Image<Bgr, Byte> currentframe)
        {
            if (currentframe != null)
            {
                using (Image<Gray, byte> grayFrame = currentframe.Convert<Gray, Byte>())
                {
                    faceDetected = face.DetectMultiScale(grayFrame, 1.1, 10, Size.Empty, Size.Empty);
                    foreach (Rectangle faceFound in faceDetected)
                    {
                        currentframe.Draw(faceFound, new Bgr(Color.Cyan), 2);
                    }

                    var oldImage = imageBox1.Image;
                    imageBox1.Image = currentframe;

                    if (oldImage != null)
                    {
                        oldImage.Dispose();
                    }
                    currentframe.Dispose();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {  //stop the capture
                    button1.Text = "Stop Face Capture";
                    timer1.Enabled = true;
                   timer1.Start();
                    _capture.Pause();
                }
                else
                {
                    //start the capture
                    timer1.Enabled = false;
                    button1.Text = "Start Face Capture";
                    timer1.Stop();
                    _capture.Start();
                }

                _captureInProgress = !_captureInProgress;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _capture.FlipHorizontal = !_capture.FlipHorizontal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
