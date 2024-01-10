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
    public partial class FrmBaoCaoThongKeKhachHang : Form
    {
        public FrmBaoCaoThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmBaoCaoThongKeKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.KhachHang);

        }

       

        private void Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                khachHangBindingSource.EndEdit();
                khachHangTableAdapter.Update(dBQuanLyKhachSanDataSet.KhachHang);
                MessageBox.Show("Đã lưu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_Click_1(object sender, EventArgs e)
        {
            this.khachHangTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.KhachHang);
            chart1.Series["TenKhachHang"].XValueMember = "TenKhachHang";
            chart1.Series["TenKhachHang"].YValueMembers = "CCCD";
            chart1.DataSource = dBQuanLyKhachSanDataSet.KhachHang;
            chart1.DataBind();
        }
    }
}
