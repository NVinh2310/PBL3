using QuanLyPhuKienDienTu.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuKienDienTu
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
<<<<<<< HEAD
            Application.Run(new FormTaiKhoan());
=======
            Application.Run(new MainForm());
>>>>>>> faf4e8b8fb78404bc567ade5d061232c77e0b3d2
        }
    }
}
