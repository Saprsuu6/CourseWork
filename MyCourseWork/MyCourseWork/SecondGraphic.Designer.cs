namespace MyCourseWork
{
    partial class SecondGraphic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.FirstChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виртуальная память (свободная)";
            // 
            // FirstChart
            // 
            chartArea3.Name = "ChartArea1";
            this.FirstChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.FirstChart.Legends.Add(legend3);
            this.FirstChart.Location = new System.Drawing.Point(12, 25);
            this.FirstChart.Name = "FirstChart";
            this.FirstChart.Size = new System.Drawing.Size(310, 171);
            this.FirstChart.TabIndex = 1;
            this.FirstChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Виртуальная память (всего)";
            // 
            // SecondChart
            // 
            chartArea4.Name = "ChartArea1";
            this.SecondChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.SecondChart.Legends.Add(legend4);
            this.SecondChart.Location = new System.Drawing.Point(347, 25);
            this.SecondChart.Name = "SecondChart";
            this.SecondChart.Size = new System.Drawing.Size(313, 171);
            this.SecondChart.TabIndex = 3;
            this.SecondChart.Text = "chart1";
            // 
            // SecondGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 207);
            this.Controls.Add(this.SecondChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstChart);
            this.Controls.Add(this.label1);
            this.Name = "SecondGraphic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SecondGraphic";
            ((System.ComponentModel.ISupportInitialize)(this.FirstChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart FirstChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart SecondChart;
    }
}