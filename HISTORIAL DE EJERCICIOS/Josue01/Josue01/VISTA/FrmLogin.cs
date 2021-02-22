using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Josue01.DOMINIO;
using Josue01.NEGOCIO;

namespace Josue01
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin clsL = new ClsLogin();

            int variabledeevaluacion= clsL.acceso(log);

            if (variabledeevaluacion == 1)
            {

                MessageBox.Show("Welcome");
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
