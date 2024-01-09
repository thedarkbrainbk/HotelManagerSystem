using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    internal class HoaDon
    {
        // Thuộc tính của đối tượng HoaDon
        private string idHoaDon;
        private string idNhanVien;
        private string idKhachHang;
        private string idPhong;
        private DateTime? checkIn;
        private DateTime? checkOut;
        private bool trangThai;
        private int? tongHoaDon;
        private string loaiNghi;

        // Thuộc tính IdHoaDon với phương thức get và set
        public string IdHoaDon
        {
            get { return idHoaDon; }
            set { idHoaDon = value; }
        }

        // Thuộc tính IdNhanVien với phương thức get và set
        public string IdNhanVien
        {
            get { return idNhanVien; }
            set { idNhanVien = value; }
        }

        // Thuộc tính IdKhachHang với phương thức get và set
        public string IdKhachHang
        {
            get { return idKhachHang; }
            set { idKhachHang = value; }
        }

        // Thuộc tính IdPhong với phương thức get và set
        public string IdPhong
        {
            get { return idPhong; }
            set { idPhong = value; }
        }

        // Thuộc tính CheckIn với phương thức get và set
        public DateTime? CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        // Thuộc tính CheckOut với phương thức get và set
        public DateTime? CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        // Thuộc tính TrangThai với phương thức get và set
        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        // Thuộc tính TongHoaDon với phương thức get và set
        public int? TongHoaDon
        {
            get { return tongHoaDon; }
            set { tongHoaDon = value; }
        }

        // Thuộc tính LoaiNghi với phương thức get và set
        public string LoaiNghi
        {
            get { return loaiNghi; }
            set { loaiNghi = value; }
        }

        // Constructor mặc định
        public HoaDon()
        {
        }

        // Constructor với tham số
        public HoaDon(string idHoaDon, string idNhanVien, string idKhachHang, string idPhong, DateTime? checkIn, DateTime? checkOut, bool trangThai, int? tongHoaDon, string loaiNghi)
        {
            IdHoaDon = idHoaDon;
            IdNhanVien = idNhanVien;
            IdKhachHang = idKhachHang;
            IdPhong = idPhong;
            CheckIn = checkIn;
            CheckOut = checkOut;
            TrangThai = trangThai;
            TongHoaDon = tongHoaDon;
            LoaiNghi = loaiNghi;
        }

        // Override phương thức ToString để hiển thị thông tin HoaDon
        public override string ToString()
        {
            return $"IdHoaDon: {IdHoaDon}, IdNhanVien: {IdNhanVien}, IdKhachHang: {IdKhachHang}, IdPhong: {IdPhong}, CheckIn: {CheckIn}, CheckOut: {CheckOut}, TrangThai: {TrangThai}, TongHoaDon: {TongHoaDon}, LoaiNghi: {LoaiNghi}";
        }
    }
}
