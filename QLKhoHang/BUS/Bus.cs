using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Globalization;

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
                           sp.MaSP,
                           sp.TenSP,
                           sp.MaLoaiSP,
                           sp.Ngay,
                           sp.SoLuong,
                           sp.Gia,
                           sp.GhiChu
                       };
            return dssp;
        }
        public object get_DsSP(string giatri)
        {
            var dssp = from sp in data.SanPhams
                       select new
                       {
                           sp.MaSP,
                           sp.TenSP,
                           sp.MaLoaiSP,
                           sp.Ngay,
                           sp.SoLuong,
                           sp.Gia,
                           sp.GhiChu
                       } into t
                       where t.MaSP.Contains(giatri)
                || t.TenSP.Contains(giatri)
                || t.MaLoaiSP.Contains(giatri)
                || t.Ngay.ToString().Contains(giatri)
                || t.SoLuong.ToString().Contains(giatri)
                || t.Gia.ToString().Contains(giatri)
                || t.GhiChu.Contains(giatri)
                       select t;

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
        public object get_DsDT(string loaidoitac, string giatri)
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
                       } into t
                       where t.MaDoiTac.Contains(giatri)
                       || t.TenDoiTac.Contains(giatri)
                       || t.DiaChi.Contains(giatri)
                       || t.Email.Contains(giatri)
                       || t.SoDT.Contains(giatri)
                       || t.GhiChu.Contains(giatri)

                       select t;

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
        public object get_DsHD(string loaihoadon,string giatri)
        {
            var dshd = from x in data.HoaDons
                       from y in data.HoaDonChiTiets
                       where x.MaHD == y.MaHD && x.KieuHoaDon == loaihoadon
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
                       } into t
                       where t.MaHD.Contains(giatri)
                       || t.MaDoiTac.Contains(giatri)
                       || t.MaHDChiTiet.Contains(giatri)
                       || t.Ngay.ToString().Contains(giatri)
                       || t.MaSP.ToString().Contains(giatri)
                       || t.SoLuong.ToString().Contains(giatri)
                       || t.Gia.ToString().Contains(giatri)
                       || t.MaNV.Contains(giatri)
                       select t;

            return dshd;
        }
        public object getDataHD()
        {
            var hd = from a in data.HoaDons
                     from b in data.HoaDonChiTiets
                     from c in data.DoiTacs
                     where a.MaDoiTac == c.MaDoiTac
                     where a.MaHD == b.MaHD
                     select new
                     {
                         MaHD      = a.MaHD,
                         TenDoiTac = c.TenDoiTac,
                         Ngay      = a.Ngay,
                         KieuHoaDon =a.KieuHoaDon,
                         SoLuong    = b.SoLuong,
                         Gia        = b.Gia 
                     };
            return hd;
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
        //Sửa xóa hóa đơn
        public int UpdateHD(string mahd, string ngay,string kieu, string soluong)
        {
            var HD = data.HoaDons.Single(a => a.MaHD == mahd);
            var ChiTiet = data.HoaDonChiTiets.Single(b => b.MaHD == mahd);
            HD.Ngay = DateTime.ParseExact(ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            HD.KieuHoaDon = kieu;
            ChiTiet.SoLuong = Convert.ToInt32(soluong);

            data.SubmitChanges();
            return 1;
        }
        public int DelHD(string mahd)
        {
            var HD = data.HoaDons.Single(a => a.MaHD == mahd);
            var ChiTiet = data.HoaDonChiTiets.Single(b => b.MaHD == mahd);

            data.HoaDons.DeleteOnSubmit(HD);
            data.HoaDonChiTiets.DeleteOnSubmit(ChiTiet);
            data.SubmitChanges();
            
            return 1;
        }
        //Sửa xóa sản phẩm
        public int UpdateSP(string masp, string tensp, string soluong, string gia, string ngay, string ghichu)
        {
            var SP = data.SanPhams.Single(p => p.MaSP == masp);
            SP.MaSP = masp;
            SP.TenSP = tensp;
            SP.SoLuong = Convert.ToInt32(soluong);
            SP.Gia = Convert.ToInt32(gia);
            SP.Ngay = Convert.ToDateTime(ngay);
            SP.GhiChu = ghichu;

            data.SubmitChanges();

            return 1;
        }
        public int delSP(string masp)
        {
            var SP = data.SanPhams.Single(p => p.MaSP == masp);
            var HDCT = data.HoaDonChiTiets.Single(p => p.MaSP == masp);
            data.SanPhams.DeleteOnSubmit(SP);
            data.HoaDonChiTiets.DeleteOnSubmit(HDCT);
            data.SubmitChanges();
            return 1;
        }
    }
}
