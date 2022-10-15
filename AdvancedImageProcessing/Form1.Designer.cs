
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.btnImageRotation = new System.Windows.Forms.Button();
            this.btnImageHistogram = new System.Windows.Forms.Button();
            this.btnNoiseGeneration = new System.Windows.Forms.Button();
            this.picNoise = new System.Windows.Forms.PictureBox();
            this.picNoiseOutput = new System.Windows.Forms.PictureBox();
            this.picNoiseInput = new System.Windows.Forms.PictureBox();
            this.chartNoiseInputHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNoiseHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNoiseOutputHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpNoiseGeneration = new System.Windows.Forms.GroupBox();
            this.btnConvolution = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoiseOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoiseInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoiseInputHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoiseHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoiseOutputHistogram)).BeginInit();
            this.gpNoiseGeneration.SuspendLayout();
            this.SuspendLayout();
            // 
            // picInput
            // 
            this.picInput.Location = new System.Drawing.Point(40, 94);
            this.picInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(465, 364);
            this.picInput.TabIndex = 2;
            this.picInput.TabStop = false;
            // 
            // picOutput
            // 
            this.picOutput.Location = new System.Drawing.Point(549, 94);
            this.picOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(465, 364);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOutput.TabIndex = 3;
            this.picOutput.TabStop = false;
            this.picOutput.Visible = false;
            // 
            // chartHistogram
            // 
            chartArea1.AxisX.Interval = 50D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 256D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Intensity";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Title = "Frequency";
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            this.chartHistogram.Enabled = false;
            this.chartHistogram.Location = new System.Drawing.Point(549, 94);
            this.chartHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Size = new System.Drawing.Size(465, 364);
            this.chartHistogram.TabIndex = 5;
            this.chartHistogram.Text = "直方圖";
            title1.Name = "Title1";
            title1.Text = "Image Histogram";
            this.chartHistogram.Titles.Add(title1);
            this.chartHistogram.Visible = false;
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(40, 42);
            this.btnInputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(100, 29);
            this.btnInputFile.TabIndex = 0;
            this.btnInputFile.Text = "檔案";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // btnImageRotation
            // 
            this.btnImageRotation.Location = new System.Drawing.Point(167, 42);
            this.btnImageRotation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImageRotation.Name = "btnImageRotation";
            this.btnImageRotation.Size = new System.Drawing.Size(100, 29);
            this.btnImageRotation.TabIndex = 1;
            this.btnImageRotation.Text = "影像旋轉";
            this.btnImageRotation.UseVisualStyleBackColor = true;
            this.btnImageRotation.Click += new System.EventHandler(this.btnImageRotation_Click);
            // 
            // btnImageHistogram
            // 
            this.btnImageHistogram.Location = new System.Drawing.Point(293, 42);
            this.btnImageHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImageHistogram.Name = "btnImageHistogram";
            this.btnImageHistogram.Size = new System.Drawing.Size(100, 29);
            this.btnImageHistogram.TabIndex = 4;
            this.btnImageHistogram.Text = "直方圖";
            this.btnImageHistogram.UseVisualStyleBackColor = true;
            this.btnImageHistogram.Click += new System.EventHandler(this.btnImageHistogram_Click);
            // 
            // btnNoiseGeneration
            // 
            this.btnNoiseGeneration.Location = new System.Drawing.Point(420, 42);
            this.btnNoiseGeneration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoiseGeneration.Name = "btnNoiseGeneration";
            this.btnNoiseGeneration.Size = new System.Drawing.Size(100, 29);
            this.btnNoiseGeneration.TabIndex = 6;
            this.btnNoiseGeneration.Text = "雜訊產生";
            this.btnNoiseGeneration.UseVisualStyleBackColor = true;
            this.btnNoiseGeneration.Click += new System.EventHandler(this.btnNoiseGeneration_Click);
            // 
            // picNoise
            // 
            this.picNoise.Location = new System.Drawing.Point(371, 0);
            this.picNoise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picNoise.Name = "picNoise";
            this.picNoise.Size = new System.Drawing.Size(233, 182);
            this.picNoise.TabIndex = 7;
            this.picNoise.TabStop = false;
            // 
            // picNoiseOutput
            // 
            this.picNoiseOutput.Location = new System.Drawing.Point(741, 0);
            this.picNoiseOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picNoiseOutput.Name = "picNoiseOutput";
            this.picNoiseOutput.Size = new System.Drawing.Size(233, 182);
            this.picNoiseOutput.TabIndex = 8;
            this.picNoiseOutput.TabStop = false;
            // 
            // picNoiseInput
            // 
            this.picNoiseInput.Location = new System.Drawing.Point(0, 0);
            this.picNoiseInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picNoiseInput.Name = "picNoiseInput";
            this.picNoiseInput.Size = new System.Drawing.Size(233, 182);
            this.picNoiseInput.TabIndex = 9;
            this.picNoiseInput.TabStop = false;
            // 
            // chartNoiseInputHistogram
            // 
            chartArea2.AxisX.Interval = 50D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Maximum = 256D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Intensity";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Title = "Frequency";
            chartArea2.Name = "ChartArea1";
            this.chartNoiseInputHistogram.ChartAreas.Add(chartArea2);
            this.chartNoiseInputHistogram.Enabled = false;
            this.chartNoiseInputHistogram.Location = new System.Drawing.Point(0, 230);
            this.chartNoiseInputHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartNoiseInputHistogram.Name = "chartNoiseInputHistogram";
            this.chartNoiseInputHistogram.Size = new System.Drawing.Size(233, 182);
            this.chartNoiseInputHistogram.TabIndex = 10;
            this.chartNoiseInputHistogram.Text = "直方圖";
            title2.Name = "Title1";
            title2.Text = "Input Histogram";
            this.chartNoiseInputHistogram.Titles.Add(title2);
            // 
            // chartNoiseHistogram
            // 
            chartArea3.AxisX.Interval = 50D;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.Maximum = 256D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Intensity";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.LineWidth = 0;
            chartArea3.AxisY.Title = "Frequency";
            chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.Name = "ChartArea1";
            this.chartNoiseHistogram.ChartAreas.Add(chartArea3);
            this.chartNoiseHistogram.Enabled = false;
            this.chartNoiseHistogram.Location = new System.Drawing.Point(371, 230);
            this.chartNoiseHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartNoiseHistogram.Name = "chartNoiseHistogram";
            this.chartNoiseHistogram.Size = new System.Drawing.Size(233, 182);
            this.chartNoiseHistogram.TabIndex = 11;
            this.chartNoiseHistogram.Text = "直方圖";
            title3.Name = "Title1";
            title3.Text = "Noise Histogram";
            this.chartNoiseHistogram.Titles.Add(title3);
            // 
            // chartNoiseOutputHistogram
            // 
            chartArea4.AxisX.Interval = 50D;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.Maximum = 256D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.Title = "Intensity";
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.LineWidth = 0;
            chartArea4.AxisY.Title = "Frequency";
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.Name = "ChartArea1";
            this.chartNoiseOutputHistogram.ChartAreas.Add(chartArea4);
            this.chartNoiseOutputHistogram.Enabled = false;
            this.chartNoiseOutputHistogram.Location = new System.Drawing.Point(741, 230);
            this.chartNoiseOutputHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartNoiseOutputHistogram.Name = "chartNoiseOutputHistogram";
            this.chartNoiseOutputHistogram.Size = new System.Drawing.Size(233, 182);
            this.chartNoiseOutputHistogram.TabIndex = 12;
            this.chartNoiseOutputHistogram.Text = "直方圖";
            title4.Name = "Title1";
            title4.Text = "Output Histogram";
            this.chartNoiseOutputHistogram.Titles.Add(title4);
            // 
            // gpNoiseGeneration
            // 
            this.gpNoiseGeneration.Controls.Add(this.picNoise);
            this.gpNoiseGeneration.Controls.Add(this.chartNoiseOutputHistogram);
            this.gpNoiseGeneration.Controls.Add(this.chartNoiseHistogram);
            this.gpNoiseGeneration.Controls.Add(this.picNoiseInput);
            this.gpNoiseGeneration.Controls.Add(this.chartNoiseInputHistogram);
            this.gpNoiseGeneration.Controls.Add(this.picNoiseOutput);
            this.gpNoiseGeneration.Location = new System.Drawing.Point(40, 94);
            this.gpNoiseGeneration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpNoiseGeneration.Name = "gpNoiseGeneration";
            this.gpNoiseGeneration.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpNoiseGeneration.Size = new System.Drawing.Size(975, 412);
            this.gpNoiseGeneration.TabIndex = 13;
            this.gpNoiseGeneration.TabStop = false;
            this.gpNoiseGeneration.Visible = false;
            // 
            // btnConvolution
            // 
            this.btnConvolution.Location = new System.Drawing.Point(547, 42);
            this.btnConvolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvolution.Name = "btnConvolution";
            this.btnConvolution.Size = new System.Drawing.Size(100, 29);
            this.btnConvolution.TabIndex = 14;
            this.btnConvolution.Text = "卷積運算";
            this.btnConvolution.UseVisualStyleBackColor = true;
            this.btnConvolution.Click += new System.EventHandler(this.btnConvolution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnConvolution);
            this.Controls.Add(this.btnNoiseGeneration);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.btnImageHistogram);
            this.Controls.Add(this.picOutput);
            this.Controls.Add(this.picInput);
            this.Controls.Add(this.btnImageRotation);
            this.Controls.Add(this.btnInputFile);
            this.Controls.Add(this.gpNoiseGeneration);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "AIP61147046s";
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoiseOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoiseInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoiseInputHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoiseHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoiseOutputHistogram)).EndInit();
            this.gpNoiseGeneration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.Button btnImageRotation;
        private System.Windows.Forms.Button btnImageHistogram;
        private System.Windows.Forms.Button btnNoiseGeneration;
        private System.Windows.Forms.PictureBox picNoise;
        private System.Windows.Forms.PictureBox picNoiseOutput;
        private System.Windows.Forms.PictureBox picNoiseInput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNoiseInputHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNoiseHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNoiseOutputHistogram;
        private System.Windows.Forms.GroupBox gpNoiseGeneration;
        private System.Windows.Forms.Button btnConvolution;
    }
}

