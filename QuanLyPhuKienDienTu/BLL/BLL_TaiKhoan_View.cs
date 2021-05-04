using QuanLyPhuKienDienTu.DAO;
using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_TaiKhoan_View
    {
        private static BLL_TaiKhoan_View instance;
        public static BLL_TaiKhoan_View Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_TaiKhoan_View();
                return BLL_TaiKhoan_View.instance;
            }
            private set { instance = value; }
        }

        public List<TaiKhoan_View> GetTaiKhoan()
        {
            return DAO_TaiKhoan_View.Instance.GetTaiKhoan();
        }
    }
}
