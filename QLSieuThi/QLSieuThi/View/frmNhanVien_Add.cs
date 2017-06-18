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
    public partial class frmNhanVien_Add : Form
    {
        private Controller control;
        private frmMain frmMain;
        public frmNhanVien_Add()
        {
            InitializeComponent();
            control = new Controller();
            frmMain = new frmMain();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Double luong = 0;
            if (isCheckAdd())
            {
                NhanVien nv = new NhanVien();
                nv.Ten = txtten.Text.ToString().Trim();
                nv.NgaySinh = DateTime.Parse(dtpngaysinh.Value.ToShortDateString());
                if (rdbnam.Checked) nv.GioiTinh = 1;
                else nv.GioiTinh = 0;
                nv.DiaChi = txtdiachi.Text.ToString().Trim();
                if(Double.TryParse(txtLuong.Text.ToString().Trim(), out luong))
                {
                    nv.Luong = luong;
                }
                
                nv.PhongBanMa = txtPhongBan.Text.ToString().Trim();
                nv.MatKhau = txtMatKhau.Text.ToString().Trim();
                nv.SoDienThoai = txtdienthoai.Text.ToString().Trim();
                if (control.NhanVien_Them(nv))
                {
                    this.Close();
                    this.frmMain.Visible = true;
                    this.frmMain.frmMain_Update();
                }
            }
        }
        private bool isCheckAdd()
        {
            if (txtten.Text.Trim().Equals(""))
            {
                erpHoTen.SetError(txtten, "Phải nhập Họ tên ");
                return false;
            }
            erpHoTen.Clear();
            if (txtdiachi.Text.Trim().Equals(""))
            {
                erpDiaChi.SetError(txtdiachi, "Phải nhập địa chỉ");
                return false;
            }
            erpDiaChi.Clear();
            if (txtLuong.Text.Trim().Equals(""))
            {
                erpDienThoai.SetError(txtLuong, "Phải nhập số điện thoại");
                return false;
            }
            erpLuong.Clear();
            if (txtdienthoai.Text.Trim().Equals(""))
            {
                erpLuong.SetError(txtdienthoai, "Phải nhập lương");
                return false;
            }
            erpLuong.Clear();
            if (txtdienthoai.Text.Trim().Equals(""))
            {
                erpPhongBan.SetError(txtdienthoai, "Phải nhập phòng ban");
                return false;
            }
            erpPhongBan.Clear();
            if (txtdienthoai.Text.Trim().Equals(""))
            {
                erpMatKhau.SetError(txtdienthoai, "Phải nhập mật khẩu");
                return false;
            }
            erpMatKhau.Clear();
            return true;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
