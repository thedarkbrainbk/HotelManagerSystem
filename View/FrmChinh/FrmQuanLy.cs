using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestGUI1.View.FrmCRUD2;

namespace TestGUI1.View
{
    public partial class FrmQuanLy : Form
    {
        ModelQuanLy modelQuanLy = new ModelQuanLy();
        public FrmQuanLy()
        {
            InitializeComponent();
        }
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            GetTableLoaiPhong();
            GetTableDichVu();
            GetTableNhanVien();
            GetTablePhong();
            GetTableKhachHang();
        }
        #region Tạo các bảng
        private void GetTableDichVu()
        {
            DgvDichVu.DataSource = modelQuanLy.GetDichVu();
            DgvDichVu.Columns["IdDichVu"].HeaderText = "Mã dịch vụ";
            DgvDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            DgvDichVu.Columns["LoaiDichVu"].HeaderText = "Loại dịch vụ";
            DgvDichVu.Columns["DonViTinh"].HeaderText = "Dơn vị tính";
            DgvDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
            TxtMaDichVu.Text = "";
            TxtTenDichVu.Text = "";
            TxtLoaiDichVu.Text = "";
            TxtDonViTinh.Text = "";
            TxtDonGia.Text = "";

        }
        private void GetTableLoaiPhong()
        {
            DgvLoaiPhong.DataSource = modelQuanLy.GetLoaiPhong();
            DgvLoaiPhong.Columns["IdLoaiPhong"].HeaderText = "Mã loại phòng";
            DgvLoaiPhong.Columns["TenLoaiPhong"].HeaderText = "Tên loại phòng";
            DgvLoaiPhong.Columns["SoNguoi"].HeaderText = "Số người";
            DgvLoaiPhong.Columns["GiaGioDau"].HeaderText = "Giá giờ đầu";
            DgvLoaiPhong.Columns["GiaGioTiepTheo"].HeaderText = "Giá giờ tiếp theo";
            DgvLoaiPhong.Columns["GiaQuaDem"].HeaderText = "Giá qua đêm";
            DgvLoaiPhong.Columns["GiaTheoNgay"].HeaderText = "Giá theo ngày";

            TxtMaLoaiPhong.Text = "";
            TxtTenLoaiPhong.Text = "";
            TxtSoNguoi.Text = "";
            TxtGiaGioDau.Text = "";
            TxtGiaGioTiepTheo.Text = "";
            TxtGiaQuaDem.Text = "";
            TxtGiaTheoNgay.Text = "";
        }
        private void GetTablePhong()
        {
            DgvPhong.DataSource = modelQuanLy.GetPhong();
            DgvPhong.Columns["IdPhong"].HeaderText = "Mã phòng";
            DgvPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
            DgvPhong.Columns["TenLoaiPhong"].HeaderText = "Loại phòng";
            DgvPhong.Columns["TinhTrangPhong"].HeaderText = "Tình trạng phòng";
            DgvPhong.Columns["IsVip"].HeaderText = "Phòng vip";
            TxtMaPhong.Text = "";
            TxtTenPhong.Text = "";
            CboLoaiPhong.Text = "";
            CboTinhTrangPhong.Text = "";
            CkbPhongVip.Checked = false;
        }
        private void GetTableKhachHang()
        {
            DgvKhachHang.DataSource = modelQuanLy.GetKhachHang();
            DgvKhachHang.Columns["IdKhachHang"].HeaderText = "Mã khách hàng";
            DgvKhachHang.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            DgvKhachHang.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            DgvKhachHang.Columns["CCCD"].HeaderText = "CCCD";
            DgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            DgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số điện thoại";

            TxtMaKhachHang.Text = "";
            TxtTenKhachHang.Text = "";
            DtpNgaySinhKH.Value = DateTime.Now;
            TxtCCCDKH.Text = "";
            TxtDiaChiKH.Text = "";
            TxtSoDienThoaiKH.Text = "";
        }

        private void GetTableNhanVien()
        {
            DgvNhanVien.DataSource = modelQuanLy.GetNhanVien();
            DgvNhanVien.Columns["IdNhanVien"].HeaderText = "Mã nhân viên";
            DgvNhanVien.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            DgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            DgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            DgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            DgvNhanVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            DgvNhanVien.Columns["CCCD"].HeaderText = "CCCD";
            DgvNhanVien.Columns["BoPhan"].HeaderText = "Bộ phận";

            TxtMaNhanVien.Text = "";
            TxtTenNhanVien.Text = "";
            DtpNgaySinh.Value = DateTime.Now; // Điều chỉnh theo tên thực tế của control DateTimePicker
            CboGioiTinh.SelectedIndex = -1; // Đặt lại index hoặc giá trị mặc định cho ComboBox
            TxtDiaChi.Text = "";
            TxtSoDienThoai.Text = "";
            TxtCCCD.Text = "";
            TxtBoPhan.Text = "";
        }

        #endregion



        private void rjButton38_Click(object sender, EventArgs e)
        {
            FrmManHinhLamViec frmManHinhLamViec = new FrmManHinhLamViec();
            frmManHinhLamViec.ShowDialog();
        }
        #region Thêm sửa xoá loại phòng
        private void BtnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            string idRanDom = SPClass.TaoId();
            FrmThemLoaiPhong frmThemLoaiPhong = new FrmThemLoaiPhong(idRanDom);
            frmThemLoaiPhong.ShowDialog();
            GetTableLoaiPhong();
        }

        private void BtnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn loại phòng trong bảng chưa
            if (TxtMaLoaiPhong.Text != "")
            {
                // Lấy dữ liệu từ các ô trong bảng
                string maLoaiPhong = DgvLoaiPhong.CurrentRow.Cells[0].Value.ToString();
                string tenLoaiPhong = DgvLoaiPhong.CurrentRow.Cells[1].Value.ToString();
                string soNguoi = DgvLoaiPhong.CurrentRow.Cells[2].Value.ToString();
                string giaGioDau = DgvLoaiPhong.CurrentRow.Cells[3].Value.ToString();
                string giaGioTiepTheo = DgvLoaiPhong.CurrentRow.Cells[4].Value.ToString();
                string giaQuaDem = DgvLoaiPhong.CurrentRow.Cells[5].Value.ToString();
                string giaTheoNgay = DgvLoaiPhong.CurrentRow.Cells[6].Value.ToString();

                // Tạo đối tượng FrmSuaLoaiPhong và truyền dữ liệu qua constructor
                FrmSuaLoaiPhong frmSuaLoaiPhong = new FrmSuaLoaiPhong(maLoaiPhong, tenLoaiPhong, soNguoi, giaGioDau, giaGioTiepTheo, giaQuaDem, giaTheoNgay);

                // Hiển thị form sửa loại phòng
                frmSuaLoaiPhong.ShowDialog();

                // Sau khi sửa xong, cập nhật lại bảng loại phòng
                GetTableLoaiPhong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn loại phòng trong bảng chưa
            if (TxtMaLoaiPhong.Text != "")
            {
                // Lấy ID của loại phòng cần xóa
                string idLoaiPhong = TxtMaLoaiPhong.Text;

                // Hiển thị hộp thoại xác nhận xoá
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá loại phòng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xoá loại phòng
                    bool XoaLoaiPhong = modelQuanLy.XoaLoaiPhong(idLoaiPhong);

                    if (XoaLoaiPhong)
                    {
                        MessageBox.Show("Xoá loại phòng thành công!");

                        // Sau khi xoá xong, cập nhật lại bảng loại phòng
                        GetTableLoaiPhong();
                    }
                    else
                    {
                        MessageBox.Show("Xoá loại phòng thất bại. Kiểm tra lại dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion


        #region Thêm sửa xoá phòng
        private void BtnThemPhong_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem đã thêm loại phòng chưa
            // Gọi hàm GetTenLoaiPhongList từ form của bạn và đặt kết quả vào ComboBox CboLoaiPhong
            List<LoaiPhong> lstLoaiPhong = modelQuanLy.GetLoaiPhongList();
            if (lstLoaiPhong.Count == 0)
            {
                    MessageBox.Show("Vui lòng thêm loại phòng trước khi thêm phòng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            else
            {
                FrmThemPhong frmThemPhong = new FrmThemPhong(lstLoaiPhong);
                frmThemPhong.ShowDialog();
                GetTablePhong();
            }
            
        }
        private void BtnSuaPhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn phòng trong bảng chưa
            if (TxtMaPhong.Text != "")
            {
                // Lấy dữ liệu từ các ô trong bảng
                string maPhong = DgvPhong.CurrentRow.Cells[0].Value.ToString();
                string tenPhong = DgvPhong.CurrentRow.Cells[1].Value.ToString();
                string idLoaiPhong = DgvPhong.CurrentRow.Cells[2].Value.ToString();
                string tinhTrangPhong = DgvPhong.CurrentRow.Cells[3].Value.ToString();
                bool isVip = Convert.ToBoolean(DgvPhong.CurrentRow.Cells[4].Value);
                List<LoaiPhong> lstLoaiPhong = modelQuanLy.GetLoaiPhongList();
                // Tạo đối tượng FrmSuaPhong và truyền dữ liệu qua constructor
                FrmSuaPhong frmSuaPhong = new FrmSuaPhong(maPhong, tenPhong, idLoaiPhong, tinhTrangPhong, isVip, lstLoaiPhong);

                // Hiển thị form sửa phòng
                frmSuaPhong.ShowDialog();

                // Sau khi sửa xong, cập nhật lại bảng phòng
                GetTablePhong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnXoaPhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn phòng trong bảng chưa
            if (TxtMaPhong.Text != "")
            {
                // Hiển thị hộp thoại xác nhận xoá
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá phòng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xác nhận từ người dùng
                if (result == DialogResult.Yes)
                {
                    // Lấy mã phòng cần xoá
                    string maPhong = DgvPhong.CurrentRow.Cells[0].Value.ToString();

                    // Gọi hàm xoá phòng từ lớp quản lý
                    bool xoaPhong = modelQuanLy.XoaPhong(maPhong);

                    // Kiểm tra kết quả xoá và cập nhật lại bảng phòng
                    if (xoaPhong)
                    {
                        MessageBox.Show("Xoá phòng thành công!");
                        GetTablePhong();
                    }
                    else
                    {
                        MessageBox.Show("Xoá phòng thất bại. Kiểm tra lại dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Thêm sửa xoá Dịch vụ
        private void BtnThemDichVu_Click(object sender, EventArgs e)
        {
            FrmThemDichVu frmThemDichVu = new FrmThemDichVu();
            frmThemDichVu.ShowDialog();
            GetTableDichVu();
        }
        private void BtnSuaDichVu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dịch vụ trong bảng chưa
            if (TxtMaDichVu.Text != "")
            {
                // Lấy dữ liệu từ các ô trong bảng
                string idDichVu = DgvDichVu.CurrentRow.Cells[0].Value.ToString();
                string tenDichVu = DgvDichVu.CurrentRow.Cells[1].Value.ToString();
                string loaiDichVu = DgvDichVu.CurrentRow.Cells[2].Value.ToString();
                string donViTinh = DgvDichVu.CurrentRow.Cells[3].Value.ToString();
                string donGia = DgvDichVu.CurrentRow.Cells[4].Value.ToString();

                // Tạo đối tượng FrmSuaDichVu và truyền dữ liệu qua constructor
                FrmSuaDichVu frmSuaDichVu = new FrmSuaDichVu(idDichVu, tenDichVu, loaiDichVu, donViTinh, donGia);

                // Hiển thị form sửa dịch vụ
                frmSuaDichVu.ShowDialog();

                // Sau khi sửa xong, cập nhật lại bảng dịch vụ
                GetTableDichVu();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnXoaDichVu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dịch vụ trong bảng chưa
            if (TxtMaDichVu.Text != "")
            {
                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn "Yes"
                if (result == DialogResult.Yes)
                {
                    // Lấy ID của dịch vụ cần xóa
                    string idDichVu = DgvDichVu.CurrentRow.Cells[0].Value.ToString();

                    // Thực hiện xóa dịch vụ
                    bool XoaDichVu = modelQuanLy.XoaDichVu(idDichVu);

                    // Kiểm tra kết quả xóa
                    if (XoaDichVu)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công!");
                        // Cập nhật lại bảng dịch vụ
                        GetTableDichVu();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Thêm xoá sửa nhân viên
        // Thêm nhân viên
        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien frmThemNhanVien = new FrmThemNhanVien();
            frmThemNhanVien.ShowDialog();
            GetTableNhanVien();
        }

        // Sửa nhân viên
        private void BtnSuaNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn nhân viên trong bảng chưa
            if (TxtMaNhanVien.Text != "")
            {
                // Lấy dữ liệu từ các ô trong bảng
                string idNhanVien = DgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                string tenNhanVien = DgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(DgvNhanVien.CurrentRow.Cells[2].Value);
                string gioiTinh = DgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                string diaChi = DgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                string soDienThoai = DgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                string cccd = DgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                string boPhan = DgvNhanVien.CurrentRow.Cells[7].Value.ToString();

                // Tạo đối tượng FrmSuaNhanVien và truyền dữ liệu qua constructor
                FrmSuaNhanVien frmSuaNhanVien = new FrmSuaNhanVien(idNhanVien, tenNhanVien, ngaySinh, gioiTinh, diaChi, soDienThoai, cccd, boPhan);

                // Hiển thị form sửa nhân viên
                frmSuaNhanVien.ShowDialog();

                // Sau khi sửa xong, cập nhật lại bảng nhân viên
                GetTableNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xoá nhân viên
        private void BtnXoaNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn nhân viên trong bảng chưa
            if (TxtMaNhanVien.Text != "")
            {
                // Lấy ID của nhân viên cần xóa
                string idNhanVien = TxtMaNhanVien.Text;

                // Hiển thị hộp thoại xác nhận xoá
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xoá nhân viên
                    bool XoaNhanVien = modelQuanLy.XoaNhanVien(idNhanVien);

                    if (XoaNhanVien)
                    {
                        MessageBox.Show("Xoá nhân viên thành công!");

                        // Sau khi xoá xong, cập nhật lại bảng nhân viên
                        GetTableNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xoá nhân viên thất bại. Kiểm tra lại dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Thêm xoá sửa xoá khách hàng
        private void BtnSuaKhachHang_Click(object sender, EventArgs e)
        {
            FrmSuaKhachHang frmSuaKhachHang = new FrmSuaKhachHang();
            frmSuaKhachHang.ShowDialog();
        }

        #endregion

        #region CellClick các bảng
        private void DgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Điền thông tin từ DataGridView vào các TextBox
            TxtMaDichVu.ReadOnly = true;
            TxtMaDichVu.Text = DgvDichVu.CurrentRow.Cells[0].Value.ToString();
            TxtTenDichVu.Text = DgvDichVu.CurrentRow.Cells[1].Value.ToString();
            TxtLoaiDichVu.Text = DgvDichVu.CurrentRow.Cells[2].Value.ToString();
            TxtDonViTinh.Text = DgvDichVu.CurrentRow.Cells[3].Value.ToString();
            TxtDonGia.Text = DgvDichVu.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnTimPhong_Click(object sender, EventArgs e)
        {

        }

        private void DgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Điền thông tin từ DataGridView vào các TextBox
            TxtMaLoaiPhong.ReadOnly = true;
            TxtMaLoaiPhong.Text = DgvLoaiPhong.CurrentRow.Cells[0].Value.ToString();
            TxtTenLoaiPhong.Text = DgvLoaiPhong.CurrentRow.Cells[1].Value.ToString();
            TxtSoNguoi.Text = DgvLoaiPhong.CurrentRow.Cells[2].Value.ToString();
            TxtGiaGioDau.Text = DgvLoaiPhong.CurrentRow.Cells[3].Value.ToString();
            TxtGiaGioTiepTheo.Text = DgvLoaiPhong.CurrentRow.Cells[4].Value.ToString();
            TxtGiaQuaDem.Text = DgvLoaiPhong.CurrentRow.Cells[5].Value.ToString();
            TxtGiaTheoNgay.Text = DgvLoaiPhong.CurrentRow.Cells[6].Value.ToString();
        }



        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Điền thông tin từ DataGridView vào các TextBox
                TxtMaPhong.ReadOnly = true;
                TxtMaPhong.Text = DgvPhong.CurrentRow.Cells[0].Value.ToString();
                TxtTenPhong.Text = DgvPhong.CurrentRow.Cells[1].Value.ToString();
                CboLoaiPhong.Text = DgvPhong.CurrentRow.Cells[2].Value.ToString();
                CboTinhTrangPhong.Text = DgvPhong.CurrentRow.Cells[3].Value.ToString();
                CkbPhongVip.Checked = Convert.ToBoolean(DgvPhong.CurrentRow.Cells[4].Value);
            }
            catch
            {

            }
           
        }
        #endregion
        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất và thoát chương trình?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả xác nhận
            if (result == DialogResult.Yes)
            {
                // Đóng ứng dụng
                Application.Exit();
            }
            // Nếu người dùng chọn "No", không làm gì cả
        }

        private void BtnTimNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void BtnTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan frmTaiKhoan = new FrmTaiKhoan();
            frmTaiKhoan.ShowDialog();
        }

        private void DgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.IdHoaDon = DgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            hoaDon.IdKhachHang = DgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            hoaDon.IdNhanVien = DgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            hoaDon.IdPhong = DgvHoaDon.CurrentRow.Cells[3].Value.ToString();
//
            hoaDon.LoaiNghi = DgvHoaDon.CurrentRow.Cells[7].Value.ToString();


        }
    }
}
