using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestGUI1.View;

namespace TestGUI1
{
    internal class ModelTaiKhoan
    {
        DbConnect connect = new DbConnect();

        //Tạo hàm thay đổi mật khẩu
        internal bool DoiMatKhau(string maQuanLy, string matKhauHienTai, string matKhauMoi, string xacNhanMatKhauMoi)
        {
            try
            {
                // Kiểm tra xác nhận mật khẩu mới
                if (matKhauMoi != xacNhanMatKhauMoi)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!");
                    return false;
                }

                // Kiểm tra thông tin đăng nhập
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string selectQuery = "SELECT * FROM QuanLy WHERE IdQuanLy = @maQuanLy AND MatKhau = @matKhauHienTai";
                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());
                command.Parameters.Add("@maQuanLy", SqlDbType.VarChar).Value = maQuanLy;
                command.Parameters.Add("@matKhauHienTai", SqlDbType.VarChar).Value = matKhauHienTai;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    // Thực hiện cập nhật mật khẩu mới
                    string updateQuery = "UPDATE QuanLy SET MatKhau = @matKhauMoi WHERE IdQuanLy = @maQuanLy";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connect.GetConnection());
                    updateCommand.Parameters.Add("@maQuanLy", SqlDbType.VarChar).Value = maQuanLy;
                    updateCommand.Parameters.Add("@matKhauMoi", SqlDbType.VarChar).Value = matKhauMoi;

                    connect.OpenCon();
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    connect.CloseCon();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không thể đổi mật khẩu. Thử lại sau!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }

    }
}
