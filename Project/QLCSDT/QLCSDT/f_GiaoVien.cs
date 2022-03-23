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
    public partial class f_GiaoVien : Form
    {
        public f_GiaoVien()
        {
            InitializeComponent();
            rest_txt();
            LoadListNhanVien();
        }
        void LoadListNhanVien()
        {
            dgv_GiaoVien.DataSource = GiaoVienDAO.Instance.GetlistGiaoVien();
        }
        private void btn_XemNV_Click(object sender, EventArgs e)
        {
            rest_txt();
            LoadListNhanVien();
        }
        void rest_txt()
        {
            txt_ID.Text = "";
            txt_HoVsTen.Text = "";
            txt_DiaChi.Text = "";
            dateEdit1.EditValue = "";
            rdob_Nam.Checked = false;
            rdob_Nu.Checked = false;
            txt_SDT.Text = "";
            txt_Mon.Text = "";

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_HoVsTen.Text;
                string diachi = txt_DiaChi.Text;
                DateTime ngaysinh = (DateTime)dateEdit1.EditValue;
                int phai = rdob_Nam.Checked ? 1 : 0;
                string sdt = txt_SDT.Text;
                string Mon = txt_Mon.Text;
                if (GiaoVienDAO.Instance.InsertGiaoVien(name, diachi, ngaysinh, phai, sdt, Mon))
                {
                    MessageBox.Show("Thêm Giáo Viên thành công");
                    LoadListNhanVien();
                }
                else
                    MessageBox.Show("Có lỗi khi thêm Giáo Viên");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi thêm Giáo Viên");
            }
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID.Text);
            string name = txt_HoVsTen.Text;
            string diachi = txt_DiaChi.Text;
            DateTime ngaysinh = (DateTime)dateEdit1.EditValue;
            int phai = rdob_Nam.Checked ? 1 : 0;
            string sdt = txt_SDT.Text;
            string Mon = txt_Mon.Text;
            if (GiaoVienDAO.Instance.UpdateGiaoVien(id, name, diachi, ngaysinh, phai, sdt, Mon))
            {
                MessageBox.Show("Sữa Giáo Viên thành công");
                LoadListNhanVien();
            }
            else
                MessageBox.Show("Có lỗi khi sữa Giáo Viên");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID.Text);
            if (GiaoVienDAO.Instance.DeleteGiaoVien(id))
            {
                MessageBox.Show("Xóa Giáo Viên thành công");
                LoadListNhanVien();
            }
            else
                MessageBox.Show("Có lỗi khi xóa Giáo Viên");
        }
        List<GiaoVien> SearchGiaoVienbByName(string name)
        {
            List<GiaoVien> listGiaoVien = GiaoVienDAO.Instance.GetSearchGiaoVienByName(name);
            return listGiaoVien;
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            dgv_GiaoVien.DataSource = SearchGiaoVienbByName(txt_Tim.Text);
        }

        private void dgv_GiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_GiaoVien.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgv_GiaoVien.SelectedRows[0];
            txt_ID.Text = r.Cells["ID"].Value.ToString();
            txt_HoVsTen.Text = r.Cells["HovsTen"].Value.ToString();
            txt_DiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            dateEdit1.EditValue = (DateTime)r.Cells["NgaySinh"].Value;
            if ((int)r.Cells["Phai"].Value == 1) rdob_Nam.Checked = true;
            else rdob_Nu.Checked = true;
            txt_SDT.Text = r.Cells["Sdt"].Value.ToString();
            txt_Mon.Text = r.Cells["Mon"].Value.ToString();
        }
    }
}
