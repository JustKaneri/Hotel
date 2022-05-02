using HotelAPI;
using HotelAPI.Regestry.Controler;
using HotelAPI.Regestry.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
