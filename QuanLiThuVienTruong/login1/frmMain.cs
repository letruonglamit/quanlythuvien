using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            frmQLSach qls = new frmQLSach();
            qls.Show();
            
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            frmQLDocGia qldg = new frmQLDocGia();
            qldg.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // dong tat ca cac form
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != "frmLogin") thisForm.Close();
            }


            //hien form Login
            frmLogin lg = new frmLogin();
            lg.Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmMuonTra mt = new frmMuonTra();
            mt.Show();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            
        }

        private void tênĐăngNhậpHoặcMậtKhẩuSaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNguoiDung ql = new frmQLNguoiDung();
            ql.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            tk.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) this.Close();
        }
    }
}
