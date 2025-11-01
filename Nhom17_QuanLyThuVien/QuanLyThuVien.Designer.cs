namespace Nhom17_QuanLyThuVien
{
    partial class QuanLyThuVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.Sach = new System.Windows.Forms.Button();
            this.ThanhVien = new System.Windows.Forms.Button();
            this.MuonTra = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Quản Lý Thư Viện";
            // 
            // Sach
            // 
            this.Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sach.Location = new System.Drawing.Point(294, 91);
            this.Sach.Name = "Sach";
            this.Sach.Size = new System.Drawing.Size(236, 35);
            this.Sach.TabIndex = 1;
            this.Sach.Text = "Quản Lý Sách";
            this.Sach.UseVisualStyleBackColor = true;
            this.Sach.Click += new System.EventHandler(this.Sach_Click);
            // 
            // ThanhVien
            // 
            this.ThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThanhVien.Location = new System.Drawing.Point(203, 154);
            this.ThanhVien.Name = "ThanhVien";
            this.ThanhVien.Size = new System.Drawing.Size(415, 37);
            this.ThanhVien.TabIndex = 2;
            this.ThanhVien.Text = "Quản Lý Thành Viên";
            this.ThanhVien.UseVisualStyleBackColor = true;
            this.ThanhVien.Click += new System.EventHandler(this.ThanhVien_Click);
            // 
            // MuonTra
            // 
            this.MuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MuonTra.Location = new System.Drawing.Point(294, 228);
            this.MuonTra.Name = "MuonTra";
            this.MuonTra.Size = new System.Drawing.Size(236, 39);
            this.MuonTra.TabIndex = 3;
            this.MuonTra.Text = "Mượn/Trả Sách";
            this.MuonTra.UseVisualStyleBackColor = true;
            this.MuonTra.Click += new System.EventHandler(this.MuonTra_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat.Location = new System.Drawing.Point(294, 300);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(236, 37);
            this.Thoat.TabIndex = 4;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // QuanLyThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.MuonTra);
            this.Controls.Add(this.ThanhVien);
            this.Controls.Add(this.Sach);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sach;
        private System.Windows.Forms.Button ThanhVien;
        private System.Windows.Forms.Button MuonTra;
        private System.Windows.Forms.Button Thoat;
    }
}