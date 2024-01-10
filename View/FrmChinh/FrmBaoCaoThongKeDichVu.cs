using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestGUI1.View.FrmChinh
{
    public partial class FrmBaoCaoThongKeDichVu : Form
    {
        public FrmBaoCaoThongKeDichVu()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoThongKeDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet1.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DichVu);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                dichVuBindingSource.EndEdit();
                dichVuTableAdapter.Update(dBQuanLyKhachSanDataSet.DichVu);
                MessageBox.Show("Đã lưu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            this.dichVuTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DichVu);
            chart1.Series["TenDichVu"].XValueMember = "TenDichVu";
            chart1.Series["TenDichVu"].YValueMembers = "DonGia";
            chart1.DataSource = dBQuanLyKhachSanDataSet.DichVu;
            chart1.DataBind();
        }

    }
}
