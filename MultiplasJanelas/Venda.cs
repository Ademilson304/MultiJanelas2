using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplasJanelas
{
    public class Venda
    {

    public int id { get; set; }
    
        [DisplayName("Id do Produto")] public int idProduto { get; set; }
        [DisplayName("Id do Cliente")] public int idcliente { get; set; }
        [DisplayName("Quantidade Vendida")] public int quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public decimal desconto { get; set; }
        [DisplayName("Id do Fornecedor")] public int idFornecedor { get; set; }
        [DisplayName("Data da compra")] public DateTime dataCompra { get; set; }
    }
}
