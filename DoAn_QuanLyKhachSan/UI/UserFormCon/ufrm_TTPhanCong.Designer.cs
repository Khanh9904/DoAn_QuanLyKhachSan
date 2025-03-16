namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTPhanCong
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
            System.Windows.Forms.Label iD_PHANCONGLabel;
            System.Windows.Forms.Label iD_NHANVIENLabel;
            System.Windows.Forms.Label iD_CALAMLabel;
            System.Windows.Forms.Label nGAYLAMLabel;
            this.data_TTPhanCong = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTPhanCong = new System.Windows.Forms.TextBox();
            this.cbMaCa = new System.Windows.Forms.ComboBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.iD_PHANCONGTextBox = new System.Windows.Forms.TextBox();
            this.nGAYLAMDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iD_PHANCONGLabel = new System.Windows.Forms.Label();
            iD_NHANVIENLabel = new System.Windows.Forms.Label();
            iD_CALAMLabel = new System.Windows.Forms.Label();
            nGAYLAMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTPhanCong
            // 
            this.data_TTPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTPhanCong.Location = new System.Drawing.Point(489, 200);
            this.data_TTPhanCong.Name = "data_TTPhanCong";
            this.data_TTPhanCong.RowHeadersWidth = 51;
            this.data_TTPhanCong.RowTemplate.Height = 24;
            this.data_TTPhanCong.Size = new System.Drawing.Size(893, 352);
            this.data_TTPhanCong.TabIndex = 63;
            this.data_TTPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTPhanCong_CellClick);
            // 
            // txtTimKiemTTPhanCong
            // 
            this.txtTimKiemTTPhanCong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTPhanCong.Location = new System.Drawing.Point(489, 164);
            this.txtTimKiemTTPhanCong.Name = "txtTimKiemTTPhanCong";
            this.txtTimKiemTTPhanCong.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTPhanCong.TabIndex = 62;
            this.txtTimKiemTTPhanCong.TextChanged += new System.EventHandler(this.txtTimKiemTTPhanCong_TextChanged);
            // 
            // cbMaCa
            // 
            this.cbMaCa.FormattingEnabled = true;
            this.cbMaCa.Location = new System.Drawing.Point(189, 266);
            this.cbMaCa.Name = "cbMaCa";
            this.cbMaCa.Size = new System.Drawing.Size(235, 24);
            this.cbMaCa.TabIndex = 79;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(189, 236);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(235, 24);
            this.cbNhanVien.TabIndex = 78;
            // 
            // iD_PHANCONGLabel
            // 
            iD_PHANCONGLabel.AutoSize = true;
            iD_PHANCONGLabel.Location = new System.Drawing.Point(52, 213);
            iD_PHANCONGLabel.Name = "iD_PHANCONGLabel";
            iD_PHANCONGLabel.Size = new System.Drawing.Size(110, 16);
            iD_PHANCONGLabel.TabIndex = 72;
            iD_PHANCONGLabel.Text = "MÃ PHÂN CÔNG";
            // 
            // iD_PHANCONGTextBox
            // 
            this.iD_PHANCONGTextBox.Enabled = false;
            this.iD_PHANCONGTextBox.Location = new System.Drawing.Point(189, 210);
            this.iD_PHANCONGTextBox.Name = "iD_PHANCONGTextBox";
            this.iD_PHANCONGTextBox.Size = new System.Drawing.Size(235, 22);
            this.iD_PHANCONGTextBox.TabIndex = 73;
            // 
            // iD_NHANVIENLabel
            // 
            iD_NHANVIENLabel.AutoSize = true;
            iD_NHANVIENLabel.Location = new System.Drawing.Point(52, 241);
            iD_NHANVIENLabel.Name = "iD_NHANVIENLabel";
            iD_NHANVIENLabel.Size = new System.Drawing.Size(103, 16);
            iD_NHANVIENLabel.TabIndex = 74;
            iD_NHANVIENLabel.Text = "MÃ NHÂN VIÊN";
            // 
            // iD_CALAMLabel
            // 
            iD_CALAMLabel.AutoSize = true;
            iD_CALAMLabel.Location = new System.Drawing.Point(52, 269);
            iD_CALAMLabel.Name = "iD_CALAMLabel";
            iD_CALAMLabel.Size = new System.Drawing.Size(78, 16);
            iD_CALAMLabel.TabIndex = 75;
            iD_CALAMLabel.Text = "MÃ CA LÀM";
            // 
            // nGAYLAMLabel
            // 
            nGAYLAMLabel.AutoSize = true;
            nGAYLAMLabel.Location = new System.Drawing.Point(52, 298);
            nGAYLAMLabel.Name = "nGAYLAMLabel";
            nGAYLAMLabel.Size = new System.Drawing.Size(108, 16);
            nGAYLAMLabel.TabIndex = 76;
            nGAYLAMLabel.Text = "NGÀY LÀM VIỆC";
            // 
            // nGAYLAMDateTimePicker
            // 
            this.nGAYLAMDateTimePicker.Location = new System.Drawing.Point(189, 294);
            this.nGAYLAMDateTimePicker.Name = "nGAYLAMDateTimePicker";
            this.nGAYLAMDateTimePicker.Size = new System.Drawing.Size(235, 22);
            this.nGAYLAMDateTimePicker.TabIndex = 77;
            // 
            // ufrm_TTPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMaCa);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(iD_PHANCONGLabel);
            this.Controls.Add(this.iD_PHANCONGTextBox);
            this.Controls.Add(iD_NHANVIENLabel);
            this.Controls.Add(iD_CALAMLabel);
            this.Controls.Add(nGAYLAMLabel);
            this.Controls.Add(this.nGAYLAMDateTimePicker);
            this.Controls.Add(this.data_TTPhanCong);
            this.Controls.Add(this.txtTimKiemTTPhanCong);
            this.Name = "ufrm_TTPhanCong";
            this.Size = new System.Drawing.Size(1424, 890);
            this.Load += new System.EventHandler(this.ufrm_TTPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTPhanCong;
        private System.Windows.Forms.TextBox txtTimKiemTTPhanCong;
        private System.Windows.Forms.ComboBox cbMaCa;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.TextBox iD_PHANCONGTextBox;
        private System.Windows.Forms.DateTimePicker nGAYLAMDateTimePicker;
    }
}
