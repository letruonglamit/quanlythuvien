namespace QuanLiThuVien
{
    partial class frmMuonTra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTra));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNamM = new System.Windows.Forms.TextBox();
            this.txtNamT = new System.Windows.Forms.TextBox();
            this.txtThangM = new System.Windows.Forms.TextBox();
            this.txtThangT = new System.Windows.Forms.TextBox();
            this.txtNgayM = new System.Windows.Forms.TextBox();
            this.txtNgayT = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblM4 = new System.Windows.Forms.Label();
            this.lblT4 = new System.Windows.Forms.Label();
            this.lblM3 = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblM1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblH2 = new System.Windows.Forms.Label();
            this.lblH3 = new System.Windows.Forms.Label();
            this.lblH4 = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.txtNgayH = new System.Windows.Forms.TextBox();
            this.txtThangH = new System.Windows.Forms.TextBox();
            this.txtNamH = new System.Windows.Forms.TextBox();
            this.rdbMuonSAch = new System.Windows.Forms.RadioButton();
            this.rdbTraSach = new System.Windows.Forms.RadioButton();
            this.dgvMuonTra = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTra = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTra);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnMuon);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(482, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 173);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(35, 129);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 36);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuon.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnMuon.Image = ((System.Drawing.Image)(resources.GetObject("btnMuon.Image")));
            this.btnMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuon.Location = new System.Drawing.Point(35, 32);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(90, 36);
            this.btnMuon.TabIndex = 0;
            this.btnMuon.Text = "Mượn";
            this.btnMuon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(159, 180);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(281, 27);
            this.txtSoLuong.TabIndex = 31;
            // 
            // txtNamM
            // 
            this.txtNamM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNamM.Location = new System.Drawing.Point(384, 216);
            this.txtNamM.Name = "txtNamM";
            this.txtNamM.Size = new System.Drawing.Size(57, 27);
            this.txtNamM.TabIndex = 32;
            // 
            // txtNamT
            // 
            this.txtNamT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNamT.Location = new System.Drawing.Point(383, 217);
            this.txtNamT.Name = "txtNamT";
            this.txtNamT.Size = new System.Drawing.Size(57, 27);
            this.txtNamT.TabIndex = 38;
            // 
            // txtThangM
            // 
            this.txtThangM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThangM.Location = new System.Drawing.Point(302, 217);
            this.txtThangM.Name = "txtThangM";
            this.txtThangM.Size = new System.Drawing.Size(28, 27);
            this.txtThangM.TabIndex = 33;
            // 
            // txtThangT
            // 
            this.txtThangT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThangT.Location = new System.Drawing.Point(302, 217);
            this.txtThangT.Name = "txtThangT";
            this.txtThangT.Size = new System.Drawing.Size(28, 27);
            this.txtThangT.TabIndex = 37;
            // 
            // txtNgayM
            // 
            this.txtNgayM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayM.Location = new System.Drawing.Point(201, 217);
            this.txtNgayM.Name = "txtNgayM";
            this.txtNgayM.Size = new System.Drawing.Size(30, 27);
            this.txtNgayM.TabIndex = 36;
            // 
            // txtNgayT
            // 
            this.txtNgayT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayT.Location = new System.Drawing.Point(201, 217);
            this.txtNgayT.Name = "txtNgayT";
            this.txtNgayT.Size = new System.Drawing.Size(30, 27);
            this.txtNgayT.TabIndex = 35;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSach.Location = new System.Drawing.Point(158, 142);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(282, 27);
            this.txtMaSach.TabIndex = 39;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDocGia.Location = new System.Drawing.Point(158, 107);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(282, 27);
            this.txtMaDocGia.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số lượng:";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.BackColor = System.Drawing.Color.Transparent;
            this.lblT1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblT1.ForeColor = System.Drawing.Color.Black;
            this.lblT1.Location = new System.Drawing.Point(40, 220);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(82, 19);
            this.lblT1.TabIndex = 28;
            this.lblT1.Text = "Ngày trả :";
            // 
            // lblM4
            // 
            this.lblM4.AutoSize = true;
            this.lblM4.BackColor = System.Drawing.Color.Transparent;
            this.lblM4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblM4.ForeColor = System.Drawing.Color.Black;
            this.lblM4.Location = new System.Drawing.Point(329, 220);
            this.lblM4.Name = "lblM4";
            this.lblM4.Size = new System.Drawing.Size(59, 19);
            this.lblM4.TabIndex = 23;
            this.lblM4.Text = "- Năm:";
            // 
            // lblT4
            // 
            this.lblT4.AutoSize = true;
            this.lblT4.BackColor = System.Drawing.Color.Transparent;
            this.lblT4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblT4.ForeColor = System.Drawing.Color.Black;
            this.lblT4.Location = new System.Drawing.Point(329, 220);
            this.lblT4.Name = "lblT4";
            this.lblT4.Size = new System.Drawing.Size(59, 19);
            this.lblT4.TabIndex = 30;
            this.lblT4.Text = "- Năm:";
            // 
            // lblM3
            // 
            this.lblM3.AutoSize = true;
            this.lblM3.BackColor = System.Drawing.Color.Transparent;
            this.lblM3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblM3.ForeColor = System.Drawing.Color.Black;
            this.lblM3.Location = new System.Drawing.Point(233, 220);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(65, 19);
            this.lblM3.TabIndex = 29;
            this.lblM3.Text = "- Tháng:";
            // 
            // lblM2
            // 
            this.lblM2.AutoSize = true;
            this.lblM2.BackColor = System.Drawing.Color.Transparent;
            this.lblM2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblM2.ForeColor = System.Drawing.Color.Black;
            this.lblM2.Location = new System.Drawing.Point(156, 220);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(50, 19);
            this.lblM2.TabIndex = 27;
            this.lblM2.Text = "Ngày:";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.BackColor = System.Drawing.Color.Transparent;
            this.lblT3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblT3.ForeColor = System.Drawing.Color.Black;
            this.lblT3.Location = new System.Drawing.Point(233, 220);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(65, 19);
            this.lblT3.TabIndex = 26;
            this.lblT3.Text = "- Tháng:";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.BackColor = System.Drawing.Color.Transparent;
            this.lblT2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblT2.ForeColor = System.Drawing.Color.Black;
            this.lblT2.Location = new System.Drawing.Point(156, 220);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(50, 19);
            this.lblT2.TabIndex = 25;
            this.lblT2.Text = "Ngày:";
            // 
            // lblM1
            // 
            this.lblM1.AutoSize = true;
            this.lblM1.BackColor = System.Drawing.Color.Transparent;
            this.lblM1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblM1.ForeColor = System.Drawing.Color.Black;
            this.lblM1.Location = new System.Drawing.Point(41, 219);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(98, 19);
            this.lblM1.TabIndex = 24;
            this.lblM1.Text = "Ngày mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(219, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mượn trả sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã độc giả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã sách:";
            // 
            // lblH2
            // 
            this.lblH2.AutoSize = true;
            this.lblH2.BackColor = System.Drawing.Color.Transparent;
            this.lblH2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblH2.ForeColor = System.Drawing.Color.Black;
            this.lblH2.Location = new System.Drawing.Point(156, 256);
            this.lblH2.Name = "lblH2";
            this.lblH2.Size = new System.Drawing.Size(50, 19);
            this.lblH2.TabIndex = 27;
            this.lblH2.Text = "Ngày:";
            // 
            // lblH3
            // 
            this.lblH3.AutoSize = true;
            this.lblH3.BackColor = System.Drawing.Color.Transparent;
            this.lblH3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblH3.ForeColor = System.Drawing.Color.Black;
            this.lblH3.Location = new System.Drawing.Point(233, 256);
            this.lblH3.Name = "lblH3";
            this.lblH3.Size = new System.Drawing.Size(65, 19);
            this.lblH3.TabIndex = 29;
            this.lblH3.Text = "- Tháng:";
            // 
            // lblH4
            // 
            this.lblH4.AutoSize = true;
            this.lblH4.BackColor = System.Drawing.Color.Transparent;
            this.lblH4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblH4.ForeColor = System.Drawing.Color.Black;
            this.lblH4.Location = new System.Drawing.Point(329, 256);
            this.lblH4.Name = "lblH4";
            this.lblH4.Size = new System.Drawing.Size(59, 19);
            this.lblH4.TabIndex = 23;
            this.lblH4.Text = "- Năm:";
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.BackColor = System.Drawing.Color.Transparent;
            this.lblH1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblH1.ForeColor = System.Drawing.Color.Black;
            this.lblH1.Location = new System.Drawing.Point(40, 256);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(112, 19);
            this.lblH1.TabIndex = 28;
            this.lblH1.Text = "Ngày hẹn trả :";
            // 
            // txtNgayH
            // 
            this.txtNgayH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayH.Location = new System.Drawing.Point(201, 253);
            this.txtNgayH.Name = "txtNgayH";
            this.txtNgayH.Size = new System.Drawing.Size(30, 27);
            this.txtNgayH.TabIndex = 36;
            // 
            // txtThangH
            // 
            this.txtThangH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThangH.Location = new System.Drawing.Point(302, 253);
            this.txtThangH.Name = "txtThangH";
            this.txtThangH.Size = new System.Drawing.Size(28, 27);
            this.txtThangH.TabIndex = 33;
            // 
            // txtNamH
            // 
            this.txtNamH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNamH.Location = new System.Drawing.Point(384, 252);
            this.txtNamH.Name = "txtNamH";
            this.txtNamH.Size = new System.Drawing.Size(57, 27);
            this.txtNamH.TabIndex = 32;
            // 
            // rdbMuonSAch
            // 
            this.rdbMuonSAch.AutoSize = true;
            this.rdbMuonSAch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbMuonSAch.Location = new System.Drawing.Point(148, 77);
            this.rdbMuonSAch.Name = "rdbMuonSAch";
            this.rdbMuonSAch.Size = new System.Drawing.Size(107, 23);
            this.rdbMuonSAch.TabIndex = 42;
            this.rdbMuonSAch.TabStop = true;
            this.rdbMuonSAch.Text = "Mượn sách";
            this.rdbMuonSAch.UseVisualStyleBackColor = true;
            this.rdbMuonSAch.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbTraSach
            // 
            this.rdbTraSach.AutoSize = true;
            this.rdbTraSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbTraSach.Location = new System.Drawing.Point(299, 77);
            this.rdbTraSach.Name = "rdbTraSach";
            this.rdbTraSach.Size = new System.Drawing.Size(88, 23);
            this.rdbTraSach.TabIndex = 42;
            this.rdbTraSach.TabStop = true;
            this.rdbTraSach.Text = "Trả sách";
            this.rdbTraSach.UseVisualStyleBackColor = true;
            this.rdbTraSach.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dgvMuonTra
            // 
            this.dgvMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonTra.Location = new System.Drawing.Point(12, 286);
            this.dgvMuonTra.Name = "dgvMuonTra";
            this.dgvMuonTra.Size = new System.Drawing.Size(654, 179);
            this.dgvMuonTra.TabIndex = 43;
            this.dgvMuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuonTra_CellClick);
            this.dgvMuonTra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuonTra_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTra
            // 
            this.btnTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTra.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnTra.Image = ((System.Drawing.Image)(resources.GetObject("btnTra.Image")));
            this.btnTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTra.Location = new System.Drawing.Point(35, 81);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(90, 36);
            this.btnTra.TabIndex = 0;
            this.btnTra.Text = "Trả";
            this.btnTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // frmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 474);
            this.Controls.Add(this.dgvMuonTra);
            this.Controls.Add(this.rdbTraSach);
            this.Controls.Add(this.rdbMuonSAch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtNamH);
            this.Controls.Add(this.txtNamM);
            this.Controls.Add(this.txtNamT);
            this.Controls.Add(this.txtThangH);
            this.Controls.Add(this.txtThangM);
            this.Controls.Add(this.txtThangT);
            this.Controls.Add(this.txtNgayH);
            this.Controls.Add(this.txtNgayM);
            this.Controls.Add(this.txtNgayT);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblH4);
            this.Controls.Add(this.lblT1);
            this.Controls.Add(this.lblM4);
            this.Controls.Add(this.lblH3);
            this.Controls.Add(this.lblT4);
            this.Controls.Add(this.lblH2);
            this.Controls.Add(this.lblM3);
            this.Controls.Add(this.lblM2);
            this.Controls.Add(this.lblT3);
            this.Controls.Add(this.lblT2);
            this.Controls.Add(this.lblM1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmMuonTra";
            this.Text = "Mượn trả sách";
            this.Load += new System.EventHandler(this.frmMuonTra_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtNamM;
        private System.Windows.Forms.TextBox txtNamT;
        private System.Windows.Forms.TextBox txtThangM;
        private System.Windows.Forms.TextBox txtThangT;
        private System.Windows.Forms.TextBox txtNgayM;
        private System.Windows.Forms.TextBox txtNgayT;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblM4;
        private System.Windows.Forms.Label lblT4;
        private System.Windows.Forms.Label lblM3;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblH2;
        private System.Windows.Forms.Label lblH3;
        private System.Windows.Forms.Label lblH4;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.TextBox txtNgayH;
        private System.Windows.Forms.TextBox txtThangH;
        private System.Windows.Forms.TextBox txtNamH;
        private System.Windows.Forms.RadioButton rdbMuonSAch;
        private System.Windows.Forms.RadioButton rdbTraSach;
        private System.Windows.Forms.DataGridView dgvMuonTra;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnTra;
    }
}