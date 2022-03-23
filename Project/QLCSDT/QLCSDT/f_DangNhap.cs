using QLCSDT.DAO;
using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCSDT
{
    public partial class f_DangNhap : Form
    {
        public f_DangNhap()
        {
            InitializeComponent();
        }

       
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
        

        private void f_DN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muôn thoát không?","Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }

        private void btn_DN_Click_1(object sender, EventArgs e)
        {
            string userNam = txt_DN.Text;
            string passWord = txt_Pass.Text;
            if (Login(userNam, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userNam);
                f_Chinh f = new f_Chinh(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
