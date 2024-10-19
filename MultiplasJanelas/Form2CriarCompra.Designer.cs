namespace MultiplasJanelas
{
    partial class Form2CriarCompra
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
            button6Cancelar = new Button();
            button7Ok = new Button();
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2Desconto).BeginInit();
            SuspendLayout();
            // 
            // button6Cancelar
            // 
            button6Cancelar.Location = new Point(271, 287);
            button6Cancelar.Name = "button6Cancelar";
            button6Cancelar.Size = new Size(75, 23);
            button6Cancelar.TabIndex = 5;
            button6Cancelar.Text = "Cancelar";
            button6Cancelar.UseVisualStyleBackColor = true;
            button6Cancelar.Click += button6Cancelar_Click;
            // 
            // button7Ok
            // 
            button7Ok.Location = new Point(181, 287);
            button7Ok.Name = "button7Ok";
            button7Ok.Size = new Size(75, 23);
            button7Ok.TabIndex = 6;
            button7Ok.Text = "Ok";
            button7Ok.UseVisualStyleBackColor = true;
            button7Ok.Click += button7Ok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 7;
            label1.Text = "Produto: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 8;
            label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 9;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 10;
            label4.Text = "Desconto(%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 11;
            label5.Text = "Preço Unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 204);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 12;
            label6.Text = "Valor Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 248);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 13;
            label7.Text = "Total Com Desconto:";
            // 
            // comboBox1Produto
            // 
            comboBox1Produto.FormattingEnabled = true;
            comboBox1Produto.Location = new Point(135, 6);
            comboBox1Produto.Name = "comboBox1Produto";
            comboBox1Produto.Size = new Size(211, 23);
            comboBox1Produto.TabIndex = 14;
            comboBox1Produto.SelectedIndexChanged += comboBox1Produto_SelectedIndexChanged;
            // 
            // comboBox2Fornecedor
            // 
            comboBox2Fornecedor.FormattingEnabled = true;
            comboBox2Fornecedor.Location = new Point(135, 41);
            comboBox2Fornecedor.Name = "comboBox2Fornecedor";
            comboBox2Fornecedor.Size = new Size(211, 23);
            comboBox2Fornecedor.TabIndex = 15;
            comboBox2Fornecedor.SelectedIndexChanged += comboBox2Fornecedor_SelectedIndexChanged;
            // 
            // numericUpDown1Quantidade
            // 
            numericUpDown1Quantidade.Location = new Point(135, 78);
            numericUpDown1Quantidade.Name = "numericUpDown1Quantidade";
            numericUpDown1Quantidade.Size = new Size(211, 23);
            numericUpDown1Quantidade.TabIndex = 16;
            numericUpDown1Quantidade.ValueChanged += numericUpDown1Quantidade_ValueChanged;
            // 
            // numericUpDown2Desconto
            // 
            numericUpDown2Desconto.Location = new Point(135, 114);
            numericUpDown2Desconto.Name = "numericUpDown2Desconto";
            numericUpDown2Desconto.Size = new Size(211, 23);
            numericUpDown2Desconto.TabIndex = 17;
            numericUpDown2Desconto.ValueChanged += numericUpDown2Desconto_ValueChanged;
            // 
            // textBox1PrecoUnit
            // 
            textBox1PrecoUnit.BackColor = SystemColors.WindowFrame;
            textBox1PrecoUnit.ForeColor = SystemColors.Window;
            textBox1PrecoUnit.Location = new Point(135, 156);
            textBox1PrecoUnit.Name = "textBox1PrecoUnit";
            textBox1PrecoUnit.ReadOnly = true;
            textBox1PrecoUnit.Size = new Size(211, 23);
            textBox1PrecoUnit.TabIndex = 18;
            textBox1PrecoUnit.TextChanged += textBox1PrecoUnit_TextChanged;
            // 
            // textBox2ValorTot
            // 
            textBox2ValorTot.BackColor = SystemColors.WindowFrame;
            textBox2ValorTot.ForeColor = SystemColors.Window;
            textBox2ValorTot.Location = new Point(135, 201);
            textBox2ValorTot.Name = "textBox2ValorTot";
            textBox2ValorTot.ReadOnly = true;
            textBox2ValorTot.Size = new Size(211, 23);
            textBox2ValorTot.TabIndex = 19;
            textBox2ValorTot.TextChanged += textBox2ValorTot_TextChanged;
            // 
            // textBox3TotalComDes
            // 
            textBox3TotalComDes.BackColor = SystemColors.WindowFrame;
            textBox3TotalComDes.ForeColor = SystemColors.Window;
            textBox3TotalComDes.Location = new Point(135, 248);
            textBox3TotalComDes.Name = "textBox3TotalComDes";
            textBox3TotalComDes.ReadOnly = true;
            textBox3TotalComDes.Size = new Size(211, 23);
            textBox3TotalComDes.TabIndex = 20;
            textBox3TotalComDes.TextChanged += textBox3TotalComDes_TextChanged;
            // 
            // Form2CriarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 326);
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
            Controls.Add(button7Ok);
            Controls.Add(button6Cancelar);
            Name = "Form2CriarCompra";
            Text = "Form2CriarCompra";
            Load += Form2CriarCompra_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2Desconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6Cancelar;
        private Button button7Ok;
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
    }
}