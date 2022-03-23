using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class HocPhi
    {
        public HocPhi(int iD,int mSHS, DateTime? ngay, double soTien)
        {
            this.ID = iD;
            this.MSHS = mSHS;
            this.Ngay = ngay;
            this.SoTien = soTien;
        }
        public HocPhi (DataRow row)
        {
            this.ID = (int)row["id"];
            this.MSHS = (int)row["MSHS"];
            this.Ngay = (DateTime?)row["Ngay"];
            this.SoTien = Convert.ToDouble (row["SoTien"]);
        }


        private int iD;
        private int mSHS;
        private DateTime? ngay;
        private double soTien;

        public int ID { get => iD; set => iD = value; }
        public int MSHS { get => mSHS; set => mSHS = value; }
        public DateTime? Ngay { get => ngay; set => ngay = value; }
        public double SoTien { get => soTien; set => soTien = value; }
    }
}
