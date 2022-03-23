using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    public class BanLuongNVDAO
    {
        private static BanLuongNVDAO instance;

        public static BanLuongNVDAO Instance
        {
            get { if (instance == null) instance = new BanLuongNVDAO(); return BanLuongNVDAO.instance; }
            private set { BanLuongNVDAO.instance = value; }
        }
        private BanLuongNVDAO()
        {

        }
        public List<BanLuongNV> GetlistBanLuongNV()
        {
            List<BanLuongNV> list = new List<BanLuongNV>();
            string query = "select * from BanLuongNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BanLuongNV blnv = new BanLuongNV(item);
                list.Add(blnv);
            }
            return list;
        }
        public bool InsertBanLuongNV(int msnv, DateTime? ngay, double sotien)
        {
            string query = string.Format("insert into BanLuongNV values (N'{0}',N'{1}','{2}')", msnv, ngay, sotien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateBanLuongNV(int id,int msnv, DateTime? ngay,double sotien)
        {
            string query = string.Format("update BanLuongNV set MSNV =N'{0}' , Ngay=N'{1}' , SoTien='{2}'where id={3}", msnv, ngay, sotien,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBanLuongNV(int id)
        {
            string query = string.Format("delete BanLuongNV where id = '{0}' ", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<BanLuongNV> GetSearchBanLuongNVByName(string name)
        {
            List<BanLuongNV> list = new List<BanLuongNV>();

            string Query = string.Format("select bl.id,bl.MSNV,bl.Ngay,bl.SoTien from NhanVien nv,BanLuongNV bl where nv.id=bl.MSNV and [dbo].[non_unicode_convert](nv.HovsTen) like N'%'+[dbo].[non_unicode_convert]('{0}')+'%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                BanLuongNV BL = new BanLuongNV(item);
                list.Add(BL);
            }

            return list;
        }
    }
}
