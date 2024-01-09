using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    public class LoaiPhong
    {
        private string idLoaiPhong;
        private string tenLoaiPhong;
        private int soNguoi;
        private int giaGioDau;
        private int giaGioTiepTheo;
        private int giaQuaDem;
        private int giaTheoNgay;

        public string IdLoaiPhong
        {
            get { return idLoaiPhong; }
            set { idLoaiPhong = value; }
        }

        public string TenLoaiPhong
        {
            get { return tenLoaiPhong; }
            set { tenLoaiPhong = value; }
        }

        public int SoNguoi
        {
            get { return soNguoi; }
            set { soNguoi = value; }
        }

        public int GiaGioDau
        {
            get { return giaGioDau; }
            set { giaGioDau = value; }
        }

        public int GiaGioTiepTheo
        {
            get { return giaGioTiepTheo; }
            set { giaGioTiepTheo = value; }
        }

        public int GiaQuaDem
        {
            get { return giaQuaDem; }
            set { giaQuaDem = value; }
        }

        public int GiaTheoNgay
        {
            get { return giaTheoNgay; }
            set { giaTheoNgay = value; }
        }

        public LoaiPhong()
        {
        }

        public LoaiPhong(string idLoaiPhong, string tenLoaiPhong, int soNguoi, int giaGioDau, int giaGioTiepTheo, int giaQuaDem, int giaTheoNgay)
        {
            IdLoaiPhong = idLoaiPhong;
            TenLoaiPhong = tenLoaiPhong;
            SoNguoi = soNguoi;
            GiaGioDau = giaGioDau;
            GiaGioTiepTheo = giaGioTiepTheo;
            GiaQuaDem = giaQuaDem;
            GiaTheoNgay = giaTheoNgay;
        }
    }

}
