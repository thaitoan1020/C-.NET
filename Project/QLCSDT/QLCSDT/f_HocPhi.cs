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
    public partial class f_HocPhi : Form
    {
        public f_HocPhi()
        {
            InitializeComponent();
            LoadlisthocPhi();
            comboboxloadnameH(cb_TenHS);
        }
        public void LoadlisthocPhi()
        {
            dgv_HocPhi.DataSource = HocPhiDAO.Instance.GetlistHocPhi();
        }
        void comboboxloadnameH(ComboBox cb)
        {
            cb.DataSource = HocSinhDAO.Instance.GetlisHocSinh();
            cb.DisplayMember = "HovsTen";
        }
        private void btn_XemNV_Click(object sender, EventArgs e)
        {
            LoadlisthocPhi();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                int mshs = Convert.ToInt32(txt_MSHS.Text);
                DateTime ngay = (DateTime)dateEdit1.EditValue;
                Double sotien = Convert.ToDouble(txt_SoTien.Text);
                if (HocPhiDAO.Instance.InsertHocPhi(mshs, ngay, sotien))
                {
                    MessageBox.Show("Thêm học phí thành công");
                    LoadlisthocPhi();
                }
                else
                    MessageBox.Show("Có lỗi khi thêm học phí");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi thêm học phí");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID.Text);
                int mshs = Convert.ToInt32(txt_MSHS.Text);
                DateTime ngay = (DateTime)dateEdit1.EditValue;
                Double sotien = Convert.ToDouble(txt_SoTien.Text);
                if (HocPhiDAO.Instance.UpdateHocPhi(id, mshs, ngay, sotien))
                {
                    MessageBox.Show("Sữa học phí thành công");
                    LoadlisthocPhi();
                }
                else
                    MessageBox.Show("Có lỗi khi sữa học phí");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi sữa học phí");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID.Text);

                if (HocPhiDAO.Instance.DeleteHocPhi(id))
                {
                    MessageBox.Show("Xóa học phí thành công");
                    LoadlisthocPhi();
                }
                else
                    MessageBox.Show("Có lỗi khi Xóa học phí");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi Xóa Lương");
            }
        }
        List<HocPhi> SearchHocPhiByName(string name)
        {
            List<HocPhi> listNhanVien = HocPhiDAO.Instance.GetSearchHocPhiByName(name);
            return listNhanVien;
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            dgv_HocPhi.DataSource = SearchHocPhiByName(txt_Tim.Text);
        }

        private void dgv_HocPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_HocPhi.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgv_HocPhi.SelectedRows[0];
            txt_ID.Text = r.Cells["ID"].Value.ToString();
            cb_TenHS.Text = (string)HocSinhDAO.Instance.GetHocSinhByID((int)r.Cells["MSHS"].Value).HovsTen;
            txt_MSHS.Text = r.Cells["MSHS"].Value.ToString();
            dateEdit1.EditValue = (DateTime)r.Cells["Ngay"].Value;
            txt_SoTien.Text = r.Cells["SoTien"].Value.ToString();
        }

        private void cb_TenHS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_MSHS.Text = (HocSinhDAO.Instance.GetHocSinhnByName(cb_TenHS.Text).Id.ToString());
            }
            catch (Exception)
            {
            }
        }
    }
}
