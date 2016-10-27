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
    public partial class frmMuonTra : Form
    {
        public frmMuonTra()
        {
            InitializeComponent();
        }

        string rdb; // khoa muon-tra
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbMuonSAch.Checked)
            {
                // an cac doi tuong trar
                lblT1.Hide();
                lblT2.Hide();
                lblT3.Hide();
                lblT4.Hide();
                txtNgayT.Hide();
                txtThangT.Hide();
                txtNamT.Hide();


                // hien cac doi tuong muon
                lblM1.Show();
                lblM2.Show();
                lblM3.Show();
                lblM4.Show();
                txtNgayM.Show();
                txtThangM.Show();
                txtNamM.Show();

                rdb = "MuonSach";
            }



            if(rdbTraSach.Checked)
            {
                lblM1.Hide();
                lblM2.Hide();
                lblM3.Hide();
                lblM4.Hide();
                txtNgayM.Hide();
                txtThangM.Hide();
                txtNamM.Hide();

                lblT1.Show();
                lblT2.Show();
                lblT3.Show();
                lblT4.Show();
                txtNgayT.Show();
                txtThangT.Show();
                txtNamT.Show();
                rdb = "TraSach";

                txtNamT.Text = "";
                txtNgayT.Text = "";
                txtThangT.Text = "";
            }
        }

        public void laybangmuontra()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select * from MuonTra");
            dgvMuonTra.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "") errorProvider1.SetError(txtMaDocGia, "Bạn chưa nhập mã độc giả"); // bat loi khi chua nhap ma docgia
            if (txtMaSach.Text == "") errorProvider1.SetError(txtMaSach, "Bạn chưa nhập mã sách");
            if (txtSoLuong.Text == "") errorProvider1.SetError(txtSoLuong, "Bạn chưa nhập số lượng");
            
            if (txtNgayM.Text == "" && txtThangM.Text != "" && txtNamM.Text != "") errorProvider1.SetError(txtNamM, "Bạn chưa nhập ngày mượn");
            if (txtNgayH.Text == "" && txtThangH.Text != "" && txtNamH.Text != "") errorProvider1.SetError(txtNamH, "Bạn chưa nhập ngày hẹn trả");
            KetNoi kn = new KetNoi();   // ket noi lai
            int kq = kn.xulydulieu("insert into MuonTra(MaDG, MaSach, SoLuong, NgayMuon, NgayHenTra) values ('" + txtMaDocGia.Text + "',N'" + txtMaSach.Text + "',N'" + txtSoLuong.Text +  "','" + txtNamM.Text + "-" + txtThangM.Text + "-" + txtNgayM.Text + "','" + txtNamH.Text + "-" + txtThangH.Text + "-" + txtNgayH.Text + "')"); // thuc thi lenh insert trong sql
            if (kq > 0) MessageBox.Show("Mượn thành công", "Thông báo", MessageBoxButtons.OK);    // thong bao insert thanh cong
            else MessageBox.Show("Mượn thất bại, hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK);

            this.laybangmuontra();
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            laybangmuontra();
            rdbMuonSAch.Checked = true;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) this.Close();
        }

        private void dgvMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(rdb == "MuonSach")
            {
                try
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dgvMuonTra.Rows[e.RowIndex];
                    txtMaDocGia.Text = row.Cells[0].Value.ToString();
                    txtMaSach.Text = row.Cells[1].Value.ToString();
                    txtSoLuong.Text = row.Cells[2].Value.ToString();
                    string _ngayMuon = row.Cells[3].Value.ToString();
                    txtNamM.Text = _ngayMuon[6].ToString() + _ngayMuon[7].ToString() + _ngayMuon[8].ToString() + _ngayMuon[9].ToString();
                    txtThangM.Text = _ngayMuon[3].ToString() + _ngayMuon[4].ToString();
                    txtNgayM.Text = _ngayMuon[0].ToString() + _ngayMuon[1].ToString();
                    string _ngayHen = row.Cells[4].Value.ToString();
                    txtNamH.Text = _ngayHen[6].ToString() + _ngayHen[7].ToString() + _ngayHen[8].ToString() + _ngayHen[9].ToString();
                    txtThangH.Text = _ngayHen[3].ToString() + _ngayHen[4].ToString();
                    txtNgayH.Text = _ngayHen[0].ToString() + _ngayHen[1].ToString();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message.ToString());
                }
            }
            else if(rdb == "TraSach")
            {
                try
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dgvMuonTra.Rows[e.RowIndex];
                    txtMaDocGia.Text = row.Cells[0].Value.ToString();
                    txtMaSach.Text = row.Cells[1].Value.ToString();
                    txtSoLuong.Text = row.Cells[2].Value.ToString();
                    string _ngayTra = row.Cells[5].Value.ToString();
                    txtNamT.Text = _ngayTra[6].ToString() + _ngayTra[7].ToString() + _ngayTra[8].ToString() + _ngayTra[9].ToString();
                    txtThangT.Text = _ngayTra[3].ToString() + _ngayTra[4].ToString();
                    txtNgayT.Text = _ngayTra[0].ToString() + _ngayTra[1].ToString();
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void dgvMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdb == "MuonSach")
            {
                try
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dgvMuonTra.Rows[e.RowIndex];
                    txtMaDocGia.Text = row.Cells[0].Value.ToString();
                    txtMaSach.Text = row.Cells[1].Value.ToString();
                    txtSoLuong.Text = row.Cells[2].Value.ToString();

                    string _ngayMuon = row.Cells[3].Value.ToString();
                    txtNamM.Text = _ngayMuon[6].ToString() + _ngayMuon[7].ToString() + _ngayMuon[8].ToString() + _ngayMuon[9].ToString();
                    txtThangM.Text = _ngayMuon[3].ToString() + _ngayMuon[4].ToString();
                    txtNgayM.Text = _ngayMuon[0].ToString() + _ngayMuon[1].ToString();
                    string _ngayHen = row.Cells[4].Value.ToString();
                    txtNamH.Text = _ngayHen[6].ToString() + _ngayHen[7].ToString() + _ngayHen[8].ToString() + _ngayHen[9].ToString();
                    txtThangH.Text = _ngayHen[3].ToString() + _ngayHen[4].ToString();
                    txtNgayH.Text = _ngayHen[0].ToString() + _ngayHen[1].ToString();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message.ToString());
                }
            }
            else if (rdb == "TraSach")
            {
                try
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dgvMuonTra.Rows[e.RowIndex];
                    txtMaDocGia.Text = row.Cells[0].Value.ToString();
                    txtMaSach.Text = row.Cells[1].Value.ToString();
                    txtSoLuong.Text = row.Cells[2].Value.ToString();
                    string _ngayTra = row.Cells[5].Value.ToString();
                    txtNamT.Text = _ngayTra[6].ToString() + _ngayTra[7].ToString() + _ngayTra[8].ToString() + _ngayTra[9].ToString();
                    txtThangT.Text = _ngayTra[3].ToString() + _ngayTra[4].ToString();
                    txtNgayT.Text = _ngayTra[0].ToString() + _ngayTra[1].ToString();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text == "") errorProvider1.SetError(txtMaDocGia, "Bạn chưa nhập mã độc giả"); // bat loi khi chua nhap ma docgia
            if (txtMaSach.Text == "") errorProvider1.SetError(txtMaSach, "Bạn chưa nhập mã sách");
            if (txtSoLuong.Text == "") errorProvider1.SetError(txtSoLuong, "Bạn chưa nhập số lượng");

            KetNoi kn = new KetNoi();   // ket noi lai
            int kq = kn.xulydulieu("update MuonTra set NgayTra='" + txtNamT.Text + "-" + txtThangT.Text + "-" + txtNgayT.Text + "' where (MaDG='" + txtMaDocGia.Text +"' AND MaSach='"+txtMaSach.Text+"')"); // thuc thi lenh insert trong sql
            if (kq > 0) MessageBox.Show("Trả thành công", "Thông báo", MessageBoxButtons.OK);    // thong bao insert thanh cong
            else MessageBox.Show("Trả thất bại, hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK);

            this.laybangmuontra();
        }
    }
}
