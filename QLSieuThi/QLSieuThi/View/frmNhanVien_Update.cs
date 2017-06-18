using QLSieuThi.Controllers;
using QLSieuThi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThi.View
{
    public partial class frmNhanVien_Update : Form
    {
        private NhanVien nhanvien;
        private Controller control;
        private frmMain frmMain;
        public frmNhanVien_Update()
        {
            InitializeComponent();
            nhanvien = new NhanVien();
            this.control = new Controller();
            this.frmMain = new frmMain();
        }
        public frmNhanVien_Update(frmMain frmMain, NhanVien nv)
        {
            InitializeComponent();
            this.nhanvien = nv;
            this.frmMain = frmMain;
            this.control = new Controller();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nhanvien.Ten = txtten.Text.ToString().Trim();
            if (rbdnu.Checked) nhanvien.GioiTinh = 0;
            else nhanvien.GioiTinh = 1;
            nhanvien.NgaySinh = dtpngaysinh.Value;
            nhanvien.SoDienThoai = txtdienthoai.Text;
            nhanvien.DiaChi = txtdiachi.Text;
            Double luong = 0;
            if (Double.TryParse(txtLuong.Text.ToString().Trim(), out luong))
            {
                nhanvien.Luong = luong;
            }
            nhanvien.PhongBanMa = txtPhongBan.Text.ToString().Trim();
            nhanvien.MatKhau = txtMatKhau.Text.ToString().Trim();


            if (control.NhanVien_Sua(nhanvien))
            {
                this.Close();
                this.frmMain.frmMain_Update();
                this.frmMain.Visible = true;  
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.frmMain.Visible = true;
        }

        private void frmNhanVien_Update_Load(object sender, EventArgs e)
        {
            txtten.Text = nhanvien.Ten;
            if (nhanvien.GioiTinh == 0) rbdnu.Checked = true;
            else rdbnam.Checked = true;
            txtdiachi.Text = nhanvien.DiaChi;
            dtpngaysinh.Text = nhanvien.NgaySinh.ToShortDateString();
            txtdienthoai.Text = nhanvien.SoDienThoai;
            txtLuong.Text = nhanvien.Luong.ToString();
            txtPhongBan.Text = nhanvien.PhongBanMa;
            txtMatKhau.Text = nhanvien.MatKhau;
            txtma.Text = nhanvien.Ma;
        }

        private void frmNhanVien_Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmMain.Visible = true;
        }
    }
}
