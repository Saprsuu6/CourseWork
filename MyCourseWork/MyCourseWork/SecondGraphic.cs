using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyCourseWork
{
    public partial class SecondGraphic : Form
    {
        readonly Timer timer;
        readonly private DriveInfo[] allDrives = DriveInfo.GetDrives();

        public SecondGraphic(Timer timer) // передаю таймер по ссылке
        {
            InitializeComponent();
            InitializeCharts();
            UpadteFirstChart();
            UpadteSecondChart();

            this.timer = timer; // this говорит компиляьору о том что я обращаююсь к обьекту с которым работаю
            this.timer.Tick += new EventHandler(Tick);
        }

        private void InitializeCharts()
        {
            for (int i = 0; i < allDrives.Length; i++)
            {
                FirstChart.Series.Add(allDrives[i].Name);
                FirstChart.Series[i].ChartType = SeriesChartType.Column; // я выбрал колонки, потомучто линию не видно на графике 

                SecondChart.Series.Add(allDrives[i].Name);
                SecondChart.Series[i].ChartType = SeriesChartType.Column; // я выбрал колонки, потомучто линию не видно на графике 
            }
        }

        private void UpadteFirstChart()
        {
            foreach (Series series in FirstChart.Series)
                series.Points.Clear();

            foreach (DriveInfo drive in allDrives)
            {
                foreach (Series series in FirstChart.Series)
                {
                    if (series.Name == drive.Name)
                    {
                        series.Points.AddY(drive.TotalFreeSpace);
                        break;
                    }
                }
            }
        }

        private void UpadteSecondChart()
        {
            foreach (Series series in SecondChart.Series)
                series.Points.Clear();

            foreach (DriveInfo drive in allDrives)
            {
                foreach (Series series in SecondChart.Series)
                {
                    if (series.Name == drive.Name)
                    {
                        series.Points.AddY(drive.TotalSize);
                        break;
                    }
                }
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            UpadteFirstChart();
            UpadteSecondChart();
        }
    }
}
