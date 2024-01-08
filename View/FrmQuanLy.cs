using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestGUI1.View.FrmCRUD;

namespace TestGUI1.View
{
    public partial class FrmQuanLy : Form
    {

        public FrmQuanLy()
        {
            InitializeComponent();
        }
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.Phong);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.DatPhong' table. You can move, or remove it, as needed.
            this.datPhongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DatPhong);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.KhachHang);
        }

        private void BtnTab1ThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCRUDLoaiPhong frm = new FrmCRUDLoaiPhong();
                frm.Show();
                // Thực hiện thêm vào bảng LoaiPhong

                // Hiển thị thông báo và làm mới dữ liệu
                MessageBox.Show("Thêm loại phòng thành công!");
                ClearTextBoxes();
                RefreshData();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void ClearTextBoxes()
        {
            // Hàm xóa dữ liệu trong các textbox
            TxtTab1IdLoaiPhong.Text = string.Empty;
            TxtTab1TenLoaiPhong.Text = string.Empty;
            TxtTab1SoNguoi.Text = string.Empty;
            TxtTab1GiaGioDau.Text = string.Empty;
            TxtTab1GiaGioTiepTheo.Text = string.Empty;
            TxtTab1GiaQuaDem.Text = string.Empty;
            TxtTab1GiaTheoNgay.Text = string.Empty;
        }

        private void RefreshData()
        {
        }

        private void rjButton38_Click(object sender, EventArgs e)
        {
            FrmManHinhLamViec frmManHinhLamViec = new FrmManHinhLamViec();
            frmManHinhLamViec.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FrmCRUDDanhSachPhong frm = new FrmCRUDDanhSachPhong();
            frm.Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            FrmCRUDDichVu frm = new FrmCRUDDichVu();
            frm.Show();
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            FrmCRUDHoaDon frm = new FrmCRUDHoaDon();
            frm.Show();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            FrmCRUDNhanVien frm = new FrmCRUDNhanVien();
            frm.Show();
        }

        private void rjButton30_Click(object sender, EventArgs e)
        {
            FrmCRUDKhachHang frm = new FrmCRUDKhachHang();
            frm.Show();
        }

        private void rjButton20_Click(object sender, EventArgs e)
        {
            FrmCRUDChamCong frm = new FrmCRUDChamCong();
            frm.Show();
        }
    }
}
