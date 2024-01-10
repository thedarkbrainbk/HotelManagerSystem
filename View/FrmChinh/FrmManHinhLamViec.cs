using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TestGUI1.View.FrmCRUD2;

namespace TestGUI1.View
{
    public partial class FrmManHinhLamViec : Form
    {
        ModelLamViec modelLamViec = new ModelLamViec();
        public FrmManHinhLamViec()
        {
            InitializeComponent();
            //List <Phong> lstPhong = modelLamViec.LayDanhSachPhong();
            //string idNhanVien = "1753090124  ";
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

        private void FrmManHinhLamViec_Load(object sender, EventArgs e)
        {
            GetTableGiaPhong();
             
        }

        private void BtnTaoMoi_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong { 
            IdPhong = "062521100124",
            TenPhong = "A",
            IdLoaiPhong = "053355100124",
            TinhTrangPhong = "Khả dụng",
            IsVip = true
            };
            string idNhanVien = "1753090124  ";
            FrmNhapThongTinKhachHang frmNhapThongTinKhachHang = new FrmNhapThongTinKhachHang(phong, idNhanVien);
            frmNhapThongTinKhachHang.ShowDialog();
            
        }
        //Hàm load dữ liệu bảng giá phòng
        private void GetTableGiaPhong()
        {
            DgvGiaPhong.DataSource = modelLamViec.GetGiaPhong();
            DgvGiaPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
            DgvGiaPhong.Columns["TenLoaiPhong"].HeaderText = "Loại phòng";
            DgvGiaPhong.Columns["SoNguoi"].HeaderText = "Số người";
            DgvGiaPhong.Columns["GiaGioDau"].HeaderText = "Giá giờ đầu";
            DgvGiaPhong.Columns["GiaGioTiepTheo"].HeaderText = "Giá giờ tiếp theo";
            DgvGiaPhong.Columns["GiaQuaDem"].HeaderText = "Giá qua đêm";
            DgvGiaPhong.Columns["GiaTheoNgay"].HeaderText = "Giá theo ngày";
            DgvGiaPhong.Columns["TinhTrangPhong"].HeaderText = "Tình trạng phòng";
            DgvGiaPhong.Columns["IsVip"].HeaderText = "Phòng vip";

        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DgvThongTinPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
