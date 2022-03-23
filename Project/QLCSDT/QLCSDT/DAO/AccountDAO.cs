using QLCSDT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login( string userName, string passWord)
        {
            string query = " USP_Login @userNam , @passWord ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count >0 ;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] {userName , displayName , pass , newPass});
            return result > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Acconut where UserName = '" + userName + "'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable GetlisAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select DislayName,UserName,level from Acconut");
        }
        public bool InsertAcount(string dislayName, string userName, int level)
        {
            //insert into NhanVien values (N'Hà',N'LX','1985/01/01','0',N'0123456789',N'Giáo viên')
            string query = string.Format("insert into Acconut (DislayName, UserName, level) values (N'{0}',[dbo].[non_unicode_convert](N'{1}'),'{2}')", dislayName, userName, level);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAcount(string dislayName, string userName, int level)
        {
            string query = string.Format("update Acconut set DislayName=N'{0}' , level='{2}' where UserName = '{1}'", dislayName, userName, level);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAcount(string userName)
        {
            //update NhanVien set HovsTen =N'', Diachi=N'', NgaySinh='', phai='',Sdt='',CongViec='' where id='')
            string query = string.Format("delete Acconut where UserName = '{0}' ", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool RestPassword(string userName)
        {
            //update NhanVien set HovsTen =N'', Diachi=N'', NgaySinh='', phai='',Sdt='',CongViec='' where id='')
            string query = string.Format("update Acconut set password = N'0' where UserName = '{0}' ", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool BackupQLCSDT(string t, string a)
        {
            string query = string.Format("backup database [QLCSDT] to disk = '{0}/{1}.bak'",a,t);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return true;
        }
        public bool RESTOREQLCSDT(string a)
        {
            string query = string.Format("USE master alter Database [QLCSDT] set single_user with rollback immediate restore database [QLCSDT]from disk= N'{0}'with replace alter database[QLCSDT] set multi_user", a);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return true;
        }
    }
}
