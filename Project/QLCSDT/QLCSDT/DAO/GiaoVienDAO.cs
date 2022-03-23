using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance
        {
            get { if (instance == null) instance = new GiaoVienDAO(); return GiaoVienDAO.instance; }
            private set { GiaoVienDAO.instance = value; }
        }
        private GiaoVienDAO()
        {

        }
        public List<GiaoVien> GetlistGiaoVien()
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = "select * from GiaoVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GiaoVien gv = new GiaoVien(item);
                list.Add(gv);
            }
            return list;
        }
        public bool InsertGiaoVien(string Name, string diachi, DateTime? ngaysinh, int Phai, string std, string Mon)
        {
            string query = string.Format("insert into GiaoVien values (N'{0}',N'{1}','{2}','{3}','{4}',N'{5}')", Name, diachi, ngaysinh, Phai, std, Mon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateGiaoVien(int id, string Name, string diachi, DateTime? ngaysinh, int Phai, string std, string Mon)
        {
            string query = string.Format("update GiaoVien set HovsTen =N'{0}' , Diachi=N'{1}' , NgaySinh='{2}' , phai={3},Sdt='{4}' , Mon='{5}' where id={6}", Name, diachi, ngaysinh, Phai, std, Mon, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteGiaoVien(int id)
        {
            string query = string.Format("delete GiaoVien where id = '{0}' ", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<GiaoVien> GetSearchGiaoVienByName(String name)
        {
            List<GiaoVien> GiaoVienlist = new List<GiaoVien>();

            string Query = string.Format("select * from GiaoVien where [dbo].[non_unicode_convert](HovsTen) like N'%' + [dbo].[non_unicode_convert](N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                GiaoVien gv = new GiaoVien(item);
                GiaoVienlist.Add(gv);
            }

            return GiaoVienlist;
        }
        public GiaoVien GetGiaoVienByID(int id)
        {
            GiaoVien gv = null;

            string Query = ("select * from GiaoVien where id=" + id);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                gv = new GiaoVien(item);
                return gv;
            }
            return gv;
        }
        public GiaoVien GetGiaoVienByName(string name)
        {
            GiaoVien gv = null;

            string Query = ("select * from GiaoVien where HovsTen= N'"+name+"'");

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                gv = new GiaoVien(item);
                return gv;
            }
            return gv;
        }

    }
}
