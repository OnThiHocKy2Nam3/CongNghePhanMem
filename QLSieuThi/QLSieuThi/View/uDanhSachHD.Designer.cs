namespace QLSieuThi.View
{
    partial class uDanhSachHD
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
            this.dtgDSCTPX = new System.Windows.Forms.DataGridView();
            this.dtgDSPX = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPX)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDSCTPX
            // 
            this.dtgDSCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSCTPX.Location = new System.Drawing.Point(532, 28);
            this.dtgDSCTPX.Name = "dtgDSCTPX";
            this.dtgDSCTPX.Size = new System.Drawing.Size(592, 602);
            this.dtgDSCTPX.TabIndex = 6;
            // 
            // dtgDSPX
            // 
            this.dtgDSPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSPX.Location = new System.Drawing.Point(9, 28);
            this.dtgDSPX.Name = "dtgDSPX";
            this.dtgDSPX.Size = new System.Drawing.Size(517, 602);
            this.dtgDSPX.TabIndex = 5;
            this.dtgDSPX.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDSPX_RowHeaderMouseClick);
            // 
            // uDanhSachPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgDSCTPX);
            this.Controls.Add(this.dtgDSPX);
            this.Name = "uDanhSachPX";
            this.Size = new System.Drawing.Size(1133, 658);
            this.Load += new System.EventHandler(this.uDanhSachPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDSCTPX;
        private System.Windows.Forms.DataGridView dtgDSPX;
    }
}
