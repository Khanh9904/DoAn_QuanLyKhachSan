namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTTang
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
            System.Windows.Forms.Label maTangLabel;
            System.Windows.Forms.Label tenTangLabel;
            this.data_TTTang = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTang = new System.Windows.Forms.TextBox();
            this.maTangTextBox = new System.Windows.Forms.TextBox();
            this.tenTangTextBox = new System.Windows.Forms.TextBox();
            maTangLabel = new System.Windows.Forms.Label();
            tenTangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTang)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTTang
            // 
            this.data_TTTang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTTang.Location = new System.Drawing.Point(428, 189);
            this.data_TTTang.Name = "data_TTTang";
            this.data_TTTang.RowHeadersWidth = 51;
            this.data_TTTang.RowTemplate.Height = 24;
            this.data_TTTang.Size = new System.Drawing.Size(893, 352);
            this.data_TTTang.TabIndex = 67;
            this.data_TTTang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_TTTang_CellClick);
            // 
            // txtTimKiemTTang
            // 
            this.txtTimKiemTTang.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTang.Location = new System.Drawing.Point(428, 153);
            this.txtTimKiemTTang.Name = "txtTimKiemTTang";
            this.txtTimKiemTTang.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTang.TabIndex = 66;
            this.txtTimKiemTTang.TextChanged += new System.EventHandler(this.txtTimKiemTTang_TextChanged);
            // 
            // maTangLabel
            // 
            maTangLabel.AutoSize = true;
            maTangLabel.Location = new System.Drawing.Point(66, 234);
            maTangLabel.Name = "maTangLabel";
            maTangLabel.Size = new System.Drawing.Size(68, 16);
            maTangLabel.TabIndex = 87;
            maTangLabel.Text = "MÃ TẦNG";
            // 
            // maTangTextBox
            // 
            this.maTangTextBox.Enabled = false;
            this.maTangTextBox.Location = new System.Drawing.Point(161, 228);
            this.maTangTextBox.Name = "maTangTextBox";
            this.maTangTextBox.Size = new System.Drawing.Size(202, 22);
            this.maTangTextBox.TabIndex = 88;
            // 
            // tenTangLabel
            // 
            tenTangLabel.AutoSize = true;
            tenTangLabel.Location = new System.Drawing.Point(66, 262);
            tenTangLabel.Name = "tenTangLabel";
            tenTangLabel.Size = new System.Drawing.Size(76, 16);
            tenTangLabel.TabIndex = 89;
            tenTangLabel.Text = "TÊN TẦNG";
            // 
            // tenTangTextBox
            // 
            this.tenTangTextBox.Location = new System.Drawing.Point(161, 256);
            this.tenTangTextBox.Name = "tenTangTextBox";
            this.tenTangTextBox.Size = new System.Drawing.Size(202, 22);
            this.tenTangTextBox.TabIndex = 90;
            // 
            // ufrm_TTTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maTangLabel);
            this.Controls.Add(this.maTangTextBox);
            this.Controls.Add(tenTangLabel);
            this.Controls.Add(this.tenTangTextBox);
            this.Controls.Add(this.data_TTTang);
            this.Controls.Add(this.txtTimKiemTTang);
            this.Name = "ufrm_TTTang";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTTang;
        private System.Windows.Forms.TextBox txtTimKiemTTang;
        private System.Windows.Forms.TextBox maTangTextBox;
        private System.Windows.Forms.TextBox tenTangTextBox;
    }
}
