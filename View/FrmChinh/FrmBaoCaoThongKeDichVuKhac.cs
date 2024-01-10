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
    public partial class FrmBaoCaoThongKeDichVuKhac : Form
    {
        public FrmBaoCaoThongKeDichVuKhac()
        {
            InitializeComponent();
        }

        private void dichVuKhacBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dichVuKhacBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmBaoCaoThongKeDichVuKhac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.DichVuKhac' table. You can move, or remove it, as needed.
            this.dichVuKhacTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DichVuKhac);

        }


        private void Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                dichVuKhacBindingSource.EndEdit();
                dichVuKhacTableAdapter.Update(dBQuanLyKhachSanDataSet.DichVuKhac);
                MessageBox.Show("Đã lưu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_Click_1(object sender, EventArgs e)
        {
            this.dichVuKhacTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DichVuKhac);
            chart1.Series["TenDichVu"].XValueMember = "TenDichVu";
            chart1.Series["TenDichVu"].YValueMembers = "DonGia";
            chart1.DataSource = dBQuanLyKhachSanDataSet.DichVu;
            chart1.DataBind();
        }
    }
}
