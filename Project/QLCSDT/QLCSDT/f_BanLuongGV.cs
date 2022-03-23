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
    public partial class f_BanLuongGV : Form
    {
        public f_BanLuongGV()
        {
            InitializeComponent();
            LoadlistBanLuongGV();
            comboboxloadnameGiaoVien(cb_TenGV);

        }
        public void LoadlistBanLuongGV()
        {
            dgv_BanLuongGV.DataSource = BanLuongGVDAO.Instance.GetlistBanLuongGV();
        }
        void comboboxloadnameGiaoVien(ComboBox cb)
        {
            cb.DataSource = GiaoVienDAO.Instance.GetlistGiaoVien();
            cb.DisplayMember = "HovsTen";
        }
        private void btn_XemNV_Click(object sender, EventArgs e)
        {
            LoadlistBanLuongGV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                int msgv = Convert.ToInt32(txt_MSGV.Text);
                DateTime ngay = (DateTime)dateEdit1.EditValue;
                Double sotien = Convert.ToDouble(txt_SoTien.Text);
                if (BanLuongGVDAO.Instance.InsertBanLuongGV(msgv, ngay, sotien))
                {
                    MessageBox.Show("Thêm Lương thành công");
                    LoadlistBanLuongGV();
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
                int msgv = Convert.ToInt32(txt_MSGV.Text);
                DateTime ngay = (DateTime)dateEdit1.EditValue;
                Double sotien = Convert.ToDouble(txt_SoTien.Text);
                if (BanLuongGVDAO.Instance.UpdateBanLuongGV(id, msgv, ngay, sotien))
                {
                    MessageBox.Show("Sữa Lương thành công");
                    LoadlistBanLuongGV();
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

                if (BanLuongGVDAO.Instance.DeleteBanLuongGV(id))
                {
                    MessageBox.Show("Xóa Lương thành công");
                    LoadlistBanLuongGV();
                }
                else
                    MessageBox.Show("Có lỗi khi Xóa Lương");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi Xóa Lương");
            }
        }
        List<BanLuongGV> SearchBanLuongGVByName(string name)
        {
            List<BanLuongGV> listNhanVien = BanLuongGVDAO.Instance.GetSearchBanLuongGVByName(name);
            return listNhanVien;
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            dgv_BanLuongGV.DataSource = SearchBanLuongGVByName(txt_Tim.Text);
        }

        private void dgv_BanLuongGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_BanLuongGV.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgv_BanLuongGV.SelectedRows[0];
            txt_ID.Text = r.Cells["ID"].Value.ToString();
            cb_TenGV.Text = (string)GiaoVienDAO.Instance.GetGiaoVienByID((int)r.Cells["MSGV"].Value).HovsTen;
            txt_MSGV.Text = r.Cells["MSGV"].Value.ToString();
            dateEdit1.EditValue = (DateTime)r.Cells["Ngay"].Value;
            txt_SoTien.Text = r.Cells["SoTien"].Value.ToString();
        }

        private void cb_TenGV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_MSGV.Text = (GiaoVienDAO.Instance.GetGiaoVienByName(cb_TenGV.Text).Id.ToString());
            }
            catch (Exception)
            {
            }
        }
    }
}
