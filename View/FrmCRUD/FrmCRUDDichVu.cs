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
    public partial class FrmCRUDDichVu : Form
    {
        public FrmCRUDDichVu()
        {
            InitializeComponent();
        }

        private void dichVuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dichVuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmCRUDDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DichVu);

        }
    }
}
