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
            ChrtRash.Titles.Add("Прибыль и расходы за год");

            double prible = 0;

            for (int i = 0; i < info.LstPrible.Count; i++)
            {
                prible += info.LstPrible[i];
            }

            double rashod = 0;

            for (int i = 0; i < info.LStRashod.Count; i++)
            {
                rashod += info.LStRashod[i];
            }

            if (rashod == 0)
                rashod = 1;

            if (prible == 0)
                prible = 1;

            var prib =  ChrtRash.Series.Add("Прибыль");
            prib.ChartType = SeriesChartType.Pie;
            prib.Points.AddXY("Прибыль",prible);
            prib.Points.AddXY("Расходы",rashod);


            //var rash = ChrtRash.Series.Add();
            //rash.ChartType = SeriesChartType.Pie;
            
        }

        private void FillChartSession()
        {
            ChrtSession.Series.Clear();
            ChrtSession.Titles.Add("Кол-во посещений каждый сезон");


            List<string> names = new List<string>() { "Зима", "Весна", "Лето", "Осень" };

            ChrtSession.Series.Add("Кол-во посещений каждый сезон");
            ChrtSession.Series[0].ChartType = SeriesChartType.Column;
            ChrtSession.Series[0].Points.DataBindXY(names,info.Session);
            ChrtSession.Series[0].IsValueShownAsLabel = true;
            ChrtSession.Series[0].Font = new Font("Georgia", 16);
        }
    }
}
