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
    public partial class frmKhach_Update : Form
    {
        private KhachHang khachHang;
        private Controller control;
        private frmMain frmMain;
        public frmKhach_Update()
        {
            InitializeComponent();
            khachHang = new KhachHang();
            this.control = new Controller();
            this.frmMain = new frmMain();
        }
        public frmKhach_Update(frmMain frmMain, KhachHang nv)
        {
            InitializeComponent();
            this.khachHang = nv;
            this.frmMain = frmMain;
            this.control = new Controller();
        }

        private void frmKhach_Update_Load(object sender, EventArgs e)
        {
            txtten.Text = khachHang.Ten;
            if (khachHang.GioiTinh == 0) rbdnu.Checked = true;
            else rdbnam.Checked = true;
            txtdiachi.Text = khachHang.DiaChi;
            txtdienthoai.Text = khachHang.SoDienThoai;
            txtEmail.Text = khachHang.Email;
            txtma.Text = khachHang.Ma;
            txtSoCMND.Text = khachHang.SoCMND;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            khachHang.Ten = txtten.Text.ToString().Trim();
            if (rbdnu.Checked) khachHang.GioiTinh = 0;
            else khachHang.GioiTinh = 1;

            khachHang.SoDienThoai = txtdienthoai.Text;
            khachHang.DiaChi = txtdiachi.Text;

            khachHang.Email = txtEmail.Text.ToString().Trim();
            khachHang.SoCMND = txtSoCMND.Text.ToString().Trim();

            if (control.KhachHang_Sua(khachHang))
            {
                this.Close();
                this.frmMain.frmMain_Update();
                this.frmMain.Visible = true;
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain.Visible = true;
        }

    }
}
