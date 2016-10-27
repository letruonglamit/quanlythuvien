using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLiThuVien;

namespace QuanLiThuVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=AL;Initial Catalog=QLTV;Integrated Security=True"); //krt noi csdl
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE TenDangNhap = '" + txtUserName.Text + "' AND MatKhau = '" + txtPassword.Text + "'",con);
            SqlDataReader dr; //chua du lieu truy van
            dr = cmd.ExecuteReader();
            
            
            int count = 0;
            // kiem tra
            while(dr.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmMain frM = new frmMain();
                frM.Show();
                this.Hide();
            }
            else if(count > 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            }
            txtPassword.Clear();
            txtUserName.Clear();
            con.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
