using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class BanLuongNV
    {
        public BanLuongNV(int id, int msnv, DateTime? ngay, double sotien)
        {
            this.ID = id;
            this.MSNV = msnv;
            this.Ngay = ngay;
            this.SoTien = sotien;
        }
        public BanLuongNV(DataRow row)
        {
            this.ID = (int)row["id"]; 
            this.MSNV = (int)row["MSNV"];
            this.Ngay = (DateTime?)row["Ngay"];
            this.SoTien = Convert.ToDouble (row["SoTien"]); 
        }
        
        private int iD;
        private int mSNV;
        private DateTime? ngay;
        private double soTien;

        public int ID { get => iD; set => iD = value; }
        public int MSNV { get => mSNV; set => mSNV = value; }
        public DateTime? Ngay { get => ngay; set => ngay = value; }
        public double SoTien { get => soTien; set => soTien = value; }
    }
}
