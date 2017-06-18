namespace QLSieuThi
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgTrangChu = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiTrangChu = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTrangChu_NhapHang = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDSPN = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTrangChu_BanHang = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDSPX = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTrangChu_QLNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTrangChu_QLKhach = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTrangChu_ThongKe = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTrangChu_HuongDan = new DevExpress.XtraNavBar.NavBarItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageQLNhanVien = new System.Windows.Forms.TabPage();
            this.btnNhanVien_Thoat = new System.Windows.Forms.Button();
            this.btnNhanVien_Xoa = new System.Windows.Forms.Button();
            this.btnNhanVien_Sua = new System.Windows.Forms.Button();
            this.btnNhanVien_Them = new System.Windows.Forms.Button();
            this.dgvNhanVien_DanhSach = new System.Windows.Forms.DataGridView();
            this.tabPageKhach = new System.Windows.Forms.TabPage();
            this.btnKhach_Thoat = new System.Windows.Forms.Button();
            this.btnKhach_Xoa = new System.Windows.Forms.Button();
            this.btnKhach_Sua = new System.Windows.Forms.Button();
            this.btnKhach_Them = new System.Windows.Forms.Button();
            this.dgvKhach_DanhSach = new System.Windows.Forms.DataGridView();
            this.tabPageThongKe = new System.Windows.Forms.TabPage();
            this.cbbkhoma = new System.Windows.Forms.ComboBox();
            this.cbbthongke = new System.Windows.Forms.ComboBox();
            this.btnthongke = new System.Windows.Forms.Button();
            this.dgrthongkehanghoa = new System.Windows.Forms.DataGridView();
            this.tptimkiem = new System.Windows.Forms.TabPage();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.dgrtimkiemhanghoa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cbbtimkiemhanghoa = new System.Windows.Forms.ComboBox();
            this.tphuongdan = new System.Windows.Forms.TabPage();
            this.rtbhuongdan1 = new System.Windows.Forms.RichTextBox();
            this.errPNNguoiGiao = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPNKhoMa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPNNoidung = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPNSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPXMaNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errpxKhachHang = new System.Windows.Forms.ErrorProvider(this.components);
            this.nvbiPhieuXuat = new DevExpress.XtraNavBar.NavBarItem();
            this.nvbiPx = new DevExpress.XtraNavBar.NavBarItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageQLNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien_DanhSach)).BeginInit();
            this.tabPageKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach_DanhSach)).BeginInit();
            this.tabPageThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrthongkehanghoa)).BeginInit();
            this.tptimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrtimkiemhanghoa)).BeginInit();
            this.tphuongdan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPNNguoiGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPNKhoMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPNNoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPNSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPXMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpxKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.navBarControl1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 658);
            this.panel1.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgTrangChu;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgTrangChu});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiTrangChu_HuongDan,
            this.nbiTrangChu,
            this.nbiTrangChu_NhapHang,
            this.nbiTrangChu_BanHang,
            this.nvbiPx,
            this.nbiTrangChu_QLNhanVien,
            this.nbiTrangChu_QLKhach,
            this.nbiTrangChu_ThongKe,
            this.nbiDSPN,
            this.nbiDSPX});
            this.navBarControl1.Location = new System.Drawing.Point(4, 10);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 508);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // nbgTrangChu
            // 
            this.nbgTrangChu.Caption = "Trang chủ";
            this.nbgTrangChu.Expanded = true;
            this.nbgTrangChu.ImageUri.Uri = "Home";
            this.nbgTrangChu.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTrangChu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTrangChu_NhapHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDSPN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTrangChu_BanHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDSPX),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTrangChu_QLNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTrangChu_QLKhach),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTrangChu_ThongKe),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTrangChu_HuongDan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvbiPx)});
            this.nbgTrangChu.Name = "nbgTrangChu";
            // 
            // nbiTrangChu
            // 
            this.nbiTrangChu.Caption = "Trang chủ";
            this.nbiTrangChu.ImageUri.Uri = "Home";
            this.nbiTrangChu.Name = "nbiTrangChu";
            this.nbiTrangChu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTrangChu_LinkClicked);
            // 
            // nbiTrangChu_NhapHang
            // 
            this.nbiTrangChu_NhapHang.Caption = "Nhập hàng";
            this.nbiTrangChu_NhapHang.ImageUri.Uri = "AddNewDataSource";
            this.nbiTrangChu_NhapHang.Name = "nbiTrangChu_NhapHang";
            this.nbiTrangChu_NhapHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTrangChu_NhapHang_LinkClicked);
            // 
            // nbiDSPN
            // 
            this.nbiDSPN.Caption = "Danh sách phiếu nhập";
            this.nbiDSPN.Name = "nbiDSPN";
            this.nbiDSPN.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDSPN.SmallImage")));
            this.nbiDSPN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDSPN_LinkClicked);
            // 
            // nbiTrangChu_BanHang
            // 
            this.nbiTrangChu_BanHang.Caption = "Bán hàng";
            this.nbiTrangChu_BanHang.ImageUri.Uri = "DeleteDataSource";
            this.nbiTrangChu_BanHang.Name = "nbiTrangChu_BanHang";
            this.nbiTrangChu_BanHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTrangChu_BanHang_LinkClicked);
            // 
            // nbiDSPX
            // 
            this.nbiDSPX.Caption = "Danh sách phiếu xuất";
            this.nbiDSPX.Name = "nbiDSPX";
            this.nbiDSPX.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDSPX.SmallImage")));
            this.nbiDSPX.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDSPX_LinkClicked);
            // 
            // nbiTrangChu_QLNhanVien
            // 
            this.nbiTrangChu_QLNhanVien.Caption = "QL Nhân viên";
            this.nbiTrangChu_QLNhanVien.Name = "nbiTrangChu_QLNhanVien";
            this.nbiTrangChu_QLNhanVien.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiTrangChu_QLNhanVien.SmallImage")));
            this.nbiTrangChu_QLNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTrangChu_QLNhanVien_LinkClicked);
            // 
            // nbiTrangChu_QLKhach
            // 
            this.nbiTrangChu_QLKhach.Caption = "QL Khách";
            this.nbiTrangChu_QLKhach.Name = "nbiTrangChu_QLKhach";
            this.nbiTrangChu_QLKhach.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiTrangChu_QLKhach.SmallImage")));
            this.nbiTrangChu_QLKhach.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTrangChu_QLKhach_LinkClicked);
            // 
            // nbiTrangChu_ThongKe
            // 
            this.nbiTrangChu_ThongKe.Caption = "Thống kê";
            this.nbiTrangChu_ThongKe.ImageUri.Uri = "Chart";
            this.nbiTrangChu_ThongKe.Name = "nbiTrangChu_ThongKe";
            this.nbiTrangChu_ThongKe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTrangChu_ThongKe_LinkClicked);
            // 
            // nbiTrangChu_HuongDan
            // 
            this.nbiTrangChu_HuongDan.Caption = "Hướng dẫn";
            this.nbiTrangChu_HuongDan.ImageUri.Uri = "InLineWithText";
            this.nbiTrangChu_HuongDan.Name = "nbiTrangChu_HuongDan";
            this.nbiTrangChu_HuongDan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTrangChu_HuongDan_LinkClicked);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageQLNhanVien);
            this.tabControlMain.Controls.Add(this.tabPageKhach);
            this.tabControlMain.Controls.Add(this.tabPageThongKe);
            this.tabControlMain.Controls.Add(this.tptimkiem);
            this.tabControlMain.Controls.Add(this.tphuongdan);
            this.tabControlMain.Location = new System.Drawing.Point(153, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1133, 658);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageQLNhanVien
            // 
            this.tabPageQLNhanVien.Controls.Add(this.btnNhanVien_Thoat);
            this.tabPageQLNhanVien.Controls.Add(this.btnNhanVien_Xoa);
            this.tabPageQLNhanVien.Controls.Add(this.btnNhanVien_Sua);
            this.tabPageQLNhanVien.Controls.Add(this.btnNhanVien_Them);
            this.tabPageQLNhanVien.Controls.Add(this.dgvNhanVien_DanhSach);
            this.tabPageQLNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabPageQLNhanVien.Name = "tabPageQLNhanVien";
            this.tabPageQLNhanVien.Size = new System.Drawing.Size(1125, 632);
            this.tabPageQLNhanVien.TabIndex = 3;
            this.tabPageQLNhanVien.Text = "QL Nhân viên";
            this.tabPageQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien_Thoat
            // 
            this.btnNhanVien_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNhanVien_Thoat.FlatAppearance.BorderSize = 0;
            this.btnNhanVien_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien_Thoat.Location = new System.Drawing.Point(1018, 576);
            this.btnNhanVien_Thoat.Name = "btnNhanVien_Thoat";
            this.btnNhanVien_Thoat.Size = new System.Drawing.Size(96, 32);
            this.btnNhanVien_Thoat.TabIndex = 1;
            this.btnNhanVien_Thoat.Text = "Thoát";
            this.btnNhanVien_Thoat.UseVisualStyleBackColor = false;
            this.btnNhanVien_Thoat.Click += new System.EventHandler(this.btnNhanVien_Thoat_Click);
            // 
            // btnNhanVien_Xoa
            // 
            this.btnNhanVien_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNhanVien_Xoa.FlatAppearance.BorderSize = 0;
            this.btnNhanVien_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien_Xoa.Location = new System.Drawing.Point(888, 576);
            this.btnNhanVien_Xoa.Name = "btnNhanVien_Xoa";
            this.btnNhanVien_Xoa.Size = new System.Drawing.Size(96, 32);
            this.btnNhanVien_Xoa.TabIndex = 1;
            this.btnNhanVien_Xoa.Text = "Xóa";
            this.btnNhanVien_Xoa.UseVisualStyleBackColor = false;
            this.btnNhanVien_Xoa.Click += new System.EventHandler(this.btnNhanVien_Xoa_Click);
            // 
            // btnNhanVien_Sua
            // 
            this.btnNhanVien_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNhanVien_Sua.FlatAppearance.BorderSize = 0;
            this.btnNhanVien_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien_Sua.Location = new System.Drawing.Point(758, 576);
            this.btnNhanVien_Sua.Name = "btnNhanVien_Sua";
            this.btnNhanVien_Sua.Size = new System.Drawing.Size(96, 32);
            this.btnNhanVien_Sua.TabIndex = 1;
            this.btnNhanVien_Sua.Text = "Sửa";
            this.btnNhanVien_Sua.UseVisualStyleBackColor = false;
            this.btnNhanVien_Sua.Click += new System.EventHandler(this.btnNhanVien_Sua_Click);
            // 
            // btnNhanVien_Them
            // 
            this.btnNhanVien_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNhanVien_Them.FlatAppearance.BorderSize = 0;
            this.btnNhanVien_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien_Them.Location = new System.Drawing.Point(628, 576);
            this.btnNhanVien_Them.Name = "btnNhanVien_Them";
            this.btnNhanVien_Them.Size = new System.Drawing.Size(96, 32);
            this.btnNhanVien_Them.TabIndex = 1;
            this.btnNhanVien_Them.Text = "Thêm";
            this.btnNhanVien_Them.UseVisualStyleBackColor = false;
            this.btnNhanVien_Them.Click += new System.EventHandler(this.btnNhanVien_Them_Click);
            // 
            // dgvNhanVien_DanhSach
            // 
            this.dgvNhanVien_DanhSach.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvNhanVien_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien_DanhSach.Location = new System.Drawing.Point(-5, 0);
            this.dgvNhanVien_DanhSach.Name = "dgvNhanVien_DanhSach";
            this.dgvNhanVien_DanhSach.ReadOnly = true;
            this.dgvNhanVien_DanhSach.RowHeadersWidth = 42;
            this.dgvNhanVien_DanhSach.Size = new System.Drawing.Size(1127, 552);
            this.dgvNhanVien_DanhSach.TabIndex = 0;
            this.dgvNhanVien_DanhSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_DanhSach_CellDoubleClick);
            // 
            // tabPageKhach
            // 
            this.tabPageKhach.Controls.Add(this.btnKhach_Thoat);
            this.tabPageKhach.Controls.Add(this.btnKhach_Xoa);
            this.tabPageKhach.Controls.Add(this.btnKhach_Sua);
            this.tabPageKhach.Controls.Add(this.btnKhach_Them);
            this.tabPageKhach.Controls.Add(this.dgvKhach_DanhSach);
            this.tabPageKhach.Location = new System.Drawing.Point(4, 22);
            this.tabPageKhach.Name = "tabPageKhach";
            this.tabPageKhach.Size = new System.Drawing.Size(1125, 632);
            this.tabPageKhach.TabIndex = 4;
            this.tabPageKhach.Text = "QL Khách";
            this.tabPageKhach.UseVisualStyleBackColor = true;
            // 
            // btnKhach_Thoat
            // 
            this.btnKhach_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKhach_Thoat.FlatAppearance.BorderSize = 0;
            this.btnKhach_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhach_Thoat.Location = new System.Drawing.Point(985, 579);
            this.btnKhach_Thoat.Name = "btnKhach_Thoat";
            this.btnKhach_Thoat.Size = new System.Drawing.Size(96, 32);
            this.btnKhach_Thoat.TabIndex = 2;
            this.btnKhach_Thoat.Text = "Thoát";
            this.btnKhach_Thoat.UseVisualStyleBackColor = false;
            this.btnKhach_Thoat.Click += new System.EventHandler(this.btnKhach_Thoat_Click);
            // 
            // btnKhach_Xoa
            // 
            this.btnKhach_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKhach_Xoa.FlatAppearance.BorderSize = 0;
            this.btnKhach_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhach_Xoa.Location = new System.Drawing.Point(855, 579);
            this.btnKhach_Xoa.Name = "btnKhach_Xoa";
            this.btnKhach_Xoa.Size = new System.Drawing.Size(96, 32);
            this.btnKhach_Xoa.TabIndex = 3;
            this.btnKhach_Xoa.Text = "Xóa";
            this.btnKhach_Xoa.UseVisualStyleBackColor = false;
            this.btnKhach_Xoa.Click += new System.EventHandler(this.btnKhach_Xoa_Click);
            // 
            // btnKhach_Sua
            // 
            this.btnKhach_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKhach_Sua.FlatAppearance.BorderSize = 0;
            this.btnKhach_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhach_Sua.Location = new System.Drawing.Point(725, 579);
            this.btnKhach_Sua.Name = "btnKhach_Sua";
            this.btnKhach_Sua.Size = new System.Drawing.Size(96, 32);
            this.btnKhach_Sua.TabIndex = 4;
            this.btnKhach_Sua.Text = "Sửa";
            this.btnKhach_Sua.UseVisualStyleBackColor = false;
            this.btnKhach_Sua.Click += new System.EventHandler(this.btnKhach_Sua_Click);
            // 
            // btnKhach_Them
            // 
            this.btnKhach_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKhach_Them.FlatAppearance.BorderSize = 0;
            this.btnKhach_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhach_Them.Location = new System.Drawing.Point(595, 579);
            this.btnKhach_Them.Name = "btnKhach_Them";
            this.btnKhach_Them.Size = new System.Drawing.Size(96, 32);
            this.btnKhach_Them.TabIndex = 5;
            this.btnKhach_Them.Text = "Thêm";
            this.btnKhach_Them.UseVisualStyleBackColor = false;
            this.btnKhach_Them.Click += new System.EventHandler(this.btnKhach_Them_Click);
            // 
            // dgvKhach_DanhSach
            // 
            this.dgvKhach_DanhSach.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvKhach_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach_DanhSach.Location = new System.Drawing.Point(-4, 0);
            this.dgvKhach_DanhSach.Name = "dgvKhach_DanhSach";
            this.dgvKhach_DanhSach.ReadOnly = true;
            this.dgvKhach_DanhSach.RowHeadersWidth = 42;
            this.dgvKhach_DanhSach.Size = new System.Drawing.Size(1129, 549);
            this.dgvKhach_DanhSach.TabIndex = 1;
            // 
            // tabPageThongKe
            // 
            this.tabPageThongKe.Controls.Add(this.cbbkhoma);
            this.tabPageThongKe.Controls.Add(this.cbbthongke);
            this.tabPageThongKe.Controls.Add(this.btnthongke);
            this.tabPageThongKe.Controls.Add(this.dgrthongkehanghoa);
            this.tabPageThongKe.Location = new System.Drawing.Point(4, 22);
            this.tabPageThongKe.Name = "tabPageThongKe";
            this.tabPageThongKe.Size = new System.Drawing.Size(1125, 632);
            this.tabPageThongKe.TabIndex = 5;
            this.tabPageThongKe.Text = "Thống kê";
            this.tabPageThongKe.UseVisualStyleBackColor = true;
            this.tabPageThongKe.Click += new System.EventHandler(this.tabPageThongKe_Click);
            // 
            // cbbkhoma
            // 
            this.cbbkhoma.FormattingEnabled = true;
            this.cbbkhoma.Location = new System.Drawing.Point(341, 55);
            this.cbbkhoma.Name = "cbbkhoma";
            this.cbbkhoma.Size = new System.Drawing.Size(141, 21);
            this.cbbkhoma.TabIndex = 8;
            this.cbbkhoma.Text = "     --- Chọn kho---";
            this.cbbkhoma.SelectedIndexChanged += new System.EventHandler(this.cbbkhoma_SelectedIndexChanged);
            // 
            // cbbthongke
            // 
            this.cbbthongke.FormattingEnabled = true;
            this.cbbthongke.Location = new System.Drawing.Point(136, 54);
            this.cbbthongke.Name = "cbbthongke";
            this.cbbthongke.Size = new System.Drawing.Size(187, 21);
            this.cbbthongke.TabIndex = 7;
            this.cbbthongke.Text = "            --- Thống kê---";
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(34, 54);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(75, 23);
            this.btnthongke.TabIndex = 6;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // dgrthongkehanghoa
            // 
            this.dgrthongkehanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrthongkehanghoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrthongkehanghoa.Location = new System.Drawing.Point(0, 179);
            this.dgrthongkehanghoa.Name = "dgrthongkehanghoa";
            this.dgrthongkehanghoa.Size = new System.Drawing.Size(1125, 453);
            this.dgrthongkehanghoa.TabIndex = 0;
            // 
            // tptimkiem
            // 
            this.tptimkiem.Controls.Add(this.txttukhoa);
            this.tptimkiem.Controls.Add(this.dgrtimkiemhanghoa);
            this.tptimkiem.Controls.Add(this.label3);
            this.tptimkiem.Controls.Add(this.btntimkiem);
            this.tptimkiem.Controls.Add(this.cbbtimkiemhanghoa);
            this.tptimkiem.Location = new System.Drawing.Point(4, 22);
            this.tptimkiem.Name = "tptimkiem";
            this.tptimkiem.Padding = new System.Windows.Forms.Padding(3);
            this.tptimkiem.Size = new System.Drawing.Size(1125, 632);
            this.tptimkiem.TabIndex = 7;
            this.tptimkiem.Text = "Tìm kiếm";
            this.tptimkiem.UseVisualStyleBackColor = true;
            // 
            // txttukhoa
            // 
            this.txttukhoa.Location = new System.Drawing.Point(370, 54);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(134, 20);
            this.txttukhoa.TabIndex = 10;
            this.txttukhoa.Text = "    Nhập từ khóa";
            this.txttukhoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttukhoa_MouseClick);
            this.txttukhoa.TextChanged += new System.EventHandler(this.txttukhoa_TextChanged);
            // 
            // dgrtimkiemhanghoa
            // 
            this.dgrtimkiemhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrtimkiemhanghoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrtimkiemhanghoa.Location = new System.Drawing.Point(3, 157);
            this.dgrtimkiemhanghoa.Name = "dgrtimkiemhanghoa";
            this.dgrtimkiemhanghoa.Size = new System.Drawing.Size(1119, 472);
            this.dgrtimkiemhanghoa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách hàng hóa";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(55, 54);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // cbbtimkiemhanghoa
            // 
            this.cbbtimkiemhanghoa.FormattingEnabled = true;
            this.cbbtimkiemhanghoa.Location = new System.Drawing.Point(167, 54);
            this.cbbtimkiemhanghoa.Name = "cbbtimkiemhanghoa";
            this.cbbtimkiemhanghoa.Size = new System.Drawing.Size(169, 21);
            this.cbbtimkiemhanghoa.TabIndex = 6;
            this.cbbtimkiemhanghoa.Text = "     --- Tìm kiếm theo---";
            // 
            // tphuongdan
            // 
            this.tphuongdan.Controls.Add(this.rtbhuongdan1);
            this.tphuongdan.Location = new System.Drawing.Point(4, 22);
            this.tphuongdan.Name = "tphuongdan";
            this.tphuongdan.Padding = new System.Windows.Forms.Padding(3);
            this.tphuongdan.Size = new System.Drawing.Size(1125, 632);
            this.tphuongdan.TabIndex = 8;
            this.tphuongdan.Text = "Hướng dẫn";
            this.tphuongdan.UseVisualStyleBackColor = true;
            // 
            // rtbhuongdan1
            // 
            this.rtbhuongdan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbhuongdan1.Location = new System.Drawing.Point(3, 3);
            this.rtbhuongdan1.Name = "rtbhuongdan1";
            this.rtbhuongdan1.Size = new System.Drawing.Size(1119, 626);
            this.rtbhuongdan1.TabIndex = 0;
            this.rtbhuongdan1.Text = "";
            // 
            // errPNNguoiGiao
            // 
            this.errPNNguoiGiao.ContainerControl = this;
            // 
            // errPNKhoMa
            // 
            this.errPNKhoMa.ContainerControl = this;
            // 
            // errPNNoidung
            // 
            this.errPNNoidung.ContainerControl = this;
            // 
            // errPNSoLuong
            // 
            this.errPNSoLuong.ContainerControl = this;
            // 
            // errTenHang
            // 
            this.errTenHang.ContainerControl = this;
            // 
            // errPXMaNV
            // 
            this.errPXMaNV.ContainerControl = this;
            // 
            // errpxKhachHang
            // 
            this.errpxKhachHang.ContainerControl = this;
            // 
            // nvbiPhieuXuat
            // 
            this.nvbiPhieuXuat.Caption = "Xuất kho";
            this.nvbiPhieuXuat.LargeImage = ((System.Drawing.Image)(resources.GetObject("nvbiPhieuXuat.LargeImage")));
            this.nvbiPhieuXuat.Name = "nvbiPhieuXuat";
            this.nvbiPhieuXuat.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbiPhieuXuat.SmallImage")));
            // 
            // nvbiPx
            // 
            this.nvbiPx.Caption = "Phiếu Xuất";
            this.nvbiPx.Name = "nvbiPx";
            this.nvbiPx.SmallImage = ((System.Drawing.Image)(resources.GetObject("nvbiPx.SmallImage")));
            this.nvbiPx.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvbiPx_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý siêu thị";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageQLNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien_DanhSach)).EndInit();
            this.tabPageKhach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach_DanhSach)).EndInit();
            this.tabPageThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrthongkehanghoa)).EndInit();
            this.tptimkiem.ResumeLayout(false);
            this.tptimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrtimkiemhanghoa)).EndInit();
            this.tphuongdan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errPNNguoiGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPNKhoMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPNNoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPNSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPXMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpxKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbgTrangChu;
        private DevExpress.XtraNavBar.NavBarItem nbiTrangChu;
        private DevExpress.XtraNavBar.NavBarItem nbiTrangChu_NhapHang;
        private DevExpress.XtraNavBar.NavBarItem nbiTrangChu_BanHang;
        private DevExpress.XtraNavBar.NavBarItem nbiTrangChu_QLNhanVien;
        private DevExpress.XtraNavBar.NavBarItem nbiTrangChu_QLKhach;
        private DevExpress.XtraNavBar.NavBarItem nbiTrangChu_ThongKe;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageQLNhanVien;
        private System.Windows.Forms.TabPage tabPageKhach;
        private System.Windows.Forms.TabPage tabPageThongKe;
        private DevExpress.XtraNavBar.NavBarItem nbiTrangChu_HuongDan;
        private System.Windows.Forms.Button btnNhanVien_Thoat;
        private System.Windows.Forms.Button btnNhanVien_Xoa;
        private System.Windows.Forms.Button btnNhanVien_Sua;
        private System.Windows.Forms.DataGridView dgvNhanVien_DanhSach;
        private System.Windows.Forms.Button btnNhanVien_Them;
        private System.Windows.Forms.Button btnKhach_Thoat;
        private System.Windows.Forms.Button btnKhach_Xoa;
        private System.Windows.Forms.Button btnKhach_Sua;
        private System.Windows.Forms.Button btnKhach_Them;
        private System.Windows.Forms.DataGridView dgvKhach_DanhSach;
        private System.Windows.Forms.ErrorProvider errPNNguoiGiao;
        private System.Windows.Forms.ErrorProvider errPNKhoMa;
        private System.Windows.Forms.ErrorProvider errPNNoidung;
        private System.Windows.Forms.ErrorProvider errPNSoLuong;
        private System.Windows.Forms.ErrorProvider errTenHang;
        private System.Windows.Forms.ErrorProvider errPXMaNV;
        private System.Windows.Forms.ErrorProvider errpxKhachHang;
        private DevExpress.XtraNavBar.NavBarItem nbiDSPN;
        private DevExpress.XtraNavBar.NavBarItem nbiDSPX;
        private System.Windows.Forms.ComboBox cbbkhoma;
        private System.Windows.Forms.ComboBox cbbthongke;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.DataGridView dgrthongkehanghoa;
        private System.Windows.Forms.TabPage tptimkiem;
        private System.Windows.Forms.DataGridView dgrtimkiemhanghoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ComboBox cbbtimkiemhanghoa;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.TabPage tphuongdan;
        private System.Windows.Forms.RichTextBox rtbhuongdan1;
        private DevExpress.XtraNavBar.NavBarItem nvbiPhieuXuat;
        private DevExpress.XtraNavBar.NavBarItem nvbiPx;
    }
}

