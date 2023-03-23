using System;
using BLL;
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
    public partial class FormConsultaGrupoUsuario : Form
    {
        public int Id;
        public FormConsultaGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();

            grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarPorNomeGrupoUsuario(textBoxBuscar.Text);
        }

        private void FormConsultaGrupoUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {

        }
    }
}
