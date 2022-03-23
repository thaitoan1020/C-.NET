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
    public partial class f_HocSinh : Form
    {
        public f_HocSinh()
        {
            InitializeComponent();
            LoadListHocSinh();
        }
        void LoadListHocSinh()
        {
            dgv_HocSinh.DataSource = HocSinhDAO.Instance.GetlisHocSinh();
        }

        private void btn_XemNV_Click(object sender, EventArgs e)
        {
            LoadListHocSinh();
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
                int mt = rb_MT_C.Checked ? 1 : 0;
                int ml = rb_ML_C.Checked ? 1 : 0;
                int mh = rb_MH_C.Checked ? 1 : 0;
                int ma = rb_MA_C.Checked ? 1 : 0;
                int mv = rb_MV_C.Checked ? 1 : 0;
                int somom = Convert.ToInt32(txt_SoMon.Text);
                int idphong = Convert.ToInt32(txt_IDPhong.Text);
                if (HocSinhDAO.Instance.InsertHocSinh(name, diachi, ngaysinh, phai, sdt, mt,ml,mh,ma,mv,somom,idphong))
                {
                    MessageBox.Show("Thêm Học Sinh thành công");
                    LoadListHocSinh();
                    if (insertHocSinh != null)
                        insertHocSinh(this, new EventArgs());
                }
                else
                    MessageBox.Show("Có lỗi khi thêm Học Sinh");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi thêm Học Sinh");
            }
        }

        private void dgv_HocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_HocSinh.SelectedRows.Count == 0) return;
            DataGridViewRow r = dgv_HocSinh.SelectedRows[0];
            txt_ID_HS.Text = r.Cells["ID"].Value.ToString();
            txt_HoVsTen.Text = r.Cells["HovsTen"].Value.ToString();
            txt_DiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            dateEdit1.EditValue = (DateTime)r.Cells["NgaySinh"].Value;
            if ((int)r.Cells["Phai"].Value == 1) rdob_Nam.Checked = true;
            else rdob_Nu.Checked = true;
            txt_SDT.Text = r.Cells["Sdt"].Value.ToString();
            if ((int)r.Cells["MonToan"].Value == 1) rb_MT_C.Checked = true;
            else rb_MT_K.Checked = true;
            if ((int)r.Cells["MonLy"].Value == 1) rb_ML_C.Checked = true;
            else rb_ML_K.Checked = true;
            if ((int)r.Cells["MonHoa"].Value == 1) rb_MH_C.Checked = true;
            else rb_MH_K.Checked = true;
            if ((int)r.Cells["MonAnh"].Value == 1) rb_MA_C.Checked = true;
            else rb_MA_K.Checked = true;
            if ((int)r.Cells["MonVan"].Value == 1) rb_MV_C.Checked = true;
            else rb_MV_K.Checked = true;
            txt_SoMon.Text = r.Cells["SoMon"].Value.ToString();
            txt_IDPhong.Text = r.Cells["IdPhong"].Value.ToString();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID_HS.Text);
            string name = txt_HoVsTen.Text;
            string diachi = txt_DiaChi.Text;
            DateTime ngaysinh = (DateTime)dateEdit1.EditValue;
            int phai = rdob_Nam.Checked ? 1 : 0;
            string sdt = txt_SDT.Text;
            int mt = rb_MT_C.Checked ? 1 : 0;
            int ml = rb_ML_C.Checked ? 1 : 0;
            int mh = rb_MH_C.Checked ? 1 : 0;
            int ma = rb_MA_C.Checked ? 1 : 0;
            int mv = rb_MV_C.Checked ? 1 : 0;
            int somom = Convert.ToInt32(txt_SoMon.Text);
            int idphong = Convert.ToInt32(txt_IDPhong.Text);
            if (HocSinhDAO.Instance.UpdateHocSinh( id , name , diachi, ngaysinh, phai, sdt, mt, ml, mh, ma, mv, somom, idphong))
            {
                MessageBox.Show("Sữa Học Sinh thành công");
                LoadListHocSinh();
                if (updateHocSinh != null)
                    updateHocSinh(this, new EventArgs());
            }
            else
                MessageBox.Show("Có lỗi khi sữa Học Sinh");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ID_HS.Text);
           
            if (HocSinhDAO.Instance.DeleteHocSinh(id))
            {
                MessageBox.Show("Xóa Học Sinh thành công");
                LoadListHocSinh();
                LoadListHocSinh();
                if (deleteHocSinh != null)
                    deleteHocSinh(this, new EventArgs());
            }
            else
                MessageBox.Show("Có lỗi khi Xóa Học Sinh");
        }
        List<HocSinh> SearchNhanVienByName(string name)
        {
            List<HocSinh> listNhanVien = HocSinhDAO.Instance.GetSearchHocSinhByName(name);
            return listNhanVien;
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            dgv_HocSinh.DataSource = SearchNhanVienByName(txt_Tim.Text);
        }
        private event EventHandler insertHocSinh;
        public event EventHandler InsertHocSinh
        {
            add { insertHocSinh += value; }
            remove { insertHocSinh -= value; }
        }
        private event EventHandler updateHocSinh;
        public event EventHandler UpdateHocSinh
        {
            add { updateHocSinh += value; }
            remove { updateHocSinh -= value; }
        }
        private event EventHandler deleteHocSinh;
        public event EventHandler DeleteHocSinh
        {
            add { deleteHocSinh += value; }
            remove { deleteHocSinh -= value; }
        }
    }
}
