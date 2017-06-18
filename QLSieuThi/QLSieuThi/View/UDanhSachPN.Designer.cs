namespace QLSieuThi.View
{
    partial class UDanhSachPN
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dtgDSPhieuNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgChiTietPhieuNhap
            // 
            this.dtgChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietPhieuNhap.Location = new System.Drawing.Point(558, 28);
            this.dtgChiTietPhieuNhap.Name = "dtgChiTietPhieuNhap";
            this.dtgChiTietPhieuNhap.Size = new System.Drawing.Size(566, 602);
            this.dtgChiTietPhieuNhap.TabIndex = 4;
            // 
            // dtgDSPhieuNhap
            // 
            this.dtgDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSPhieuNhap.Location = new System.Drawing.Point(9, 28);
            this.dtgDSPhieuNhap.Name = "dtgDSPhieuNhap";
            this.dtgDSPhieuNhap.Size = new System.Drawing.Size(543, 602);
            this.dtgDSPhieuNhap.TabIndex = 3;
            this.dtgDSPhieuNhap.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDSPhieuNhap_RowHeaderMouseClick);
            // 
            // UDanhSachPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgChiTietPhieuNhap);
            this.Controls.Add(this.dtgDSPhieuNhap);
            this.Name = "UDanhSachPN";
            this.Size = new System.Drawing.Size(1133, 658);
            this.Load += new System.EventHandler(this.UDanhSachPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgChiTietPhieuNhap;
        private System.Windows.Forms.DataGridView dtgDSPhieuNhap;
    }
}
