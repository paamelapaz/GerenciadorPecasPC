using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorPecasPC.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroPecas telaCadastro = new TelaCadastroPecas();
            telaCadastro.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPecas buscarPecas = new BuscarPecas();
            buscarPecas.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarPecas alterarPecas = new AlterarPecas(); 
            alterarPecas.Show();

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarPecas deletarPecas = new DeletarPecas();
            deletarPecas.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
