using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestGUI1.View
{
    public partial class FrmDangNhap : Form
    {
        DbConnect connect = new DbConnect();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click_1(object sender, EventArgs e)
        {
            if(TxtMaNhanVien.Text == "" || TxtMatKhau.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin đăng nhập!");
            }
            else
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string selectQuery = "SELECT * FROM QuanLy WHERE IdQuanLy = @maQuanLy AND MatKhau = @matKhau";
                SqlCommand command = new SqlCommand(selectQuery, connect.GetConnection());
                command.Parameters.Add("@maQuanLy", SqlDbType.VarChar).Value = TxtMaNhanVien.Text;
                command.Parameters.Add("@matKhau", SqlDbType.VarChar).Value = TxtMatKhau.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    FrmQuanLy frmQuanLy = new FrmQuanLy();
                    frmQuanLy.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!");
                    TxtMaNhanVien.Text = "";
                    TxtMatKhau.Text = "";
                }
            }
        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
                // Đóng form khi người dùng chọn "Yes"
                this.Close();
            }
            // Nếu người dùng chọn "No", không làm gì cả
        }
    }
}
