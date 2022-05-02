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

            DtmBorn.MaxDate = DateTime.Now.AddYears(-16);

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
                WriteDataPersonal();
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
            personal.Fam = TbxFam.Text;
            personal.Name = TbxName.Text;
            personal.Othc = TbxOtch.Text;
            personal.PasportN = TbxNomer.Text;
            personal.PasportS = TbxSeria.Text;
            personal.Polic = TbxPolic.Text;
            personal.DateBorn = DtmBorn.Value;
            personal.INN = TbxInn.Text;
            personal.Password = TbxPass.Text;
            personal.IdPost = posts[CmbxPost.SelectedIndex].Id_Post;
            
        }

        private void WriteDataPersonal()
        {
            TbxFam.Text = personal.Fam;
            TbxName.Text = personal.Name;
            TbxOtch.Text = personal.Othc;
            TbxNomer.Text = personal.PasportN;
            TbxSeria.Text = personal.PasportS;
            TbxPolic.Text = personal.Polic;
            DtmBorn.Value = personal.DateBorn ?? DtmBorn.Value;
            TbxInn.Text = personal.INN;
            TbxLogin.Text = personal.Login;
            TbxPass.Text = personal.Password;
            CmbxPost.SelectedIndex = posts.IndexOf(posts.Where(ps => ps.Name.Equals(personal.PostPersonal.Name[0])).First());
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FillData();

            string resultUpdate = await personalController.EditPersonal(personal);

            if(!resultUpdate.Equals("OK"))
            {
                MessageBox.Show("Не удалось сохранить изменения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Изменения сохранены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }

        private async void BtnDel_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Для увольнения работника, введите пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormAssept formAssept = new FormAssept(Manager);
            if (formAssept.ShowDialog() == DialogResult.OK)
            {
                string result = await personalController.DismissalPersonal(Id_Personal);

                if (!result.Equals("OK"))
                {
                    MessageBox.Show("Не удалось уволить работника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Работник уволен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CheckData()
        {
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace((item as TextBox).Text))
                        throw new Exception("Введите " + (item as TextBox).Tag);
                }
            }

            int tmp = 0;

            if (!int.TryParse(TbxNomer.Text, out tmp))
                throw new Exception("Не корректное значение номера паспорта");

            if (!int.TryParse(TbxNomer.Text, out tmp))
                throw new Exception("Не корректное значение серии паспорта");

            long tmpL = 0;

            if (TbxNomer.Text.Length < 6)
                throw new Exception("Не корректное значение номера паспорта");

            if (TbxSeria.Text.Length < 4)
                throw new Exception("Не корректное значение серии паспорта");

            if (TbxInn.Text.Length < 12)
                throw new Exception("Не корректное значение ИНН");

            if (TbxPolic.Text.Length < 16)
                throw new Exception("Не корректное значение полиса");

            if (!long.TryParse(TbxInn.Text,out tmpL))
                throw new Exception("Не корректное значение ИНН");

            if (!long.TryParse(TbxInn.Text, out tmpL))
                throw new Exception("Не корректное значение полиса");
        }


    }
}
