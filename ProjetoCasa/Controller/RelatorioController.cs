using ProjetoCasa.DAO;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Controller
{
    public class RelatorioController
    {
        public List<Relatorio> GerarFluxoCaixa(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().GerarFluxoCaixa(dataMinima, dataMaxima);
        }

        public List<Relatorio> GerarItensPedido(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().GerarItensPedido(dataMinima, dataMaxima);
        }

        public List<Relatorio> GerarRelatorio(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().GerarRelatorio(dataMinima, dataMaxima);
        }

        public List<Relatorio> ContarPedidos(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().ContarPedidos(dataMinima, dataMaxima);
        }
        public List<Relatorio> ContarItensVendidos(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().ContarItensVendidos(dataMinima, dataMaxima);
        }
        public List<Relatorio> MediaItemCliente(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().MediaItemCliente(dataMinima, dataMaxima);
        }
        public List<Relatorio> ValorTotalVendasRecebidas(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().ValorTotalVendasRecebidas(dataMinima, dataMaxima);
        }
        public List<Relatorio> ValorTotalVendasNaoRecebidas(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().ValorTotalVendasNaoRecebidas(dataMinima, dataMaxima);
        }
        public List<Relatorio> MediaGastoPorCliente(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().MediaGastoPorCliente(dataMinima, dataMaxima);
        }
        public List<Relatorio> QuantidadePedidosCancelados(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().QuantidadePedidosCancelados(dataMinima, dataMaxima);
        }
        public List<Relatorio> TotalDespesasPagas(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().TotalDespesasPagas(dataMinima, dataMaxima);
        }
    }
}
