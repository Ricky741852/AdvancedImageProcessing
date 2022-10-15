using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AdvancedImageProcessing.Form1;

namespace AdvancedImageProcessing
{
    public partial class FormConvolution : Form
    {
        public FormConvolution(Convolution convolution)
        {
            InitializeComponent();
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            _Convolution = convolution ?? new Convolution
            {
                Size = 5,
                Mask = MatrixCreate(5)
            };
            txtWidth.Text = _Convolution.Size.ToString();
            txtHeight.Text = _Convolution.Size.ToString();
            CreateMaskString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] rows = rtxtMask.Lines;
            for (int i = 0; i < rows.Length; i++)
            {
                string[] cols = rows[i].Split(',');
                for (int j = 0; j < cols.Length; j++)
                {
                    if (int.TryParse(cols[j], out int value))
                    {
                        _Convolution.Mask[i,j] = value;
                    }
                    else
                    {
                        MessageBox.Show("數值有誤，請重新檢查");
                        return;
                    }
                }
            }
            Form1 form1 = (Form1)Owner;
            form1._Convolution = new Convolution
            {
                Size = _Convolution.Size,
                Mask = _Convolution.Mask
            };
        }

        private void txtWidth_Leave(object sender, EventArgs e)
        {
            if (txtWidth.Text != _Convolution.Size.ToString())
            {
                if (int.TryParse(txtWidth.Text, out int size) && size >= 5)
                {
                    txtHeight.Text = txtWidth.Text;
                    _Convolution = new Convolution
                    {
                        Size = size,
                        Mask = MatrixCreate(size)
                    };
                    CreateMaskString();
                }
                else
                {
                    txtWidth.Text = txtHeight.Text;
                    MessageBox.Show("請輸入大於5之整數");
                }
            }
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            if (txtHeight.Text != _Convolution.Size.ToString())
            {
                if (int.TryParse(txtHeight.Text, out int size) && size >= 5)
                {
                    txtWidth.Text = txtHeight.Text;
                    _Convolution = new Convolution
                    {
                        Size = size,
                        Mask = MatrixCreate(size)
                    };
                    CreateMaskString();
                }
                else
                {
                    txtHeight.Text = txtWidth.Text;
                    MessageBox.Show("請輸入大於5之整數");
                }
            }
        }

        /// <summary>
        /// 製作矩陣
        /// </summary>
        /// <param name="size">矩陣長寬</param>
        /// <returns></returns>
        static int[,] MatrixCreate(int size)
        {
            int[,] matrix = new int[size,size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = 1;
                }
            return matrix;
        }

        /// <summary>
        /// 矩陣轉字串
        /// </summary>
        private void CreateMaskString()
        {
            int size = _Convolution.Size;
            string maskString = string.Empty;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    maskString += _Convolution.Mask[i,j].ToString();
                    maskString += j < (_Convolution.Size - 1) ? "," : "";
                }
                maskString += i < (_Convolution.Size - 1) ? "\n" : "";
            }
            rtxtMask.Text = maskString;
        }

        private Convolution _Convolution { get; set; }
    }
}
