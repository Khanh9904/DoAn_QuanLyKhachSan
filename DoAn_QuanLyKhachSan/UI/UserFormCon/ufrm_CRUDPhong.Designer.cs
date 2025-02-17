namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    partial class ufrm_CRUDPhong
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
            System.Windows.Forms.Label maPhongLabel;
            System.Windows.Forms.Label tenPhongLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            System.Windows.Forms.Label maLoaiPhongLabel;
            System.Windows.Forms.Label maThietBiLabel;
            System.Windows.Forms.Label maDichVuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufrm_CRUDPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.heThongKhachSanDataSet = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.PHONGTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager();
            this.pHONGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pHONGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.maPhongTextBox = new System.Windows.Forms.TextBox();
            this.tenPhongTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.TextBox();
            this.maLoaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.maThietBiTextBox = new System.Windows.Forms.TextBox();
            this.maDichVuTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTroLaiQLTTP = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            maPhongLabel = new System.Windows.Forms.Label();
            tenPhongLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            maLoaiPhongLabel = new System.Windows.Forms.Label();
            maThietBiLabel = new System.Windows.Forms.Label();
            maDichVuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingNavigator)).BeginInit();
            this.pHONGBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // maPhongLabel
            // 
            maPhongLabel.AutoSize = true;
            maPhongLabel.Location = new System.Drawing.Point(110, 190);
            maPhongLabel.Name = "maPhongLabel";
            maPhongLabel.Size = new System.Drawing.Size(71, 16);
            maPhongLabel.TabIndex = 3;
            maPhongLabel.Text = "Ma Phong:";
            // 
            // tenPhongLabel
            // 
            tenPhongLabel.AutoSize = true;
            tenPhongLabel.Location = new System.Drawing.Point(110, 218);
            tenPhongLabel.Name = "tenPhongLabel";
            tenPhongLabel.Size = new System.Drawing.Size(76, 16);
            tenPhongLabel.TabIndex = 5;
            tenPhongLabel.Text = "Ten Phong:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(110, 246);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(75, 16);
            tinhTrangLabel.TabIndex = 7;
            tinhTrangLabel.Text = "Tinh Trang:";
            // 
            // maLoaiPhongLabel
            // 
            maLoaiPhongLabel.AutoSize = true;
            maLoaiPhongLabel.Location = new System.Drawing.Point(110, 274);
            maLoaiPhongLabel.Name = "maLoaiPhongLabel";
            maLoaiPhongLabel.Size = new System.Drawing.Size(100, 16);
            maLoaiPhongLabel.TabIndex = 9;
            maLoaiPhongLabel.Text = "Ma Loai Phong:";
            // 
            // maThietBiLabel
            // 
            maThietBiLabel.AutoSize = true;
            maThietBiLabel.Location = new System.Drawing.Point(110, 302);
            maThietBiLabel.Name = "maThietBiLabel";
            maThietBiLabel.Size = new System.Drawing.Size(77, 16);
            maThietBiLabel.TabIndex = 11;
            maThietBiLabel.Text = "Ma Thiet Bi:";
            // 
            // maDichVuLabel
            // 
            maDichVuLabel.AutoSize = true;
            maDichVuLabel.Location = new System.Drawing.Point(110, 330);
            maDichVuLabel.Name = "maDichVuLabel";
            maDichVuLabel.Size = new System.Drawing.Size(78, 16);
            maDichVuLabel.TabIndex = 13;
            maDichVuLabel.Text = "Ma Dich Vu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THÔNG TIN PHÒNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(563, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 393);
            this.dataGridView1.TabIndex = 2;
            // 
            // heThongKhachSanDataSet
            // 
            this.heThongKhachSanDataSet.DataSetName = "HeThongKhachSanDataSet";
            this.heThongKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.heThongKhachSanDataSet;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PHONGTableAdapter = this.pHONGTableAdapter;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHONGBindingNavigator
            // 
            this.pHONGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pHONGBindingNavigator.BindingSource = this.pHONGBindingSource;
            this.pHONGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pHONGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pHONGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pHONGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pHONGBindingNavigatorSaveItem});
            this.pHONGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pHONGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pHONGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pHONGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pHONGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pHONGBindingNavigator.Name = "pHONGBindingNavigator";
            this.pHONGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pHONGBindingNavigator.Size = new System.Drawing.Size(1250, 31);
            this.pHONGBindingNavigator.TabIndex = 3;
            this.pHONGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // pHONGBindingNavigatorSaveItem
            // 
            this.pHONGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pHONGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pHONGBindingNavigatorSaveItem.Image")));
            this.pHONGBindingNavigatorSaveItem.Name = "pHONGBindingNavigatorSaveItem";
            this.pHONGBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.pHONGBindingNavigatorSaveItem.Text = "Save Data";
            this.pHONGBindingNavigatorSaveItem.Click += new System.EventHandler(this.pHONGBindingNavigatorSaveItem_Click);
            // 
            // maPhongTextBox
            // 
            this.maPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "MaPhong", true));
            this.maPhongTextBox.Location = new System.Drawing.Point(216, 187);
            this.maPhongTextBox.Name = "maPhongTextBox";
            this.maPhongTextBox.Size = new System.Drawing.Size(237, 22);
            this.maPhongTextBox.TabIndex = 4;
            // 
            // tenPhongTextBox
            // 
            this.tenPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "TenPhong", true));
            this.tenPhongTextBox.Location = new System.Drawing.Point(216, 215);
            this.tenPhongTextBox.Name = "tenPhongTextBox";
            this.tenPhongTextBox.Size = new System.Drawing.Size(237, 22);
            this.tenPhongTextBox.TabIndex = 6;
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "TinhTrang", true));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(216, 243);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(237, 22);
            this.tinhTrangTextBox.TabIndex = 8;
            // 
            // maLoaiPhongTextBox
            // 
            this.maLoaiPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "MaLoaiPhong", true));
            this.maLoaiPhongTextBox.Location = new System.Drawing.Point(216, 271);
            this.maLoaiPhongTextBox.Name = "maLoaiPhongTextBox";
            this.maLoaiPhongTextBox.Size = new System.Drawing.Size(237, 22);
            this.maLoaiPhongTextBox.TabIndex = 10;
            // 
            // maThietBiTextBox
            // 
            this.maThietBiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "MaThietBi", true));
            this.maThietBiTextBox.Location = new System.Drawing.Point(216, 299);
            this.maThietBiTextBox.Name = "maThietBiTextBox";
            this.maThietBiTextBox.Size = new System.Drawing.Size(237, 22);
            this.maThietBiTextBox.TabIndex = 12;
            // 
            // maDichVuTextBox
            // 
            this.maDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBindingSource, "MaDichVu", true));
            this.maDichVuTextBox.Location = new System.Drawing.Point(216, 327);
            this.maDichVuTextBox.Name = "maDichVuTextBox";
            this.maDichVuTextBox.Size = new System.Drawing.Size(237, 22);
            this.maDichVuTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-19, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTroLaiQLTTP
            // 
            this.btnTroLaiQLTTP.Location = new System.Drawing.Point(71, 89);
            this.btnTroLaiQLTTP.Name = "btnTroLaiQLTTP";
            this.btnTroLaiQLTTP.Size = new System.Drawing.Size(75, 23);
            this.btnTroLaiQLTTP.TabIndex = 16;
            this.btnTroLaiQLTTP.Text = "Trở lại";
            this.btnTroLaiQLTTP.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(745, 654);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Xóa Dữ Liệu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(594, 654);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPhong.TabIndex = 19;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Location = new System.Drawing.Point(433, 654);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPhong.TabIndex = 18;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(284, 654);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(75, 23);
            this.btnThemPhong.TabIndex = 17;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // ufrm_CRUDPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.btnTroLaiQLTTP);
            this.Controls.Add(this.button1);
            this.Controls.Add(maPhongLabel);
            this.Controls.Add(this.maPhongTextBox);
            this.Controls.Add(tenPhongLabel);
            this.Controls.Add(this.tenPhongTextBox);
            this.Controls.Add(tinhTrangLabel);
            this.Controls.Add(this.tinhTrangTextBox);
            this.Controls.Add(maLoaiPhongLabel);
            this.Controls.Add(this.maLoaiPhongTextBox);
            this.Controls.Add(maThietBiLabel);
            this.Controls.Add(this.maThietBiTextBox);
            this.Controls.Add(maDichVuLabel);
            this.Controls.Add(this.maDichVuTextBox);
            this.Controls.Add(this.pHONGBindingNavigator);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_CRUDPhong";
            this.Size = new System.Drawing.Size(1250, 830);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingNavigator)).EndInit();
            this.pHONGBindingNavigator.ResumeLayout(false);
            this.pHONGBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HeThongKhachSanDataSet heThongKhachSanDataSet;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private HeThongKhachSanDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private HeThongKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pHONGBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pHONGBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maPhongTextBox;
        private System.Windows.Forms.TextBox tenPhongTextBox;
        private System.Windows.Forms.TextBox tinhTrangTextBox;
        private System.Windows.Forms.TextBox maLoaiPhongTextBox;
        private System.Windows.Forms.TextBox maThietBiTextBox;
        private System.Windows.Forms.TextBox maDichVuTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTroLaiQLTTP;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
    }
}
