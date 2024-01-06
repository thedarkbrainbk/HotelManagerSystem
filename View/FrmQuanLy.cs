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
    public partial class FrmQuanLy : Form
    {

        public FrmQuanLy()
        {
            InitializeComponent();
        }
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.HoaDon);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.NhanVien);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.DichVu);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dBQuanLyKhachSanDataSet.Phong);
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.LoaiPhong' table. You can move, or remove it, as needed.
            this.loaiPhongTableAdapter1.Fill(this.dBQuanLyKhachSanDataSet.LoaiPhong);
        }

        private void BtnTab1ThemMoi_Click(object sender, EventArgs e)
        {
            try
            { 
                // Thực hiện thêm vào bảng LoaiPhong
                this.loaiPhongTableAdapter1.Insert(
                    Convert.ToInt32(TxtTab1IdLoaiPhong.Text),
                    TxtTab1TenLoaiPhong.Text,
                    Convert.ToInt32(TxtTab1SoNguoi.Text),
                    decimal.Parse(TxtTab1GiaGioDau.Text),
                    decimal.Parse(TxtTab1GiaGioTiepTheo.Text),
                    decimal.Parse(TxtTab1GiaQuaDem.Text),
                    decimal.Parse(TxtTab1GiaTheoNgay.Text)
                );

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
            // Load lại dữ liệu từ cơ sở dữ liệu và hiển thị trong DataGridView
            this.loaiPhongTableAdapter1.Fill(this.dBQuanLyKhachSanDataSet.LoaiPhong);
        }

    }
}
