
namespace AdvancedImageProcessing
{
    partial class FormNoiseGeneration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSDV = new System.Windows.Forms.Label();
            this.txtSDV = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.lblGaussianNoise = new System.Windows.Forms.Label();
            this.lblSaltAndPepperNoise = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radSDV = new System.Windows.Forms.RadioButton();
            this.radPercentage = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSDV
            // 
            this.lblSDV.AutoSize = true;
            this.lblSDV.Location = new System.Drawing.Point(19, 67);
            this.lblSDV.Name = "lblSDV";
            this.lblSDV.Size = new System.Drawing.Size(53, 12);
            this.lblSDV.TabIndex = 0;
            this.lblSDV.Text = "標準差：";
            // 
            // txtSDV
            // 
            this.txtSDV.Location = new System.Drawing.Point(19, 99);
            this.txtSDV.Name = "txtSDV";
            this.txtSDV.Size = new System.Drawing.Size(100, 22);
            this.txtSDV.TabIndex = 1;
            this.txtSDV.Text = "25";
            this.txtSDV.TextChanged += new System.EventHandler(this.txtSDV_TextChanged);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(154, 67);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(70, 12);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "百分比(%)：";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(154, 99);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtPercentage.TabIndex = 3;
            this.txtPercentage.Text = "25";
            this.txtPercentage.TextChanged += new System.EventHandler(this.txtPercentage_TextChanged);
            // 
            // lblGaussianNoise
            // 
            this.lblGaussianNoise.AutoSize = true;
            this.lblGaussianNoise.Location = new System.Drawing.Point(39, 35);
            this.lblGaussianNoise.Name = "lblGaussianNoise";
            this.lblGaussianNoise.Size = new System.Drawing.Size(65, 12);
            this.lblGaussianNoise.TabIndex = 4;
            this.lblGaussianNoise.Text = "高斯白雜訊";
            // 
            // lblSaltAndPepperNoise
            // 
            this.lblSaltAndPepperNoise.AutoSize = true;
            this.lblSaltAndPepperNoise.Location = new System.Drawing.Point(174, 35);
            this.lblSaltAndPepperNoise.Name = "lblSaltAndPepperNoise";
            this.lblSaltAndPepperNoise.Size = new System.Drawing.Size(53, 12);
            this.lblSaltAndPepperNoise.TabIndex = 5;
            this.lblSaltAndPepperNoise.Text = "椒鹽雜訊";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // radSDV
            // 
            this.radSDV.AutoSize = true;
            this.radSDV.Checked = true;
            this.radSDV.Location = new System.Drawing.Point(19, 34);
            this.radSDV.Name = "radSDV";
            this.radSDV.Size = new System.Drawing.Size(14, 13);
            this.radSDV.TabIndex = 9;
            this.radSDV.TabStop = true;
            this.radSDV.UseVisualStyleBackColor = true;
            // 
            // radPercentage
            // 
            this.radPercentage.AutoSize = true;
            this.radPercentage.Location = new System.Drawing.Point(154, 34);
            this.radPercentage.Name = "radPercentage";
            this.radPercentage.Size = new System.Drawing.Size(14, 13);
            this.radPercentage.TabIndex = 10;
            this.radPercentage.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(297, 62);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormNoiseGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radPercentage);
            this.Controls.Add(this.radSDV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSaltAndPepperNoise);
            this.Controls.Add(this.lblGaussianNoise);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtSDV);
            this.Controls.Add(this.lblSDV);
            this.Name = "FormNoiseGeneration";
            this.Text = "雜訊產生";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSDV;
        private System.Windows.Forms.TextBox txtSDV;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label lblGaussianNoise;
        private System.Windows.Forms.Label lblSaltAndPepperNoise;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radSDV;
        private System.Windows.Forms.RadioButton radPercentage;
        private System.Windows.Forms.Button btnOK;
    }
}