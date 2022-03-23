using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    public class InfoPhongDAO
    {
        private static InfoPhongDAO instance;

        public static InfoPhongDAO Instance
        {
            get { if (instance == null) instance = new InfoPhongDAO(); return InfoPhongDAO.instance; }
            private set { InfoPhongDAO.instance = value; }
        }
        private InfoPhongDAO() { }

        public List<InfoPhong> LoadinfoPhongList(int id)
        {
            List<InfoPhong> infophonglist = new List<InfoPhong>();

            string Query = "USP_GetfromChinh "+id;

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                InfoPhong infoPhong = new InfoPhong(item);
                infophonglist.Add(infoPhong);
            }

            return infophonglist;
        }
        public List<DSHS> LoadDSHS(int id)
        {
            List<DSHS> dshs = new List<DSHS>();

            string Query = "select hs.HovsTen,hs.Diachi,hs.Phai,hs.Sdt,hs.NgaySinh from HocSinh hs, PhongHoc ph where hs.idPhong = ph.id and ph.id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                DSHS Ds = new DSHS(item);
                dshs.Add(Ds);
            }

            return dshs;
        }
    }
}
