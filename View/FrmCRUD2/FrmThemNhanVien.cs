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
    public partial class FrmThemNhanVien : Form
    {
        ModelQuanLy modelQuanLy = new ModelQuanLy();
        public FrmThemNhanVien()
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
                // Get information from the form controls
                string idNhanVien = TxtMaNhanVien.Text;
                string tenNhanVien = TxtTenNhanVien.Text;
                DateTime ngaySinh = DtpNgaySinh.Value; // Adjust to your actual DateTimePicker control name
                string gioiTinh = CboGioiTinh.SelectedItem.ToString(); // Assuming CboGioiTinh is a ComboBox
                string diaChi = TxtDiaChi.Text;
                string soDienThoai = TxtSoDienThoai.Text;
                string cccd = TxtCCCD.Text;
                string boPhan = TxtBoPhan.Text;

                // Check if any required field is empty
                if (string.IsNullOrEmpty(idNhanVien) || string.IsNullOrEmpty(tenNhanVien) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(boPhan))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Perform adding new employee
                bool themNhanVien = modelQuanLy.ThemNhanVien(idNhanVien, tenNhanVien, ngaySinh, gioiTinh, diaChi, soDienThoai, cccd, boPhan);

                if (themNhanVien)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại. Kiểm tra lại dữ liệu nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmThemNhanVien_Load(object sender, EventArgs e)
        {
            string idRand = SPClass.TaoId();
            TxtMaNhanVien.Text = idRand;
        }
    }
}
