using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class frmQLNguoiDung : Form
    {
        public frmQLNguoiDung()
        {
            InitializeComponent();
        }

        //thoat
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) this.Close();
        }


        //Nhap lai
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtResMatKhauMoi.Text = "";
            txtTenDangNhap.Text = "";
        }

        //Thay doi
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AL;Initial Catalog=QLTV;Integrated Security=True");// tao ketnoi
            con.Open();//mo ket noi
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE TenDangNhap = '" + txtTenDangNhap.Text + "' AND MatKhau = '" + txtMatKhauCu.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
            }
            con.Close();
            if (count == 1)
            {
                
                if (txtMatKhauMoi.Text != txtResMatKhauMoi.Text) MessageBox.Show("Mật khẩu nhập lại không đúng", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    
                    int kq = 0;
                    try
                    {
                        con.Open();
                        SqlCommand lenh = new SqlCommand("update Login set MatKhau='"+txtResMatKhauMoi.Text+"' where TenDangNhap = '"+txtTenDangNhap.Text+"'", con);
                        kq = lenh.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                       
                        //Thông báo lỗi ra!
                        kq = 0;
                    }
                    finally
                    {
                        con.Close();
                    }
                    MessageBox.Show(kq.ToString(), "Thông báo", MessageBoxButtons.OK);
                    if (kq > 0) MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
                    else MessageBox.Show("Thay đổi thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
            
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
            //txt.Clear();
            //txtUserName.Clear();
            con.Close();
        }
    }
}
