namespace TestGUI1.View
{
    partial class FrmCRUDLoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDLoaiPhong));
            System.Windows.Forms.Label idLoaiPhongLabel;
            System.Windows.Forms.Label tenLoaiPhongLabel;
            System.Windows.Forms.Label soNguoiLabel;
            System.Windows.Forms.Label giaGioDauLabel;
            System.Windows.Forms.Label giaGioTiepTheoLabel;
            System.Windows.Forms.Label giaQuaDemLabel;
            System.Windows.Forms.Label giaTheoNgayLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.loaiPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiPhongTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.LoaiPhongTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.loaiPhongBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.loaiPhongBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loaiPhongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLoaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.tenLoaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.soNguoiTextBox = new System.Windows.Forms.TextBox();
            this.giaGioDauTextBox = new System.Windows.Forms.TextBox();
            this.giaGioTiepTheoTextBox = new System.Windows.Forms.TextBox();
            this.giaQuaDemTextBox = new System.Windows.Forms.TextBox();
            this.giaTheoNgayTextBox = new System.Windows.Forms.TextBox();
            idLoaiPhongLabel = new System.Windows.Forms.Label();
            tenLoaiPhongLabel = new System.Windows.Forms.Label();
            soNguoiLabel = new System.Windows.Forms.Label();
            giaGioDauLabel = new System.Windows.Forms.Label();
            giaGioTiepTheoLabel = new System.Windows.Forms.Label();
            giaQuaDemLabel = new System.Windows.Forms.Label();
            giaTheoNgayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingNavigator)).BeginInit();
            this.loaiPhongBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = null;
            this.tableAdapterManager.DatPhongTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = this.loaiPhongTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loaiPhongBindingNavigator
            // 
            this.loaiPhongBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loaiPhongBindingNavigator.BindingSource = this.loaiPhongBindingSource;
            this.loaiPhongBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loaiPhongBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loaiPhongBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.loaiPhongBindingNavigatorSaveItem});
            this.loaiPhongBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loaiPhongBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loaiPhongBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loaiPhongBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loaiPhongBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loaiPhongBindingNavigator.Name = "loaiPhongBindingNavigator";
            this.loaiPhongBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loaiPhongBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.loaiPhongBindingNavigator.TabIndex = 0;
            this.loaiPhongBindingNavigator.Text = "bindingNavigator1";
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
            // loaiPhongBindingNavigatorSaveItem
            // 
            this.loaiPhongBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loaiPhongBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loaiPhongBindingNavigatorSaveItem.Image")));
            this.loaiPhongBindingNavigatorSaveItem.Name = "loaiPhongBindingNavigatorSaveItem";
            this.loaiPhongBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.loaiPhongBindingNavigatorSaveItem.Text = "Save Data";
            this.loaiPhongBindingNavigatorSaveItem.Click += new System.EventHandler(this.loaiPhongBindingNavigatorSaveItem_Click);
            // 
            // loaiPhongDataGridView
            // 
            this.loaiPhongDataGridView.AutoGenerateColumns = false;
            this.loaiPhongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaiPhongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.loaiPhongDataGridView.DataSource = this.loaiPhongBindingSource;
            this.loaiPhongDataGridView.Location = new System.Drawing.Point(265, 53);
            this.loaiPhongDataGridView.Name = "loaiPhongDataGridView";
            this.loaiPhongDataGridView.Size = new System.Drawing.Size(523, 220);
            this.loaiPhongDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdLoaiPhong";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdLoaiPhong";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLoaiPhong";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenLoaiPhong";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoNguoi";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoNguoi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiaGioDau";
            this.dataGridViewTextBoxColumn4.HeaderText = "GiaGioDau";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GiaGioTiepTheo";
            this.dataGridViewTextBoxColumn5.HeaderText = "GiaGioTiepTheo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GiaQuaDem";
            this.dataGridViewTextBoxColumn6.HeaderText = "GiaQuaDem";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GiaTheoNgay";
            this.dataGridViewTextBoxColumn7.HeaderText = "GiaTheoNgay";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // idLoaiPhongLabel
            // 
            idLoaiPhongLabel.AutoSize = true;
            idLoaiPhongLabel.Location = new System.Drawing.Point(21, 53);
            idLoaiPhongLabel.Name = "idLoaiPhongLabel";
            idLoaiPhongLabel.Size = new System.Drawing.Size(76, 13);
            idLoaiPhongLabel.TabIndex = 2;
            idLoaiPhongLabel.Text = "Id Loai Phong:";
            // 
            // idLoaiPhongTextBox
            // 
            this.idLoaiPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongBindingSource, "IdLoaiPhong", true));
            this.idLoaiPhongTextBox.Location = new System.Drawing.Point(124, 50);
            this.idLoaiPhongTextBox.Name = "idLoaiPhongTextBox";
            this.idLoaiPhongTextBox.Size = new System.Drawing.Size(100, 20);
            this.idLoaiPhongTextBox.TabIndex = 3;
            this.idLoaiPhongTextBox.TextChanged += new System.EventHandler(this.idLoaiPhongTextBox_TextChanged);
            // 
            // tenLoaiPhongLabel
            // 
            tenLoaiPhongLabel.AutoSize = true;
            tenLoaiPhongLabel.Location = new System.Drawing.Point(21, 79);
            tenLoaiPhongLabel.Name = "tenLoaiPhongLabel";
            tenLoaiPhongLabel.Size = new System.Drawing.Size(86, 13);
            tenLoaiPhongLabel.TabIndex = 4;
            tenLoaiPhongLabel.Text = "Ten Loai Phong:";
            // 
            // tenLoaiPhongTextBox
            // 
            this.tenLoaiPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongBindingSource, "TenLoaiPhong", true));
            this.tenLoaiPhongTextBox.Location = new System.Drawing.Point(124, 76);
            this.tenLoaiPhongTextBox.Name = "tenLoaiPhongTextBox";
            this.tenLoaiPhongTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenLoaiPhongTextBox.TabIndex = 5;
            // 
            // soNguoiLabel
            // 
            soNguoiLabel.AutoSize = true;
            soNguoiLabel.Location = new System.Drawing.Point(21, 105);
            soNguoiLabel.Name = "soNguoiLabel";
            soNguoiLabel.Size = new System.Drawing.Size(54, 13);
            soNguoiLabel.TabIndex = 6;
            soNguoiLabel.Text = "So Nguoi:";
            // 
            // soNguoiTextBox
            // 
            this.soNguoiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongBindingSource, "SoNguoi", true));
            this.soNguoiTextBox.Location = new System.Drawing.Point(124, 102);
            this.soNguoiTextBox.Name = "soNguoiTextBox";
            this.soNguoiTextBox.Size = new System.Drawing.Size(100, 20);
            this.soNguoiTextBox.TabIndex = 7;
            // 
            // giaGioDauLabel
            // 
            giaGioDauLabel.AutoSize = true;
            giaGioDauLabel.Location = new System.Drawing.Point(21, 131);
            giaGioDauLabel.Name = "giaGioDauLabel";
            giaGioDauLabel.Size = new System.Drawing.Size(68, 13);
            giaGioDauLabel.TabIndex = 8;
            giaGioDauLabel.Text = "Gia Gio Dau:";
            // 
            // giaGioDauTextBox
            // 
            this.giaGioDauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongBindingSource, "GiaGioDau", true));
            this.giaGioDauTextBox.Location = new System.Drawing.Point(124, 128);
            this.giaGioDauTextBox.Name = "giaGioDauTextBox";
            this.giaGioDauTextBox.Size = new System.Drawing.Size(100, 20);
            this.giaGioDauTextBox.TabIndex = 9;
            // 
            // giaGioTiepTheoLabel
            // 
            giaGioTiepTheoLabel.AutoSize = true;
            giaGioTiepTheoLabel.Location = new System.Drawing.Point(21, 157);
            giaGioTiepTheoLabel.Name = "giaGioTiepTheoLabel";
            giaGioTiepTheoLabel.Size = new System.Drawing.Size(97, 13);
            giaGioTiepTheoLabel.TabIndex = 10;
            giaGioTiepTheoLabel.Text = "Gia Gio Tiep Theo:";
            // 
            // giaGioTiepTheoTextBox
            // 
            this.giaGioTiepTheoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongBindingSource, "GiaGioTiepTheo", true));
            this.giaGioTiepTheoTextBox.Location = new System.Drawing.Point(124, 154);
            this.giaGioTiepTheoTextBox.Name = "giaGioTiepTheoTextBox";
            this.giaGioTiepTheoTextBox.Size = new System.Drawing.Size(100, 20);
            this.giaGioTiepTheoTextBox.TabIndex = 11;
            // 
            // giaQuaDemLabel
            // 
            giaQuaDemLabel.AutoSize = true;
            giaQuaDemLabel.Location = new System.Drawing.Point(21, 183);
            giaQuaDemLabel.Name = "giaQuaDemLabel";
            giaQuaDemLabel.Size = new System.Drawing.Size(74, 13);
            giaQuaDemLabel.TabIndex = 12;
            giaQuaDemLabel.Text = "Gia Qua Dem:";
            // 
            // giaQuaDemTextBox
            // 
            this.giaQuaDemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongBindingSource, "GiaQuaDem", true));
            this.giaQuaDemTextBox.Location = new System.Drawing.Point(124, 180);
            this.giaQuaDemTextBox.Name = "giaQuaDemTextBox";
            this.giaQuaDemTextBox.Size = new System.Drawing.Size(100, 20);
            this.giaQuaDemTextBox.TabIndex = 13;
            // 
            // giaTheoNgayLabel
            // 
            giaTheoNgayLabel.AutoSize = true;
            giaTheoNgayLabel.Location = new System.Drawing.Point(21, 209);
            giaTheoNgayLabel.Name = "giaTheoNgayLabel";
            giaTheoNgayLabel.Size = new System.Drawing.Size(82, 13);
            giaTheoNgayLabel.TabIndex = 14;
            giaTheoNgayLabel.Text = "Gia Theo Ngay:";
            // 
            // giaTheoNgayTextBox
            // 
            this.giaTheoNgayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongBindingSource, "GiaTheoNgay", true));
            this.giaTheoNgayTextBox.Location = new System.Drawing.Point(124, 206);
            this.giaTheoNgayTextBox.Name = "giaTheoNgayTextBox";
            this.giaTheoNgayTextBox.Size = new System.Drawing.Size(100, 20);
            this.giaTheoNgayTextBox.TabIndex = 15;
            // 
            // FrmCRUDLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idLoaiPhongLabel);
            this.Controls.Add(this.idLoaiPhongTextBox);
            this.Controls.Add(tenLoaiPhongLabel);
            this.Controls.Add(this.tenLoaiPhongTextBox);
            this.Controls.Add(soNguoiLabel);
            this.Controls.Add(this.soNguoiTextBox);
            this.Controls.Add(giaGioDauLabel);
            this.Controls.Add(this.giaGioDauTextBox);
            this.Controls.Add(giaGioTiepTheoLabel);
            this.Controls.Add(this.giaGioTiepTheoTextBox);
            this.Controls.Add(giaQuaDemLabel);
            this.Controls.Add(this.giaQuaDemTextBox);
            this.Controls.Add(giaTheoNgayLabel);
            this.Controls.Add(this.giaTheoNgayTextBox);
            this.Controls.Add(this.loaiPhongDataGridView);
            this.Controls.Add(this.loaiPhongBindingNavigator);
            this.Name = "FrmCRUDLoaiPhong";
            this.Text = "FrmCRUDLoaiPhong";
            this.Load += new System.EventHandler(this.FrmCRUDLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingNavigator)).EndInit();
            this.loaiPhongBindingNavigator.ResumeLayout(false);
            this.loaiPhongBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource loaiPhongBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.LoaiPhongTableAdapter loaiPhongTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loaiPhongBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton loaiPhongBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView loaiPhongDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idLoaiPhongTextBox;
        private System.Windows.Forms.TextBox tenLoaiPhongTextBox;
        private System.Windows.Forms.TextBox soNguoiTextBox;
        private System.Windows.Forms.TextBox giaGioDauTextBox;
        private System.Windows.Forms.TextBox giaGioTiepTheoTextBox;
        private System.Windows.Forms.TextBox giaQuaDemTextBox;
        private System.Windows.Forms.TextBox giaTheoNgayTextBox;
    }
}