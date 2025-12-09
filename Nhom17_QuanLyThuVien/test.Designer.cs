namespace Nhom17_QuanLyThuVien
{
    partial class test
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
            this.Thoat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Thoat
            // 
            this.Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Thoat.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Thoat.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.pngtree_exit_icon_vectors_png_image_1737870;
            this.Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Thoat.Location = new System.Drawing.Point(12, 21);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(102, 42);
            this.Thoat.TabIndex = 55;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Thoat.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Image = global::Nhom17_QuanLyThuVien.Properties.Resources.pngtree_vector_search_icon_png_image_320926;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(777, 21);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(116, 42);
            this.btnThongKe.TabIndex = 54;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Location = new System.Drawing.Point(502, 30);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(269, 24);
            this.cbbThongKe.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(187, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 59;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 773);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cbbThongKe);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cbbThongKe;
        private System.Windows.Forms.Panel panel1;
    }
}