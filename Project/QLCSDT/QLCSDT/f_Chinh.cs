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
    public partial class f_Chinh : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set { loginAccount = value; ChangeAccount(loginAccount.Level); }
        }
        int IDPhong = 0;
        public f_Chinh(Account acc)
        {
            InitializeComponent();
            adminToolStripMenuItem.Enabled = false;
            TaiChinhToolStripMenuItem.Enabled = false;
            toolStripMenuItem2.Enabled = false;
            nhânViênToolStripMenuItem.Enabled = false;
            giáoViênToolStripMenuItem.Enabled = false;

            this.LoginAccount = acc;
            LoadPhong();
        }

        #region metthod
        void ChangeAccount(int level)
        {
            if(level == 1)
            {
                adminToolStripMenuItem.Enabled = level == 1;
                TaiChinhToolStripMenuItem.Enabled = level == 1;
                toolStripMenuItem2.Enabled = level == 1;
                nhânViênToolStripMenuItem.Enabled = level == 1;
                giáoViênToolStripMenuItem.Enabled = level == 1;
            }
            if (level == 2)
            {
                TaiChinhToolStripMenuItem.Enabled = level== 2;
                toolStripMenuItem2.Enabled= level == 2;
                nhânViênToolStripMenuItem.Enabled = level == 2;
                giáoViênToolStripMenuItem.Enabled = level == 2;
            }
            
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + LoginAccount.DislayName+ ")";
            
        }
        void LoadPhong()
        {
            flp_Phong.Controls.Clear();
            List<Phong> phonglist = PhongDAO.Instance.LoadPhongList();
            foreach(Phong item in phonglist)
            {
                Button btn = new Button() { Width = PhongDAO.PhongWidth, Height = PhongDAO.PhongHeight };

                btn.Text = item.TenPhong + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flp_Phong.Controls.Add(btn);
            }
        }
        void ShowPhong(int id)
        {
            List<InfoPhong> Infophonglist = InfoPhongDAO.Instance.LoadinfoPhongList(id);
            foreach (InfoPhong item in Infophonglist)
            {
                txt_TenGiaoVien.Text = item.HovsTen.ToString();
                txt_Mon.Text = item.Mon.ToString();
                txt_NhanVien.Text = item.HovsTenNV.ToString();
                txt_SoHocSinh.Text = item.SOHS.ToString();
                dtp_GioBD.Text = item.GioHoc.ToString();
                dtp_GioKT.Text = item.GioKT.ToString();
            }
        }

        #endregion

        #region Events

        private void btn_Click(object sender, EventArgs e)
        {
            txt_TenGiaoVien.Text = "";
            txt_Mon.Text = "";
            txt_NhanVien.Text = "";
            txt_SoHocSinh.Text = "";
            dtp_GioBD.Text = "";
            dtp_GioKT.Text = "";
            int PhongID = ((sender as Button).Tag as Phong).ID;
            IDPhong = PhongID;
            ShowPhong(PhongID);
            
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_taikhoan f = new f_taikhoan(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
           
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_admin f = new f_admin();
            f.loginAccount = LoginAccount;
            f.ShowDialog();
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DislayName + ")";
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_NhanVien f = new f_NhanVien();
            f.ShowDialog();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_GiaoVien f = new f_GiaoVien();
            f.ShowDialog();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_HocSinh f = new f_HocSinh();
            f.InsertHocSinh += F_InsertHocSinh;
            f.DeleteHocSinh += F_DeleteHocSinh;
            f.UpdateHocSinh += F_UpdateHocSinh;
            f.ShowDialog();
        }

        private void F_UpdateHocSinh(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void F_DeleteHocSinh(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void F_InsertHocSinh(object sender, EventArgs e)
        {
            LoadPhong();
        }
        #endregion

        private void btn_EditPhong_Click(object sender, EventArgs e)
        {
            EditPhong f = new EditPhong();
            f.UpdatePhong += F_UpdatePhong;
            f.ShowDialog();
        }

        private void F_UpdatePhong(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void btn_XemDSHS_Click(object sender, EventArgs e)
        {
            if(IDPhong == 0)
            {
                MessageBox.Show("Vui long chọn phòng trước");
                return;
            }
            frm_DSHS f = new frm_DSHS(IDPhong);
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bảnLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_BanLuongNV f = new f_BanLuongNV();
            f.ShowDialog();
        }

        private void họcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_HocPhi f = new f_HocPhi();
            f.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            f_BanLuongGV f = new f_BanLuongGV();
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            f_Bao_Cao f = new f_Bao_Cao();
            f.ShowDialog();
        }

        private void f_Chinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                e.Cancel = true;
        }
    }
}
