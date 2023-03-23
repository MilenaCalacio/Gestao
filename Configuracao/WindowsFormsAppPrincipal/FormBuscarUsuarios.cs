using Models;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using System;
using System.Linq.Expressions;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuarios : Form 
    {
        private int id;

        public FormBuscarUsuarios()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, System.EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();

            throw new NotImplementedException();
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            using(FormCadastroUsuario Frm = new FormCadastroUsuario())
            {
                Frm.ShowDialog();
                UsuarioBLL usuarioBLL=new UsuarioBLL();
                int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                usuarioBLL.AdicionarGrupo(idUsuario, Frm.Id);
            }
          
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
            }

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

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {

            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
            }

            if (MessageBox.Show("Deseja realmete excluir este registro?", "Anteção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
                int id = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);

            MessageBox.Show("Rsgistro excluído com sucesso!");
            buttonBuscar_Click(null, null);

        }

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario())
            {
                frm.ShowDialog();

                if (frm.Id == 0)
                    return;
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                usuarioBLL.AdicionarGrupo(idUsuario, frm.Id);

            }

        }

        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {
            if(usuarioBindingSource.Count == 0 || grupoUsuariosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existe grupo de usuário para ser excluir.");
                return;
            }
           
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
            int idGrupoUsuario = ((GrupoUsuario)grupoUsuariosBindingSource.Current).Id;
            new UsuarioBLL().RemoverGrupoUsuario(idUsuario, idGrupoUsuario);
            grupoUsuariosBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso! ");
            buttonBuscar_Click(null, null);
        }
    }
}
