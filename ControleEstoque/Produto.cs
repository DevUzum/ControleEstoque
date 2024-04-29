using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    internal class Produto
    {
        public Produto()
        {
            QuantidadeEstoque = 0;
        }

        public string Nome { get; set; }
        public decimal? Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Fabricante { get; set; }
    }
}
