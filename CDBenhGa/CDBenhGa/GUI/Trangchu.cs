using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;

namespace CDBenhGa.GUI
{
    public partial class Trangchu : Form
    {
        private DockPanel dockPanel;
        private TrieuChung frmTrieu = new TrieuChung();
        private ChuanDoanBenh frmChuanDoan ;
        public Trangchu()
        {
            InitializeComponent();
            dockPanel = new DockPanel();
            this.Size = new Size(1030, 605);
            // Hiển thị panel chứa các triệu chứng bệnh ở phía bên trái
            dockPanel.DocumentStyle = DocumentStyle.DockingWindow;
            dockPanel.Dock = DockStyle.Fill;
            dockPanel.DockLeftPortion = 200;
            dockPanel.DockBottomPortion = 200;
            pnMain.Controls.Add(dockPanel);

            frmTrieu.FormClosed += new FormClosedEventHandler(frmTrieu_FormClosed);
            frmTrieu.Show(dockPanel, DockState.DockLeft);
        }
       
        private void frmTrieu_FormClosed(object sender, EventArgs e)
        {
            frmTrieu = null;
        }
        private void frmChuanDoan_FormClosed(object sender, EventArgs e)
        {
            frmTrieu = null;
        }

        private void chuẩnĐoánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmChuanDoan == null)
            {
                frmChuanDoan = new ChuanDoanBenh();
                frmChuanDoan.FormClosed += new FormClosedEventHandler(frmChuanDoan_FormClosed);
                frmChuanDoan.Show(dockPanel, DockState.Document);
            }
            else
                frmChuanDoan.Activate();
        }

        private void sựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (frmTrieu == null)
            {
                frmTrieu = new TrieuChung();
                frmTrieu.FormClosed += new FormClosedEventHandler(frmTrieu_FormClosed);
                frmTrieu.Show(dockPanel, DockState.DockLeft);
            }
            else
                frmTrieu.Activate();*/

            SuKien frmSk = new SuKien();
            frmSk.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            /*if (frmTrieu == null)
            {
                frmTrieu = new TrieuChung();
                frmTrieu.FormClosed += new FormClosedEventHandler(frmTrieu_FormClosed);
                frmTrieu.Show(dockPanel, DockState.DockLeft);
            }
            else
                frmChuanDoan.Activate();*/

            SuKien frmSk = new SuKien();
            frmSk.Show();
            frmSk.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (frmChuanDoan == null)
            {
                frmChuanDoan = new ChuanDoanBenh();
                frmChuanDoan.FormClosed += new FormClosedEventHandler(frmChuanDoan_FormClosed);
                frmChuanDoan.Show(dockPanel, DockState.Document);
            }
            else
                frmChuanDoan.Activate();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Luat frmLuat = new Luat();
            frmLuat.Show();
            frmLuat.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void luậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luat frmLuat = new Luat();
            frmLuat.Show();
            frmLuat.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login("", "");
            frmLogin.Show();
            this.Close();
        }
    }
}
