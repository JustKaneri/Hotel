using HotelAPI;
using HotelAPI.Personal.Controller;
using HotelAPI.Personal.Model;
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
    public partial class FormPersonal : Form
    {
        private MainManager Manager;
        private PersonalController personalController;
        private List<HapfPersonalInfo> personales;

        public FormPersonal(MainManager manager)
        {
            InitializeComponent();
            Manager = manager;

            personalController = Manager.GetPersonalController();
        }

        private async void FormPersonal_Load(object sender, EventArgs e)
        {
            personales = await personalController.GetHalfPersonal();
            
            if(personales == null)
            {
                MessageBox.Show("Нет соединения с сервером", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            try
            {
                FillPersonalDGV();
            }
            catch 
            {
                Close();
                return;
            }
        }

        private void FillPersonalDGV()
        {
            DgvPersonal.Rows.Clear();

            foreach (var item in personales)
            {
                DgvPersonal.Rows.Add(item.PostPersonal.Name[0], item.Fam + " " + item.Name + " " + item.Othc);
            }
        }

        private void BtnFind_MouseEnter(object sender, EventArgs e)
        {
            BtnFind.BackColor = Colors.ButtonMousEnter;
            BtnFind.ForeColor = Colors.ButtonForeSelect;
            BtnFind.Image = Properties.Resources.MiniSearhW;
        }

        private void BtnFind_MouseLeave(object sender, EventArgs e)
        {
            BtnFind.BackColor = Colors.ButtonMousLeave;
            BtnFind.ForeColor = Colors.ButtonForeNoSelect;
            BtnFind.Image = Properties.Resources.MiniSearhB;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormPersonalAdding formPersonal = new FormPersonalAdding();
            formPersonal.ShowDialog();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            int index = -1;

            HapfPersonalInfo personalInfo = new HapfPersonalInfo();

            foreach (var item in personales)
            {
                if(item.Name.ToLower().StartsWith(TbxFind.Text.ToLower()))
                {
                    personalInfo = item;
                    break;
                }

                if (item.Fam.ToLower().StartsWith(TbxFind.Text.ToLower()))
                {
                    personalInfo = item;
                    break;
                }
            }

            index = personales.IndexOf(personalInfo);

            if (index == -1)
            {
                MessageBox.Show("Клиент не найден", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DgvPersonal.CurrentCell = DgvPersonal.Rows[index].Cells[0];
            DgvPersonal.Rows[index].Selected = true;
        }

        private async void DgvPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEditPersonal editPersonal = new FormEditPersonal(Manager,personales[e.RowIndex].Id);
            if(editPersonal.ShowDialog() == DialogResult.OK)
            {
                await Task.Delay(1000);

                personales = await personalController.GetHalfPersonal();

                if (personales == null)
                {
                    MessageBox.Show("Нет соединения с сервером", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    return;
                }

                try
                {
                    FillPersonalDGV();
                }
                catch
                {
                    Close();
                    return;
                }
            }
        }
    }
}
