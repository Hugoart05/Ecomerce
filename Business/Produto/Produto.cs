using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Produtos
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? NomeProduto { get; private set; }
        public string? DescricaoProduto { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QntProduto { get; set; }
        public float PrecoCusto { get; private set; }
        public float PrecoVenda { get; set; } 
        public int  FornecedorProdutoId { get; set; }
        public virtual FornecedorProduto fornecedor { get; set; }
        public ICollection<FornecedorProduto> FornecedorProdutos { get;}


        public string PrecoVendaProduto()
        {
            
            return "logica";
        }

    }
}
