using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    public class HocSinhDAO
    {
        private static HocSinhDAO instance;

        public static HocSinhDAO Instance
        {
            get { if (instance == null) instance = new HocSinhDAO(); return HocSinhDAO.instance; }
            private set { HocSinhDAO.instance = value; }
        }
        private HocSinhDAO()
        {
        }
        public List<HocSinh> GetlisHocSinh()
        {
            List<HocSinh> list = new List<HocSinh>();
            string query = "select * from HocSinh";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HocSinh hv = new HocSinh(item);
                list.Add(hv);
            }
            return list;
        }
        public bool InsertHocSinh(string Name, string diachi, DateTime? ngaysinh, int Phai, string std, int monToan, int monLy, int monHoa, int monAnh, int monVan, int soMon, int idPhong)
        {
            //insert into NhanVien values (N'Hà',N'LX','1985/01/01','0',N'0123456789',N'Giáo viên')
            string query = string.Format("insert into HocSinh values (N'{0}',N'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", Name, diachi, ngaysinh, Phai, std, monToan,monLy,monHoa,monAnh,monVan,soMon,idPhong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateHocSinh(int id, string Name, string diachi, DateTime? ngaysinh, int Phai, string std, int monToan, int monLy, int monHoa, int monAnh, int monVan, int soMon, int idPhong)
        {
            //update NhanVien set HovsTen =N'', Diachi=N'', NgaySinh='', phai='',Sdt='',CongViec='' where id='')
            string query = string.Format("update HocSinh set HovsTen =N'{0}' , Diachi=N'{1}' , NgaySinh='{2}' , Phai={3} , Sdt='{4}' , MonToan ='{5}' , MonLy ='{6}' , MonHoa ='{7}' , MonAnh ='{8}' , MonVan = '{9}' , SoMon ={10} , idPhong ='{11}'  where id = {12}", Name, diachi, ngaysinh, Phai, std, monToan,monLy,monHoa,monAnh,monVan,soMon,idPhong, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHocSinh(int id)
        {
            //update NhanVien set HovsTen =N'', Diachi=N'', NgaySinh='', phai='',Sdt='',CongViec='' where id='')
            string query = string.Format("delete HocSinh where id = '{0}' ", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<HocSinh> GetSearchHocSinhByName(String name)
        {
            List<HocSinh> list = new List<HocSinh>();

            string Query = string.Format("select * from HocSinh where [dbo].[non_unicode_convert](HovsTen) like N'%' + [dbo].[non_unicode_convert](N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                HocSinh hv = new HocSinh(item);
                list.Add(hv);
            }

            return list;
        }
        public HocSinh GetHocSinhByID(int id)
        {
            HocSinh hs = null;

            string Query = ("select * from HocSinh where id=" + id);

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                hs = new HocSinh(item);
                return hs;
            }
            return hs;
        }
        public HocSinh GetHocSinhnByName(string name)
        {
            HocSinh hs = null;

            string Query = ("select * from HocSinh where HovsTen= N'" + name + "'");

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                hs = new HocSinh(item);
                return hs;
            }
            return hs;
        }
    }
}
