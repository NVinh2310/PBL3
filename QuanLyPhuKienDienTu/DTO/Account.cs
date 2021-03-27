using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DTO
{
    class Account
    {
        private int id;
        private int idStaff;
        private string username;
        private string password;

        public Account(int id, int idStaff, string username, string password)
        {
            this.ID = id;
            this.IDStaff = idStaff;
            this.Username = username;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.ID = (int)row["IDAccount"];
            this.IDStaff = (int)row["IDStaff"];
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
        }

        public int ID
        {
            get => id;
            set => id = value;
        }
        public int IDStaff
        {
            get => idStaff;
            set => idStaff = value;
        }
        public string Username
        {
            get => username;
            set => username = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }
    }
}
