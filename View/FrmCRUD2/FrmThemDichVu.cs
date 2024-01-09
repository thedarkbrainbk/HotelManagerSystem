using QuanLyKhachSan;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestGUI1.View.FrmCRUD2
{
    public partial class FrmThemDichVu : Form
    {
        ModelQuanLy frmQuanLyClass = new ModelQuanLy();
        public FrmThemDichVu()
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

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các controls trên Form
                string idDichVu = TxtMaDichVu.Text;
                string tenDichVu = TxtTenDichVu.Text;
                string loaiDichVu = TxtLoaiDichVu.Text;
                string donViTinh = TxtDonViTinh.Text;
                string donGia = TxtDonGia.Text;

                // Kiểm tra nếu một trong các trường dữ liệu không được nhập
                if (string.IsNullOrEmpty(idDichVu) || string.IsNullOrEmpty(tenDichVu) || string.IsNullOrEmpty(loaiDichVu) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(donGia))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thực hiện thêm dịch vụ
                Boolean ThemDichVu = frmQuanLyClass.ThemDichVu(idDichVu, tenDichVu, loaiDichVu, donViTinh, donGia);

                if (ThemDichVu)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Kiểm tra lại dữ liệu nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
