﻿using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_TaiKhoan
    {
        private static DAO_TaiKhoan instance;
        public static DAO_TaiKhoan Instance
        {
            get
            {
                if (instance == null) 
                    instance = new DAO_TaiKhoan();
                return DAO_TaiKhoan.instance;
            }
            private set { instance = value; }
        }

        private DAO_TaiKhoan() { }

        public List<TaiKhoan_View> GetTaiKhoan()
        {
            List<TaiKhoan_View> accounts = new List<TaiKhoan_View>();

            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                foreach (var item in db.TaiKhoans.ToList())
                {
                    accounts.Add(new TaiKhoan_View()
                    {
                        MaTaiKhoan = item.MaTaiKhoan,
                        TenNhanVien = item.NhanVien.TenNhanVien,
                        Username = item.Username,
                        TrangThai = (item.NhanVien.TrangThai == 1) ? "Quản lý" : "Nhân viên"
                    });
                }
            }

            return accounts;
        }

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    db.TaiKhoans.Add(taiKhoan);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
