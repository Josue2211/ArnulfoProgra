using Josue01.DAO;
using System;
using System.Windows.Forms;

namespace Josue01.VISTA
{
    public partial class FrmListaVisualDeUsuario : Form
    {
        public FrmListaVisualDeUsuario()
        {
            InitializeComponent();
        }

        private void FrmListaVisualDeUsuario_Load(object sender, EventArgs e)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();

            foreach (var iteracion in cls.user)
            {

                dataGridView3.Rows.Add(iteracion.ToString());

            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
