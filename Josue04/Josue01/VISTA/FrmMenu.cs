using System;
using System.Windows.Forms;

namespace Josue01.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cLICKPARAMASINFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void arreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVisualDeUsuario frm = new FrmListaVisualDeUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void conexionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
