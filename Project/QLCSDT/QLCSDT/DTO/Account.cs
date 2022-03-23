using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCSDT.DTO
{
    public class Account
    {
        public Account(string dislayName, string userName, string password, int level)
        {
            this.DislayName = dislayName;
            this.UserName = userName;
            this.Password = password;
            this.Level = level;
        }

        public Account(DataRow row)
        {
            this.DislayName = row["DislayName"].ToString();
            this.UserName = row["UserName"].ToString();
            this.Password = row["Password"].ToString();
            this.Level = (int)row["level"];
        }
        
        private string dislayName;
        private string userName;
        private string password;
        private int level;

        public string DislayName { get => dislayName; set => dislayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Level { get => level; set => level = value; }
    }
}
