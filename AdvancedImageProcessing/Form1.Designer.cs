
namespace AdvancedImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInputFile = new System.Windows.Forms.Button();
            this.btnImageRotation = new System.Windows.Forms.Button();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.picOutput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(30, 34);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(75, 23);
            this.btnInputFile.TabIndex = 0;
            this.btnInputFile.Text = "檔案";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // btnImageRotation
            // 
            this.btnImageRotation.Location = new System.Drawing.Point(128, 34);
            this.btnImageRotation.Name = "btnImageRotation";
            this.btnImageRotation.Size = new System.Drawing.Size(75, 23);
            this.btnImageRotation.TabIndex = 1;
            this.btnImageRotation.Text = "影像旋轉";
            this.btnImageRotation.UseVisualStyleBackColor = true;
            this.btnImageRotation.Click += new System.EventHandler(this.btnImageRotation_Click);
            // 
            // picInput
            // 
            this.picInput.Location = new System.Drawing.Point(30, 111);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(349, 291);
            this.picInput.TabIndex = 2;
            this.picInput.TabStop = false;
            // 
            // picOutput
            // 
            this.picOutput.Location = new System.Drawing.Point(412, 111);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(349, 291);
            this.picOutput.TabIndex = 3;
            this.picOutput.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picOutput);
            this.Controls.Add(this.picInput);
            this.Controls.Add(this.btnImageRotation);
            this.Controls.Add(this.btnInputFile);
            this.Name = "Form1";
            this.Text = "AIP61147046s";
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.Button btnImageRotation;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.PictureBox picOutput;
    }
}

