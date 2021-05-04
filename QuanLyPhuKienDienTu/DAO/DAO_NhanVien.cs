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

        public List<NhanVien> GetNhanVien()
        {
            List<NhanVien> accounts = new List<NhanVien>();

            accounts.AddRange(new NhanVien[] {
                new NhanVien()
                {
                    MaNhanVien = 1,
                    TenNhanVien = "Bùi Ngọc Thịnh"
                },
                new NhanVien()
                {
                    MaNhanVien = 3,
                    TenNhanVien = "Nguyễn Văn Vĩnh"
                },
                new NhanVien()
                {
                    MaNhanVien = 5,
                    TenNhanVien = "Nguyễn Thị Bích Phượng"
                },
                new NhanVien()
                {
                    MaNhanVien = 7,
                    TenNhanVien = "Captain America"
                },
                new NhanVien()
                {
                    MaNhanVien = 9,
                    TenNhanVien = "Batman"
                }
            });

            return accounts;
        }
    }
}
