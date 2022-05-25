using ProjetoCasa.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Model
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public int idClientePed { get; set; }
        public int idProdutoPed { get; set; }
        public double custoUnitarioProd { get; set; }
        public double custoTotalProduto { get; set; }
        public double valorVendaUnitarioProd { get; set; }
        public double valorVendaTotalProd { get; set; }
        public double valorVenda { get; set; }
        public string tipoFrete { get; set; }
        public double frete { get; set; }
        public DateTime dataPedido { get; set; }
        public string entrega { get; set; }
        public string pedidoAtivo { get; set; }
        public double lucro { get; set; }
        public double porcentagemLucro { get; set; }
        public Cliente cliente { get; set; }
        public Produto produto { get; set; }
        public List<Produto> listaProdutos { get; set; }
        public Pedido() 
        {
            this.cliente = new Cliente();
            this.produto = new Produto();
        }

        public override string ToString()
        {
            ClienteController cliente = new ClienteController();
            foreach (var item in cliente.ConsultarClientePorId(this.idClientePed))
            {
                this.cliente.nomeCliente = item.nomeCliente;
                this.cliente.nomeCachorro = item.nomeCachorro;
            }
            return this.idPedido.ToString() + " - " + this.cliente.nomeCliente + " - " + this.cliente.nomeCachorro;
        }

        //Propriedades entrarão no módulo Pagamento
        //public string pagamentoRecebido { get; set; }
        //public string formaPagamento { get; set; }
        //public string lucro { get; set; }
        //public string porcentagemLucro { get; set; }
    }
}
