
namespace AdvancedImageProcessing
{
    partial class FormConvolution
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMultiplication = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblPixels = new System.Windows.Forms.Label();
            this.rtxtMask = new System.Windows.Forms.RichTextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(297, 41);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblMultiplication
            // 
            this.lblMultiplication.AutoSize = true;
            this.lblMultiplication.Location = new System.Drawing.Point(96, 18);
            this.lblMultiplication.Name = "lblMultiplication";
            this.lblMultiplication.Size = new System.Drawing.Size(13, 13);
            this.lblMultiplication.TabIndex = 14;
            this.lblMultiplication.Text = "x";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(56, 13);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(34, 22);
            this.txtWidth.TabIndex = 13;
            this.txtWidth.Text = "5";
            this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
            // 
            // lblPixels
            // 
            this.lblPixels.AutoSize = true;
            this.lblPixels.Location = new System.Drawing.Point(12, 18);
            this.lblPixels.Name = "lblPixels";
            this.lblPixels.Size = new System.Drawing.Size(38, 13);
            this.lblPixels.TabIndex = 12;
            this.lblPixels.Text = "pixels:";
            // 
            // rtxtMask
            // 
            this.rtxtMask.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtxtMask.Location = new System.Drawing.Point(12, 41);
            this.rtxtMask.Name = "rtxtMask";
            this.rtxtMask.Size = new System.Drawing.Size(279, 203);
            this.rtxtMask.TabIndex = 18;
            this.rtxtMask.Text = "";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(115, 13);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(34, 22);
            this.txtHeight.TabIndex = 19;
            this.txtHeight.Text = "5";
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(155, 18);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(145, 13);
            this.lblDirection.TabIndex = 20;
            this.lblDirection.Text = "(矩陣請以逗點隔開元素)";
            // 
            // FormConvolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.rtxtMask);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMultiplication);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblPixels);
            this.Name = "FormConvolution";
            this.Text = "卷積運算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMultiplication;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblPixels;
        private System.Windows.Forms.RichTextBox rtxtMask;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblDirection;
    }
}