using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    public class HoaDonDichVu
    {
        // Thuộc tính của đối tượng HoaDonDichVu
        private string idHoaDon;
        private string idDichVu;
        private int soLuong;
        private int thanhTien;

        // Thuộc tính IdHoaDon với phương thức get và set
        public string IdHoaDon
        {
            get { return idHoaDon; }
            set { idHoaDon = value; }
        }

        // Thuộc tính IdDichVu với phương thức get và set
        public string IdDichVu
        {
            get { return idDichVu; }
            set { idDichVu = value; }
        }

        // Thuộc tính SoLuong với phương thức get và set
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        // Thuộc tính ThanhTien với phương thức get và set
        public int ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        // Constructor mặc định
        public HoaDonDichVu()
        {
        }

        // Constructor với tham số
        public HoaDonDichVu(string idHoaDon, string idDichVu, int soLuong, int thanhTien)
        {
            IdHoaDon = idHoaDon;
            IdDichVu = idDichVu;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }

        // Override phương thức ToString để hiển thị thông tin HoaDonDichVu
        public override string ToString()
        {
            return $"IdHoaDon: {IdHoaDon}, IdDichVu: {IdDichVu}, SoLuong: {SoLuong}, ThanhTien: {ThanhTien}";
        }
    }
}
