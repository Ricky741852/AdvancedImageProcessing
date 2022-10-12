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
    public partial class FormNoiseGeneration : Form
    {
        public FormNoiseGeneration(NoiseGeneration noiseGeneration)
        {
            InitializeComponent();
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            _NoiseGeneration = noiseGeneration ?? new NoiseGeneration
            {
                Mode = true,
                Value = 25
            };
            if (_NoiseGeneration.Mode)
            {
                radSDV.Checked = true;
                txtSDV.Text = _NoiseGeneration.Value.ToString();
                txtSDV.Select();
            }
            else
            {
                radPercentage.Checked = true;
                txtPercentage.Text = _NoiseGeneration.Value.ToString();
                txtPercentage.Select();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            if (float.TryParse(radSDV.Checked ? txtSDV.Text : txtPercentage.Text, out float value))
            {
                form1._NoiseGeneration = new NoiseGeneration
                {
                    Mode = radSDV.Checked,
                    Value = value
                };
            }
        }

        private void txtSDV_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtSDV.Text, out float sdv) || sdv < 0)
            {
                txtSDV.Text = "25";
                MessageBox.Show("請輸入正實數");
            }
        }

        private void txtPercentage_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPercentage.Text, out int percentage) || percentage < 0)
            {
                txtPercentage.Text = "25";
                MessageBox.Show("請輸入正實數");
            }
        }

        private NoiseGeneration _NoiseGeneration { get; set; }
    }
}
