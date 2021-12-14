//using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDBenhGa.GUI
{
    public partial class TrieuChungGap : UserControl
    {
        ConnectToDB ConnectToDB;
        DataSet dataSet;
        public TrieuChungGap()
        {
            InitializeComponent();
            ConnectToDB = new ConnectToDB();
            HienThiTrieuChung();
        }
        public string getTrieuChungThuongGapNhat()
        {
            try
            {
                return cboTrieuChungThuongGapNhat.SelectedValue.ToString();
            }
            catch
            {
                return null;
            }
        }
        public void HienThiTrieuChung()
        {
            string sql = "Select MASK, TENSK From SuKien";
            dataSet = new ConnectToDB().get_data(sql, "SUKIEN", null);
            cboTrieuChungThuongGapNhat.DataSource = dataSet.Tables["SUKIEN"];
            cboTrieuChungThuongGapNhat.DisplayMember = "TENSK";
            cboTrieuChungThuongGapNhat.ValueMember = "MaSK";
        }
    }
}
