using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Model
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nomeCliente { get; set; }
        public string nomeCachorro { get; set; }
        public string telefoneCliente { get; set; }
        public string emailCliente { get; set; }
        public string enderecoCliente { get; set; }
        public string clienteAtivo { get; set; }

        public override string ToString()
        {
            return this.nomeCliente + " - " + this.nomeCachorro;
        }
    }
}
