using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CSKH_SALONOTO.Class;

namespace CSKH_SALONOTO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Progress sql01 = new Progress();


            if (sql01.connect(@".\SQLEXPRESS;", "CSKH_OTO;") == true)
            {
                Application.Run(new Main());
            }
            else
            {
                MessageBox.Show("Không thể kết nối tới database");
                Application.Exit();
            }

            
        }
    }
}
// drop down style = drop down list ( Combo ko thể chèn kỳ tự );