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
    public partial class FrmNhapThongTinKhachHang : Form
    {
        ModelQuanLy modelQuanLy = new ModelQuanLy();
        public FrmNhapThongTinKhachHang()
        {
            InitializeComponent();
        }
        public FrmNhapThongTinKhachHang(Phong phong, string idNhanVien)
        {
            InitializeComponent();
            string IdNhanhVien1 = idNhanVien;
            Phong Phong1 = phong;
        }

        private void TxtCCCD_TextChanged(object sender, EventArgs e)
        {
            // Khi nội dung của TextBox CCCD thay đổi, thực hiện tìm kiếm trong danh sách khách hàng
            string cccd = TxtCCCD.Text;

            // Gọi hàm tìm kiếm khách hàng theo CCCD
            KhachHang khachHang = TimKiemKhachHangTheoCCCD(cccd);

            // Nếu tìm thấy khách hàng, điền thông tin vào các TextBox khác
            if (khachHang != null)
            {
                TxtMaKhachHang.Text = khachHang.IdKhachHang;
                TxtTenKhachHang.Text = khachHang.TenKhachHang;
                DtpNgaySinh.Value = khachHang.NgaySinh;
                TxtDiaChi.Text = khachHang.DiaChi;
                TxtSoDienThoai.Text = khachHang.SoDienThoai;

                // Đặt ReadOnly cho các TextBox thông tin khách hàng nếu đã tìm thấy
                TxtMaKhachHang.ReadOnly = true;
                TxtTenKhachHang.ReadOnly = true;
                TxtDiaChi.ReadOnly = true;
                TxtSoDienThoai.ReadOnly = true;
            }
            else
            {
                // Nếu không tìm thấy, làm cho các TextBox có thể sửa đổi
                TxtMaKhachHang.ReadOnly = false;
                TxtTenKhachHang.ReadOnly = false;
                TxtDiaChi.ReadOnly = false;
                TxtSoDienThoai.ReadOnly = false;
            }
        }
        // Hàm tìm kiếm khách hàng theo CCCD
        private KhachHang TimKiemKhachHangTheoCCCD(string cccd)
        {
            // Gọi hàm lấy danh sách khách hàng (sử dụng modelQuanLy.GetKhachHang() hoặc hàm tương tự)
            List<KhachHang> danhSachKhachHang = modelQuanLy.GetKhachHangList();

            // Tìm kiếm trong danh sách khách hàng
            foreach (KhachHang khachHang in danhSachKhachHang)
            {
                if (khachHang.CCCD == cccd)
                {
                    return khachHang; // Trả về khách hàng nếu tìm thấy
                }
            }

            return null; // Trả về null nếu không tìm thấy
        }
        private bool KiemTraTonTaiKhachHang(string cccd)
        {
            // Gọi hàm lấy danh sách khách hàng (sử dụng modelQuanLy.GetKhachHang() hoặc hàm tương tự)
            List<KhachHang> danhSachKhachHang = modelQuanLy.GetKhachHangList();

            // Tìm kiếm trong danh sách khách hàng
            foreach (KhachHang khachHang in danhSachKhachHang)
            {
                if (khachHang.CCCD == cccd)
                {
                    return true; // Trả về khách hàng nếu tìm thấy
                }
            }

            return false; // Trả về null nếu không tìm thấy
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện xác nhận
        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các controls trên Form
                string idKhachHang = TxtMaKhachHang.Text;
                string tenKhachHang = TxtTenKhachHang.Text;
                DateTime ngaySinh = DtpNgaySinh.Value;
                string cccd = TxtCCCD.Text;
                string diaChi = TxtDiaChi.Text;
                string soDienThoai = TxtSoDienThoai.Text;
                // Kiểm tra nếu một trong các trường dữ liệu không được nhập
                if (string.IsNullOrEmpty(idKhachHang) || string.IsNullOrEmpty(tenKhachHang) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra khách hàng đã tồn tại hay chưa
                ModelQuanLy modelQuanLy = new ModelQuanLy();
                bool khachHangTonTai = KiemTraTonTaiKhachHang(cccd);

                if (khachHangTonTai)
                {
                    // Nếu khách hàng đã tồn tại, khởi tạo hoá đơn mới và lưu vào database
                    bool themHoaDonThanhCong = modelQuanLy.ThemHoaDon(idKhachHang, idNhanVien , idPhong, DateTime.Now);

                    if (themHoaDonThanhCong)
                    {
                        MessageBox.Show("Tạo hoá đơn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Tạo hoá đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Nếu khách hàng chưa tồn tại, lưu thông tin khách hàng vào database
                    bool themKhachHangThanhCong = modelQuanLy.ThemKhachHang(idKhachHang, tenKhachHang, ngaySinh, cccd, diaChi, soDienThoai);

                    if (themKhachHangThanhCong)
                    {
                        // Nếu lưu thông tin khách hàng thành công, khởi tạo hoá đơn mới và lưu vào database
                        // (Chưa implement mã mở form và truyền thông tin, bạn cần thay đổi phần này)
                        bool themHoaDonThanhCong = modelQuanLy.ThemHoaDon(idKhachHang,idNhanVien,idPhong,DateTime.Now);

                        if (themHoaDonThanhCong)
                        {
                            MessageBox.Show("Tạo hoá đơn thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Tạo hoá đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lưu thông tin khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
