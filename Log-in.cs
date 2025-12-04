using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom17_QuanLyThuVien
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUser;
        }
 
        bool CheckLogin( string userName , string passWord)
        {
            for(int i = 0;i < ListUser.Instance.ListAccountUser.Count; i++)
            {
                if(userName ==ListUser.Instance.ListAccountUser[i].UserName && passWord == ListUser.Instance.ListAccountUser[i].Password)
                {
                   
                    return true;
                }
                    
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string pass = txtPassWord.Text;
            if (CheckLogin(name, pass))
            {
                MainThuVien f = new MainThuVien();
                f.Show();
                this.Hide();
                f.LogOut +=F_LogOut;
            }
            else
            {
                MessageBox.Show("Not Found UserName or PassWord", "Lỗi", MessageBoxButtons.OK);
                txtUser.Focus();
                return;
            }
               
        }

        private void F_LogOut(object sender, EventArgs e)
        {
            (sender as MainThuVien).isExit = false;
            (sender as MainThuVien).Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát !",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (rs == DialogResult.Yes) { 
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcHienThiMatKhau.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            if (!ckcHienThiMatKhau.Checked)
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
