using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace TestGUI1.View.FrmCRUD2
{
    public partial class FrmThemPhong : Form
    {
        ModelQuanLy frmQuanLyClass = new ModelQuanLy();

        public FrmThemPhong()
        {
            InitializeComponent();
        }
        public FrmThemPhong(List<LoaiPhong> lstLoaiPhong)
        {
            InitializeComponent();

            CboLoaiPhong.DataSource = lstLoaiPhong;
            CboLoaiPhong.DisplayMember = "TenLoaiPhong"; 
            CboLoaiPhong.ValueMember = "IdLoaiPhong";     

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
                string maPhong = TxtMaPhong.Text;
                string tenPhong = TxtTenPhong.Text;
                string maLoaiPhong = CboLoaiPhong.SelectedValue.ToString(); // Sử dụng ?. để tránh lỗi null
                string trangThaiPhong = CboTrangThaiPhong.SelectedItem.ToString(); // Sử dụng ?. để tránh lỗi null
                bool isVip = ChkPhongVip.Checked;

                if (string.IsNullOrEmpty(maPhong) || string.IsNullOrEmpty(tenPhong) || string.IsNullOrEmpty(maLoaiPhong) || string.IsNullOrEmpty(trangThaiPhong))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool ThemPhong = frmQuanLyClass.ThemPhong(maPhong, tenPhong, maLoaiPhong, trangThaiPhong, isVip);

                if (ThemPhong)
                {
                    MessageBox.Show("Thêm phòng thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại. Kiểm tra lại dữ liệu nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmThemPhong_Load(object sender, EventArgs e)
        {
            string idRand = SPClass.TaoId();
            TxtMaPhong.Text = idRand;
        }
    }
}
