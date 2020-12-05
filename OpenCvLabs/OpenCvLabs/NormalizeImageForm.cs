using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace OpenCvLabs
{
    public partial class NormalizeImageForm : Form
    {
        private readonly Image<Bgr, Byte> _inputImage;
        public NormalizeImageForm()
        {
            InitializeComponent();
        }
        
        public NormalizeImageForm(Image<Bgr, Byte> inputImage)
        {
            _inputImage = inputImage;
            InitializeComponent();
        }

        public void NormalizeImage()
        {
            Image<Gray, Byte> imageL = _inputImage[1];
            imageL._EqualizeHist();
            _inputImage[1] = imageL;

            imageBox1.Image = _inputImage[1];
            histogramBox1.ClearHistogram();
            histogramBox1.GenerateHistograms(imageL, 255);
            histogramBox1.Refresh();
        }

        public void Equalize()
        {
            Image<Gray, Byte> imageL = _inputImage[1];
            imageL._EqualizeHist();
            imageL._GammaCorrect(1.8d);
            imageBox1.Image = imageL;
            histogramBox1.ClearHistogram();
            histogramBox1.GenerateHistograms(imageL, 255);
            histogramBox1.Refresh();
        }

        private void NormalizeImageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
