﻿using QuanLyPhuKienDienTu.DAO;
using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_ThongTinBan
    {
        private static BLL_ThongTinBan instance;
        public static BLL_ThongTinBan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_ThongTinBan();
                return BLL_ThongTinBan.instance;
            }
            private set { instance = value; }
        }

        private BLL_ThongTinBan() { }

        public List<ThongTinBan> HoaDonBan()
        {
            return DAO_ThongTinBan.Instance.HoaDonBan();
        }
    }
}