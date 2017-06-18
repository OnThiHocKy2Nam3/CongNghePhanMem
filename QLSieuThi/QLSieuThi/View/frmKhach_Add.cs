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
    public partial class frmKhach_Add : Form
    {
        private Controller control;
        private frmMain frmMain;
        public frmKhach_Add()
        {
            InitializeComponent();
            this.control = new Controller();
            this.frmMain = new frmMain();
        }
        
        private void frmKhach_Add_Load(object sender, EventArgs e)
        {
            Double luong = 0;
            if (isCheckAdd())
            {
                KhachHang kh = new KhachHang();
                kh.Ten = txtten.Text.ToString().Trim();
                
                if (rdbnam.Checked) kh.GioiTinh = 1;
                else kh.GioiTinh = 0;
                kh.DiaChi = txtdiachi.Text.ToString().Trim();

                kh.SoDienThoai = txtdienthoai.Text.ToString().Trim();
                if (control.KhachHang_Them(kh))
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
            if (txtSoCMND.Text.Trim().Equals(""))
            {
                erpDienThoai.SetError(txtSoCMND, "Phải nhập số điện thoại");
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Double luong = 0;
            if (isCheckAdd())
            {
                KhachHang kh = new KhachHang();
                kh.Ten = txtten.Text.ToString().Trim();
                
                if (rdbnam.Checked) kh.GioiTinh = 1;
                else kh.GioiTinh = 0;
                kh.DiaChi = txtdiachi.Text.ToString().Trim();
                kh.Email = txtEmail.Text.ToString().Trim();
                kh.DiaChi = txtdiachi.Text.ToString().Trim();
                kh.SoCMND = txtSoCMND.Text.ToString().Trim();
                kh.SoDienThoai = txtdienthoai.Text.ToString().Trim();
                if (control.KhachHang_Them(kh))
                {
                    this.Close();
                    this.frmMain.frmMain_Update();
                    this.frmMain.Visible = true;
                    
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
