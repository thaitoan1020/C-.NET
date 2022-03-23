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
    public partial class f_BanLuongNV : Form
    {
        public f_BanLuongNV()
        {
            InitializeComponent();
            LoadlistBanLuongNV();
            comboboxloadnameNhanVien(cb_TenNV);
        }
        public void LoadlistBanLuongNV()
        {
            dgv_BanLuongNV.DataSource = BanLuongNVDAO.Instance.GetlistBanLuongNV();
        }
        void comboboxloadnameNhanVien(ComboBox cb)
        {
            cb.DataSource = NhanVienDAO.Instance.GetlistNhanVien();
            cb.DisplayMember = "HovsTen";
        }
        private void btn_XemNV_Click(object sender, EventArgs e)
        {
            LoadlistBanLuongNV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                int msnv = Convert.ToInt32(txt_MSNV.Text);
                DateTime ngay = (DateTime)dateEdit1.EditValue;
                Double sotien = Convert.ToDouble(txt_SoTien.Text);
                if (BanLuongNVDAO.Instance.InsertBanLuongNV(msnv, ngay, sotien))
                {
                    MessageBox.Show("Thêm Lương thành công");
                    LoadlistBanLuongNV();
                }
                else
                    MessageBox.Show("Có lỗi khi thêm Lương");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi thêm Lương");
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID.Text);
                int msnv = Convert.ToInt32(txt_MSNV.Text);
                DateTime ngay = (DateTime)dateEdit1.EditValue;
                Double sotien = Convert.ToDouble(txt_SoTien.Text);
                if (BanLuongNVDAO.Instance.UpdateBanLuongNV(id,msnv, ngay, sotien))
                {
                    MessageBox.Show("Sữa Lương thành công");
                    LoadlistBanLuongNV();
                }
                else
                    MessageBox.Show("Có lỗi khi sữa Lương");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi sữa Lương");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID.Text);
                
                if (BanLuongNVDAO.Instance.DeleteBanLuongNV(id))
                {
                    MessageBox.Show("Xóa Lương thành công");
                    LoadlistBanLuongNV();
                }
                else
                    MessageBox.Show("Có lỗi khi Xóa Lương");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi Xóa Lương");
            }
        }
        List<BanLuongNV> SearchBanLuongNVByName(string name)
        {
            List<BanLuongNV> listNhanVien = BanLuongNVDAO.Instance.GetSearchBanLuongNVByName(name);
            return listNhanVien;
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            dgv_BanLuongNV.DataSource = SearchBanLuongNVByName(txt_Tim.Text);
        }

        private void dgv_BanLuongNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_BanLuongNV.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgv_BanLuongNV.SelectedRows[0];
            txt_ID.Text = r.Cells["ID"].Value.ToString();
            cb_TenNV.Text = (string)NhanVienDAO.Instance.GetNhanVienByID((int)r.Cells["MSNV"].Value).HovsTen;
            txt_MSNV.Text = r.Cells["MSNV"].Value.ToString();
            dateEdit1.EditValue = (DateTime)r.Cells["Ngay"].Value;
            txt_SoTien.Text = r.Cells["SoTien"].Value.ToString();
        }

        private void cb_TenNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_MSNV.Text = (NhanVienDAO.Instance.GetNhanVienByName(cb_TenNV.Text).ID.ToString());
            }
            catch (Exception)
            {
            }

        }
    }
}
