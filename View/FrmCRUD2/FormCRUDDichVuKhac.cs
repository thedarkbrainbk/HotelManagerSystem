using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI1.View.FrmChinh
{
    public partial class FormCRUDDichVuKhac : Form
    {
        public FormCRUDDichVuKhac()
        {
            InitializeComponent();
        }

        private void dichVuKhacBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dichVuKhacBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FormCRUDDichVuKhac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.DichVuKhac' table. You can move, or remove it, as needed.
            this.dichVuKhacTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DichVuKhac);

        }
    }
}
