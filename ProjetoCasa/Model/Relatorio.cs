using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Model
{
    public class Relatorio
    {
        public string transacao { get; set; }
        public int quantidadePedido { get; set; }
        public int quantidadePedidoCancelados { get; set; }
        public int quantidadeItensVendidos { get; set; }
        public double mediaItemPorCliente { get; set; }
        public double valorTotalVendasRecebidas { get; set; }
        public double valorTotalVendasNaoRecebidas { get; set; }
        public double mediaGastoPorCliente { get; set; }
        public double totalDespesasPagas { get; set; }
        public Pedido pedido { get; set; }
        public Pagamento pagamento { get; set; }
        public Despesa despesa { get; set; }
        public Relatorio()
        {
            this.pedido = new Pedido();
            this.pagamento = new Pagamento();
            this.despesa = new Despesa();
        }
    }
}
