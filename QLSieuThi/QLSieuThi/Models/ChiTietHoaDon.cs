using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi.Models
{
    class ChiTietHoaDon
    {
        public ChiTietHoaDon() { }
        public string Ma { get; set; }
        public string HoaDonMa { get; set; }
        public string HangHoaMa { get; set; }
       // public string KhoMa { get; set; }
        public int SoLuong { get; set; }
        public string DonVi { get; set; }
        public string DonViQuyDoiMa { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }

    }
}
