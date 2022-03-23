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
    public partial class f_Bao_Cao : Form
    {
        public f_Bao_Cao()
        {
            InitializeComponent();
        }

        private void f_Bao_Cao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCSDTDataSet.GiaoVien' table. You can move, or remove it, as needed.
            this.GiaoVienTableAdapter.Fill(this.QLCSDTDataSet.GiaoVien);
            // TODO: This line of code loads data into the 'QLCSDTDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.QLCSDTDataSet.NhanVien);
            // TODO: This line of code loads data into the 'QLCSDTDataSet.HocSinh' table. You can move, or remove it, as needed.
            this.HocSinhTableAdapter.Fill(this.QLCSDTDataSet.HocSinh);
            // TODO: This line of code loads data into the 'QLCSDTDataSet.NewBanLuongGV' table. You can move, or remove it, as needed.
            this.NewBanLuongGVTableAdapter.Fill(this.QLCSDTDataSet.NewBanLuongGV);
            // TODO: This line of code loads data into the 'QLCSDTDataSet.NewBanLuongNV' table. You can move, or remove it, as needed.
            this.NewBanLuongNVTableAdapter.Fill(this.QLCSDTDataSet.NewBanLuongNV);
            // TODO: This line of code loads data into the 'QLCSDTDataSet.NewHocPhi' table. You can move, or remove it, as needed.
            this.NewHocPhiTableAdapter.Fill(this.QLCSDTDataSet.NewHocPhi);
           


            this.rp_HocPhi.RefreshReport();
            this.rp_HocPhi.RefreshReport();
            this.rp_DSGV.RefreshReport();
            this.rp_DSNV.RefreshReport();
            this.rp_DSHS.RefreshReport();
            this.rp_LGV.RefreshReport();
            this.rp_LNV.RefreshReport();
        }
    }
}
