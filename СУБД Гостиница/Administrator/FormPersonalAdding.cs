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
    public partial class FormPersonalAdding : Form
    {
        private MainManager Manager;
        private PersonalController personalController;
        private List<Post> posts;
        private PersonalInfo personal;

        public FormPersonalAdding(MainManager manager)
        {
            InitializeComponent();

            Manager = manager;

            DtmBorn.MaxDate = DateTime.Now.AddYears(-16);

            personalController = Manager.GetPersonalController();
        }

        private async void FormPersonalAdding_Load(object sender, EventArgs e)
        {
            posts = await personalController.GetPosts();

            if (posts == null)
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            try
            {
                FillCmb();
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

            CmbxPost.SelectedIndex = 0;
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
            personal.Login = TbxLogin.Text;
            personal.Password = TbxPass.Text;
            personal.IdPost = posts[CmbxPost.SelectedIndex].Id_Post;
            personal.PostPersonal = new Posts();
            personal.PostPersonal.Name = new List<string>();
            personal.PostPersonal.Name.Add(CmbxPost.SelectedItem.ToString());

        }

        private void CheckData()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
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

            if (!long.TryParse(TbxInn.Text, out tmpL))
                throw new Exception("Не корректное значение ИНН");

            if (!long.TryParse(TbxInn.Text, out tmpL))
                throw new Exception("Не корректное значение полиса");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
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

            personal = new PersonalInfo();

            FillData();

            string resultUpdate = await personalController.AddPersonal(personal);

            if (!resultUpdate.Equals("OK"))
            {
                MessageBox.Show(resultUpdate, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Пользователь добавлен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }
    }
}
