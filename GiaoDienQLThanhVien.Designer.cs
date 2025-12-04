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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tim = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
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
            this.NgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.Thoat = new System.Windows.Forms.Button();
            this.DaTaThanhVien = new System.Windows.Forms.DataGridView();
            this.mtv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttvtim = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DaTaThanhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tim
            // 
            this.Tim.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tim.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.pngtree_vector_search_icon_png_image_320926;
            this.Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tim.Location = new System.Drawing.Point(299, 17);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(63, 42);
            this.Tim.TabIndex = 7;
            this.Tim.Text = "Tìm";
            this.Tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sua.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.tải_xuống__1_;
            this.Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sua.Location = new System.Drawing.Point(462, 235);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(73, 41);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Xoa.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.images1;
            this.Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xoa.Location = new System.Drawing.Point(311, 235);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(73, 41);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "Xóa";
            this.Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // NgaySinh
            // 
            this.NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinh.Location = new System.Drawing.Point(414, 22);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(187, 22);
            this.NgaySinh.TabIndex = 28;
            // 
            // TenTV
            // 
            this.TenTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTV.Location = new System.Drawing.Point(106, 55);
            this.TenTV.Name = "TenTV";
            this.TenTV.Size = new System.Drawing.Size(187, 22);
            this.TenTV.TabIndex = 27;
            // 
            // SDTTV
            // 
            this.SDTTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTTV.Location = new System.Drawing.Point(106, 86);
            this.SDTTV.MaxLength = 10;
            this.SDTTV.Name = "SDTTV";
            this.SDTTV.Size = new System.Drawing.Size(187, 22);
            this.SDTTV.TabIndex = 26;
            this.SDTTV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SDTTV_KeyPress);
            // 
            // CanYeuCau
            // 
            this.CanYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanYeuCau.Location = new System.Drawing.Point(414, 86);
            this.CanYeuCau.Name = "CanYeuCau";
            this.CanYeuCau.Size = new System.Drawing.Size(187, 22);
            this.CanYeuCau.TabIndex = 25;
            // 
            // MaTV
            // 
            this.MaTV.BackColor = System.Drawing.SystemColors.Window;
            this.MaTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTV.Location = new System.Drawing.Point(106, 24);
            this.MaTV.Name = "MaTV";
            this.MaTV.ReadOnly = true;
            this.MaTV.Size = new System.Drawing.Size(187, 22);
            this.MaTV.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày đăng ký:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên TV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã TV:";
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nam.Location = new System.Drawing.Point(414, 119);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(55, 20);
            this.Nam.TabIndex = 29;
            this.Nam.TabStop = true;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = true;
            // 
            // Nu
            // 
            this.Nu.AutoSize = true;
            this.Nu.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Nu.Location = new System.Drawing.Point(484, 119);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(46, 20);
            this.Nu.TabIndex = 30;
            this.Nu.TabStop = true;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = true;
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.CustomFormat = "dd/MM/yyyy";
            this.NgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayDangKy.Location = new System.Drawing.Point(414, 55);
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.Size = new System.Drawing.Size(187, 22);
            this.NgayDangKy.TabIndex = 32;
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.pngtree_exit_icon_vectors_png_image_1737870;
            this.Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Thoat.Location = new System.Drawing.Point(471, 17);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(77, 42);
            this.Thoat.TabIndex = 33;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // DaTaThanhVien
            // 
            this.DaTaThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.DaTaThanhVien.Location = new System.Drawing.Point(14, 20);
            this.DaTaThanhVien.Name = "DaTaThanhVien";
            this.DaTaThanhVien.RowHeadersWidth = 51;
            this.DaTaThanhVien.RowTemplate.Height = 24;
            this.DaTaThanhVien.Size = new System.Drawing.Size(587, 122);
            this.DaTaThanhVien.TabIndex = 34;
            this.DaTaThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaTaThanhVien_CellClick);
          
            // 
            // mtv
            // 
            this.mtv.DataPropertyName = "MaThanhVien";
            this.mtv.HeaderText = "Mã TV";
            this.mtv.MinimumWidth = 8;
            this.mtv.Name = "mtv";
            this.mtv.Width = 81;
            // 
            // ttv
            // 
            this.ttv.DataPropertyName = "TenThanhVien";
            this.ttv.HeaderText = "Tên TV";
            this.ttv.MinimumWidth = 8;
            this.ttv.Name = "ttv";
            this.ttv.Width = 84;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            this.sdt.Width = 113;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "Email";
            this.mail.HeaderText = "Email";
            this.mail.MinimumWidth = 8;
            this.mail.Name = "mail";
            this.mail.Width = 70;
            // 
            // ns
            // 
            this.ns.DataPropertyName = "NgayThangNamSinh";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.ns.DefaultCellStyle = dataGridViewCellStyle5;
            this.ns.HeaderText = "Ngày Sinh";
            this.ns.MinimumWidth = 8;
            this.ns.Name = "ns";
            this.ns.Width = 98;
            // 
            // ndk
            // 
            this.ndk.DataPropertyName = "NgayDangKy";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.ndk.DefaultCellStyle = dataGridViewCellStyle6;
            this.ndk.HeaderText = "Ngày Đăng Ký";
            this.ndk.MinimumWidth = 8;
            this.ndk.Name = "ndk";
            this.ndk.Width = 127;
            // 
            // Gc
            // 
            this.Gc.DataPropertyName = "YeuCau";
            this.Gc.HeaderText = "Ghi chú";
            this.Gc.MinimumWidth = 8;
            this.Gc.Name = "Gc";
            this.Gc.Width = 82;
            // 
            // phai
            // 
            this.phai.DataPropertyName = "Phai";
            this.phai.HeaderText = "Giới tính";
            this.phai.MinimumWidth = 8;
            this.phai.Name = "phai";
            this.phai.Width = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(27, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "SĐT:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(106, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 22);
            this.txtEmail.TabIndex = 35;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.ql;
            this.btnquaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquaylai.Location = new System.Drawing.Point(378, 17);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(73, 42);
            this.btnquaylai.TabIndex = 36;
            this.btnquaylai.Text = "Back";
            this.btnquaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttvtim);
            this.groupBox1.Controls.Add(this.Tim);
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.Thoat);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 66);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thành viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nhập Mã TV cần tìm:";
            // 
            // txttvtim
            // 
            this.txttvtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttvtim.Location = new System.Drawing.Point(141, 26);
            this.txttvtim.Name = "txttvtim";
            this.txttvtim.Size = new System.Drawing.Size(133, 22);
            this.txttvtim.TabIndex = 39;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Nam);
            this.groupBox3.Controls.Add(this.Nu);
            this.groupBox3.Controls.Add(this.CanYeuCau);
            this.groupBox3.Controls.Add(this.NgayDangKy);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.MaTV);
            this.groupBox3.Controls.Add(this.TenTV);
            this.groupBox3.Controls.Add(this.SDTTV);
            this.groupBox3.Controls.Add(this.NgaySinh);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 142);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thành viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Giới tính:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.DaTaThanhVien);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 282);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(609, 148);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách thành viên";
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Them.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.tải_xuống;
            this.Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Them.Location = new System.Drawing.Point(153, 235);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(74, 41);
            this.Them.TabIndex = 4;
            this.Them.Text = "Thêm";
            this.Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // GiaoDienQLThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(637, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GiaoDienQLThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Quản Lý Thành Viên";
            this.Load += new System.EventHandler(this.GiaoDienQLThanhVien_Load);
            this.Shown += new System.EventHandler(this.GiaoDienQLThanhVien_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DaTaThanhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
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
        private System.Windows.Forms.DateTimePicker NgayDangKy;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView DaTaThanhVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttvtim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ns;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gc;
        private System.Windows.Forms.DataGridViewTextBoxColumn phai;
        private System.Windows.Forms.Button Them;
    }
}