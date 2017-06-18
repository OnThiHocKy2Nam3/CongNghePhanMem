using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi.Models
{
    class HoaDon
    {
        public HoaDon(){}
        public string Ma { get; set; }
        public DateTime Ngay { get; set; }
        //public string NoiDung { get; set; }
        public string KhachHangMa { get; set; }
        public string NhanVienMa { get; set; }
        public double TongTien { get; set; }

    }
}
