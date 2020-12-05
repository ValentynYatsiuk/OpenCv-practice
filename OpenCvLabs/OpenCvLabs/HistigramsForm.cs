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
    public partial class HistigramsForm : Form
    {
        private Image<Bgr, Byte> _inputImage;
        private Image<Gray, Byte> _r;
        private Image<Gray, Byte> _g;
        private Image<Gray, Byte> _b;
        public HistigramsForm(Image<Bgr, Byte> inputImage)
        {
            _inputImage = inputImage;
            _r = _inputImage[2];
            _g = _inputImage[1];
            _b = _inputImage[0];
            InitializeComponent();

        }

        public HistigramsForm()
        {
            InitializeComponent();
        }

        public void DrawHistograms()
        {
            DenseHistogram rDense = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            rDense.Calculate(new Image<Gray, byte>[] { _r }, false, null);
            Mat mr = new Mat();
            rDense.CopyTo(mr);

            DenseHistogram gDense = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            gDense.Calculate(new Image<Gray, byte>[] { _g }, false, null);
            Mat mg = new Mat();
            gDense.CopyTo(mg);

            DenseHistogram bDense = new DenseHistogram(256, new RangeF(0.0f, 255.0f));
            bDense.Calculate(new Image<Gray, byte>[] { _b }, false, null);
            Mat mb = new Mat();
            bDense.CopyTo(mb);

            histogramBox1.ClearHistogram();
            histogramBox2.ClearHistogram();
            histogramBox3.ClearHistogram();

            histogramBox1.AddHistogram("RED", Color.Red, mr, 256, new float[] { 0f, 255f });
            histogramBox2.AddHistogram("GREEN", Color.Green, mg, 256, new float[] { 0f, 255f });
            histogramBox3.AddHistogram("BLUE", Color.Blue, mb, 256, new float[] { 0f, 255f });

            //histogramBox1.Dock = DockStyle.Fill;
            //histogramBox2.Dock = DockStyle.Fill;
            //histogramBox3.Dock = DockStyle.Fill;


            histogramBox1.Refresh();
            histogramBox2.Refresh();
            histogramBox3.Refresh();

            _inputImage.Split();
        }
        private void HistigramsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
