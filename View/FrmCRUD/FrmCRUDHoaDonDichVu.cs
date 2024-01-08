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
    public partial class FrmCRUDHoaDonDichVu : Form
    {
        public FrmCRUDHoaDonDichVu()
        {
            InitializeComponent();
        }

        private void hoaDonDichVuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoaDonDichVuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmCRUDHoaDonDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.HoaDonDichVu' table. You can move, or remove it, as needed.
            this.hoaDonDichVuTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.HoaDonDichVu);

        }
    }
}
