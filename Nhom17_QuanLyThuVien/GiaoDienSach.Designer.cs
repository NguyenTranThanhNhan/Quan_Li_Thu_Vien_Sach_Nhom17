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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaSach = new System.Windows.Forms.TextBox();
            this.Gia = new System.Windows.Forms.TextBox();
            this.TheLoai = new System.Windows.Forms.TextBox();
            this.TacGia = new System.Windows.Forms.TextBox();
            this.TenSach = new System.Windows.Forms.TextBox();
            this.NgaySX = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Thoat = new System.Windows.Forms.Button();
            this.DaTaSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DaTaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(569, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(569, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(569, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(569, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tìm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tác Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Năm Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thể Loại";
            // 
            // MaSach
            // 
            this.MaSach.Location = new System.Drawing.Point(101, 112);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(374, 22);
            this.MaSach.TabIndex = 10;
            this.MaSach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Gia
            // 
            this.Gia.Location = new System.Drawing.Point(101, 333);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(374, 22);
            this.Gia.TabIndex = 12;
            // 
            // TheLoai
            // 
            this.TheLoai.Location = new System.Drawing.Point(101, 388);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Size = new System.Drawing.Size(374, 22);
            this.TheLoai.TabIndex = 13;
            // 
            // TacGia
            // 
            this.TacGia.Location = new System.Drawing.Point(101, 217);
            this.TacGia.Name = "TacGia";
            this.TacGia.Size = new System.Drawing.Size(374, 22);
            this.TacGia.TabIndex = 14;
            // 
            // TenSach
            // 
            this.TenSach.Location = new System.Drawing.Point(101, 166);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(374, 22);
            this.TenSach.TabIndex = 15;
            // 
            // NgaySX
            // 
            this.NgaySX.Location = new System.Drawing.Point(175, 270);
            this.NgaySX.Name = "NgaySX";
            this.NgaySX.Size = new System.Drawing.Size(193, 22);
            this.NgaySX.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(290, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yêu Cầu Về Sách";
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat.Location = new System.Drawing.Point(569, 394);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(164, 44);
            this.Thoat.TabIndex = 18;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // DaTaSach
            // 
            this.DaTaSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaTaSach.Location = new System.Drawing.Point(12, 444);
            this.DaTaSach.Name = "DaTaSach";
            this.DaTaSach.RowHeadersWidth = 51;
            this.DaTaSach.RowTemplate.Height = 24;
            this.DaTaSach.Size = new System.Drawing.Size(721, 251);
            this.DaTaSach.TabIndex = 19;
            // 
            // GiaoDienSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.DaTaSach);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NgaySX);
            this.Controls.Add(this.TenSach);
            this.Controls.Add(this.TacGia);
            this.Controls.Add(this.TheLoai);
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.MaSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GiaoDienSach";
            this.Text = "Giao Diện  Sách ";
            this.Load += new System.EventHandler(this.GiaoDienSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaTaSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaSach;
        private System.Windows.Forms.TextBox Gia;
        private System.Windows.Forms.TextBox TheLoai;
        private System.Windows.Forms.TextBox TacGia;
        private System.Windows.Forms.TextBox TenSach;
        private System.Windows.Forms.DateTimePicker NgaySX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView DaTaSach;
    }
}