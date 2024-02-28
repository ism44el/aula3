using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    public class ClasEstoque
    {
        public long Id { get; set; }
        public int CodigoDoProduto { get; set; }
        public int Quantidade { get; set; }

        public ClasEstoque(int codigoDoProduto, int quantidade)
        {
            CodigoDoProduto = codigoDoProduto;
            Quantidade = quantidade;
        }
    }
}
