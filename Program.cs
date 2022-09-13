using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeNegraWinForms.Forms;
using CoffeeNegraWinForms.Database;

namespace CoffeeNegraWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dbpath = System.IO.Path.Combine(Environment.CurrentDirectory, "main.db");
            if (System.IO.File.Exists(dbpath) == false)
            {
                databaseSeeder db = new databaseSeeder();
                db.CreateDatabase();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
