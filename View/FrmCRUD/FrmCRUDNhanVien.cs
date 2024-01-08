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
    public partial class FrmCRUDNhanVien : Form
    {
        public FrmCRUDNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FormCRUDNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.NhanVien);

        }
    }
}
