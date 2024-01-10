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
    public partial class FrmManHinhLamViec : Form
    {
        public FrmManHinhLamViec()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
                // Đóng form khi người dùng chọn "Yes"
                this.Close();
            }
            // Nếu người dùng chọn "No", không làm gì cả
        }

        private void FrmManHinhLamViec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.Phong);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DichVu);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.LoaiPhong' table. You can move, or remove it, as needed.
            this.loaiPhongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.LoaiPhong);

        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phoDgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton15_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDon frmChiTietHoaDon = new FrmChiTietHoaDon();
            frmChiTietHoaDon.ShowDialog();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDon frmChiTietHoaDon = new FrmChiTietHoaDon();
            frmChiTietHoaDon.Show();
        }

        private void rjButton13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình phát triển!");
        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình phát triển!");
        }
    }
}
