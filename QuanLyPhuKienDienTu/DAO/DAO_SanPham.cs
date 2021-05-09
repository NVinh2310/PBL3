using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_SanPham
    {
        private static DAO_SanPham instance;
        public static DAO_SanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_SanPham();
                return DAO_SanPham.instance;
            }
            private set { instance = value; }
        }
        private DAO_SanPham()
        { }
        public List<SanPham> GetSanPham()
        {
            List<SanPham> sp = new List<SanPham>();
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                foreach (var item in db.SanPhams.ToList())
                {
                    sp.Add(new SanPham()
                    {
                        MaSanPham = item.MaSanPham,
                        MaThuongHieu = item.MaThuongHieu,
                        MaLoai = item.MaLoai,
                        TenSanPham = item.TenSanPham,
                        MauSac = item.MauSac,
                        MoTa = item.MoTa,
                        GiaBan = item.GiaBan,
                        GiaNhap = item.GiaNhap,
                        ThoiLuongBaoHanh = item.ThoiLuongBaoHanh,
                        SoLuongTonKho = item.SoLuongTonKho
                    });

                }
            }
            return sp;
        }
        public List<SanPham> GetListSP(int masp, string tensp)
        {
            QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities();
            List<SanPham> data = new List<SanPham>();
            if(masp == 0)
            {
                var list = db.SanPhams.Where(p => p.TenSanPham.Contains(tensp)).Select(p => p);
                data = list.ToList();
            }    
            else
            {
                var list = db.SanPhams.Where(p => p.MaSanPham == masp && p.TenSanPham.Contains(tensp)).Select(p => p);
                data = list.ToList();
            }
            return data;
        }
        public bool ThemSanPham(SanPham sp)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    db.SanPhams.Add(sp);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }
        public bool SuaSanPham(int masp)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    SanPham sp = db.SanPhams.Find(masp);
                    sp.MaSanPham = masp;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }
        public bool XoaSanPham(int masp)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    SanPham sp = db.SanPhams.Find(masp);
                    db.SanPhams.Remove(sp);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
