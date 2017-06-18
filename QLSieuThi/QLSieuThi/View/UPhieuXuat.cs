using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSieuThi.Controllers;
using QLSieuThi.Models;

namespace QLSieuThi.View
{
    public partial class UPhieuXuat : UserControl
    {
        public UPhieuXuat()
        {
            InitializeComponent();
        }
        private Controller controller = new Controller();
        DataTable dt = new DataTable();
        private void tabPhieuXuatload()
        {
           
            dt.Columns.Add("mã hàng", typeof(string));
            dt.Columns.Add("số lượng", typeof(string));
            dt.Columns.Add("đơn vị", typeof(string));
            dt.Columns.Add("đơn giá", typeof(string));
            dt.Columns.Add("thành tiền", typeof(string));
     
            PhieuXuat px = new PhieuXuat();

            dtgPXMuaHang.DataSource = dt;
            dtgPXMuaHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbPXMaNhanVien.DataSource = controller.getList_NhanVien();
            cbbPXMaNhanVien.DisplayMember = "ma";
            cbbPXMaNhanVien.ValueMember = "ma";
            lblPhieuXuatMa.Text = controller.get_PXma(px);
            cbbPXMaHang.DataSource = controller.getList_HangHoa();
            cbbPXMaHang.DisplayMember = "ma";
            cbbPXMaHang.ValueMember = "ma";
            cbbPXKhachHang.DataSource = controller.getList_Khach();
            cbbPXKhachHang.DisplayMember = "ten";
            cbbPXKhachHang.ValueMember = "ma";
            cbbPXDonViQuyDoi.DataSource = controller.getList_DonVi();
            cbbPXDonViQuyDoi.DisplayMember = "ten";
            cbbPXDonViQuyDoi.ValueMember = "ma";
        }
        private void cbbPXND_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPXND.Text.ToString().Trim().Equals("Bán lẻ"))
            {
                cbbPXKhachHang.Enabled = false;

            }
            else cbbPXKhachHang.Enabled = true;
        }

        private void cbbPXMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtPXTenHang.Text = controller.getTenHang(cbbPXMaHang.Text.ToString().Trim());
            txtPXDonGia.Text = controller.getDonGia(cbbPXMaHang.Text.ToString().Trim());
            txtPXKhuyenMai.Text = controller.getPhanTramKhuyenMai(cbbPXMaHang.SelectedValue.ToString()).ToString();

        }
        private bool checkpx()
        {
            if (cbbPXMaNhanVien.Text.ToString().Trim().Equals(""))
            {
                errPXMaNV.SetError(cbbPXMaNhanVien, "nhap nhan vien");
                return false;
            }
            errPXMaNV.Clear();
            if (cbbPXND.Text.ToString().Trim().Equals(""))
            {
                errPNNoidung.SetError(cbbPXND, "chon noi dung");
                return false;
            }
            errPNNoidung.Clear();
            if (cbbPXKhachHang.Text.ToString().Trim().Equals(""))
            {
                errPXMaNV.SetError(cbbPXKhachHang, "nhap khach hang");
                return false;
            }
            errPXMaNV.Clear();
            if (txtPXTenHang.Text.ToString().Trim().Equals(""))
            {
                errPNNoidung.SetError(txtPXTenHang, "nhap ten hang");
                return false;
            }
            errPNNoidung.Clear();
            if (txtPXSoLuong.Text.ToString().Trim().Equals(""))
            {
                errPNNoidung.SetError(txtPXSoLuong, "nhap so luong");
                return false;
            }
            errPNNoidung.Clear();
            return true;
        }
        double tongtienpx = 0;

        private void btnPXThemHang_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            if (checkpx())
            {
                if (int.Parse(txtPXSoLuong.Text.ToString().Trim()) == 0)
                    MessageBox.Show("Vui lòng kiểm tra lại số lượng!");
                else
                {
                    int row = dtgPXMuaHang.Rows.Count + 1;
                    double soluong = 0, dongia = 0, thanhtien = 0;
                    int hesoquydoi = 0, phantramkhuyenmai = 0;
                    double.TryParse(txtPXSoLuong.Text, out soluong);
                    double.TryParse(txtPXDonGia.Text, out dongia);
                   
                 
                    ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                    ctpx.HangHoaMa = cbbPXMaHang.Text.ToString().Trim();
                    ctpx.SoLuong = int.Parse(txtPXSoLuong.Text.ToString().Trim());
                    ctpx.DonVi = cbbPXDonViQuyDoi.Text.ToString().Trim();
                    ctpx.DonViQuyDoiMa = cbbPXDonViQuyDoi.SelectedValue.ToString().Trim();
                    ctpx.DonGia = dongia;
                    dtgPXMuaHang.DataSource = dt;
                    hesoquydoi = controller.getHeSoQuyDoi(ctpx.DonViQuyDoiMa);
                    phantramkhuyenmai = int.Parse(txtPXKhuyenMai.Text.ToString().Trim());
                    if (phantramkhuyenmai != 0)
                        thanhtien = soluong * hesoquydoi * dongia * 0.01 *(100- phantramkhuyenmai);
                    else thanhtien = soluong * hesoquydoi * dongia;
                    ctpx.ThanhTien = thanhtien;
                    dt.Rows.Add(ctpx.HangHoaMa, ctpx.SoLuong.ToString(),ctpx.DonVi, ctpx.DonGia.ToString(), ctpx.ThanhTien.ToString());
                    tongtienpx += thanhtien;
                }
            }
            txtPXTongTien.Text = tongtienpx.ToString();
        }

        private void btnPXHuy_Click(object sender, EventArgs e)
        {
            this.dtgPXMuaHang.DataSource = null;
        }

        private void btnPXLuu_Click(object sender, EventArgs e)
        {
            if (txtPXTienTraLai.Text.ToString().Equals(""))
                MessageBox.Show("Phải thanh toán trước!");
            else
            {
                PhieuXuat px = new PhieuXuat();
                px.Ma = controller.get_PXma(px);
                if (cbbPXND.Text.ToString().Trim().Equals("Bán lẻ"))
                {

                    px.KhachHangMa = "KH0001";
                }

                px.KhachHangMa = cbbPXKhachHang.SelectedValue.ToString().Trim();
                px.NoiDung = cbbPXND.Text.ToString().Trim();
                px.NhanVienMa = cbbPXMaNhanVien.SelectedValue.ToString().Trim();
                px.TongTien = float.Parse(txtPXTongTien.Text.ToString().Trim());
                controller.insertPX(px);
                int hesoquydoi = 0;
                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                foreach (DataRow row in dt.Rows)
                {

                    ctpx.HangHoaMa = row[0].ToString();
                    ctpx.SoLuong = int.Parse(row[1].ToString());
                    ctpx.DonVi = row[2].ToString().Trim();
                    double dongia = 0;
                    double.TryParse(row[3].ToString(), out dongia);
                    ctpx.DonGia = dongia;
                    ctpx.DonViQuyDoiMa = controller.getDonViQuyDoiMa(ctpx.DonVi);
                    controller.insertChiTietPX(ctpx, px.Ma);


                }
             
                MessageBox.Show("Đã lưu hóa đơn!");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            if (int.Parse(txtPXTongTien.Text.ToString().Trim()) == 0)
                MessageBox.Show("Vui lòng kiểm tra lại tổng tiền!");
            else  if (txtPXTienKhachDua.Text.ToString().Equals(""))
                MessageBox.Show("Nhập tiền khách đưa!");
            else if (int.Parse(txtPXTienKhachDua.Text.ToString().Trim()) < int.Parse(txtPXTongTien.Text.ToString().Trim()))
                MessageBox.Show("Số tiền của quý khách không đủ,vui lòng thanh toán lại!");
            else
            {
                double pxtienkhach = 0, tientralai = 0, tongtienhoadon = 0;
                double tienthetichluy = 0;
                double.TryParse(txtPXTienKhachDua.Text.ToString().Trim(), out pxtienkhach);
                double.TryParse(txtPXTongTien.Text.ToString().Trim(), out tongtienhoadon);
                double.TryParse(txtTheKhachHang.ToString().Trim(),out tienthetichluy);
                tientralai = pxtienkhach - tongtienhoadon-tienthetichluy;
                txtPXTienTraLai.Text = tientralai.ToString();
                kh.Ma = cbbPXKhachHang.SelectedValue.ToString().Trim();
                

            }
        }

        private void UPhieuXuat_Load(object sender, EventArgs e)
        {
            tabPhieuXuatload();
        }

        private void cbbPXKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTheKhachHang.Text = controller.getTheKhachHang(cbbPXKhachHang.SelectedValue.ToString()).ToString();

        }

        private void cbbPXDonViQuyDoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
