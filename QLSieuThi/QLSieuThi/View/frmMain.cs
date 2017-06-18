using QLSieuThi.Controllers;
using QLSieuThi.Models;
using QLSieuThi.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThi
{
    public partial class frmMain : Form
    {
        private Controller controller = new Controller();
        frmLogin frmLogin;
       
        public frmMain()
        {
            InitializeComponent();
            this.frmLogin = new frmLogin();
        }

        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            dgrthongkehanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrtimkiemhanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        DataAccess da = new DataAccess();
        private void frmMain_Load(object sender, EventArgs e)
        {
            Load_tabpage_QLNhanVien();
            Load_tabpage_QLKhach();
            cbbkhoma.DataSource = da.Convert(da.Query("select ma from Kho"));
           // cbbthongke.Items.Add("Thống kê theo kho");
            cbbthongke.Items.Add("Thống kê lượng hàng hóa nhập vào");
            cbbthongke.Items.Add("Thống kê lượng hàng hóa bán ra");
            cbbtimkiemhanghoa.Items.Add("Tìm kiếm theo tên hàng hóa");
            cbbtimkiemhanghoa.Items.Add("Tìm kiếm theo ngày sản xuất");
            cbbtimkiemhanghoa.Items.Add("Tìm kiếm theo hạn sử dụng");
            cbbtimkiemhanghoa.Items.Add("Tìm kiếm theo nơi sản xuất");
            cbbtimkiemhanghoa.Items.Add("Tìm kiếm theo tên số lượng");
            cbbtimkiemhanghoa.Items.Add("Tìm kiếm theo đơn giá");
            cbbtimkiemhanghoa.Items.Add("Tìm kiếm theo kho");
            rtbhuongdan1.Text = "\t\t\t" + "B1:Đăng nhập vào hệ thống" + "\n\t\t\t" +
                             "B2:Vào trang chủ chọn các chức năng mong muốn" + "\n\t\t\t\t\t\t\t" +
                                  " + Quản lý nhân viên: Có các nút thêm, sửa, xóa, thoát.Nhấn vào các button để thêm bớt các bản ghi như mong muốn.Nếu muốn thoát nhấn Thoát" + "\n\t\t\t\t\t\t\t" +
                                  " + Quản lý nhân viên: Có các nút thêm, sửa, xóa, thoát.Nhấn vào các button để thêm bớt các bản ghi như mong muốn.Nếu muốn thoát nhấn Thoát" + "\n\t\t\t\t\t\t\t" +
                                  " + Thống kê: Bạn có thể thống kê hàng hóa theo một số điều kiện nào đó. Cần phải điền đầy đủ thông tin vào các trường" + "\n\t\t\t\t\t\t\t" +
                                  " + Tìm kiếm: Bạn có thể tìm kiếm hàng hóa theo một số điều kiện nào đó. Cần phải điền đủ thông tin các trường" + "\n\t\t\t" +
                              "B3:Để thoát ra khỏi các chức năng bạn ấn vào tab trang chủ, trở về vị trí ban đầu" + "\n\n\t\t\t\t" +
                              "Chú thích: các thanh bên các cũng có chức năng tương ứng với các tên trên các tab bên trên" + "\n\n\n\t\t\t\t\t\t\t\t" +
                                                         "CHÚC BẠN THÀNH CÔNG";

        }


        private void Load_tabpage_QLNhanVien()
        {
            dgvNhanVien_DanhSach.DataSource = controller.getList_NhanVien();
            dgvNhanVien_DanhSach.Columns["Ma"].HeaderText = "Mã";
            dgvNhanVien_DanhSach.Columns["Ten"].HeaderText = "Tên";
            dgvNhanVien_DanhSach.Columns["Ten"].Width = 200;
            dgvNhanVien_DanhSach.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien_DanhSach.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanVien_DanhSach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvNhanVien_DanhSach.Columns["Luong"].HeaderText = "Lương";
            dgvNhanVien_DanhSach.Columns["PhongBanMa"].HeaderText = "Phòng ban";
            dgvNhanVien_DanhSach.Columns["PhongBanMa"].Width = 175;
            dgvNhanVien_DanhSach.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNhanVien_DanhSach.Columns["MatKhau"].HeaderText = "Mật khẩu";

        }  
        private void Load_tabpage_QLKhach()
        {
            dgvKhach_DanhSach.DataSource = controller.getList_Khach();
            dgvKhach_DanhSach.Columns["Ma"].HeaderText = "Mã";
            dgvKhach_DanhSach.Columns["Ten"].HeaderText = "Tên";
            dgvKhach_DanhSach.Columns["Ten"].Width = 200;
            dgvKhach_DanhSach.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvKhach_DanhSach.Columns["SoCMND"].HeaderText = "CMND";
            dgvKhach_DanhSach.Columns["SoCMND"].Width = 150;
            dgvKhach_DanhSach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvKhach_DanhSach.Columns["SoDienThoai"].Width = 150;
            dgvKhach_DanhSach.Columns["email"].HeaderText = "Email";
            dgvKhach_DanhSach.Columns["email"].Width = 285;
            dgvKhach_DanhSach.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }
        public void frmMain_Update()
        {
            dgvNhanVien_DanhSach.DataSource = controller.getList_NhanVien();
            dgvKhach_DanhSach.DataSource = controller.getList_Khach();
        }

        private void nbiTrangChu_BanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TabPage tabPageBanHang = new TabPage();
            tabPageBanHang.Text = "Bán hàng";
            UHoaDon px = new UHoaDon();
            px.Dock = DockStyle.Fill;
            tabPageBanHang.Controls.Add(px);
            tabControlMain.TabPages.Add(tabPageBanHang);
            tabControlMain.SelectTab(tabPageBanHang);
        }

        private void nbiTrangChu_QLNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageQLNhanVien);
        }

        private void nbiTrangChu_QLKhach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageKhach);
        }

        private void nbiTrangChu_ThongKe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tabPageThongKe);
        }

        private void nbiTrangChu_HuongDan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            tabControlMain.SelectTab(tphuongdan);
        }

        private void nbiTrangChu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          //  tabControlMain.SelectTab(tabPageTrangChu);
        }

        private void nbiTrangChu_NhapHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TabPage tabPageNhapHang = new TabPage();
            tabPageNhapHang.Text = "Nhập hàng";
            UNhapHang nh = new UNhapHang();
            nh.Dock = DockStyle.Fill;
            tabPageNhapHang.Controls.Add(nh);
            tabControlMain.TabPages.Add(tabPageNhapHang); 
            tabControlMain.SelectTab(tabPageNhapHang);
          
        }

        private void btnNhanVien_Them_Click(object sender, EventArgs e)
        {
            frmNhanVien_Add frmNhanVien_Add = new frmNhanVien_Add();
            frmNhanVien_Add.ShowDialog();
        }

        private void btnNhanVien_Sua_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            int temp = 0;
            Double luong = 0;
            nhanvien.Ma = dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[0].Value.ToString();
            nhanvien.Ten = dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[1].Value.ToString();

            if (int.TryParse(dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[2].Value.ToString(), out temp))
            {
                nhanvien.GioiTinh = temp;
            }

            DateTime ngaysinh = DateTime.Now;
            if (DateTime.TryParse(dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[3].Value.ToString().Trim(), out ngaysinh))
            {
                nhanvien.NgaySinh = ngaysinh;
            }
            nhanvien.SoDienThoai = dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[4].Value.ToString().Trim();
            if (Double.TryParse(dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[5].Value.ToString().Trim(), out luong))
            {
                nhanvien.Luong = temp;
            }
            nhanvien.PhongBanMa = dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[6].Value.ToString().Trim();
            nhanvien.DiaChi = dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[7].Value.ToString().Trim();
            nhanvien.MatKhau = dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[8].Value.ToString().Trim();
            frmNhanVien_Update frmNhanVien_Update = new frmNhanVien_Update(this, nhanvien);
            frmNhanVien_Update.ShowDialog();
        }

        private void btnNhanVien_Xoa_Click(object sender, EventArgs e)
        {
            String rowID = dgvNhanVien_DanhSach.Rows[dgvNhanVien_DanhSach.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("Ban co chac  chan  xoa  nhan vien ma " + rowID + "", "Xóa nhân viên",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.NhanVien_Xoa(rowID);
                frmMain_Update();
            }
        }

        private void btnNhanVien_Thoat_Click(object sender, EventArgs e)
        {
           // tabControlMain.SelectTab(tabPageTrangChu);
        }

        private void dgvNhanVien_DanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNhanVien_Sua_Click(sender, e);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frmLogin.Visible = true;
        }

        private void btnKhach_Them_Click(object sender, EventArgs e)
        {
            frmKhach_Add frmKhach_Add = new frmKhach_Add();
            frmKhach_Add.ShowDialog();
        }

        private void btnKhach_Sua_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang();
            int temp = 0;
           
            khachhang.Ma = dgvKhach_DanhSach.Rows[dgvKhach_DanhSach.CurrentRow.Index].Cells[0].Value.ToString();
            khachhang.Ten = dgvKhach_DanhSach.Rows[dgvKhach_DanhSach.CurrentRow.Index].Cells[1].Value.ToString();

            if (int.TryParse(dgvKhach_DanhSach.Rows[dgvKhach_DanhSach.CurrentRow.Index].Cells[2].Value.ToString(), out temp))
            {
                khachhang.GioiTinh = temp;
            }
            khachhang.DiaChi = dgvKhach_DanhSach.Rows[dgvKhach_DanhSach.CurrentRow.Index].Cells[3].Value.ToString().Trim();

            khachhang.SoDienThoai = dgvKhach_DanhSach.Rows[dgvKhach_DanhSach.CurrentRow.Index].Cells[4].Value.ToString().Trim();
            khachhang.SoCMND = dgvKhach_DanhSach.Rows[dgvKhach_DanhSach.CurrentRow.Index].Cells[5].Value.ToString().Trim();
            khachhang.Email = dgvKhach_DanhSach.Rows[dgvKhach_DanhSach.CurrentRow.Index].Cells[6].Value.ToString().Trim();


            frmKhach_Update frmKhach_Update = new frmKhach_Update(this, khachhang);
            frmKhach_Update.ShowDialog();
        }
        private void btnKhach_Xoa_Click(object sender, EventArgs e)
        {
            String rowID = dgvKhach_DanhSach.Rows[dgvKhach_DanhSach.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn xóa khách có mã  " + rowID + "", "Xóa khách hàng",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.Khach_Xoa(rowID);
                frmMain_Update();
            }
        }

        private void btnKhach_Thoat_Click(object sender, EventArgs e)
        {
            //tabControlMain.SelectTab(tabPageTrangChu);
        }
       
      
        private void nbiDSPN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TabPage tabPageDSPN = new TabPage();
            tabPageDSPN.Text = "Danh sách nhập hàng";
            UDanhSachPN dsnh = new UDanhSachPN();
            dsnh.Dock = DockStyle.Fill;
            tabPageDSPN.Controls.Add(dsnh);
            tabControlMain.TabPages.Add(tabPageDSPN);
            tabControlMain.SelectTab(tabPageDSPN);
        }

        private void nbiDSPX_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TabPage tabPageDSPX = new TabPage();
            tabPageDSPX.Text = "Danh sách xuất hàng";
            uDanhSachHD dsPX = new uDanhSachHD();
            dsPX.Dock = DockStyle.Fill;
            tabPageDSPX.Controls.Add(dsPX);
            tabControlMain.TabPages.Add(tabPageDSPX);
            tabControlMain.SelectTab(tabPageDSPX);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbbtimkiemhanghoa.Text.Equals("Tìm kiếm theo tên hàng hóa"))
                if (txttukhoa.Text != "    Nhập từ khóa")
                    dgrtimkiemhanghoa.DataSource = da.Query("ProcTimKiemTheoTen", new SqlParameter("@ten", txttukhoa.Text));
                else
                    MessageBox.Show("Vui lòng chọn kho");
            else if (cbbtimkiemhanghoa.Text.Equals("Tìm kiếm theo tên số lượng"))
                if (txttukhoa.Text != "    Nhập từ khóa")
                    dgrtimkiemhanghoa.DataSource = da.Query("ProcTimKiemTheoSoLuong", new SqlParameter("@soluong", txttukhoa.Text));
                else
                    MessageBox.Show("Vui lòng nhập từ khóa");
            else if (cbbtimkiemhanghoa.Text.Equals("Tìm kiếm theo nơi sản xuất"))
                if (txttukhoa.Text != "    Nhập từ khóa")
                    dgrtimkiemhanghoa.DataSource = da.Query("ProcTimKiemTheoNoiSanXuat", new SqlParameter("@noisanxuat", txttukhoa.Text));
                else
                    MessageBox.Show("Vui lòng nhập từ khóa");
            else if (cbbtimkiemhanghoa.Text.Equals("Tìm kiếm theo ngày sản xuất"))
                if (txttukhoa.Text != "    Nhập từ khóa")
                    dgrtimkiemhanghoa.DataSource = da.Query("ProcTimKiemTheoNgaySanXuat", new SqlParameter("@ngaysanxuat", txttukhoa.Text));
                else
                    MessageBox.Show("Vui lòng nhập từ khóa");
            else if (cbbtimkiemhanghoa.Text.Equals("Tìm kiếm theo kho"))
                if (txttukhoa.Text != "    Nhập từ khóa")
                    dgrtimkiemhanghoa.DataSource = da.Query("ProcTimKiemTheoKhoMa", new SqlParameter("@khoma", txttukhoa.Text));
                else
                    MessageBox.Show("Vui lòng nhập từ khóa");
            else if (cbbtimkiemhanghoa.Text.Equals("Tìm kiếm theo hạn sử dụng"))
                if (txttukhoa.Text != "    Nhập từ khóa")
                    dgrtimkiemhanghoa.DataSource = da.Query("ProcTimKiemTheoHanSuDung", new SqlParameter("@hansudung", txttukhoa.Text));
                else
                    MessageBox.Show("Vui lòng nhập từ khóa");
            else if (cbbtimkiemhanghoa.Text.Equals("Tìm kiếm theo đơn giá"))
                if (txttukhoa.Text != "    Nhập từ khóa")
                    dgrtimkiemhanghoa.DataSource = da.Query("ProcTimKiemTheoDongia", new SqlParameter("@dongia", txttukhoa.Text));
                else
                    MessageBox.Show("Vui lòng nhập từ khóa");

            else
                MessageBox.Show("Vui lòng chọn từ khóa tìm kiếm");

            
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            if (cbbthongke.Text.Equals("Thống kê lượng hàng hóa nhập vào"))
                if (cbbkhoma.Text != "     --- Chọn kho---")
                    dgrthongkehanghoa.DataSource = da.Query("[ThongKeHangHoaNhapVao]", new SqlParameter("@khoma", cbbkhoma.Text));
                else
                    MessageBox.Show("Vui lòng chọn kho");
            else if (cbbthongke.Text.Equals("Thống kê lượng hàng hóa bán ra"))
                if (cbbkhoma.Text != "     --- Chọn kho---")
                    dgrthongkehanghoa.DataSource = da.Query("ThongKeHangHoaBanRa", new SqlParameter("@khoma", cbbkhoma.Text));
                else
                    MessageBox.Show("Vui lòng chọn kho");
            else
                MessageBox.Show("Vui lòng chọn cách thống kê");
        }

        private void cbbkhoma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPageThongKe_Click(object sender, EventArgs e)
        {

        }

        private void txttukhoa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttukhoa_MouseClick(object sender, MouseEventArgs e)
        {
            txttukhoa.Text = "";
        }

        private void nvbiPx_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            TabPage tabPageXuatHang = new TabPage();
            tabPageXuatHang.Text = "Xuất hàng";
            UPhieuXuat px = new UPhieuXuat();
            px.Dock = DockStyle.Fill;
            tabPageXuatHang.Controls.Add(px);
            tabControlMain.TabPages.Add(tabPageXuatHang);
            tabControlMain.SelectTab(tabPageXuatHang);
        }
    }
}
