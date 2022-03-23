using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    public class HocPhiDAO
    {
        private static HocPhiDAO instance;

        public static HocPhiDAO Instance
        {
            get { if (instance == null) instance = new HocPhiDAO(); return HocPhiDAO.instance; }
            private set { HocPhiDAO.instance = value; }
        }
        private HocPhiDAO()
        {

        }
        public List<HocPhi> GetlistHocPhi()
        {
            List<HocPhi> list = new List<HocPhi>();
            string query = "select * from HocPhi";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HocPhi hs = new HocPhi(item);
                list.Add(hs);
            }
            return list;
        }
        public bool InsertHocPhi(int mshs, DateTime? ngay, double sotien)
        {
            string query = string.Format("insert into HocPhi values (N'{0}',N'{1}','{2}')", mshs, ngay, sotien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateHocPhi(int id, int mshs, DateTime? ngay, double sotien)
        {
            string query = string.Format("update HocPhi set MSHS =N'{0}' , Ngay=N'{1}' , SoTien='{2}'where id={3}", mshs, ngay, sotien, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHocPhi(int id)
        {
            string query = string.Format("delete HocPhi where id = '{0}' ", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<HocPhi> GetSearchHocPhiByName(string name)
        {
            List<HocPhi> list = new List<HocPhi>();

            string Query = string.Format("select bl.id,bl.MSHS,bl.Ngay,bl.SoTien from HocSinh nv,HocPhi bl where nv.id=bl.MSHS and [dbo].[non_unicode_convert](nv.HovsTen) like N'%'+[dbo].[non_unicode_convert]('{0}')+'%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                HocPhi BL = new HocPhi(item);
                list.Add(BL);
            }

            return list;
        }
    }
}
