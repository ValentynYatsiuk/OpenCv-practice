using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace OpenCvLabs
{
    public partial class SplitToChanelsForm : Form
    {
        private readonly OpenFileDialog _openFileDialog;

        public SplitToChanelsForm()
        {
            InitializeComponent();
        }

        public SplitToChanelsForm(OpenFileDialog inputImage)
        {
            _openFileDialog = inputImage;
            InitializeComponent();
            splitImageIntoChannels();
        }

        public void splitImageIntoChannels()
        {
            if (!string.IsNullOrEmpty(_openFileDialog.FileName))
            {
                var img = new Image<Bgra, Byte>(_openFileDialog.FileName);
                Image<Bgra, Byte> blue = img.Copy();
                Image<Bgra, Byte> green = img.Copy();
                Image<Bgra, Byte> red = img.Copy();
                Bgra tmp;
                Bgra save;

                for (int ii = 0; ii < img.Height; ii++)
                {
                    for (int jj = 0; jj < img.Width; jj++)
                    {
                        tmp = img[ii, jj];
                        save = tmp;

                        // Red channel.

                        if (tmp.Red == 255)
                        {
                            tmp.Blue = tmp.Green = 255;
                        }
                        else if (tmp.Red == 0)
                        {
                            tmp.Blue = tmp.Green = 0;
                        }
                        else if (tmp.Red < 128)
                        {
                            tmp.Blue = tmp.Green = tmp.Red / 2;
                        }

                        red[ii, jj] = tmp;

                        // Green channel.

                        tmp = save;

                        if (tmp.Green == 255)
                        {
                            tmp.Blue = tmp.Red = 255;
                        }
                        else if (tmp.Green == 0)
                        {
                            tmp.Blue = tmp.Red = 0;
                        }
                        else if (tmp.Green < 128)
                        {
                            tmp.Blue = tmp.Red = tmp.Green / 2;
                        }

                        green[ii, jj] = tmp;

                        // Blue channel.

                        tmp = save;

                        if (tmp.Blue == 255)
                        {
                            tmp.Green = tmp.Red = 255;
                        }
                        else if (tmp.Blue == 0)
                        {
                            tmp.Green = tmp.Red = 0;
                        }
                        else if (tmp.Blue < 128)
                        {
                            tmp.Green = tmp.Red = tmp.Blue / 2;
                        }

                        blue[ii, jj] = tmp;
                    }
                    imageBox1.Image = red;
                    imageBox2.Image = green;
                    imageBox3.Image = blue;
                }
            }
        }

        private void SplitToChanelsForm_Load(object sender, EventArgs e)
            {

            }
        }
    }

