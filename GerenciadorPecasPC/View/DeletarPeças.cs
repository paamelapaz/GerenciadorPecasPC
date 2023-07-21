using GerenciadorPecasPC.Controller;
using GerenciadorPecasPC.Model;
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
    public partial class DeletarPecas : Form
    {
        public DeletarPecas()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigoVer.Text);
            
            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.DeletarPec();

        }

    

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();

            textBoxCodigoVer.Text = Pecas.Codigo.ToString();
            textBoxPeca.Text = Pecas.Peca;
            textBoxMarca.Text = Pecas.Marca;
            textBoxCapacidade.Text = Pecas.Capacidade;
        }
    }
}
