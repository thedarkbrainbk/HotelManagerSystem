using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI1.View
{
    public partial class FrmChiTietHoaDon : Form
    {
        public FrmChiTietHoaDon()
        {

            InitializeComponent();
            
        }
        public FrmChiTietHoaDon(KhachHang khachHang, Phong phong, string maNhanVien)
        {
            InitializeComponent();
            TxtMaKhachHang.Text = khachHang.IdKhachHang;
            TxtTenKhachHang.Text = khachHang.TenKhachHang;
            TxtCCCDKH.Text = khachHang.CCCD;
            TxtDiaChiKH.Text = khachHang.CCCD;
            TxtSoDienThoaiKH.Text = khachHang.SoDienThoai;
            TxtMaNhanVien.Text = maNhanVien;
        }
        public FrmChiTietHoaDon(string tenPhong)
        {
            InitializeComponent();
            TxtTenPhong.Text = tenPhong;
        }


        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQuanLyKhachSanDataSet.HoaDonDichVu' table. You can move, or remove it, as needed.
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvHoaDonDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
