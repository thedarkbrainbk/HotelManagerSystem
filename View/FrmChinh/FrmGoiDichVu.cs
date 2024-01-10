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
    public partial class FrmGoiDichVu : Form
    {
        public FrmGoiDichVu()
        {
            InitializeComponent();
        }

        private void FrmGoiDichVu_Load(object sender, EventArgs e)
        {

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình phát triển!");
        }
    }
}
