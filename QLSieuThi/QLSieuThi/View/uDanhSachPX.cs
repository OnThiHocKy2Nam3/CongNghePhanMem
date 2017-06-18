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
    public partial class uDanhSachPX : UserControl
    {
          private Controller controller = new Controller();
        public uDanhSachPX()
        {
            InitializeComponent();
        }

        private void uDanhSachPX_Load(object sender, EventArgs e)
        {

            tabDSHoadonLoad();
        }

        private void tabDSHoadonLoad()
        {
            dtgDSPX.DataSource = controller.getList_PhieuXuat();
            dtgDSPX.Columns["Ma"].HeaderText = "Mã phiếu xuất";
            dtgDSPX.Columns["Ngay"].HeaderText = "Ngày xuất";
            dtgDSPX.Columns["NoiDung"].HeaderText = "Nội Dung";
            dtgDSPX.Columns["KhachHangMa"].HeaderText = "Mã khách hàng";
            dtgDSPX.Columns["NhanVienMa"].HeaderText = "Mã nhân viên";
            dtgDSPX.Columns["TongTien"].HeaderText = "Tổng tiền";
            dtgDSPX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PhieuXuat px = new PhieuXuat();
            px.Ma = dtgDSPX.Rows[dtgDSPX.CurrentRow.Index].Cells[0].Value.ToString();

            //
            dtgDSCTPX.DataSource = controller.getList_ChiTietPhieuXuat(px.Ma);
            dtgDSCTPX.Columns["Ma"].HeaderText = "Mã CTphiếu xuất";
            dtgDSCTPX.Columns["PhieuXuatMa"].HeaderText = "Mã phiếu xuất";
            dtgDSCTPX.Columns["KhoMa"].HeaderText = "Mã kho";
            dtgDSCTPX.Columns["HangHoaMa"].HeaderText = "Mã hàng hóa";
            dtgDSCTPX.Columns["SoLuong"].HeaderText = "Số Lượng";
            dtgDSCTPX.Columns["DonVi"].HeaderText = "Đơn vị";
            dtgDSCTPX.Columns["DonViQuyDoiMa"].HeaderText = "Đơn vị quy đổi mã";
            dtgDSCTPX.Columns["DonGia"].HeaderText = "Đơn giá";
            dtgDSCTPX.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dtgDSCTPX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void dtgDSPX_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PhieuXuat px = new PhieuXuat();
            px.Ma = dtgDSPX.Rows[dtgDSPX.CurrentRow.Index].Cells[0].Value.ToString();
            dtgDSCTPX.DataSource = controller.getList_ChiTietPhieuXuat(px.Ma);
            dtgDSCTPX.Columns["Ma"].HeaderText = "Mã CTphiếu xuất";
            dtgDSCTPX.Columns["PhieuXuatMa"].HeaderText = "Mã phiếu xuất";
            dtgDSCTPX.Columns["KhoMa"].HeaderText = "Mã kho";
            dtgDSCTPX.Columns["HangHoaMa"].HeaderText = "Mã hàng hóa";
            dtgDSCTPX.Columns["SoLuong"].HeaderText = "Số Lượng";
            dtgDSCTPX.Columns["DonVi"].HeaderText = "Đơn vị";
            dtgDSCTPX.Columns["DonViQuyDoiMa"].HeaderText = "Đơn vị quy đổi mã";
            dtgDSCTPX.Columns["DonGia"].HeaderText = "Đơn giá";
            dtgDSCTPX.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dtgDSCTPX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
