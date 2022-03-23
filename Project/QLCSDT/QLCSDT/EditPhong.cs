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
    public partial class EditPhong : Form
    {
        public EditPhong()
        {
            InitializeComponent();
            comboboxloadnameNhanVien(cb_TenNhanVien);
            comboboxloadnameGiaoVien(cb_TenGiaoVien);
            loadlistPhong();
        }

        private void btn_XemNV_Click(object sender, EventArgs e)
        {
            loadlistPhong();
        }
        void comboboxloadnameNhanVien(ComboBox cb)
        {
            cb.DataSource = NhanVienDAO.Instance.GetlistNhanVien();
            cb.DisplayMember = "HovsTen";
        }
        void comboboxloadnameGiaoVien(ComboBox cb)
        {
            cb.DataSource = GiaoVienDAO.Instance.GetlistGiaoVien();
            cb.DisplayMember = "HovsTen";
        }
        void loadlistPhong()
        {
            dgv_Phong.DataSource = PhongDAO.Instance.LoadPhongList();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID.Text);
            string name = txt_TenPhong.Text;
            int msgv = (cb_TenGiaoVien.SelectedItem as GiaoVien).Id;
            int msnv = (cb_TenNhanVien.SelectedItem as NhanVien).ID;
            DateTime giohoc = dtp_GioHoc.Value;
            DateTime giokt = dtp_GioKetThuc.Value;
            string status = txt_TrangThai.Text;
            if (PhongDAO.Instance.UpdatePhong(id, name, msgv, msnv, giohoc, giokt, status))
            {
                MessageBox.Show("Sữa Phòng thành công");
                loadlistPhong();
                if (updatePhong != null)
                    updatePhong(this, new EventArgs());
            }
            else
                MessageBox.Show("Có lỗi khi sữa Phòng");
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            dgv_Phong.DataSource = SearchPhongByName(txt_Tim.Text);
        }

        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Phong.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgv_Phong.SelectedRows[0];
            txt_ID.Text = r.Cells["ID"].Value.ToString();
            txt_TenPhong.Text = r.Cells["TenPhong"].Value.ToString();
            cb_TenGiaoVien.Text = (string)GiaoVienDAO.Instance.GetGiaoVienByID((int)r.Cells["MSGV"].Value).HovsTen;
            cb_TenNhanVien.Text = (string)NhanVienDAO.Instance.GetNhanVienByID((int)r.Cells["MSNV"].Value).HovsTen;
            dtp_GioHoc.Value = (DateTime)r.Cells["GioHoc"].Value;
            dtp_GioKetThuc.Value = (DateTime)r.Cells["GioKT"].Value;
            txt_TrangThai.Text = r.Cells["Status"].Value.ToString();
        }
        List<Phong> SearchPhongByName(string name)
        {
            List<Phong> listPhong = PhongDAO.Instance.GetSearchPhongByName(name);
            return listPhong;
        }
        private event EventHandler updatePhong;
        public event EventHandler UpdatePhong
        {
            add { updatePhong += value; }
            remove { updatePhong -= value; }
        }
    }
}
