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
    public partial class UDanhSachPN : UserControl
    {

        private Controller controller = new Controller();
        public UDanhSachPN()
        {
            InitializeComponent();
        }

        private void UDanhSachPN_Load(object sender, EventArgs e)
        {
            tabDanhSachPhieuNhapLoad();
        }
        private void tabDanhSachPhieuNhapLoad()
        {
            dtgDSPhieuNhap.DataSource = controller.getList_PhieuNhap();
            dtgDSPhieuNhap.Columns["Ma"].HeaderText = "Mã Phiếu Nhập";
            dtgDSPhieuNhap.Columns["Ngay"].HeaderText = "Ngày nhập";
            dtgDSPhieuNhap.Columns["NhaCungCapMa"].HeaderText = "Mã nhà cung cấp";
            dtgDSPhieuNhap.Columns["NguoiGiaoMa"].HeaderText = "Người giao";
            dtgDSPhieuNhap.Columns["NoiDung"].HeaderText = "Nội dung";
            dtgDSPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PhieuNhap pn = new PhieuNhap();
            pn.Ma = dtgDSPhieuNhap.Rows[dtgDSPhieuNhap.CurrentRow.Index].Cells[0].Value.ToString();

            //
            dtgChiTietPhieuNhap.DataSource = controller.getList_ChiTietPhieuNhap(pn.Ma);
            dtgChiTietPhieuNhap.Columns["Ma"].HeaderText = "Mã CTPhiếu Nhập";
            dtgChiTietPhieuNhap.Columns["PhieuNhapMa"].HeaderText = "Mã Phiếu Nhập";
            dtgChiTietPhieuNhap.Columns["KhoMa"].HeaderText = "Mã Kho";
            dtgChiTietPhieuNhap.Columns["HangHoaMa"].HeaderText = "Mã hàng";
            dtgChiTietPhieuNhap.Columns["SoLuong"].HeaderText = "Số Lượng";
            dtgChiTietPhieuNhap.Columns["DonGia"].HeaderText = "Đơn Gía";
            dtgChiTietPhieuNhap.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dtgChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void dtgDSPhieuNhap_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.Ma = dtgDSPhieuNhap.Rows[dtgDSPhieuNhap.CurrentRow.Index].Cells[0].Value.ToString();
            dtgChiTietPhieuNhap.DataSource = controller.getList_ChiTietPhieuNhap(pn.Ma);
            dtgChiTietPhieuNhap.Columns["Ma"].HeaderText = "Mã CTPhiếu Nhập";
            dtgChiTietPhieuNhap.Columns["PhieuNhapMa"].HeaderText = "Mã Phiếu Nhập";
            dtgChiTietPhieuNhap.Columns["KhoMa"].HeaderText = "Mã Kho";
            dtgChiTietPhieuNhap.Columns["HangHoaMa"].HeaderText = "Mã hàng";
            dtgChiTietPhieuNhap.Columns["SoLuong"].HeaderText = "Số Lượng";
            dtgChiTietPhieuNhap.Columns["DonGia"].HeaderText = "Đơn Gía";
            dtgChiTietPhieuNhap.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dtgChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
