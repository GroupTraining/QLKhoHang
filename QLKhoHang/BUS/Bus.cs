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
        //thêm hóa đơn
        public int Add_HoaDon(string mahd,string madt,DateTime ngaylap,string manv)
        {
            int sl_dt = (from count in data.DoiTacs
                      where count.MaDoiTac == madt
                      select count).Count();
            int sl_hd = (from count in data.HoaDons
                      where count.MaHD == mahd
                      select count).Count();
            int sl_nv = (from count in data.NhanViens
                      where count.MaNV == manv
                      select count).Count();
            var doitac = data.DoiTacs.Single(p => p.MaDoiTac == madt);
            if (sl_dt >0 && sl_hd ==0 && sl_nv >0)
            {
                HoaDon hd = new HoaDon();
                hd.MaHD = mahd;
                hd.MaDoiTac = madt;
                hd.Ngay = ngaylap;
                hd.MaNV = manv;
                if(doitac.KieuDoiTac == "Khách hàng")
                {
                    hd.KieuHoaDon = "Xuất ra";
                }else
                {
                    hd.KieuHoaDon = "Nhập vào";
                }
                data.HoaDons.InsertOnSubmit(hd);
                data.SubmitChanges();
                return 1;
            }
            else
            {
                return 0;
            }       
        }
        //Thêm mới hóa đơn chi tiết
        public int Add_HDCT(string mahdct, string mahd, string masp, int sl, int gia)
        {
            int sl_hd = (from count in data.HoaDons
                         where count.MaHD == mahd
                         select count).Count();
            int sl_hdct = (from count in data.HoaDonChiTiets
                           where count.MaHDChiTiet == mahdct
                           select count).Count();
            var sp = data.SanPhams.Single(p => p.MaSP == masp);
            if (sl_hd > 0 && sl_hdct == 0 && sp != null)
            {
                HoaDonChiTiet hdct = new HoaDonChiTiet();
                hdct.MaHDChiTiet = mahdct;
                hdct.MaHD = mahd;
                hdct.MaSP = masp;
                hdct.SoLuong = sl;
                hdct.Gia = gia;
                data.HoaDonChiTiets.InsertOnSubmit(hdct);
                data.SubmitChanges();
                return 1;
            }
            else
                return 0;
        }

        //lay du lieu loai san pham
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
            return 1;
        }

        //tim kiem san pham
        public object get_sanpham(string giatri)
        {
            var sp = from a in data.SanPhams
                     from b in data.LoaiSanPhams
                     where a.MaLoaiSP == b.MaLoaiSP
                     select new
                     {
                         MaSP = a.MaSP,
                         TenSP = a.TenSP,
                         MaLoaiSP = a.MaLoaiSP,
                         SoLuong = a.SoLuong,
                         Gia = a.Gia,
                         GhiChu = a.GhiChu,
                         Ngay = a.Ngay,

                     } into timkiemsanpham
                     where timkiemsanpham.MaSP.Contains(giatri)
                     || timkiemsanpham.TenSP.Contains(giatri)
                     || timkiemsanpham.MaLoaiSP.Contains(giatri)
                    
                     select timkiemsanpham;
            return sp;

        }
        //tim kiem doi tac
        public object get_doitac(string giatri)
        {
            var cc = from a in data.DoiTacs
                     from b in data.HoaDons
                     where a.MaDoiTac == b.MaDoiTac
                     select new
                     {
                         MaDoiTac = a.MaDoiTac,
                         TenDoiTac = a.TenDoiTac,
                         DiaChi = a.DiaChi,
                         SDT = a.SoDT,
                         Email = a.Email,
                         GhiChu = a.GhiChu,
                     } into timkiemdoitac
                     where timkiemdoitac.MaDoiTac.Contains(giatri)
                     || timkiemdoitac.TenDoiTac.Contains(giatri)
                     || timkiemdoitac.DiaChi.Contains(giatri)
                     || timkiemdoitac.SDT.Contains(giatri)
                     || timkiemdoitac.Email.Contains(giatri)
                     || timkiemdoitac.GhiChu.Contains(giatri)
                     select timkiemdoitac;
            return cc;

        }
        //tim kiem hoa don
        public object get_hoadon(string giatri)
        {
            var hd = from a in data.HoaDons
                     from b in data.HoaDonChiTiets
                     where a.MaHD == b.MaHD
                     select new
                     {
                         MaHD = a.MaHD,
                         MaDoiTac = a.MaDoiTac,
                         MaHDChiTiet = b.MaHDChiTiet,
                         Ngay = a.Ngay,
                         MaSP = b.MaSP,
                         SoLuong = b.SoLuong,
                         Gia = b.Gia,
                         MaNV = a.MaNV,
                     } into timkiemhoadon
                     where timkiemhoadon.MaHD.Contains(giatri)
                     || timkiemhoadon.MaDoiTac.Contains(giatri)
                     || timkiemhoadon.MaHDChiTiet.Contains(giatri)
                     || timkiemhoadon.MaSP.Contains(giatri)
                     || timkiemhoadon.MaNV.Contains(giatri)
                     select timkiemhoadon;
            return hd;
        }
    }
}
