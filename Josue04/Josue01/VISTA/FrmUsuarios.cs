using Josue01.DAO;
using Josue01.MODEL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Josue01.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            Carga();
            Clear();
        }


        void Clear()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPass.Clear();

        }

        void Carga()
        {
            dtgListaUsuarios.Rows.Clear();
            ClsDUserList clsDUserList = new ClsDUserList();
            List<UserList> Lista = clsDUserList.cargarDatosUserList();


            foreach (var iteraction in Lista)
            {
                dtgListaUsuarios.Rows.Add(iteraction.Id, iteraction.NombreUsuario, iteraction.Apellido, iteraction.Edad, iteraction.Pass);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                ClsDUserList clsDUserList = new ClsDUserList();
                //clsDUserList.SaveDatosUser(txtNombre.Text,txtApellido.Text,Convert.ToInt32(txtEdad.Text),txtPass.Text);
                UserList userList = new UserList();
                userList.NombreUsuario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;
                clsDUserList.SaveDatosUser(userList);
            }
            else
            {
                ClsDUserList clsDUserList = new ClsDUserList();

                UserList userList = new UserList();
                userList.Id = Convert.ToInt32(txtID.Text);
                userList.NombreUsuario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;
                clsDUserList.UpdateUser(userList);


            }

            Carga();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            ClsDUserList userList = new ClsDUserList();
            userList.DeleteUser(Convert.ToInt32(txtID.Text));
            Carga();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Carga();
            Clear();

        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Pass = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();



            txtID.Text = Id;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtPass.Text = Pass;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void dtgListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
