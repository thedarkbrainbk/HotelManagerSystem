namespace TestGUI1.View.FrmChinh
{
    partial class FormCRUDDichVuKhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUDDichVuKhac));
            System.Windows.Forms.Label tenDichVuLabel;
            System.Windows.Forms.Label moTaLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.Windows.Forms.Label nhaCungCapLabel;
            System.Windows.Forms.Label soDienThoaiLabel;
            this.dBQuanLyKhachSanDataSet = new TestGUI1.DBQuanLyKhachSanDataSet();
            this.dichVuKhacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dichVuKhacTableAdapter = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.DichVuKhacTableAdapter();
            this.tableAdapterManager = new TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager();
            this.dichVuKhacBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dichVuKhacBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dichVuKhacDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVuTextBox = new System.Windows.Forms.TextBox();
            this.moTaTextBox = new System.Windows.Forms.TextBox();
            this.donGiaTextBox = new System.Windows.Forms.TextBox();
            this.nhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.soDienThoaiTextBox = new System.Windows.Forms.TextBox();
            tenDichVuLabel = new System.Windows.Forms.Label();
            moTaLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            nhaCungCapLabel = new System.Windows.Forms.Label();
            soDienThoaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuKhacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuKhacBindingNavigator)).BeginInit();
            this.dichVuKhacBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuKhacDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBQuanLyKhachSanDataSet
            // 
            this.dBQuanLyKhachSanDataSet.DataSetName = "DBQuanLyKhachSanDataSet";
            this.dBQuanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dichVuKhacBindingSource
            // 
            this.dichVuKhacBindingSource.DataMember = "DichVuKhac";
            this.dichVuKhacBindingSource.DataSource = this.dBQuanLyKhachSanDataSet;
            // 
            // dichVuKhacTableAdapter
            // 
            this.dichVuKhacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChamCongTableAdapter = null;
            this.tableAdapterManager.DichVuKhacTableAdapter = this.dichVuKhacTableAdapter;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuKhacTableAdapter = null;
            this.tableAdapterManager.HoaDonDichVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LichDatPhongTableAdapter = null;
            this.tableAdapterManager.LoaiPhongTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestGUI1.DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dichVuKhacBindingNavigator
            // 
            this.dichVuKhacBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dichVuKhacBindingNavigator.BindingSource = this.dichVuKhacBindingSource;
            this.dichVuKhacBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dichVuKhacBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dichVuKhacBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dichVuKhacBindingNavigatorSaveItem});
            this.dichVuKhacBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dichVuKhacBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dichVuKhacBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dichVuKhacBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dichVuKhacBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dichVuKhacBindingNavigator.Name = "dichVuKhacBindingNavigator";
            this.dichVuKhacBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dichVuKhacBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.dichVuKhacBindingNavigator.TabIndex = 0;
            this.dichVuKhacBindingNavigator.Text = "bindingNavigator1";
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
            // dichVuKhacBindingNavigatorSaveItem
            // 
            this.dichVuKhacBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dichVuKhacBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dichVuKhacBindingNavigatorSaveItem.Image")));
            this.dichVuKhacBindingNavigatorSaveItem.Name = "dichVuKhacBindingNavigatorSaveItem";
            this.dichVuKhacBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dichVuKhacBindingNavigatorSaveItem.Text = "Save Data";
            this.dichVuKhacBindingNavigatorSaveItem.Click += new System.EventHandler(this.dichVuKhacBindingNavigatorSaveItem_Click);
            // 
            // dichVuKhacDataGridView
            // 
            this.dichVuKhacDataGridView.AutoGenerateColumns = false;
            this.dichVuKhacDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dichVuKhacDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dichVuKhacDataGridView.DataSource = this.dichVuKhacBindingSource;
            this.dichVuKhacDataGridView.Location = new System.Drawing.Point(12, 130);
            this.dichVuKhacDataGridView.Name = "dichVuKhacDataGridView";
            this.dichVuKhacDataGridView.Size = new System.Drawing.Size(551, 226);
            this.dichVuKhacDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDichVu";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenDichVu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MoTa";
            this.dataGridViewTextBoxColumn2.HeaderText = "MoTa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "DonGia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NhaCungCap";
            this.dataGridViewTextBoxColumn4.HeaderText = "NhaCungCap";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SoDienThoai";
            this.dataGridViewTextBoxColumn5.HeaderText = "SoDienThoai";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tenDichVuLabel
            // 
            tenDichVuLabel.AutoSize = true;
            tenDichVuLabel.Location = new System.Drawing.Point(23, 33);
            tenDichVuLabel.Name = "tenDichVuLabel";
            tenDichVuLabel.Size = new System.Drawing.Size(70, 13);
            tenDichVuLabel.TabIndex = 2;
            tenDichVuLabel.Text = "Ten Dich Vu:";
            // 
            // tenDichVuTextBox
            // 
            this.tenDichVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuKhacBindingSource, "TenDichVu", true));
            this.tenDichVuTextBox.Location = new System.Drawing.Point(109, 30);
            this.tenDichVuTextBox.Name = "tenDichVuTextBox";
            this.tenDichVuTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenDichVuTextBox.TabIndex = 3;
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Location = new System.Drawing.Point(23, 59);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(41, 13);
            moTaLabel.TabIndex = 4;
            moTaLabel.Text = "Mo Ta:";
            // 
            // moTaTextBox
            // 
            this.moTaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuKhacBindingSource, "MoTa", true));
            this.moTaTextBox.Location = new System.Drawing.Point(109, 56);
            this.moTaTextBox.Name = "moTaTextBox";
            this.moTaTextBox.Size = new System.Drawing.Size(100, 20);
            this.moTaTextBox.TabIndex = 5;
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Location = new System.Drawing.Point(23, 85);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(49, 13);
            donGiaLabel.TabIndex = 6;
            donGiaLabel.Text = "Don Gia:";
            // 
            // donGiaTextBox
            // 
            this.donGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuKhacBindingSource, "DonGia", true));
            this.donGiaTextBox.Location = new System.Drawing.Point(109, 82);
            this.donGiaTextBox.Name = "donGiaTextBox";
            this.donGiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.donGiaTextBox.TabIndex = 7;
            // 
            // nhaCungCapLabel
            // 
            nhaCungCapLabel.AutoSize = true;
            nhaCungCapLabel.Location = new System.Drawing.Point(233, 33);
            nhaCungCapLabel.Name = "nhaCungCapLabel";
            nhaCungCapLabel.Size = new System.Drawing.Size(80, 13);
            nhaCungCapLabel.TabIndex = 8;
            nhaCungCapLabel.Text = "Nha Cung Cap:";
            // 
            // nhaCungCapTextBox
            // 
            this.nhaCungCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuKhacBindingSource, "NhaCungCap", true));
            this.nhaCungCapTextBox.Location = new System.Drawing.Point(319, 30);
            this.nhaCungCapTextBox.Name = "nhaCungCapTextBox";
            this.nhaCungCapTextBox.Size = new System.Drawing.Size(100, 20);
            this.nhaCungCapTextBox.TabIndex = 9;
            // 
            // soDienThoaiLabel
            // 
            soDienThoaiLabel.AutoSize = true;
            soDienThoaiLabel.Location = new System.Drawing.Point(233, 59);
            soDienThoaiLabel.Name = "soDienThoaiLabel";
            soDienThoaiLabel.Size = new System.Drawing.Size(78, 13);
            soDienThoaiLabel.TabIndex = 10;
            soDienThoaiLabel.Text = "So Dien Thoai:";
            // 
            // soDienThoaiTextBox
            // 
            this.soDienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuKhacBindingSource, "SoDienThoai", true));
            this.soDienThoaiTextBox.Location = new System.Drawing.Point(319, 56);
            this.soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            this.soDienThoaiTextBox.Size = new System.Drawing.Size(100, 20);
            this.soDienThoaiTextBox.TabIndex = 11;
            // 
            // FormCRUDDichVuKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(tenDichVuLabel);
            this.Controls.Add(this.tenDichVuTextBox);
            this.Controls.Add(moTaLabel);
            this.Controls.Add(this.moTaTextBox);
            this.Controls.Add(donGiaLabel);
            this.Controls.Add(this.donGiaTextBox);
            this.Controls.Add(nhaCungCapLabel);
            this.Controls.Add(this.nhaCungCapTextBox);
            this.Controls.Add(soDienThoaiLabel);
            this.Controls.Add(this.soDienThoaiTextBox);
            this.Controls.Add(this.dichVuKhacDataGridView);
            this.Controls.Add(this.dichVuKhacBindingNavigator);
            this.Name = "FormCRUDDichVuKhac";
            this.Text = "FormCRUDDichVuKhac";
            this.Load += new System.EventHandler(this.FormCRUDDichVuKhac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBQuanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuKhacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuKhacBindingNavigator)).EndInit();
            this.dichVuKhacBindingNavigator.ResumeLayout(false);
            this.dichVuKhacBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuKhacDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBQuanLyKhachSanDataSet dBQuanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource dichVuKhacBindingSource;
        private DBQuanLyKhachSanDataSetTableAdapters.DichVuKhacTableAdapter dichVuKhacTableAdapter;
        private DBQuanLyKhachSanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dichVuKhacBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dichVuKhacBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dichVuKhacDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tenDichVuTextBox;
        private System.Windows.Forms.TextBox moTaTextBox;
        private System.Windows.Forms.TextBox donGiaTextBox;
        private System.Windows.Forms.TextBox nhaCungCapTextBox;
        private System.Windows.Forms.TextBox soDienThoaiTextBox;
    }
}