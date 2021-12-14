using System;
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
    public partial class ThongTinBoSung : UserControl
    {
        public ThongTinBoSung()
        {
            InitializeComponent();
        }
        public Label LblCauHoi
        {
            get { return lblCauHoi; }
            set { lblCauHoi = value; }
        }

        public RadioButton RadCo
        {
            get { return radCo; }
            set { radCo = value; }
        }

        public RadioButton RadKhong
        {
            get { return radKhong; }
            set { radKhong = value; }
        }
    }
}
