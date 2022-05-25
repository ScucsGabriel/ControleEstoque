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
    class PagamentoDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Pagamento InserirPagamento(int idPedidoPag, DateTime dataPagamento, string tipoPagamento, double valorPago, string statusPagamentoPedido, string pagamentoAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Pagamento(idPedidoPag, dataPagamento, tipoPagamento, valorPago, statusPagamentoPedido, pagamentoAtivo)" +
                              " VALUES (@idPedidoPag, @dataPagamento, @tipoPagamento, @valorPago, @statusPagamentoPedido, @pagamentoAtivo)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@idPedidoPag", idPedidoPag));
            comando.Parameters.Add(new SqlParameter("@dataPagamento", dataPagamento));
            comando.Parameters.Add(new SqlParameter("@tipoPagamento", tipoPagamento));
            comando.Parameters.Add(new SqlParameter("@valorPago", valorPago));
            comando.Parameters.Add(new SqlParameter("@statusPagamentoPedido", statusPagamentoPedido));
            comando.Parameters.Add(new SqlParameter("@pagamentoAtivo", pagamentoAtivo));

            try
            {
                conn.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na gravação de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        internal List<Pagamento> ConsultarPagamentoPorClienteOuCachorro(string nomeClienteOuCachorro)
        {
            List<Pagamento> lstPagamento = new List<Pagamento>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPagamento, p.idPedidoPag, c.nomeCliente, c.nomeCachorro, p.dataPagamento, i.valorVenda, p.valorPago, p.statusPagamentoPedido, p.tipoPagamento" +
                               " FROM Pagamento AS p" +
                               " INNER JOIN Pedido AS i ON i.idPedido = p.idPedidoPag" +
                               " INNER JOIN Cliente AS c ON c.idCliente = i.idCli" +
                               " WHERE (c.nomeCliente LIKE '%" + nomeClienteOuCachorro + "%'" + 
                               " OR c.nomeCachorro LIKE '%" + nomeClienteOuCachorro + "%')" + 
                               " AND pagamentoAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pagamento pagamento = new Pagamento();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                pagamento.idPagamento = Convert.ToInt32(dr["idPagamento"].ToString());
                pagamento.idPedidoPag = Convert.ToInt32(dr["idPedidoPag"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                pagamento.pedido.cliente.nomeCliente = cliente.nomeCliente;
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pagamento.pedido.cliente.nomeCachorro = cliente.nomeCachorro;
                pagamento.dataPagamento = Convert.ToDateTime(dr["dataPagamento"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pagamento.pedido.valorVenda = pedido.valorVenda;
                pagamento.valorPago = Convert.ToDouble(dr["valorPago"].ToString());
                pagamento.statusPagamentoPedido = dr["statusPagamentoPedido"].ToString();
                pagamento.tipoPagamento = dr["tipoPagamento"].ToString();

                lstPagamento.Add(pagamento);
            }
            conn.Close();

            return lstPagamento;
        }

        internal List<Pagamento> ConsultarPagamentoPorStatusPgto(string dataPagamentoMinima, string dataPagamentoMaxima, string statusPagamento)
        {
            List<Pagamento> lstPagamento = new List<Pagamento>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPagamento, p.idPedidoPag, c.nomeCliente, c.nomeCachorro, p.dataPagamento, i.valorVenda, p.valorPago, p.statusPagamentoPedido, p.tipoPagamento" +
                               " FROM Pagamento AS p" +
                               " INNER JOIN Pedido AS i ON i.idPedido = p.idPedidoPag" +
                               " INNER JOIN Cliente AS c ON c.idCliente = i.idCli" +
                               " WHERE pagamentoAtivo = 'Sim' AND" +
                               " statusPagamentoPedido = '" + statusPagamento + "'" +
                               " AND (cast(dataPagamento AS DATE) >= '" + dataPagamentoMinima +
                               "' AND cast(dataPagamento AS DATE) <= '" + dataPagamentoMaxima + "')" +
                               " ORDER BY dataPagamento";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pagamento pagamento = new Pagamento();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                pagamento.idPagamento = Convert.ToInt32(dr["idPagamento"].ToString());
                pagamento.idPedidoPag = Convert.ToInt32(dr["idPedidoPag"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                pagamento.pedido.cliente.nomeCliente = cliente.nomeCliente;
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pagamento.pedido.cliente.nomeCachorro = cliente.nomeCachorro;
                pagamento.dataPagamento = Convert.ToDateTime(dr["dataPagamento"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pagamento.pedido.valorVenda = pedido.valorVenda;
                pagamento.valorPago = Convert.ToDouble(dr["valorPago"].ToString());
                pagamento.statusPagamentoPedido = dr["statusPagamentoPedido"].ToString();
                pagamento.tipoPagamento = dr["tipoPagamento"].ToString();

                lstPagamento.Add(pagamento);
            }
            conn.Close();

            return lstPagamento;
        }

        internal List<Pagamento> ConsultarPagamentoPorTipoPgto(string dataPagamentoMinima, string dataPagamentoMaxima, string tipoPagamento)
        {
            List<Pagamento> lstPagamento = new List<Pagamento>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPagamento, p.idPedidoPag, c.nomeCliente, c.nomeCachorro, p.dataPagamento, i.valorVenda, p.valorPago, p.statusPagamentoPedido, p.tipoPagamento" +
                               " FROM Pagamento AS p" +
                               " INNER JOIN Pedido AS i ON i.idPedido = p.idPedidoPag" +
                               " INNER JOIN Cliente AS c ON c.idCliente = i.idCli" +
                               " WHERE pagamentoAtivo = 'Sim' AND" +
                               " tipoPagamento = '" + tipoPagamento + "'" +
                               " AND (cast(dataPagamento AS DATE) >= '" + dataPagamentoMinima +
                               "' AND cast(dataPagamento AS DATE) <= '" + dataPagamentoMaxima + "')" +
                               " ORDER BY dataPagamento";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pagamento pagamento = new Pagamento();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                pagamento.idPagamento = Convert.ToInt32(dr["idPagamento"].ToString());
                pagamento.idPedidoPag = Convert.ToInt32(dr["idPedidoPag"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                pagamento.pedido.cliente.nomeCliente = cliente.nomeCliente;
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pagamento.pedido.cliente.nomeCachorro = cliente.nomeCachorro;
                pagamento.dataPagamento = Convert.ToDateTime(dr["dataPagamento"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pagamento.pedido.valorVenda = pedido.valorVenda;
                pagamento.valorPago = Convert.ToDouble(dr["valorPago"].ToString());
                pagamento.statusPagamentoPedido = dr["statusPagamentoPedido"].ToString();
                pagamento.tipoPagamento = dr["tipoPagamento"].ToString();

                lstPagamento.Add(pagamento);
            }
            conn.Close();

            return lstPagamento;
        }

        internal List<Pagamento> ConsultarPagamento(string dataPagamentoMinima, string dataPagamentoMaxima)
        {
            List<Pagamento> lstPagamento = new List<Pagamento>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPagamento, p.idPedidoPag, c.nomeCliente, c.nomeCachorro, p.dataPagamento, i.valorVenda, p.valorPago, p.statusPagamentoPedido, p.tipoPagamento" +
                               " FROM Pagamento AS p" +
                               " INNER JOIN Pedido AS i ON i.idPedido = p.idPedidoPag" +
                               " INNER JOIN Cliente AS c ON c.idCliente = i.idCli" +
                               " WHERE pagamentoAtivo = 'Sim' AND" +
                               " cast(dataPagamento AS DATE) >= '" + dataPagamentoMinima +
                               "' AND cast(dataPagamento AS DATE) <= '" + dataPagamentoMaxima + "' ORDER BY dataPagamento";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pagamento pagamento = new Pagamento();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                pagamento.idPagamento = Convert.ToInt32(dr["idPagamento"].ToString());
                pagamento.idPedidoPag = Convert.ToInt32(dr["idPedidoPag"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                pagamento.pedido.cliente.nomeCliente = cliente.nomeCliente;
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pagamento.pedido.cliente.nomeCachorro = cliente.nomeCachorro;
                pagamento.dataPagamento = Convert.ToDateTime(dr["dataPagamento"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pagamento.pedido.valorVenda = pedido.valorVenda;
                pagamento.valorPago = Convert.ToDouble(dr["valorPago"].ToString());
                pagamento.statusPagamentoPedido = dr["statusPagamentoPedido"].ToString();
                pagamento.tipoPagamento = dr["tipoPagamento"].ToString();

                lstPagamento.Add(pagamento);
            }
            conn.Close();

            return lstPagamento;
        }

        internal List<Pagamento> ConsultarPagamentoPorNumeroPedido(int numeroPedido)
        {
            List<Pagamento> lstPagamento = new List<Pagamento>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPagamento, p.idPedidoPag, c.nomeCliente, c.nomeCachorro, p.dataPagamento, i.valorVenda, p.valorPago, p.statusPagamentoPedido, p.tipoPagamento" +
                               " FROM Pagamento AS p" +
                               " INNER JOIN Pedido AS i ON i.idPedido = p.idPedidoPag" +
                               " INNER JOIN Cliente AS c ON c.idCliente = i.idCli" +
                               " WHERE pagamentoAtivo = 'Sim' AND" +
                               " idPedidoPag = " + numeroPedido;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pagamento pagamento = new Pagamento();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                pagamento.idPagamento = Convert.ToInt32(dr["idPagamento"].ToString());
                pagamento.idPedidoPag = Convert.ToInt32(dr["idPedidoPag"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                pagamento.pedido.cliente.nomeCliente = cliente.nomeCliente;
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pagamento.pedido.cliente.nomeCachorro = cliente.nomeCachorro;
                pagamento.dataPagamento = Convert.ToDateTime(dr["dataPagamento"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pagamento.pedido.valorVenda = pedido.valorVenda;
                pagamento.valorPago = Convert.ToDouble(dr["valorPago"].ToString());
                pagamento.statusPagamentoPedido = dr["statusPagamentoPedido"].ToString();
                pagamento.tipoPagamento = dr["tipoPagamento"].ToString();

                lstPagamento.Add(pagamento);
            }
            conn.Close();

            return lstPagamento;
        }

        internal List<Pagamento> ConsultarPagamentoPorId(int idPagamento)
        {
            List<Pagamento> lstPagamento = new List<Pagamento>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPagamento, p.idPedidoPag, c.idCliente, c.nomeCliente, c.nomeCachorro, p.dataPagamento," +
                               " p.tipoPagamento, d.valorVenda, p.valorPago, p.statusPagamentoPedido" +
                               " FROM Pagamento AS p" +
                               " INNER JOIN Pedido AS d ON d.idPedido = p.idPedidoPag" +
                               " INNER JOIN Cliente AS c ON c.idCliente = d.idCli" +
                               " WHERE p.idPagamento = " + idPagamento;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pagamento pagamento = new Pagamento();
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                pagamento.idPagamento = Convert.ToInt32(dr["idPagamento"].ToString());
                pagamento.idPedidoPag = Convert.ToInt32(dr["idPedidoPag"].ToString());
                cliente.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                pagamento.pedido.cliente.idCliente = cliente.idCliente;
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                pagamento.pedido.cliente.nomeCliente = cliente.nomeCliente;
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pagamento.pedido.cliente.nomeCachorro = cliente.nomeCachorro;
                pagamento.statusPagamentoPedido = dr["statusPagamentoPedido"].ToString();
                pagamento.tipoPagamento = dr["tipoPagamento"].ToString();
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pagamento.pedido.valorVenda = pedido.valorVenda;
                pagamento.valorPago = Convert.ToDouble(dr["valorPago"].ToString());
                pagamento.dataPagamento = Convert.ToDateTime(dr["dataPagamento"].ToString());

                lstPagamento.Add(pagamento);
            }
            conn.Close();

            return lstPagamento;
        }

        internal Pagamento ExcluirPagamento(int idPagamento)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Pagamento SET pagamentoAtivo = 'Não'" +
                               " WHERE idPagamento = " + idPagamento;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na exclusão: " + e);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        internal List<Pagamento> EditarPagamento(int idPagamento, int idPedidoPag, DateTime dataPagamento, string tipoPagamento, double valorPago, string statusPagamentoPedido)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Pagamento SET idPedidoPag = @idPedidoPag, dataPagamento = @dataPagamento, tipoPagamento = @tipoPagamento, valorPago = @valorPago, statusPagamentoPedido = @statusPagamentoPedido" +
                               " WHERE idPagamento = " + idPagamento;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@idPedidoPag", idPedidoPag));
            cmd.Parameters.Add(new SqlParameter("@dataPagamento", dataPagamento));
            cmd.Parameters.Add(new SqlParameter("@tipoPagamento", tipoPagamento));
            cmd.Parameters.Add(new SqlParameter("@valorPago", valorPago));
            cmd.Parameters.Add(new SqlParameter("@statusPagamentoPedido", statusPagamentoPedido));

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na edição de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
