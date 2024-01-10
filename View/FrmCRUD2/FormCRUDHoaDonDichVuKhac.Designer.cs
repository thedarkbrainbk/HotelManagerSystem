namespace TestGUI1.View.FrmChinh
{
    partial class FormCRUDHoaDonDichVuKhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUDHoaDonDichVuKhac));
            System.Windows.Forms.Label idHoaDonDichVuKhacLabel;
            System.Windows.Forms.Label idHoaDonLabel;
            System.Windows.Forms.Label idNhanVienLabel;
            System.Windows.Forms.Label idKhachHangLabel;
            System.Windows.Forms.Label tenDichVuKhacLabel;
            System.Windows.Forms.Label thoiGianLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.Windows.Forms.Label thanhTienLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.hoaDonDichVuKhacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonDichVuKhacTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.HoaDonDichVuKhacTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.hoaDonDichVuKhacBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hoaDonDichVuKhacBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hoaDonDichVuKhacDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHoaDonDichVuKhacTextBox = new System.Windows.Forms.TextBox();
            this.idHoaDonTextBox = new System.Windows.Forms.TextBox();
            this.idNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.idKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.tenDichVuKhacTextBox = new System.Windows.Forms.TextBox();
            this.thoiGianDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.thanhTienTextBox = new System.Windows.Forms.TextBox();
            idHoaDonDichVuKhacLabel = new System.Windows.Forms.Label();
            idHoaDonLabel = new System.Windows.Forms.Label();
            idNhanVienLabel = new System.Windows.Forms.Label();
            idKhachHangLabel = new System.Windows.Forms.Label();
            tenDichVuKhacLabel = new System.Windows.Forms.Label();
            thoiGianLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            thanhTienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuKhacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuKhacBindingNavigator)).BeginInit();
            this.hoaDonDichVuKhacBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuKhacDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonDichVuKhacBindingSource
            // 
            this.hoaDonDichVuKhacBindingSource.DataMember = "HoaDonDichVuKhac";
            this.hoaDonDichVuKhacBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // hoaDonDichVuKhacTableAdapter
            // 
            this.hoaDonDichVuKhacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = null;
            this.tableAdapterManager.DichVuKhacTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuKhacTableAdapter = this.hoaDonDichVuKhacTableAdapter;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LichDatPhongTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoaDonDichVuKhacBindingNavigator
            // 
            this.hoaDonDichVuKhacBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hoaDonDichVuKhacBindingNavigator.BindingSource = this.hoaDonDichVuKhacBindingSource;
            this.hoaDonDichVuKhacBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hoaDonDichVuKhacBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hoaDonDichVuKhacBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hoaDonDichVuKhacBindingNavigatorSaveItem});
            this.hoaDonDichVuKhacBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hoaDonDichVuKhacBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hoaDonDichVuKhacBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hoaDonDichVuKhacBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hoaDonDichVuKhacBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hoaDonDichVuKhacBindingNavigator.Name = "hoaDonDichVuKhacBindingNavigator";
            this.hoaDonDichVuKhacBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hoaDonDichVuKhacBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.hoaDonDichVuKhacBindingNavigator.TabIndex = 0;
            this.hoaDonDichVuKhacBindingNavigator.Text = "bindingNavigator1";
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
            // hoaDonDichVuKhacBindingNavigatorSaveItem
            // 
            this.hoaDonDichVuKhacBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hoaDonDichVuKhacBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hoaDonDichVuKhacBindingNavigatorSaveItem.Image")));
            this.hoaDonDichVuKhacBindingNavigatorSaveItem.Name = "hoaDonDichVuKhacBindingNavigatorSaveItem";
            this.hoaDonDichVuKhacBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hoaDonDichVuKhacBindingNavigatorSaveItem.Text = "Save Data";
            this.hoaDonDichVuKhacBindingNavigatorSaveItem.Click += new System.EventHandler(this.hoaDonDichVuKhacBindingNavigatorSaveItem_Click);
            // 
            // hoaDonDichVuKhacDataGridView
            // 
            this.hoaDonDichVuKhacDataGridView.AutoGenerateColumns = false;
            this.hoaDonDichVuKhacDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonDichVuKhacDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.hoaDonDichVuKhacDataGridView.DataSource = this.hoaDonDichVuKhacBindingSource;
            this.hoaDonDichVuKhacDataGridView.Location = new System.Drawing.Point(0, 150);
            this.hoaDonDichVuKhacDataGridView.Name = "hoaDonDichVuKhacDataGridView";
            this.hoaDonDichVuKhacDataGridView.Size = new System.Drawing.Size(797, 220);
            this.hoaDonDichVuKhacDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdHoaDonDichVuKhac";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdHoaDonDichVuKhac";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdHoaDon";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdHoaDon";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdNhanVien";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdNhanVien";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdKhachHang";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdKhachHang";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenDichVuKhac";
            this.dataGridViewTextBoxColumn5.HeaderText = "TenDichVuKhac";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ThoiGian";
            this.dataGridViewTextBoxColumn6.HeaderText = "ThoiGian";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn7.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn8.HeaderText = "ThanhTien";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idHoaDonDichVuKhacLabel
            // 
            idHoaDonDichVuKhacLabel.AutoSize = true;
            idHoaDonDichVuKhacLabel.Location = new System.Drawing.Point(11, 30);
            idHoaDonDichVuKhacLabel.Name = "idHoaDonDichVuKhacLabel";
            idHoaDonDichVuKhacLabel.Size = new System.Drawing.Size(134, 13);
            idHoaDonDichVuKhacLabel.TabIndex = 2;
            idHoaDonDichVuKhacLabel.Text = "Id Hoa Don Dich Vu Khac:";
            // 
            // idHoaDonDichVuKhacTextBox
            // 
            this.idHoaDonDichVuKhacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuKhacBindingSource, "IdHoaDonDichVuKhac", true));
            this.idHoaDonDichVuKhacTextBox.Location = new System.Drawing.Point(151, 27);
            this.idHoaDonDichVuKhacTextBox.Name = "idHoaDonDichVuKhacTextBox";
            this.idHoaDonDichVuKhacTextBox.Size = new System.Drawing.Size(200, 20);
            this.idHoaDonDichVuKhacTextBox.TabIndex = 3;
            // 
            // idHoaDonLabel
            // 
            idHoaDonLabel.AutoSize = true;
            idHoaDonLabel.Location = new System.Drawing.Point(11, 56);
            idHoaDonLabel.Name = "idHoaDonLabel";
            idHoaDonLabel.Size = new System.Drawing.Size(65, 13);
            idHoaDonLabel.TabIndex = 4;
            idHoaDonLabel.Text = "Id Hoa Don:";
            // 
            // idHoaDonTextBox
            // 
            this.idHoaDonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuKhacBindingSource, "IdHoaDon", true));
            this.idHoaDonTextBox.Location = new System.Drawing.Point(151, 53);
            this.idHoaDonTextBox.Name = "idHoaDonTextBox";
            this.idHoaDonTextBox.Size = new System.Drawing.Size(200, 20);
            this.idHoaDonTextBox.TabIndex = 5;
            // 
            // idNhanVienLabel
            // 
            idNhanVienLabel.AutoSize = true;
            idNhanVienLabel.Location = new System.Drawing.Point(11, 82);
            idNhanVienLabel.Name = "idNhanVienLabel";
            idNhanVienLabel.Size = new System.Drawing.Size(72, 13);
            idNhanVienLabel.TabIndex = 6;
            idNhanVienLabel.Text = "Id Nhan Vien:";
            // 
            // idNhanVienTextBox
            // 
            this.idNhanVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuKhacBindingSource, "IdNhanVien", true));
            this.idNhanVienTextBox.Location = new System.Drawing.Point(151, 79);
            this.idNhanVienTextBox.Name = "idNhanVienTextBox";
            this.idNhanVienTextBox.Size = new System.Drawing.Size(200, 20);
            this.idNhanVienTextBox.TabIndex = 7;
            // 
            // idKhachHangLabel
            // 
            idKhachHangLabel.AutoSize = true;
            idKhachHangLabel.Location = new System.Drawing.Point(11, 108);
            idKhachHangLabel.Name = "idKhachHangLabel";
            idKhachHangLabel.Size = new System.Drawing.Size(82, 13);
            idKhachHangLabel.TabIndex = 8;
            idKhachHangLabel.Text = "Id Khach Hang:";
            // 
            // idKhachHangTextBox
            // 
            this.idKhachHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuKhacBindingSource, "IdKhachHang", true));
            this.idKhachHangTextBox.Location = new System.Drawing.Point(151, 105);
            this.idKhachHangTextBox.Name = "idKhachHangTextBox";
            this.idKhachHangTextBox.Size = new System.Drawing.Size(200, 20);
            this.idKhachHangTextBox.TabIndex = 9;
            // 
            // tenDichVuKhacLabel
            // 
            tenDichVuKhacLabel.AutoSize = true;
            tenDichVuKhacLabel.Location = new System.Drawing.Point(383, 33);
            tenDichVuKhacLabel.Name = "tenDichVuKhacLabel";
            tenDichVuKhacLabel.Size = new System.Drawing.Size(98, 13);
            tenDichVuKhacLabel.TabIndex = 10;
            tenDichVuKhacLabel.Text = "Ten Dich Vu Khac:";
            // 
            // tenDichVuKhacTextBox
            // 
            this.tenDichVuKhacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuKhacBindingSource, "TenDichVuKhac", true));
            this.tenDichVuKhacTextBox.Location = new System.Drawing.Point(523, 30);
            this.tenDichVuKhacTextBox.Name = "tenDichVuKhacTextBox";
            this.tenDichVuKhacTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenDichVuKhacTextBox.TabIndex = 11;
            // 
            // thoiGianLabel
            // 
            thoiGianLabel.AutoSize = true;
            thoiGianLabel.Location = new System.Drawing.Point(383, 60);
            thoiGianLabel.Name = "thoiGianLabel";
            thoiGianLabel.Size = new System.Drawing.Size(56, 13);
            thoiGianLabel.TabIndex = 12;
            thoiGianLabel.Text = "Thoi Gian:";
            // 
            // thoiGianDateTimePicker
            // 
            this.thoiGianDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hoaDonDichVuKhacBindingSource, "ThoiGian", true));
            this.thoiGianDateTimePicker.Location = new System.Drawing.Point(523, 56);
            this.thoiGianDateTimePicker.Name = "thoiGianDateTimePicker";
            this.thoiGianDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.thoiGianDateTimePicker.TabIndex = 13;
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(383, 85);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(48, 13);
            ghiChuLabel.TabIndex = 14;
            ghiChuLabel.Text = "Ghi Chu:";
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuKhacBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Location = new System.Drawing.Point(523, 82);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(200, 20);
            this.ghiChuTextBox.TabIndex = 15;
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Location = new System.Drawing.Point(383, 111);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new System.Drawing.Size(65, 13);
            thanhTienLabel.TabIndex = 16;
            thanhTienLabel.Text = "Thanh Tien:";
            // 
            // thanhTienTextBox
            // 
            this.thanhTienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuKhacBindingSource, "ThanhTien", true));
            this.thanhTienTextBox.Location = new System.Drawing.Point(523, 108);
            this.thanhTienTextBox.Name = "thanhTienTextBox";
            this.thanhTienTextBox.Size = new System.Drawing.Size(200, 20);
            this.thanhTienTextBox.TabIndex = 17;
            // 
            // FormCRUDHoaDonDichVuKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(idHoaDonDichVuKhacLabel);
            this.Controls.Add(this.idHoaDonDichVuKhacTextBox);
            this.Controls.Add(idHoaDonLabel);
            this.Controls.Add(this.idHoaDonTextBox);
            this.Controls.Add(idNhanVienLabel);
            this.Controls.Add(this.idNhanVienTextBox);
            this.Controls.Add(idKhachHangLabel);
            this.Controls.Add(this.idKhachHangTextBox);
            this.Controls.Add(tenDichVuKhacLabel);
            this.Controls.Add(this.tenDichVuKhacTextBox);
            this.Controls.Add(thoiGianLabel);
            this.Controls.Add(this.thoiGianDateTimePicker);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.ghiChuTextBox);
            this.Controls.Add(thanhTienLabel);
            this.Controls.Add(this.thanhTienTextBox);
            this.Controls.Add(this.hoaDonDichVuKhacDataGridView);
            this.Controls.Add(this.hoaDonDichVuKhacBindingNavigator);
            this.Name = "FormCRUDHoaDonDichVuKhac";
            this.Text = "FormCRUDHoaDonDichVuKhac";
            this.Load += new System.EventHandler(this.FormCRUDHoaDonDichVuKhac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuKhacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuKhacBindingNavigator)).EndInit();
            this.hoaDonDichVuKhacBindingNavigator.ResumeLayout(false);
            this.hoaDonDichVuKhacBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuKhacDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource hoaDonDichVuKhacBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.HoaDonDichVuKhacTableAdapter hoaDonDichVuKhacTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hoaDonDichVuKhacBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hoaDonDichVuKhacBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hoaDonDichVuKhacDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idHoaDonDichVuKhacTextBox;
        private System.Windows.Forms.TextBox idHoaDonTextBox;
        private System.Windows.Forms.TextBox idNhanVienTextBox;
        private System.Windows.Forms.TextBox idKhachHangTextBox;
        private System.Windows.Forms.TextBox tenDichVuKhacTextBox;
        private System.Windows.Forms.DateTimePicker thoiGianDateTimePicker;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private System.Windows.Forms.TextBox thanhTienTextBox;
    }
}