using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class BanLuongGV
    {
        public BanLuongGV(int id, int msgv, DateTime? ngay, double sotien)
        {
            this.ID = id;
            this.MSGV = msgv;
            this.Ngay = ngay;
            this.SoTien = sotien;
        }
        public BanLuongGV(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MSGV = (int)row["MSGV"];
            this.Ngay = (DateTime?)row["Ngay"];
            this.SoTien = Convert.ToDouble(row["SoTien"]);
        }

        private int iD;
        private int mSGV;
        private DateTime? ngay;
        private double soTien;

        public int ID { get => iD; set => iD = value; }
        public int MSGV { get => mSGV; set => mSGV = value; }
        public DateTime? Ngay { get => ngay; set => ngay = value; }
        public double SoTien { get => soTien; set => soTien = value; }
    }
}
