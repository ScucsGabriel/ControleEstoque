using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Model
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string descricao { get; set; }
        public double custo { get; set; }
        public int quantidade { get; set; }
        public double valorVendaProd { get; set; }
        public string produtoAtivo { get; set; }
        public override string ToString()
        {
            return this.descricao;
        }
    }
}
