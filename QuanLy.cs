using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    internal class QuanLy
    {
        // Thuộc tính của đối tượng QuanLy
        private string idQuanLy;
        private string matKhau;

        // Thuộc tính IdQuanLy với phương thức get và set
        public string IdQuanLy
        {
            get { return idQuanLy; }
            set { idQuanLy = value; }
        }

        // Thuộc tính MatKhau với phương thức get và set
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        // Constructor mặc định
        public QuanLy()
        {
        }

        // Constructor với tham số
        public QuanLy(string idQuanLy, string matKhau)
        {
            IdQuanLy = idQuanLy;
            MatKhau = matKhau;
        }

        // Override phương thức ToString để hiển thị thông tin QuanLy
        public override string ToString()
        {
            return $"IdQuanLy: {IdQuanLy}, MatKhau: {MatKhau}";
        }
    }
}
