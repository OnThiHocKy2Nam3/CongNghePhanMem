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

namespace QLSieuThi
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tenDangNhap = txtTenDangNhap.Text.ToString().Trim();
            String matKhau = txtMatKhau.Text.ToString().Trim();
            if (isCheck(tenDangNhap, matKhau))
            {
                frmMain frmMain = new frmMain(this);
                this.Visible = false;
                frmMain.Visible = true;
            }
        }
        private bool isCheck(String tenDangNhap, String matKhau)
        {
            NhanVien nv = new NhanVien();
            if(tenDangNhap == "" || matKhau == "")
            {
                erpTenDangNhap.SetError(txtTenDangNhap, "Phải nhập mã nhân viên");
                erpMatKhau.SetError(txtMatKhau, "Phải nhập mật khẩu.");
                return false;
            }
            erpTenDangNhap.Clear();
            nv = (new Controller()).getNhanVien(tenDangNhap, matKhau);
            if(nv.Ma == "")
            {
                erpTenDangNhap.SetError(txtTenDangNhap, "Mã hoặc mật khẩu không chính xác");
                erpMatKhau.SetError(txtMatKhau, "Mật khẩu không chính xác.");
                return false;
            }
            erpTenDangNhap.Clear();

            return true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
