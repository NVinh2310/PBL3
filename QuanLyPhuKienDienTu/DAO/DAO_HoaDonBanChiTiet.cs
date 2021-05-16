using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_HoaDonBanChiTiet
    {
        private static DAO_HoaDonBanChiTiet instance;
        public static DAO_HoaDonBanChiTiet Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_HoaDonBanChiTiet();
                return DAO_HoaDonBanChiTiet.instance;
            }
            private set { instance = value; }
        }
        public void AddHoaDonBanChiTiet(int MHD, int MSP, int SL, string GC)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                ChiTietHoaDonBan i = new ChiTietHoaDonBan()
                {
                    MaHoaDonBan = MHD,
                    MaSanPham = MSP,
                    SoLuongBan = SL,
                    GhiChu = GC
                };
                db.ChiTietHoaDonBans.Add(i);
                db.SaveChanges();
            }
        }
        //public void UpdateSLgHoaDonBan(int MHD, int MSP, int SL)
    }
}
