namespace Nhom17_QuanLyThuVien
{
    partial class MainThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainThuVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiNV = new System.Windows.Forms.ToolStripMenuItem();
            this.stmiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripThem = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripXoa = new System.Windows.Forms.ToolStripLabel();
            this.btnSuaaa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripLabel();
            this.btnLuuu = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripLabel();
            this.btnHuyy = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripMuonTra = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTV = new System.Windows.Forms.TextBox();
            this.txtMaTv = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDST = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDST)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmiUser,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // stmiUser
            // 
            this.stmiUser.Name = "stmiUser";
            this.stmiUser.Size = new System.Drawing.Size(162, 26);
            this.stmiUser.Text = "Tài Khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmiNV,
            this.stmiSach});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // stmiNV
            // 
            this.stmiNV.Name = "stmiNV";
            this.stmiNV.Size = new System.Drawing.Size(174, 26);
            this.stmiNV.Text = "Người Dùng";
            this.stmiNV.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // stmiSach
            // 
            this.stmiSach.Name = "stmiSach";
            this.stmiSach.Size = new System.Drawing.Size(174, 26);
            this.stmiSach.Text = "Sách";
            this.stmiSach.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripThem,
            this.btnDelete,
            this.toolStripXoa,
            this.btnSuaaa,
            this.btnSua,
            this.btnLuuu,
            this.btnLuu,
            this.btnHuyy,
            this.btnHuy,
            this.toolStripButton6,
            this.toolStripMuonTra});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(902, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 24);
            this.btnAdd.Text = "Them";
            // 
            // toolStripThem
            // 
            this.toolStripThem.Name = "toolStripThem";
            this.toolStripThem.Size = new System.Drawing.Size(46, 24);
            this.toolStripThem.Text = "Thêm";
            this.toolStripThem.Click += new System.EventHandler(this.toolStripLabel1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 24);
            this.btnDelete.Text = "Delete";
            // 
            // toolStripXoa
            // 
            this.toolStripXoa.Name = "toolStripXoa";
            this.toolStripXoa.Size = new System.Drawing.Size(35, 24);
            this.toolStripXoa.Text = "Xóa";
            this.toolStripXoa.Click += new System.EventHandler(this.toolStripXoa_Click);
            // 
            // btnSuaaa
            // 
            this.btnSuaaa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSuaaa.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaaa.Image")));
            this.btnSuaaa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaaa.Name = "btnSuaaa";
            this.btnSuaaa.Size = new System.Drawing.Size(29, 24);
            this.btnSuaaa.Text = "Edit";
            // 
            // btnSua
            // 
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(34, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuuu
            // 
            this.btnLuuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLuuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuu.Image")));
            this.btnLuuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuuu.Name = "btnLuuu";
            this.btnLuuu.Size = new System.Drawing.Size(29, 24);
            this.btnLuuu.Text = "Save";
            // 
            // btnLuu
            // 
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(33, 24);
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuyy
            // 
            this.btnHuyy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHuyy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyy.Image")));
            this.btnHuyy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuyy.Name = "btnHuyy";
            this.btnHuyy.Size = new System.Drawing.Size(29, 24);
            this.btnHuyy.Text = "Cancel";
            // 
            // btnHuy
            // 
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(35, 24);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "MuonTra";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripMuonTra
            // 
            this.toolStripMuonTra.Name = "toolStripMuonTra";
            this.toolStripMuonTra.Size = new System.Drawing.Size(74, 24);
            this.toolStripMuonTra.Text = "Mượn/Trả";
            this.toolStripMuonTra.Click += new System.EventHandler(this.toolStripMuonTra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenTV);
            this.groupBox1.Controls.Add(this.txtMaTv);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(54, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(546, 24);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(183, 22);
            this.txtSDT.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Điện Thoại";
            // 
            // txtTenTV
            // 
            this.txtTenTV.Location = new System.Drawing.Point(136, 56);
            this.txtTenTV.Name = "txtTenTV";
            this.txtTenTV.Size = new System.Drawing.Size(198, 22);
            this.txtTenTV.TabIndex = 6;
            // 
            // txtMaTv
            // 
            this.txtMaTv.Location = new System.Drawing.Point(136, 24);
            this.txtMaTv.Name = "txtMaTv";
            this.txtMaTv.Size = new System.Drawing.Size(198, 22);
            this.txtMaTv.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(316, 84);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 41);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Thành Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Thành Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH TỔNG\r\n\r\n\r\n";
            // 
            // dgvDST
            // 
            this.dgvDST.BackgroundColor = System.Drawing.Color.White;
            this.dgvDST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDST.Location = new System.Drawing.Point(0, 274);
            this.dgvDST.Name = "dgvDST";
            this.dgvDST.RowHeadersWidth = 51;
            this.dgvDST.RowTemplate.Height = 24;
            this.dgvDST.Size = new System.Drawing.Size(902, 200);
            this.dgvDST.TabIndex = 4;
            this.dgvDST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDST_CellContentClick);
            // 
            // MainThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 511);
            this.Controls.Add(this.dgvDST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainThuVien_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainThuVien_FormClosed);
            this.Load += new System.EventHandler(this.MainThuVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stmiUser;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stmiNV;
        private System.Windows.Forms.ToolStripMenuItem stmiSach;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSuaaa;
        private System.Windows.Forms.ToolStripButton btnLuuu;
        private System.Windows.Forms.ToolStripLabel btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuyy;
        private System.Windows.Forms.ToolStripLabel btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDST;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripMuonTra;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripLabel toolStripThem;
        private System.Windows.Forms.ToolStripLabel toolStripXoa;
        private System.Windows.Forms.ToolStripLabel btnSua;
        private System.Windows.Forms.TextBox txtTenTV;
        private System.Windows.Forms.TextBox txtMaTv;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
    }
}