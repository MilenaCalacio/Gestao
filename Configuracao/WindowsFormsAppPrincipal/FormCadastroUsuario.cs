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
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

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
                usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current);
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
            usuarioBindingSource.AddNew();
        }
    }
}
