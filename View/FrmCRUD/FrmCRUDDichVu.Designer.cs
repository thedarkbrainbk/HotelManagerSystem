namespace TestGUI1.View.FrmCRUD
{
    partial class FrmCRUDDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUDDichVu));
            System.Windows.Forms.Label idDichVuLabel;
            System.Windows.Forms.Label tenDichVuLabel;
            System.Windows.Forms.Label loaiDichVuLabel;
            System.Windows.Forms.Label donViTinhLabel;
            System.Windows.Forms.Label donGiaLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dichVuTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.DichVuTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.dichVuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dichVuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dichVuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDichVuTextBox = new System.Windows.Forms.TextBox();
            this.tenDichVuTextBox = new System.Windows.Forms.TextBox();
            this.loaiDichVuTextBox = new System.Windows.Forms.TextBox();
            this.donViTinhTextBox = new System.Windows.Forms.TextBox();
            this.donGiaTextBox = new System.Windows.Forms.TextBox();
            idDichVuLabel = new System.Windows.Forms.Label();
            tenDichVuLabel = new System.Windows.Forms.Label();
            loaiDichVuLabel = new System.Windows.Forms.Label();
            donViTinhLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingNavigator)).BeginInit();
            this.dichVuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataMember = "DichVu";
            this.dichVuBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // dichVuTableAdapter
            // 
            this.dichVuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = null;
            this.tableAdapterManager.DatPhongTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = this.dichVuTableAdapter;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dichVuBindingNavigator
            // 
            this.dichVuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dichVuBindingNavigator.BindingSource = this.dichVuBindingSource;
            this.dichVuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dichVuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dichVuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dichVuBindingNavigatorSaveItem});
            this.dichVuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dichVuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dichVuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dichVuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dichVuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dichVuBindingNavigator.Name = "dichVuBindingNavigator";
            this.dichVuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dichVuBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.dichVuBindingNavigator.TabIndex = 0;
            this.dichVuBindingNavigator.Text = "bindingNavigator1";
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
            // dichVuBindingNavigatorSaveItem
            // 
            this.dichVuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dichVuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dichVuBindingNavigatorSaveItem.Image")));
            this.dichVuBindingNavigatorSaveItem.Name = "dichVuBindingNavigatorSaveItem";
            this.dichVuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dichVuBindingNavigatorSaveItem.Text = "Save Data";
            this.dichVuBindingNavigatorSaveItem.Click += new System.EventHandler(this.dichVuBindingNavigatorSaveItem_Click);
            // 
            // dichVuDataGridView
            // 
            this.dichVuDataGridView.AutoGenerateColumns = false;
            this.dichVuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dichVuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dichVuDataGridView.DataSource = this.dichVuBindingSource;
            this.dichVuDataGridView.Location = new System.Drawing.Point(0, 130);
            this.dichVuDataGridView.Name = "dichVuDataGridView";
            this.dichVuDataGridView.Size = new System.Drawing.Size(550, 220);
            this.dichVuDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDichVu";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDichVu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDichVu";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenDichVu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoaiDichVu";
            this.dataGridViewTextBoxColumn3.HeaderText = "LoaiDichVu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonViTinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "DonViTinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn5.HeaderText = "DonGia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // idDichVuLabel
            // 
            idDichVuLabel.AutoSize = true;
            idDichVuLabel.Location = new System.Drawing.Point(11, 43);
            idDichVuLabel.Name = "idDichVuLabel";
            idDichVuLabel.Size = new System.Drawing.Size(60, 13);
            idDichVuLabel.TabIndex = 2;
            idDichVuLabel.Text = "Id Dich Vu:";
            // 
            // idDichVuTextBox
            // 
            this.idDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuBindingSource, "IdDichVu", true));
            this.idDichVuTextBox.Location = new System.Drawing.Point(88, 40);
            this.idDichVuTextBox.Name = "idDichVuTextBox";
            this.idDichVuTextBox.Size = new System.Drawing.Size(100, 20);
            this.idDichVuTextBox.TabIndex = 3;
            // 
            // tenDichVuLabel
            // 
            tenDichVuLabel.AutoSize = true;
            tenDichVuLabel.Location = new System.Drawing.Point(11, 69);
            tenDichVuLabel.Name = "tenDichVuLabel";
            tenDichVuLabel.Size = new System.Drawing.Size(70, 13);
            tenDichVuLabel.TabIndex = 4;
            tenDichVuLabel.Text = "Ten Dich Vu:";
            // 
            // tenDichVuTextBox
            // 
            this.tenDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuBindingSource, "TenDichVu", true));
            this.tenDichVuTextBox.Location = new System.Drawing.Point(88, 66);
            this.tenDichVuTextBox.Name = "tenDichVuTextBox";
            this.tenDichVuTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenDichVuTextBox.TabIndex = 5;
            // 
            // loaiDichVuLabel
            // 
            loaiDichVuLabel.AutoSize = true;
            loaiDichVuLabel.Location = new System.Drawing.Point(11, 95);
            loaiDichVuLabel.Name = "loaiDichVuLabel";
            loaiDichVuLabel.Size = new System.Drawing.Size(71, 13);
            loaiDichVuLabel.TabIndex = 6;
            loaiDichVuLabel.Text = "Loai Dich Vu:";
            // 
            // loaiDichVuTextBox
            // 
            this.loaiDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuBindingSource, "LoaiDichVu", true));
            this.loaiDichVuTextBox.Location = new System.Drawing.Point(88, 92);
            this.loaiDichVuTextBox.Name = "loaiDichVuTextBox";
            this.loaiDichVuTextBox.Size = new System.Drawing.Size(100, 20);
            this.loaiDichVuTextBox.TabIndex = 7;
            // 
            // donViTinhLabel
            // 
            donViTinhLabel.AutoSize = true;
            donViTinhLabel.Location = new System.Drawing.Point(202, 43);
            donViTinhLabel.Name = "donViTinhLabel";
            donViTinhLabel.Size = new System.Drawing.Size(66, 13);
            donViTinhLabel.TabIndex = 8;
            donViTinhLabel.Text = "Don Vi Tinh:";
            // 
            // donViTinhTextBox
            // 
            this.donViTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuBindingSource, "DonViTinh", true));
            this.donViTinhTextBox.Location = new System.Drawing.Point(279, 40);
            this.donViTinhTextBox.Name = "donViTinhTextBox";
            this.donViTinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.donViTinhTextBox.TabIndex = 9;
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Location = new System.Drawing.Point(202, 69);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(49, 13);
            donGiaLabel.TabIndex = 10;
            donGiaLabel.Text = "Don Gia:";
            // 
            // donGiaTextBox
            // 
            this.donGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuBindingSource, "DonGia", true));
            this.donGiaTextBox.Location = new System.Drawing.Point(279, 66);
            this.donGiaTextBox.Name = "donGiaTextBox";
            this.donGiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.donGiaTextBox.TabIndex = 11;
            // 
            // FrmCRUDDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idDichVuLabel);
            this.Controls.Add(this.idDichVuTextBox);
            this.Controls.Add(tenDichVuLabel);
            this.Controls.Add(this.tenDichVuTextBox);
            this.Controls.Add(loaiDichVuLabel);
            this.Controls.Add(this.loaiDichVuTextBox);
            this.Controls.Add(donViTinhLabel);
            this.Controls.Add(this.donViTinhTextBox);
            this.Controls.Add(donGiaLabel);
            this.Controls.Add(this.donGiaTextBox);
            this.Controls.Add(this.dichVuDataGridView);
            this.Controls.Add(this.dichVuBindingNavigator);
            this.Name = "FrmCRUDDichVu";
            this.Text = "FrmCRUDDichVu";
            this.Load += new System.EventHandler(this.FrmCRUDDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingNavigator)).EndInit();
            this.dichVuBindingNavigator.ResumeLayout(false);
            this.dichVuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.DichVuTableAdapter dichVuTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dichVuBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dichVuBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dichVuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idDichVuTextBox;
        private System.Windows.Forms.TextBox tenDichVuTextBox;
        private System.Windows.Forms.TextBox loaiDichVuTextBox;
        private System.Windows.Forms.TextBox donViTinhTextBox;
        private System.Windows.Forms.TextBox donGiaTextBox;
    }
}