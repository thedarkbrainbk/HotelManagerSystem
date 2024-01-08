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
    public partial class FrmCRUDLoaiPhong : Form
    {
        public FrmCRUDLoaiPhong()
        {
            InitializeComponent();
        }

        private void loaiPhongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loaiPhongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmCRUDLoaiPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.LoaiPhong' table. You can move, or remove it, as needed.
            this.loaiPhongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.LoaiPhong);

        }

        private void idLoaiPhongTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
