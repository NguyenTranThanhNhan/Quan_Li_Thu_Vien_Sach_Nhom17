namespace Nhom17_QuanLyThuVien
{
    partial class GiaoDienQLThanhVien
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
            this.Tim = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.TenTV = new System.Windows.Forms.TextBox();
            this.SDTTV = new System.Windows.Forms.TextBox();
            this.CanYeuCau = new System.Windows.Forms.TextBox();
            this.MaTV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nam = new System.Windows.Forms.RadioButton();
            this.Nu = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.NgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.Thoat = new System.Windows.Forms.Button();
            this.DaTaThanhVien = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.mtv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DaTaThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // Tim
            // 
            this.Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tim.Location = new System.Drawing.Point(842, 340);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(184, 44);
            this.Tim.TabIndex = 7;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sua.Location = new System.Drawing.Point(842, 268);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(184, 44);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Xoa.Location = new System.Drawing.Point(842, 193);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(184, 44);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Them.Location = new System.Drawing.Point(842, 126);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(184, 44);
            this.Them.TabIndex = 4;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(351, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yêu Cầu Thành Viên";
            // 
            // NgaySinh
            // 
            this.NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinh.Location = new System.Drawing.Point(264, 333);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(420, 25);
            this.NgaySinh.TabIndex = 28;
            // 
            // TenTV
            // 
            this.TenTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTV.Location = new System.Drawing.Point(264, 183);
            this.TenTV.Name = "TenTV";
            this.TenTV.Size = new System.Drawing.Size(420, 25);
            this.TenTV.TabIndex = 27;
            // 
            // SDTTV
            // 
            this.SDTTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTTV.Location = new System.Drawing.Point(264, 234);
            this.SDTTV.Name = "SDTTV";
            this.SDTTV.Size = new System.Drawing.Size(420, 25);
            this.SDTTV.TabIndex = 26;
            this.SDTTV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SDTTV_KeyPress);
            // 
            // CanYeuCau
            // 
            this.CanYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanYeuCau.Location = new System.Drawing.Point(264, 424);
            this.CanYeuCau.Name = "CanYeuCau";
            this.CanYeuCau.Size = new System.Drawing.Size(420, 25);
            this.CanYeuCau.TabIndex = 25;
            // 
            // MaTV
            // 
            this.MaTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTV.Location = new System.Drawing.Point(264, 129);
            this.MaTV.Name = "MaTV";
            this.MaTV.Size = new System.Drawing.Size(420, 25);
            this.MaTV.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày Tháng Năm Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày Đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(72, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Thành Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã Thành Viên";
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nam.Location = new System.Drawing.Point(735, 176);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(84, 30);
            this.Nam.TabIndex = 29;
            this.Nam.TabStop = true;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = true;
            // 
            // Nu
            // 
            this.Nu.AutoSize = true;
            this.Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nu.Location = new System.Drawing.Point(735, 227);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(65, 30);
            this.Nu.TabIndex = 30;
            this.Nu.TabStop = true;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(731, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 26);
            this.label8.TabIndex = 31;
            this.label8.Text = "Phái";
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.CustomFormat = "dd/MM/yyyy";
            this.NgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayDangKy.Location = new System.Drawing.Point(264, 380);
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.Size = new System.Drawing.Size(420, 25);
            this.NgayDangKy.TabIndex = 32;
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat.Location = new System.Drawing.Point(842, 417);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(184, 44);
            this.Thoat.TabIndex = 33;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // DaTaThanhVien
            // 
            this.DaTaThanhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DaTaThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaTaThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mtv,
            this.ttv,
            this.sdt,
            this.mail,
            this.ns,
            this.ndk,
            this.Gc,
            this.phai});
            this.DaTaThanhVien.Location = new System.Drawing.Point(12, 483);
            this.DaTaThanhVien.Name = "DaTaThanhVien";
            this.DaTaThanhVien.RowHeadersWidth = 51;
            this.DaTaThanhVien.RowTemplate.Height = 24;
            this.DaTaThanhVien.Size = new System.Drawing.Size(1209, 225);
            this.DaTaThanhVien.TabIndex = 34;
            this.DaTaThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaTaThanhVien_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(70, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Số Điện Thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(264, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(420, 25);
            this.txtEmail.TabIndex = 35;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.ql;
            this.btnquaylai.Location = new System.Drawing.Point(47, 23);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(45, 27);
            this.btnquaylai.TabIndex = 36;
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // mtv
            // 
            this.mtv.DataPropertyName = "MaThanhVien";
            this.mtv.HeaderText = "Mã TV";
            this.mtv.MinimumWidth = 8;
            this.mtv.Name = "mtv";
            this.mtv.Width = 150;
            // 
            // ttv
            // 
            this.ttv.DataPropertyName = "TenThanhVien";
            this.ttv.HeaderText = "Tên TV";
            this.ttv.MinimumWidth = 8;
            this.ttv.Name = "ttv";
            this.ttv.Width = 150;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            this.sdt.Width = 150;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "Email";
            this.mail.HeaderText = "email";
            this.mail.MinimumWidth = 8;
            this.mail.Name = "mail";
            this.mail.Width = 150;
            // 
            // ns
            // 
            this.ns.DataPropertyName = "NgayThangNamSinh";
            this.ns.HeaderText = "Ngày Sinh";
            this.ns.MinimumWidth = 8;
            this.ns.Name = "ns";
            this.ns.Width = 150;
            // 
            // ndk
            // 
            this.ndk.DataPropertyName = "NgayDangKy";
            this.ndk.HeaderText = "Ngày Đăng Ký";
            this.ndk.MinimumWidth = 8;
            this.ndk.Name = "ndk";
            this.ndk.Width = 150;
            // 
            // Gc
            // 
            this.Gc.DataPropertyName = "YeuCau";
            this.Gc.HeaderText = "Ghi chú";
            this.Gc.MinimumWidth = 8;
            this.Gc.Name = "Gc";
            this.Gc.Width = 150;
            // 
            // phai
            // 
            this.phai.DataPropertyName = "Phai";
            this.phai.HeaderText = "Giới tính";
            this.phai.MinimumWidth = 8;
            this.phai.Name = "phai";
            this.phai.Width = 150;
            // 
            // GiaoDienQLThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1177, 793);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.DaTaThanhVien);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.NgayDangKy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Nu);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.TenTV);
            this.Controls.Add(this.SDTTV);
            this.Controls.Add(this.CanYeuCau);
            this.Controls.Add(this.MaTV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GiaoDienQLThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Quản Lý Thành Viên";
            this.Load += new System.EventHandler(this.GiaoDienQLThanhVien_Load);
            this.Shown += new System.EventHandler(this.GiaoDienQLThanhVien_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DaTaThanhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.TextBox TenTV;
        private System.Windows.Forms.TextBox SDTTV;
        private System.Windows.Forms.TextBox CanYeuCau;
        private System.Windows.Forms.TextBox MaTV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Nam;
        private System.Windows.Forms.RadioButton Nu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker NgayDangKy;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView DaTaThanhVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gc;
        private System.Windows.Forms.DataGridViewTextBoxColumn phai;
    }
}