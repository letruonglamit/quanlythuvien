using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
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
            Application.Run(new frmLogin());
            //Application.Run(new frmQLSach());
            //Application.Run(new frmQLDocGia());
            //Application.Run(new frmQLNguoiDung());
            //Application.Run(new frmMain());
            //Application.Run(new frmMuonTra());
            //Application.Run(new frmTimKiem());
        }
    }
}
