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
            tabPhieuXuatload();
        }
        private Controller controller = new Controller();
        DataTable dt = new DataTable();
        private void tabPhieuXuatload()
        {

            dt.Columns.Add("mã hàng", typeof(string));
            dt.Columns.Add("số lượng", typeof(string));
            dt.Columns.Add("đơn vị", typeof(string));
           

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
            cbbPNKhoHang.DataSource = controller.getList_KhoHang();
            cbbPNKhoHang.DisplayMember = "ten";
            cbbPNKhoHang.ValueMember = "ma";
            cbbPNDonVi.DataSource = controller.getList_DonVi();
            cbbPNDonVi.DisplayMember = "ten";
            cbbPNDonVi.ValueMember = "ma";
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
                 
                    ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                    ctpx.HangHoaMa = cbbPXMaHang.Text.ToString().Trim();
                    ctpx.soluong = int.Parse(txtPXSoLuong.Text.ToString().Trim());
                    ctpx.donvi = cbbPNDonVi.Text.ToString().Trim();
                    ctpx.DonViQuyDoiMa = cbbPNDonVi.SelectedValue.ToString().Trim();
                    //ctpx.DonGia = dongia;
                    dtgPXMuaHang.DataSource = dt;
                    hesoquydoi = controller.getHeSoQuyDoi(ctpx.DonViQuyDoiMa);                
                  
                        thanhtien = soluong * hesoquydoi * dongia ;
                 
                    
                    dt.Rows.Add(ctpx.HangHoaMa, ctpx.soluong.ToString(), ctpx.donvi);
                    tongtienpx += thanhtien;
                }
            }
           
        }
        private bool checkpx()
        {
            if (cbbPXMaNhanVien.Text.ToString().Trim().Equals(""))
            {
                errPXMaNV.SetError(cbbPXMaNhanVien, "nhap nhan vien");
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
                errPNNoidung.SetError(txtPXSoLuong, "nhap ten hang");
                return false;
            }
            errPNNoidung.Clear();
            return true;
        }
        private void cbbPXMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtPXTenHang.Text = controller.getTenHang(cbbPXMaHang.Text.ToString().Trim());           
           
        }

        private void btnPXLuu_Click(object sender, EventArgs e)
        {
            PhieuXuat px = new PhieuXuat();
            px.Ma = controller.get_PXma(px);       
            
            controller.insertPX(px);
            int hesoquydoi = 0;
            ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
            foreach (DataRow row in dt.Rows)
            {

                ctpx.HangHoaMa = row[0].ToString();
                ctpx.soluong = int.Parse(row[1].ToString());
                ctpx.donvi = row[2].ToString().Trim();                           
                controller.insertChiTietPX(ctpx, px.Ma);
            }

            MessageBox.Show("Đã lưu hóa đơn!");
        }
    }
    }

