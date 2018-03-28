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
    }
}
