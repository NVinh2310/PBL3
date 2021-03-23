﻿using QuanLyPhuKienDienTu.DTO;
using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { 
                if (instance == null) instance = new StaffDAO();
                return StaffDAO.instance;
            }
            private set { instance = value; }
        }

        private StaffDAO() { }

        public List<Staff> GetStaffs()
        {
            List<Staff> staffs = new List<Staff>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Staff");

            foreach(DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                staffs.Add(staff);
            }

            return staffs;
        }

        public int Login(string username, string password)
        {
            int ERROR = -100;
            int result = ERROR;

            var status = from staff in StaffDAO.Instance.GetStaffs()
                      where staff.Username == username && staff.Password == password
                      select staff.Status;

            foreach (int item in status)
            {
                result = item;
            }

            return result;
        }

        public int GetID(string username, string password)
        {
            int ERROR = -100;
            int result = ERROR;

            var ids = from staff in StaffDAO.Instance.GetStaffs()
                      where staff.Username == username && staff.Password == password
                      select staff.ID;

            foreach (int id in ids)
            {
                result = id;
            }

            return result;
        }

        public bool ModifyPassword(int id, string newPassword)
        {
            int ERROR = -100;
            int result = ERROR;

            string query = string.Format("EXEC USP_ModifyPassword @IDAccount = '{0}', @Password = '{1}'",
                                                                            id, newPassword);
            result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
