using HotelAPI;
using HotelAPI.Statistic.Contoller;
using HotelAPI.Statistic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace СУБД_Гостиница
{
    public partial class FormStatistic : Form
    {
        private MainManager Manager;
        private StatisticController statisticController;
        private StatisticInfo info;

        public FormStatistic(MainManager manager)
        {
            InitializeComponent();

            Manager = manager;
            statisticController = Manager.GetStatisticController();
        }

        private async void FormStatistic_Load(object sender, EventArgs e)
        {
            info = await statisticController.GetStatisticInfo();

            if(info == null)
            {
                MessageBox.Show("Нет соединения с сервером", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LbxCountClient.Text = info.CountPeople.ToString();
                LbxPribel.Text = info.Prible.ToString();
                LbxRashod.Text = info.Rashod.ToString();

                FillChartSession();
                FillChartMoney();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void FillChartMoney()
        {
            ChrtRash.Series.Clear();

            var prib =  ChrtRash.Series.Add("Прибыль");
            prib.ChartType = SeriesChartType.Column;
            prib.Points.AddXY("Зима", info.LstPrible[0] == 0 ? info.LstPrible[0] + 1: info.LstPrible[0]);
            prib.Points.AddXY("Весна", info.LstPrible[1] == 0 ? info.LstPrible[1] + 1 : info.LstPrible[1]);
            prib.Points.AddXY("Лето", info.LstPrible[2] == 0 ? info.LstPrible[2] + 1 : info.LstPrible[2]);
            prib.Points.AddXY("Осень", info.LstPrible[3] == 0 ? info.LstPrible[3] + 1 : info.LstPrible[3]);

            var rash =  ChrtRash.Series.Add("Расходы");
            rash.ChartType = SeriesChartType.Column;
            rash.Points.AddXY("Зима", info.LStRashod[0] == 0 ? info.LStRashod[0] + 1 : info.LStRashod[0]);
            rash.Points.AddXY("Весна", info.LStRashod[1] == 0 ? info.LStRashod[1] + 1 : info.LStRashod[1]);
            rash.Points.AddXY("Лето", info.LStRashod[2] == 0 ? info.LStRashod[2] + 1 : info.LStRashod[2]);
            rash.Points.AddXY("Осень", info.LStRashod[3] == 0 ? info.LStRashod[3] + 1 : info.LStRashod[3]);
        }

        private void FillChartSession()
        {
            ChrtSession.Series.Clear();

            ChrtSession.Series.Add("Зима");
            ChrtSession.Series["Зима"].ChartType = SeriesChartType.Column;
            ChrtSession.Series["Зима"].Points.AddY(info.Session[0]==0 ?info.Session[0]+1:info.Session[0]);

            ChrtSession.Series.Add("Весна");
            ChrtSession.Series["Весна"].ChartType = SeriesChartType.Column;
            ChrtSession.Series["Весна"].Points.AddY(info.Session[1] == 0 ? info.Session[1] + 1 : info.Session[1]);

            ChrtSession.Series.Add("Лето");
            ChrtSession.Series["Лето"].ChartType = SeriesChartType.Column;
            ChrtSession.Series["Лето"].Points.AddY(info.Session[2] == 0 ? info.Session[2] + 1 : info.Session[2]);

            ChrtSession.Series.Add("Осень");
            ChrtSession.Series["Осень"].ChartType = SeriesChartType.Column;
            ChrtSession.Series["Осень"].Points.AddY(info.Session[3] == 0 ? info.Session[3] + 1 : info.Session[3]);
        }
    }
}
