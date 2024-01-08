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
    public partial class FrmCRUDChamCong : Form
    {
        public FrmCRUDChamCong()
        {
            InitializeComponent();
        }

        private void chamCongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chamCongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmCRUDChamCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.ChamCong' table. You can move, or remove it, as needed.
            this.chamCongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.ChamCong);

        }
    }
}
