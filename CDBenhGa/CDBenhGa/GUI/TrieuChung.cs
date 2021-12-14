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
    public partial class TrieuChung : DockContent
    {
        ConnectToDB connDB = new ConnectToDB();
        DataSet data;
        public TrieuChung()
        {
            InitializeComponent();
            GetData();
        }
        public DataSet GetData()
        {
            string sql = "Select TenSK from SuKien";
            data = connDB.get_data(sql,"SUKIEN",null);
            lstSuKien.DataSource = data.Tables["SUKIEN"];
            lstSuKien.DisplayMember = "TenSK";
            return data;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            data.Tables["SUKIEN"].DefaultView.RowFilter = "TenSK Like '%" + txtTimKiem.Text + "%'";
        }

    }
}
