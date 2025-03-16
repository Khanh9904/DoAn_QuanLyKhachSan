namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTCaLam
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
            System.Windows.Forms.Label iD_CALAMLabel;
            System.Windows.Forms.Label tENCALabel;
            System.Windows.Forms.Label gIOBATDAULabel;
            System.Windows.Forms.Label gIOKETTHUCLabel;
            this.data_TTCaLam = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTCaLam = new System.Windows.Forms.TextBox();
            this.iD_CALAMTextBox = new System.Windows.Forms.TextBox();
            this.tENCATextBox = new System.Windows.Forms.TextBox();
            this.gIOBATDAUTextBox = new System.Windows.Forms.TextBox();
            this.gIOKETTHUCTextBox = new System.Windows.Forms.TextBox();
            iD_CALAMLabel = new System.Windows.Forms.Label();
            tENCALabel = new System.Windows.Forms.Label();
            gIOBATDAULabel = new System.Windows.Forms.Label();
            gIOKETTHUCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTCaLam)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTCaLam
            // 
            this.data_TTCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTCaLam.Location = new System.Drawing.Point(471, 180);
            this.data_TTCaLam.Name = "data_TTCaLam";
            this.data_TTCaLam.RowHeadersWidth = 51;
            this.data_TTCaLam.RowTemplate.Height = 24;
            this.data_TTCaLam.Size = new System.Drawing.Size(893, 352);
            this.data_TTCaLam.TabIndex = 69;
            this.data_TTCaLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTCaLam_CellClick);
            // 
            // txtTimKiemTTCaLam
            // 
            this.txtTimKiemTTCaLam.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTCaLam.Location = new System.Drawing.Point(471, 144);
            this.txtTimKiemTTCaLam.Name = "txtTimKiemTTCaLam";
            this.txtTimKiemTTCaLam.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTCaLam.TabIndex = 68;
            this.txtTimKiemTTCaLam.TextChanged += new System.EventHandler(this.txtTimKiemTTCaLam_TextChanged);
            // 
            // iD_CALAMLabel
            // 
            iD_CALAMLabel.AutoSize = true;
            iD_CALAMLabel.Location = new System.Drawing.Point(59, 213);
            iD_CALAMLabel.Name = "iD_CALAMLabel";
            iD_CALAMLabel.Size = new System.Drawing.Size(78, 16);
            iD_CALAMLabel.TabIndex = 75;
            iD_CALAMLabel.Text = "MÃ CA LÀM";
            iD_CALAMLabel.Click += new System.EventHandler(this.iD_CALAMLabel_Click);
            // 
            // iD_CALAMTextBox
            // 
            this.iD_CALAMTextBox.Enabled = false;
            this.iD_CALAMTextBox.Location = new System.Drawing.Point(177, 210);
            this.iD_CALAMTextBox.Name = "iD_CALAMTextBox";
            this.iD_CALAMTextBox.Size = new System.Drawing.Size(235, 22);
            this.iD_CALAMTextBox.TabIndex = 76;
            // 
            // tENCALabel
            // 
            tENCALabel.AutoSize = true;
            tENCALabel.Location = new System.Drawing.Point(59, 241);
            tENCALabel.Name = "tENCALabel";
            tENCALabel.Size = new System.Drawing.Size(86, 16);
            tENCALabel.TabIndex = 77;
            tENCALabel.Text = "TÊN CA LÀM";
            // 
            // tENCATextBox
            // 
            this.tENCATextBox.Location = new System.Drawing.Point(177, 238);
            this.tENCATextBox.Name = "tENCATextBox";
            this.tENCATextBox.Size = new System.Drawing.Size(235, 22);
            this.tENCATextBox.TabIndex = 78;
            // 
            // gIOBATDAULabel
            // 
            gIOBATDAULabel.AutoSize = true;
            gIOBATDAULabel.Location = new System.Drawing.Point(59, 269);
            gIOBATDAULabel.Name = "gIOBATDAULabel";
            gIOBATDAULabel.Size = new System.Drawing.Size(91, 16);
            gIOBATDAULabel.TabIndex = 79;
            gIOBATDAULabel.Text = "GIỜ BẮT ĐẦU";
            // 
            // gIOBATDAUTextBox
            // 
            this.gIOBATDAUTextBox.Location = new System.Drawing.Point(177, 266);
            this.gIOBATDAUTextBox.Name = "gIOBATDAUTextBox";
            this.gIOBATDAUTextBox.Size = new System.Drawing.Size(235, 22);
            this.gIOBATDAUTextBox.TabIndex = 80;
            // 
            // gIOKETTHUCLabel
            // 
            gIOKETTHUCLabel.AutoSize = true;
            gIOKETTHUCLabel.Location = new System.Drawing.Point(59, 297);
            gIOKETTHUCLabel.Name = "gIOKETTHUCLabel";
            gIOKETTHUCLabel.Size = new System.Drawing.Size(100, 16);
            gIOKETTHUCLabel.TabIndex = 81;
            gIOKETTHUCLabel.Text = "GIỜ KẾT THÚC";
            // 
            // gIOKETTHUCTextBox
            // 
            this.gIOKETTHUCTextBox.Location = new System.Drawing.Point(177, 294);
            this.gIOKETTHUCTextBox.Name = "gIOKETTHUCTextBox";
            this.gIOKETTHUCTextBox.Size = new System.Drawing.Size(235, 22);
            this.gIOKETTHUCTextBox.TabIndex = 82;
            // 
            // ufrm_TTCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(iD_CALAMLabel);
            this.Controls.Add(this.iD_CALAMTextBox);
            this.Controls.Add(tENCALabel);
            this.Controls.Add(this.tENCATextBox);
            this.Controls.Add(gIOBATDAULabel);
            this.Controls.Add(this.gIOBATDAUTextBox);
            this.Controls.Add(gIOKETTHUCLabel);
            this.Controls.Add(this.gIOKETTHUCTextBox);
            this.Controls.Add(this.data_TTCaLam);
            this.Controls.Add(this.txtTimKiemTTCaLam);
            this.Name = "ufrm_TTCaLam";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTCaLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTCaLam;
        private System.Windows.Forms.TextBox txtTimKiemTTCaLam;
        private System.Windows.Forms.TextBox iD_CALAMTextBox;
        private System.Windows.Forms.TextBox tENCATextBox;
        private System.Windows.Forms.TextBox gIOBATDAUTextBox;
        private System.Windows.Forms.TextBox gIOKETTHUCTextBox;
    }
}
