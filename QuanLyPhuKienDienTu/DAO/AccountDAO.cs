using QuanLyPhuKienDienTu.DTO;
using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account");

            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                accounts.Add(account);
            }

            return accounts;
        }

        public int Login(string username, string password)
        {
            int ERROR = -100;
            int result = ERROR;

            string query = string.Format("EXEC USP_GetStatus " +
                                          "@Username = '{0}', " +
                                          "@Password = '{1}'", username, password);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {

                result = (int)DataProvider.Instance.ExecuteScalar(query);
            }
            return result;
        }
    }
}
