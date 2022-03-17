using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Гостиница.Porte
{
    public partial class FormOformlen : Form
    {
        public FormOformlen()
        {
            InitializeComponent();
        }

        private Calendar calendar;

        private void FormOformlen_Load(object sender, EventArgs e)
        {
            BtnReg.FlatAppearance.BorderColor = Colors.BorderButton;

            CurrentYear.Text = DateTime.Now.Year + " Год";

            List<DateTime> dtSt = new List<DateTime>();
            dtSt.Add(new DateTime(2022, 3, 1));
            dtSt.Add(new DateTime(2022, 3, 17));

            List<DateTime> dtFn = new List<DateTime>();
            dtFn.Add(new DateTime(2022, 3, 15));
            dtFn.Add(new DateTime(2022, 4, 2));

            calendar = new Calendar(dtSt, dtFn);
            FillCalendar(calendar.SetNowMont(),calendar.NameMonth);
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

        private void BtnReg_MouseEnter(object sender, EventArgs e)
        {
            BtnReg.BackColor = Colors.ButtonMousEnter;
            BtnReg.ForeColor = Colors.ButtonForeSelect;
        }

        private void BtnReg_MouseLeave(object sender, EventArgs e)
        {
            BtnReg.BackColor = Colors.ButtonMousLeave;
            BtnReg.ForeColor = Colors.ButtonForeNoSelect;
        }

        private void CbxExsist_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxExsist.Checked)
                CmbxFam.DropDownStyle = ComboBoxStyle.DropDownList;
            else
                CmbxFam.DropDownStyle = ComboBoxStyle.DropDown;
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
