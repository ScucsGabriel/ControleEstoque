using ProjetoCasa.DAO;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Controller
{
    public class PedidoController
    {
        public Pedido InserirPedido(int idCli, DateTime dataPedido, double valorVenda, string tipoFrete, double frete, string entrega, string pedidoAtivo, double lucro, double porcentagemLucro)
        {
            return new PedidoDB().InserirPedido(idCli, dataPedido, valorVenda, tipoFrete, frete, entrega, pedidoAtivo, lucro, porcentagemLucro);
        }
        public Pedido InserirItensPedido(int idPedido, List<Produto> resultadoProduto)
        {
            return new PedidoDB().InserirItensPedido(idPedido, resultadoProduto);
        }
        public List<Pedido> ConsultarPedidoPorTipoFrete(string dataPedidoMinima, string dataPedidoMaxima, string tipoFrete)
        {
            return new PedidoDB().ConsultarPedidoPorTipoFrete(dataPedidoMinima, dataPedidoMaxima, tipoFrete);
        }
        public List<Pedido> ConsultarPedidoPorData(string dataPedidoMinima, string dataPedidoMaxima)
        {
            return new PedidoDB().ConsultarPedidoPorData(dataPedidoMinima, dataPedidoMaxima);
        }        
        public List<Pedido> ConsultarPedidoPorNumeroPedido(int numeroPedido)
        {
            return new PedidoDB().ConsultarPedidoPorNumeroPedido(numeroPedido);
        }
        public List<Pedido> ConsultarPedidoPorNomeCliente(string nomeCliente)
        {
            return new PedidoDB().ConsultarPedidoPorNomeCliente(nomeCliente);
        }
        public List<Pedido> ConsultarUltimoPedidoPorCliente(int idClie)
        {
            return new PedidoDB().ConsultarUltimoPedidoPorCliente(idClie);
        }

        public List<Pedido> ConsultarPedidoPorCliente(int idCli)
        {
            return new PedidoDB().ConsultarPedidoPorCliente(idCli);
        }
        public List<Pedido> ConsultarPedidoPorClienteExclusao(int idCli)
        {
            return new PedidoDB().ConsultarPedidoPorClienteExclusao(idCli);
        }
        public List<Pedido> ConsultarPedidoPorProdutoExclusao(int idProd)
        {
            return new PedidoDB().ConsultarPedidoPorProdutoExclusao(idProd);
        }
        public List<Pedido> ConsultarPedidoPorId(int idPedido)
        {
            return new PedidoDB().ConsultarPedidoPorId(idPedido);
        }
        public int ConsultarProdutoItensPedido(int idPedido, int idProduto)
        {
            return new PedidoDB().ConsultarProdutoItensPedido(idPedido, idProduto);
        }
        public List<Pedido> ConsultarItensPedidoPorIdPedido(int idPedido)
        {
            return new PedidoDB().ConsultarItensPedidoPorIdPedido(idPedido);
        }        
        public List<Pedido> ConsultarItensPedidoPorIdPedidoLista(int idPedido)
        {
            return new PedidoDB().ConsultarItensPedidoPorIdPedidoLista(idPedido);
        }

        public List<Pedido> ConsultarTodoPedidoAtivo()
        {
            return new PedidoDB().ConsultarTodoPedidoAtivo();
        }

        public Pedido CalcularNumeroPedido()
        {
            return new PedidoDB().CalcularNumeroPedido();
        }

        public Pedido ExcluirPedido(int idPedido)
        {
            return new PedidoDB().ExcluirPedido(idPedido);
        }
        public Pedido ExcluirItemPedido(int idPedidoExcluir, int idProduto)
        {
            return new PedidoDB().ExcluirItemPedido(idPedidoExcluir, idProduto);
        }       

        public List<Pedido> EditarPedido(int idPedido, int idCli, DateTime dataPedido, double valorVenda, string tipoFrete, double frete, string entrega, double lucro, double porcentagemLucro)
        {
            return new PedidoDB().EditarPedido(idPedido, idCli, dataPedido, valorVenda, tipoFrete, frete, entrega, lucro, porcentagemLucro);
        }
        public List<Pedido> EditarItensPedido(int idPedido, List<Produto> resultadoProduto)
        {
            return new PedidoDB().EditarItensPedido(idPedido, resultadoProduto);
        }
    }
}
