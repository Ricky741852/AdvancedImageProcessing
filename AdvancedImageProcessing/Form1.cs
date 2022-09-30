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
                int i = 0;
                while (File.Exists("ImageRotation" + (i == 0 ? "" : i.ToString()) +  ".bmp"))
                {
                    i++;
                }
                picOutput.Image.Save("ImageRotation" + (i == 0 ? "" : i.ToString()) + ".bmp");
            }
        }
    }
}
