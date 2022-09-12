using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeNegraWinForms.Database
{
    public class databasePath
    {
        public string dbpath = System.IO.Path.Combine(Environment.CurrentDirectory, "main.db");
    }
}
