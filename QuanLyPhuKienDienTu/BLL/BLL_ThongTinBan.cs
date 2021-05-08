using QuanLyPhuKienDienTu.DAO;
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

        public List<ThongTinBan> TimTheoNgay(DateTime datetime)
        {
            List<ThongTinBan> result = new List<ThongTinBan>();
            string formatDate = datetime.ToString("dd-MM-yyyy");

            foreach (ThongTinBan item in HoaDonBan())
            {
                if ((item.NgayBan.DayOfYear == datetime.DayOfYear) && 
                    (item.NgayBan.Year == datetime.Year))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<ThongTinBan> TimTheoThang(DateTime dateTime)
        {
            List<ThongTinBan> result = new List<ThongTinBan>();

            foreach(ThongTinBan item in HoaDonBan())
            {
                if (item.NgayBan.Month == dateTime.Month && 
                    (item.NgayBan.Year == dateTime.Year))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public List<ThongTinBan> TimTheoNam(DateTime dateTime)
        {
            List<ThongTinBan> result = new List<ThongTinBan>();

            foreach (ThongTinBan item in HoaDonBan())
            {
                if (item.NgayBan.Year == dateTime.Year)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public List<ThongTinBan> TimTheoTen(string name)
        {
            List<ThongTinBan> result = new List<ThongTinBan>();

            foreach(ThongTinBan item in HoaDonBan())
            {
                if (item.TenKhachHang.Contains(name))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
