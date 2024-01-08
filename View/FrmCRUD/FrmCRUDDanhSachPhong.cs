using System;
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
    public partial class FrmCRUDDanhSachPhong : Form
    {
        public FrmCRUDDanhSachPhong()
        {
            InitializeComponent();
        }

        private void phongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FormCRUDDanhSachPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.LoaiPhong' table. You can move, or remove it, as needed.
            this.loaiPhongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.LoaiPhong);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.Phong);

        }
    }
}
