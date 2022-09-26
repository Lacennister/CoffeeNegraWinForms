using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeNegraWinForms.Class
{
    public class TimeAvailability
    {
        public bool Monday = false;
        public bool Tuesday = false;
        public bool Wednesday = false;
        public bool Thursday = false;
        public bool Friday = false;
        public bool Saturday = false;
        public bool Sunday = false;

        public override string ToString()
        {
            List<string> availability = new List<string>();

            if (Monday) { availability.Add("Monday"); }
            if (Tuesday) { availability.Add("Tuesday"); }
            if (Wednesday) { availability.Add("Wednesday"); }
            if (Thursday) { availability.Add("Thursday"); }
            if (Friday) { availability.Add("Friday"); }
            if (Saturday) { availability.Add("Saturday"); }
            if (Sunday) { availability.Add("Sunday"); }

            string _result = "N/A";
            if (availability.Count > 0)
            {
                _result = string.Join(",", availability);
            }

            return _result;
        }

        public bool ParseFromString(string _availability)
        {
            if (_availability == "N/A") return true;

            if (_availability.Contains(","))
            {
                string[] days = _availability.Split(',');
                foreach (string day in days)
                {
                    if (day.Trim().ToUpper() == "MONDAY") { Monday = true; }
                    if (day.Trim().ToUpper() == "TUESDAY") { Tuesday = true; }
                    if (day.Trim().ToUpper() == "WEDNESDAY") { Wednesday = true; }
                    if (day.Trim().ToUpper() == "THURSDAY") { Thursday = true; }
                    if (day.Trim().ToUpper() == "FRIDAY") { Friday = true; }
                    if (day.Trim().ToUpper() == "SATURDAY") { Saturday = true; }
                    if (day.Trim().ToUpper() == "SUNDAY") { Sunday = true; }
                }

                if (Monday==false &&
                    Tuesday == false &&
                    Wednesday == false &&
                    Thursday == false &&
                    Friday == false &&
                    Saturday == false && Sunday == false)
                {
                    return false;
                }
            }
            else
            {
                if (_availability.Trim().ToUpper() == "MONDAY") { Monday = true; return true; }
                if (_availability.Trim().ToUpper() == "TUESDAY") { Tuesday = true; return true; }
                if (_availability.Trim().ToUpper() == "WEDNESDAY") { Wednesday = true; return true; }
                if (_availability.Trim().ToUpper() == "THURSDAY") { Thursday = true; return true; }
                if (_availability.Trim().ToUpper() == "FRIDAY") { Friday = true; return true; }
                if (_availability.Trim().ToUpper() == "SATURDAY") { Saturday = true; return true; }
                if (_availability.Trim().ToUpper() == "SUNDAY") { Sunday = true; return true; }
            }

            return true;

        }

        public string[] toShowOnDataGridView(string employeeName)
        {
            List<string> schedule = new List<string>();
            if (Monday) { schedule.Add(employeeName); } else { schedule.Add(""); }
            if (Tuesday) { schedule.Add(employeeName); } else { schedule.Add(""); }
            if (Wednesday) { schedule.Add(employeeName); } else { schedule.Add(""); }
            if (Thursday) { schedule.Add(employeeName); } else { schedule.Add(""); }
            if (Friday) { schedule.Add(employeeName); } else { schedule.Add(""); }
            if (Saturday) { schedule.Add(employeeName); } else { schedule.Add(""); }
            if (Sunday) { schedule.Add(employeeName); } else { schedule.Add(""); }
            return schedule.ToArray();
        }
    }
}
