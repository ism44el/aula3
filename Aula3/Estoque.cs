using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void estIncluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionado ao estoque com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void estAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produto alterado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void estExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja excluir produto? ", "Ops", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void estPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisando produto", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
