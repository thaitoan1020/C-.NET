using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class HocSinh
    {
        public HocSinh (int id, string hovsTen, string diaChi, DateTime? ngaySinh, int phai, string sdt ,int monToan, int monLy, int monHoa, int monAnh, int monVan,int soMon, int idPhong)
        {
            this.Id = id;
            this.HovsTen = hovsTen;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.Phai = phai;
            this.Sdt = sdt;
            this.MonToan = monToan;
            this.MonLy = monLy;
            this.MonHoa = monHoa;
            this.MonAnh = monAnh;
            this.MonVan = monVan;
            this.SoMon = soMon;
            this.IdPhong = idPhong;

        }

        public HocSinh(DataRow row)
        {
            this.Id = (int)row["id"];
            this.HovsTen = row["HovsTen"].ToString();
            this.DiaChi = row["Diachi"].ToString();
            this.NgaySinh = (DateTime?)row["NgaySinh"];
            this.Phai = (int)row["Phai"];
            this.Sdt = row["Sdt"].ToString();
            this.MonToan = (int)row["MonToan"];
            this.MonLy = (int)row["MonLy"];
            this.MonHoa = (int)row["MonHoa"];
            this.MonAnh = (int)row["MonAnh"];
            this.MonVan = (int)row["MonVan"];
            this.SoMon = (int)row["SoMon"];
            this.IdPhong = (int)row["idPhong"];

        }

        private int id;
        private string hovsTen;
        private string diaChi;
        private DateTime? ngaySinh;
        private int phai;
        private string sdt;
        private int monToan;
        private int monLy;
        private int monHoa;
        private int monAnh;
        private int monVan;
        private int soMon;
        private int idPhong;


        public int Id { get => id; set => id = value; }
        public string HovsTen { get => hovsTen; set => hovsTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int Phai { get => phai; set => phai = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int MonToan { get => monToan; set => monToan = value; }
        public int MonLy { get => monLy; set => monLy = value; }
        public int MonHoa { get => monHoa; set => monHoa = value; }
        public int MonAnh { get => monAnh; set => monAnh = value; }
        public int MonVan { get => monVan; set => monVan = value; }
        public int IdPhong { get => idPhong; set => idPhong = value; }
        public int SoMon { get => soMon; set => soMon = value; }
    }
}
