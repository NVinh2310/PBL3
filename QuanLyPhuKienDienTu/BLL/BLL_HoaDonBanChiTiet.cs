using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_HoaDonBanChiTiet
    {
        private static BLL_HoaDonBanChiTiet instance;
        public static BLL_HoaDonBanChiTiet Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_HoaDonBanChiTiet();
                return BLL_HoaDonBanChiTiet.instance;
            }
            private set { instance = value; }
        }
    }
}
