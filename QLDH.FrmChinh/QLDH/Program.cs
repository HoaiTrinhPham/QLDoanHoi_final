using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLDH
{
    static class Program
    {
        public static bool kiemtradangnhap = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
            if (kiemtradangnhap == true)
                Application.Run(new Form1());

        }
    }
}
