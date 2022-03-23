using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class GiaoVien
    {
        public GiaoVien (int id, string hovsTen, string diaChi, DateTime? ngaySinh, int phai, string sdt, string mon)
        {
            this.Id = id;
            this.HovsTen = hovsTen;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.Phai = phai;
            this.Sdt = sdt;
            this.Mon = mon;
        }
        public GiaoVien(DataRow row)
        {
            this.Id = (int)row["id"];
            this.HovsTen = row["HovsTen"].ToString();
            this.DiaChi = row["Diachi"].ToString();
            this.NgaySinh = (DateTime?)row["NgaySinh"];
            this.Phai = (int)row["Phai"];
            this.Sdt = row["Sdt"].ToString();
            this.Mon = row["Mon"].ToString();
        }

        private int id;
        private string hovsTen;
        private string diaChi;
        private DateTime? ngaySinh;
        private int phai;
        private string sdt;
        private string mon;

        public int Id { get => id; set => id = value; }
        public string HovsTen { get => hovsTen; set => hovsTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int Phai { get => phai; set => phai = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Mon { get => mon; set => mon = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
