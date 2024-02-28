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
    public partial class mnProduto : Form
    {
        List<Produto> produtos = new List<Produto>();
        public mnProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertUpdate();
        }

        private void ProdAlterar_Click(object sender, EventArgs e)
        {


            var a = Grid.SelectedRows[0].Cells[0].Value.ToString();
            txtDescricao.Text = Grid.Rows[0].Cells[1].Value.ToString();
            txtValor.Text = Grid.Rows[0].Cells[2].Value.ToString();
            txtId.Text = Grid.Rows[0].Cells[0].Value.ToString();
            txtTipo.Text = Grid.Rows[0].Cells[3].Value.ToString();


        }

        private void ProdExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja excluir produto? ", "Ops", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void ProdPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisando produto", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnProduto_Load(object sender, EventArgs e)
        {

        }

        private void InsertUpdate()
        {
            if (Validar())
            {

                Produto produto = new Produto();
                long produtoId = long.Parse(txtId.Text.Trim());

                if (produtos.Count > 0)
                {
                    produto = produtos.Find(produto => produto.Id == produtoId);

                    if (produto != null)
                    {
                        produtos.Remove(produto);
                    }
                    else
                    {
                        produto = new Produto();
                    }


                }


                produto.Descricao = txtDescricao.Text.Trim();
                produto.Valor = double.Parse(txtValor.Text.Trim());
                produto.Tipo = int.Parse(txtTipo.Text.Trim());
                produto.Id = long.Parse(txtId.Text.Trim());
                produtos.Add(produto);
                limpar();
                AtualizaGrid();
            }
        }
        private void limpar()
        {
            txtDescricao.Clear();
            txtValor.Clear();
            txtTipo.Clear();
            txtId.Clear();
        }

        private void AtualizaGrid()
        {
            
            Grid.Rows.Clear();
            foreach (Produto produto in produtos)
            {
                Grid.Rows.Add(produto.Id, produto.Descricao, produto.Valor, produto.Tipo);
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            string mensagem = "";
            if (txtId.Text.Trim().Length == 0)
            {
                mensagem = "O campo Id não pode ser vazio";
            }
            else if (long.TryParse(txtId.Text.Trim(), out long Id) == false)
            {
                mensagem = "Campo Id tem quer um número";
            }
            else if (txtDescricao.Text.Trim() == "")
            {
                mensagem = "O campo descrição não pode ser vazio";
            }
            else if (txtValor.Text.Trim().Length == 0)
            {
                mensagem = "O campo valor não pode ser vazio";
            }
            else if (double.TryParse(txtValor.Text.Trim(), out double Valor) == false)
            {
                mensagem = "Campo Valor tem que ser número";
            }

            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
                return false;
            }
            return true;

        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;


            txtDescricao.Text = Grid.Rows[index].Cells[colDescricao.Index].Value.ToString();
            txtValor.Text = Grid.Rows[index].Cells[2].Value.ToString();
            txtId.Text = Grid.Rows[index].Cells[0].Value.ToString();
            txtTipo.Text = Grid.Rows[index].Cells[3].Value.ToString();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
