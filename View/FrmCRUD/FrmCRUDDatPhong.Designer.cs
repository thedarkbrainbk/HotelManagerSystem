namespace TestGUI1.View.FrmCRUD
{
    partial class FrmCRUDDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDDatPhong));
            System.Windows.Forms.Label idDatPhongLabel;
            System.Windows.Forms.Label idKhachHangLabel;
            System.Windows.Forms.Label thoiGianDenLabel;
            System.Windows.Forms.Label thoiGianDiLabel;
            System.Windows.Forms.Label idPhongLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.datPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datPhongTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.DatPhongTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.datPhongBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.datPhongBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.datPhongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDatPhongTextBox = new System.Windows.Forms.TextBox();
            this.idKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.thoiGianDenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.thoiGianDiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idPhongTextBox = new System.Windows.Forms.TextBox();
            idDatPhongLabel = new System.Windows.Forms.Label();
            idKhachHangLabel = new System.Windows.Forms.Label();
            thoiGianDenLabel = new System.Windows.Forms.Label();
            thoiGianDiLabel = new System.Windows.Forms.Label();
            idPhongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongBindingNavigator)).BeginInit();
            this.datPhongBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datPhongBindingSource
            // 
            this.datPhongBindingSource.DataMember = "DatPhong";
            this.datPhongBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // datPhongTableAdapter
            // 
            this.datPhongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = null;
            this.tableAdapterManager.DatPhongTableAdapter = this.datPhongTableAdapter;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datPhongBindingNavigator
            // 
            this.datPhongBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.datPhongBindingNavigator.BindingSource = this.datPhongBindingSource;
            this.datPhongBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.datPhongBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.datPhongBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.datPhongBindingNavigatorSaveItem});
            this.datPhongBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.datPhongBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.datPhongBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.datPhongBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.datPhongBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.datPhongBindingNavigator.Name = "datPhongBindingNavigator";
            this.datPhongBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.datPhongBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.datPhongBindingNavigator.TabIndex = 0;
            this.datPhongBindingNavigator.Text = "bindingNavigator1";
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
            // datPhongBindingNavigatorSaveItem
            // 
            this.datPhongBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.datPhongBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("datPhongBindingNavigatorSaveItem.Image")));
            this.datPhongBindingNavigatorSaveItem.Name = "datPhongBindingNavigatorSaveItem";
            this.datPhongBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.datPhongBindingNavigatorSaveItem.Text = "Save Data";
            this.datPhongBindingNavigatorSaveItem.Click += new System.EventHandler(this.datPhongBindingNavigatorSaveItem_Click);
            // 
            // datPhongDataGridView
            // 
            this.datPhongDataGridView.AutoGenerateColumns = false;
            this.datPhongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datPhongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.datPhongDataGridView.DataSource = this.datPhongBindingSource;
            this.datPhongDataGridView.Location = new System.Drawing.Point(12, 131);
            this.datPhongDataGridView.Name = "datPhongDataGridView";
            this.datPhongDataGridView.Size = new System.Drawing.Size(554, 220);
            this.datPhongDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDatPhong";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDatPhong";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdKhachHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdKhachHang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ThoiGianDen";
            this.dataGridViewTextBoxColumn3.HeaderText = "ThoiGianDen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ThoiGianDi";
            this.dataGridViewTextBoxColumn4.HeaderText = "ThoiGianDi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdPhong";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdPhong";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // idDatPhongLabel
            // 
            idDatPhongLabel.AutoSize = true;
            idDatPhongLabel.Location = new System.Drawing.Point(20, 41);
            idDatPhongLabel.Name = "idDatPhongLabel";
            idDatPhongLabel.Size = new System.Drawing.Size(73, 13);
            idDatPhongLabel.TabIndex = 2;
            idDatPhongLabel.Text = "Id Dat Phong:";
            // 
            // idDatPhongTextBox
            // 
            this.idDatPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datPhongBindingSource, "IdDatPhong", true));
            this.idDatPhongTextBox.Location = new System.Drawing.Point(108, 38);
            this.idDatPhongTextBox.Name = "idDatPhongTextBox";
            this.idDatPhongTextBox.Size = new System.Drawing.Size(200, 20);
            this.idDatPhongTextBox.TabIndex = 3;
            // 
            // idKhachHangLabel
            // 
            idKhachHangLabel.AutoSize = true;
            idKhachHangLabel.Location = new System.Drawing.Point(20, 67);
            idKhachHangLabel.Name = "idKhachHangLabel";
            idKhachHangLabel.Size = new System.Drawing.Size(82, 13);
            idKhachHangLabel.TabIndex = 4;
            idKhachHangLabel.Text = "Id Khach Hang:";
            // 
            // idKhachHangTextBox
            // 
            this.idKhachHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datPhongBindingSource, "IdKhachHang", true));
            this.idKhachHangTextBox.Location = new System.Drawing.Point(108, 64);
            this.idKhachHangTextBox.Name = "idKhachHangTextBox";
            this.idKhachHangTextBox.Size = new System.Drawing.Size(200, 20);
            this.idKhachHangTextBox.TabIndex = 5;
            // 
            // thoiGianDenLabel
            // 
            thoiGianDenLabel.AutoSize = true;
            thoiGianDenLabel.Location = new System.Drawing.Point(331, 42);
            thoiGianDenLabel.Name = "thoiGianDenLabel";
            thoiGianDenLabel.Size = new System.Drawing.Size(79, 13);
            thoiGianDenLabel.TabIndex = 6;
            thoiGianDenLabel.Text = "Thoi Gian Den:";
            // 
            // thoiGianDenDateTimePicker
            // 
            this.thoiGianDenDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datPhongBindingSource, "ThoiGianDen", true));
            this.thoiGianDenDateTimePicker.Location = new System.Drawing.Point(419, 38);
            this.thoiGianDenDateTimePicker.Name = "thoiGianDenDateTimePicker";
            this.thoiGianDenDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.thoiGianDenDateTimePicker.TabIndex = 7;
            // 
            // thoiGianDiLabel
            // 
            thoiGianDiLabel.AutoSize = true;
            thoiGianDiLabel.Location = new System.Drawing.Point(331, 68);
            thoiGianDiLabel.Name = "thoiGianDiLabel";
            thoiGianDiLabel.Size = new System.Drawing.Size(69, 13);
            thoiGianDiLabel.TabIndex = 8;
            thoiGianDiLabel.Text = "Thoi Gian Di:";
            // 
            // thoiGianDiDateTimePicker
            // 
            this.thoiGianDiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datPhongBindingSource, "ThoiGianDi", true));
            this.thoiGianDiDateTimePicker.Location = new System.Drawing.Point(419, 64);
            this.thoiGianDiDateTimePicker.Name = "thoiGianDiDateTimePicker";
            this.thoiGianDiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.thoiGianDiDateTimePicker.TabIndex = 9;
            // 
            // idPhongLabel
            // 
            idPhongLabel.AutoSize = true;
            idPhongLabel.Location = new System.Drawing.Point(20, 93);
            idPhongLabel.Name = "idPhongLabel";
            idPhongLabel.Size = new System.Drawing.Size(53, 13);
            idPhongLabel.TabIndex = 10;
            idPhongLabel.Text = "Id Phong:";
            idPhongLabel.Click += new System.EventHandler(this.idPhongLabel_Click);
            // 
            // idPhongTextBox
            // 
            this.idPhongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datPhongBindingSource, "IdPhong", true));
            this.idPhongTextBox.Location = new System.Drawing.Point(108, 90);
            this.idPhongTextBox.Name = "idPhongTextBox";
            this.idPhongTextBox.Size = new System.Drawing.Size(200, 20);
            this.idPhongTextBox.TabIndex = 11;
            this.idPhongTextBox.TextChanged += new System.EventHandler(this.idPhongTextBox_TextChanged);
            // 
            // FrmCRUDDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idDatPhongLabel);
            this.Controls.Add(this.idDatPhongTextBox);
            this.Controls.Add(idKhachHangLabel);
            this.Controls.Add(this.idKhachHangTextBox);
            this.Controls.Add(thoiGianDenLabel);
            this.Controls.Add(this.thoiGianDenDateTimePicker);
            this.Controls.Add(thoiGianDiLabel);
            this.Controls.Add(this.thoiGianDiDateTimePicker);
            this.Controls.Add(idPhongLabel);
            this.Controls.Add(this.idPhongTextBox);
            this.Controls.Add(this.datPhongDataGridView);
            this.Controls.Add(this.datPhongBindingNavigator);
            this.Name = "FrmCRUDDatPhong";
            this.Text = "FrmCRUDDatPhong";
            this.Load += new System.EventHandler(this.FrmCRUDDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongBindingNavigator)).EndInit();
            this.datPhongBindingNavigator.ResumeLayout(false);
            this.datPhongBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource datPhongBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.DatPhongTableAdapter datPhongTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator datPhongBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton datPhongBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView datPhongDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idDatPhongTextBox;
        private System.Windows.Forms.TextBox idKhachHangTextBox;
        private System.Windows.Forms.DateTimePicker thoiGianDenDateTimePicker;
        private System.Windows.Forms.DateTimePicker thoiGianDiDateTimePicker;
        private System.Windows.Forms.TextBox idPhongTextBox;
    }
}