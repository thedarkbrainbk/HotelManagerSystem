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
    public partial class FrmBaoCaoThongKeLoaiPhong : Form
    {
        public FrmBaoCaoThongKeLoaiPhong()
        {
            InitializeComponent();
        }

        private void loaiPhongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loaiPhongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBQuanLyKhachSanDataSet);

        }

        private void FrmBaoCaoThongKeLoaiPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.LoaiPhong' table. You can move, or remove it, as needed.
            this.loaiPhongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.LoaiPhong);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                loaiPhongBindingSource.EndEdit();
                loaiPhongTableAdapter.Update(dBQuanLyKhachSanDataSet.LoaiPhong);
                MessageBox.Show("Đã lưu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            this.loaiPhongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.LoaiPhong);
            chart1.Series["TenLoaiPhong"].XValueMember = "TenLoaiPhong";
            chart1.Series["TenLoaiPhong"].YValueMembers = "GiaGioDau";
            chart1.DataSource = dBQuanLyKhachSanDataSet.LoaiPhong;
            chart1.DataBind();
        }
    }
}
