using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI1.View.FrmCRUD2
{
    public partial class FrmSuaLoaiPhong : Form
    {
        ModelQuanLy frmQuanLyClass = new ModelQuanLy();
        public FrmSuaLoaiPhong()
        {
            InitializeComponent();
        }
        public FrmSuaLoaiPhong(string idLoaiPhong, string tenLoaiPhong, string soNguoi, string giaGioDau, string giaGioTiepTheo, string giaQuaDem, string giaTheoNgay)
        {
            InitializeComponent();
            TxtMaLoaiPhong.Text = idLoaiPhong;
            TxtTenLoaiPhong.Text = tenLoaiPhong;
            TxtSoNguoi.Text = soNguoi;
            TxtGiaGioDau.Text = giaGioDau;
            TxtGiaGioTiepTheo.Text = giaGioTiepTheo;
            TxtGiaQuaDem.Text = giaQuaDem;
            TxtGiaTheoNgay.Text = giaTheoNgay;
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

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các controls trên Form
                string idLoaiPhong = TxtMaLoaiPhong.Text;
                string tenLoaiPhong = TxtTenLoaiPhong.Text;
                string soNguoi = TxtSoNguoi.Text;
                string giaGioDau = TxtGiaGioDau.Text;
                string giaGioTiepTheo = TxtGiaGioTiepTheo.Text;
                string giaQuaDem = TxtGiaQuaDem.Text;
                string giaTheoNgay = TxtGiaTheoNgay.Text;

                // Kiểm tra nếu một trong các trường dữ liệu không được nhập
                if (string.IsNullOrEmpty(idLoaiPhong) || string.IsNullOrEmpty(tenLoaiPhong) || string.IsNullOrEmpty(soNguoi) || string.IsNullOrEmpty(giaGioDau) || string.IsNullOrEmpty(giaGioTiepTheo) || string.IsNullOrEmpty(giaQuaDem) || string.IsNullOrEmpty(giaTheoNgay))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thực hiện sửa thông tin loại phòng
                bool SuaLoaiPhong = frmQuanLyClass.SuaLoaiPhong(idLoaiPhong, tenLoaiPhong, soNguoi, giaGioDau, giaGioTiepTheo, giaQuaDem, giaTheoNgay);

                if (SuaLoaiPhong)
                {
                    MessageBox.Show("Sửa thông tin loại phòng thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại. Kiểm tra lại dữ liệu nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
