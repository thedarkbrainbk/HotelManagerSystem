using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    internal class DichVu
    {
        // Thuộc tính của đối tượng Dịch Vụ
        private string idDichVu;
        private string tenDichVu;
        private string loaiDichVu;
        private string donViTinh;
        private int donGia;

        // Thuộc tính IdDichVu với phương thức get và set
        public string IdDichVu
        {
            get { return idDichVu; }
            set { idDichVu = value; }
        }

        // Thuộc tính TenDichVu với phương thức get và set
        public string TenDichVu
        {
            get { return tenDichVu; }
            set { tenDichVu = value; }
        }

        // Thuộc tính LoaiDichVu với phương thức get và set
        public string LoaiDichVu
        {
            get { return loaiDichVu; }
            set { loaiDichVu = value; }
        }

        // Thuộc tính DonViTinh với phương thức get và set
        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        // Thuộc tính DonGia với phương thức get và set
        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        // Constructor mặc định
        public DichVu()
        {
        }

        // Constructor với tham số
        public DichVu(string idDichVu, string tenDichVu, string loaiDichVu, string donViTinh, int donGia)
        {
            IdDichVu = idDichVu;
            TenDichVu = tenDichVu;
            LoaiDichVu = loaiDichVu;
            DonViTinh = donViTinh;
            DonGia = donGia;
        }

        // Override phương thức ToString để hiển thị thông tin Dịch Vụ
        public override string ToString()
        {
            return $"IdDichVu: {IdDichVu}, TenDichVu: {TenDichVu}, LoaiDichVu: {LoaiDichVu}, DonViTinh: {DonViTinh}, DonGia: {DonGia}";
        }
        
    }
}
