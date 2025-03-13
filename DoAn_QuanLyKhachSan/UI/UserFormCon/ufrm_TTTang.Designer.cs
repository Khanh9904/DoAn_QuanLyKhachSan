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
            this.data_TTTang = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTTang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_TTTang)).BeginInit();
            this.SuspendLayout();
            // 
            // data_TTTang
            // 
            this.data_TTTang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TTTang.Location = new System.Drawing.Point(199, 237);
            this.data_TTTang.Name = "data_TTTang";
            this.data_TTTang.RowHeadersWidth = 51;
            this.data_TTTang.RowTemplate.Height = 24;
            this.data_TTTang.Size = new System.Drawing.Size(893, 352);
            this.data_TTTang.TabIndex = 67;
            // 
            // txtTimKiemTTang
            // 
            this.txtTimKiemTTang.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTTang.Location = new System.Drawing.Point(199, 201);
            this.txtTimKiemTTang.Name = "txtTimKiemTTang";
            this.txtTimKiemTTang.Size = new System.Drawing.Size(893, 22);
            this.txtTimKiemTTang.TabIndex = 66;
            this.txtTimKiemTTang.TextChanged += new System.EventHandler(this.txtTimKiemTTang_TextChanged);
            // 
            // ufrm_TTTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
