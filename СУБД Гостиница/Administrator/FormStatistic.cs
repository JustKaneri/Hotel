using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {


            chart3.Series.Clear();

            chart3.Series.Add("V1");
            chart3.Series["V1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart3.Series["V1"].Points.AddXY("Зима", 20);
            chart3.Series["V1"].Points.AddXY("Лето", 51);
            chart3.Series["V1"].Points.AddXY("Осень", 21);
            chart3.Series["V1"].Points.AddXY("Весна", 16);

            chart2.Series.Clear();

            chart2.Series.Add("V1");
            chart2.Series["V1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart2.Series["V1"].Points.AddXY("Зима", 20);
            chart2.Series["V1"].Points.AddXY("Лето", 51);
            chart2.Series["V1"].Points.AddXY("Осень", 21);
            chart2.Series["V1"].Points.AddXY("Весна", 16);

        }

        private void BtnOtch_MouseEnter(object sender, EventArgs e)
        {
            BtnOtch.BackColor = Colors.ButtonMousEnter;
            BtnOtch.ForeColor = Colors.ButtonForeSelect;
        }

        private void BtnOtch_MouseLeave(object sender, EventArgs e)
        {
            BtnOtch.BackColor = Colors.ButtonMousLeave;
            BtnOtch.ForeColor = Colors.ButtonForeNoSelect;
        }
    }
}
