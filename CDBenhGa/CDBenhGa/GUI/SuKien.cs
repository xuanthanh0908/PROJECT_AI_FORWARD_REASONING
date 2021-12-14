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
    public partial class SuKien : Form
    {
        ConnectToDB db = new ConnectToDB();
        public SuKien()
        {
            InitializeComponent();
            dgvSK.DataSource = Load_Form().Tables["SUKIEN"];
            dgvSK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_Form()
        {
            string sql = "SELECT * FROM SUKIEN";
            DataSet data = db.get_data(sql, "SUKIEN", null);
            return data;
        }

        private void dgvSK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnThem.Enabled = false;
            txtMaSK.Enabled = false;
            if(e.RowIndex >= 0 && e.RowIndex < dgvSK.Rows.Count - 1)
            {
                txtMaSK.Text = dgvSK.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMota.Text = dgvSK.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCauhoi.Text = dgvSK.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSK = txtMaSK.Text;
            string TenSk = txtMota.Text;
            string cauhoi = txtCauhoi.Text;

            string sql = "INSERT INTO SUKIEN VALUES (@mask,@tensk,@cauhoi)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("mask", MaSK));
            parameters.Add(new SqlParameter("tensk", TenSk));
            parameters.Add(new SqlParameter("cauhoi", cauhoi));

            if(MaSK == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.Excute(sql, parameters);
                MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                ClearText();
                btnSua.Enabled = true;
                btnXOa.Enabled = true;
            }

        }
        public void ClearText()
        {
            txtMaSK.Text = "";
            txtMota.Text = "";
            txtCauhoi.Text = "";
        }
        public void Refresh()
        {
            dgvSK.DataSource = Load_Form().Tables["SUKIEN"];
            dgvSK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaSK = txtMaSK.Text;
            string TenSk = txtMota.Text;
            string cauhoi = txtCauhoi.Text;

            string sql = "UPDATE SUKIEN SET TENSK = @TENSK, CAUHOI = @CAUHOI WHERE MASK = @MASK";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("MASK", MaSK));
            parameters.Add(new SqlParameter("TENSK", TenSk));
            parameters.Add(new SqlParameter("CAUHOI", cauhoi));

            if (MaSK == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.Excute(sql, parameters);
                MessageBox.Show("Sửa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                ClearText();
                btnThem.Enabled = true;
            }
        }

        private void btnXOa_Click(object sender, EventArgs e)
        {
            string MaSK = txtMaSK.Text;
            string sql = "DELETE SUKIEN WHERE MASK = @MASK";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("MASK", MaSK));

            if (MaSK == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(rs == DialogResult.Yes)
                {
                    db.Excute(sql, parameters);
                    MessageBox.Show("Xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    ClearText();
                    btnThem.Enabled = true;
                }
            }
        }

      
        private void SuKien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchu frmMain = new Trangchu();
            frmMain.Show();
            frmMain.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
