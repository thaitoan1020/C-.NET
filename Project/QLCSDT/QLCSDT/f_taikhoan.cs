
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
    public partial class f_taikhoan : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public f_taikhoan(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txt_TenDangNhap.Text = LoginAccount.UserName;
            txt_TenHienThi.Text = LoginAccount.DislayName;

        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void updateAccountInfo()
        {
            string displayName = txt_TenHienThi.Text;
            string password = txt_Pass.Text;
            string newpass = txt_NhapLaiPass.Text;
            string reenterPass = txt_NewPass.Text;
            string userName = txt_TenDangNhap.Text;

            if(!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }else
            {
                if(AccountDAO.Instance.UpdateAccount(userName,displayName,password,newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            updateAccountInfo();
        }
        
    }
    public class AccountEvent:EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }
        public  AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
