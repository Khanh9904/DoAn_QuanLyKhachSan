namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTLoaiPhong
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
            System.Windows.Forms.Label maLoaiPhongLabel;
            System.Windows.Forms.Label tenLoaiPhongLabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label soNguoiToiDaLabel;
            this.data_TTLoaiPhong = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTLoaiPhong = new System.Windows.Forms.TextBox();
            this.maLoaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.tenLoaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.giaTextBox = new System.Windows.Forms.TextBox();
            this.soNguoiToiDaTextBox = new System.Windows.Forms.TextBox();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            tenLoaiPhongLabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            soNguoiToiDaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(34, 236);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(111, 16);
            maLoaiPhongLabel.TabIndex = 77;
            maLoaiPhongLabel.Text = "MÃ LOẠI PHÒNG";
            // 
            // tenLoaiPhongLabel
            // 
            tenLoaiPhongLabel.AutoSize = true;
            tenLoaiPhongLabel.Location = new System.Drawing.Point(34, 264);
            tenLoaiPhongLabel.Name = "tenLoaiPhongLabel";
            tenLoaiPhongLabel.Size = new System.Drawing.Size(119, 16);
            tenLoaiPhongLabel.TabIndex = 79;
            tenLoaiPhongLabel.Text = "TÊN LOẠI PHÒNG";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Location = new System.Drawing.Point(34, 292);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(29, 16);
            giaLabel.TabIndex = 81;
            giaLabel.Text = "GIÁ";
            // 
            // soNguoiToiDaLabel
            // 
            soNguoiToiDaLabel.AutoSize = true;
            soNguoiToiDaLabel.Location = new System.Drawing.Point(34, 320);
            soNguoiToiDaLabel.Name = "soNguoiToiDaLabel";
            soNguoiToiDaLabel.Size = new System.Drawing.Size(118, 16);
            soNguoiToiDaLabel.TabIndex = 83;
            soNguoiToiDaLabel.Text = "SỐ NGƯỜI TỐI ĐA";
            // 
            // data_TTLoaiPhong
            // 
            this.data_TTLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTLoaiPhong.Location = new System.Drawing.Point(473, 194);
            this.data_TTLoaiPhong.Name = "data_TTLoaiPhong";
            this.data_TTLoaiPhong.RowHeadersWidth = 51;
            this.data_TTLoaiPhong.RowTemplate.Height = 24;
            this.data_TTLoaiPhong.Size = new System.Drawing.Size(893, 352);
            this.data_TTLoaiPhong.TabIndex = 67;
            this.data_TTLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTLoaiPhong_CellClick);
            this.data_TTLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTLoaiPhong_CellContentClick);
            // 
            // txtTimKiemTTLoaiPhong
            // 
            this.txtTimKiemTTLoaiPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTLoaiPhong.Location = new System.Drawing.Point(473, 158);
            this.txtTimKiemTTLoaiPhong.Name = "txtTimKiemTTLoaiPhong";
            this.txtTimKiemTTLoaiPhong.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTLoaiPhong.TabIndex = 66;
            this.txtTimKiemTTLoaiPhong.TextChanged += new System.EventHandler(this.txtTimKiemTTLoaiPhong_TextChanged);
            // 
            // maLoaiPhongTextBox
            // 
            this.maLoaiPhongTextBox.Enabled = false;
            this.maLoaiPhongTextBox.Location = new System.Drawing.Point(176, 233);
            this.maLoaiPhongTextBox.Name = "maLoaiPhongTextBox";
            this.maLoaiPhongTextBox.Size = new System.Drawing.Size(272, 22);
            this.maLoaiPhongTextBox.TabIndex = 78;
            // 
            // tenLoaiPhongTextBox
            // 
            this.tenLoaiPhongTextBox.Location = new System.Drawing.Point(176, 261);
            this.tenLoaiPhongTextBox.Name = "tenLoaiPhongTextBox";
            this.tenLoaiPhongTextBox.Size = new System.Drawing.Size(272, 22);
            this.tenLoaiPhongTextBox.TabIndex = 80;
            // 
            // giaTextBox
            // 
            this.giaTextBox.Location = new System.Drawing.Point(176, 289);
            this.giaTextBox.Name = "giaTextBox";
            this.giaTextBox.Size = new System.Drawing.Size(272, 22);
            this.giaTextBox.TabIndex = 82;
            this.giaTextBox.TextChanged += new System.EventHandler(this.giaTextBox_TextChanged);
            // 
            // soNguoiToiDaTextBox
            // 
            this.soNguoiToiDaTextBox.Location = new System.Drawing.Point(176, 317);
            this.soNguoiToiDaTextBox.Name = "soNguoiToiDaTextBox";
            this.soNguoiToiDaTextBox.Size = new System.Drawing.Size(272, 22);
            this.soNguoiToiDaTextBox.TabIndex = 84;
            // 
            // ufrm_TTLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maLoaiPhongLabel);
            this.Controls.Add(this.maLoaiPhongTextBox);
            this.Controls.Add(tenLoaiPhongLabel);
            this.Controls.Add(this.tenLoaiPhongTextBox);
            this.Controls.Add(giaLabel);
            this.Controls.Add(this.giaTextBox);
            this.Controls.Add(soNguoiToiDaLabel);
            this.Controls.Add(this.soNguoiToiDaTextBox);
            this.Controls.Add(this.data_TTLoaiPhong);
            this.Controls.Add(this.txtTimKiemTTLoaiPhong);
            this.Name = "ufrm_TTLoaiPhong";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTLoaiPhong;
        private System.Windows.Forms.TextBox txtTimKiemTTLoaiPhong;
        private System.Windows.Forms.TextBox maLoaiPhongTextBox;
        private System.Windows.Forms.TextBox tenLoaiPhongTextBox;
        private System.Windows.Forms.TextBox giaTextBox;
        private System.Windows.Forms.TextBox soNguoiToiDaTextBox;
    }
}
