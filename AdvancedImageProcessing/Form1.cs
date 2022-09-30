using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdvancedImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 插入圖片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg;*.bmp;*.ppm)|*.jpg;*.bmp;*.ppm";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picInput.SizeMode = PictureBoxSizeMode.StretchImage;
                picInput.BackgroundImageLayout = ImageLayout.Stretch;
                try
                {
                    picInput.Load(openFileDialog.FileName);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// 影像翻轉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImageRotation_Click(object sender, EventArgs e)
        {
            Image image = picInput.Image;
            if (image != null)
            {
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                Bitmap bmp = new Bitmap(image);
                picOutput.SizeMode = PictureBoxSizeMode.StretchImage;
                picOutput.BackgroundImageLayout = ImageLayout.Stretch;
                picOutput.Image = bmp;
                //int i = 0;
                //while (File.Exists("ImageRotation" + (i == 0 ? "" : i.ToString()) + ".bmp"))
                //{
                //    i++;
                //}
                //picOutput.Image.Save("ImageRotation" + (i == 0 ? "" : i.ToString()) + ".bmp");
            }
        }

        /// <summary>
        /// 直方圖
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImageHistogram_Click(object sender, EventArgs e)
        {
            Image image = picInput.Image;
            if (image != null)
            {
                Bitmap bmp = new Bitmap(image);
                int height = bmp.Height;
                int width = bmp.Width;
                int[] values = new int[256];

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        byte red = pixelColor.R;
                        byte green = pixelColor.G;
                        byte blue = pixelColor.B;
                        int value = (red + green + blue) / 3;
                        values[value]++;
                    }
                }


                Series series = new Series
                {
                    Color = Color.Gray,
                    IsVisibleInLegend = false,
                    ChartType = SeriesChartType.Column,
                    MarkerStyle = MarkerStyle.None
                };

                //加入點位
                for (int i = 0; i < values.Length; i++)
                {
                    series.Points.AddXY(i, values[i]);
                }
                chartImageHistogram.Visible = true;
                chartImageHistogram.Series.Clear();
                chartImageHistogram.Series.Add(series);
                chartImageHistogram.Series[0]["PointWidth"] = "1";

                //設定x, y軸
                Axis axis = chartImageHistogram.ChartAreas[0].AxisX;
                axis.Minimum = 0;
                axis.Maximum = 256;
                axis.Interval = 50;
                chartImageHistogram.ChartAreas[0].AxisY.Maximum = values.Max() * 1.1;
            }
        }
    }
}
