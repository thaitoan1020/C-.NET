using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    public class BanLuongGVDAO
    {
        private static BanLuongGVDAO instance;

        public static BanLuongGVDAO Instance
        {
            get { if (instance == null) instance = new BanLuongGVDAO(); return BanLuongGVDAO.instance; }
            private set { BanLuongGVDAO.instance = value; }
        }
        private BanLuongGVDAO()
        {

        }
        public List<BanLuongGV> GetlistBanLuongGV()
        {
            List<BanLuongGV> list = new List<BanLuongGV>();
            string query = "select * from BanLuongGV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BanLuongGV blgv = new BanLuongGV(item);
                list.Add(blgv);
            }
            return list;
        }
        public bool InsertBanLuongGV(int msgv, DateTime? ngay, double sotien)
        {
            string query = string.Format("insert into BanLuongGV values (N'{0}',N'{1}','{2}')", msgv, ngay, sotien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateBanLuongGV(int id, int msgv, DateTime? ngay, double sotien)
        {
            string query = string.Format("update BanLuongGV set MSGV =N'{0}' , Ngay=N'{1}' , SoTien='{2}'where id={3}", msgv, ngay, sotien, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBanLuongGV(int id)
        {
            string query = string.Format("delete BanLuongGV where id = '{0}' ", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<BanLuongGV> GetSearchBanLuongGVByName(string name)
        {
            List<BanLuongGV> list = new List<BanLuongGV>();

            string Query = string.Format("select bl.id,bl.MSGV,bl.Ngay,bl.SoTien from GiaoVien nv,BanLuongGV bl where nv.id=bl.MSGV and [dbo].[non_unicode_convert](nv.HovsTen) like N'%'+[dbo].[non_unicode_convert]('{0}')+'%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                BanLuongGV BL = new BanLuongGV(item);
                list.Add(BL);
            }

            return list;
        }
    }
}
