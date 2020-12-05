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
    public partial class MorphologyForm : Form
    {
        private Image<Bgr, Byte> _inputImage;
        private int _coefOfOperation;
        public MorphologyForm()
        {
            InitializeComponent();
        }

        public MorphologyForm(Image<Bgr, Byte> inputImage, int coef)
        {
            _inputImage = inputImage;
            _coefOfOperation = coef;
            InitializeComponent();
        }

        public void Dilatate()
        {
            if(_inputImage == null)
            {
                return;
            }
            morphologyLabel.Text = "Dilatation";
            imageBox1.Image = _inputImage.Dilate(_coefOfOperation);
        }

        public void Erosion()
        {
            if (_inputImage == null)
            {
                return;
            }
            morphologyLabel.Text = "Erosion";
            imageBox1.Image = _inputImage.Erode(_coefOfOperation);
        }

        public void OpenImage()
        {
            if (_inputImage == null)
            {
                return;
            }
            morphologyLabel.Text = "Opening image";
            imageBox1.Image = _inputImage.Erode(_coefOfOperation);
            imageBox1.Image = _inputImage.Dilate(_coefOfOperation);
        }

        public void CloseImage()
        {
            if (_inputImage == null)
            {
                return;
            }
            morphologyLabel.Text = "Closing image";
            imageBox1.Image = _inputImage.Dilate(_coefOfOperation);
            imageBox1.Image = _inputImage.Erode(_coefOfOperation);
        }

        private void MorphologyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
