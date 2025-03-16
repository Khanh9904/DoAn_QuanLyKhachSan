namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTDichVu
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
            System.Windows.Forms.Label maDichVuLabel;
            System.Windows.Forms.Label tenDichVuLabel;
            System.Windows.Forms.Label giaDichVuLabel;
            System.Windows.Forms.Label trangThaiDichVuLabel;
            System.Windows.Forms.Label soLuongDichVuLabel;
            this.data_TTDichVu = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTDichVu = new System.Windows.Forms.TextBox();
            this.trangThaiDichVuTextBox = new System.Windows.Forms.ComboBox();
            this.maDichVuTextBox = new System.Windows.Forms.TextBox();
            this.tenDichVuTextBox = new System.Windows.Forms.TextBox();
            this.giaDichVuTextBox = new System.Windows.Forms.TextBox();
            this.soLuongDichVuTextBox = new System.Windows.Forms.TextBox();
            maDichVuLabel = new System.Windows.Forms.Label();
            tenDichVuLabel = new System.Windows.Forms.Label();
            giaDichVuLabel = new System.Windows.Forms.Label();
            trangThaiDichVuLabel = new System.Windows.Forms.Label();
            soLuongDichVuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // maDichVuLabel
            // 
            maDichVuLabel.AutoSize = true;
            maDichVuLabel.Location = new System.Drawing.Point(42, 276);
            maDichVuLabel.Name = "maDichVuLabel";
            maDichVuLabel.Size = new System.Drawing.Size(84, 16);
            maDichVuLabel.TabIndex = 72;
            maDichVuLabel.Text = "MÃ DỊCH VỤ";
            // 
            // tenDichVuLabel
            // 
            tenDichVuLabel.AutoSize = true;
            tenDichVuLabel.Location = new System.Drawing.Point(42, 304);
            tenDichVuLabel.Name = "tenDichVuLabel";
            tenDichVuLabel.Size = new System.Drawing.Size(92, 16);
            tenDichVuLabel.TabIndex = 74;
            tenDichVuLabel.Text = "TÊN DỊCH VỤ";
            // 
            // giaDichVuLabel
            // 
            giaDichVuLabel.AutoSize = true;
            giaDichVuLabel.Location = new System.Drawing.Point(42, 332);
            giaDichVuLabel.Name = "giaDichVuLabel";
            giaDichVuLabel.Size = new System.Drawing.Size(86, 16);
            giaDichVuLabel.TabIndex = 76;
            giaDichVuLabel.Text = "GIÁ DỊCH VỤ";
            // 
            // trangThaiDichVuLabel
            // 
            trangThaiDichVuLabel.AutoSize = true;
            trangThaiDichVuLabel.Location = new System.Drawing.Point(42, 360);
            trangThaiDichVuLabel.Name = "trangThaiDichVuLabel";
            trangThaiDichVuLabel.Size = new System.Drawing.Size(89, 16);
            trangThaiDichVuLabel.TabIndex = 78;
            trangThaiDichVuLabel.Text = "TRẠNG THÁI";
            // 
            // soLuongDichVuLabel
            // 
            soLuongDichVuLabel.AutoSize = true;
            soLuongDichVuLabel.Location = new System.Drawing.Point(42, 388);
            soLuongDichVuLabel.Name = "soLuongDichVuLabel";
            soLuongDichVuLabel.Size = new System.Drawing.Size(76, 16);
            soLuongDichVuLabel.TabIndex = 79;
            soLuongDichVuLabel.Text = "SỐ LƯỢNG";
            // 
            // data_TTDichVu
            // 
            this.data_TTDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTDichVu.Location = new System.Drawing.Point(496, 212);
            this.data_TTDichVu.Name = "data_TTDichVu";
            this.data_TTDichVu.RowHeadersWidth = 51;
            this.data_TTDichVu.RowTemplate.Height = 24;
            this.data_TTDichVu.Size = new System.Drawing.Size(893, 352);
            this.data_TTDichVu.TabIndex = 71;
            this.data_TTDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTDichVu_CellClick);
            this.data_TTDichVu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_TTDichVu_CellFormatting);
            // 
            // txtTimKiemTTDichVu
            // 
            this.txtTimKiemTTDichVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTDichVu.Location = new System.Drawing.Point(496, 176);
            this.txtTimKiemTTDichVu.Name = "txtTimKiemTTDichVu";
            this.txtTimKiemTTDichVu.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTDichVu.TabIndex = 70;
            this.txtTimKiemTTDichVu.TextChanged += new System.EventHandler(this.txtTimKiemTTDichVu_TextChanged);
            // 
            // trangThaiDichVuTextBox
            // 
            this.trangThaiDichVuTextBox.FormattingEnabled = true;
            this.trangThaiDichVuTextBox.Items.AddRange(new object[] {
            "Tốt",
            "Bảo trì",
            "Hỏng"});
            this.trangThaiDichVuTextBox.Location = new System.Drawing.Point(174, 355);
            this.trangThaiDichVuTextBox.Name = "trangThaiDichVuTextBox";
            this.trangThaiDichVuTextBox.Size = new System.Drawing.Size(282, 24);
            this.trangThaiDichVuTextBox.TabIndex = 81;
            // 
            // maDichVuTextBox
            // 
            this.maDichVuTextBox.Enabled = false;
            this.maDichVuTextBox.Location = new System.Drawing.Point(173, 273);
            this.maDichVuTextBox.Name = "maDichVuTextBox";
            this.maDichVuTextBox.Size = new System.Drawing.Size(283, 22);
            this.maDichVuTextBox.TabIndex = 73;
            // 
            // tenDichVuTextBox
            // 
            this.tenDichVuTextBox.Location = new System.Drawing.Point(173, 301);
            this.tenDichVuTextBox.Name = "tenDichVuTextBox";
            this.tenDichVuTextBox.Size = new System.Drawing.Size(283, 22);
            this.tenDichVuTextBox.TabIndex = 75;
            // 
            // giaDichVuTextBox
            // 
            this.giaDichVuTextBox.Location = new System.Drawing.Point(173, 329);
            this.giaDichVuTextBox.Name = "giaDichVuTextBox";
            this.giaDichVuTextBox.Size = new System.Drawing.Size(283, 22);
            this.giaDichVuTextBox.TabIndex = 77;
            this.giaDichVuTextBox.TextChanged += new System.EventHandler(this.giaDichVuTextBox_TextChanged);
            // 
            // soLuongDichVuTextBox
            // 
            this.soLuongDichVuTextBox.Location = new System.Drawing.Point(173, 385);
            this.soLuongDichVuTextBox.Name = "soLuongDichVuTextBox";
            this.soLuongDichVuTextBox.Size = new System.Drawing.Size(283, 22);
            this.soLuongDichVuTextBox.TabIndex = 80;
            // 
            // ufrm_TTDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trangThaiDichVuTextBox);
            this.Controls.Add(maDichVuLabel);
            this.Controls.Add(this.maDichVuTextBox);
            this.Controls.Add(tenDichVuLabel);
            this.Controls.Add(this.tenDichVuTextBox);
            this.Controls.Add(giaDichVuLabel);
            this.Controls.Add(this.giaDichVuTextBox);
            this.Controls.Add(trangThaiDichVuLabel);
            this.Controls.Add(soLuongDichVuLabel);
            this.Controls.Add(this.soLuongDichVuTextBox);
            this.Controls.Add(this.data_TTDichVu);
            this.Controls.Add(this.txtTimKiemTTDichVu);
            this.Name = "ufrm_TTDichVu";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTDichVu;
        private System.Windows.Forms.TextBox txtTimKiemTTDichVu;
        private System.Windows.Forms.ComboBox trangThaiDichVuTextBox;
        private System.Windows.Forms.TextBox maDichVuTextBox;
        private System.Windows.Forms.TextBox tenDichVuTextBox;
        private System.Windows.Forms.TextBox giaDichVuTextBox;
        private System.Windows.Forms.TextBox soLuongDichVuTextBox;
    }
}
