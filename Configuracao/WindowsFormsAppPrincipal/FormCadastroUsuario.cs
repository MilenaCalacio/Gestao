using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool alterar;

        public FormCadastroUsuario(bool _alterar = false, int _id = 0)
        {
            InitializeComponent();
            alterar = _alterar;

            if( alterar )
            {   UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorId(_id);
            }

        }

        public int Id { get; internal set; }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            try
            {
                usuarioBindingSource.EndEdit();
                if(!alterar)
                usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current,confirmacaoTextBox.Text);
                else
                usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, confirmacaoTextBox.Text);
                MessageBox.Show("Registro salvo com sucesso!");
                Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }


        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (!alterar)
            usuarioBindingSource.AddNew();
        }
    }
}
