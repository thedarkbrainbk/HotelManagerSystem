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
    public partial class FrmTaiKhoan : Form
    {
        ModelTaiKhoan modelTaiKhoan = new ModelTaiKhoan();
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string maQuanLy = TxtMaQuanLy.Text;
            string matKhauHienTai = TxtMatKhauHienTai.Text;
            string matKhauMoi = TxtMatKhauMoi.Text;
            string xacNhanMatKhauMoi = TxtXacNhanMKM.Text;
            if(modelTaiKhoan.DoiMatKhau(maQuanLy, matKhauHienTai, matKhauMoi, xacNhanMatKhauMoi));
            
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
