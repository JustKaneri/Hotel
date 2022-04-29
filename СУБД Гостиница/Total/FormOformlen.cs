using HotelAPI;
using HotelAPI.Client.Controller;
using HotelAPI.Client.Model;
using HotelAPI.Regestry.Controler;
using HotelAPI.Regestry.Model;
using HotelAPI.Rooms.Controller;
using HotelAPI.Rooms.Model;
using HotelAPI.Servis.Controller;
using HotelAPI.Servis.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using СУБД_Гостиница.Total;

namespace СУБД_Гостиница.Porte
{
    public partial class FormOformlen : Form
    {
        private MainManager Manager;
        private int Id_Room;
        private RoomController roomController;
        private RegestryController regestryController;
        private ClientController clientController;
        private ServisController servisController;
        private Calendar calendar;
        private Room room;
        private List<ServisInfo> servis;
        private bool IsEdit = false;
        private ClientInfo client;

        public int Id_Reg { get; private set;}

        public FormOformlen(MainManager manager,int id)
        {
            InitializeComponent();
            Manager = manager;
            Id_Room = id;

            roomController = Manager.GetRoomController();
            regestryController = Manager.GetRegestryController();
            clientController = Manager.GetClientController();
            servisController = Manager.GetServisController();

            DtmFinish.MinDate = DateTime.Now;
        }

        private async void FormOformlen_Load(object sender, EventArgs e)
        {
            string conect = await Manager.GetConect();

            if (!conect.Equals("OK"))
            {
                MessageBox.Show("Нет соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            RoomHistory history = await roomController.GetHistoryRoom(Id_Room);

            CurrentYear.Text = DateTime.Now.Year + " год";

            calendar = new Calendar(history.DateStart, history.DateFinish);
            FillCalendar(calendar.SetNowMont(), calendar.NameMonth);

            room = await roomController.GetRoomInfoAsync(Id_Room);

            servis = await servisController.GetServis();

            FillServisDgv();
        }

        private void FillServisDgv()
        {
            foreach (var item in servis)
            {
                DgvServis.Rows.Add(item.Name, item.Count, item.Price);
            }
        }

        private void FillCalendar(List<Calendar.DayMonth> list,string name)
        {
            LbxMonthName.Text = name;

            DgvCalendar.Rows.Clear();
            for (int i = 0; i < 6; i++)
            {
                DgvCalendar.Rows.Add();
            }

            int row = 0;

            for (int i = 0; i < list.Count; i++)
            {

                DgvCalendar[list[i].NumWeek-1 , row].Value = list[i].Name;

                if (!list[i].IsFree)
                {
                    DgvCalendar[list[i].NumWeek - 1, row].Style.BackColor = Colors.ColorSelectPanelRoom;
                    DgvCalendar[list[i].NumWeek - 1, row].Style.SelectionBackColor = Colors.ColorSelectPanelRoom;
                }

                if (list[i].NumWeek == 7)
                {
                    row++;
                }

            }
        }

        private void LbxNextMonth_Click(object sender, EventArgs e)
        {
            FillCalendar(calendar.NextMonth(), calendar.NameMonth);
        }

        private void LbxLastMonth_Click(object sender, EventArgs e)
        {
            FillCalendar(calendar.PrevMonth(), calendar.NameMonth);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            FormSelectClient selectClient = new FormSelectClient(Manager);
            if(selectClient.ShowDialog() == DialogResult.OK)
            {
                IsEdit = true;
                GetSelectClient(selectClient.CurrentId);
            }
        }
        
        private async void GetSelectClient(int id)
        {
            client = await clientController.GetClientInfo(id);

            TbxFam.Text = client.Fam;
            TbxName.Text = client.Name;
            TbxOtch.Text = client.Othc;
            TbxNomer.Text = client.PasportN;
            TbxSeria.Text = client.PasportS;
            TbxPhone.Text = client.Phone;
        }

        private void CheckData()
        {
            if (string.IsNullOrWhiteSpace(TbxFam.Text))
                throw new Exception("Введите фамилию");

            if (string.IsNullOrWhiteSpace(TbxName.Text))
                throw new Exception("Введите имя");

            if (string.IsNullOrWhiteSpace(TbxNomer.Text))
                throw new Exception("Введите номер паспорта");

            if (string.IsNullOrWhiteSpace(TbxSeria.Text))
                throw new Exception("Введите серию паспорта");

            int tmp = 0;

            if (!int.TryParse(TbxNomer.Text, out tmp))
                throw new Exception("Не корректное значение номера паспорта");

            if (!int.TryParse(TbxSeria.Text, out tmp))
                throw new Exception("Не корректное значение серии паспорта");

            string phone = TbxPhone.Text;

            phone = phone.Replace(" ", "");

            if (phone.Length < 11)
                throw new Exception("Не корректный номер");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            client = null;
            IsEdit = false;
            TbxFam.Clear();
            TbxName.Clear();
            TbxOtch.Clear();
            TbxPhone.Clear();
            TbxSeria.Clear();
            TbxNomer.Clear();
        }

        private async void BtnReg_Click(object sender, EventArgs e)
        {
            if(!CheckServis())
            {
                MessageBox.Show("Укажите корректное значение в кол-во доп. услуг","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CheckData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show($"Проживание в номере будет стоить: {GetPrice()}\r\nПродолжить?", "Цена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
                return;

            string resulClient = "";

            if(IsEdit)
            {
                resulClient = await EditClient();
            }
            else
            {
                resulClient = await AddClient();
            }

            if (resulClient.Equals("Not Conect"))
            {
                MessageBox.Show("Не удалось зарегистрировать данного пользователя","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Regestration reg = new Regestration();
            reg.Id_Client = client.Id;
            reg.Id_Nomer = room.Id;
            reg.FullPrice = (float)GetPrice();
            reg.DateStart = DtmStart.Value;
            reg.DateEnd = DtmFinish.Value;

            string result = await regestryController.Registration(reg);

            if (result.Equals("Not Conect"))
            {
                MessageBox.Show("Не удалось зарегистрировать данного пользователя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Id_Reg = int.Parse(result);


            for (int i = 0; i < DgvServis.RowCount; i++)
            {
                if (DgvServis[3, i].Value == null)
                    continue;


                if (DgvServis[4,i].Value.ToString().ToLower().Equals("true"))
                {
                    int count = int.Parse(DgvServis[3, i].Value.ToString());
                    result = await servisController.AddServisInRegestry(Id_Reg, servis[i].Id_Servis,count);
                }
            }

            MessageBox.Show("Клиент зарегистрирован", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            DialogResult = DialogResult.OK;

        }

        private double GetPrice()
        {
            int countDay = (int)Math.Round((DtmFinish.Value - DtmStart.Value).TotalDays) + 1;

            int summ = 0;

            for (int i = 0; i < DgvServis.RowCount; i++)
            {
                if (DgvServis[4, i].Value == null)
                    continue;

                if (DgvServis[4, i].Value.ToString().ToLower().Equals("true"))
                {
                    int price = int.Parse(DgvServis[2, i].Value.ToString());

                    int count = -1;

                    if (DgvServis[3, i].Value == null)
                        continue;

                    int.TryParse(DgvServis[3, i].Value.ToString(), out count);


                    summ += count * price;
                }
            }

            return room.Money * countDay + summ;
        }

        private bool CheckServis()
        {
            for (int i = 0; i < DgvServis.RowCount; i++)
            {
                if (DgvServis[4, i].Value == null)
                    continue;

                if (DgvServis[4, i].Value.ToString().ToLower().Equals("true"))
                {
                    int all = int.Parse(DgvServis[1, i].Value.ToString());

                    int count = -1;

                    if (DgvServis[3, i].Value == null)
                        continue;

                    int.TryParse(DgvServis[3, i].Value.ToString(), out count);

                    if (count == -1)
                        return false;

                    if (all - count < 0)
                        return false;
                }
            }

            return true;

        }

        private async Task<string> AddClient()
        {
            client = new ClientInfo();
            client.Fam = TbxFam.Text;
            client.Name = TbxName.Text;
            client.Othc = TbxOtch.Text;
            client.PasportN = TbxNomer.Text;
            client.PasportS = TbxSeria.Text;
            client.Phone = TbxPhone.Text;

            string result = await clientController.AddClient(client);

            int tmp = 0;

            if(int.TryParse(result,out tmp))
            {
                client.Id = int.Parse(result);
            }

            return result;
        }

        private async Task<string> EditClient()
        {
            client.Fam = TbxFam.Text;
            client.Name = TbxName.Text;
            client.Othc = TbxOtch.Text;
            client.PasportN = TbxNomer.Text;
            client.PasportS = TbxSeria.Text;
            client.Phone = TbxPhone.Text;

            string result = await clientController.UpdateClient(client);

            return result;
        }
    }
}
