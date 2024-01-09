namespace TestGUI1.View
{
    partial class FrmCRUDHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDHoaDon));
            System.Windows.Forms.Label idHoaDonLabel;
            System.Windows.Forms.Label idNhanVienLabel;
            System.Windows.Forms.Label idKhachHangLabel;
            System.Windows.Forms.Label idPhongLabel;
            System.Windows.Forms.Label checkInLabel;
            System.Windows.Forms.Label checkOutLabel;
            System.Windows.Forms.Label trangThaiLabel;
            System.Windows.Forms.Label tongHoaDonLabel;
            System.Windows.Forms.Label loaiNghiLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.HoaDonTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.hoaDonBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hoaDonBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hoaDonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHoaDonTextBox = new System.Windows.Forms.TextBox();
            this.idNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.idKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.idPhongTextBox = new System.Windows.Forms.TextBox();
            this.checkInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.trangThaiCheckBox = new System.Windows.Forms.CheckBox();
            this.tongHoaDonTextBox = new System.Windows.Forms.TextBox();
            this.loaiNghiTextBox = new System.Windows.Forms.TextBox();
            idHoaDonLabel = new System.Windows.Forms.Label();
            idNhanVienLabel = new System.Windows.Forms.Label();
            idKhachHangLabel = new System.Windows.Forms.Label();
            idPhongLabel = new System.Windows.Forms.Label();
            checkInLabel = new System.Windows.Forms.Label();
            checkOutLabel = new System.Windows.Forms.Label();
            trangThaiLabel = new System.Windows.Forms.Label();
            tongHoaDonLabel = new System.Windows.Forms.Label();
            loaiNghiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingNavigator)).BeginInit();
            this.hoaDonBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = null;
            this.tableAdapterManager.DatPhongTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = this.hoaDonTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoaDonBindingNavigator
            // 
            this.hoaDonBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hoaDonBindingNavigator.BindingSource = this.hoaDonBindingSource;
            this.hoaDonBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hoaDonBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hoaDonBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hoaDonBindingNavigatorSaveItem});
            this.hoaDonBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hoaDonBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hoaDonBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hoaDonBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hoaDonBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hoaDonBindingNavigator.Name = "hoaDonBindingNavigator";
            this.hoaDonBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hoaDonBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.hoaDonBindingNavigator.TabIndex = 0;
            this.hoaDonBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // hoaDonBindingNavigatorSaveItem
            // 
            this.hoaDonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hoaDonBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hoaDonBindingNavigatorSaveItem.Image")));
            this.hoaDonBindingNavigatorSaveItem.Name = "hoaDonBindingNavigatorSaveItem";
            this.hoaDonBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hoaDonBindingNavigatorSaveItem.Text = "Save Data";
            this.hoaDonBindingNavigatorSaveItem.Click += new System.EventHandler(this.hoaDonBindingNavigatorSaveItem_Click);
            // 
            // hoaDonDataGridView
            // 
            this.hoaDonDataGridView.AutoGenerateColumns = false;
            this.hoaDonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.hoaDonDataGridView.DataSource = this.hoaDonBindingSource;
            this.hoaDonDataGridView.Location = new System.Drawing.Point(14, 170);
            this.hoaDonDataGridView.Name = "hoaDonDataGridView";
            this.hoaDonDataGridView.Size = new System.Drawing.Size(654, 220);
            this.hoaDonDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdHoaDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdHoaDon";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idNhanVien";
            this.dataGridViewTextBoxColumn2.HeaderText = "idNhanVien";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idKhachHang";
            this.dataGridViewTextBoxColumn3.HeaderText = "idKhachHang";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idPhong";
            this.dataGridViewTextBoxColumn4.HeaderText = "idPhong";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CheckIn";
            this.dataGridViewTextBoxColumn5.HeaderText = "CheckIn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CheckOut";
            this.dataGridViewTextBoxColumn6.HeaderText = "CheckOut";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "TrangThai";
            this.dataGridViewCheckBoxColumn1.HeaderText = "TrangThai";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TongHoaDon";
            this.dataGridViewTextBoxColumn7.HeaderText = "TongHoaDon";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LoaiNghi";
            this.dataGridViewTextBoxColumn8.HeaderText = "LoaiNghi";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idHoaDonLabel
            // 
            idHoaDonLabel.AutoSize = true;
            idHoaDonLabel.Location = new System.Drawing.Point(11, 41);
            idHoaDonLabel.Name = "idHoaDonLabel";
            idHoaDonLabel.Size = new System.Drawing.Size(65, 13);
            idHoaDonLabel.TabIndex = 2;
            idHoaDonLabel.Text = "Id Hoa Don:";
            // 
            // idHoaDonTextBox
            // 
            this.idHoaDonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "IdHoaDon", true));
            this.idHoaDonTextBox.Location = new System.Drawing.Point(98, 38);
            this.idHoaDonTextBox.Name = "idHoaDonTextBox";
            this.idHoaDonTextBox.Size = new System.Drawing.Size(200, 20);
            this.idHoaDonTextBox.TabIndex = 3;
            // 
            // idNhanVienLabel
            // 
            idNhanVienLabel.AutoSize = true;
            idNhanVienLabel.Location = new System.Drawing.Point(11, 67);
            idNhanVienLabel.Name = "idNhanVienLabel";
            idNhanVienLabel.Size = new System.Drawing.Size(71, 13);
            idNhanVienLabel.TabIndex = 4;
            idNhanVienLabel.Text = "id Nhan Vien:";
            // 
            // idNhanVienTextBox
            // 
            this.idNhanVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "idNhanVien", true));
            this.idNhanVienTextBox.Location = new System.Drawing.Point(98, 64);
            this.idNhanVienTextBox.Name = "idNhanVienTextBox";
            this.idNhanVienTextBox.Size = new System.Drawing.Size(200, 20);
            this.idNhanVienTextBox.TabIndex = 5;
            // 
            // idKhachHangLabel
            // 
            idKhachHangLabel.AutoSize = true;
            idKhachHangLabel.Location = new System.Drawing.Point(11, 93);
            idKhachHangLabel.Name = "idKhachHangLabel";
            idKhachHangLabel.Size = new System.Drawing.Size(81, 13);
            idKhachHangLabel.TabIndex = 6;
            idKhachHangLabel.Text = "id Khach Hang:";
            // 
            // idKhachHangTextBox
            // 
            this.idKhachHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "idKhachHang", true));
            this.idKhachHangTextBox.Location = new System.Drawing.Point(98, 90);
            this.idKhachHangTextBox.Name = "idKhachHangTextBox";
            this.idKhachHangTextBox.Size = new System.Drawing.Size(200, 20);
            this.idKhachHangTextBox.TabIndex = 7;
            // 
            // idPhongLabel
            // 
            idPhongLabel.AutoSize = true;
            idPhongLabel.Location = new System.Drawing.Point(11, 119);
            idPhongLabel.Name = "idPhongLabel";
            idPhongLabel.Size = new System.Drawing.Size(52, 13);
            idPhongLabel.TabIndex = 8;
            idPhongLabel.Text = "id Phong:";
            // 
            // idPhongTextBox
            // 
            this.idPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "idPhong", true));
            this.idPhongTextBox.Location = new System.Drawing.Point(98, 116);
            this.idPhongTextBox.Name = "idPhongTextBox";
            this.idPhongTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPhongTextBox.TabIndex = 9;
            // 
            // checkInLabel
            // 
            checkInLabel.AutoSize = true;
            checkInLabel.Location = new System.Drawing.Point(342, 16);
            checkInLabel.Name = "checkInLabel";
            checkInLabel.Size = new System.Drawing.Size(53, 13);
            checkInLabel.TabIndex = 10;
            checkInLabel.Text = "Check In:";
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hoaDonBindingSource, "CheckIn", true));
            this.checkInDateTimePicker.Location = new System.Drawing.Point(429, 12);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.checkInDateTimePicker.TabIndex = 11;
            // 
            // checkOutLabel
            // 
            checkOutLabel.AutoSize = true;
            checkOutLabel.Location = new System.Drawing.Point(342, 42);
            checkOutLabel.Name = "checkOutLabel";
            checkOutLabel.Size = new System.Drawing.Size(61, 13);
            checkOutLabel.TabIndex = 12;
            checkOutLabel.Text = "Check Out:";
            // 
            // checkOutDateTimePicker
            // 
            this.checkOutDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hoaDonBindingSource, "CheckOut", true));
            this.checkOutDateTimePicker.Location = new System.Drawing.Point(429, 38);
            this.checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            this.checkOutDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.checkOutDateTimePicker.TabIndex = 13;
            // 
            // trangThaiLabel
            // 
            trangThaiLabel.AutoSize = true;
            trangThaiLabel.Location = new System.Drawing.Point(342, 69);
            trangThaiLabel.Name = "trangThaiLabel";
            trangThaiLabel.Size = new System.Drawing.Size(62, 13);
            trangThaiLabel.TabIndex = 14;
            trangThaiLabel.Text = "Trang Thai:";
            // 
            // trangThaiCheckBox
            // 
            this.trangThaiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.hoaDonBindingSource, "TrangThai", true));
            this.trangThaiCheckBox.Location = new System.Drawing.Point(429, 64);
            this.trangThaiCheckBox.Name = "trangThaiCheckBox";
            this.trangThaiCheckBox.Size = new System.Drawing.Size(200, 24);
            this.trangThaiCheckBox.TabIndex = 15;
            this.trangThaiCheckBox.Text = "checkBox1";
            this.trangThaiCheckBox.UseVisualStyleBackColor = true;
            // 
            // tongHoaDonLabel
            // 
            tongHoaDonLabel.AutoSize = true;
            tongHoaDonLabel.Location = new System.Drawing.Point(342, 97);
            tongHoaDonLabel.Name = "tongHoaDonLabel";
            tongHoaDonLabel.Size = new System.Drawing.Size(81, 13);
            tongHoaDonLabel.TabIndex = 16;
            tongHoaDonLabel.Text = "Tong Hoa Don:";
            // 
            // tongHoaDonTextBox
            // 
            this.tongHoaDonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "TongHoaDon", true));
            this.tongHoaDonTextBox.Location = new System.Drawing.Point(429, 94);
            this.tongHoaDonTextBox.Name = "tongHoaDonTextBox";
            this.tongHoaDonTextBox.Size = new System.Drawing.Size(200, 20);
            this.tongHoaDonTextBox.TabIndex = 17;
            // 
            // loaiNghiLabel
            // 
            loaiNghiLabel.AutoSize = true;
            loaiNghiLabel.Location = new System.Drawing.Point(342, 123);
            loaiNghiLabel.Name = "loaiNghiLabel";
            loaiNghiLabel.Size = new System.Drawing.Size(55, 13);
            loaiNghiLabel.TabIndex = 18;
            loaiNghiLabel.Text = "Loai Nghi:";
            // 
            // loaiNghiTextBox
            // 
            this.loaiNghiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "LoaiNghi", true));
            this.loaiNghiTextBox.Location = new System.Drawing.Point(429, 120);
            this.loaiNghiTextBox.Name = "loaiNghiTextBox";
            this.loaiNghiTextBox.Size = new System.Drawing.Size(200, 20);
            this.loaiNghiTextBox.TabIndex = 19;
            // 
            // FormCRUDHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idHoaDonLabel);
            this.Controls.Add(this.idHoaDonTextBox);
            this.Controls.Add(idNhanVienLabel);
            this.Controls.Add(this.idNhanVienTextBox);
            this.Controls.Add(idKhachHangLabel);
            this.Controls.Add(this.idKhachHangTextBox);
            this.Controls.Add(idPhongLabel);
            this.Controls.Add(this.idPhongTextBox);
            this.Controls.Add(checkInLabel);
            this.Controls.Add(this.checkInDateTimePicker);
            this.Controls.Add(checkOutLabel);
            this.Controls.Add(this.checkOutDateTimePicker);
            this.Controls.Add(trangThaiLabel);
            this.Controls.Add(this.trangThaiCheckBox);
            this.Controls.Add(tongHoaDonLabel);
            this.Controls.Add(this.tongHoaDonTextBox);
            this.Controls.Add(loaiNghiLabel);
            this.Controls.Add(this.loaiNghiTextBox);
            this.Controls.Add(this.hoaDonDataGridView);
            this.Controls.Add(this.hoaDonBindingNavigator);
            this.Name = "FormCRUDHoaDon";
            this.Text = "FormCRUDHoaDon";
            this.Load += new System.EventHandler(this.FormCRUDHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingNavigator)).EndInit();
            this.hoaDonBindingNavigator.ResumeLayout(false);
            this.hoaDonBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hoaDonBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hoaDonBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hoaDonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idHoaDonTextBox;
        private System.Windows.Forms.TextBox idNhanVienTextBox;
        private System.Windows.Forms.TextBox idKhachHangTextBox;
        private System.Windows.Forms.TextBox idPhongTextBox;
        private System.Windows.Forms.DateTimePicker checkInDateTimePicker;
        private System.Windows.Forms.DateTimePicker checkOutDateTimePicker;
        private System.Windows.Forms.CheckBox trangThaiCheckBox;
        private System.Windows.Forms.TextBox tongHoaDonTextBox;
        private System.Windows.Forms.TextBox loaiNghiTextBox;
    }
}