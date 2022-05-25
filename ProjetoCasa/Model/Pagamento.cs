using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Model
{
    public class Pagamento
    {
        public int idPagamento { get; set; }
        public int idPedidoPag { get; set; }
        public DateTime dataPagamento { get; set; }
        public string statusPagamentoPedido { get; set; }
        public string tipoPagamento { get; set; }
        public double valorPago { get; set; }
        public string pagamentoAtivo { get; set; }
        public Pedido pedido { get; set; }

        public Pagamento()
        {
            this.pedido = new Pedido();
        }
    }
}
