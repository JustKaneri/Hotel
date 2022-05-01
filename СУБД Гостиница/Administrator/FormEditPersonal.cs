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
    public partial class FormEditPersonal : Form
    {
        private MainManager Manager;
        private PersonalController personalController;
        private int Id_Personal;
        private List<Post> posts;
        private PersonalInfo personal;

        public FormEditPersonal(MainManager manager, int id_Personal)
        {
            InitializeComponent();

            Manager = manager;
            Id_Personal = id_Personal;

            personalController = Manager.GetPersonalController();
        }

        private async void FormEditPersonal_Load(object sender, EventArgs e)
        {
            posts = await personalController.GetPosts();

            if (posts == null)
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            personal = await personalController.GetPersonalInfo(Id_Personal);

            if(personal == null)
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            try
            {
                FillCmb();
                FillData();
            }
            catch
            {
                return;
            }
        }

        private void FillCmb()
        {
            foreach (var item in posts)
            {
                CmbxPost.Items.Add(item.Name);
            }
        }

        private void FillData()
        {
            TbxFam.Text = personal.Fam;
            TbxName.Text = personal.Name;
            TbxOtch.Text = personal.Othc;
            TbxNomer.Text = personal.PasportN;
            TbxSeria.Text = personal.PasportS;
            DtmBorn.Value = personal.DateBorn ?? DateTime.Now;
            TbxInn.Text = personal.INN;
            TbxLogin.Text = personal.Login;
            TbxPass.Text = personal.Password;
            CmbxPost.SelectedIndex = posts.IndexOf(posts.Where(ps => ps.Name.Equals(personal.PostPersonal.Name[0])).First());
        }

    }
}
