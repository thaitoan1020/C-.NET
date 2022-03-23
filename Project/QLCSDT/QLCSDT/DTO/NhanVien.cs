using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class NhanVien
    {
        public NhanVien(int iD, string hovsTen, string diaChi, DateTime? ngaySinh, int phai, string sdt, string congViec)
        {
            this.ID = iD;
            this.HovsTen = hovsTen;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.Phai = phai;
            this.Sdt = sdt;
            this.CongViec = congViec;
        }
        public NhanVien(DataRow row)
        {
            this.ID = (int)row["id"];
            this.HovsTen = row["HovsTen"].ToString();
            this.DiaChi = row["Diachi"].ToString();
            this.NgaySinh = (DateTime?)row["NgaySinh"];
            this.Phai = (int)row["Phai"];
            this.Sdt = row["Sdt"].ToString();
            this.CongViec = row["CongViec"].ToString();
        }
        private int iD;
        private string hovsTen;
        private string diaChi;
        private DateTime? ngaySinh;
        private int phai;
        private string sdt;
        private string congViec;

        public int ID { get => iD; set => iD = value; }
        public string HovsTen { get => hovsTen; set => hovsTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int Phai { get => phai; set => phai = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string CongViec { get => congViec; set => congViec = value; }
    }
}
