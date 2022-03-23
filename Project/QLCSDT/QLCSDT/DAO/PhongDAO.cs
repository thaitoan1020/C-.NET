using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set { PhongDAO.instance = value; }
        }
        private PhongDAO() { }

        public static int PhongWidth = 90;
        public static int PhongHeight = 90;

        public List<Phong> LoadPhongList()
        {
            List<Phong> phonglist = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetPhongList");

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                phonglist.Add(phong);
            }

            return phonglist;
        }
        public bool UpdatePhong(int id, string Name, int msgv, int msnv, DateTime? giohoc, DateTime? giokt, string trangthai)
        {
            //update NhanVien set HovsTen =N'', Diachi=N'', NgaySinh='', phai='',Sdt='',CongViec='' where id='')
            string query = string.Format("update PhongHoc set TenPhong =N'{0}' , MSGV={1} , MSNV={2} , GioHoc='{3}', GioKT='{4}' , Status=N'{5}' where id={6}", Name, msgv, msnv, giohoc, giokt, trangthai, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<Phong> GetSearchPhongByName(String name)
        {
            List<Phong> Phonglist = new List<Phong>();

            string Query = string.Format("select * from PhongHoc where [dbo].[non_unicode_convert](TenPhong) like N'%' + [dbo].[non_unicode_convert](N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                Phonglist.Add(p);
            }

            return Phonglist;
        }
    }
}
