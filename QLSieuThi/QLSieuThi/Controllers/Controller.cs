using QLSieuThi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSieuThi.Controllers
{
    class Controller
    {
        DataAccess dataAccess = new DataAccess();

        public NhanVien[] getList_NhanVien()
        {
            DataTable table = dataAccess.Query("select *from NhanVien");
            int n = table.Rows.Count;
            int i, gioitinh = 0;
            if (n == 0) return null;
            NhanVien[] list = new NhanVien[n];
            NhanVien nv = new NhanVien();
            for (i = 0; i < n; i++)
            {
                nv = new NhanVien();
                nv.Ma = table.Rows[i]["ma"].ToString().Trim();
                nv.Ten = table.Rows[i]["ten"].ToString().Trim();
                if (int.TryParse(table.Rows[i]["gioitinh"].ToString().Trim(), out gioitinh))
                {
                    nv.GioiTinh = gioitinh;
                }
                nv.NgaySinh = DateTime.Parse(table.Rows[i]["ngaysinh"].ToString().Trim());
                nv.SoDienThoai = table.Rows[i]["sodienthoai"].ToString().Trim();
                nv.Luong = Double.Parse(table.Rows[i]["luong"].ToString().Trim());
                nv.PhongBanMa = table.Rows[i]["phongbanma"].ToString().Trim();
                nv.DiaChi = table.Rows[i]["diachi"].ToString().Trim();
                nv.MatKhau = table.Rows[i]["matkhau"].ToString().Trim();
                list[i] = nv;

            }
            return list;
        }

        public PhieuNhap[] getList_PhieuNhap()
        {
            DataTable table = dataAccess.Query("select *from PhieuNhap order by ma desc");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            PhieuNhap[] list = new PhieuNhap[n];
            double tongtien = 0;

            for (i = 0; i < n; i++)
            {
                list[i] = new PhieuNhap();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ngay = DateTime.Parse(table.Rows[i]["ngay"].ToString().Trim());
                list[i].NhaCungCapMa = table.Rows[i]["nhacungcapma"].ToString().Trim();
                list[i].NguoiGiaoMa = table.Rows[i]["nguoigiaoma"].ToString().Trim();
                list[i].NoiDung = table.Rows[i]["noidung"].ToString().Trim();
                double.TryParse(table.Rows[i]["tongtien"].ToString().Trim(), out tongtien);
                list[i].TongTien = tongtien;
            }
            return list;
        }

        public PhieuXuat[] getList_PhieuXuat()
        {
            DataTable table = dataAccess.Query("select *from PhieuXuat order by ma desc");
            int n = table.Rows.Count;
            int i;
            double tongtien = 0;
            if (n == 0) return null;
            PhieuXuat[] list = new PhieuXuat[n];
            for (i = 0; i < n; i++)
            {
                list[i] = new PhieuXuat();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ngay = DateTime.Parse(table.Rows[i]["ngay"].ToString().Trim());
                list[i].NoiDung = table.Rows[i]["noidung"].ToString().Trim();
                list[i].KhachHangMa = table.Rows[i]["khachhangma"].ToString().Trim();
                list[i].NhanVienMa = table.Rows[i]["nhanvienma"].ToString().Trim();
                double.TryParse(table.Rows[i]["tongtien"].ToString().Trim(), out tongtien);
                list[i].TongTien = tongtien;
            }
            return list;
        }

        public ChiTietPhieuNhap[] getList_ChiTietPhieuNhap(string ma)
        {
            DataTable table = dataAccess.Query("select *from ChiTietPhieuNhap where phieunhapma='"+ma+"'");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            ChiTietPhieuNhap[] list = new ChiTietPhieuNhap[n];
            double dongia = 0,thanhtien=0;
            for (i = 0; i < n; i++)
            {
                list[i] = new ChiTietPhieuNhap();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].PhieuNhapMa = table.Rows[i]["phieunhapma"].ToString().Trim();
                list[i].KhoMa = table.Rows[i]["khoma"].ToString().Trim();
                list[i].HangHoaMa = table.Rows[i]["hanghoama"].ToString().Trim();
                list[i].SoLuong =int.Parse( table.Rows[i]["soluong"].ToString().Trim());
                list[i].DonVi = table.Rows[i]["donvi"].ToString().Trim();
                list[i].DonViQuyDoiMa = table.Rows[i]["donviquydoima"].ToString().Trim();
                double.TryParse(table.Rows[i]["dongia"].ToString().Trim(),out dongia);
                list[i].DonGia = dongia;
                double.TryParse(table.Rows[i]["thanhtien"].ToString().Trim(), out thanhtien);
                list[i].ThanhTien = thanhtien;
            }
            return list;
        }

        public ChiTietPhieuXuat[] getList_ChiTietPhieuXuat(string ma)
        {
            DataTable table = dataAccess.Query("select *from ChiTietPhieuXuat where phieuxuatma='"+ma+"'");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            ChiTietPhieuXuat[] list = new ChiTietPhieuXuat[n];
            double dongia = 0, thanhtien = 0;
            for (i = 0; i < n; i++)
            {
                list[i] = new ChiTietPhieuXuat();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].PhieuXuatMa = table.Rows[i]["phieuxuatma"].ToString().Trim();
                list[i].KhoMa = table.Rows[i]["khoma"].ToString().Trim();
                list[i].HangHoaMa = table.Rows[i]["hanghoama"].ToString().Trim();
                list[i].SoLuong = int.Parse(table.Rows[i]["soluong"].ToString().Trim());
                list[i].DonVi = table.Rows[i]["donvi"].ToString().Trim();
                list[i].DonViQuyDoiMa = table.Rows[i]["donviquydoima"].ToString().Trim();
                double.TryParse(table.Rows[i]["dongia"].ToString().Trim(), out dongia);
                list[i].DonGia = dongia;
                double.TryParse(table.Rows[i]["thanhtien"].ToString().Trim(), out thanhtien);
                list[i].ThanhTien = thanhtien;
            }
            return list;
        }

        public NhaCungCap[] getList_NhaCungCap()
        {
            DataTable table = dataAccess.Query("select *from NhaCungCap");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            NhaCungCap[] list = new NhaCungCap[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new NhaCungCap();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ten = table.Rows[i]["ten"].ToString().Trim();
                list[i].DiaChi = table.Rows[i]["diachi"].ToString().Trim();
                list[i].DienThoai = table.Rows[i]["dienthoai"].ToString().Trim();
                list[i].MaSoThue = int.Parse(table.Rows[i]["masothue"].ToString().Trim());
                list[i].Email = table.Rows[i]["email"].ToString().Trim();
            }
            return list;
        }
        public Kho[] getList_KhoHang()
        {
            DataTable table = dataAccess.Query("select *from Kho");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            Kho[] list = new Kho[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new Kho();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ten = table.Rows[i]["ten"].ToString().Trim();
               
            }
            return list;
        }
        public string getTenHang(string ma)
        {
            DataTable table = dataAccess.Query("select ten from HangHoa where ma='" + ma + "'");
            string ten = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["ten"].ToString().Trim();
            return ten;
        }
        public string getDonGia(string ma)
        {
            DataTable table = dataAccess.Query("select dongia from HangHoa where ma='" + ma + "'");
            string dongia = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["dongia"].ToString().Trim();
            return dongia;
        }
        public string getKhoma(string ma)
        {
            DataTable table = dataAccess.Query("select top(1) khoma from ChiTietPhieuNhap where hanghoama='" + ma + "'");
            string khoma = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["khoma"].ToString().Trim();
            return khoma;
        }
        public HangHoa[] getList_HangHoa()
        {
            DataTable table = dataAccess.Query("select *from HangHoa");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            HangHoa[] list = new HangHoa[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new HangHoa();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ten = table.Rows[i]["ten"].ToString().Trim();
                double soluong = 0;
                double.TryParse(table.Rows[i]["soluong"].ToString().Trim(), out soluong);
                list[i].SoLuong = soluong;
                list[i].NgaySanXuat = DateTime.Parse(table.Rows[i]["ngaysanxuat"].ToString().Trim());
                list[i].HanSuDung = DateTime.Parse(table.Rows[i]["hansudung"].ToString().Trim());
                list[i].NoiSanXuat = table.Rows[i]["noisanxuat"].ToString().Trim();
                double dongia = 0;
                double.TryParse(table.Rows[i]["dongia"].ToString().Trim(), out dongia);
                list[i].DonGia = dongia;
            }
            return list;
        }
    
        public NhomHang[] getList_NhomHang()
        {
            DataTable table = dataAccess.Query("select *from NhomHang");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            NhomHang[] list = new NhomHang[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new NhomHang();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ten = table.Rows[i]["ten"].ToString().Trim();
                
            }
            return list;
        }
        public DonViQuyDoi[] getList_DonVi()
        {
            DataTable table = dataAccess.Query("select *from DonViQuyDoi");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            DonViQuyDoi[] list = new DonViQuyDoi[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new DonViQuyDoi();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ten = table.Rows[i]["ten"].ToString().Trim();
                list[i].DonViDoi = table.Rows[i]["donvidoi"].ToString().Trim();
                list[i].DonViCoSo = table.Rows[i]["donvicoso"].ToString().Trim();
                list[i].HeSoQuyDoi = int.Parse(table.Rows[i]["hesoquydoi"].ToString().Trim());
            }
            return list;
        }

        public bool NhanVien_Them(NhanVien nv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ten", nv.Ten),
                new SqlParameter("gioitinh", nv.GioiTinh),
                new SqlParameter("ngaysinh", nv.NgaySinh),
                new SqlParameter("sodienthoai", nv.SoDienThoai),
                new SqlParameter("luong", nv.Luong),
                new SqlParameter("phongban", nv.PhongBanMa),
                new SqlParameter("diachi", nv.DiaChi),
                new SqlParameter("matkhau", nv.MatKhau)
            };
            dataAccess.Query("proc_insertNV", para);

            return true;
        }
       
        public bool NhanVien_Sua(NhanVien nv)
        {
            SqlParameter[] para =
                  {
                new SqlParameter("ma", nv.Ma),
                new SqlParameter("ten", nv.Ten),
                new SqlParameter("gioitinh", nv.GioiTinh),
                new SqlParameter("ngaysinh", nv.NgaySinh),
                new SqlParameter("sodienthoai", nv.SoDienThoai),
                new SqlParameter("luong", nv.Luong),
                new SqlParameter("phongban", nv.PhongBanMa),
                new SqlParameter("diachi", nv.DiaChi),
                new SqlParameter("matkhau", nv.MatKhau)
            };
            dataAccess.Query("proc_updateNV", para);

            return true;
        }

        public void NhanVien_Xoa(string ma)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ma", ma)
            };
            dataAccess.NonQuery("proc_deleteNV", para);
        }

        public KhachHang[] getList_Khach()
        {
            DataTable table = dataAccess.Query("select *from KhachHang");
            int n = table.Rows.Count;
            int i, gioitinh = 0;
            if (n == 0) return null;
            KhachHang[] list = new KhachHang[n];

            for (i = 0; i < n; i++)
            {
                list[i] = new KhachHang();
                list[i].Ma = table.Rows[i]["ma"].ToString().Trim();
                list[i].Ten = table.Rows[i]["ten"].ToString().Trim();
                if (int.TryParse(table.Rows[i]["gioitinh"].ToString().Trim(), out gioitinh))
                {
                    list[i].GioiTinh = gioitinh;
                }
                list[i].Email = table.Rows[i]["email"].ToString().Trim();
                list[i].SoDienThoai = table.Rows[i]["sodienthoai"].ToString().Trim();
                list[i].SoCMND = table.Rows[i]["sochungminh"].ToString().Trim();
                list[i].DiaChi = table.Rows[i]["diachi"].ToString().Trim();
            }
            return list;
        }

        public bool KhachHang_Them(KhachHang kh)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ten", kh.Ten),
                new SqlParameter("gioitinh", kh.GioiTinh),
                new SqlParameter("sodienthoai", kh.SoDienThoai),
               new SqlParameter("email", kh.Email),
                new SqlParameter("socmnd", kh.SoCMND),
                new SqlParameter("diachi", kh.DiaChi)
            };
            
            dataAccess.Query("proc_insertKhachHang", para);

            return true;
        }
        public void insertChiTietPN(ChiTietPhieuNhap ctpn,string ma)
        {

            SqlParameter[] para =
         {
                new SqlParameter("phieunhapma",ma),
                new SqlParameter("hanghoama",ctpn.HangHoaMa),
                new SqlParameter("khoma",ctpn.KhoMa),
                new SqlParameter("soluong",ctpn.SoLuong),
                new SqlParameter("donvi",ctpn.DonVi),
                new SqlParameter("donviquydoima",ctpn.DonViQuyDoiMa),
                new SqlParameter("dongia",ctpn.DonGia)
             

            };
            dataAccess.Query("procedure_insertChiTietPhieuNhap", para);
          
         }


        public void insertChiTietPX(ChiTietPhieuXuat ctpx,string ma)
        {
            SqlParameter[] para =
        {
                new SqlParameter("phieuxuatma",ma),
                new SqlParameter("hanghoama",ctpx.HangHoaMa),
                new SqlParameter("soluong",ctpx.SoLuong),
                new SqlParameter("donvi",ctpx.DonVi),
                new SqlParameter("donviquydoima",ctpx.DonViQuyDoiMa),
                new SqlParameter("dongia",ctpx.DonGia)
               

            };
            dataAccess.Query("procedure_insertChiTietPhieuXuat", para);

        }
        public void insertPN(PhieuNhap pn)
        {

            SqlParameter[] para =
         {
                new SqlParameter("nhacungcapma",pn.NhaCungCapMa),
                new SqlParameter("manguoigiao",pn.NguoiGiaoMa),
                new SqlParameter("noidung",pn.NoiDung),
                new SqlParameter("tongtien",pn.TongTien)
           };
            dataAccess.Query("procedure_insertPhieuNhap", para);

        }

      
        public void insertPX(PhieuXuat px)
        {

            SqlParameter[] para =
         {
                new SqlParameter("noidung",px.NoiDung),
                new SqlParameter("khachhangma",px.KhachHangMa),
                new SqlParameter("nhanvienma",px.NhanVienMa),
                new SqlParameter("tongtien",px.TongTien)
         };
            dataAccess.Query("procedure_insertPhieuXuat", para);
        }
        public string getMaPN(PhieuNhap pn)
        {
            DataTable table = dataAccess.Query(" select dbo.auto_ma_PhieuNhap()as ma");
            string ma = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["ma"].ToString().Trim();
            return ma;
        }
        public string get_PXma(PhieuXuat px)
        {
            DataTable table = dataAccess.Query(" select dbo.auto_ma_PhieuXuat()as ma");
            string ma = "";
            if (table.Rows.Count == 1)
                return table.Rows[0]["ma"].ToString().Trim();
            return ma;
        }
      
        public float getPhanTramKhuyenMai(string ma)
        {
            DataTable dt = dataAccess.Query("select KhuyenMai.PhanTramKhuyenMai from KhuyenMai inner join HangHoa on HangHoa.KhuyenMaiMa=KhuyenMai.ma where KhuyenMai.ngaybatdau<GETDATE() and KhuyenMai.ngayketthuc>GETDATE() and HangHoa.ma='" + ma + "'");
            float phantramkm = 0;
            if (dt.Rows.Count == 1)
                return float.Parse(dt.Rows[0]["phantramkhuyenmai"].ToString().Trim());
            return phantramkm;


        }
        public int getHeSoQuyDoi(string ma)
        {
            DataTable dt = dataAccess.Query("select hesoquydoi from DonViQuyDoi where ma='" + ma + "'");
            int heso = 0;
            if (dt.Rows.Count == 1)
                return int.Parse(dt.Rows[0]["hesoquydoi"].ToString().Trim());
            return heso;

        }
        public string getDonViQuyDoiMa(string ten)
        {
            DataTable dt = dataAccess.Query("select ma from DonViQuyDoi where ten=N'" + ten + "'");
            string ma = "";
            if (dt.Rows.Count == 1)
                return dt.Rows[0]["ma"].ToString().Trim();
            return ma;


        }
        public int getTheKhachHang(string ma)
        {

            DataTable dt = dataAccess.Query("select TheKhachHang.diemtichluy from TheKhachHang inner join KhachHang on KhachHang.TheKhachHangMa=TheKhachHang.ma where KhachHang.ma='" + ma + "'");
            int diemtichluy = 0;
            if (dt.Rows.Count == 1)
                return int.Parse(dt.Rows[0]["diemtichluy"].ToString().Trim());
            return diemtichluy;


        }
        public bool KhachHang_Sua(KhachHang kh)
        {
            SqlParameter[] para =
                  {
                new SqlParameter("ma", kh.Ma),
                new SqlParameter("ten", kh.Ten),
                new SqlParameter("gioitinh", kh.GioiTinh),
                new SqlParameter("sodienthoai", kh.SoDienThoai),
                new SqlParameter("diachi", kh.DiaChi),
                new SqlParameter("email", kh.Email),
                new SqlParameter("socmnd", kh.SoCMND)
            };
            dataAccess.Query("proc_updateKhachHang", para);

            return true;
        }
        public void Khach_Xoa(string ma)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ma", ma)
            };
            dataAccess.NonQuery("proc_deleteKhachHang", para);
        }
        public NhanVien getNhanVien(String ma, String matkhau)
        {
            DataTable table = dataAccess.Query("select * from nhanvien where ma = '" + ma + "' and matkhau  = '" + matkhau + "'");
            NhanVien nv = new NhanVien();
            if(table.Rows.Count == 1)
            {
                nv.Ma = table.Rows[0]["ma"].ToString().Trim();
            }
            return nv;
        }




    }
}
