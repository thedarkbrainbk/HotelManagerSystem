namespace TestGUI1.View
{
    partial class FrmCRUDDanhSachPhong
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idPhongLabel;
            System.Windows.Forms.Label idLoaiPhongLabel;
            System.Windows.Forms.Label tinhTrangPhongLabel;
            System.Windows.Forms.Label isVipLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDDanhSachPhong));
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.PhongTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.phongBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.phongBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.phongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idPhongTextBox = new System.Windows.Forms.TextBox();
            this.idLoaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangPhongTextBox = new System.Windows.Forms.TextBox();
            this.isVipCheckBox = new System.Windows.Forms.CheckBox();
            this.loaiPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiPhongTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.LoaiPhongTableAdapter();
            this.loaiPhongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idPhongLabel = new System.Windows.Forms.Label();
            idLoaiPhongLabel = new System.Windows.Forms.Label();
            tinhTrangPhongLabel = new System.Windows.Forms.Label();
            isVipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingNavigator)).BeginInit();
            this.phongBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idPhongLabel
            // 
            idPhongLabel.AutoSize = true;
            idPhongLabel.Location = new System.Drawing.Point(14, 46);
            idPhongLabel.Name = "idPhongLabel";
            idPhongLabel.Size = new System.Drawing.Size(53, 13);
            idPhongLabel.TabIndex = 2;
            idPhongLabel.Text = "Id Phong:";
            // 
            // idLoaiPhongLabel
            // 
            idLoaiPhongLabel.AutoSize = true;
            idLoaiPhongLabel.Location = new System.Drawing.Point(14, 72);
            idLoaiPhongLabel.Name = "idLoaiPhongLabel";
            idLoaiPhongLabel.Size = new System.Drawing.Size(75, 13);
            idLoaiPhongLabel.TabIndex = 4;
            idLoaiPhongLabel.Text = "id Loai Phong:";
            // 
            // tinhTrangPhongLabel
            // 
            tinhTrangPhongLabel.AutoSize = true;
            tinhTrangPhongLabel.Location = new System.Drawing.Point(14, 98);
            tinhTrangPhongLabel.Name = "tinhTrangPhongLabel";
            tinhTrangPhongLabel.Size = new System.Drawing.Size(96, 13);
            tinhTrangPhongLabel.TabIndex = 6;
            tinhTrangPhongLabel.Text = "Tinh Trang Phong:";
            // 
            // isVipLabel
            // 
            isVipLabel.AutoSize = true;
            isVipLabel.Location = new System.Drawing.Point(14, 126);
            isVipLabel.Name = "isVipLabel";
            isVipLabel.Size = new System.Drawing.Size(36, 13);
            isVipLabel.TabIndex = 8;
            isVipLabel.Text = "Is Vip:";
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = null;
            this.tableAdapterManager.DatPhongTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = this.phongTableAdapter;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phongBindingNavigator
            // 
            this.phongBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phongBindingNavigator.BindingSource = this.phongBindingSource;
            this.phongBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phongBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phongBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.phongBindingNavigatorSaveItem});
            this.phongBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phongBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phongBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phongBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phongBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phongBindingNavigator.Name = "phongBindingNavigator";
            this.phongBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phongBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.phongBindingNavigator.TabIndex = 0;
            this.phongBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // phongBindingNavigatorSaveItem
            // 
            this.phongBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phongBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phongBindingNavigatorSaveItem.Image")));
            this.phongBindingNavigatorSaveItem.Name = "phongBindingNavigatorSaveItem";
            this.phongBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.phongBindingNavigatorSaveItem.Text = "Save Data";
            this.phongBindingNavigatorSaveItem.Click += new System.EventHandler(this.phongBindingNavigatorSaveItem_Click);
            // 
            // phongDataGridView
            // 
            this.phongDataGridView.AutoGenerateColumns = false;
            this.phongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.phongDataGridView.DataSource = this.phongBindingSource;
            this.phongDataGridView.Location = new System.Drawing.Point(226, 28);
            this.phongDataGridView.Name = "phongDataGridView";
            this.phongDataGridView.Size = new System.Drawing.Size(481, 212);
            this.phongDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPhong";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPhong";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idLoaiPhong";
            this.dataGridViewTextBoxColumn2.HeaderText = "idLoaiPhong";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TinhTrangPhong";
            this.dataGridViewTextBoxColumn3.HeaderText = "TinhTrangPhong";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsVip";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsVip";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // idPhongTextBox
            // 
            this.idPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBindingSource, "IdPhong", true));
            this.idPhongTextBox.Location = new System.Drawing.Point(116, 43);
            this.idPhongTextBox.Name = "idPhongTextBox";
            this.idPhongTextBox.Size = new System.Drawing.Size(104, 20);
            this.idPhongTextBox.TabIndex = 3;
            // 
            // idLoaiPhongTextBox
            // 
            this.idLoaiPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBindingSource, "idLoaiPhong", true));
            this.idLoaiPhongTextBox.Location = new System.Drawing.Point(116, 69);
            this.idLoaiPhongTextBox.Name = "idLoaiPhongTextBox";
            this.idLoaiPhongTextBox.Size = new System.Drawing.Size(104, 20);
            this.idLoaiPhongTextBox.TabIndex = 5;
            // 
            // tinhTrangPhongTextBox
            // 
            this.tinhTrangPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phongBindingSource, "TinhTrangPhong", true));
            this.tinhTrangPhongTextBox.Location = new System.Drawing.Point(116, 95);
            this.tinhTrangPhongTextBox.Name = "tinhTrangPhongTextBox";
            this.tinhTrangPhongTextBox.Size = new System.Drawing.Size(104, 20);
            this.tinhTrangPhongTextBox.TabIndex = 7;
            // 
            // isVipCheckBox
            // 
            this.isVipCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.phongBindingSource, "IsVip", true));
            this.isVipCheckBox.Location = new System.Drawing.Point(116, 121);
            this.isVipCheckBox.Name = "isVipCheckBox";
            this.isVipCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isVipCheckBox.TabIndex = 9;
            this.isVipCheckBox.Text = "checkBox1";
            this.isVipCheckBox.UseVisualStyleBackColor = true;
            // 
            // loaiPhongBindingSource
            // 
            this.loaiPhongBindingSource.DataMember = "LoaiPhong";
            this.loaiPhongBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // loaiPhongTableAdapter
            // 
            this.loaiPhongTableAdapter.ClearBeforeFill = true;
            // 
            // loaiPhongDataGridView
            // 
            this.loaiPhongDataGridView.AutoGenerateColumns = false;
            this.loaiPhongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaiPhongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.loaiPhongDataGridView.DataSource = this.loaiPhongBindingSource;
            this.loaiPhongDataGridView.Location = new System.Drawing.Point(0, 246);
            this.loaiPhongDataGridView.Name = "loaiPhongDataGridView";
            this.loaiPhongDataGridView.Size = new System.Drawing.Size(707, 192);
            this.loaiPhongDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdLoaiPhong";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdLoaiPhong";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenLoaiPhong";
            this.dataGridViewTextBoxColumn5.HeaderText = "TenLoaiPhong";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoNguoi";
            this.dataGridViewTextBoxColumn6.HeaderText = "SoNguoi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GiaGioDau";
            this.dataGridViewTextBoxColumn7.HeaderText = "GiaGioDau";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GiaGioTiepTheo";
            this.dataGridViewTextBoxColumn8.HeaderText = "GiaGioTiepTheo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "GiaQuaDem";
            this.dataGridViewTextBoxColumn9.HeaderText = "GiaQuaDem";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GiaTheoNgay";
            this.dataGridViewTextBoxColumn10.HeaderText = "GiaTheoNgay";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FrmCRUDDanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loaiPhongDataGridView);
            this.Controls.Add(idPhongLabel);
            this.Controls.Add(this.idPhongTextBox);
            this.Controls.Add(idLoaiPhongLabel);
            this.Controls.Add(this.idLoaiPhongTextBox);
            this.Controls.Add(tinhTrangPhongLabel);
            this.Controls.Add(this.tinhTrangPhongTextBox);
            this.Controls.Add(isVipLabel);
            this.Controls.Add(this.isVipCheckBox);
            this.Controls.Add(this.phongDataGridView);
            this.Controls.Add(this.phongBindingNavigator);
            this.Name = "FrmCRUDDanhSachPhong";
            this.Text = "FormCRUDDanhSachPhong";
            this.Load += new System.EventHandler(this.FormCRUDDanhSachPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingNavigator)).EndInit();
            this.phongBindingNavigator.ResumeLayout(false);
            this.phongBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.PhongTableAdapter phongTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phongBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton phongBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView phongDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox idPhongTextBox;
        private System.Windows.Forms.TextBox idLoaiPhongTextBox;
        private System.Windows.Forms.TextBox tinhTrangPhongTextBox;
        private System.Windows.Forms.CheckBox isVipCheckBox;
        private System.Windows.Forms.BindingSource loaiPhongBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.LoaiPhongTableAdapter loaiPhongTableAdapter;
        private System.Windows.Forms.DataGridView loaiPhongDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}