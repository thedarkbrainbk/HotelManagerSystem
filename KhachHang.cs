using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    public class KhachHang
    {
        private string idKhachHang;
        private string tenKhachHang;
        private DateTime ngaySinh;
        private string cccd;
        private string diaChi;
        private string soDienThoai;

        // Thuộc tính public với get/set
        public string IdKhachHang
        {
            get { return idKhachHang; }
            set { idKhachHang = value; }
        }

        public string TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string CCCD
        {
            get { return cccd; }
            set { cccd = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        // Constructor mặc định
        public KhachHang()
        {
        }

        // Constructor với tham số
        public KhachHang(string idKhachHang, string tenKhachHang, DateTime ngaySinh, string cccd, string diaChi, string soDienThoai)
        {
            IdKhachHang = idKhachHang;
            TenKhachHang = tenKhachHang;
            NgaySinh = ngaySinh;
            CCCD = cccd;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        // Các phương thức khác nếu cần
    }
}
