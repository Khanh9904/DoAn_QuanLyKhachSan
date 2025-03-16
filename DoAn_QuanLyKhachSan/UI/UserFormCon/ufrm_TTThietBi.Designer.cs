namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTThietBi
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
            System.Windows.Forms.Label maThietBiLabel;
            System.Windows.Forms.Label tenThietBiLabel;
            System.Windows.Forms.Label soLuongThietBiLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.data_TTThietBi = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTThietBi = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.ComboBox();
            this.maThietBiTextBox = new System.Windows.Forms.TextBox();
            this.tenThietBiTextBox = new System.Windows.Forms.TextBox();
            this.soLuongThietBiTextBox = new System.Windows.Forms.TextBox();
            maThietBiLabel = new System.Windows.Forms.Label();
            tenThietBiLabel = new System.Windows.Forms.Label();
            soLuongThietBiLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTThietBi
            // 
            this.data_TTThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTThietBi.Location = new System.Drawing.Point(493, 189);
            this.data_TTThietBi.Name = "data_TTThietBi";
            this.data_TTThietBi.RowHeadersWidth = 51;
            this.data_TTThietBi.RowTemplate.Height = 24;
            this.data_TTThietBi.Size = new System.Drawing.Size(893, 352);
            this.data_TTThietBi.TabIndex = 69;
            this.data_TTThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTThietBi_CellClick);
            // 
            // txtTimKiemTTThietBi
            // 
            this.txtTimKiemTTThietBi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTThietBi.Location = new System.Drawing.Point(493, 153);
            this.txtTimKiemTTThietBi.Name = "txtTimKiemTTThietBi";
            this.txtTimKiemTTThietBi.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTThietBi.TabIndex = 68;
            this.txtTimKiemTTThietBi.TextChanged += new System.EventHandler(this.txtTimKiemTTThietBi_TextChanged);
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.FormattingEnabled = true;
            this.tinhTrangTextBox.Items.AddRange(new object[] {
            "Mới 100%",
            "Hoạt động tốt",
            "Bảo trì"});
            this.tinhTrangTextBox.Location = new System.Drawing.Point(193, 287);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(257, 24);
            this.tinhTrangTextBox.TabIndex = 100;
            // 
            // maThietBiLabel
            // 
            maThietBiLabel.AutoSize = true;
            maThietBiLabel.Location = new System.Drawing.Point(53, 203);
            maThietBiLabel.Name = "maThietBiLabel";
            maThietBiLabel.Size = new System.Drawing.Size(85, 16);
            maThietBiLabel.TabIndex = 93;
            maThietBiLabel.Text = "MÃ THIẾT BỊ";
            // 
            // maThietBiTextBox
            // 
            this.maThietBiTextBox.Enabled = false;
            this.maThietBiTextBox.Location = new System.Drawing.Point(193, 200);
            this.maThietBiTextBox.Name = "maThietBiTextBox";
            this.maThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.maThietBiTextBox.TabIndex = 94;
            // 
            // tenThietBiLabel
            // 
            tenThietBiLabel.AutoSize = true;
            tenThietBiLabel.Location = new System.Drawing.Point(53, 231);
            tenThietBiLabel.Name = "tenThietBiLabel";
            tenThietBiLabel.Size = new System.Drawing.Size(93, 16);
            tenThietBiLabel.TabIndex = 95;
            tenThietBiLabel.Text = "TÊN THIẾT BỊ";
            // 
            // tenThietBiTextBox
            // 
            this.tenThietBiTextBox.Location = new System.Drawing.Point(193, 228);
            this.tenThietBiTextBox.Name = "tenThietBiTextBox";
            this.tenThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.tenThietBiTextBox.TabIndex = 96;
            // 
            // soLuongThietBiLabel
            // 
            soLuongThietBiLabel.AutoSize = true;
            soLuongThietBiLabel.Location = new System.Drawing.Point(53, 259);
            soLuongThietBiLabel.Name = "soLuongThietBiLabel";
            soLuongThietBiLabel.Size = new System.Drawing.Size(134, 16);
            soLuongThietBiLabel.TabIndex = 97;
            soLuongThietBiLabel.Text = "SỐ LƯỢNG THIẾT BỊ";
            // 
            // soLuongThietBiTextBox
            // 
            this.soLuongThietBiTextBox.Location = new System.Drawing.Point(193, 256);
            this.soLuongThietBiTextBox.Name = "soLuongThietBiTextBox";
            this.soLuongThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.soLuongThietBiTextBox.TabIndex = 98;
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(53, 287);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(90, 16);
            tinhTrangLabel.TabIndex = 99;
            tinhTrangLabel.Text = "TÌNH TRẠNG";
            // 
            // ufrm_TTThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tinhTrangTextBox);
            this.Controls.Add(maThietBiLabel);
            this.Controls.Add(this.maThietBiTextBox);
            this.Controls.Add(tenThietBiLabel);
            this.Controls.Add(this.tenThietBiTextBox);
            this.Controls.Add(soLuongThietBiLabel);
            this.Controls.Add(this.soLuongThietBiTextBox);
            this.Controls.Add(tinhTrangLabel);
            this.Controls.Add(this.data_TTThietBi);
            this.Controls.Add(this.txtTimKiemTTThietBi);
            this.Name = "ufrm_TTThietBi";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTThietBi;
        private System.Windows.Forms.TextBox txtTimKiemTTThietBi;
        private System.Windows.Forms.ComboBox tinhTrangTextBox;
        private System.Windows.Forms.TextBox maThietBiTextBox;
        private System.Windows.Forms.TextBox tenThietBiTextBox;
        private System.Windows.Forms.TextBox soLuongThietBiTextBox;
    }
}
