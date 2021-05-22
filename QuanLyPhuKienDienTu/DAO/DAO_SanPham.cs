﻿using QuanLyPhuKienDienTu.DTO;
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
        private DAO_SanPham() {}
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
                        SoLuongTonKho = item.SoLuongTonKho,
                        ThoiLuongBaoHanh = item.ThoiLuongBaoHanh
                    });
                }
            }
            return sp;
        }
        // tra ve danh sach tat ca cac san pham theo masp va namesp
        public List<SanPham> GetSanPhamByName(string name)
        {
            List<SanPham> sp = new List<SanPham>();
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                var data = db.SanPhams.Where(p => p.TenSanPham.Contains(name)).ToList();
                foreach (var item in data)
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
                        SoLuongTonKho = item.SoLuongTonKho,
                        ThoiLuongBaoHanh = item.ThoiLuongBaoHanh
                    });
                }
            }
            return sp;
        }
        public List<ThuongHieu> GetThuongHieu()
        {
            List<ThuongHieu> th = new List<ThuongHieu>();
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                var data = (from p in db.ThuongHieux select p).Distinct().ToList();
                foreach (var item in data)
                {
                    th.Add(new ThuongHieu()
                    {
                        MaThuongHieu = item.MaThuongHieu,
                        TenThuongHieu = item.TenThuongHieu,
                        XuatXu = item.XuatXu,
                    });

                }
            }
            return th;
        }
        public List<Loai> GetLoai()
        {
            List<Loai> ls = new List<Loai>();
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                foreach (var item in db.Loais.Distinct().ToList())
                {
                    ls.Add(new Loai()
                    {
                        MaLoai = item.MaLoai,
                        TenLoai = item.TenLoai
                    });
                }
            }
            return ls;

        }
        public bool CheckMaSP(int masp)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    if ((db.SanPhams.Where(p => p.MaSanPham == masp).Count()) == 0)
                    {
                        return true;
                    }
                    else return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool ThemSanPham(SanPham s)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    //Không cần thiết
                    if (!CheckMaSP(s.MaSanPham))
                    {
                        return false;
                    }
                    else
                    {
                        db.SanPhams.Add(s);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }
        public bool SuaSanPham(int masp, SanPham product) 
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    SanPham sp = db.SanPhams.Find(masp);
                    sp.TenSanPham = product.TenSanPham;
                    sp.MaThuongHieu = product.MaThuongHieu;
                    sp.MaLoai = product.MaLoai;
                    sp.MauSac = product.MauSac;
                    sp.MoTa = product.MoTa;
                    sp.GiaBan = product.GiaBan;
                    sp.GiaNhap = product.GiaNhap;
                    sp.SoLuongTonKho = product.SoLuongTonKho;
                    sp.ThoiLuongBaoHanh = product.ThoiLuongBaoHanh;
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
        public List<SanPham_View> GetSanPhamView()
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                var list = (from i in db.SanPhams select new SanPham_View 
                { 
                    MaSanPham =i.MaSanPham,
                    TenSanPham = i.TenSanPham,
                    TenLoai=i.Loai.TenLoai, 
                    TenThuongHieu =i.ThuongHieu.TenThuongHieu,
                    SoLuongTonKho = i.SoLuongTonKho,
                    MauSac =i.MauSac,
                    MoTa =i.MoTa,
                    ThoiLuongBaoHanh=i.ThoiLuongBaoHanh,
                    GiaBan=i.GiaBan
                });
                return list.ToList();
            }
        }
    }
}
