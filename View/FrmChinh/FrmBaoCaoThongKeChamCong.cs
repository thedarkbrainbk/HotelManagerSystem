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
    public partial class FrmBaoCaoThongKeChamCong : Form
    {
        public FrmBaoCaoThongKeChamCong()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmBaoCaoThongKeNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.NhanVien);

        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                nhanVienBindingSource.EndEdit();
                nhanVienTableAdapter.Update(dBQuanLyKhachSanDataSet.NhanVien);
                MessageBox.Show("Đã lưu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.NhanVien);
            chart1.Series["TenNhanVien"].XValueMember = "TenNhanVien";
            chart1.Series["TenNhanVien"].YValueMembers = "GioiTinh";
            chart1.DataSource = dBQuanLyKhachSanDataSet.NhanVien;
            chart1.DataBind();
        }
        
    }
}
