using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    internal class NhanVien
    {
        private string idNhanVien;
        private string tenNhanVien;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDienThoai;
        private string cccd;
        private string boPhan;

        // Thuộc tính IdNhanVien với phương thức get và set
        public string IdNhanVien
        {
            get { return idNhanVien; }
            set { idNhanVien = value; }
        }

        // Thuộc tính TenNhanVien với phương thức get và set
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        // Thuộc tính NgaySinh với phương thức get và set
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        // Thuộc tính GioiTinh với phương thức get và set
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        // Thuộc tính DiaChi với phương thức get và set
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        // Thuộc tính SoDienThoai với phương thức get và set
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        // Thuộc tính CCCD với phương thức get và set
        public string CCCD
        {
            get { return cccd; }
            set { cccd = value; }
        }

        // Thuộc tính BoPhan với phương thức get và set
        public string BoPhan
        {
            get { return boPhan; }
            set { boPhan = value; }
        }

        // Constructor mặc định
        public NhanVien()
        {
        }

        // Constructor với tham số
        public NhanVien(string idNhanVien, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai, string cccd, string boPhan)
        {
            IdNhanVien = idNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            CCCD = cccd;
            BoPhan = boPhan;
        }

        // Override phương thức ToString để hiển thị thông tin nhân viên
        public override string ToString()
        {
            return $"IdNhanVien: {IdNhanVien}, TenNhanVien: {TenNhanVien}, NgaySinh: {NgaySinh.ToShortDateString()}, GioiTinh: {GioiTinh}, DiaChi: {DiaChi}, SoDienThoai: {SoDienThoai}, CCCD: {CCCD}, BoPhan: {BoPhan}";
        }
    }
}
