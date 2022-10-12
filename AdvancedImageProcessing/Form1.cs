using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
                InitPictureBox();
                picInput.SizeMode = PictureBoxSizeMode.StretchImage;
                picInput.BackgroundImageLayout = ImageLayout.Stretch;
                try
                {
                    //使用ShaniSoft套件處理.ppm影像讀取
                    if (openFileDialog.FileName.ToLower().Contains("ppm"))
                    {
                        picInput.Image = ShaniSoft.Drawing.PNM.ReadPNM(openFileDialog.FileName);
                    }
                    else
                    {
                        picInput.Load(openFileDialog.FileName);
                    }
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
            if (picInput.Image != null)
            {
                InitPictureBox();
                picOutput.Visible = true;

                Bitmap bmp = new Bitmap(picInput.Image);
                bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
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
            else
            {
                MessageBox.Show("請先選取檔案");
            }
        }

        /// <summary>
        /// 直方圖
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImageHistogram_Click(object sender, EventArgs e)
        {
            if (picInput.Image != null)
            {
                InitPictureBox();
                chartHistogram.Visible = true;

                HistogramSeries histogramSeries = GetHistogram(picInput.Image);

                chartHistogram.Series.Clear();
                chartHistogram.Series.Add(histogramSeries.Series);
                chartHistogram.Series[0]["PointWidth"] = "1";
                chartHistogram.ChartAreas[0].AxisY.Maximum = histogramSeries.MaxValue * 1.1;
            }
            else
            {
                MessageBox.Show("請先選取檔案");
            }
        }

        /// <summary>
        /// 取得直方圖
        /// </summary>
        /// <param name="image">輸入影像</param>
        /// <returns>直方圖內容</returns>
        private HistogramSeries GetHistogram(Image image)
        {
            int[] values = new int[256];

            Bitmap bmp = new Bitmap(image);
            int height = bmp.Height;
            int width = bmp.Width;

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

            return new HistogramSeries
            {
                Series = series,
                MaxValue = values.Max()
            };
        }

        /// <summary>
        /// 直方圖
        /// </summary>
        private class HistogramSeries
        {
            public Series Series { get; set; }
            public int MaxValue { get; set; }
        }

        /// <summary>
        /// 雜訊產生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoiseGeneration_Click(object sender, EventArgs e)
        {
            if (picInput.Image != null)
            {
                //設定子表單
                Form form = new FormNoiseGeneration(_NoiseGeneration)
                {
                    Owner = this,
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    InitPictureBox();

                    #region 設定視窗顯示

                    picInput.Visible = false;
                    picOutput.Visible = false;
                    chartHistogram.Visible = false;
                    picNoiseInput.Visible = true;
                    picNoise.Visible = true;
                    picNoiseOutput.Visible = true;
                    chartNoiseInputHistogram.Visible = true;
                    chartNoiseHistogram.Visible = true;
                    chartNoiseOutputHistogram.Visible = true;

                    #endregion

                    int w = picNoiseInput.Width;
                    int h = picNoiseInput.Height;
                    picNoiseInput.Image = new Bitmap(picInput.Image, w, h);
                    Bitmap bmpInput = new Bitmap(picNoiseInput.Image, w, h);
                    Bitmap bmpNoise = new Bitmap(w, h);
                    Bitmap bmpOutput = new Bitmap(bmpInput, w, h);
                    Series sNoise = new Series
                    {
                        Color = Color.Gray,
                        IsVisibleInLegend = false,
                        ChartType = SeriesChartType.Column,
                        MarkerStyle = MarkerStyle.None
                    };

                    //Noise Histogram
                    int[] nh = new int[256];

                    double value = _NoiseGeneration.Value;
                    Random rnd = new Random();

                    if (_NoiseGeneration.Mode)
                    {
                        #region 製作高斯白雜訊

                        List<double> values = new List<double>();
                        for (int x = 0; x < w; x++)
                        {
                            for (int y = 0; y < h; y++)
                            {
                                if (y % 2 == 0)
                                {
                                    double gamma = rnd.NextDouble();
                                    double phi = rnd.NextDouble();
                                    double z1 = value * Math.Cos(2 * Math.PI * phi) * Math.Sqrt(-2 * Math.Log(gamma, Math.E));
                                    double z2 = value * Math.Sin(2 * Math.PI * phi) * Math.Sqrt(-2 * Math.Log(gamma, Math.E));
                                    values.Add(z1);
                                    values.Add(z2);
                                }
                            }
                        }

                        //設定Output
                        for (int x = 0; x < w; x++)
                        {
                            for (int y = 0; y < h; y++)
                            {
                                int noise = (int)values[x * h + y];
                                int outputR = AdjRGB(bmpInput.GetPixel(x, y).R + noise);
                                int outputG = AdjRGB(bmpInput.GetPixel(x, y).G + noise);
                                int outputB = AdjRGB(bmpInput.GetPixel(x, y).B + noise);
                                bmpOutput.SetPixel(x, y, Color.FromArgb(outputR, outputG, outputB));
                            }
                        }

                        //雜訊圖正規化
                        double min = values.Min();
                        double max = values.Max();
                        double range = max - min;
                        values = values.Select(s => Math.Floor(255 * (s - min) / range)).ToList();

                        //設定Noise
                        for (int x = 0; x < w; x++)
                        {
                            for (int y = 0; y < h; y++)
                            {
                                int noise = (int)values[x * h + y];
                                bmpNoise.SetPixel(x, y, Color.FromArgb(noise, noise, noise));
                            }
                        }

                        //直方圖
                        for (int i = 0; i < 256; i++)
                        {
                            nh[i] = values.Count(x => x == (i));
                        }

                        #endregion
                    }
                    else
                    {
                        #region 製作椒鹽雜訊

                        for (int x = 0; x < w; x++)
                        {
                            for (int y = 0; y < h; y++)
                            {
                                if (rnd.NextDouble() < (value / 100))
                                {
                                    Color color = rnd.NextDouble() < 0.5 ? Color.White : Color.Black;
                                    bmpNoise.SetPixel(x, y, color);
                                    bmpOutput.SetPixel(x, y, color);
                                    nh[color.R]++;
                                }
                            }
                        }

                        #endregion
                    }

                    #region 輸出雜訊圖&結果圖

                    picNoiseInput.Image = bmpInput;
                    picNoise.Image = bmpNoise;
                    picNoiseOutput.Image = bmpOutput;

                    HistogramSeries hsInput = GetHistogram(bmpInput);
                    chartNoiseInputHistogram.Series.Clear();
                    chartNoiseInputHistogram.Series.Add(hsInput.Series);
                    chartNoiseInputHistogram.Series[0]["PointWidth"] = "1";
                    chartNoiseInputHistogram.ChartAreas[0].AxisY.Maximum = hsInput.MaxValue * 1.1;


                    //加入點位
                    for (int i = 0; i < 256; i++)
                    {
                        sNoise.Points.AddXY(i, nh[i]);
                    }
                    chartNoiseHistogram.Series.Clear();
                    chartNoiseHistogram.Series.Add(sNoise);
                    chartNoiseHistogram.Series[0]["PointWidth"] = "1";
                    chartNoiseHistogram.ChartAreas[0].AxisY.Maximum = nh.Max() * 1.1;

                    HistogramSeries hsOutput = GetHistogram(bmpOutput);
                    chartNoiseOutputHistogram.Series.Clear();
                    chartNoiseOutputHistogram.Series.Add(hsOutput.Series);
                    chartNoiseOutputHistogram.Series[0]["PointWidth"] = "1";
                    chartNoiseOutputHistogram.ChartAreas[0].AxisY.Maximum = hsOutput.MaxValue * 1.1;

                    #endregion
                }
            }
            else
            {
                MessageBox.Show("請先選取檔案");
            }
        }

        /// <summary>
        /// 雜訊產生回傳值
        /// </summary>
        public class NoiseGeneration
        {
            /// <summary>
            /// 格式：
            /// True = 高斯白雜訊
            /// False = 椒鹽雜訊
            /// </summary>
            public bool Mode { get; set; }

            /// <summary>
            /// 數值
            /// </summary>
            public double Value { get; set; }
        }

        /// <summary>
        /// 雜訊產生
        /// </summary>
        public NoiseGeneration _NoiseGeneration { get; set; }

        /// <summary>
        /// 調整RGB位元
        /// </summary>
        /// <param name="inRGB"></param>
        /// <returns></returns>
        public int AdjRGB(int inRGB)
        {
            return inRGB > 255 ? 255 : inRGB < 0 ? 0 : inRGB;
        }

        /// <summary>
        /// 初始化控制項顯示
        /// </summary>
        private void InitPictureBox()
        {
            picNoiseInput.Visible = false;
            picNoise.Visible = false;
            picNoiseOutput.Visible = false;
            picOutput.Visible = false;
            chartHistogram.Visible = false;
            chartNoiseInputHistogram.Visible = false;
            chartNoiseHistogram.Visible = false;
            chartNoiseOutputHistogram.Visible = false;
            picInput.Visible = true;
        }
    }
}
