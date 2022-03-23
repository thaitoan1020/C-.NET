using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
     public class Phong
    {
        public Phong(int id, string name, int magv, int manv, DateTime? giohoc, DateTime? giokt, string status)
        {
            this.ID = id;
            this.TenPhong = name;
            this.MSGV = magv;
            this.MSNV = manv;
            this.GioHoc = giohoc;
            this.GioKT = gioKT;
            this.Status = status;
        }
        public Phong(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenPhong = row["TenPhong"].ToString();
            this.MSGV = (int)row["MSGV"];
            this.MSNV = (int)row["MSNV"];
            this.GioHoc = (DateTime?)row["GioHoc"];
            this.GioKT = (DateTime?)row["GioKT"];
            this.Status = row["Status"].ToString();
        }

        private int iD;
        private string tenPhong;
        private int mSGV;
        private int mSNV;
        private DateTime? gioHoc;
        private DateTime? gioKT;
        private string status;

        public int ID { get => iD; set => iD = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public int MSGV { get => mSGV; set => mSGV = value; }
        public int MSNV { get => mSNV; set => mSNV = value; }
        public string Status { get => status; set => status = value; }
        public DateTime? GioHoc { get => gioHoc; set => gioHoc = value; }
        public DateTime? GioKT { get => gioKT; set => gioKT = value; }
    }
}
