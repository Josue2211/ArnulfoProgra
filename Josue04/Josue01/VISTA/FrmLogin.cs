using Josue01.DOMINIO;
using Josue01.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Josue01.VISTA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin clsL = new ClsLogin();

            int variabledeevaluacion = clsL.acceso(log);

            if (variabledeevaluacion == 1)
            {

                MessageBox.Show("Welcome");
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("False");
            }



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
