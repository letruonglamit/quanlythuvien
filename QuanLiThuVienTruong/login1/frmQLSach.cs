using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }
        
       
        private void frmQLSach_Load(object sender, EventArgs e)
        {
            this.laybangsach();
            this.LayTheLoaiSach();
            
        }
        public void LayTheLoaiSach()
        {


            KetNoi kn = new KetNoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select MaLoaiSach, TenLoai, KieuSach from LoaiSach";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbbMaLoaiSach.DataSource = table_MK;
            cbbMaLoaiSach.DisplayMember = table_MK.Columns["TenLoai"].ToString(); // hien thi vao trong comboBox
            cbbMaLoaiSach.ValueMember = table_MK.Columns["MaLoaiSach"].ToString();// gia tri luu vao coboBox
            kn.kn.Close();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") errorProvider1.SetError(txtMaSach, "Bạn chưa nhập mã sách"); // bat loi khi chua nhap ma sach
            if (txtTenSach.Text == "") errorProvider1.SetError(txtTenSach, "Bạn chưa nhập tên sách");
            if (cbbMaLoaiSach.ValueMember.ToString() == "") errorProvider1.SetError(cbbMaLoaiSach, "Bạn chưa chọn loại sach");
            if (txtSoLuong.Text == "") errorProvider1.SetError(txtSoLuong, "Bạn chưa nhập số lượng sách");
            if (txtTacGia.Text == "") errorProvider1.SetError(txtTacGia, "Bạn chưa nhập tác giả");
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtTacGia.Text != "" && txtSoLuong.Text != "" && cbbMaLoaiSach.Text != "")// thuc hien lenh neu tat ca textBox khong trong
            {
                
                KetNoi kn = new KetNoi();   // ket noi lai
                int kq = kn.xulydulieu("insert into Sach(MaSach, TenSach, MaLoaiSach, SoLuong, TacGia) values ('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + cbbMaLoaiSach.SelectedValue.ToString() + "','" + txtSoLuong.Text + "',N'" + txtTacGia.Text + "')"); // thuc thi lenh insert trong sql
                if (kq > 0) MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK);    // thong bao insert thanh cong
                else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);

            }
            this.laybangsach();
        }

       public void laybangsach()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select MaSach, TenSach, s.MaLoaiSach, TenLoai, SoLuong, TacGia from Sach s, LoaiSach ls where s.MaLoaiSach = ls.MaLoaiSach");
            dgvQLSach.DataSource = dt;
        }

        private void cbbMaLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) this.Close();
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaSach, "");// tat bat loi khi textBox Ma Sach co du lieu
            errorProvider1.SetError(txtTenSach, "");
            errorProvider1.SetError(cbbMaLoaiSach, "");
            errorProvider1.SetError(txtSoLuong, "");
            errorProvider1.SetError(txtTacGia, "");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") errorProvider1.SetError(txtMaSach, "Bạn chưa nhập mã sách"); // bat loi khi chua nhap ma sach
            if (txtTenSach.Text == "") errorProvider1.SetError(txtTenSach, "Bạn chưa nhập tên sách");
            if (cbbMaLoaiSach.ValueMember.ToString() == "") errorProvider1.SetError(cbbMaLoaiSach, "Bạn chưa chọn loại sach");
            if (txtSoLuong.Text == "") errorProvider1.SetError(txtSoLuong, "Bạn chưa nhập số lượng sách");
            if (txtTacGia.Text == "") errorProvider1.SetError(txtTacGia, "Bạn chưa nhập tác giả");
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtTacGia.Text != "" && txtSoLuong.Text != "" && cbbMaLoaiSach.Text != "")// thuc hien lenh neu tat ca textBox khong trong
            {

                KetNoi kn = new KetNoi();   // ket noi lai
                int kq = kn.xulydulieu("update Sach set TenSach=N'"+txtTenSach.Text+"',MaLoaiSach='"+cbbMaLoaiSach.SelectedValue.ToString()+"',SoLuong='"+txtSoLuong.Text+"',TacGia=N'"+txtTacGia.Text+"' where MaSach = '"+txtMaSach.Text+"'"); // thuc thi lenh insert trong sql
                if (kq > 0) MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);    // thong bao upload thanh cong
                else MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);

            }
            this.laybangsach();
        }

        private void dgvQLSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvQLSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                cbbMaLoaiSach.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
                txtTacGia.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") errorProvider1.SetError(txtMaSach, "Bạn chưa nhập mã sách"); // bat loi khi chua nhap ma sach
            if (txtTenSach.Text == "") errorProvider1.SetError(txtTenSach, "Bạn chưa nhập tên sách");
            if (cbbMaLoaiSach.ValueMember.ToString() == "") errorProvider1.SetError(cbbMaLoaiSach, "Bạn chưa chọn loại sach");
            if (txtSoLuong.Text == "") errorProvider1.SetError(txtSoLuong, "Bạn chưa nhập số lượng sách");
            if (txtTacGia.Text == "") errorProvider1.SetError(txtTacGia, "Bạn chưa nhập tác giả");
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtTacGia.Text != "" && txtSoLuong.Text != "" && cbbMaLoaiSach.Text != "") // thuc hien lenh neu tat ca textBox khong trong
            {

                KetNoi kn = new KetNoi();   // ket noi lai
                int kq = kn.xulydulieu("delete from Sach where MaSach = '"+txtMaSach.Text+"'"); // thuc thi lenh insert trong sql
                if (kq > 0) MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);    // thong bao Xoa thanh cong
                else MessageBox.Show("Xóa thất bại, có người đang mượn", "Thông báo", MessageBoxButtons.OK);

            }
            this.laybangsach();
        }

        private void dgvQLSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvQLSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                cbbMaLoaiSach.Text = row.Cells[3].Value.ToString();
                txtSoLuong.Text = row.Cells[4].Value.ToString();
                txtTacGia.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        

    }
}
