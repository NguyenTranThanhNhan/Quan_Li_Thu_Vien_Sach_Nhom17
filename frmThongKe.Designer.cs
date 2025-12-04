namespace Nhom17_QuanLyThuVien
{
    partial class frmThongKe
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
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Location = new System.Drawing.Point(345, 22);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(269, 24);
            this.cbbThongKe.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.pngtree_vector_search_icon_png_image_320926;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(646, 12);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(116, 42);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.pngtree_exit_icon_vectors_png_image_1737870;
            this.Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Thoat.Location = new System.Drawing.Point(24, 12);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(77, 42);
            this.Thoat.TabIndex = 39;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 135);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(800, 315);
            this.dgvThongKe.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 48);
            this.label1.TabIndex = 41;
            this.label1.Text = "BẢNG THỐNG KÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cbbThongKe);
            this.Name = "frmThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label label1;
    }
}