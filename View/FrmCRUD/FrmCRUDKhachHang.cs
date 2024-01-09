﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI1.View
{
    public partial class FrmCRUDKhachHang : Form
    {
        public FrmCRUDKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FormCRUDKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.KhachHang);

        }
    }
}
