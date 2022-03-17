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
    public partial class FormRemont : Form
    {
        private Calendar calendar;

        public FormRemont()
        {
            InitializeComponent();
        }

        private void FormRemont_Load(object sender, EventArgs e)
        {
            CurrentYear.Text = DateTime.Now.Year + " Год";

            List<DateTime> dtSt = new List<DateTime>();
            dtSt.Add(new DateTime(2022, 3, 1));
            dtSt.Add(new DateTime(2022, 3, 17));

            List<DateTime> dtFn = new List<DateTime>();
            dtFn.Add(new DateTime(2022, 3, 15));
            dtFn.Add(new DateTime(2022, 4, 2));

            calendar = new Calendar(dtSt, dtFn);
            FillCalendar(calendar.SetNowMont(), calendar.NameMonth);
        }

        private void FillCalendar(List<Calendar.DayMonth> list, string name)
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

                DgvCalendar[list[i].NumWeek - 1, row].Value = list[i].Name;

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

        private void BtnRem_MouseEnter(object sender, EventArgs e)
        {
            BtnRem.BackColor = Colors.ButtonMousEnter;
            BtnRem.ForeColor = Colors.ButtonForeSelect;
        }

        private void BtnRem_MouseLeave(object sender, EventArgs e)
        {
            BtnRem.BackColor = Colors.ButtonMousLeave;
            BtnRem.ForeColor = Colors.ButtonForeNoSelect;
        }

        private void LbxNextMonth_Click(object sender, EventArgs e)
        {
            FillCalendar(calendar.NextMonth(), calendar.NameMonth);
            
        }

        private void LbxLastMonth_Click(object sender, EventArgs e)
        {
            FillCalendar(calendar.PrevMonth(), calendar.NameMonth);
        }
    }
}
