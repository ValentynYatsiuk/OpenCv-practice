using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace OpenCvLabs
{
    public partial class Form1 : Form
    {
        private OpenFileDialog _openFileDialog;
        private Image<Bgr, Byte> _inputImage;

        Mat srcImage = new Mat(), dstImage = new Mat();
        Mat map_x = new Mat(), map_y = new Mat();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            ErosionButton.Enabled = false;
            DilatateButton.Enabled = false;
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _openFileDialog = new OpenFileDialog();
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _inputImage = new Image<Bgr, Byte>(_openFileDialog.FileName);
                //_inputImage._SmoothGaussian(1, 1, 31.1, 0.2);
                imageBox1.Image = _inputImage;
                srcImage = _inputImage.Mat;
                // Create the same effect image as the original image, x remap, y remap
                dstImage.Create(srcImage.Rows, srcImage.Cols, srcImage.Depth, srcImage.NumberOfChannels);
                map_x.Create(srcImage.Rows, srcImage.Cols, DepthType.Cv32F, 1);
                map_y.Create(srcImage.Rows, srcImage.Cols, DepthType.Cv32F, 1);
            }

            if (_inputImage != null)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                ErosionButton.Enabled = true;
                DilatateButton.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _inputImage._SmoothGaussian(1, 1, 0.1, 0.2);
            NormalizeImageForm normalize = new NormalizeImageForm(_inputImage);
            normalize.Show();
            normalize.NormalizeImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_inputImage != null)
            {
                HistigramsForm histigramsForm = new HistigramsForm(_inputImage);
                histigramsForm.Show();
                histigramsForm.DrawHistograms();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SplitToChanelsForm splitToChanels = new SplitToChanelsForm(_openFileDialog);
            splitToChanels.Show();
        }

        private void eroziumCoef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dilatateCoef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ErosionButton_Click(object sender, EventArgs e)
        {
            var morfForm = new MorphologyForm(_inputImage, Convert.ToInt32(eroziumCoef.Text));
            morfForm.Show();
            morfForm.Erosion();

        }

        private void DilatateButton_Click(object sender, EventArgs e)
        {
            var morfForm = new MorphologyForm(_inputImage, Convert.ToInt32(dilatateCoef.Text));
            morfForm.Show();
            morfForm.Dilatate();
        }

        #region GaussSBLUR

        // fubction to do gauss blur for 100+ pictures
        //private void button5_Click(object sender, EventArgs e)
        //{
        //    if (_inputImage == null)
        //    {
        //        return;
        //    }

        //    var imageWidth = _inputImage.Size.Width;
        //    var imageHeighth = _inputImage.Size.Height;
        //    if (imageWidth % 2 == 0)
        //    {
        //        imageWidth++;
        //    }

        //    if (imageHeighth % 2 == 0)
        //    {
        //        imageHeighth++;
        //    }

        //    var sizee = new Size(imageWidth, imageHeighth);

        //    double sigmaX = 0.001;
        //    double sigmaY = 0.001;

        //    //CvInvoke.GaussianBlur(_inputImage, _inputImage, sizee, sigmaX, sigmaY);

        //    int count = 0;
        //    for (double i = 0; i < 1; i += 0.005)
        //    {
        //        //var oldImage = imageBox2.Image;
        //        sigmaX += i;
        //        sigmaY += i;
        //        CvInvoke.GaussianBlur(imageBox1.Image, _inputImage, sizee, sigmaX, sigmaY);
        //        //oldImage.Dispose();
        //        //imageBox2.Image = _inputImage;
        //        _inputImage.Bitmap.Save($"image{count}.bmp");
        //        count++;
        //    }
        //}

        #endregion

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            update_map(e.KeyCode);
            CvInvoke.Remap(srcImage, dstImage, map_x, map_y, Inter.Linear);
            imageBox2.Image = dstImage;
        }

        // Paint contour of GOLF BALLS
        private void button5_Click(object sender, EventArgs e)
        {
            if (_inputImage == null)
            {
                return;
            }

            var mainImage = _inputImage;
            // get binary mask of _input image
            var image = GetRedPixelMask(_inputImage);
            // removes pixels on object boundaries.
            image.Erode(2);
            // connecting areas that are separated by spaces
            image.Dilate(2);

            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(image, contours, null, RetrType.External,
                    ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {
                        CircleF circle = CvInvoke.MinEnclosingCircle(contour);
                        var arr = circle.Area;
                        if (arr > 1000)
                        {
                            CvInvoke.Circle(mainImage, new Point((int) circle.Center.X, (int) circle.Center.Y),
                                (int) circle.Radius, new MCvScalar(255, 0, 255, 235), 2);
                        }
                        imageBox2.Image = mainImage;
                    }
                }
            }
        }

        private Image<Gray, Byte> GetRedPixelMask(Image<Bgr, byte> image)
        {
            using (Image<Hsv, Byte> hsv = image.Convert<Hsv, Byte>())
            {
                Image<Gray, Byte>[] channels = hsv.Split();
                try
                {
                    //channels[0] is the mask for hue less than 80 or larger than 180
                    CvInvoke.InRange(channels[0], new ScalarArray(new MCvScalar(80)), new ScalarArray(new MCvScalar(180)), channels[0]);
                    channels[0]._Not();
                    
                    //channels[1] is the mask for satuation of at least 10, this is mainly used to filter out white pixels
                    channels[1]._ThresholdBinary(new Gray(0), new Gray(255));
                    
                    // Convert image to binary
                    CvInvoke.BitwiseAnd(channels[0], channels[1], channels[1]);
                   
                    channels[1]._Not();
                   
                }
                finally
                {
                    channels[0].Dispose();
                    channels[2].Dispose();
                }
                return channels[1];
            }
        }

        // Paint contour of GOLF BALLS
        
        private void openButton_Click(object sender, EventArgs e)
        {
            var morfForm = new MorphologyForm(_inputImage, 1);
            morfForm.Show();
            morfForm.OpenImage();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            var morfForm = new MorphologyForm(_inputImage, 1);
            morfForm.Show();
            morfForm.CloseImage();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NormalizeImageForm normalize = new NormalizeImageForm(_inputImage);
            normalize.Show();
            normalize.Equalize();
        }

        // Пользовательская функция, обновляем значения map_x и map_y в соответствии с ключом
        void update_map(Keys key)
        {
            unsafe
            {
                // Определяем указатель типа float *, указывающий на первые адреса map_x и map_y
                float* ptr_to_map_x = (float*)map_x.DataPointer;
                float* ptr_to_map_y = (float*)map_y.DataPointer;

                int step = srcImage.Cols;

                // Двухслойный цикл, проходим каждый пиксель
                for (int i = 0; i < srcImage.Rows; i++)
                {
                    for (int j = 0; j < srcImage.Cols; j++)
                    {
                        switch (key)
                        {
                            // Если нажата клавиша [1] на клавиатуре, операция «длина и ширина изображения уменьшаются до половины оригинала и отображаются в центре»
                            case Keys.D1:
                                if (i > srcImage.Rows * 0.25 && i < srcImage.Rows * 0.75 &&
                                    j > srcImage.Cols * 0.25 && j < srcImage.Cols * 0.75)
                                {
                                    ptr_to_map_x[i * step + j] = (float)(2 * j - srcImage.Cols / 2 + 0.5);
                                    ptr_to_map_y[i * step + j] = (float)(2 * i - srcImage.Rows / 2 + 0.5);
                                }
                                else
                                {
                                    ptr_to_map_x[i * step + j] = 0;
                                    ptr_to_map_y[i * step + j] = 0;
                                }
                                break;
                            // Если нажата клавиша [2] на клавиатуре, выполняется операция «переворачивание изображения вверх и вниз»
                            case Keys.D2:
                                ptr_to_map_x[i * step + j] = j;
                                ptr_to_map_y[i * step + j] = srcImage.Rows - i;
                                break;
                            // Если нажата клавиша [3] на клавиатуре, выполняется операция «пролистать влево и вправо».
                            case Keys.D3:
                                ptr_to_map_x[i * step + j] = srcImage.Cols - j;
                                ptr_to_map_y[i * step + j] = i;
                                break;
                            // Если нажата клавиша [4] на клавиатуре, выполнить операцию «Перевернуть изображение вверх ногами, влево и вправо»
                            case Keys.D4:
                                ptr_to_map_x[i * step + j] = srcImage.Cols - j;
                                ptr_to_map_y[i * step + j] = srcImage.Rows - i;
                                break;
                        }
                    }
                }
            }
        }

    }
}
