using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGUI1
{
    public class LoaiPhong
    {
        private int idLoaiPhong;
        private string tenLoaiPhong;
        private int soNguoi;
        private decimal giaGioDau;
        private decimal giaGioTiepTheo;
        private decimal giaQuaDem;
        private decimal giaTheoNgay;

        public int IdLoaiPhong
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

        public decimal GiaGioDau
        {
            get { return giaGioDau; }
            set { giaGioDau = value; }
        }

        public decimal GiaGioTiepTheo
        {
            get { return giaGioTiepTheo; }
            set { giaGioTiepTheo = value; }
        }

        public decimal GiaQuaDem
        {
            get { return giaQuaDem; }
            set { giaQuaDem = value; }
        }

        public decimal GiaTheoNgay
        {
            get { return giaTheoNgay; }
            set { giaTheoNgay = value; }
        }

        public LoaiPhong()
        {
        }

        public LoaiPhong(int idLoaiPhong, string tenLoaiPhong, int soNguoi, decimal giaGioDau, decimal giaGioTiepTheo, decimal giaQuaDem, decimal giaTheoNgay)
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
