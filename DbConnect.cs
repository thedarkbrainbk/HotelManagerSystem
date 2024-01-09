using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestGUI1
{
    internal class DbConnect
    {
        private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nguyen Khac Anh Tuan\\Desktop\\RemotePhanMemQuanLyKhachSan\\HotelManagerSystem\\DBQuanLyKhachSan.mdf\";Integrated Security=True");
        //tạo hàm trả về kết nối
        public SqlConnection GetConnection() { return connection; }
        //tạo hàm mở kết nối
        public void OpenCon()
        {
            if(connection.State == System.Data.ConnectionState.Closed) 
            { 
            connection.Open();
            }

        }
        //tạo hàm đóng kết nối
        public void CloseCon()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
