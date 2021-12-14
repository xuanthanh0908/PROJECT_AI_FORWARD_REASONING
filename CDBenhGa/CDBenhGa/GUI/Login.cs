using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDBenhGa.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUS.Text = "xuanthanh";
            txtPas.Text = "123";
        }
        public Login(string tk, string mk)
        {
            InitializeComponent();
            txtUS.Text = tk;
            txtPas.Text = mk;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txtUS.Text;
                string pss = txtPas.Text;
                string sql = "SELECT COUNT(*) FROM NGUOIDUNG WHERE USERNAME = '" + tk + "' AND PASSWORD = '" + pss + "'";

                SqlConnection connection = new SqlConnection(ConnectToDB.conn);
                connection.Open();
                SqlCommand command = new SqlCommand(sql,connection) ;
                int count = (int)command.ExecuteScalar();
                connection.Close();

                if(count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Trangchu frmMain = new Trangchu();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi !!", ex.Message);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }
    }
}
