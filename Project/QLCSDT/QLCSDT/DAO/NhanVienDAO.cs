using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }
        private NhanVienDAO()
        {

        }
        public List<NhanVien> GetlistNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "select * from NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }
        public bool InsertNhanVien(string Name, string diachi, DateTime? ngaysinh, int Phai, string std, string CongViec)
        {
            //insert into NhanVien values (N'Hà',N'LX','1985/01/01','0',N'0123456789',N'Giáo viên')
            string query = string.Format("insert into NhanVien values (N'{0}',N'{1}','{2}','{3}','{4}',N'{5}')",Name,diachi,ngaysinh,Phai,std,CongViec);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result >0;
        }
        public bool UpdateNhanVien(int id, string Name, string diachi, DateTime? ngaysinh, int Phai, string std, string CongViec)
        {
            //update NhanVien set HovsTen =N'', Diachi=N'', NgaySinh='', phai='',Sdt='',CongViec='' where id='')
            string query = string.Format("update NhanVien set HovsTen =N'{0}' , Diachi=N'{1}' , NgaySinh='{2}' , phai={3},Sdt='{4}' , CongViec='{5}' where id={6}", Name, diachi, ngaysinh, Phai, std, CongViec,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteNhanVien(int id)
        {
            //update NhanVien set HovsTen =N'', Diachi=N'', NgaySinh='', phai='',Sdt='',CongViec='' where id='')
            string query = string.Format("delete NhanVien where id = '{0}' ", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<NhanVien> GetSearchNhanVienByName(String name)
        {
            List<NhanVien> NhanVienlist = new List<NhanVien>();

            string Query = string.Format("select * from NhanVien where [dbo].[non_unicode_convert](HovsTen) like N'%' + [dbo].[non_unicode_convert](N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                NhanVienlist.Add(nv);
            }

            return NhanVienlist;
        }
        public NhanVien GetNhanVienByID(int id)
        {
            NhanVien nv = null;

            string Query = ("select * from NhanVien where id=" + id);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                nv = new NhanVien(item);
                return nv;
            }
            return nv;
        }
        public NhanVien GetNhanVienByName(string name)
        {
            NhanVien nv = null;

            string Query = ("select * from NhanVien where HovsTen= N'" + name+"'");

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                nv = new NhanVien(item);
                return nv;
            }
            return nv;
        }
    }
}
