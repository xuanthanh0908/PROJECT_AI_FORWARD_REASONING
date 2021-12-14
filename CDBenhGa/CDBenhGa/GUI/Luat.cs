using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CDBenhGa.GUI
{
    public partial class Luat : Form
    {
        ConnectToDB db = new ConnectToDB();
        string vetrai = "";
        string vephai = "";
        string selectTrai = "";
        string selectPhai = "";
        public Luat()
        {
            InitializeComponent();
            this.Size = new Size(850, 550);
            Load_SK();
            Load_LUAT();
            Load_MOTAKL();
        }
        public void Load_SK()
        {
            string sql = "SELECT * FROM SUKIEN";
            DataSet data = db.get_data(sql,"SUKIEN",null);
            dgvSK.DataSource = data.Tables["SUKIEN"];
            dgvSK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Load_LUAT()
        {
            string sql = "SELECT * FROM LUAT";
            DataSet data = db.get_data(sql, "LUAT", null);
            dgvLuat.DataSource = data.Tables["LUAT"];
            dgvLuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Load_MOTAKL()
        {
            string sql = "SELECT * FROM MOTAKL";
            DataSet data = db.get_data(sql, "MOTAKL", null);
            dgvMoKl.DataSource = data.Tables["MOTAKL"];
            dgvMoKl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvSK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgvSK.Rows.Count - 1)
            {
                selectTrai = dgvSK.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dgvMoKl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMoKl.Rows.Count - 1)
            {
                selectPhai = dgvMoKl.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnVT_Click(object sender, EventArgs e)
        {
            if(selectTrai == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin vế trái !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtVetrai.Enabled = false;
                txtMaluat.Enabled = false;
                txtVephai.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                if (txtVetrai.Text == "")
                {
                    txtVetrai.Text = selectTrai;
                }
                else
                {
                    txtVetrai.Text += " ^ " + selectTrai;
                }
            }    
        }

        private void btnVP_Click(object sender, EventArgs e)
        {
            if (selectTrai == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin vế phải !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtVetrai.Enabled = false;
                txtMaluat.Enabled = false;
                txtVephai.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                if (txtVephai.Text == "")
                {
                    txtVephai.Text = selectPhai;
                    return;
                }
            }
        }

        private void dgvLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLuat.Rows.Count - 1)
            {
                txtVetrai.Enabled = true;
                txtMaluat.Enabled = false;
                txtVephai.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                ///

                txtMaluat.Text = dgvLuat.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtVetrai.Text = dgvLuat.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtVephai.Text = dgvLuat.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        public void refresh()
        {
            txtVetrai.Text = "";
            txtVephai.Text = "";
            txtMaluat.Text = "";
            txtVetrai.Enabled = true;
            txtMaluat.Enabled = true;
            txtVephai.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maluat = "KL" + dgvLuat.Rows.Count.ToString();
            string vetrai = txtVetrai.Text;
            string vephai = txtVephai.Text;

            string sql = "INSERT INTO LUAT VALUES(@MALUAT,@VETRAI,@VEPHAI)";
            List <SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MALUAT", maluat));
            parameters.Add(new SqlParameter("@VETRAI", vetrai));
            parameters.Add(new SqlParameter("@VEPHAI", vephai));

            if (maluat == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.Excute(sql, parameters);
                MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                Load_LUAT();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maluat = txtMaluat.Text;
            string vetrai = txtVetrai.Text;
            string vephai = txtVephai.Text;

            string sql = "UPDATE LUAT SET VETRAI = @VETRAI,VEPHAI = @VEPHAI WHERE MALUAT = @MALUAT";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MALUAT", maluat));
            parameters.Add(new SqlParameter("@VETRAI", vetrai));
            parameters.Add(new SqlParameter("@VEPHAI", vephai));

            if (maluat == "")
            {
                MessageBox.Show("Vui chọn thông tin cần sửa !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.Excute(sql, parameters);
                MessageBox.Show("Sửa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                Load_LUAT();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maluat = txtMaluat.Text;
            string sql = "DELETE LUAT WHERE MALUAT = @MALUAT";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MALUAT", maluat));
            if (maluat == "")
            {
                MessageBox.Show("Vui chọn thông tin cần xóa !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa bản ghi này ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(rs == DialogResult.Yes)
                {
                    db.Excute(sql, parameters);
                    MessageBox.Show("Xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                    Load_LUAT();
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                }    
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Luat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trangchu frmMain = new Trangchu();
            frmMain.Show();
            frmMain.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
