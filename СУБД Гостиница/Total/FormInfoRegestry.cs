using HotelAPI;
using HotelAPI.Regestry.Controler;
using HotelAPI.Regestry.Model;
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

using Excel = Microsoft.Office.Interop.Excel;

namespace СУБД_Гостиница.Total
{
    public partial class FormInfoRegestry : Form
    {
        private MainManager Manager;
        private int Id_Room;
        private RegestryController regestryControoler;
        private RegestryInfo info;

        public FormInfoRegestry(MainManager manager,int id_Room)
        {
            InitializeComponent();

            Manager = manager;
            Id_Room = id_Room;

            regestryControoler = Manager.GetRegestryController();
        }

        private async void FormInfoRegestry_Load(object sender, EventArgs e)
        {
            info = await regestryControoler.GetRegestryInfo(Id_Room);

            if(info == null)
            {
                MessageBox.Show("Нет соединения с сервером", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FillData();
            }
            catch
            {
                return;
            }
            
        }

        private void FillData()
        {
            TbxFam.Text = info.Fam;
            TbxName.Text = info.Name;
            TbxOtch.Text = info.Otch;
            TbxPhone.Text = info.Phohe;
            TbxStart.Text = info.DtmStart.ToShortDateString();
            TbxEnd.Text = info.DtmEnd.ToShortDateString();

            for (int i = 0; i < info.NameServis.Count; i++)
            {
                DgvServis.Rows.Add(info.NameServis[i], info.CountServis[i], info.PriceServis[i]);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\Шаблон.xlsx"))
            {
                MessageBox.Show("Отсутствует файл Шаблон.xlsx", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Application app = new Excel.Application();
            Excel.Workbook book = app.Workbooks.Open(Application.StartupPath + "\\Шаблон.xlsx", Type.Missing, false);
            Excel.Worksheet list = app.Worksheets.get_Item(1);

            list.get_Range("C13").Value = info.Fam;
            list.get_Range("C14").Value = info.Name;
            list.get_Range("C15").Value = info.Otch;
            list.get_Range("C16").Value = info.Phohe;

            list.get_Range("C20").Value = info.DtmStart;
            list.get_Range("C21").Value = info.DtmEnd;
            list.get_Range("C22").Value = info.Price.Remove(info.Price.IndexOf(','));
            double price = ((((int)Math.Round((info.DtmEnd - info.DtmStart).TotalDays) + 1) * double.Parse(info.Price)));
            list.get_Range("B24").Value = price;

            double Summ = 0;

            for (int i = 0; i < info.NameServis.Count; i++)
            {
                list.get_Range($"A{28+i}").Value = i+1;
                list.get_Range($"B{28 + i}").Value = info.NameServis[i];
                list.get_Range($"C{28 + i}").Value = info.CountServis[i];
                list.get_Range($"D{28 + i}").Value = info.PriceServis[i].Remove(info.PriceServis[i].IndexOf(','));

                Summ += info.CountServis[i] * int.Parse(info.PriceServis[i].Remove(info.PriceServis[i].IndexOf(',')));
            }

            list.get_Range("B47").Value = Summ;

            list.get_Range("B51").Value = Summ + int.Parse(price.ToString());

            list.get_Range("A55").Value = DateTime.Now.ToShortDateString();

            string fileName =  String.Format("Check_List_{0}_{1}_{2}.xlsx",info.Fam, DateTime.Now.ToString("yyyyMMddHHmmssfff"), Guid.NewGuid());


            book.SaveAs(Application.StartupPath+"\\"+fileName);

            book.Close(false);
            app.Quit();

            System.Diagnostics.Process.Start(Application.StartupPath + "\\" + fileName);
        }
    }
}
