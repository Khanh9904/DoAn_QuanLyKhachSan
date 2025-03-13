namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    partial class ufrm_TTPhanQuyen
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
            this.data_TTPhanQuyen = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTPhanQuyen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTPhanQuyen
            // 
            this.data_TTPhanQuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.data_TTPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTPhanQuyen.Location = new System.Drawing.Point(196, 189);
            this.data_TTPhanQuyen.Name = "data_TTPhanQuyen";
            this.data_TTPhanQuyen.RowHeadersWidth = 51;
            this.data_TTPhanQuyen.RowTemplate.Height = 24;
            this.data_TTPhanQuyen.Size = new System.Drawing.Size(893, 352);
            this.data_TTPhanQuyen.TabIndex = 67;
            // 
            // txtTimKiemTTPhanQuyen
            // 
            this.txtTimKiemTTPhanQuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTimKiemTTPhanQuyen.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTPhanQuyen.Location = new System.Drawing.Point(196, 153);
            this.txtTimKiemTTPhanQuyen.Name = "txtTimKiemTTPhanQuyen";
            this.txtTimKiemTTPhanQuyen.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTPhanQuyen.TabIndex = 66;
            this.txtTimKiemTTPhanQuyen.TextChanged += new System.EventHandler(this.txtTimKiemTTPhanQuyen_TextChanged);
            // 
            // ufrm_TTPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_TTPhanQuyen);
            this.Controls.Add(this.txtTimKiemTTPhanQuyen);
            this.Name = "ufrm_TTPhanQuyen";
            this.Size = new System.Drawing.Size(1424, 890);
            ((System.ComponentModel.ISupportInitialize)(this.data_TTPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_TTPhanQuyen;
        private System.Windows.Forms.TextBox txtTimKiemTTPhanQuyen;
    }
}
