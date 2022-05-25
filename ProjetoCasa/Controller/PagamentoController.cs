using ProjetoCasa.DAO;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Controller
{
    public class PagamentoController
    {
        public Pagamento InserirPagamento(int idPedidoPag, DateTime dataPagamento, string tipoPagamento, double valorPago, string statusPagamentoPedido, string pagamentoAtivo)
        {
            return new PagamentoDB().InserirPagamento(idPedidoPag, dataPagamento, tipoPagamento, valorPago, statusPagamentoPedido, pagamentoAtivo);
        }

        public List<Pagamento> ConsultarPagamento(string dataPagamentoMinima, string dataPagamentoMaxima)
        {
            return new PagamentoDB().ConsultarPagamento(dataPagamentoMinima, dataPagamentoMaxima);
        }

        public List<Pagamento> ConsultarPagamentoPorTipoPgto(string dataPagamentoMinima, string dataPagamentoMaxima, string tipoPagamento)
        {
            return new PagamentoDB().ConsultarPagamentoPorTipoPgto(dataPagamentoMinima, dataPagamentoMaxima, tipoPagamento);
        }

        public List<Pagamento> ConsultarPagamentoPorClienteOuCachorro(string nomeClienteOuCachorro)
        {
            return new PagamentoDB().ConsultarPagamentoPorClienteOuCachorro(nomeClienteOuCachorro);
        }

        public List<Pagamento> ConsultarPagamentoPorStatusPgto(string dataPagamentoMinima, string dataPagamentoMaxima, string statusPagamento)
        {
            return new PagamentoDB().ConsultarPagamentoPorStatusPgto(dataPagamentoMinima, dataPagamentoMaxima, statusPagamento);
        }

        public List<Pagamento> ConsultarPagamentoPorNumeroPedido(int numeroPedido)
        {
            return new PagamentoDB().ConsultarPagamentoPorNumeroPedido(numeroPedido);
        }

        public List<Pagamento> ConsultarPagamentoPorId(int idPagamento)
        {
            return new PagamentoDB().ConsultarPagamentoPorId(idPagamento);
        }
        public Pagamento ExcluirPagamento(int idPagamento)
        {
            return new PagamentoDB().ExcluirPagamento(idPagamento);
        }

        public List<Pagamento> EditarPagamento(int idPagamento, int idPedidoPag, DateTime dataPagamento, string tipoPagamento, double valorPago, string statusPagamentoPedido)
        {
            return new PagamentoDB().EditarPagamento(idPagamento, idPedidoPag, dataPagamento, tipoPagamento, valorPago, statusPagamentoPedido);
        }
    }
}
