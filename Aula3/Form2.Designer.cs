namespace Aula3
{
    partial class mnProduto
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtDescricao = new TextBox();
            label2 = new Label();
            txtValor = new TextBox();
            label3 = new Label();
            txtTipo = new TextBox();
            ProdPesquisar = new Button();
            ProdExcluir = new Button();
            ProdAlterar = new Button();
            ProdIncluir = new Button();
            Grid = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            label4 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 8);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Descrição";
            label1.Click += label1_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(129, 31);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(320, 27);
            txtDescricao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(29, 86);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(166, 27);
            txtValor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 63);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Tipo";
            label3.Click += label3_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(201, 86);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(248, 27);
            txtTipo.TabIndex = 5;
            // 
            // ProdPesquisar
            // 
            ProdPesquisar.Location = new Point(329, 137);
            ProdPesquisar.Name = "ProdPesquisar";
            ProdPesquisar.Size = new Size(94, 29);
            ProdPesquisar.TabIndex = 23;
            ProdPesquisar.Text = "Pesquisar";
            ProdPesquisar.UseVisualStyleBackColor = true;
            ProdPesquisar.Click += ProdPesquisar_Click;
            // 
            // ProdExcluir
            // 
            ProdExcluir.Location = new Point(229, 137);
            ProdExcluir.Name = "ProdExcluir";
            ProdExcluir.Size = new Size(94, 29);
            ProdExcluir.TabIndex = 22;
            ProdExcluir.Text = "Excluir";
            ProdExcluir.UseVisualStyleBackColor = true;
            ProdExcluir.Click += ProdExcluir_Click;
            // 
            // ProdAlterar
            // 
            ProdAlterar.Location = new Point(129, 137);
            ProdAlterar.Name = "ProdAlterar";
            ProdAlterar.Size = new Size(94, 29);
            ProdAlterar.TabIndex = 21;
            ProdAlterar.Text = "Alterar";
            ProdAlterar.UseVisualStyleBackColor = true;
            ProdAlterar.Click += ProdAlterar_Click;
            // 
            // ProdIncluir
            // 
            ProdIncluir.Location = new Point(29, 137);
            ProdIncluir.Name = "ProdIncluir";
            ProdIncluir.Size = new Size(94, 29);
            ProdIncluir.TabIndex = 20;
            ProdIncluir.Text = "Incluir";
            ProdIncluir.UseVisualStyleBackColor = true;
            ProdIncluir.Click += button1_Click;
            // 
            // Grid
            // 
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Columns.AddRange(new DataGridViewColumn[] { colId, colDescricao, colValor, colTipo });
            Grid.Location = new Point(19, 188);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 51;
            Grid.RowTemplate.Height = 29;
            Grid.Size = new Size(557, 144);
            Grid.TabIndex = 24;
            Grid.CellClick += Grid_CellClick;
            Grid.CellContentClick += Grid_CellContentClick;
            Grid.SelectionChanged += Grid_SelectionChanged;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Width = 125;
            // 
            // colDescricao
            // 
            colDescricao.HeaderText = "Descrição";
            colDescricao.MinimumWidth = 6;
            colDescricao.Name = "colDescricao";
            colDescricao.Width = 125;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor";
            colValor.MinimumWidth = 6;
            colValor.Name = "colValor";
            colValor.Width = 125;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 8);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 25;
            label4.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(29, 31);
            txtId.Name = "txtId";
            txtId.Size = new Size(94, 27);
            txtId.TabIndex = 26;
            // 
            // mnProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 351);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(Grid);
            Controls.Add(ProdPesquisar);
            Controls.Add(ProdExcluir);
            Controls.Add(ProdAlterar);
            Controls.Add(ProdIncluir);
            Controls.Add(txtTipo);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Name = "mnProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Load += mnProduto_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtDescricao;
        private Label label2;
        private TextBox txtValor;
        private Label label3;
        private TextBox txtTipo;
        private Button ProdPesquisar;
        private Button ProdExcluir;
        private Button ProdAlterar;
        private Button ProdIncluir;
        private DataGridView Grid;
        private Label label4;
        private TextBox txtId;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colTipo;
    }
}