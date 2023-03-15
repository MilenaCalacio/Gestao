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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Usuario)usuarioBindingSource.Current).Id;
            using (FormCadastroUsuario frm = new FormCadastroUsuario(true, id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_click(sender, e);
        }

        private void buttonBuscar_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
