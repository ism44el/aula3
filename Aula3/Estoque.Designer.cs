namespace Aula3
{
    partial class Estoque
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            estPesquisar = new Button();
            estExcluir = new Button();
            estAlterar = new Button();
            estIncluir = new Button();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colQuantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 9);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Quantidade";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 3;
            // 
            // estPesquisar
            // 
            estPesquisar.Location = new Point(324, 88);
            estPesquisar.Name = "estPesquisar";
            estPesquisar.Size = new Size(94, 29);
            estPesquisar.TabIndex = 19;
            estPesquisar.Text = "Pesquisar";
            estPesquisar.UseVisualStyleBackColor = true;
            estPesquisar.Click += estPesquisar_Click;
            // 
            // estExcluir
            // 
            estExcluir.Location = new Point(224, 88);
            estExcluir.Name = "estExcluir";
            estExcluir.Size = new Size(94, 29);
            estExcluir.TabIndex = 18;
            estExcluir.Text = "Excluir";
            estExcluir.UseVisualStyleBackColor = true;
            estExcluir.Click += estExcluir_Click;
            // 
            // estAlterar
            // 
            estAlterar.Location = new Point(124, 88);
            estAlterar.Name = "estAlterar";
            estAlterar.Size = new Size(94, 29);
            estAlterar.TabIndex = 17;
            estAlterar.Text = "Alterar";
            estAlterar.UseVisualStyleBackColor = true;
            estAlterar.Click += estAlterar_Click;
            // 
            // estIncluir
            // 
            estIncluir.Location = new Point(24, 88);
            estIncluir.Name = "estIncluir";
            estIncluir.Size = new Size(94, 29);
            estIncluir.TabIndex = 16;
            estIncluir.Text = "Incluir";
            estIncluir.UseVisualStyleBackColor = true;
            estIncluir.Click += estIncluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colQuantidade });
            dataGridView1.Location = new Point(12, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(426, 188);
            dataGridView1.TabIndex = 20;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 125;
            // 
            // colQuantidade
            // 
            colQuantidade.HeaderText = "Quantidade";
            colQuantidade.MinimumWidth = 6;
            colQuantidade.Name = "colQuantidade";
            colQuantidade.Width = 125;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 323);
            Controls.Add(dataGridView1);
            Controls.Add(estPesquisar);
            Controls.Add(estExcluir);
            Controls.Add(estAlterar);
            Controls.Add(estIncluir);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Estoque";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button estPesquisar;
        private Button estExcluir;
        private Button estAlterar;
        private Button estIncluir;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colQuantidade;
    }
}