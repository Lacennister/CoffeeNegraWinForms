using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeNegraWinForms.Class
{
    public class Deduction
    {
        private string path = System.IO.Path.Combine(Environment.CurrentDirectory, "deductions.csv");

        public int id;
        public string name;
        public string value;

        public List<Deduction> GetAll()
        {
            List<Deduction> listOfDeductions = new List<Deduction>();

            if (System.IO.File.Exists(path) == false) { return listOfDeductions; }

            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] li = line.Split(',');
                Deduction dd = new Deduction() 
                { 
                    id = Convert.ToInt32(li[0]),
                    name = li[1],
                    value = li[2],
                };
                listOfDeductions.Add(dd);
            }

            return listOfDeductions;
        }

        public void Save(List<Deduction> _deductions)
        {
            if (System.IO.File.Exists(path)) System.IO.File.Delete(path);

            using (System.IO.StreamWriter wr = new System.IO.StreamWriter(path))
            {
                foreach (Deduction d in _deductions)
                {
                    string line = String.Join(",", Convert.ToString(d.id), d.name, d.value);
                    wr.WriteLine(line);
                }
                wr.Close();
            }
        }
    }
}
