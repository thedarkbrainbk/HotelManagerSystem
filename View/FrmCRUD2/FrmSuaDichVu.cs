using QuanLyKhachSan;
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
    public partial class FrmSuaDichVu : Form
    {
        ModelQuanLy frmQuanLyClass = new ModelQuanLy();
        public FrmSuaDichVu()
        {
            InitializeComponent();
        }
        public FrmSuaDichVu(string idDichVu, string tenDichVu,string loaiDichVu,string donViTinh,string donGia)
        {
            InitializeComponent();
            // Sử dụng thông tin nhận được để điền dữ liệu vào các TextBox trên form sửa
            TxtMaDichVu.Text = idDichVu;
            TxtTenDichVu.Text = tenDichVu;
            TxtLoaiDichVu.Text = loaiDichVu;
            TxtDonViTinh.Text = donViTinh;
            TxtDonGia.Text = donGia;

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

                // Thực hiện sửa dịch vụ
                Boolean SuaDichVu = frmQuanLyClass.SuaDichVu(idDichVu, tenDichVu, loaiDichVu, donViTinh, donGia);

                if (SuaDichVu)
                {
                    MessageBox.Show("Sửa thông tin dịch vụ thành công!");
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
