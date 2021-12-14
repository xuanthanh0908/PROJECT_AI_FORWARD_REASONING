using CDBenhGa.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CDBenhGa.GUI
{
    public partial class ChuanDoanBenh : DockContent
    {
        private TrieuChungGap trieuChungGap ;
        private ThongTinBoSung thongTinBo ;
        private Dictionary<String, String> quaTrinhSuyDien;
        private List<Rules> KL;

        // variable for check question
        private Data getData = new Data();
        int position = 0;
        List<string> lstTrieu ;
        List<Rules> lstSK = null;
        DataSet Check;
        DataSet getALLRule;
        List<string> lstCauHoi;
        string currentQu;
        List<int> kq;


        public ChuanDoanBenh()
        {
            InitializeComponent();
            trieuChungGap = new TrieuChungGap();
            thongTinBo = new ThongTinBoSung();
            // Load
            Load_Form();
            
        }
        public void Load_Form()
        {
            pnlCauHoi.Controls.Clear();
            quaTrinhSuyDien = null;
            lblKetLuan.Text = "";
            lblQuaTrinhSuyDien.Text = "";
            thongTinBo.RadCo.Enabled = true;
            thongTinBo.RadKhong.Enabled = true;
            btnTiep.Enabled = true;
            btnKetThuc.Enabled = true;
            pnlCauHoi.Controls.Add(trieuChungGap);
            Check = new DataSet();
            lstTrieu = new List<string>();
            getALLRule = new ConnectToDB().get_data("SELECT * FROM LUAT", "ALLRULE", null);
            position = 0;
            lstCauHoi = new List<string>();
        }
        public void setCauHoi(String cauHoi)
        {
            thongTinBo.LblCauHoi.Text = cauHoi;
            thongTinBo.RadCo.Checked = true;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            string selected = trieuChungGap.getTrieuChungThuongGapNhat();
            if (quaTrinhSuyDien == null)
            {
                if(selected == null)
                {
                    MessageBox.Show("Bạn chưa chọn triệu chứng thường gặp nhất", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    quaTrinhSuyDien = new Dictionary<string, string>();
                    string sql = "SELECT TENSK,CAUHOI FROM SUKIEN WHERE MASK = '" + selected + "'";
                    DataSet suKienThoaMan = new ConnectToDB().get_data(sql, "CAUHOI", null);
                    quaTrinhSuyDien.Add(suKienThoaMan.Tables["CAUHOI"].Rows[0][1].ToString(), suKienThoaMan.Tables["CAUHOI"].Rows[0][0].ToString());
                    lblQuaTrinhSuyDien.Text = "";
                    String trieuChung = quaTrinhSuyDien.ElementAt(0).Value;
                    lblQuaTrinhSuyDien.Text = "Triệu chứng bạn chọn ban đầu: " + trieuChung;
                    KL = new List<Rules>();
                    pnlCauHoi.Controls.Remove(trieuChungGap);
                    pnlCauHoi.Controls.Add(thongTinBo);
                    lstSK = getData.get_rule(getALLRule.Tables["ALLRULE"]);
                    foreach (var item in lstSK)
                    {
                        if (item.Left.Contains(selected))
                        {
                            foreach (var con in item.Left)
                            {
                                if (!lstTrieu.Contains(con))
                                    lstTrieu.Add(con);
                            }
                        }
                    }
                    string query = "SELECT * FROM SUKIEN WHERE MASK = '" + selected + "'";
                    Check = new ConnectToDB().get_data(query, "CHECK", null);
                    lstCauHoi.Add(Check.Tables["CHECK"].Rows[0][0].ToString());
                    currentQu = Check.Tables["CHECK"].Rows[0][0].ToString();
                    if(lstTrieu.Count > 1)
                        lstTrieu.Remove(selected);
                    if(lstTrieu.Count == 0)
                    {
                        pnlCauHoi.Controls.Remove(thongTinBo);
                        btnTiep.Enabled = false;
                        btnKetThuc.Enabled = false;
                        lblKetLuan.Text = "Các dữ kiện chưa đủ để đưa ra lỗi cụ thể!\n";
                        lblKetLuan.Text += ("\t" + "==> Không thể chuẩn đoán được bệnh của gà!");
                    }
                    if (lstTrieu.Count >= 1)
                    {
                        query = "SELECT * FROM SUKIEN WHERE MASK = '" + lstTrieu[position] + "'";
                        Check = new ConnectToDB().get_data(query, "CHECK", null);
                        try
                        {
                            setCauHoi(Check.Tables["CHECK"].Rows[0][2].ToString());
                            currentQu = Check.Tables["CHECK"].Rows[0][0].ToString();
                            position = position + 1;
                        }
                        catch
                        {

                        }
                    }
                    else {
                        btnTiep.Enabled = false;
                        btnKetThuc.Enabled = false;
                    }
                }
            }
            else
            {
                String selected2 = (thongTinBo.RadCo.Checked == true) ? "Có" : "Không";
                String key = thongTinBo.LblCauHoi.Text;
                lblQuaTrinhSuyDien.Text += "\n" + "Chương trình hỏi: " + key + "   Bạn trả lời: " + selected2;
                if (selected2.Equals("Có"))
                {
                    string query = "SELECT * FROM SUKIEN WHERE CAUHOI = '" + key + "'";
                    Check = new ConnectToDB().get_data(query, "CHECK", null);
                    lstCauHoi.Add(currentQu);
                }
                if (position == lstTrieu.Count || lstTrieu.Count == 0)
                {
                    btnTiep.Enabled = false;
                    btnKetThuc.Enabled = false;

                    /// XỬ LÝ SUY DIỄN TIẾN -- FORWARD_REASONING
                    Handle_forward_reasoning();
                }
                
                if(position < lstTrieu.Count)
                {
                    string query = "SELECT * FROM SUKIEN WHERE MASK = '" + lstTrieu[position] + "'";
                    Check = new ConnectToDB().get_data(query, "CHECK", null);
                    setCauHoi(Check.Tables["CHECK"].Rows[0][2].ToString());
                    currentQu = Check.Tables["CHECK"].Rows[0][0].ToString();
                    position = position + 1;
                }
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            Load_Form();
        }

        
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Handle_forward_reasoning();
        }

        private void Handle_forward_reasoning()
        {
            List<string> TG = new List<string>();
            TG.AddRange(lstCauHoi);
            Data data = new Data();
            kq = new List<int>();
            DataSet KL_table = new ConnectToDB().get_data("SELECT MAKL,MoTa FROM MOTAKL", "KL_TABLE", null);
            DataSet Rule_table = new ConnectToDB().get_data("SELECT * FROM LUAT", "RULES_TABLE", null);
            kq.AddRange(data.forward_reasoning(KL_table.Tables["KL_TABLE"], Rule_table.Tables["RULES_TABLE"], TG));

            if (kq.Count != 0)
            {
                lblKetLuan.Text = "";
                foreach (int item in kq)
                {
                    lblKetLuan.Text += KL_table.Tables["KL_TABLE"].Rows[item][1].ToString() + "\n";
                }
            }
            else
            {
                lblKetLuan.Text = "Các dữ kiện chưa đủ để đưa ra lỗi cụ thể!\n";
                lblKetLuan.Text += ("\t" + "==> Không thể chuẩn đoán được bệnh của gà!");
            }
        }
    }
}
