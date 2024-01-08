namespace TestGUI1.View.FrmCRUD
{
    partial class FrmCRUDChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDChamCong));
            System.Windows.Forms.Label idNhanVienLabel;
            System.Windows.Forms.Label ngayLabel;
            System.Windows.Forms.Label checkInLabel;
            System.Windows.Forms.Label checkOutLabel;
            System.Windows.Forms.Label soGioLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.chamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamCongTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.ChamCongTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.chamCongBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.chamCongBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.chamCongDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.ngayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkInTextBox = new System.Windows.Forms.TextBox();
            this.checkOutTextBox = new System.Windows.Forms.TextBox();
            this.soGioTextBox = new System.Windows.Forms.TextBox();
            idNhanVienLabel = new System.Windows.Forms.Label();
            ngayLabel = new System.Windows.Forms.Label();
            checkInLabel = new System.Windows.Forms.Label();
            checkOutLabel = new System.Windows.Forms.Label();
            soGioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingNavigator)).BeginInit();
            this.chamCongBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chamCongBindingSource
            // 
            this.chamCongBindingSource.DataMember = "ChamCong";
            this.chamCongBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // chamCongTableAdapter
            // 
            this.chamCongTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = this.chamCongTableAdapter;
            this.tableAdapterManager.DatPhongTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chamCongBindingNavigator
            // 
            this.chamCongBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.chamCongBindingNavigator.BindingSource = this.chamCongBindingSource;
            this.chamCongBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.chamCongBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.chamCongBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.chamCongBindingNavigatorSaveItem});
            this.chamCongBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.chamCongBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.chamCongBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.chamCongBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.chamCongBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.chamCongBindingNavigator.Name = "chamCongBindingNavigator";
            this.chamCongBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.chamCongBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.chamCongBindingNavigator.TabIndex = 0;
            this.chamCongBindingNavigator.Text = "bindingNavigator1";
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
            // chamCongBindingNavigatorSaveItem
            // 
            this.chamCongBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chamCongBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("chamCongBindingNavigatorSaveItem.Image")));
            this.chamCongBindingNavigatorSaveItem.Name = "chamCongBindingNavigatorSaveItem";
            this.chamCongBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.chamCongBindingNavigatorSaveItem.Text = "Save Data";
            this.chamCongBindingNavigatorSaveItem.Click += new System.EventHandler(this.chamCongBindingNavigatorSaveItem_Click);
            // 
            // chamCongDataGridView
            // 
            this.chamCongDataGridView.AutoGenerateColumns = false;
            this.chamCongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chamCongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.chamCongDataGridView.DataSource = this.chamCongBindingSource;
            this.chamCongDataGridView.Location = new System.Drawing.Point(0, 135);
            this.chamCongDataGridView.Name = "chamCongDataGridView";
            this.chamCongDataGridView.Size = new System.Drawing.Size(552, 220);
            this.chamCongDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdNhanVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdNhanVien";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ngay";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngay";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CheckIn";
            this.dataGridViewTextBoxColumn3.HeaderText = "CheckIn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CheckOut";
            this.dataGridViewTextBoxColumn4.HeaderText = "CheckOut";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SoGio";
            this.dataGridViewTextBoxColumn5.HeaderText = "SoGio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // idNhanVienLabel
            // 
            idNhanVienLabel.AutoSize = true;
            idNhanVienLabel.Location = new System.Drawing.Point(12, 36);
            idNhanVienLabel.Name = "idNhanVienLabel";
            idNhanVienLabel.Size = new System.Drawing.Size(72, 13);
            idNhanVienLabel.TabIndex = 2;
            idNhanVienLabel.Text = "Id Nhan Vien:";
            // 
            // idNhanVienTextBox
            // 
            this.idNhanVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chamCongBindingSource, "IdNhanVien", true));
            this.idNhanVienTextBox.Location = new System.Drawing.Point(90, 33);
            this.idNhanVienTextBox.Name = "idNhanVienTextBox";
            this.idNhanVienTextBox.Size = new System.Drawing.Size(200, 20);
            this.idNhanVienTextBox.TabIndex = 3;
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Location = new System.Drawing.Point(12, 63);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(35, 13);
            ngayLabel.TabIndex = 4;
            ngayLabel.Text = "Ngay:";
            // 
            // ngayDateTimePicker
            // 
            this.ngayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.chamCongBindingSource, "Ngay", true));
            this.ngayDateTimePicker.Location = new System.Drawing.Point(90, 59);
            this.ngayDateTimePicker.Name = "ngayDateTimePicker";
            this.ngayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngayDateTimePicker.TabIndex = 5;
            // 
            // checkInLabel
            // 
            checkInLabel.AutoSize = true;
            checkInLabel.Location = new System.Drawing.Point(311, 36);
            checkInLabel.Name = "checkInLabel";
            checkInLabel.Size = new System.Drawing.Size(53, 13);
            checkInLabel.TabIndex = 6;
            checkInLabel.Text = "Check In:";
            // 
            // checkInTextBox
            // 
            this.checkInTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chamCongBindingSource, "CheckIn", true));
            this.checkInTextBox.Location = new System.Drawing.Point(389, 33);
            this.checkInTextBox.Name = "checkInTextBox";
            this.checkInTextBox.Size = new System.Drawing.Size(200, 20);
            this.checkInTextBox.TabIndex = 7;
            // 
            // checkOutLabel
            // 
            checkOutLabel.AutoSize = true;
            checkOutLabel.Location = new System.Drawing.Point(311, 62);
            checkOutLabel.Name = "checkOutLabel";
            checkOutLabel.Size = new System.Drawing.Size(61, 13);
            checkOutLabel.TabIndex = 8;
            checkOutLabel.Text = "Check Out:";
            // 
            // checkOutTextBox
            // 
            this.checkOutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chamCongBindingSource, "CheckOut", true));
            this.checkOutTextBox.Location = new System.Drawing.Point(389, 59);
            this.checkOutTextBox.Name = "checkOutTextBox";
            this.checkOutTextBox.Size = new System.Drawing.Size(200, 20);
            this.checkOutTextBox.TabIndex = 9;
            // 
            // soGioLabel
            // 
            soGioLabel.AutoSize = true;
            soGioLabel.Location = new System.Drawing.Point(311, 88);
            soGioLabel.Name = "soGioLabel";
            soGioLabel.Size = new System.Drawing.Size(42, 13);
            soGioLabel.TabIndex = 10;
            soGioLabel.Text = "So Gio:";
            // 
            // soGioTextBox
            // 
            this.soGioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chamCongBindingSource, "SoGio", true));
            this.soGioTextBox.Location = new System.Drawing.Point(389, 85);
            this.soGioTextBox.Name = "soGioTextBox";
            this.soGioTextBox.Size = new System.Drawing.Size(200, 20);
            this.soGioTextBox.TabIndex = 11;
            // 
            // FrmCRUDChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idNhanVienLabel);
            this.Controls.Add(this.idNhanVienTextBox);
            this.Controls.Add(ngayLabel);
            this.Controls.Add(this.ngayDateTimePicker);
            this.Controls.Add(checkInLabel);
            this.Controls.Add(this.checkInTextBox);
            this.Controls.Add(checkOutLabel);
            this.Controls.Add(this.checkOutTextBox);
            this.Controls.Add(soGioLabel);
            this.Controls.Add(this.soGioTextBox);
            this.Controls.Add(this.chamCongDataGridView);
            this.Controls.Add(this.chamCongBindingNavigator);
            this.Name = "FrmCRUDChamCong";
            this.Text = "FrmCRUDChamCong";
            this.Load += new System.EventHandler(this.FrmCRUDChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingNavigator)).EndInit();
            this.chamCongBindingNavigator.ResumeLayout(false);
            this.chamCongBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource chamCongBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.ChamCongTableAdapter chamCongTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator chamCongBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton chamCongBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView chamCongDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idNhanVienTextBox;
        private System.Windows.Forms.DateTimePicker ngayDateTimePicker;
        private System.Windows.Forms.TextBox checkInTextBox;
        private System.Windows.Forms.TextBox checkOutTextBox;
        private System.Windows.Forms.TextBox soGioTextBox;
    }
}