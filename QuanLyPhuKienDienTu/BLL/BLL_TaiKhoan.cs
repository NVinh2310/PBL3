using QuanLyPhuKienDienTu.DAO;
using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan instance;
        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_TaiKhoan();
                return BLL_TaiKhoan.instance;
            }
            private set { instance = value; }
        }

        public List<TaiKhoan_View> GetTaiKhoan()
        {
            return DAO_TaiKhoan.Instance.GetTaiKhoan();
        }

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            return DAO_TaiKhoan.Instance.ThemTaiKhoan(taiKhoan);
        }
    }
}
