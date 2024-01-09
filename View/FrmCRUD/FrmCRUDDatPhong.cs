using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI1.View.FrmCRUD
{
    public partial class FrmCRUDDatPhong : Form
    {
        public FrmCRUDDatPhong()
        {
            InitializeComponent();
        }

        private void datPhongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datPhongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmCRUDDatPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.DatPhong' table. You can move, or remove it, as needed.
            this.datPhongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DatPhong);

        }

        private void idPhongLabel_Click(object sender, EventArgs e)
        {

        }

        private void idPhongTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
