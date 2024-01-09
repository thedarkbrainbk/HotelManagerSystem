using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    internal class Phong
    {
        // Thuộc tính của đối tượng phòng
        private string idPhong;
        private string tenPhong;
        private string idLoaiPhong;
        private string tinhTrangPhong;
        private bool isVip;

        // Thuộc tính IdPhong với phương thức get và set
        public string IdPhong
        {
            get { return idPhong; }
            set { idPhong = value; }
        }

        // Thuộc tính TenPhong với phương thức get và set
        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }

        // Thuộc tính IdLoaiPhong với phương thức get và set
        public string IdLoaiPhong
        {
            get { return idLoaiPhong; }
            set { idLoaiPhong = value; }
        }

        // Thuộc tính TinhTrangPhong với phương thức get và set
        public string TinhTrangPhong
        {
            get { return tinhTrangPhong; }
            set { tinhTrangPhong = value; }
        }

        // Thuộc tính IsVip với phương thức get và set
        public bool IsVip
        {
            get { return isVip; }
            set { isVip = value; }
        }

        // Constructor mặc định
        public Phong()
        {
        }

        // Constructor với tham số
        public Phong(string idPhong, string tenPhong, string idLoaiPhong, string tinhTrangPhong, bool isVip)
        {
            IdPhong = idPhong;
            TenPhong = tenPhong;
            IdLoaiPhong = idLoaiPhong;
            TinhTrangPhong = tinhTrangPhong;
            IsVip = isVip;
        }

        // Override phương thức ToString để hiển thị thông tin phòng
        public override string ToString()
        {
            return $"IdPhong: {IdPhong}, TenPhong: {TenPhong}, IdLoaiPhong: {IdLoaiPhong}, TinhTrangPhong: {TinhTrangPhong}, IsVip: {IsVip}";
        }
    }
}
