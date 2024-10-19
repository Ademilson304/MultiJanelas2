namespace MultiplasJanelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            buttonViewClientes = new Button();
            buttonViewProdutos = new Button();
            buttonViewVendas = new Button();
            buttonAdicionarProd = new Button();
            buttonRemoverProd = new Button();
            buttonViewCompras = new Button();
            buttonViewFornecedores = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonAdicionarClient = new Button();
            button4 = new Button();
            button3 = new Button();
            buttonRemoverClient = new Button();
            buttonAdicionarFornecedores = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(990, 422);
            dataGridView1.TabIndex = 2;
            // 
            // buttonViewClientes
            // 
            buttonViewClientes.Anchor = AnchorStyles.Top;
            buttonViewClientes.BackColor = Color.FromArgb(64, 64, 64);
            buttonViewClientes.Cursor = Cursors.Hand;
            buttonViewClientes.FlatStyle = FlatStyle.Flat;
            buttonViewClientes.ForeColor = Color.White;
            buttonViewClientes.Image = Properties.Resources.cliente;
            buttonViewClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewClientes.Location = new Point(204, 12);
            buttonViewClientes.Name = "buttonViewClientes";
            buttonViewClientes.Size = new Size(178, 32);
            buttonViewClientes.TabIndex = 5;
            buttonViewClientes.Text = "Clientes";
            buttonViewClientes.UseVisualStyleBackColor = false;
            buttonViewClientes.Click += buttonViewClientes_Click;
            // 
            // buttonViewProdutos
            // 
            buttonViewProdutos.Anchor = AnchorStyles.Top;
            buttonViewProdutos.BackColor = Color.FromArgb(64, 64, 64);
            buttonViewProdutos.Cursor = Cursors.Hand;
            buttonViewProdutos.FlatStyle = FlatStyle.Flat;
            buttonViewProdutos.ForeColor = Color.White;
            buttonViewProdutos.Image = Properties.Resources.produto;
            buttonViewProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewProdutos.Location = new Point(12, 12);
            buttonViewProdutos.Name = "buttonViewProdutos";
            buttonViewProdutos.Size = new Size(182, 32);
            buttonViewProdutos.TabIndex = 4;
            buttonViewProdutos.Text = "Produtos";
            buttonViewProdutos.UseVisualStyleBackColor = false;
            buttonViewProdutos.Click += buttonViewProdutos_Click;
            // 
            // buttonViewVendas
            // 
            buttonViewVendas.Anchor = AnchorStyles.Top;
            buttonViewVendas.BackColor = Color.FromArgb(64, 64, 64);
            buttonViewVendas.Cursor = Cursors.Hand;
            buttonViewVendas.FlatStyle = FlatStyle.Flat;
            buttonViewVendas.ForeColor = Color.White;
            buttonViewVendas.Image = Properties.Resources.venda;
            buttonViewVendas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewVendas.Location = new Point(392, 12);
            buttonViewVendas.Name = "buttonViewVendas";
            buttonViewVendas.Size = new Size(182, 32);
            buttonViewVendas.TabIndex = 6;
            buttonViewVendas.Text = "Vendas";
            buttonViewVendas.UseVisualStyleBackColor = false;
            buttonViewVendas.Click += buttonViewVendas_Click;
            // 
            // buttonAdicionarProd
            // 
            buttonAdicionarProd.BackColor = Color.FromArgb(64, 64, 64);
            buttonAdicionarProd.Cursor = Cursors.Hand;
            buttonAdicionarProd.FlatAppearance.BorderSize = 0;
            buttonAdicionarProd.FlatStyle = FlatStyle.Flat;
            buttonAdicionarProd.ForeColor = Color.White;
            buttonAdicionarProd.Location = new Point(12, 50);
            buttonAdicionarProd.Name = "buttonAdicionarProd";
            buttonAdicionarProd.Size = new Size(182, 25);
            buttonAdicionarProd.TabIndex = 0;
            buttonAdicionarProd.Text = "Adicionar Produtos";
            buttonAdicionarProd.UseVisualStyleBackColor = false;
            buttonAdicionarProd.Click += buttonAdicionarProd_Click;
            // 
            // buttonRemoverProd
            // 
            buttonRemoverProd.BackColor = Color.FromArgb(64, 64, 64);
            buttonRemoverProd.Cursor = Cursors.Hand;
            buttonRemoverProd.FlatAppearance.BorderSize = 0;
            buttonRemoverProd.FlatStyle = FlatStyle.Flat;
            buttonRemoverProd.ForeColor = Color.White;
            buttonRemoverProd.Location = new Point(12, 81);
            buttonRemoverProd.Name = "buttonRemoverProd";
            buttonRemoverProd.Size = new Size(182, 25);
            buttonRemoverProd.TabIndex = 1;
            buttonRemoverProd.Text = "Remover Produtos";
            buttonRemoverProd.UseVisualStyleBackColor = false;
            buttonRemoverProd.Click += buttonRemoverProd_Click;
            // 
            // buttonViewCompras
            // 
            buttonViewCompras.Anchor = AnchorStyles.Top;
            buttonViewCompras.BackColor = Color.FromArgb(64, 64, 64);
            buttonViewCompras.Cursor = Cursors.Hand;
            buttonViewCompras.FlatStyle = FlatStyle.Flat;
            buttonViewCompras.ForeColor = Color.White;
            buttonViewCompras.Image = Properties.Resources.compra;
            buttonViewCompras.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewCompras.Location = new Point(800, 12);
            buttonViewCompras.Name = "buttonViewCompras";
            buttonViewCompras.Size = new Size(182, 32);
            buttonViewCompras.TabIndex = 8;
            buttonViewCompras.Text = "Compras";
            buttonViewCompras.UseVisualStyleBackColor = false;
            buttonViewCompras.Click += buttonViewCompras_Click;
            // 
            // buttonViewFornecedores
            // 
            buttonViewFornecedores.Anchor = AnchorStyles.Top;
            buttonViewFornecedores.BackColor = Color.FromArgb(64, 64, 64);
            buttonViewFornecedores.Cursor = Cursors.Hand;
            buttonViewFornecedores.FlatStyle = FlatStyle.Flat;
            buttonViewFornecedores.ForeColor = Color.White;
            buttonViewFornecedores.Image = Properties.Resources.fornecedor;
            buttonViewFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewFornecedores.Location = new Point(600, 12);
            buttonViewFornecedores.Name = "buttonViewFornecedores";
            buttonViewFornecedores.Size = new Size(182, 32);
            buttonViewFornecedores.TabIndex = 7;
            buttonViewFornecedores.Text = "Fornecedores";
            buttonViewFornecedores.UseVisualStyleBackColor = false;
            buttonViewFornecedores.Click += buttonViewFornecedores_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(392, 50);
            button2.Name = "button2";
            button2.Size = new Size(182, 25);
            button2.TabIndex = 9;
            button2.Text = "Adicionar Vendas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(392, 81);
            button1.Name = "button1";
            button1.Size = new Size(182, 25);
            button1.TabIndex = 10;
            button1.Text = "Remover Vendas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonAdicionarClient
            // 
            buttonAdicionarClient.BackColor = Color.FromArgb(64, 64, 64);
            buttonAdicionarClient.Cursor = Cursors.Hand;
            buttonAdicionarClient.FlatAppearance.BorderSize = 0;
            buttonAdicionarClient.FlatStyle = FlatStyle.Flat;
            buttonAdicionarClient.ForeColor = Color.White;
            buttonAdicionarClient.Location = new Point(200, 50);
            buttonAdicionarClient.Name = "buttonAdicionarClient";
            buttonAdicionarClient.Size = new Size(182, 25);
            buttonAdicionarClient.TabIndex = 13;
            buttonAdicionarClient.Text = "Adicionar Cliente";
            buttonAdicionarClient.UseVisualStyleBackColor = false;
            buttonAdicionarClient.Click += buttonAdicionarClient_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(800, 50);
            button4.Name = "button4";
            button4.Size = new Size(182, 25);
            button4.TabIndex = 11;
            button4.Text = "Adicionar Compra";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(800, 81);
            button3.Name = "button3";
            button3.Size = new Size(182, 25);
            button3.TabIndex = 12;
            button3.Text = "Remover Compra";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonRemoverClient
            // 
            buttonRemoverClient.BackColor = Color.FromArgb(64, 64, 64);
            buttonRemoverClient.Cursor = Cursors.Hand;
            buttonRemoverClient.FlatAppearance.BorderSize = 0;
            buttonRemoverClient.FlatStyle = FlatStyle.Flat;
            buttonRemoverClient.ForeColor = Color.White;
            buttonRemoverClient.Location = new Point(200, 81);
            buttonRemoverClient.Name = "buttonRemoverClient";
            buttonRemoverClient.Size = new Size(182, 25);
            buttonRemoverClient.TabIndex = 14;
            buttonRemoverClient.Text = "Remover Cliente";
            buttonRemoverClient.UseVisualStyleBackColor = false;
            buttonRemoverClient.Click += buttonRemoverClient_Click;
            // 
            // buttonAdicionarFornecedores
            // 
            buttonAdicionarFornecedores.BackColor = Color.FromArgb(64, 64, 64);
            buttonAdicionarFornecedores.Cursor = Cursors.Hand;
            buttonAdicionarFornecedores.FlatAppearance.BorderSize = 0;
            buttonAdicionarFornecedores.FlatStyle = FlatStyle.Flat;
            buttonAdicionarFornecedores.ForeColor = Color.White;
            buttonAdicionarFornecedores.Location = new Point(600, 50);
            buttonAdicionarFornecedores.Name = "buttonAdicionarFornecedores";
            buttonAdicionarFornecedores.Size = new Size(182, 25);
            buttonAdicionarFornecedores.TabIndex = 15;
            buttonAdicionarFornecedores.Text = "Adicionar Fornecedor";
            buttonAdicionarFornecedores.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedores.Click += buttonAdicionarFornecedores_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(600, 81);
            button7.Name = "button7";
            button7.Size = new Size(182, 25);
            button7.TabIndex = 16;
            button7.Text = "Remover Fornecedor";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1038, 625);
            Controls.Add(button7);
            Controls.Add(buttonAdicionarFornecedores);
            Controls.Add(dataGridView1);
            Controls.Add(buttonViewFornecedores);
            Controls.Add(buttonRemoverClient);
            Controls.Add(buttonViewCompras);
            Controls.Add(buttonAdicionarClient);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(buttonViewClientes);
            Controls.Add(buttonRemoverProd);
            Controls.Add(button4);
            Controls.Add(buttonAdicionarProd);
            Controls.Add(button2);
            Controls.Add(buttonViewProdutos);
            Controls.Add(buttonViewVendas);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private PictureBox fechar;
        private Button buttonViewClientes;
        private Button buttonViewProdutos;
        private Button buttonViewVendas;
        private Button buttonAdicionarProd;
        private Button buttonRemoverProd;
        private Button buttonViewCompras;
        private Button buttonViewFornecedores;
        private Button button2;
        private Button button1;
        private Button buttonAdicionarClient;
        private Button button4;
        private Button button3;
        private Button buttonRemoverClient;
        private Button buttonAdicionarFornecedores;
        private Button button7;
    }
}
