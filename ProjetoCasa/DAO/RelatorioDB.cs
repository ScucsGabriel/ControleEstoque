using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.DAO
{
    class RelatorioDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal List<Relatorio> GerarFluxoCaixa(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.dataPagamento, ('Pagamento - ' +  c.nomeCliente + ' (' + c.nomeCachorro + ')')" +
                               " AS transacao, p.valorPago FROM Pagamento AS p" +
                               " INNER JOIN Pedido AS i ON i.idPedido = p.idPedidoPag" +
                               " INNER JOIN Cliente AS c ON c.idCliente = i.idCli" +
                               " WHERE pagamentoAtivo = 'Sim'" +
                               " AND (statusPagamentoPedido = 'Pago Totalmente' OR statusPagamentoPedido = 'Adiantamento')" +                               
                               " AND(CAST(dataPagamento AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPagamento AS DATE) <= '" + dataMaxima + "')" +
                               " UNION SELECT datas, ('Despesa - ' + despesa) AS transacao, valorDespesa FROM Despesa" +
                               " WHERE despesaAtiva = 'Sim'" +
                               " AND statusPagamento = 'Pago'" +
                               " AND(CAST(datas AS DATE) >= '" + dataMinima +
                               "' AND cast(datas AS DATE) <= '" + dataMaxima + "')" +
                               " ORDER BY dataPagamento";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                Pagamento pagamento = new Pagamento();
                pagamento.dataPagamento = Convert.ToDateTime(dr["dataPagamento"].ToString());
                relatorio.pagamento.dataPagamento = pagamento.dataPagamento;
                relatorio.transacao = dr["transacao"].ToString();
                pagamento.valorPago = Convert.ToDouble(dr["valorPago"].ToString());
                relatorio.pagamento.valorPago = pagamento.valorPago;

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }

        internal List<Relatorio> ContarPedidos(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT COUNT(idPedido) AS quantidadePedidos FROM Pedido" +
                               " WHERE (CAST(dataPedido AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.quantidadePedido = Convert.ToInt32(dr["quantidadePedidos"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }

        internal List<Relatorio> ContarItensVendidos(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT SUM(quantidade) AS quantidadeItensVendidos FROM ItensPedido AS i" +
                               " INNER JOIN Pedido AS p ON p.idPedido = i.idPed" + 
                               " WHERE (CAST(dataPedido AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.quantidadeItensVendidos = Convert.ToInt32(dr["quantidadeItensVendidos"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }

        internal List<Relatorio> MediaItemCliente(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT CAST((CAST(SUM(quantidade) AS NUMERIC(10,2)) /" +
                               " CAST(COUNT(DISTINCT(idPedido)) AS NUMERIC(10,2))) AS NUMERIC(10,2)) AS mediaItemPorCliente" +
                               " FROM Pedido AS p" +
                               " INNER JOIN Pagamento AS g ON g.idPedidoPag = p.idPedido" +
                               " INNER JOIN ItensPedido AS i ON i.idPed = p.idPedido" + 
                               " WHERE (CAST(dataPedido AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.mediaItemPorCliente = Convert.ToDouble(dr["mediaItemPorCliente"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }

        internal List<Relatorio> ValorTotalVendasRecebidas(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT CAST(SUM(valorPago) AS NUMERIC(10,2)) AS valorTotalVendas" +
                               " FROM Pedido AS p" +
                               " INNER JOIN Pagamento AS g ON g.idPedidoPag = p.idPedido" +
                               " WHERE pedidoAtivo = 'Sim' AND pagamentoAtivo = 'Sim'" +
                               " AND(CAST(dataPedido AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.valorTotalVendasRecebidas = Convert.ToDouble(dr["valorTotalVendas"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }

        internal List<Relatorio> ValorTotalVendasNaoRecebidas(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT (CAST(SUM(valorVenda) AS NUMERIC(10,2)) - CAST(SUM(valorPago)" +
                               " AS NUMERIC(10,2))) AS valorTotalAReceber" +
                               " FROM Pedido AS p" +
                               " INNER JOIN Pagamento AS g ON g.idPedidoPag = p.idPedido" +
                               " WHERE pedidoAtivo = 'Sim' AND pagamentoAtivo = 'Sim'" +
                               " AND(CAST(dataPedido AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.valorTotalVendasNaoRecebidas = Convert.ToDouble(dr["valorTotalAReceber"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }
        internal List<Relatorio> MediaGastoPorCliente(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT CAST((CAST(SUM(valorPago) AS NUMERIC(10,2)) / CAST(COUNT(DISTINCT(idPedido))" +
                               " AS NUMERIC(10,2))) AS NUMERIC(10,2))AS mediaGastoCliente" +
                               " FROM Pedido AS p" +
                               " INNER JOIN Pagamento AS g ON g.idPedidoPag = p.idPedido" +
                               " WHERE pedidoAtivo = 'Sim' AND pagamentoAtivo = 'Sim'" +
                               " AND(CAST(dataPedido AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.mediaGastoPorCliente = Convert.ToDouble(dr["mediaGastoCliente"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }
        internal List<Relatorio> QuantidadePedidosCancelados(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT COUNT(idPedido) AS quantidadePedidosCancelados FROM Pedido" +
                               " WHERE pedidoAtivo = 'Não'" +
                               " AND(CAST(dataPedido AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.quantidadePedidoCancelados = Convert.ToInt32(dr["quantidadePedidosCancelados"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }

        internal List<Relatorio> TotalDespesasPagas(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT (CAST(SUM(valorDespesa) AS NUMERIC(10,2))) AS despesasPagas" +
                               " FROM Despesa WHERE despesaAtiva = 'Sim'" +
                               " AND statusPagamento = 'Pago'" +
                               " AND(CAST(datas AS DATE) >= '" + dataMinima +
                               "' AND cast(datas AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.totalDespesasPagas = Convert.ToDouble(dr["despesasPagas"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }

        internal List<Relatorio> GerarRelatorio(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT d.descricao, i.quantidade FROM ItensPedido AS i" +
                               " INNER JOIN Pedido AS p ON p.idPedido = i.idPed" +
                               " INNER JOIN Produto AS d ON d.idProduto = i.idProdPed" +
                               " WHERE pedidoAtivo = 'Sim'" +
                               " AND(CAST(dataPedido AS DATE) >= '" + dataMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima + "')";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                Pedido pedido = new Pedido();
                Produto produto = new Produto();
                produto.descricao = dr["descricao"].ToString();
                relatorio.pedido.produto.descricao = produto.descricao;
                produto.quantidade = Convert.ToInt32(dr["quantidade"].ToString());
                relatorio.pedido.produto.quantidade = produto.quantidade;

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }

        internal List<Relatorio> GerarItensPedido(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT d.descricao, SUM(CASE WHEN descricao = d.descricao THEN i.quantidade END) AS quantidade" +
                               " FROM ItensPedido AS i" + 
                               " INNER JOIN Pedido AS p ON p.idPedido = i.idPed" + 
                               " INNER JOIN Produto AS d ON d.idProduto = i.idProdPed" + 
                               " WHERE pedidoAtivo = 'Sim'" + 
                               " AND(CAST(dataPedido AS DATE) >= '" + dataMinima + 
                               "' AND cast(dataPedido AS DATE) <= '" + dataMaxima +
                               "') GROUP BY d.descricao, i.quantidade" +
                               " ORDER BY quantidade DESC";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                Pedido pedido = new Pedido();
                Produto produto = new Produto();
                produto.descricao = dr["descricao"].ToString();
                relatorio.pedido.produto.descricao = produto.descricao;
                produto.quantidade = Convert.ToInt32(dr["quantidade"].ToString());
                relatorio.pedido.produto.quantidade = produto.quantidade;

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }
    }
}
