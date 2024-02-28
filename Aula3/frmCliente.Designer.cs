namespace Aula3
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCPF = new TextBox();
            label4 = new Label();
            txtEndereco = new TextBox();
            txtTel = new TextBox();
            label5 = new Label();
            txtTelefone = new Label();
            GridCliente = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colCPF = new DataGridViewTextBoxColumn();
            colEndereco = new DataGridViewTextBoxColumn();
            colTelefone = new DataGridViewTextBoxColumn();
            txtIncluir = new Button();
            txtAlterar = new Button();
            clienteExcluir = new Button();
            clientePesquisar = new Button();
            txtId = new Label();
            txtClienteId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 23);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(129, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(277, 27);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(392, 1);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 86);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 3;
            label3.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(14, 109);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(170, 27);
            txtCPF.TabIndex = 4;
            txtCPF.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(13, 152);
            label4.Name = "label4";
            label4.Size = new Size(389, 1);
            label4.TabIndex = 5;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(14, 176);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(392, 27);
            txtEndereco.TabIndex = 6;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(190, 109);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(216, 27);
            txtTel.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 153);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 8;
            label5.Text = "Endereço";
            label5.Click += label5_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.AutoSize = true;
            txtTelefone.Location = new Point(190, 86);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(66, 20);
            txtTelefone.TabIndex = 10;
            txtTelefone.Text = "Telefone";
            // 
            // GridCliente
            // 
            GridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCliente.Columns.AddRange(new DataGridViewColumn[] { colNome, colCPF, colEndereco, colTelefone });
            GridCliente.Location = new Point(11, 278);
            GridCliente.Name = "GridCliente";
            GridCliente.RowHeadersWidth = 51;
            GridCliente.RowTemplate.Height = 29;
            GridCliente.Size = new Size(549, 178);
            GridCliente.TabIndex = 11;
            GridCliente.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.Width = 125;
            // 
            // colCPF
            // 
            colCPF.HeaderText = "CPF";
            colCPF.MinimumWidth = 6;
            colCPF.Name = "colCPF";
            colCPF.Width = 125;
            // 
            // colEndereco
            // 
            colEndereco.HeaderText = "Endereço";
            colEndereco.MinimumWidth = 6;
            colEndereco.Name = "colEndereco";
            colEndereco.Width = 125;
            // 
            // colTelefone
            // 
            colTelefone.HeaderText = "Telefone";
            colTelefone.MinimumWidth = 6;
            colTelefone.Name = "colTelefone";
            colTelefone.Width = 125;
            // 
            // txtIncluir
            // 
            txtIncluir.Location = new Point(12, 216);
            txtIncluir.Name = "txtIncluir";
            txtIncluir.Size = new Size(94, 29);
            txtIncluir.TabIndex = 12;
            txtIncluir.Text = "Incluir";
            txtIncluir.UseVisualStyleBackColor = true;
            txtIncluir.Click += button1_Click;
            // 
            // txtAlterar
            // 
            txtAlterar.Location = new Point(112, 216);
            txtAlterar.Name = "txtAlterar";
            txtAlterar.Size = new Size(94, 29);
            txtAlterar.TabIndex = 13;
            txtAlterar.Text = "Alterar";
            txtAlterar.UseVisualStyleBackColor = true;
            txtAlterar.Click += button2_Click;
            // 
            // clienteExcluir
            // 
            clienteExcluir.Location = new Point(212, 216);
            clienteExcluir.Name = "clienteExcluir";
            clienteExcluir.Size = new Size(94, 29);
            clienteExcluir.TabIndex = 14;
            clienteExcluir.Text = "Excluir";
            clienteExcluir.UseVisualStyleBackColor = true;
            clienteExcluir.Click += clienteExcluir_Click;
            // 
            // clientePesquisar
            // 
            clientePesquisar.Location = new Point(312, 216);
            clientePesquisar.Name = "clientePesquisar";
            clientePesquisar.Size = new Size(94, 29);
            clientePesquisar.TabIndex = 15;
            clientePesquisar.Text = "Pesquisar";
            clientePesquisar.UseVisualStyleBackColor = true;
            clientePesquisar.Click += clientePesquisar_Click;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(14, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(24, 20);
            txtId.TabIndex = 16;
            txtId.Text = "ID";
            txtId.Click += txtId_Click;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(14, 46);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(109, 27);
            txtClienteId.TabIndex = 17;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 462);
            Controls.Add(txtClienteId);
            Controls.Add(txtId);
            Controls.Add(clientePesquisar);
            Controls.Add(clienteExcluir);
            Controls.Add(txtAlterar);
            Controls.Add(txtIncluir);
            Controls.Add(GridCliente);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(txtTel);
            Controls.Add(txtEndereco);
            Controls.Add(label4);
            Controls.Add(txtCPF);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de clientes";
            Load += Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)GridCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtCPF;
        private Label label4;
        private TextBox txtEndereco;
        private TextBox txtTel;
        private Label label5;
        private Label txtTelefone;
        private DataGridView GridCliente;
        private Button txtIncluir;
        private Button txtAlterar;
        private Button clienteExcluir;
        private Button clientePesquisar;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCPF;
        private DataGridViewTextBoxColumn colEndereco;
        private DataGridViewTextBoxColumn colTelefone;
        private Label txtId;
        private TextBox txtClienteId;
    }
}