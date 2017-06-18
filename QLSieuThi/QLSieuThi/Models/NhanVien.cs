using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi.Models
{
    public class NhanVien
    {
        public NhanVien()
        {
            Ma = "";
            Ten = "";
            GioiTinh = 1;
            NgaySinh = DateTime.Now;
            SoDienThoai = "";
            Luong = 0;
            PhongBanMa = "";
            ChucVuMa = "";
            DiaChi = "";
            MatKhau = "";
        }
        public String Ma { get; set; }
        public String Ten { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public String SoDienThoai { get; set; }
        public Double Luong { get; set; }
        public String PhongBanMa { get; set; }
        public String ChucVuMa { get; set; }
        public String DiaChi { get; set; }
        public String MatKhau { get; set; }
    }
}
