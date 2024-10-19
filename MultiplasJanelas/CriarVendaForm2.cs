using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplasJanelas
{
    public partial class CriarVendaForm2 : Form
    {
        private BindingList<Fornecedor> Fornecedores { get; set; }
        private Fornecedor Fornecedor { get { return Fornecedores.FirstOrDefault(f => f.Id == (int)comboBox2Fornecedor.SelectedValue); } }
        public int IdFornecedor { get { return (int)comboBox2Fornecedor.SelectedValue; } }

        private BindingList<Produto> Produtos { get; set; }
        private Produto Produto { get { return Produtos.FirstOrDefault(p => p.Id == (int)comboBox1Produto.SelectedValue); } }
        public int IdProduto { get { return (int)comboBox1Produto.SelectedValue; } }

        public decimal Quantidade { get { return numericUpDown1Quantidade.Value; } }
        public decimal Desconto { get { return numericUpDown2Desconto.Value; } }

        private decimal PrecoUnitario { get { return Produto.PrecoCompra; } }
        private decimal valorTotal { get { return PrecoUnitario * Quantidade; } }
        private decimal valorComDesconto { get { return valorTotal * (1 - (Desconto / 100)); } }
        public CriarVendaForm2(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)

        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBox2Fornecedor.DataSource = Fornecedores;
            comboBox2Fornecedor.ValueMember = "Id";
            comboBox2Fornecedor.DisplayMember = "NomeEmpresa";

            Produtos = produtos;
            comboBox1Produto.DataSource = Produtos;
            comboBox1Produto.ValueMember = "Id";
            comboBox1Produto.DisplayMember = "Nome";
        }

        private void CriarVendaForm2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void comboBox2Fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1Quantidade_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void numericUpDown2Desconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void textBox1PrecoUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2ValorTot_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3TotalComDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarValores()
        {
            if (Produto != null)
            {
                textBox1PrecoUnit.Text = PrecoUnitario.ToString("C", CultureInfo.CurrentCulture);
                textBox2ValorTot.Text = valorTotal.ToString("C", CultureInfo.CurrentCulture);
                textBox3TotalComDes.Text = valorComDesconto.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void Okbutton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
