using QuanLyKhachSan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    internal class ModelQuanLy
    {
        DbConnect connect = new DbConnect();

        #region Quản lý dịch vụ
        //Hàm thêm dịch vụ
        public DataTable GetDichVu()
        {
            string selecQuerry = "Select * From DichVu";
            SqlCommand command = new SqlCommand(selecQuerry, connect.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool ThemDichVu(string idDichVu, string tenDichVu, string loaiDichVu, string donViTinh, string donGia)
        {
            string insertQuerry = "INSERT INTO DichVu (IdDichVu, TenDichVu, LoaiDichVu, DonViTinh, DonGia) VALUES (@IdDichVu, @TenDichVu, @LoaiDichVu, @DonViTinh, @DonGia)";
            SqlCommand command = new SqlCommand(insertQuerry, connect.GetConnection());
            command.Parameters.Add("@IdDichVu", SqlDbType.VarChar).Value = idDichVu;
            command.Parameters.Add("@TenDichVu", SqlDbType.NVarChar).Value = tenDichVu;
            command.Parameters.Add("@LoaiDichVu", SqlDbType.NVarChar).Value = loaiDichVu;
            command.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = donViTinh;

            // Chuyển đổi giá trị đơn giá sang kiểu INT
            if (int.TryParse(donGia, out int donGiaValue))
            {
                command.Parameters.Add("@DonGia", SqlDbType.Int).Value = donGiaValue;
            }
            else
            {
                return false;
            }
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Hàm sửa thông tin bảng dịch vụ
        public bool SuaDichVu(string idDichVu, string tenDichVu, string loaiDichVu, string donViTinh, string donGia)
        {
            string updateQuery = "UPDATE DichVu SET TenDichVu = @TenDichVu, LoaiDichVu = @LoaiDichVu, DonViTinh = @DonViTinh, DonGia = @DonGia WHERE IdDichVu = @IdDichVu";
            SqlCommand command = new SqlCommand(updateQuery, connect.GetConnection());
            command.Parameters.Add("@IdDichVu", SqlDbType.VarChar).Value = idDichVu;
            command.Parameters.Add("@TenDichVu", SqlDbType.NVarChar).Value = tenDichVu;
            command.Parameters.Add("@LoaiDichVu", SqlDbType.NVarChar).Value = loaiDichVu;
            command.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = donViTinh;

            // Chuyển đổi giá trị đơn giá sang kiểu INT
            if (int.TryParse(donGia, out int donGiaValue))
            {
                command.Parameters.Add("@DonGia", SqlDbType.Int).Value = donGiaValue;
            }
            else
            {
                return false;
            }

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Ham xoá dịch vụ
        public bool XoaDichVu(string idDichVu)
        {
            string deleteQuery = "DELETE FROM DichVu WHERE IdDichVu = @IdDichVu";
            SqlCommand command = new SqlCommand(deleteQuery, connect.GetConnection());
            // Thay thế tham số trong câu lệnh SQL với giá trị thực tế
            command.Parameters.Add("@IdDichVu", SqlDbType.NVarChar).Value = idDichVu;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Quản lý loại phòng
        //Lấy dữ liệu bảng LoaiPhong
        // Hàm lấy thông tin bảng LoaiPhong
        public DataTable GetLoaiPhong()
        {
            try
            {
                // Chuỗi truy vấn SQL để lấy toàn bộ thông tin từ bảng LoaiPhong
                string selectQuery = "SELECT * FROM LoaiPhong";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());

                // Tạo đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter();

                // Tạo đối tượng DataTable để lưu trữ dữ liệu
                DataTable table = new DataTable();

                // Thiết lập đối tượng SqlCommand cho đối tượng SqlDataAdapter
                adapter.SelectCommand = command;

                // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                adapter.Fill(table);

                // Trả về DataTable chứa thông tin từ bảng LoaiPhong
                return table;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về null
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;
            }
        }
        //Hàm thêm loại phòng
        public bool ThemLoaiPhong(string idLoaiPhong, string tenLoaiPhong, string soNguoi, string giaGioDau, string giaGioTiepTheo, string giaQuaDem, string giaTheoNgay)
        {
            try
            {
                // Chuỗi truy vấn SQL để thêm loại phòng vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO LoaiPhong (IdLoaiPhong, TenLoaiPhong, SoNguoi, GiaGioDau, GiaGioTiepTheo, GiaQuaDem, GiaTheoNgay) VALUES (@IdLoaiPhong, @TenLoaiPhong, @SoNguoi, @GiaGioDau, @GiaGioTiepTheo, @GiaQuaDem, @GiaTheoNgay)";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(insertQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdLoaiPhong", SqlDbType.NVarChar).Value = idLoaiPhong;
                command.Parameters.Add("@TenLoaiPhong", SqlDbType.NVarChar).Value = tenLoaiPhong;
                command.Parameters.Add("@SoNguoi", SqlDbType.Int).Value = soNguoi;
                command.Parameters.Add("@GiaGioDau", SqlDbType.Int).Value = giaGioDau;
                command.Parameters.Add("@GiaGioTiepTheo", SqlDbType.Int).Value = giaGioTiepTheo;
                command.Parameters.Add("@GiaQuaDem", SqlDbType.Int).Value = giaQuaDem;
                command.Parameters.Add("@GiaTheoNgay", SqlDbType.Int).Value = giaTheoNgay;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }

        //Hàm sửa loại phòng
        public bool SuaLoaiPhong(string idLoaiPhong, string tenLoaiPhong, string soNguoi, string giaGioDau, string giaGioTiepTheo, string giaQuaDem, string giaTheoNgay)
        {
            try
            {
                // Chuỗi truy vấn SQL để sửa thông tin loại phòng trong cơ sở dữ liệu
                string updateQuery = "UPDATE LoaiPhong SET TenLoaiPhong = @TenLoaiPhong, SoNguoi = @SoNguoi, GiaGioDau = @GiaGioDau, GiaGioTiepTheo = @GiaGioTiepTheo, GiaQuaDem = @GiaQuaDem, GiaTheoNgay = @GiaTheoNgay WHERE IdLoaiPhong = @IdLoaiPhong";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(updateQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdLoaiPhong", SqlDbType.NVarChar).Value = idLoaiPhong;
                command.Parameters.Add("@TenLoaiPhong", SqlDbType.NVarChar).Value = tenLoaiPhong;
                command.Parameters.Add("@SoNguoi", SqlDbType.Int).Value = soNguoi;
                command.Parameters.Add("@GiaGioDau", SqlDbType.Int).Value = giaGioDau;
                command.Parameters.Add("@GiaGioTiepTheo", SqlDbType.Int).Value = giaGioTiepTheo;
                command.Parameters.Add("@GiaQuaDem", SqlDbType.Int).Value = giaQuaDem;
                command.Parameters.Add("@GiaTheoNgay", SqlDbType.Int).Value = giaTheoNgay;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }
        //Hàm xoá loại phòng
        public bool XoaLoaiPhong(string idLoaiPhong)
        {
            string deleteQuery = "DELETE FROM LoaiPhong WHERE IdLoaiPhong = @IdLoaiPhong";
            SqlCommand command = new SqlCommand(deleteQuery, connect.GetConnection());
            // Thay thế tham số trong câu lệnh SQL với giá trị thực tế
            command.Parameters.Add("@IdLoaiPhong", SqlDbType.NVarChar).Value = idLoaiPhong;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Quản lý phòng
        // Hàm lấy thông tin bảng Phong và LoaiPhong
        public DataTable GetPhong()
        {
            try
            {
                // Chuỗi truy vấn SQL để lấy thông tin từ bảng Phong và LoaiPhong
                string selectQuery = @"
            SELECT P.IdPhong, P.TenPhong, LP.TenLoaiPhong, P.TinhTrangPhong, P.IsVip
            FROM Phong P
            JOIN LoaiPhong LP ON P.IdLoaiPhong = LP.IdLoaiPhong";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());

                // Tạo đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter();

                // Tạo đối tượng DataTable để lưu trữ dữ liệu
                DataTable table = new DataTable();

                // Thiết lập đối tượng SqlCommand cho đối tượng SqlDataAdapter
                adapter.SelectCommand = command;

                // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                adapter.Fill(table);

                // Trả về DataTable chứa thông tin từ bảng Phong và LoaiPhong
                return table;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về null
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;
            }
        }

        // Hàm thêm phòng
        public bool ThemPhong(string idPhong, string tenPhong, string idLoaiPhong, string tinhTrangPhong, bool isVip)
        {
            if (string.IsNullOrEmpty(idPhong) || string.IsNullOrEmpty(tenPhong) || string.IsNullOrEmpty(idLoaiPhong))
            {
                Console.WriteLine("Có giá trị null");
                return false;
            }
            else
            {
                try
                {
                    Console.WriteLine(idPhong);
                    Console.WriteLine(tenPhong);
                    Console.WriteLine(idPhong);
                    Console.WriteLine(tinhTrangPhong);
                    Console.WriteLine(isVip);
                    // Chuỗi truy vấn SQL để thêm phòng vào cơ sở dữ liệu
                    string insertQuery = "INSERT INTO Phong (IdPhong, TenPhong, idLoaiPhong, TinhTrangPhong, IsVip) VALUES (@IdPhong, @TenPhong, @IdLoaiPhong, @TinhTrangPhong, @IsVip)";

                    // Tạo đối tượng SqlCommand
                    SqlCommand command = new SqlCommand(insertQuery, connect.GetConnection());

                    // Thêm các tham số vào câu lệnh SQL
                    command.Parameters.Add("@IdPhong", SqlDbType.NChar).Value = idPhong;
                    command.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = tenPhong;
                    command.Parameters.Add("@IdLoaiPhong", SqlDbType.NChar).Value = idLoaiPhong;
                    command.Parameters.Add("@TinhTrangPhong", SqlDbType.NVarChar).Value = tinhTrangPhong;
                    command.Parameters.Add("@IsVip", SqlDbType.Bit).Value = isVip;

                    // Mở kết nối
                    connect.OpenCon();

                    // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                    if (command.ExecuteNonQuery() == 1)
                    {
                        // Đóng kết nối và trả về true nếu thành công
                        connect.CloseCon();
                        return true;
                    }
                    else
                    {
                        // Đóng kết nối và trả về false nếu thất bại
                        connect.CloseCon();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi và trả về false
                    Console.WriteLine($"Lỗi: {ex.Message}");
                    connect.CloseCon();
                    return false;
                }
            }
        }

        public bool SuaPhong(string idPhong, string tenPhong, string tenLoaiPhong, string tinhTrangPhong, bool isVip)
        {
            try
            {
                // Trước hết, lấy idLoaiPhong từ tenLoaiPhong
                string idLoaiPhong = GetIdLoaiPhongByTenLoaiPhong(tenLoaiPhong);

                // Kiểm tra xem idLoaiPhong có giá trị không
                if (string.IsNullOrEmpty(idLoaiPhong))
                {
                    Console.WriteLine("Không tìm thấy idLoaiPhong cho tenLoaiPhong đã cho.");
                    return false;
                }

                // Chuỗi truy vấn SQL để sửa thông tin phòng trong cơ sở dữ liệu
                string updateQuery = "UPDATE Phong SET TenPhong = @TenPhong, idLoaiPhong = @IdLoaiPhong, TinhTrangPhong = @TinhTrangPhong, IsVip = @IsVip WHERE IdPhong = @IdPhong";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(updateQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdPhong", SqlDbType.NChar).Value = idPhong;
                command.Parameters.Add("@TenPhong", SqlDbType.NVarChar).Value = tenPhong;
                command.Parameters.Add("@IdLoaiPhong", SqlDbType.NChar).Value = idLoaiPhong;
                command.Parameters.Add("@TinhTrangPhong", SqlDbType.NVarChar).Value = tinhTrangPhong;
                command.Parameters.Add("@IsVip", SqlDbType.Bit).Value = isVip;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }

        // Hàm lấy idLoaiPhong từ tenLoaiPhong
        private string GetIdLoaiPhongByTenLoaiPhong(string tenLoaiPhong)
        {
            try
            {
                string selectQuery = "SELECT IdLoaiPhong FROM LoaiPhong WHERE TenLoaiPhong = @TenLoaiPhong";

                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());
                command.Parameters.Add("@TenLoaiPhong", SqlDbType.NVarChar).Value = tenLoaiPhong;

                connect.OpenCon();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;
            }
            finally
            {
                connect.CloseCon();
            }
        }


        // Hàm xoá phòng
        public bool XoaPhong(string idPhong)
        {
            try
            {
                // Chuỗi truy vấn SQL để xoá phòng từ cơ sở dữ liệu
                string deleteQuery = "DELETE FROM Phong WHERE IdPhong = @IdPhong";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(deleteQuery, connect.GetConnection());

                // Thêm tham số vào câu lệnh SQL
                command.Parameters.Add("@IdPhong", SqlDbType.NVarChar).Value = idPhong;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }
        #endregion

        #region Quản lý nhân viên
        //Hàm lấy dữ liệu nhân viên từ database
        public DataTable GetNhanVien()
        {
            string selecQuerry = "Select * From NhanVien";
            SqlCommand command = new SqlCommand(selecQuerry, connect.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //Hàm thêm nhân viên
        public bool ThemNhanVien(string idNhanVien, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string cccd, string boPhan)
        {
            try
            {
                // Chuỗi truy vấn SQL để thêm nhân viên vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO NhanVien (IdNhanVien, TenNhanVien, NgaySinh, GioiTinh, DiaChi, SoDienThoai, CCCD, BoPhan) VALUES (@IdNhanVien, @TenNhanVien, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @CCCD, @BoPhan)";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(insertQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdNhanVien", SqlDbType.NChar).Value = idNhanVien;
                command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar).Value = tenNhanVien;
                command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = soDienThoai;
                command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = cccd;
                command.Parameters.Add("@BoPhan", SqlDbType.NVarChar).Value = boPhan;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }
        //Hàm sửa nhân viên
        public bool SuaNhanVien(string idNhanVien, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string cccd, string boPhan)
        {
            try
            {
                // Chuỗi truy vấn SQL để sửa thông tin nhân viên trong cơ sở dữ liệu
                string updateQuery = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, CCCD = @CCCD, BoPhan = @BoPhan WHERE IdNhanVien = @IdNhanVien";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(updateQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdNhanVien", SqlDbType.NChar).Value = idNhanVien;
                command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar).Value = tenNhanVien;
                command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = soDienThoai;
                command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = cccd;
                command.Parameters.Add("@BoPhan", SqlDbType.NVarChar).Value = boPhan;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }
        //Hàm xoá nhân viên
        public bool XoaNhanVien(string idNhanVien)
        {
            try
            {
                string deleteQuery = "DELETE FROM NhanVien WHERE IdNhanVien = @IdNhanVien";
                SqlCommand command = new SqlCommand(deleteQuery, connect.GetConnection());
                // Thay thế tham số trong câu lệnh SQL với giá trị thực tế
                command.Parameters.Add("@IdNhanVien", SqlDbType.NChar).Value = idNhanVien;
                connect.OpenCon();
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }

        #endregion

        #region Quản lý khách hàng
        // Hàm lấy thông tin bảng KhachHang
        public DataTable GetKhachHang()
        {
            try
            {
                // Chuỗi truy vấn SQL để lấy toàn bộ thông tin từ bảng KhachHang
                string selectQuery = "SELECT * FROM KhachHang";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());

                // Tạo đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter();

                // Tạo đối tượng DataTable để lưu trữ dữ liệu
                DataTable table = new DataTable();

                // Thiết lập đối tượng SqlCommand cho đối tượng SqlDataAdapter
                adapter.SelectCommand = command;

                // Đổ dữ liệu từ cơ sở dữ liệu vào DataTable
                adapter.Fill(table);

                // Trả về DataTable chứa thông tin từ bảng KhachHang
                return table;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về null
                Console.WriteLine($"Lỗi: {ex.Message}");
                return null;
            }
        }

        // Hàm thêm khách hàng
        public bool ThemKhachHang(string idKhachHang,string tenKhachHang,DateTime ngaySinh,string cccd,string diaChi,string soDienThoai)
        {
            try
            {
                // Chuỗi truy vấn SQL để thêm khách hàng vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO KhachHang (IdKhachHang, TenKhachHang, NgaySinh, DiaChi, SoDienThoai, CCCD) VALUES (@IdKhachHang, @TenKhachHang, @NgaySinh, @DiaChi, @SoDienThoai, @CCCD)";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(insertQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdKhachHang", SqlDbType.NChar).Value = idKhachHang;
                command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = tenKhachHang;
                command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = soDienThoai;
                command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = cccd;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }

        // Hàm sửa thông tin bảng KhachHang
        public bool SuaKhachHang(string idKhachHang, string tenKhachHang, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string cccd, string boPhan)
        {
            try
            {
                // Chuỗi truy vấn SQL để sửa thông tin khách hàng trong cơ sở dữ liệu
                string updateQuery = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, CCCD = @CCCD, BoPhan = @BoPhan WHERE IdKhachHang = @IdKhachHang";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(updateQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdKhachHang", SqlDbType.NChar).Value = idKhachHang;
                command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = tenKhachHang;
                command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = soDienThoai;
                command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = cccd;
                command.Parameters.Add("@BoPhan", SqlDbType.NVarChar).Value = boPhan;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }

        // Hàm xoá khách hàng
        public bool XoaKhachHang(string idKhachHang)
        {
            try
            {
                // Chuỗi truy vấn SQL để xoá khách hàng từ cơ sở dữ liệu
                string deleteQuery = "DELETE FROM KhachHang WHERE IdKhachHang = @IdKhachHang";
                SqlCommand command = new SqlCommand(deleteQuery, connect.GetConnection());

                // Thay thế tham số trong câu lệnh SQL với giá trị thực tế
                command.Parameters.Add("@IdKhachHang", SqlDbType.NChar).Value = idKhachHang;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }
        #endregion

        #region Quản lý chấm công
        // Hàm thêm chấm công
        public bool ThemChamCong(string idNhanVien, DateTime ngay, TimeSpan checkIn, TimeSpan? checkOut, decimal soGio)
        {
            try
            {
                // Chuỗi truy vấn SQL để thêm chấm công vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO ChamCong (IdNhanVien, Ngay, CheckIn, CheckOut, SoGio) VALUES (@IdNhanVien, @Ngay, @CheckIn, @CheckOut, @SoGio)";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(insertQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdNhanVien", SqlDbType.NChar).Value = idNhanVien;
                command.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
                command.Parameters.Add("@CheckIn", SqlDbType.Time).Value = checkIn;
                command.Parameters.Add("@CheckOut", SqlDbType.Time).Value = (object)checkOut ?? DBNull.Value;
                command.Parameters.Add("@SoGio", SqlDbType.Decimal).Value = soGio;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }

        // Hàm sửa thông tin chấm công
        public bool SuaChamCong(int idChamCong, string idNhanVien, DateTime ngay, TimeSpan checkIn, TimeSpan? checkOut, decimal soGio)
        {
            try
            {
                // Chuỗi truy vấn SQL để sửa thông tin chấm công trong cơ sở dữ liệu
                string updateQuery = "UPDATE ChamCong SET IdNhanVien = @IdNhanVien, Ngay = @Ngay, CheckIn = @CheckIn, CheckOut = @CheckOut, SoGio = @SoGio WHERE IdChamCong = @IdChamCong";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(updateQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdChamCong", SqlDbType.Int).Value = idChamCong;
                command.Parameters.Add("@IdNhanVien", SqlDbType.NChar).Value = idNhanVien;
                command.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
                command.Parameters.Add("@CheckIn", SqlDbType.Time).Value = checkIn;
                command.Parameters.Add("@CheckOut", SqlDbType.Time).Value = (object)checkOut ?? DBNull.Value;
                command.Parameters.Add("@SoGio", SqlDbType.Decimal).Value = soGio;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }

        // Hàm xoá chấm công
        public bool XoaChamCong(int idChamCong)
        {
            try
            {
                // Chuỗi truy vấn SQL để xoá chấm công từ cơ sở dữ liệu
                string deleteQuery = "DELETE FROM ChamCong WHERE IdChamCong = @IdChamCong";
                SqlCommand command = new SqlCommand(deleteQuery, connect.GetConnection());

                // Thay thế tham số trong câu lệnh SQL với giá trị thực tế
                command.Parameters.Add("@IdChamCong", SqlDbType.Int).Value = idChamCong;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }
        #endregion

        #region Quản lý hoá đơn
        // Hàm thêm hoá đơn
        public bool ThemHoaDon(string idPhong, DateTime ngayLap, decimal tongTien)
        {
            try
            {
                // Chuỗi truy vấn SQL để thêm hoá đơn vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO HoaDon (IdPhong, NgayLap, TongTien) VALUES (@IdPhong, @NgayLap, @TongTien)";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(insertQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdPhong", SqlDbType.NChar).Value = idPhong;
                command.Parameters.Add("@NgayLap", SqlDbType.Date).Value = ngayLap;
                command.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = tongTien;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }
        // Hàm thêm hoá đơn
        public bool ThemHoaDon(string idKhachHang, string idNhanVien, string idPhong, DateTime ngayLap)
        {
            try
            {
                // Chuỗi truy vấn SQL để thêm hoá đơn vào cơ sở dữ liệu
                string insertQuery = "INSERT INTO HoaDon (IdKhachHang, IdNhanVien, IdPhong, NgayLap) VALUES (@IdKhachHang, @IdNhanVien, @IdPhong, @NgayLap)";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(insertQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdKhachHang", SqlDbType.NChar).Value = idKhachHang;
                command.Parameters.Add("@IdNhanVien", SqlDbType.NChar).Value = idNhanVien;
                command.Parameters.Add("@IdPhong", SqlDbType.NChar).Value = idPhong;
                command.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = ngayLap;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }


        // Hàm sửa thông tin hoá đơn
        public bool SuaHoaDon(int idHoaDon, string idPhong, DateTime ngayLap, decimal tongTien)
        {
            try
            {
                // Chuỗi truy vấn SQL để sửa thông tin hoá đơn trong cơ sở dữ liệu
                string updateQuery = "UPDATE HoaDon SET IdPhong = @IdPhong, NgayLap = @NgayLap, TongTien = @TongTien WHERE IdHoaDon = @IdHoaDon";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(updateQuery, connect.GetConnection());

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.Add("@IdHoaDon", SqlDbType.Int).Value = idHoaDon;
                command.Parameters.Add("@IdPhong", SqlDbType.NChar).Value = idPhong;
                command.Parameters.Add("@NgayLap", SqlDbType.Date).Value = ngayLap;
                command.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = tongTien;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }

        // Hàm xoá hoá đơn
        public bool XoaHoaDon(int idHoaDon)
        {
            try
            {
                // Chuỗi truy vấn SQL để xoá hoá đơn từ cơ sở dữ liệu
                string deleteQuery = "DELETE FROM HoaDon WHERE IdHoaDon = @IdHoaDon";
                SqlCommand command = new SqlCommand(deleteQuery, connect.GetConnection());

                // Thay thế tham số trong câu lệnh SQL với giá trị thực tế
                command.Parameters.Add("@IdHoaDon", SqlDbType.Int).Value = idHoaDon;

                // Mở kết nối
                connect.OpenCon();

                // Thực hiện câu lệnh SQL và kiểm tra số dòng bị ảnh hưởng
                if (command.ExecuteNonQuery() == 1)
                {
                    // Đóng kết nối và trả về true nếu thành công
                    connect.CloseCon();
                    return true;
                }
                else
                {
                    // Đóng kết nối và trả về false nếu thất bại
                    connect.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi và trả về false
                Console.WriteLine($"Lỗi: {ex.Message}");
                connect.CloseCon();
                return false;
            }
        }
        #endregion




        #region Hàm sử lý logic
        #endregion

        #region Hàm load dữ liệu từ database

        // Lấy dữ liệu loại phòng
        public List<LoaiPhong> GetLoaiPhongList()
        {
            List<LoaiPhong> loaiPhongList = new List<LoaiPhong>();

            try
            {
                string selectQuery = "SELECT * FROM LoaiPhong";
                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());
                connect.OpenCon();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Tạo đối tượng LoaiPhong từ dữ liệu đọc được từ cơ sở dữ liệu
                        LoaiPhong loaiPhong = new LoaiPhong
                        {
                            IdLoaiPhong = reader["IdLoaiPhong"].ToString(),
                            TenLoaiPhong = reader["TenLoaiPhong"].ToString(),
                            SoNguoi = Convert.ToInt32(reader["SoNguoi"]),
                            GiaGioDau = Convert.ToInt32(reader["GiaGioDau"]),
                            GiaGioTiepTheo = Convert.ToInt32(reader["GiaGioTiepTheo"]),
                            GiaQuaDem = Convert.ToInt32(reader["GiaQuaDem"]),
                            GiaTheoNgay = Convert.ToInt32(reader["GiaTheoNgay"])
                        };

                        loaiPhongList.Add(loaiPhong);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                connect.CloseCon();
            }

            return loaiPhongList;
        }

        //Hàm lấy dữ liệu khách hàng
        public List<KhachHang> GetKhachHangList()
        {
            List<KhachHang> khachHangList = new List<KhachHang>();

            try
            {
                // Chuỗi truy vấn SQL để lấy thông tin từ bảng KhachHang
                string selectQuery = "SELECT * FROM KhachHang";

                // Tạo đối tượng SqlCommand
                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());

                // Mở kết nối
                connect.OpenCon();

                // Sử dụng SqlDataReader để đọc dữ liệu từ cơ sở dữ liệu
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Tạo đối tượng KhachHang từ dữ liệu đọc được từ cơ sở dữ liệu
                        KhachHang khachHang = new KhachHang
                        {
                            IdKhachHang = reader["IdKhachHang"].ToString(),
                            TenKhachHang = reader["TenKhachHang"].ToString(),
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                            CCCD = reader["CCCD"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString()
                        };

                        // Thêm đối tượng KhachHang vào danh sách
                        khachHangList.Add(khachHang);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                // Đóng kết nối sau khi sử dụng
                connect.CloseCon();
            }

            // Trả về danh sách khách hàng
            return khachHangList;
        }


        #endregion
    }
}