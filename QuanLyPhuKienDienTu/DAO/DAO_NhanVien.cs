using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_NhanVien
    {
        private static DAO_NhanVien instance;
        public static DAO_NhanVien Instance
        {
            get 
            {
                if (instance == null)
                    instance = new DAO_NhanVien();
                return DAO_NhanVien.instance;
            }
            private set { instance = value; }
        }

        private DAO_NhanVien() { }
    }
}
