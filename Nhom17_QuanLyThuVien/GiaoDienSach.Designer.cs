namespace Nhom17_QuanLyThuVien
{
    partial class GiaoDienSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaSach = new System.Windows.Forms.TextBox();
            this.NhaXB = new System.Windows.Forms.TextBox();
            this.TacGia = new System.Windows.Forms.TextBox();
            this.TenSach = new System.Windows.Forms.TextBox();
            this.NgaySX = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Thoat = new System.Windows.Forms.Button();
            this.DaTaSach = new System.Windows.Forms.DataGridView();
            this.ms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DaTaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(640, 90);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(184, 44);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(640, 166);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(184, 44);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(640, 241);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(184, 44);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntim.Location = new System.Drawing.Point(640, 316);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(184, 44);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tác Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Năm Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhà Xuất Bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thể Loại";
            // 
            // MaSach
            // 
            this.MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSach.Location = new System.Drawing.Point(160, 90);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(422, 22);
            this.MaSach.TabIndex = 10;
            // 
            // NhaXB
            // 
            this.NhaXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaXB.Location = new System.Drawing.Point(160, 291);
            this.NhaXB.Name = "NhaXB";
            this.NhaXB.Size = new System.Drawing.Size(422, 22);
            this.NhaXB.TabIndex = 12;
            // 
            // TacGia
            // 
            this.TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacGia.Location = new System.Drawing.Point(160, 187);
            this.TacGia.Name = "TacGia";
            this.TacGia.Size = new System.Drawing.Size(422, 22);
            this.TacGia.TabIndex = 14;
            // 
            // TenSach
            // 
            this.TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSach.Location = new System.Drawing.Point(160, 136);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(422, 22);
            this.TenSach.TabIndex = 15;
            // 
            // NgaySX
            // 
            this.NgaySX.CustomFormat = "dd/MM/yyyy";
            this.NgaySX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySX.Location = new System.Drawing.Point(160, 241);
            this.NgaySX.Name = "NgaySX";
            this.NgaySX.Size = new System.Drawing.Size(422, 22);
            this.NgaySX.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(227, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yêu Cầu Về Sách";
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat.Location = new System.Drawing.Point(641, 387);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(184, 44);
            this.Thoat.TabIndex = 18;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // DaTaSach
            // 
            this.DaTaSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DaTaSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DaTaSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DaTaSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaTaSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ms,
            this.ts,
            this.tg,
            this.nsx,
            this.nxb,
            this.tl,
            this.Sl});
            this.DaTaSach.Location = new System.Drawing.Point(3, 454);
            this.DaTaSach.Name = "DaTaSach";
            this.DaTaSach.RowHeadersWidth = 51;
            this.DaTaSach.RowTemplate.Height = 24;
            this.DaTaSach.Size = new System.Drawing.Size(861, 238);
            this.DaTaSach.TabIndex = 19;
            this.DaTaSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaTaSach_CellClick);
            // 
            // ms
            // 
            this.ms.DataPropertyName = "MaSach";
            this.ms.HeaderText = "Mã Sách";
            this.ms.MinimumWidth = 8;
            this.ms.Name = "ms";
            this.ms.Width = 89;
            // 
            // ts
            // 
            this.ts.DataPropertyName = "TenSach";
            this.ts.HeaderText = "Tên Sách";
            this.ts.MinimumWidth = 8;
            this.ts.Name = "ts";
            this.ts.Width = 94;
            // 
            // tg
            // 
            this.tg.DataPropertyName = "TacGia";
            this.tg.HeaderText = "Tác Giả";
            this.tg.MinimumWidth = 8;
            this.tg.Name = "tg";
            this.tg.Width = 84;
            // 
            // nsx
            // 
            this.nsx.DataPropertyName = "NamXuatBan";
            this.nsx.HeaderText = "Năm Xuất Bản";
            this.nsx.MinimumWidth = 8;
            this.nsx.Name = "nsx";
            this.nsx.Width = 121;
            // 
            // nxb
            // 
            this.nxb.DataPropertyName = "NhaXuatBan";
            this.nxb.HeaderText = "Nhà Xuất Bản";
            this.nxb.MinimumWidth = 8;
            this.nxb.Name = "nxb";
            this.nxb.Width = 117;
            // 
            // tl
            // 
            this.tl.DataPropertyName = "TheLoai";
            this.tl.HeaderText = "Thể Loại";
            this.tl.MinimumWidth = 8;
            this.tl.Name = "tl";
            this.tl.Width = 89;
            // 
            // Sl
            // 
            this.Sl.DataPropertyName = "SoLuong";
            this.Sl.HeaderText = "Số Lượng";
            this.Sl.MinimumWidth = 8;
            this.Sl.Name = "Sl";
            this.Sl.Width = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số Lượng ";
            // 
            // SoLuong
            // 
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.Location = new System.Drawing.Point(160, 387);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(422, 22);
            this.SoLuong.TabIndex = 13;
            this.SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoLuong_KeyPress);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.ql;
            this.btnquaylai.Location = new System.Drawing.Point(19, 21);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(45, 27);
            this.btnquaylai.TabIndex = 20;
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(163, 343);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(419, 24);
            this.cbbTheLoai.TabIndex = 21;
            // 
            // GiaoDienSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(929, 721);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.DaTaSach);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NgaySX);
            this.Controls.Add(this.TenSach);
            this.Controls.Add(this.TacGia);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.NhaXB);
            this.Controls.Add(this.MaSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GiaoDienSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện  Sách ";
            this.Load += new System.EventHandler(this.GiaoDienSach_Load);
            this.Shown += new System.EventHandler(this.GiaoDienSach_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DaTaSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaSach;
        private System.Windows.Forms.TextBox NhaXB;
        private System.Windows.Forms.TextBox TacGia;
        private System.Windows.Forms.TextBox TenSach;
        private System.Windows.Forms.DateTimePicker NgaySX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView DaTaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ts;
        private System.Windows.Forms.DataGridViewTextBoxColumn tg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.ComboBox cbbTheLoai;
    }
}