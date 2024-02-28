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

    //Aqui é o nome da sua tela
    public partial class frmCliente : Form
    {
        //Aqui é uma lista da classe Clientes
        List<Clientes> clientes = new List<Clientes>();

        public frmCliente()
        {
            InitializeComponent();
        }          

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente incluido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = GridCliente.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = GridCliente.Rows[0].Cells[1].Value.ToString();
            txtCPF.Text = GridCliente.Rows[0].Cells[2].Value.ToString();
            txtTel.Text = GridCliente.Rows[0].Cells[3].Value.ToString();
            txtEndereco.Text = GridCliente.Rows[0].Cells[4].Value.ToString();
        }

        private void clienteExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja excluir cliente? ", "Ops", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void clientePesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisando cliente", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void InserteUpdate()
        {
            if (Validar())
            {

                if (Validar())
                {

                    Clientes cliente = new Clientes();// Aqui é um objeto da classe clientes
                    long ClienteId = long.Parse(txtClienteId.Text.Trim());

                    if (clientes.Count > 0)
                    {
                        cliente = clientes.Find(cliente => cliente.ClienteId == ClienteId);

                        if (cliente != null)
                        {
                            clientes.Remove(cliente);
                        }
                        else
                        {
                            cliente = new Clientes();
                        }


                    }

                    cliente.Nome = txtNome.Text.Trim();
                    cliente.CPF = txtId.Text.Trim();
                    cliente.Endereço = txtEndereco.Text.Trim();
                    cliente.Telefone = txtTelefone.Text.Trim();
                    clientes.Add(cliente);
                    limpar();
                    AtualizaGrid();
                }
            }
        }

        public bool Validar()
        {
            string mensagem = "";
            if (txtId.Text.Trim().Length == 0)
            {
                mensagem = " Campo Id não pode ser vazio";
            }
            else if (long.TryParse(txtId.Text.Trim(), out long Id) == false)
            {
                mensagem = "Campo Id tem quer um número";
            }
            else if (txtNome.Text.Trim().Length == 0)
            {
                mensagem = " Campo nome não pode ser vazio";
            }
            else if (long.TryParse(txtCPF.Text.Trim(), out long CPF) == false)
            {
                mensagem = "Campo CPF tem que ser um número";
            }
            else if (long.TryParse(txtTel.Text.Trim(), out long Tel) == false)
            {
                mensagem = "Campo Telefone tem que ser um número";
            }
            else if (txtEndereco.Text.Trim().Length == 0)
            {
                mensagem = "Campo nome tem que se um número";
            }
            if (mensagem != "")
            {
                MessageBox.Show(mensagem);
                return false;
            }
            return true;
        }
        private void limpar()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTel.Clear();
            txtClienteId.Clear();
        }

        private void AtualizaGrid()
        {

            GridCliente.Rows.Clear();
            foreach (Clientes cliente in clientes)//Aqui é um laço da sua lista de clientes
            {
                GridCliente.Rows.Add(cliente.ClienteId, cliente.Nome);
            }
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }
    }
}
