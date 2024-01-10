using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    public class SPClass
    {
        public static string TaoId()
        {
            // Lấy thông tin về ngày và giờ hiện tại
            DateTime thoiGianHienTai = DateTime.Now;

            // Tạo chuỗi IdDichVu từ thông tin về thời gian hiện tại
            string id = $"{thoiGianHienTai.Hour:00}{thoiGianHienTai.Minute:00}{thoiGianHienTai.Second:00}{thoiGianHienTai.Day:00}{thoiGianHienTai.Month:00}{thoiGianHienTai.Year % 100:00}";

            return id;
        }
    }
}
