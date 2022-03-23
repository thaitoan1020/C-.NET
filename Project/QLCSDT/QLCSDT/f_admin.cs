using DevExpress.Utils.CommonDialogs;
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
    public partial class f_admin : Form
    {
        public f_admin()
        {
            InitializeComponent();
        }
        public Account loginAccount;
        private void fadmin_Load(object sender, EventArgs e)
        {
            loadListAccount();
        }

        private void btn_XemTK_Click(object sender, EventArgs e)
        {
            loadListAccount();
        }
        void loadListAccount()
        {
            dgv_TK.DataSource = AccountDAO.Instance.GetlisAccount();
        }

        private void dgv_TK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_TK.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgv_TK.SelectedRows[0];
            txt_TenHienThiTK.Text = r.Cells["DislayName"].Value.ToString();
            txt_TenDangNhapTK.Text = r.Cells["UserName"].Value.ToString();
            txt_LoaiTaiKhoan.Text = r.Cells["level"].Value.ToString();
           
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            
            string UserName = txt_TenDangNhapTK.Text;
            if (loginAccount.UserName.Equals(UserName))
            {
                MessageBox.Show("Vui Long đừng xáo chính bạn chứ :)");
                return;
            }
            if (AccountDAO.Instance.DeleteAcount(UserName))
            {
                MessageBox.Show("Xóa Account thành công");
                loadListAccount();
            }
            else
                MessageBox.Show("Có lỗi khi Xóa Account");
        }

        private void btn_SuaTK_Click(object sender, EventArgs e)
        {
            string UserName = txt_TenDangNhapTK.Text;
            string DislayName = txt_TenHienThiTK.Text;
            int Level = (int)txt_LoaiTaiKhoan.Value;
            if (AccountDAO.Instance.UpdateAcount(DislayName, UserName, Level))
            {
                MessageBox.Show("Sữa Account thành công");
                loadListAccount();
            }
            else
                MessageBox.Show("Có lỗi khi Sữa Account");
        }

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            string UserName = txt_TenDangNhapTK.Text;
            string DislayName = txt_TenHienThiTK.Text;
            int Level = (int)txt_LoaiTaiKhoan.Value;
            if (AccountDAO.Instance.InsertAcount(DislayName,UserName,Level))
            {
                MessageBox.Show("Thêm Account thành công");
                loadListAccount();
            }
            else
                MessageBox.Show("Có lỗi khi thêm Account");
        }

        private void btn_DatLaiMKTK_Click(object sender, EventArgs e)
        {
            string UserName = txt_TenDangNhapTK.Text;
            if (AccountDAO.Instance.RestPassword(UserName))
            {
                MessageBox.Show("Reset pass thành công");
                loadListAccount();
            }
            else
                MessageBox.Show("Có lỗi khi reset pass");
        }

        private void searchControl1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Chọn đường đẫn tới ổ D,F (trừ ổ hệ thống)";
            if (f.ShowDialog() == DialogResult.OK)
            {
                searchControl1.EditValue = f.SelectedPath.ToString();
            }
        }

        private void searchControl2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
           
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Chọn đường dẫn tới file Backup";
            o.Filter = "Backup Database File | *.bak";
            if (o.ShowDialog() == DialogResult.OK)
            {
                searchControl2.EditValue = o.FileName.ToString();
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccountDAO.Instance.BackupQLCSDT(txt_TenFile.Text, searchControl1.EditValue.ToString()))
                {
                    MessageBox.Show("Sao lưu thành công");
                }
                
            }catch(Exception)
            { 
               MessageBox.Show("Có lỗi khi sao lưu");
            }


        }

        private void btn_XacNhan1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (AccountDAO.Instance.RESTOREQLCSDT(searchControl2.EditValue.ToString()))
                {
                    MessageBox.Show("Khôi phục thành công");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi Khôi phục");
            }
        }
    }
}
