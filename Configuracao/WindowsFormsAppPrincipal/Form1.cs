using BLL;
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
    public partial class G : Form
    {
        public G()
        {
            InitializeComponent();
        }
           private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Milena");
        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grupoUsuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();


        }
    }
}
