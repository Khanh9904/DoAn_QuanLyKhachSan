﻿namespace DoAn_QuanLyKhachSan.UI
{
    partial class DanhSachHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.btn_LoadTongTien = new System.Windows.Forms.Button();
            this.data_hoaDon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.txttimhoadon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_hoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(187)))), ((int)(((byte)(178)))));
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_InHoaDon.Location = new System.Drawing.Point(198, 600);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(271, 41);
            this.btn_InHoaDon.TabIndex = 148;
            this.btn_InHoaDon.Text = "IN HÓA ĐƠN";
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
            // 
            // btn_LoadTongTien
            // 
            this.btn_LoadTongTien.BackColor = System.Drawing.Color.Black;
            this.btn_LoadTongTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadTongTien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LoadTongTien.Location = new System.Drawing.Point(752, 600);
            this.btn_LoadTongTien.Name = "btn_LoadTongTien";
            this.btn_LoadTongTien.Size = new System.Drawing.Size(266, 41);
            this.btn_LoadTongTien.TabIndex = 147;
            this.btn_LoadTongTien.Text = "ĐÓNG";
            this.btn_LoadTongTien.UseVisualStyleBackColor = false;
            this.btn_LoadTongTien.Click += new System.EventHandler(this.btn_LoadTongTien_Click);
            // 
            // data_hoaDon
            // 
            this.data_hoaDon.BackgroundColor = System.Drawing.Color.White;
            this.data_hoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_hoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hoaDon.Location = new System.Drawing.Point(12, 86);
            this.data_hoaDon.Name = "data_hoaDon";
            this.data_hoaDon.RowHeadersWidth = 51;
            this.data_hoaDon.RowTemplate.Height = 24;
            this.data_hoaDon.Size = new System.Drawing.Size(1241, 451);
            this.data_hoaDon.TabIndex = 146;
            this.data_hoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_hoaDon_CellFormatting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 25);
            this.label3.TabIndex = 145;
            this.label3.Text = "DANH SÁCH HÓA ĐƠN KHÁCH HÀNG ";
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(187)))), ((int)(((byte)(178)))));
            this.btnXoaHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaHoaDon.Location = new System.Drawing.Point(475, 600);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(271, 41);
            this.btnXoaHoaDon.TabIndex = 149;
            this.btnXoaHoaDon.Text = "XÓA HÓA ĐƠN";
            this.btnXoaHoaDon.UseVisualStyleBackColor = false;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // txttimhoadon
            // 
            this.txttimhoadon.Location = new System.Drawing.Point(21, 58);
            this.txttimhoadon.Name = "txttimhoadon";
            this.txttimhoadon.Size = new System.Drawing.Size(1243, 22);
            this.txttimhoadon.TabIndex = 150;
            this.txttimhoadon.TextChanged += new System.EventHandler(this.txttimhoadon_TextChanged);
            // 
            // DanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 730);
            this.Controls.Add(this.txttimhoadon);
            this.Controls.Add(this.btnXoaHoaDon);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.btn_LoadTongTien);
            this.Controls.Add(this.data_hoaDon);
            this.Controls.Add(this.label3);
            this.Name = "DanhSachHoaDon";
            this.Text = "DanhSachHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.data_hoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Button btn_LoadTongTien;
        private System.Windows.Forms.DataGridView data_hoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.TextBox txttimhoadon;
    }
}