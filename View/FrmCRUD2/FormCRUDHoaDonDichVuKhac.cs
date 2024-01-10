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
    public partial class FormCRUDHoaDonDichVuKhac : Form
    {
        public FormCRUDHoaDonDichVuKhac()
        {
            InitializeComponent();
        }

        private void hoaDonDichVuKhacBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoaDonDichVuKhacBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FormCRUDHoaDonDichVuKhac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.HoaDonDichVuKhac' table. You can move, or remove it, as needed.
            this.hoaDonDichVuKhacTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.HoaDonDichVuKhac);

        }
    }
}
