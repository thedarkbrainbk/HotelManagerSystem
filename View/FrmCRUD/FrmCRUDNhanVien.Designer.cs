namespace TestGUI1.View
{
    partial class FrmCRUDNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDNhanVien));
            System.Windows.Forms.Label idNhanVienLabel;
            System.Windows.Forms.Label tenNhanVienLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label soDienThoaiLabel;
            System.Windows.Forms.Label cCCDLabel;
            System.Windows.Forms.Label boPhanLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.nhanVienBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nhanVienBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nhanVienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.tenNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.soDienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.cCCDTextBox = new System.Windows.Forms.TextBox();
            this.boPhanTextBox = new System.Windows.Forms.TextBox();
            idNhanVienLabel = new System.Windows.Forms.Label();
            tenNhanVienLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            soDienThoaiLabel = new System.Windows.Forms.Label();
            cCCDLabel = new System.Windows.Forms.Label();
            boPhanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingNavigator)).BeginInit();
            this.nhanVienBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienBindingNavigator
            // 
            this.nhanVienBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nhanVienBindingNavigator.BindingSource = this.nhanVienBindingSource;
            this.nhanVienBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nhanVienBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nhanVienBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nhanVienBindingNavigatorSaveItem});
            this.nhanVienBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nhanVienBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nhanVienBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nhanVienBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nhanVienBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nhanVienBindingNavigator.Name = "nhanVienBindingNavigator";
            this.nhanVienBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nhanVienBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.nhanVienBindingNavigator.TabIndex = 0;
            this.nhanVienBindingNavigator.Text = "bindingNavigator1";
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
            // nhanVienBindingNavigatorSaveItem
            // 
            this.nhanVienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nhanVienBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nhanVienBindingNavigatorSaveItem.Image")));
            this.nhanVienBindingNavigatorSaveItem.Name = "nhanVienBindingNavigatorSaveItem";
            this.nhanVienBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.nhanVienBindingNavigatorSaveItem.Text = "Save Data";
            this.nhanVienBindingNavigatorSaveItem.Click += new System.EventHandler(this.nhanVienBindingNavigatorSaveItem_Click);
            // 
            // nhanVienDataGridView
            // 
            this.nhanVienDataGridView.AutoGenerateColumns = false;
            this.nhanVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.nhanVienDataGridView.DataSource = this.nhanVienBindingSource;
            this.nhanVienDataGridView.Location = new System.Drawing.Point(6, 174);
            this.nhanVienDataGridView.Name = "nhanVienDataGridView";
            this.nhanVienDataGridView.Size = new System.Drawing.Size(678, 227);
            this.nhanVienDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdNhanVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdNhanVien";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhanVien";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhanVien";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgaySinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "GioiTinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn5.HeaderText = "DiaChi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoDienThoai";
            this.dataGridViewTextBoxColumn6.HeaderText = "SoDienThoai";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CCCD";
            this.dataGridViewTextBoxColumn7.HeaderText = "CCCD";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BoPhan";
            this.dataGridViewTextBoxColumn8.HeaderText = "BoPhan";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idNhanVienLabel
            // 
            idNhanVienLabel.AutoSize = true;
            idNhanVienLabel.Location = new System.Drawing.Point(18, 51);
            idNhanVienLabel.Name = "idNhanVienLabel";
            idNhanVienLabel.Size = new System.Drawing.Size(72, 13);
            idNhanVienLabel.TabIndex = 2;
            idNhanVienLabel.Text = "Id Nhan Vien:";
            // 
            // idNhanVienTextBox
            // 
            this.idNhanVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "IdNhanVien", true));
            this.idNhanVienTextBox.Location = new System.Drawing.Point(106, 48);
            this.idNhanVienTextBox.Name = "idNhanVienTextBox";
            this.idNhanVienTextBox.Size = new System.Drawing.Size(200, 20);
            this.idNhanVienTextBox.TabIndex = 3;
            // 
            // tenNhanVienLabel
            // 
            tenNhanVienLabel.AutoSize = true;
            tenNhanVienLabel.Location = new System.Drawing.Point(18, 77);
            tenNhanVienLabel.Name = "tenNhanVienLabel";
            tenNhanVienLabel.Size = new System.Drawing.Size(82, 13);
            tenNhanVienLabel.TabIndex = 4;
            tenNhanVienLabel.Text = "Ten Nhan Vien:";
            // 
            // tenNhanVienTextBox
            // 
            this.tenNhanVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenNhanVien", true));
            this.tenNhanVienTextBox.Location = new System.Drawing.Point(106, 74);
            this.tenNhanVienTextBox.Name = "tenNhanVienTextBox";
            this.tenNhanVienTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenNhanVienTextBox.TabIndex = 5;
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(18, 104);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(59, 13);
            ngaySinhLabel.TabIndex = 6;
            ngaySinhLabel.Text = "Ngay Sinh:";
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(106, 100);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngaySinhDateTimePicker.TabIndex = 7;
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(18, 129);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(52, 13);
            gioiTinhLabel.TabIndex = 8;
            gioiTinhLabel.Text = "Gioi Tinh:";
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(106, 126);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(200, 20);
            this.gioiTinhTextBox.TabIndex = 9;
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(339, 54);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(44, 13);
            diaChiLabel.TabIndex = 10;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(427, 51);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(200, 20);
            this.diaChiTextBox.TabIndex = 11;
            // 
            // soDienThoaiLabel
            // 
            soDienThoaiLabel.AutoSize = true;
            soDienThoaiLabel.Location = new System.Drawing.Point(339, 80);
            soDienThoaiLabel.Name = "soDienThoaiLabel";
            soDienThoaiLabel.Size = new System.Drawing.Size(78, 13);
            soDienThoaiLabel.TabIndex = 12;
            soDienThoaiLabel.Text = "So Dien Thoai:";
            // 
            // soDienThoaiTextBox
            // 
            this.soDienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "SoDienThoai", true));
            this.soDienThoaiTextBox.Location = new System.Drawing.Point(427, 77);
            this.soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            this.soDienThoaiTextBox.Size = new System.Drawing.Size(200, 20);
            this.soDienThoaiTextBox.TabIndex = 13;
            // 
            // cCCDLabel
            // 
            cCCDLabel.AutoSize = true;
            cCCDLabel.Location = new System.Drawing.Point(339, 106);
            cCCDLabel.Name = "cCCDLabel";
            cCCDLabel.Size = new System.Drawing.Size(39, 13);
            cCCDLabel.TabIndex = 14;
            cCCDLabel.Text = "CCCD:";
            // 
            // cCCDTextBox
            // 
            this.cCCDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "CCCD", true));
            this.cCCDTextBox.Location = new System.Drawing.Point(427, 103);
            this.cCCDTextBox.Name = "cCCDTextBox";
            this.cCCDTextBox.Size = new System.Drawing.Size(200, 20);
            this.cCCDTextBox.TabIndex = 15;
            // 
            // boPhanLabel
            // 
            boPhanLabel.AutoSize = true;
            boPhanLabel.Location = new System.Drawing.Point(339, 132);
            boPhanLabel.Name = "boPhanLabel";
            boPhanLabel.Size = new System.Drawing.Size(51, 13);
            boPhanLabel.TabIndex = 16;
            boPhanLabel.Text = "Bo Phan:";
            // 
            // boPhanTextBox
            // 
            this.boPhanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "BoPhan", true));
            this.boPhanTextBox.Location = new System.Drawing.Point(427, 129);
            this.boPhanTextBox.Name = "boPhanTextBox";
            this.boPhanTextBox.Size = new System.Drawing.Size(200, 20);
            this.boPhanTextBox.TabIndex = 17;
            // 
            // FormCRUDNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idNhanVienLabel);
            this.Controls.Add(this.idNhanVienTextBox);
            this.Controls.Add(tenNhanVienLabel);
            this.Controls.Add(this.tenNhanVienTextBox);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(soDienThoaiLabel);
            this.Controls.Add(this.soDienThoaiTextBox);
            this.Controls.Add(cCCDLabel);
            this.Controls.Add(this.cCCDTextBox);
            this.Controls.Add(boPhanLabel);
            this.Controls.Add(this.boPhanTextBox);
            this.Controls.Add(this.nhanVienDataGridView);
            this.Controls.Add(this.nhanVienBindingNavigator);
            this.Name = "FormCRUDNhanVien";
            this.Text = "FormCRUDNhanVien";
            this.Load += new System.EventHandler(this.FormCRUDNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingNavigator)).EndInit();
            this.nhanVienBindingNavigator.ResumeLayout(false);
            this.nhanVienBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nhanVienBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nhanVienBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nhanVienDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idNhanVienTextBox;
        private System.Windows.Forms.TextBox tenNhanVienTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.TextBox gioiTinhTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox soDienThoaiTextBox;
        private System.Windows.Forms.TextBox cCCDTextBox;
        private System.Windows.Forms.TextBox boPhanTextBox;
    }
}