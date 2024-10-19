namespace MultiplasJanelas
{
    partial class CriarVendaForm2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1Produto = new ComboBox();
            comboBox2Fornecedor = new ComboBox();
            numericUpDown1Quantidade = new NumericUpDown();
            numericUpDown2Desconto = new NumericUpDown();
            textBox1PrecoUnit = new TextBox();
            textBox2ValorTot = new TextBox();
            textBox3TotalComDes = new TextBox();
            Okbutton1 = new Button();
            Cancelarbutton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2Desconto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Desconto(%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 194);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Preço Unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 239);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Valor Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 286);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 6;
            label7.Text = "Total Com Desconto:";
            // 
            // comboBox1Produto
            // 
            comboBox1Produto.FormattingEnabled = true;
            comboBox1Produto.Location = new Point(135, 9);
            comboBox1Produto.Name = "comboBox1Produto";
            comboBox1Produto.Size = new Size(145, 23);
            comboBox1Produto.TabIndex = 7;
            comboBox1Produto.SelectedIndexChanged += comboBox1Produto_SelectedIndexChanged;
            // 
            // comboBox2Fornecedor
            // 
            comboBox2Fornecedor.FormattingEnabled = true;
            comboBox2Fornecedor.Location = new Point(135, 51);
            comboBox2Fornecedor.Name = "comboBox2Fornecedor";
            comboBox2Fornecedor.Size = new Size(145, 23);
            comboBox2Fornecedor.TabIndex = 8;
            comboBox2Fornecedor.SelectedIndexChanged += comboBox2Fornecedor_SelectedIndexChanged;
            // 
            // numericUpDown1Quantidade
            // 
            numericUpDown1Quantidade.Location = new Point(135, 96);
            numericUpDown1Quantidade.Name = "numericUpDown1Quantidade";
            numericUpDown1Quantidade.Size = new Size(145, 23);
            numericUpDown1Quantidade.TabIndex = 9;
            numericUpDown1Quantidade.ValueChanged += numericUpDown1Quantidade_ValueChanged;
            // 
            // numericUpDown2Desconto
            // 
            numericUpDown2Desconto.Location = new Point(135, 146);
            numericUpDown2Desconto.Name = "numericUpDown2Desconto";
            numericUpDown2Desconto.Size = new Size(145, 23);
            numericUpDown2Desconto.TabIndex = 10;
            numericUpDown2Desconto.ValueChanged += numericUpDown2Desconto_ValueChanged;
            // 
            // textBox1PrecoUnit
            // 
            textBox1PrecoUnit.BackColor = SystemColors.ActiveBorder;
            textBox1PrecoUnit.Location = new Point(135, 194);
            textBox1PrecoUnit.Name = "textBox1PrecoUnit";
            textBox1PrecoUnit.ReadOnly = true;
            textBox1PrecoUnit.Size = new Size(145, 23);
            textBox1PrecoUnit.TabIndex = 11;
            textBox1PrecoUnit.TextChanged += textBox1PrecoUnit_TextChanged;
            // 
            // textBox2ValorTot
            // 
            textBox2ValorTot.BackColor = SystemColors.ActiveBorder;
            textBox2ValorTot.Location = new Point(135, 239);
            textBox2ValorTot.Name = "textBox2ValorTot";
            textBox2ValorTot.ReadOnly = true;
            textBox2ValorTot.Size = new Size(145, 23);
            textBox2ValorTot.TabIndex = 12;
            textBox2ValorTot.TextChanged += textBox2ValorTot_TextChanged;
            // 
            // textBox3TotalComDes
            // 
            textBox3TotalComDes.BackColor = SystemColors.ActiveBorder;
            textBox3TotalComDes.Location = new Point(135, 286);
            textBox3TotalComDes.Name = "textBox3TotalComDes";
            textBox3TotalComDes.ReadOnly = true;
            textBox3TotalComDes.Size = new Size(145, 23);
            textBox3TotalComDes.TabIndex = 13;
            textBox3TotalComDes.TextChanged += textBox3TotalComDes_TextChanged;
            // 
            // Okbutton1
            // 
            Okbutton1.Location = new Point(112, 333);
            Okbutton1.Name = "Okbutton1";
            Okbutton1.Size = new Size(75, 23);
            Okbutton1.TabIndex = 14;
            Okbutton1.Text = "Ok";
            Okbutton1.UseVisualStyleBackColor = true;
            Okbutton1.Click += Okbutton1_Click;
            // 
            // Cancelarbutton2
            // 
            Cancelarbutton2.Location = new Point(213, 333);
            Cancelarbutton2.Name = "Cancelarbutton2";
            Cancelarbutton2.Size = new Size(75, 23);
            Cancelarbutton2.TabIndex = 15;
            Cancelarbutton2.Text = "Cancelar";
            Cancelarbutton2.UseVisualStyleBackColor = true;
            Cancelarbutton2.Click += Cancelarbutton2_Click;
            // 
            // CriarVendaForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 401);
            Controls.Add(Cancelarbutton2);
            Controls.Add(Okbutton1);
            Controls.Add(textBox3TotalComDes);
            Controls.Add(textBox2ValorTot);
            Controls.Add(textBox1PrecoUnit);
            Controls.Add(numericUpDown2Desconto);
            Controls.Add(numericUpDown1Quantidade);
            Controls.Add(comboBox2Fornecedor);
            Controls.Add(comboBox1Produto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CriarVendaForm2";
            Text = "CriarVendaForm2";
            Load += CriarVendaForm2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2Desconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1Produto;
        private ComboBox comboBox2Fornecedor;
        private NumericUpDown numericUpDown1Quantidade;
        private NumericUpDown numericUpDown2Desconto;
        private TextBox textBox1PrecoUnit;
        private TextBox textBox2ValorTot;
        private TextBox textBox3TotalComDes;
        private Button Okbutton1;
        private Button Cancelarbutton2;
    }
}