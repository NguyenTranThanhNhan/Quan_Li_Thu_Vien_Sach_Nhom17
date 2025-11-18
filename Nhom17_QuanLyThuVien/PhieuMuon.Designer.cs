namespace Nhom17_QuanLyThuVien
{
    partial class PhieuMuon
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
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpkNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dpkNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DaTaMuonTra = new System.Windows.Forms.DataGridView();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtnMuon = new System.Windows.Forms.RadioButton();
            this.rbtnTra = new System.Windows.Forms.RadioButton();
            this.Thoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tim = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.mmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DaTaMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(294, 122);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(383, 26);
            this.txtMaPT.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Mã Phiếu Mượn";
            // 
            // dpkNgayMuon
            // 
            this.dpkNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dpkNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgayMuon.Location = new System.Drawing.Point(294, 395);
            this.dpkNgayMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkNgayMuon.Name = "dpkNgayMuon";
            this.dpkNgayMuon.Size = new System.Drawing.Size(383, 26);
            this.dpkNgayMuon.TabIndex = 70;
            // 
            // dpkNgayTra
            // 
            this.dpkNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dpkNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgayTra.Location = new System.Drawing.Point(294, 446);
            this.dpkNgayTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpkNgayTra.Name = "dpkNgayTra";
            this.dpkNgayTra.Size = new System.Drawing.Size(383, 26);
            this.dpkNgayTra.TabIndex = 69;
            this.dpkNgayTra.ValueChanged += new System.EventHandler(this.dpkNgayTra_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ngày Phải Trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ngày Mượn";
            // 
            // DaTaMuonTra
            // 
            this.DaTaMuonTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DaTaMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaTaMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mmt,
            this.Ms,
            this.mtv,
            this.sdt,
            this.sl,
            this.nm,
            this.nt});
            this.DaTaMuonTra.Location = new System.Drawing.Point(12, 566);
            this.DaTaMuonTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DaTaMuonTra.Name = "DaTaMuonTra";
            this.DaTaMuonTra.RowHeadersWidth = 51;
            this.DaTaMuonTra.RowTemplate.Height = 24;
            this.DaTaMuonTra.Size = new System.Drawing.Size(1099, 328);
            this.DaTaMuonTra.TabIndex = 66;
            this.DaTaMuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaTaMuonTra_CellClick);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(294, 341);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(383, 26);
            this.txtSoLuong.TabIndex = 65;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(294, 290);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(383, 26);
            this.txtSDT.TabIndex = 64;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(93, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Số Điện Thoại";
            // 
            // rbtnMuon
            // 
            this.rbtnMuon.AutoSize = true;
            this.rbtnMuon.Enabled = false;
            this.rbtnMuon.Location = new System.Drawing.Point(294, 500);
            this.rbtnMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMuon.Name = "rbtnMuon";
            this.rbtnMuon.Size = new System.Drawing.Size(115, 24);
            this.rbtnMuon.TabIndex = 62;
            this.rbtnMuon.TabStop = true;
            this.rbtnMuon.Text = "Mượn Sách";
            this.rbtnMuon.UseVisualStyleBackColor = true;
            // 
            // rbtnTra
            // 
            this.rbtnTra.AutoSize = true;
            this.rbtnTra.Enabled = false;
            this.rbtnTra.Location = new System.Drawing.Point(504, 500);
            this.rbtnTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnTra.Name = "rbtnTra";
            this.rbtnTra.Size = new System.Drawing.Size(98, 24);
            this.rbtnTra.TabIndex = 61;
            this.rbtnTra.TabStop = true;
            this.rbtnTra.Text = "Trả Sách";
            this.rbtnTra.UseVisualStyleBackColor = true;
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat.Location = new System.Drawing.Point(726, 478);
            this.Thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(184, 55);
            this.Thoat.TabIndex = 60;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(287, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(406, 40);
            this.label7.TabIndex = 59;
            this.label7.Text = "Phiếu Mượn / Trả Sách";
            // 
            // txtTV
            // 
            this.txtTV.Location = new System.Drawing.Point(294, 235);
            this.txtTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTV.Name = "txtTV";
            this.txtTV.Size = new System.Drawing.Size(383, 26);
            this.txtTV.TabIndex = 58;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(294, 176);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(383, 26);
            this.txtMaSach.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Số Lượng ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Trạng Thái ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã Thành Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã Sách";
            // 
            // Tim
            // 
            this.Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tim.Location = new System.Drawing.Point(726, 399);
            this.Tim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(184, 55);
            this.Tim.TabIndex = 52;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sua.Location = new System.Drawing.Point(726, 321);
            this.Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(184, 55);
            this.Sua.TabIndex = 51;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // btnTra
            // 
            this.btnTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTra.Location = new System.Drawing.Point(726, 169);
            this.btnTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(184, 55);
            this.btnTra.TabIndex = 50;
            this.btnTra.Text = "Trả Sách ";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMuon.Location = new System.Drawing.Point(726, 95);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(184, 55);
            this.btnMuon.TabIndex = 49;
            this.btnMuon.Text = "Mượn Sách";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(726, 242);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(184, 55);
            this.btnXoa.TabIndex = 73;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.ql;
            this.btnquaylai.Location = new System.Drawing.Point(32, 31);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(45, 27);
            this.btnquaylai.TabIndex = 74;
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // mmt
            // 
            this.mmt.DataPropertyName = "MaMuonTra";
            this.mmt.HeaderText = "Mã Mượn Trả";
            this.mmt.MinimumWidth = 8;
            this.mmt.Name = "mmt";
            this.mmt.Width = 150;
            // 
            // Ms
            // 
            this.Ms.DataPropertyName = "MaSach";
            this.Ms.HeaderText = "Mã Sách";
            this.Ms.MinimumWidth = 8;
            this.Ms.Name = "Ms";
            this.Ms.Width = 150;
            // 
            // mtv
            // 
            this.mtv.DataPropertyName = "MaThanhVien";
            this.mtv.HeaderText = "Mã TV";
            this.mtv.MinimumWidth = 8;
            this.mtv.Name = "mtv";
            this.mtv.Width = 150;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            this.sdt.Width = 150;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "Soluong";
            this.sl.HeaderText = "Số Lượng";
            this.sl.MinimumWidth = 8;
            this.sl.Name = "sl";
            this.sl.Width = 150;
            // 
            // nm
            // 
            this.nm.DataPropertyName = "NgayMuon";
            this.nm.HeaderText = "Ngày Mượn";
            this.nm.MinimumWidth = 8;
            this.nm.Name = "nm";
            this.nm.Width = 150;
            // 
            // nt
            // 
            this.nt.DataPropertyName = "NgayTra";
            this.nt.HeaderText = "Ngày Trả";
            this.nt.MinimumWidth = 8;
            this.nt.Name = "nt";
            this.nt.Width = 150;
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 907);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dpkNgayMuon);
            this.Controls.Add(this.dpkNgayTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DaTaMuonTra);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbtnMuon);
            this.Controls.Add(this.rbtnTra);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTV);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnMuon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhieuMuon";
            this.Text = "PhieuMuon";
            this.Load += new System.EventHandler(this.PhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaTaMuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpkNgayMuon;
        private System.Windows.Forms.DateTimePicker dpkNgayTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DaTaMuonTra;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtnMuon;
        private System.Windows.Forms.RadioButton rbtnTra;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTV;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ms;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nt;
    }
}