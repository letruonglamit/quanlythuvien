namespace QuanLiThuVien
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMuon = new System.Windows.Forms.Button();
            this.rdbTimTenDocGia = new System.Windows.Forms.RadioButton();
            this.rdbTimSach = new System.Windows.Forms.RadioButton();
            this.cbbTimSach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(213, 140);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(282, 27);
            this.txtTimKiem.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tìm kiếm :";
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Location = new System.Drawing.Point(12, 190);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.Size = new System.Drawing.Size(626, 150);
            this.dgvTimKiem.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(265, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 37);
            this.label7.TabIndex = 44;
            this.label7.Text = "Tìm kiếm";
            // 
            // btnMuon
            // 
            this.btnMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuon.ForeColor = System.Drawing.Color.Transparent;
            this.btnMuon.Image = ((System.Drawing.Image)(resources.GetObject("btnMuon.Image")));
            this.btnMuon.Location = new System.Drawing.Point(512, 140);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(60, 29);
            this.btnMuon.TabIndex = 45;
            this.btnMuon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // rdbTimTenDocGia
            // 
            this.rdbTimTenDocGia.AutoSize = true;
            this.rdbTimTenDocGia.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbTimTenDocGia.Location = new System.Drawing.Point(144, 95);
            this.rdbTimTenDocGia.Name = "rdbTimTenDocGia";
            this.rdbTimTenDocGia.Size = new System.Drawing.Size(141, 23);
            this.rdbTimTenDocGia.TabIndex = 46;
            this.rdbTimTenDocGia.TabStop = true;
            this.rdbTimTenDocGia.Text = "Tìm tên độc giả";
            this.rdbTimTenDocGia.UseVisualStyleBackColor = true;
            this.rdbTimTenDocGia.CheckedChanged += new System.EventHandler(this.rdbTimKiem_CheckedChanged);
            // 
            // rdbTimSach
            // 
            this.rdbTimSach.AutoSize = true;
            this.rdbTimSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbTimSach.Location = new System.Drawing.Point(329, 95);
            this.rdbTimSach.Name = "rdbTimSach";
            this.rdbTimSach.Size = new System.Drawing.Size(103, 23);
            this.rdbTimSach.TabIndex = 46;
            this.rdbTimSach.TabStop = true;
            this.rdbTimSach.Text = "Tìm sách :";
            this.rdbTimSach.UseVisualStyleBackColor = true;
            // 
            // cbbTimSach
            // 
            this.cbbTimSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTimSach.FormattingEnabled = true;
            this.cbbTimSach.Items.AddRange(new object[] {
            "Tên sách",
            "Thể loại",
            "Tác giả"});
            this.cbbTimSach.Location = new System.Drawing.Point(438, 94);
            this.cbbTimSach.Name = "cbbTimSach";
            this.cbbTimSach.Size = new System.Drawing.Size(121, 27);
            this.cbbTimSach.TabIndex = 47;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 352);
            this.Controls.Add(this.cbbTimSach);
            this.Controls.Add(this.rdbTimSach);
            this.Controls.Add(this.rdbTimTenDocGia);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.RadioButton rdbTimTenDocGia;
        private System.Windows.Forms.RadioButton rdbTimSach;
        private System.Windows.Forms.ComboBox cbbTimSach;
    }
}