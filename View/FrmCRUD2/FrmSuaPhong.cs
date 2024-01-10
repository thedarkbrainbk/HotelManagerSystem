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
    public partial class FrmSuaPhong : Form
    {
        ModelQuanLy modelQuanLy = new ModelQuanLy();
        public FrmSuaPhong()
        {
            InitializeComponent();
        }
        public FrmSuaPhong(string maPhong, string tenPhong, string ten, string tinhTrangPhong,bool isVip,List<LoaiPhong> lstLoaiPhong)
        {
            InitializeComponent();
            TxtMaPhong.Text = maPhong;
            TxtTenPhong.Text = tenPhong;
            CboLoaiPhong.DataSource = lstLoaiPhong;
            CboLoaiPhong.DisplayMember = "TenLoaiPhong";
            CboLoaiPhong.ValueMember = "IdLoaiPhong";
            CboLoaiPhong.Text = ten;
            CboTrangThaiPhong.SelectedItem = tinhTrangPhong;
            ChkPhongVip.Checked = isVip;

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
                string idPhong = TxtMaPhong.Text;
                string tenPhong = TxtTenPhong.Text;
                string tenLoaiPhong = CboLoaiPhong.Text;
                string tinhTrangPhong = CboTrangThaiPhong.Text;
                bool isVip = ChkPhongVip.Checked;

                // Kiểm tra nếu một trong các trường dữ liệu không được nhập
                if (string.IsNullOrEmpty(idPhong) || string.IsNullOrEmpty(tenPhong) || string.IsNullOrEmpty(tenLoaiPhong) || string.IsNullOrEmpty(tinhTrangPhong))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thực hiện sửa phòng
                bool SuaPhong = modelQuanLy.SuaPhong(idPhong, tenPhong, tenLoaiPhong, tinhTrangPhong, isVip);

                if (SuaPhong)
                {
                    MessageBox.Show("Sửa thông tin phòng thành công!");
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
