namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    partial class ufrm_CRUDTang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufrm_CRUDTang));
            System.Windows.Forms.Label maTangLabel;
            System.Windows.Forms.Label tenTangLabel;
            this.data_Tang = new System.Windows.Forms.DataGridView();
            this.txtTimKiemTang = new System.Windows.Forms.TextBox();
            this.btnClearTang = new System.Windows.Forms.Button();
            this.btnXoaTang = new System.Windows.Forms.Button();
            this.btnSuaTang = new System.Windows.Forms.Button();
            this.btnThemTang = new System.Windows.Forms.Button();
            this.btnTroLaiTang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.heThongKhachSanDataSet1 = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet1();
            this.tangLauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tangLauTableAdapter = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet1TableAdapters.TangLauTableAdapter();
            this.tableAdapterManager = new DoAn_QuanLyKhachSan.HeThongKhachSanDataSet1TableAdapters.TableAdapterManager();
            this.tangLauBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tangLauBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.maTangTextBox = new System.Windows.Forms.TextBox();
            this.tenTangTextBox = new System.Windows.Forms.TextBox();
            maTangLabel = new System.Windows.Forms.Label();
            tenTangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Tang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangLauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangLauBindingNavigator)).BeginInit();
            this.tangLauBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_Tang
            // 
            this.data_Tang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Tang.Location = new System.Drawing.Point(431, 251);
            this.data_Tang.Name = "data_Tang";
            this.data_Tang.RowHeadersWidth = 51;
            this.data_Tang.RowTemplate.Height = 24;
            this.data_Tang.Size = new System.Drawing.Size(703, 364);
            this.data_Tang.TabIndex = 65;
            // 
            // txtTimKiemTang
            // 
            this.txtTimKiemTang.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTimKiemTang.Location = new System.Drawing.Point(431, 213);
            this.txtTimKiemTang.Name = "txtTimKiemTang";
            this.txtTimKiemTang.Size = new System.Drawing.Size(703, 22);
            this.txtTimKiemTang.TabIndex = 64;
            // 
            // btnClearTang
            // 
            this.btnClearTang.Location = new System.Drawing.Point(623, 634);
            this.btnClearTang.Name = "btnClearTang";
            this.btnClearTang.Size = new System.Drawing.Size(135, 23);
            this.btnClearTang.TabIndex = 63;
            this.btnClearTang.Text = "Xóa Dữ Liệu";
            this.btnClearTang.UseVisualStyleBackColor = true;
            // 
            // btnXoaTang
            // 
            this.btnXoaTang.Location = new System.Drawing.Point(472, 634);
            this.btnXoaTang.Name = "btnXoaTang";
            this.btnXoaTang.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTang.TabIndex = 62;
            this.btnXoaTang.Text = "Xóa";
            this.btnXoaTang.UseVisualStyleBackColor = true;
            // 
            // btnSuaTang
            // 
            this.btnSuaTang.Location = new System.Drawing.Point(311, 634);
            this.btnSuaTang.Name = "btnSuaTang";
            this.btnSuaTang.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTang.TabIndex = 61;
            this.btnSuaTang.Text = "Sửa";
            this.btnSuaTang.UseVisualStyleBackColor = true;
            // 
            // btnThemTang
            // 
            this.btnThemTang.Location = new System.Drawing.Point(162, 634);
            this.btnThemTang.Name = "btnThemTang";
            this.btnThemTang.Size = new System.Drawing.Size(75, 23);
            this.btnThemTang.TabIndex = 60;
            this.btnThemTang.Text = "Thêm";
            this.btnThemTang.UseVisualStyleBackColor = true;
            // 
            // btnTroLaiTang
            // 
            this.btnTroLaiTang.Location = new System.Drawing.Point(60, 174);
            this.btnTroLaiTang.Name = "btnTroLaiTang";
            this.btnTroLaiTang.Size = new System.Drawing.Size(75, 23);
            this.btnTroLaiTang.TabIndex = 59;
            this.btnTroLaiTang.Text = "Trở lại";
            this.btnTroLaiTang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "QUẢN LÝ TẦNG";
            // 
            // heThongKhachSanDataSet1
            // 
            this.heThongKhachSanDataSet1.DataSetName = "HeThongKhachSanDataSet1";
            this.heThongKhachSanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tangLauBindingSource
            // 
            this.tangLauBindingSource.DataMember = "TangLau";
            this.tangLauBindingSource.DataSource = this.heThongKhachSanDataSet1;
            // 
            // tangLauTableAdapter
            // 
            this.tangLauTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TangLauTableAdapter = this.tangLauTableAdapter;
            this.tableAdapterManager.THIET_BITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAn_QuanLyKhachSan.HeThongKhachSanDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tangLauBindingNavigator
            // 
            this.tangLauBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tangLauBindingNavigator.BindingSource = this.tangLauBindingSource;
            this.tangLauBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tangLauBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tangLauBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tangLauBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tangLauBindingNavigatorSaveItem});
            this.tangLauBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tangLauBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tangLauBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tangLauBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tangLauBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tangLauBindingNavigator.Name = "tangLauBindingNavigator";
            this.tangLauBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tangLauBindingNavigator.Size = new System.Drawing.Size(1191, 27);
            this.tangLauBindingNavigator.TabIndex = 83;
            this.tangLauBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // tangLauBindingNavigatorSaveItem
            // 
            this.tangLauBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tangLauBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tangLauBindingNavigatorSaveItem.Image")));
            this.tangLauBindingNavigatorSaveItem.Name = "tangLauBindingNavigatorSaveItem";
            this.tangLauBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tangLauBindingNavigatorSaveItem.Text = "Save Data";
            this.tangLauBindingNavigatorSaveItem.Click += new System.EventHandler(this.tangLauBindingNavigatorSaveItem_Click_1);
            // 
            // maTangLabel
            // 
            maTangLabel.AutoSize = true;
            maTangLabel.Location = new System.Drawing.Point(91, 279);
            maTangLabel.Name = "maTangLabel";
            maTangLabel.Size = new System.Drawing.Size(64, 16);
            maTangLabel.TabIndex = 83;
            maTangLabel.Text = "Ma Tang:";
            // 
            // maTangTextBox
            // 
            this.maTangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tangLauBindingSource, "MaTang", true));
            this.maTangTextBox.Location = new System.Drawing.Point(166, 276);
            this.maTangTextBox.Name = "maTangTextBox";
            this.maTangTextBox.Size = new System.Drawing.Size(100, 22);
            this.maTangTextBox.TabIndex = 84;
            // 
            // tenTangLabel
            // 
            tenTangLabel.AutoSize = true;
            tenTangLabel.Location = new System.Drawing.Point(91, 307);
            tenTangLabel.Name = "tenTangLabel";
            tenTangLabel.Size = new System.Drawing.Size(69, 16);
            tenTangLabel.TabIndex = 85;
            tenTangLabel.Text = "Ten Tang:";
            // 
            // tenTangTextBox
            // 
            this.tenTangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tangLauBindingSource, "TenTang", true));
            this.tenTangTextBox.Location = new System.Drawing.Point(166, 304);
            this.tenTangTextBox.Name = "tenTangTextBox";
            this.tenTangTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenTangTextBox.TabIndex = 86;
            // 
            // ufrm_CRUDTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(maTangLabel);
            this.Controls.Add(this.maTangTextBox);
            this.Controls.Add(tenTangLabel);
            this.Controls.Add(this.tenTangTextBox);
            this.Controls.Add(this.tangLauBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_Tang);
            this.Controls.Add(this.txtTimKiemTang);
            this.Controls.Add(this.btnClearTang);
            this.Controls.Add(this.btnXoaTang);
            this.Controls.Add(this.btnSuaTang);
            this.Controls.Add(this.btnThemTang);
            this.Controls.Add(this.btnTroLaiTang);
            this.Name = "ufrm_CRUDTang";
            this.Size = new System.Drawing.Size(1191, 830);
            ((System.ComponentModel.ISupportInitialize)(this.data_Tang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heThongKhachSanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangLauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangLauBindingNavigator)).EndInit();
            this.tangLauBindingNavigator.ResumeLayout(false);
            this.tangLauBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data_Tang;
        private System.Windows.Forms.TextBox txtTimKiemTang;
        private System.Windows.Forms.Button btnClearTang;
        private System.Windows.Forms.Button btnXoaTang;
        private System.Windows.Forms.Button btnSuaTang;
        private System.Windows.Forms.Button btnThemTang;
        private System.Windows.Forms.Button btnTroLaiTang;
        private System.Windows.Forms.Label label1;
        private HeThongKhachSanDataSet1 heThongKhachSanDataSet1;
        private System.Windows.Forms.BindingSource tangLauBindingSource;
        private HeThongKhachSanDataSet1TableAdapters.TangLauTableAdapter tangLauTableAdapter;
        private HeThongKhachSanDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tangLauBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tangLauBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maTangTextBox;
        private System.Windows.Forms.TextBox tenTangTextBox;
    }
}
