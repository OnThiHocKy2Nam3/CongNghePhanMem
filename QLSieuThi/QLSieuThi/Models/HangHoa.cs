using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi.Models
{
    public class HangHoa
    {
        public String Ma { get; set; }
        public String NhomHangMa { get; set; }
        public  String Ten { get; set; }
        public Double SoLuong { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime HanSuDung { get; set;}
        public String NoiSanXuat { get; set; }
        public double DonGia { get; set; }
        public String KhuyenMaiMa { get; set; }

    }
}
