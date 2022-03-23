using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class InfoPhong
    {
        public InfoPhong(string hovsTen,string mon,string hovsTenNV ,int sOHS, DateTime? giohoc, DateTime? giokt)
        {
            this.HovsTen = hovsTen;
            this.Mon = mon;
            this.HovsTenNV = hovsTenNV;
            this.SOHS = sOHS;
            this.GioHoc = giohoc;
            this.GioKT = gioKT;
        }

        public InfoPhong(DataRow row)
        {
            this.HovsTen = row["Tgv"].ToString();
            this.Mon= row["Mon"].ToString();
            this.HovsTenNV = row["Tnv"].ToString();
            this.SOHS = (int)row["SOHS"];
            this.GioHoc = (DateTime?)row["GioHoc"];
            this.GioKT = (DateTime?)row["GioKT"];
        }

        private string hovsTen;
        private string mon;
        private string hovsTenNV;
        private int sOHS;
        private DateTime? gioHoc;
        private DateTime? gioKT;

        public string HovsTen { get => hovsTen; set => hovsTen = value; }
        public int SOHS { get => sOHS; set => sOHS = value; }
        public DateTime? GioHoc { get => gioHoc; set => gioHoc = value; }
        public DateTime? GioKT { get => gioKT; set => gioKT = value; }
        public string HovsTenNV { get => hovsTenNV; set => hovsTenNV = value; }
        public string Mon { get => mon; set => mon = value; }
    }
}
