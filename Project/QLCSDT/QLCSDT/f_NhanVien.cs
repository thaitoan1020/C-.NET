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
    public partial class f_NhanVien : Form
    {
        public f_NhanVien()
        {
            InitializeComponent();
            LoadListNhanVien();
            rest_txt();
        }
        void LoadListNhanVien()
        {
            dgv_NhanVien.DataSource = NhanVienDAO.Instance.GetlistNhanVien();
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
            dateEdit1.EditValue ="";
            rdob_Nam.Checked = false;
            rdob_Nu.Checked = false;
            txt_SDT.Text = "";
            txt_CongViec.Text = "";
        
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NhanVien.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgv_NhanVien.SelectedRows[0];
            txt_ID.Text = r.Cells["ID"].Value.ToString();
            txt_HoVsTen.Text = r.Cells["HovsTen"].Value.ToString();
            txt_DiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            dateEdit1.EditValue = (DateTime)r.Cells["NgaySinh"].Value;
            if ((int)r.Cells["Phai"].Value == 1) rdob_Nam.Checked = true;
            else rdob_Nu.Checked = true;
            txt_SDT.Text = r.Cells["Sdt"].Value.ToString();
            txt_CongViec.Text = r.Cells["CongViec"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                //string Name, string diachi, DateTime? ngaysinh, int Phai, string std, string CongViec
                string name = txt_HoVsTen.Text;
                string diachi = txt_DiaChi.Text;
                DateTime ngaysinh = (DateTime)dateEdit1.EditValue;
                int phai = rdob_Nam.Checked ? 1 : 0;
                string sdt = txt_SDT.Text;
                string congviec = txt_CongViec.Text;
                if (NhanVienDAO.Instance.InsertNhanVien(name, diachi, ngaysinh, phai, sdt, congviec))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    LoadListNhanVien();
                }
                else
                    MessageBox.Show("Có lỗi khi thêm nhân viên");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên");
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
            string congviec = txt_CongViec.Text;
            if (NhanVienDAO.Instance.UpdateNhanVien(id,name,diachi,ngaysinh,phai,sdt,congviec))
            {
                MessageBox.Show("Sữa nhân viên thành công");
                LoadListNhanVien();
            }
            else
                MessageBox.Show("Có lỗi khi sữa nhân viên");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID.Text);
            if (NhanVienDAO.Instance.DeleteNhanVien(id))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                LoadListNhanVien();
            }
            else
                MessageBox.Show("Có lỗi khi xóa nhân viên");

        }
        List<NhanVien> SearchNhanVienByName (string name)
        {
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.GetSearchNhanVienByName(name);
            return listNhanVien;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = SearchNhanVienByName(txt_Tim.Text);
        }
    }
}
