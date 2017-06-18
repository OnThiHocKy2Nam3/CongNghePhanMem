using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi.Models
{
    class KhuyenMai
    {
        public KhuyenMai() { }
        public String Ma { get; set; }
        public String Ten { get; set; }
        public String NoiDungKhuyenMai { get; set; }
        public float PhanTramKhuyenMai { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public String TinhTrang { get; set; }
    }
}
