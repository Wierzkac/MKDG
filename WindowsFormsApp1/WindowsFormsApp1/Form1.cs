using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainApplication : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;
        private delegate void EventHandle();
        private double[][] histogram;
        private int histogramWidth, histogramHeight;

        double shortPrimitiveEmphasis = 0;
        double longPrimitiveEmphasis = 0;
        double greyLevelUniformity = 0;
        double primitiveLengthUniformity = 0;
        double primitivePercentage = 0;

        string directionOfAnalisys;

        public MainApplication()
        {
            InitializeComponent();
            directionComboBox.SelectedIndex = 0;
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(open.FileName);
                originalPictureBox.Image = originalImage;
                processingPictureBox.Image = null;
                processButton.Enabled = true;
                histogramButton.Enabled = false;
                summaryButton.Enabled = false;
                ResetParameters();
            }
        }
        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null || directionComboBox.Text == "")
                return;
            processedImage = new Bitmap(originalImage);
            directionComboBox.Enabled = false;
            treshholdUpDown.Enabled = false;
            histogramButton.Enabled = false;
            summaryButton.Enabled = false;
            processButton.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            Thread thr = new Thread(() =>
            {
                ConvertToGreyScale(processedImage);

                Thread.Sleep(1000);

                TreshholdImage(processedImage);

                Thread.Sleep(1000);

                CalculateHistogram(processedImage);

                CalculateParameters();

                this.Invoke((MethodInvoker)delegate ()
                {
                    histogramButton.Enabled = true;
                    summaryButton.Enabled = true;
                    directionComboBox.Enabled = true;
                    treshholdUpDown.Enabled = true;
                    histogramButton.Enabled = true;
                    summaryButton.Enabled = true;
                    processButton.Enabled = true;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                });
            });
            thr.Start();
        }
        private void summaryButton_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(() =>
            {
                SummaryForm summary = new SummaryForm(originalImage, processedImage, histogramWidth, histogramHeight, histogram, shortPrimitiveEmphasis, longPrimitiveEmphasis, greyLevelUniformity, primitiveLengthUniformity, primitivePercentage, directionOfAnalisys);
                summary.ShowDialog();
            });
            thr.Start();
        }
        private void ShowHistogram()
        {
            if (histogram == null || histogramHeight == 0 || histogramWidth == 0)
                return;
            Form2 histogramForm = new Form2(histogramWidth, histogramHeight, histogram);
            histogramForm.ShowDialog();
        }
        private void CalculateParameters()
        {
            shortPrimitiveEmphasis = 0;
            longPrimitiveEmphasis = 0;
            greyLevelUniformity = 0;
            primitiveLengthUniformity = 0;
            primitivePercentage = 0;

            double K = 0;
            for (int i = 0; i < histogramHeight; i++)
                for (int j = 0; j < histogramWidth; j++)
                    K += histogram[i][j];

            //Short primitive emphasis
            for (int i = 0; i < histogramHeight; i++)
                for (int j = 0; j < histogramWidth; j++)
                    shortPrimitiveEmphasis += histogram[i][j] / ((j + 1) * (j + 1));
            shortPrimitiveEmphasis /= K;

            //Long primitive emphasis
            for (int i = 0; i < histogramHeight; i++)
                for (int j = 0; j < histogramWidth; j++)
                    longPrimitiveEmphasis += (double)histogram[i][j] * ((j + 1) * (j + 1));
            longPrimitiveEmphasis /= K;

            //Gray-level uniformity
            for (int i = 0; i < histogramHeight; i++)
            {
                double tmp = 0;
                for (int j = 0; j < histogramWidth; j++)
                    tmp += histogram[i][j];
                greyLevelUniformity += tmp * tmp;
            }
            greyLevelUniformity /= K;

            //Primitive length uniformity
            for (int j = 0; j < histogramWidth; j++)
            {
                double tmp = 0;
                for (int i = 0; i < histogramHeight; i++)
                    tmp += histogram[i][j];
                primitiveLengthUniformity += tmp * tmp;
            }
            primitiveLengthUniformity /= K;

            //Primitive percentage
            for (int i = 0; i < histogramHeight; i++)
                for (int j = 0; j < histogramWidth; j++)
                    primitivePercentage += histogram[i][j] * (j + 1);
            primitivePercentage = K / primitivePercentage * 100;

            this.Invoke((MethodInvoker)delegate ()
            {
                WriteParametersToLabels();
            });
        }
        private void CalculateHistogram(Bitmap image)
        {
            var rect = new Rectangle(0, 0, image.Width, image.Height);
            var data = image.LockBits(rect, ImageLockMode.ReadWrite, image.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8;
            var buffer = new byte[data.Width * data.Height * depth];
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);

            int numberOfTreshholds = (int)treshholdUpDown.Value;
            histogramHeight = numberOfTreshholds;
            histogram = new double[histogramHeight][];
            directionOfAnalisys = "";
            int firstCounter = 0, secondCounter = 0;
            this.Invoke((MethodInvoker)delegate ()
            {
                directionOfAnalisys = directionComboBox.Text;
            });
            for (int i = 0; i < numberOfTreshholds; i++)
            {
                if (directionOfAnalisys == "pionowa")
                {
                    firstCounter = data.Width;
                    secondCounter = data.Height;
                    histogramWidth = image.Height;
                    histogram[i] = new double[image.Height];
                    for (int j = 0; j < image.Height; j++)
                    {
                        histogram[i][j] = 0;
                    }
                }
                else if (directionOfAnalisys == "pozioma")
                {
                    firstCounter = data.Height;
                    secondCounter = data.Width;
                    histogramWidth = image.Width;
                    histogram[i] = new double[image.Width];
                    for (int j = 0; j < image.Width; j++)
                    {
                        histogram[i][j] = 0;
                    }
                }
                else if (directionOfAnalisys == "w obu kierunkach")
                {
                    firstCounter = data.Height;
                    secondCounter = data.Width;
                    int tmp = Math.Max(image.Width, image.Height);
                    histogramWidth = tmp;
                    histogram[i] = new double[tmp];
                    for (int j = 0; j < tmp; j++)
                    {
                        histogram[i][j] = 0;
                    }
                }
            }
            double max = 0;

            for (int i = 0; i < firstCounter; i++)
            {
                int value = -1;
                int length = 0;
                for (int j = 0; j < secondCounter; j++)
                {
                    int offset = 0;
                    if (directionOfAnalisys == "pionowa")
                        offset = ((j * data.Width) + i) * depth;
                    else
                        offset = ((i * data.Width) + j) * depth;
                    int b = buffer[offset + 0];
                    if (value == b)
                    {
                        length++;
                    }
                    else if (value == -1)
                    {
                        length++;
                        value = b;
                    }
                    if ((value != b && value != -1) || j + 1 == secondCounter)
                    {
                        int tmp = 0;
                        for (tmp = 1; tmp < numberOfTreshholds + 1; tmp++)
                        {
                            if (value < tmp * ((double)256 / numberOfTreshholds))
                            {
                                tmp--;
                                break;
                            }
                        }
                        histogram[tmp][length - 1]++;
                        if (histogram[tmp][length - 1] > max)
                            max = histogram[tmp][length - 1];
                        value = b;
                        length = 1;
                    }
                }
            }
            if (directionOfAnalisys == "w obu kierunkach")
            {
                var tmp = firstCounter;
                firstCounter = secondCounter;
                secondCounter = tmp;
                for (int i = 0; i < firstCounter; i++)
                {
                    int value = -1;
                    int length = 0;
                    for (int j = 0; j < secondCounter; j++)
                    {
                        int offset = 0;
                        offset = ((j * data.Width) + i) * depth;
                        int b = buffer[offset + 0];
                        if (value == b)
                        {
                            length++;
                        }
                        else if (value == -1)
                        {
                            length++;
                            value = b;
                        }
                        if ((value != b && value != -1) || j + 1 == secondCounter)
                        {
                            tmp = 0;
                            for (tmp = 1; tmp < numberOfTreshholds + 1; tmp++)
                            {
                                if (value < tmp * ((double)256 / numberOfTreshholds))
                                {
                                    tmp--;
                                    break;
                                }
                            }
                            histogram[tmp][length - 1]++;
                            if (histogram[tmp][length - 1] > max)
                                max = histogram[tmp][length - 1];
                            value = b;
                            length = 1;
                        }
                    }
                }
            }
            NormalizeHistogram((int)max);

            image.UnlockBits(data);
        }
        private void NormalizeHistogram(int max)
        {
            for (int i = 0; i < histogramHeight; i++)
                for (int j = 0; j < histogramWidth; j++)
                    histogram[i][j] /= max;
        }
        private void TreshholdImage(Bitmap image)
        {
            var rect = new Rectangle(0, 0, image.Width, image.Height);
            var data = image.LockBits(rect, ImageLockMode.ReadWrite, image.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8;
            var buffer = new byte[data.Width * data.Height * depth];

            int numberOfTreshholds = (int)treshholdUpDown.Value;

            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);
            for (int i = 0; i < data.Width; i++)
            {
                for (int j = 0; j < data.Height; j++)
                {
                    var offset = ((j * data.Width) + i) * depth;
                    var b = buffer[offset + 0];
                    for (int tmp = 1; tmp < numberOfTreshholds + 1; tmp++)
                    {
                        if (b < tmp * ((double)256 / numberOfTreshholds))
                        {
                            b = (byte)(tmp * ((double)256 / numberOfTreshholds) - ((double)256 / numberOfTreshholds)/2);
                            break;
                        }
                    }
                    buffer[offset + 0] = buffer[offset + 1] = buffer[offset + 2] = (byte)b;
                }
            }
            Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
            image.UnlockBits(data);
            processingPictureBox.Image = image;
        }
        private void ConvertToGreyScale(Bitmap image)
        {
            var rect = new Rectangle(0, 0, image.Width, image.Height);
            var data = image.LockBits(rect, ImageLockMode.ReadWrite, image.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8;
            var buffer = new byte[data.Width * data.Height * depth];


            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);
            for (int i = 0; i < data.Width; i++)
            {
                for (int j = 0; j < data.Height; j++)
                {
                    var offset = ((j * data.Width) + i) * depth;
                    var b = 0.2126 * buffer[offset + 0] + 0.7152 * buffer[offset + 1] + 0.0722 * buffer[offset + 2];
                    buffer[offset + 0] = buffer[offset + 1] = buffer[offset + 2] = (byte)b;
                }
            }
            Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
            image.UnlockBits(data);
            processingPictureBox.Image = image;
        }
        private void histogramButton_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(() =>
            {
                ShowHistogram();
            });
            thr.Start();
        }
        private void WriteParametersToLabels()
        {
            shortPrimitiveEmphasisLabel.Text = ((decimal)shortPrimitiveEmphasis).ToString("0." + new string('#', 339));
            longPrimitiveEmphasisLabel.Text = longPrimitiveEmphasis.ToString();
            greyLevelUniformityLabel.Text = greyLevelUniformity.ToString();
            primitiveLengthUniformityLabel.Text = primitiveLengthUniformity.ToString();
            primitivePercentageLabel.Text = primitivePercentage.ToString() + "%";
        }
        private void ResetParameters()
        {
            shortPrimitiveEmphasis = 0;
            longPrimitiveEmphasis = 0;
            greyLevelUniformity = 0;
            primitiveLengthUniformity = 0;
            primitivePercentage = 0;
            WriteParametersToLabels();
        }
    }
}
