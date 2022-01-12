namespace MyCourseWork
{
    partial class MyCourseWork
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оперативная память (свободное место)";
            // 
            // FirstChart
            // 
            chartArea2.Name = "ChartArea1";
            this.FirstChart.ChartAreas.Add(chartArea2);
            this.FirstChart.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend2.Name = "Legend1";
            this.FirstChart.Legends.Add(legend2);
            this.FirstChart.Location = new System.Drawing.Point(12, 25);
            this.FirstChart.Name = "FirstChart";
            this.FirstChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.FirstChart.Size = new System.Drawing.Size(216, 182);
            this.FirstChart.TabIndex = 1;
            this.FirstChart.Text = "FirstChart";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Остальные графики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Задания";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(234, 9);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(357, 296);
            this.Tree.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Прочитать информацию о расшерении .zip ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MyCourseWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 317);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FirstChart);
            this.Controls.Add(this.label1);
            this.Name = "MyCourseWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.FirstChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart FirstChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.Button button3;
    }
}

