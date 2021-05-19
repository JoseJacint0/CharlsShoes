using CharlsShoes.DAL;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CharlsShoes.Win
{
    static class Program
    {
        private static CharlsShoesContext charlsShoesContext = new CharlsShoesContext();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //migracion en caso de que exista
            charlsShoesContext.Database.Migrate();

            if (new frmLogin().ShowDialog() == DialogResult.OK)
                Application.Run(new frmMain());
        }
    }
}
