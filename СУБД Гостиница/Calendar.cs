using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СУБД_Гостиница
{
    public class Calendar
    {
        public int CurrentMonth { get; private set; }
        public string NameMonth { get; private set; }
        
        public struct DayMonth
        {
            public string Name;
            public int NumWeek;
            public bool IsFree ;
        }

        public Dictionary<string, List<DayMonth>> Months = new Dictionary<string, List<DayMonth>>();

        private int currentYear;

        public Calendar(List<DateTime> Start,List<DateTime> Finish)
        {
            currentYear = DateTime.Now.Year;

            for (int month = 1; month <= 12; month++)
            {
                int CountDay = DateTime.DaysInMonth(currentYear, month);

                List<DayMonth> dayMonths = new List<DayMonth>();

                for (int day = 1; day <= CountDay; day++)
                {
                    DayMonth dayMonth;
                    dayMonth.IsFree = true;

                    dayMonth.Name = day.ToString();
                    DateTime curretnDate = new DateTime(currentYear, month, day);
                    dayMonth.NumWeek = curretnDate.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)curretnDate.DayOfWeek;
                    dayMonth.IsFree = SetStatusDay(curretnDate, Start, Finish);

                    dayMonths.Add(dayMonth);
                }

                DateTime dt = new DateTime(currentYear, month, 1);

                GetName(month);

                Months.Add(NameMonth, dayMonths);
            }
        }

        private bool SetStatusDay(DateTime date,List<DateTime> Start, List<DateTime> Finish)
        {
            for (int i = 0; i < Start.Count; i++)
            {
                if (date >= Start[i] && date <= Finish[i])
                    return false;
            }

            return true;
        }

        public List<DayMonth> SetNowMont()
        {
            DateTime now = DateTime.Now;

            CurrentMonth = now.Month;
            GetName(CurrentMonth);

            return Months[NameMonth];
        }


        public List<DayMonth> NextMonth()
        {
            if (CurrentMonth + 1 > 12)
                CurrentMonth = 1;
            else
                CurrentMonth++;

            DateTime now = new DateTime(currentYear, CurrentMonth, 1);

            CurrentMonth = now.Month;
            GetName(CurrentMonth);

            return Months[NameMonth];

        }

        public List<DayMonth> PrevMonth()
        {
            if (CurrentMonth - 1 == 0)
                CurrentMonth = 12;
            else
                CurrentMonth--;

            DateTime now = new DateTime(currentYear, CurrentMonth, 1);

            CurrentMonth = now.Month;
            GetName(CurrentMonth);

            return Months[NameMonth];
        }


        private void GetName(int month)
        {
            switch (month)
            {
                case 1:
                    NameMonth = "Январь";
                    break;
                case 2:
                    NameMonth = "Февраль";
                    break;
                case 3:
                    NameMonth = "Март";
                    break;
                case 4:
                    NameMonth = "Апрель";
                    break;
                case 5:
                    NameMonth = "Май";
                    break;
                case 6:
                    NameMonth = "Июнь";
                    break;
                case 7:
                    NameMonth = "Июль";
                    break;
                case 8:
                    NameMonth = "Август";
                    break;
                case 9:
                    NameMonth = "Сентябрь";
                    break;
                case 10:
                    NameMonth = "Октябрь";
                    break;
                case 11:
                    NameMonth = "Ноябрь";
                    break;
                case 12:
                    NameMonth = "Декабрь";
                    break;
            }
        }
    }
}
