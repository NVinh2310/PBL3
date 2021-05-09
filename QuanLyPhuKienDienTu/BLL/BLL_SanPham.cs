using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhuKienDienTu.DAO;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_SanPham
    {
        private static BLL_SanPham instance;
        public static BLL_SanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_SanPham();
                return BLL_SanPham.instance;
            }
            private set { instance = value; }
        }

        private BLL_SanPham() { }

        public List<SanPham> GetKhachHang()
        {
            return BLL_SanPham.Instance.GetKhachHang();
        }
    }
}
