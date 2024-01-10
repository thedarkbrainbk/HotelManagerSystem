using System;
using System.Windows.Forms;

namespace TestGUI1.View.FrmCRUD2
{
    public partial class FrmSuaNhanVien : Form
    {
        ModelQuanLy frmQuanLyClass = new ModelQuanLy();

        public FrmSuaNhanVien()
        {
            InitializeComponent();
        }

        public FrmSuaNhanVien(string idNhanVien, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string cccd, string boPhan)
        {
            InitializeComponent();
            TxtMaNhanVien.Text = idNhanVien;
            TxtTenNhanVien.Text = tenNhanVien;
            DtpNgaySinh.Value = ngaySinh;
            CboGioiTinh.SelectedItem = gioiTinh;
            TxtDiaChi.Text = diaChi;
            TxtSoDienThoai.Text = soDienThoai;
            TxtCCCD.Text = cccd;
            TxtBoPhan.Text = boPhan;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string idNhanVien = TxtMaNhanVien.Text;
                string tenNhanVien = TxtTenNhanVien.Text;
                DateTime ngaySinh = DtpNgaySinh.Value;
                string gioiTinh = CboGioiTinh.SelectedItem.ToString();
                string diaChi = TxtDiaChi.Text;
                string soDienThoai = TxtSoDienThoai.Text;
                string cccd = TxtCCCD.Text;
                string boPhan = TxtBoPhan.Text;

                if (string.IsNullOrEmpty(idNhanVien) || string.IsNullOrEmpty(tenNhanVien) || string.IsNullOrEmpty(gioiTinh) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(boPhan))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool SuaNhanVien = frmQuanLyClass.SuaNhanVien(idNhanVien, tenNhanVien, ngaySinh, gioiTinh, diaChi, soDienThoai, cccd, boPhan);

                if (SuaNhanVien)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công!");
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
