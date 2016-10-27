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
    public partial class frmQLDocGia : Form
    {
        public frmQLDocGia()
        {
            InitializeComponent();
        }

        private void frmQLDocGia_Load(object sender, EventArgs e)
        {
            this.laybangsach();

        }

        string temp;
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (txtMaDocGia.Text == "") errorProvider1.SetError(txtMaDocGia, "Bạn chưa nhập mã độc giả"); // bat loi khi chua nhap ma docgia
            if (txtTenDocGia.Text == "") errorProvider1.SetError(txtTenDocGia, "Bạn chưa nhập tên độc giả");
            if (txtGioiTinh.Text == "") errorProvider1.SetError(txtGioiTinh, "Bạn chưa nhập giới tính");
            if (txtLop.Text == "") errorProvider1.SetError(txtLop, "Bạn chưa nhập lớp");
            if (txtNgayS.Text == "" && txtThangS.Text!=""&&txtNamS.Text !="") errorProvider1.SetError(txtNamS, "Bạn chưa nhập ngày sinh");


            if (txtNgayM.Text == "" && txtThangM.Text == "" && txtNamM.Text == "") temp = "KhongCoNgayMuon";
            else if (txtNgayM.Text != "" && txtThangM.Text != "" && txtNamM.Text != "") temp = "CoNgayMuon";
            else errorProvider1.SetError(txtNamM, "Bạn nhập chưa đủ ngày mượn");
            //MessageBox.Show(temp);
            if (txtMaDocGia.Text != "" && txtTenDocGia.Text != "" && txtGioiTinh.Text != "" && txtLop.Text != "")// thuc hien lenh neu tat ca textBox khong trong
            {

                KetNoi kn = new KetNoi();   // ket noi lai
                if (temp == "CoNgayMuon")
                {
                    int kq = kn.xulydulieu("insert into NguoiMuon(MaDG, TenDG, GioiTinh, Lop, NgaySinh, NgayMuon) values ('" + txtMaDocGia.Text + "',N'" + txtTenDocGia.Text + "',N'" + txtGioiTinh.Text + "','"+txtLop.Text+"','" + txtNamS.Text + "-" + txtThangS.Text + "-" + txtNgayS.Text + "','" + txtNamM.Text + "-" + txtThangM.Text + "-" + txtNgayM.Text + "')"); // thuc thi lenh insert trong sql
                    if (kq > 0) MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);    // thong bao insert thanh cong
                    else MessageBox.Show("Thêm thất bại, hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                }
                else if(temp =="KhongCoNgayMuon")
                {
                    int kq = kn.xulydulieu("insert into NguoiMuon(MaDG, TenDG, GioiTinh, Lop, NgaySinh) values ('" + txtMaDocGia.Text + "',N'" + txtTenDocGia.Text + "',N'" + txtGioiTinh.Text + "','" + txtLop.Text + "','" + txtNamS.Text + "-" + txtThangS.Text + "-" + txtNgayS.Text + "')"); // thuc thi lenh insert trong sql
                    if (kq > 0) MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);    // thong bao insert thanh cong
                    else MessageBox.Show("Thêm thất bại, hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                }
                

            }
            this.laybangsach(); // hien thi lai data gritvew
        }
        public void laybangsach()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select * from NguoiMuon");
            dgvQLDocGia.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) this.Close();
        }


        // Tat bat loi
        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaDocGia, "");// tat bat loi khi textBox Ma Sach co du lieu
            errorProvider1.SetError(txtTenDocGia, "");
            errorProvider1.SetError(txtLop, "");
            errorProvider1.SetError(txtNgayS, "");
            errorProvider1.SetError(txtGioiTinh, "");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "") errorProvider1.SetError(txtMaDocGia, "Bạn chưa nhập mã độc giả"); // bat loi khi chua nhap ma docgia
            if (txtTenDocGia.Text == "") errorProvider1.SetError(txtTenDocGia, "Bạn chưa nhập tên độc giả");
            if (txtGioiTinh.Text == "") errorProvider1.SetError(txtGioiTinh, "Bạn chưa nhập giới tính");
            if (txtLop.Text == "") errorProvider1.SetError(txtLop, "Bạn chưa nhập lớp");
            if (txtNgayS.Text == "" && txtThangS.Text != "" && txtNamS.Text != "") errorProvider1.SetError(txtNgayS, "Bạn chưa nhập ngày sinh");
            if (txtNgayM.Text == "" && txtThangM.Text == "" && txtNamM.Text != "") temp = "KhongCoNgayMuon";
            else if (txtNgayS.Text != "" && txtThangS.Text != "" && txtNamS.Text != "") temp = "CoNgayMuon";
            else errorProvider1.SetError(txtLop, "Bạn nhập chưa đủ ngày mượn");
                      
                          
            KetNoi kn = new KetNoi();   // ket noi lai
            int kq = kn.xulydulieu("update NguoiMuon set TenDG=N'" + txtTenDocGia.Text + "', GioiTinh=N'" + txtGioiTinh.Text + "', NgaySinh='" + txtNamS.Text + "-" + txtThangS.Text + "-" + txtNgayS.Text + "', NgayMuon='" + txtNamM.Text + "-" + txtThangM.Text + "-" + txtNgayM.Text + "' where MaDG='" + txtMaDocGia.Text + "'"); // thuc thi lenh insert trong sql
            if (kq > 0) MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);    // thong bao insert thanh cong
            else MessageBox.Show("Sửa thất bại, hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            
            this.laybangsach();
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvQLDocGia.Rows[e.RowIndex];
                txtMaDocGia.Text = row.Cells[0].Value.ToString();
                txtTenDocGia.Text = row.Cells[1].Value.ToString();
                txtGioiTinh.Text = row.Cells[2].Value.ToString();
                txtLop.Text = row.Cells[3].Value.ToString();
                string _ngaySinh = row.Cells[4].Value.ToString();
                txtNamS.Text = _ngaySinh[6].ToString() + _ngaySinh[7].ToString() + _ngaySinh[8].ToString() + _ngaySinh[9].ToString();
                txtThangS.Text = _ngaySinh[3].ToString() + _ngaySinh[4].ToString();
                txtNgayS.Text = _ngaySinh[0].ToString() + _ngaySinh[1].ToString();
                string _ngayMuon = row.Cells[5].Value.ToString();
                txtNamM.Text = _ngayMuon[6].ToString() + _ngayMuon[7].ToString() + _ngayMuon[8].ToString() + _ngayMuon[9].ToString();
                txtThangM.Text = _ngayMuon[3].ToString() + _ngayMuon[4].ToString();
                txtNgayM.Text = _ngayMuon[0].ToString() + _ngayMuon[1].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (txtMaDocGia.Text != "" && txtTenDocGia.Text != "" && txtGioiTinh.Text != "" && txtLop.Text != "") // thuc hien lenh neu tat ca textBox khong trong
            {

                KetNoi kn = new KetNoi();   // ket noi lai
                int kq = kn.xulydulieu("delete from NguoiMuon where MaDG = '" + txtMaDocGia.Text + "'"); // thuc thi lenh insert trong sql
                if (kq > 0) MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);    // thong bao Xoa thanh cong
                else MessageBox.Show("Xóa thất bại, hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK);

            }
            this.laybangsach();
        }



        // lay gia tri tu bang datagritvew len txt
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvQLDocGia.Rows[e.RowIndex];
                txtMaDocGia.Text = row.Cells[0].Value.ToString();
                txtTenDocGia.Text = row.Cells[1].Value.ToString();
                txtGioiTinh.Text = row.Cells[2].Value.ToString();
                txtLop.Text = row.Cells[3].Value.ToString();
                string _ngaySinh = row.Cells[4].Value.ToString();
                txtNamS.Text = _ngaySinh[6].ToString() + _ngaySinh[7].ToString() + _ngaySinh[8].ToString() + _ngaySinh[9].ToString();
                txtThangS.Text = _ngaySinh[3].ToString() + _ngaySinh[4].ToString();
                txtNgayS.Text = _ngaySinh[0].ToString() + _ngaySinh[1].ToString();
                string _ngayMuon = row.Cells[5].Value.ToString();
                txtNamM.Text = _ngayMuon[6].ToString() + _ngayMuon[7].ToString() + _ngayMuon[8].ToString() + _ngayMuon[9].ToString();
                txtThangM.Text = _ngayMuon[3].ToString() + _ngayMuon[4].ToString();
                txtNgayM.Text = _ngayMuon[0].ToString() + _ngayMuon[1].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtThangS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThangM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
