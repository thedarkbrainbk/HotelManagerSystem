namespace TestGUI1.View.FrmCRUD
{
    partial class FrmCRUDHoaDonDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDHoaDonDichVu));
            System.Windows.Forms.Label idHoaDonLabel;
            System.Windows.Forms.Label idDichVuLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label thanhTienLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.hoaDonDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonDichVuTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.HoaDonDichVuTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.hoaDonDichVuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hoaDonDichVuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hoaDonDichVuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHoaDonTextBox = new System.Windows.Forms.TextBox();
            this.idDichVuTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTextBox = new System.Windows.Forms.TextBox();
            this.thanhTienTextBox = new System.Windows.Forms.TextBox();
            idHoaDonLabel = new System.Windows.Forms.Label();
            idDichVuLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            thanhTienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuBindingNavigator)).BeginInit();
            this.hoaDonDichVuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonDichVuBindingSource
            // 
            this.hoaDonDichVuBindingSource.DataMember = "HoaDonDichVu";
            this.hoaDonDichVuBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // hoaDonDichVuTableAdapter
            // 
            this.hoaDonDichVuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = null;
            this.tableAdapterManager.DatPhongTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = this.hoaDonDichVuTableAdapter;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoaDonDichVuBindingNavigator
            // 
            this.hoaDonDichVuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hoaDonDichVuBindingNavigator.BindingSource = this.hoaDonDichVuBindingSource;
            this.hoaDonDichVuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hoaDonDichVuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hoaDonDichVuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hoaDonDichVuBindingNavigatorSaveItem});
            this.hoaDonDichVuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hoaDonDichVuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hoaDonDichVuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hoaDonDichVuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hoaDonDichVuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hoaDonDichVuBindingNavigator.Name = "hoaDonDichVuBindingNavigator";
            this.hoaDonDichVuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hoaDonDichVuBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.hoaDonDichVuBindingNavigator.TabIndex = 0;
            this.hoaDonDichVuBindingNavigator.Text = "bindingNavigator1";
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
            // hoaDonDichVuBindingNavigatorSaveItem
            // 
            this.hoaDonDichVuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hoaDonDichVuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hoaDonDichVuBindingNavigatorSaveItem.Image")));
            this.hoaDonDichVuBindingNavigatorSaveItem.Name = "hoaDonDichVuBindingNavigatorSaveItem";
            this.hoaDonDichVuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hoaDonDichVuBindingNavigatorSaveItem.Text = "Save Data";
            this.hoaDonDichVuBindingNavigatorSaveItem.Click += new System.EventHandler(this.hoaDonDichVuBindingNavigatorSaveItem_Click);
            // 
            // hoaDonDichVuDataGridView
            // 
            this.hoaDonDichVuDataGridView.AutoGenerateColumns = false;
            this.hoaDonDichVuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonDichVuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hoaDonDichVuDataGridView.DataSource = this.hoaDonDichVuBindingSource;
            this.hoaDonDichVuDataGridView.Location = new System.Drawing.Point(0, 139);
            this.hoaDonDichVuDataGridView.Name = "hoaDonDichVuDataGridView";
            this.hoaDonDichVuDataGridView.Size = new System.Drawing.Size(450, 220);
            this.hoaDonDichVuDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdHoaDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdHoaDon";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idDichVu";
            this.dataGridViewTextBoxColumn2.HeaderText = "idDichVu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn4.HeaderText = "ThanhTien";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // idHoaDonLabel
            // 
            idHoaDonLabel.AutoSize = true;
            idHoaDonLabel.Location = new System.Drawing.Point(21, 57);
            idHoaDonLabel.Name = "idHoaDonLabel";
            idHoaDonLabel.Size = new System.Drawing.Size(65, 13);
            idHoaDonLabel.TabIndex = 2;
            idHoaDonLabel.Text = "Id Hoa Don:";
            // 
            // idHoaDonTextBox
            // 
            this.idHoaDonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuBindingSource, "IdHoaDon", true));
            this.idHoaDonTextBox.Location = new System.Drawing.Point(92, 54);
            this.idHoaDonTextBox.Name = "idHoaDonTextBox";
            this.idHoaDonTextBox.Size = new System.Drawing.Size(100, 20);
            this.idHoaDonTextBox.TabIndex = 3;
            // 
            // idDichVuLabel
            // 
            idDichVuLabel.AutoSize = true;
            idDichVuLabel.Location = new System.Drawing.Point(21, 83);
            idDichVuLabel.Name = "idDichVuLabel";
            idDichVuLabel.Size = new System.Drawing.Size(59, 13);
            idDichVuLabel.TabIndex = 4;
            idDichVuLabel.Text = "id Dich Vu:";
            // 
            // idDichVuTextBox
            // 
            this.idDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuBindingSource, "idDichVu", true));
            this.idDichVuTextBox.Location = new System.Drawing.Point(92, 80);
            this.idDichVuTextBox.Name = "idDichVuTextBox";
            this.idDichVuTextBox.Size = new System.Drawing.Size(100, 20);
            this.idDichVuTextBox.TabIndex = 5;
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(225, 57);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(56, 13);
            soLuongLabel.TabIndex = 6;
            soLuongLabel.Text = "So Luong:";
            // 
            // soLuongTextBox
            // 
            this.soLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuBindingSource, "SoLuong", true));
            this.soLuongTextBox.Location = new System.Drawing.Point(296, 54);
            this.soLuongTextBox.Name = "soLuongTextBox";
            this.soLuongTextBox.Size = new System.Drawing.Size(100, 20);
            this.soLuongTextBox.TabIndex = 7;
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Location = new System.Drawing.Point(225, 83);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new System.Drawing.Size(65, 13);
            thanhTienLabel.TabIndex = 8;
            thanhTienLabel.Text = "Thanh Tien:";
            // 
            // thanhTienTextBox
            // 
            this.thanhTienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonDichVuBindingSource, "ThanhTien", true));
            this.thanhTienTextBox.Location = new System.Drawing.Point(296, 80);
            this.thanhTienTextBox.Name = "thanhTienTextBox";
            this.thanhTienTextBox.Size = new System.Drawing.Size(100, 20);
            this.thanhTienTextBox.TabIndex = 9;
            // 
            // FrmCRUDHoaDonDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idHoaDonLabel);
            this.Controls.Add(this.idHoaDonTextBox);
            this.Controls.Add(idDichVuLabel);
            this.Controls.Add(this.idDichVuTextBox);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.soLuongTextBox);
            this.Controls.Add(thanhTienLabel);
            this.Controls.Add(this.thanhTienTextBox);
            this.Controls.Add(this.hoaDonDichVuDataGridView);
            this.Controls.Add(this.hoaDonDichVuBindingNavigator);
            this.Name = "FrmCRUDHoaDonDichVu";
            this.Text = "FormCRUDHoaDonDichVu";
            this.Load += new System.EventHandler(this.FrmCRUDHoaDonDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuBindingNavigator)).EndInit();
            this.hoaDonDichVuBindingNavigator.ResumeLayout(false);
            this.hoaDonDichVuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource hoaDonDichVuBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.HoaDonDichVuTableAdapter hoaDonDichVuTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hoaDonDichVuBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hoaDonDichVuBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hoaDonDichVuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idHoaDonTextBox;
        private System.Windows.Forms.TextBox idDichVuTextBox;
        private System.Windows.Forms.TextBox soLuongTextBox;
        private System.Windows.Forms.TextBox thanhTienTextBox;
    }
}