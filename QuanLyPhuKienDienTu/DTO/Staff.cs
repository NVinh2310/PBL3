using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DTO
{
    class Staff
    {
        private int id;
        private string username;
        private string password;
        private int status;
        private string name;
        private string address;
        private string phone;

        public Staff(int idAccount, string username, string password, 
            int status, string name, string address, string phone)
        {
            this.ID = idAccount;
            this.Username = username;
            this.Password = password;
            this.Status = status;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public Staff(DataRow row)
        {
            this.ID = (int)row["IDAccount"];
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.Status = (int)row["Status"];
            this.Name = row["Name"].ToString();
            this.Address = row["Address"].ToString();
            this.Phone = row["Phone"].ToString();
        }

        public int ID
        {
            get => id;
            private set => id = value;
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
        public int Status
        {
            get => status;
            set => status = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
    }
}
