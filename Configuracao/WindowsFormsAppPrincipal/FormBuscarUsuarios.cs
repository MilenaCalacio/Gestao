using Models;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using System;


namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuarios : Form
    {
        public FormBuscarUsuarios()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, System.EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            using(FormCadastroUsuario Frm = new FormCadastroUsuario())
            {
                Frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }
    }
}
