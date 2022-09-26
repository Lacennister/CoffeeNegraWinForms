using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeNegraWinForms.Class
{
    public class Employee
    {
        public int id;
        public string name;
        public int age;
        public string birthday;
        public string address;
        public string contact;
        public TimeAvailability timeAvailability;

        public TimeAvailability morning;
        public TimeAvailability afternoon;

        public void DataGridViewToEmployee(DataGridViewRow row)
        {
            this.id = (int)row.Cells[0].Value;
            this.name = (string)row.Cells[1].Value;
            this.birthday = Convert.ToString(row.Cells[2].Value);
            this.age = Convert.ToInt16(row.Cells[3].Value);
            this.address = (string)row.Cells[4].Value;
            this.contact = (string)row.Cells[5].Value;

            TimeAvailability _t = new TimeAvailability();
            _t.ParseFromString((string)row.Cells[6].Value);

            this.timeAvailability = _t;

            Console.WriteLine("");
        }
    }


}
