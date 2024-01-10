using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    internal class ModelLamViec
    {
        DbConnect connect = new DbConnect();
        
        //Hàm lấy data bảng giá phòng
        public DataTable GetGiaPhong()
        {
            try
            {
                // Chuỗi truy vấn SQL để lấy toàn bộ thông tin từ bảng LoaiPhong
                string selectQuery = "SELECT\r\n    P.TenPhong,\r\n    LP.TenLoaiPhong,\r\n    LP.SoNguoi,\r\n    LP.GiaGioDau,\r\n    LP.GiaGioTiepTheo,\r\n    LP.GiaQuaDem,\r\n    LP.GiaTheoNgay,\r\n   P.TinhTrangPhong,\r\n    P.IsVip\r\nFROM\r\n    Phong P\r\nJOIN\r\n    LoaiPhong LP ON P.IdLoaiPhong = LP.IdLoaiPhong;";

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

        // Hàm lấy data phòng từ database
        public List<Phong> LayDanhSachPhong()
        {
            List<Phong> lstPhong = new List<Phong>();
            try
            {
                string selectQuery = "SELECT * FROM Phong";
                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());
                connect.OpenCon();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Tạo đối tượng Phong từ dữ liệu đọc được từ cơ sở dữ liệu
                        Phong phong = new Phong
                        {
                            IdPhong = reader["IdPhong"].ToString(),
                            TenPhong = reader["TenPhong"].ToString(),
                            IdLoaiPhong = reader["IdLoaiPhong"].ToString(),
                            IsVip = Convert.ToBoolean(reader["IsVip"])
                        };

                        lstPhong.Add(phong);
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

            return lstPhong;
        }

    }
}
