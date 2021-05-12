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

        public List<SanPham> GetSanPham()
        {
            return DAO_SanPham.Instance.GetSanPham();
        }
        public List<SanPham> GetListSP(int masp, string namesp)
        {
            return DAO_SanPham.Instance.GetListSP(masp, namesp);
        }
        public List<SanPham> GetSanPhamByName(string name)
        {
            return DAO_SanPham.Instance.GetSanPhamByName(name);
        }
        public List<ThuongHieu> GetThuongHieu()
        {
            return DAO_SanPham.Instance.GetThuongHieu();
        }
        public List<Loai> GetLoai()
        {
            return DAO_SanPham.Instance.GetLoai();
        }
        public bool ThemSanPham(SanPham s)
        {
            return DAO_SanPham.Instance.ThemSanPham(s);
        }
        public bool SuaSanPham(int masp, SanPham product)
        {
            return DAO_SanPham.Instance.SuaSanPham(masp, product);
        }
        public bool XoaSanPham(int masp)
        {
            return DAO_SanPham.Instance.XoaSanPham(masp);
        }
    }
}
