using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class DSHS
    {
        public DSHS(string hovsTen, string diaChi, DateTime? ngaySinh, int phai, string sdt)
        {
            this.HovsTen = hovsTen;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.Phai = phai;
            this.Sdt = sdt;

        }

        public DSHS(DataRow row)
        {
            this.HovsTen = row["HovsTen"].ToString();
            this.DiaChi = row["Diachi"].ToString();
            this.NgaySinh = (DateTime?)row["NgaySinh"];
            this.Phai = (int)row["Phai"];
            this.Sdt = row["Sdt"].ToString();

        }
        private string hovsTen;
        private string diaChi;
        private DateTime? ngaySinh;
        private int phai;
        private string sdt;

        
        public string HovsTen { get => hovsTen; set => hovsTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int Phai { get => phai; set => phai = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
