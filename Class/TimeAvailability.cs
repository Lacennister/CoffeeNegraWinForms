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
                    if (day.ToUpper() == "MONDAY") { Monday = true; }
                    if (day.ToUpper() == "TUESDAY") { Tuesday = true; }
                    if (day.ToUpper() == "WEDNESDAY") { Wednesday = true; }
                    if (day.ToUpper() == "THURSDAY") { Thursday = true; }
                    if (day.ToUpper() == "FRIDAY") { Friday = true; }
                    if (day.ToUpper() == "SATURDAY") { Saturday = true; }
                    if (day.ToUpper() == "SUNDAY") { Sunday = true; }
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
                if (_availability.ToUpper() == "MONDAY") { Monday = true; return true; }
                if (_availability.ToUpper() == "TUESDAY") { Tuesday = true; return true; }
                if (_availability.ToUpper() == "WEDNESDAY") { Wednesday = true; return true; }
                if (_availability.ToUpper() == "THURSDAY") { Thursday = true; return true; }
                if (_availability.ToUpper() == "FRIDAY") { Friday = true; return true; }
                if (_availability.ToUpper() == "SATURDAY") { Saturday = true; return true; }
                if (_availability.ToUpper() == "SUNDAY") { Sunday = true; return true; }
            }

            return false;

        }
    }
}
