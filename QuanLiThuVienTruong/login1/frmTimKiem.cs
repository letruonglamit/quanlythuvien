using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class frmTimKiem : Form
    {
        string _timKiem;

        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            
            if(_timKiem=="docgia")
            {
              
                KetNoi kn = new KetNoi();
                DataTable dt = new DataTable();
                dt = kn.laybang("select * from NguoiMuon,MuonTra where NguoiMuon.MaDG = MuonTra.MaDG and TenDG = N'" + txtTimKiem.Text + "'");
                dgvTimKiem.DataSource = dt;
                
            }

            if(_timKiem=="sach")
            {
             
                if (cbbTimSach.Text == "Tên sách")
                {
                    KetNoi kn = new KetNoi();
                    DataTable dt = new DataTable();
                    dt = kn.laybang("select TenSach, MaSach,TenLoai,SoLuong,TacGia from LoaiSach,Sach where LoaiSach.MaLoaiSach = Sach.MaLoaiSach AND TenSach = N'" + txtTimKiem.Text + "'");
                    dgvTimKiem.DataSource = dt;
                }
                if (cbbTimSach.Text == "Thể loại")
                {
                    KetNoi kn = new KetNoi();
                    DataTable dt = new DataTable();
                    dt = kn.laybang("select * from Sach,LoaiSach where  Sach.MaLoaiSach = LoaiSach.MaLoaiSach and TenLoai = N'" + txtTimKiem.Text + "'");
                    dgvTimKiem.DataSource = dt;
                }

                if (cbbTimSach.Text == "Tác giả")
                {
                    KetNoi kn = new KetNoi();
                    DataTable dt = new DataTable();
                    dt = kn.laybang("select * from Sach where  TacGia = N'" + txtTimKiem.Text + "'");
                    dgvTimKiem.DataSource = dt;
                }
            }
        }

        private void rdbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTimTenDocGia.Checked) _timKiem = "docgia";
            else if (rdbTimSach.Checked) _timKiem = "sach";
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            rdbTimTenDocGia.Checked=true;
            cbbTimSach.Text = "Tên sách";
        }
    }
}
