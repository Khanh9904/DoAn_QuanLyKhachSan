namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    partial class ufrm_CRUDThietBi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufrm_CRUDThietBi));
            System.Windows.Forms.Label maThietBiLabel;
            System.Windows.Forms.Label tenThietBiLabel;
            System.Windows.Forms.Label soLuongThietBiLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.txtTimKiemThietbi = new System.Windows.Forms.TextBox();
            this.btnClearThietbi = new System.Windows.Forms.Button();
            this.btnXoaThietbi = new System.Windows.Forms.Button();
            this.btnSuaThietbi = new System.Windows.Forms.Button();
            this.btnThemThietbi = new System.Windows.Forms.Button();
            this.btnTroLaiThietbi = new System.Windows.Forms.Button();
            this.data_Thietbi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.tHIET_BIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHIET_BITableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.THIET_BITableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.tHIET_BIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tHIET_BIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.maThietBiTextBox = new System.Windows.Forms.TextBox();
            this.tenThietBiTextBox = new System.Windows.Forms.TextBox();
            this.soLuongThietBiTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.TextBox();
            maThietBiLabel = new System.Windows.Forms.Label();
            tenThietBiLabel = new System.Windows.Forms.Label();
            soLuongThietBiLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Thietbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIET_BIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIET_BIBindingNavigator)).BeginInit();
            this.tHIET_BIBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiemThietbi
            // 
            this.txtTimKiemThietbi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemThietbi.Location = new System.Drawing.Point(553, 184);
            this.txtTimKiemThietbi.Name = "txtTimKiemThietbi";
            this.txtTimKiemThietbi.Size = new System.Drawing.Size(603, 22);
            this.txtTimKiemThietbi.TabIndex = 84;
            // 
            // btnClearThietbi
            // 
            this.btnClearThietbi.Location = new System.Drawing.Point(735, 679);
            this.btnClearThietbi.Name = "btnClearThietbi";
            this.btnClearThietbi.Size = new System.Drawing.Size(135, 23);
            this.btnClearThietbi.TabIndex = 83;
            this.btnClearThietbi.Text = "Xóa Dữ Liệu";
            this.btnClearThietbi.UseVisualStyleBackColor = true;
            // 
            // btnXoaThietbi
            // 
            this.btnXoaThietbi.Location = new System.Drawing.Point(584, 679);
            this.btnXoaThietbi.Name = "btnXoaThietbi";
            this.btnXoaThietbi.Size = new System.Drawing.Size(75, 23);
            this.btnXoaThietbi.TabIndex = 82;
            this.btnXoaThietbi.Text = "Xóa";
            this.btnXoaThietbi.UseVisualStyleBackColor = true;
            // 
            // btnSuaThietbi
            // 
            this.btnSuaThietbi.Location = new System.Drawing.Point(423, 679);
            this.btnSuaThietbi.Name = "btnSuaThietbi";
            this.btnSuaThietbi.Size = new System.Drawing.Size(75, 23);
            this.btnSuaThietbi.TabIndex = 81;
            this.btnSuaThietbi.Text = "Sửa";
            this.btnSuaThietbi.UseVisualStyleBackColor = true;
            // 
            // btnThemThietbi
            // 
            this.btnThemThietbi.Location = new System.Drawing.Point(274, 679);
            this.btnThemThietbi.Name = "btnThemThietbi";
            this.btnThemThietbi.Size = new System.Drawing.Size(75, 23);
            this.btnThemThietbi.TabIndex = 80;
            this.btnThemThietbi.Text = "Thêm";
            this.btnThemThietbi.UseVisualStyleBackColor = true;
            // 
            // btnTroLaiThietbi
            // 
            this.btnTroLaiThietbi.Location = new System.Drawing.Point(61, 114);
            this.btnTroLaiThietbi.Name = "btnTroLaiThietbi";
            this.btnTroLaiThietbi.Size = new System.Drawing.Size(75, 23);
            this.btnTroLaiThietbi.TabIndex = 79;
            this.btnTroLaiThietbi.Text = "Trở lại";
            this.btnTroLaiThietbi.UseVisualStyleBackColor = true;
            // 
            // data_Thietbi
            // 
            this.data_Thietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Thietbi.Location = new System.Drawing.Point(553, 212);
            this.data_Thietbi.Name = "data_Thietbi";
            this.data_Thietbi.RowHeadersWidth = 51;
            this.data_Thietbi.RowTemplate.Height = 24;
            this.data_Thietbi.Size = new System.Drawing.Size(599, 393);
            this.data_Thietbi.TabIndex = 78;
            this.data_Thietbi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_Thietbi_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "QUẢN LÝ THÔNG TIN THIẾT BỊ";
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHIET_BIBindingSource
            // 
            this.tHIET_BIBindingSource.DataMember = "THIET_BI";
            this.tHIET_BIBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // tHIET_BITableAdapter
            // 
            this.tHIET_BITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CALAMVIECTableAdapter = null;
            this.tableAdapterManager.CHAMCONGLAMVIECTableAdapter = null;
            this.tableAdapterManager.DICH_VUTableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.KHACH_HANGTableAdapter = null;
            this.tableAdapterManager.LOAI_PHONGTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHANCONGCALAMTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEU_DAT_PHONGTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TangLauTableAdapter = null;
            this.tableAdapterManager.THIET_BITableAdapter = this.tHIET_BITableAdapter;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tHIET_BIBindingNavigator
            // 
            this.tHIET_BIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tHIET_BIBindingNavigator.BindingSource = this.tHIET_BIBindingSource;
            this.tHIET_BIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tHIET_BIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tHIET_BIBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tHIET_BIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tHIET_BIBindingNavigatorSaveItem});
            this.tHIET_BIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tHIET_BIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tHIET_BIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tHIET_BIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tHIET_BIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tHIET_BIBindingNavigator.Name = "tHIET_BIBindingNavigator";
            this.tHIET_BIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tHIET_BIBindingNavigator.Size = new System.Drawing.Size(1191, 27);
            this.tHIET_BIBindingNavigator.TabIndex = 85;
            this.tHIET_BIBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tHIET_BIBindingNavigatorSaveItem
            // 
            this.tHIET_BIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tHIET_BIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tHIET_BIBindingNavigatorSaveItem.Image")));
            this.tHIET_BIBindingNavigatorSaveItem.Name = "tHIET_BIBindingNavigatorSaveItem";
            this.tHIET_BIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tHIET_BIBindingNavigatorSaveItem.Text = "Save Data";
            this.tHIET_BIBindingNavigatorSaveItem.Click += new System.EventHandler(this.tHIET_BIBindingNavigatorSaveItem_Click);
            // 
            // maThietBiLabel
            // 
            maThietBiLabel.AutoSize = true;
            maThietBiLabel.Location = new System.Drawing.Point(86, 237);
            maThietBiLabel.Name = "maThietBiLabel";
            maThietBiLabel.Size = new System.Drawing.Size(77, 16);
            maThietBiLabel.TabIndex = 85;
            maThietBiLabel.Text = "Ma Thiet Bi:";
            // 
            // maThietBiTextBox
            // 
            this.maThietBiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIET_BIBindingSource, "MaThietBi", true));
            this.maThietBiTextBox.Location = new System.Drawing.Point(207, 234);
            this.maThietBiTextBox.Name = "maThietBiTextBox";
            this.maThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.maThietBiTextBox.TabIndex = 86;
            // 
            // tenThietBiLabel
            // 
            tenThietBiLabel.AutoSize = true;
            tenThietBiLabel.Location = new System.Drawing.Point(86, 265);
            tenThietBiLabel.Name = "tenThietBiLabel";
            tenThietBiLabel.Size = new System.Drawing.Size(82, 16);
            tenThietBiLabel.TabIndex = 87;
            tenThietBiLabel.Text = "Ten Thiet Bi:";
            // 
            // tenThietBiTextBox
            // 
            this.tenThietBiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIET_BIBindingSource, "TenThietBi", true));
            this.tenThietBiTextBox.Location = new System.Drawing.Point(207, 262);
            this.tenThietBiTextBox.Name = "tenThietBiTextBox";
            this.tenThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.tenThietBiTextBox.TabIndex = 88;
            // 
            // soLuongThietBiLabel
            // 
            soLuongThietBiLabel.AutoSize = true;
            soLuongThietBiLabel.Location = new System.Drawing.Point(86, 293);
            soLuongThietBiLabel.Name = "soLuongThietBiLabel";
            soLuongThietBiLabel.Size = new System.Drawing.Size(115, 16);
            soLuongThietBiLabel.TabIndex = 89;
            soLuongThietBiLabel.Text = "So Luong Thiet Bi:";
            // 
            // soLuongThietBiTextBox
            // 
            this.soLuongThietBiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIET_BIBindingSource, "SoLuongThietBi", true));
            this.soLuongThietBiTextBox.Location = new System.Drawing.Point(207, 290);
            this.soLuongThietBiTextBox.Name = "soLuongThietBiTextBox";
            this.soLuongThietBiTextBox.Size = new System.Drawing.Size(257, 22);
            this.soLuongThietBiTextBox.TabIndex = 90;
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(86, 321);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(75, 16);
            tinhTrangLabel.TabIndex = 91;
            tinhTrangLabel.Text = "Tinh Trang:";
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHIET_BIBindingSource, "TinhTrang", true));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(207, 318);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(257, 22);
            this.tinhTrangTextBox.TabIndex = 92;
            // 
            // ufrm_CRUDThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maThietBiLabel);
            this.Controls.Add(this.maThietBiTextBox);
            this.Controls.Add(tenThietBiLabel);
            this.Controls.Add(this.tenThietBiTextBox);
            this.Controls.Add(soLuongThietBiLabel);
            this.Controls.Add(this.soLuongThietBiTextBox);
            this.Controls.Add(tinhTrangLabel);
            this.Controls.Add(this.tinhTrangTextBox);
            this.Controls.Add(this.tHIET_BIBindingNavigator);
            this.Controls.Add(this.txtTimKiemThietbi);
            this.Controls.Add(this.btnClearThietbi);
            this.Controls.Add(this.btnXoaThietbi);
            this.Controls.Add(this.btnSuaThietbi);
            this.Controls.Add(this.btnThemThietbi);
            this.Controls.Add(this.btnTroLaiThietbi);
            this.Controls.Add(this.data_Thietbi);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDThietBi";
            this.Size = new System.Drawing.Size(1191, 830);
            ((System.ComponentModel.ISupportInitialize)(this.data_Thietbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIET_BIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHIET_BIBindingNavigator)).EndInit();
            this.tHIET_BIBindingNavigator.ResumeLayout(false);
            this.tHIET_BIBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiemThietbi;
        private System.Windows.Forms.Button btnClearThietbi;
        private System.Windows.Forms.Button btnXoaThietbi;
        private System.Windows.Forms.Button btnSuaThietbi;
        private System.Windows.Forms.Button btnThemThietbi;
        private System.Windows.Forms.Button btnTroLaiThietbi;
        private System.Windows.Forms.DataGridView data_Thietbi;
        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource tHIET_BIBindingSource;
        private HeThongKhachSanDataSetTableAdapters.THIET_BITableAdapter tHIET_BITableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tHIET_BIBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tHIET_BIBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maThietBiTextBox;
        private System.Windows.Forms.TextBox tenThietBiTextBox;
        private System.Windows.Forms.TextBox soLuongThietBiTextBox;
        private System.Windows.Forms.TextBox tinhTrangTextBox;
    }
}
