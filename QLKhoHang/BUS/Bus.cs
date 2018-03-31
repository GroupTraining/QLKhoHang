using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Bus
    {
        DataDiagramDataContext data = new DataDiagramDataContext();

        public object get_DsSP()
        {
            var dssp = from sp in data.SanPhams
                       select new
                       {
                           sp.MaSP,sp.TenSP, sp.MaLoaiSP, sp.SoLuong, sp.Gia, sp.GhiChu, sp.Ngay
                       };
            return dssp;
        }
        public object get_DsDT(string loaidoitac)
        {
            var dsdt = from dt in data.DoiTacs
                       where dt.KieuDoiTac == loaidoitac
                       select new
                       {
                           dt.MaDoiTac,
                           dt.TenDoiTac,
                           dt.DiaChi,
                           dt.Email,
                           dt.SoDT,
                           dt.GhiChu
                       };
            return dsdt;
        }
        public object get_DsHD(string loaihoadon)
        {
            var dshd = from x in data.HoaDons
                       from y in data.HoaDonChiTiets
                       where x.MaHD == y .MaHD && x.KieuHoaDon == loaihoadon
                       select new
                       {
                           MaHD = x.MaHD,
                           MaDoiTac = x.MaDoiTac,
                           MaHDChiTiet = y.MaHDChiTiet,
                           Ngay = x.Ngay,
                           MaSP = y.MaSP,
                           SoLuong = y.SoLuong,
                           Gia = y.Gia,
                           MaNV = x.MaNV
                       };
            return dshd;
        }
        //Them đối tác
        public int add_company(string id, string name, string address,string phone,string email, string message, string group )
        {
            int sl = (from count in data.DoiTacs
                      where count.MaDoiTac == id
                      select count).Count();
            if(sl == 0)
            {
                DoiTac new_com = new DoiTac();
                new_com.MaDoiTac = id;
                new_com.TenDoiTac = name;
                new_com.DiaChi = address;
                new_com.SoDT = phone;
                new_com.Email = email;
                new_com.GhiChu = message;
                new_com.KieuDoiTac = group;
                data.DoiTacs.InsertOnSubmit(new_com);
                data.SubmitChanges();
                return 1;
            }else
            return 0;
        }

        //theem sản phẩm 
        public object Add_SanPham(string masp,string tensp,string maloaisp,string soluong,string gia,string ghichu,string ngay)
        {
            SanPham sp = new SanPham();
            sp.MaSP = masp;
            sp.TenSP = tensp;
            sp.MaLoaiSP = maloaisp;
            sp.SoLuong = Convert.ToInt32(soluong);
            sp.Gia = Convert.ToInt32(gia);
            sp.GhiChu = ghichu;
            sp.Ngay = Convert.ToDateTime(ngay);
            data.SanPhams.InsertOnSubmit(sp);
            data.SubmitChanges();
            return 1;
        }
        //lay du lieu loai sp
        public object get_LoaiSP()
        {
            var lsp = from p in data.LoaiSanPhams
                      select new
                      {
                          p.MaLoaiSP,
                          p.TenLoaiSP,
                          p.MoTa
                      };
            return lsp;
        }

        //them loai san pham
        public object Add_LoaiSP(string maloaisp,string tenloaisp,string mota)
        {
            LoaiSanPham lsp = new LoaiSanPham();
            lsp.MaLoaiSP = maloaisp;
            lsp.TenLoaiSP = tenloaisp;
            lsp.MoTa = mota;
            data.LoaiSanPhams.InsertOnSubmit(lsp);
            data.SubmitChanges();
            return 1;
        }

    }
}
