using System;
using System.Windows.Forms;

namespace TestGUI1.View
{
    public partial class FrmDangNhap : Form
    {
        private string MaNhanVien = "admin";
        private string MatKhau = "admin";
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private bool KiemTraDangNhap(string maNhanVien, string matKhau)
        {
            // Viết logic kiểm tra đăng nhập ở đây
            // Trả về true nếu đúng và false nếu sai
            // Ví dụ đơn giản: 
            return maNhanVien == MaNhanVien && matKhau == MatKhau;
        }

        private void BtnDangNhap_Click_1(object sender, EventArgs e)
        {
            string maNhanVien = TxtMaNhanVien.Text;
            string matKhau = TxtMatKhau.Text;

            // Kiểm tra xem liệu các TextBox có chứa dữ liệu hợp lệ hay không
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra điều kiện đăng nhập từ cơ sở dữ liệu
            if (!KiemTraDangNhap(maNhanVien, matKhau))
            {
                MessageBox.Show("Sai mã nhân viên hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Xoá thông tin mã nhân viên và mật khẩu trên TextBox hiện tại
                TxtMaNhanVien.Text = "";
                TxtMatKhau.Text = "";

                return;
            }

            // Mở form chính khi đăng nhập thành công
            FrmManHinhLamViec frmMain = new FrmManHinhLamViec();
            frmMain.Show();
            this.Hide(); // Ẩn form đăng nhập
        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
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
    }
}
