using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCasa.DAO
{
    class PedidoDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Pedido InserirPedido(int idCli, DateTime dataPedido, double valorVenda, string tipoFrete, double frete, string entrega, string pedidoAtivo, double lucro, double porcentagemLucro)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Pedido(idCli, dataPedido, valorVenda, tipoFrete, frete, entrega, pedidoAtivo, lucro, porcentagemLucro)" +
                              " VALUES (@idCli, @dataPedido, @valorVenda, @tipoFrete, @frete, @entrega, @pedidoAtivo, @lucro, @porcentagemLucro)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@idCli", idCli));
            comando.Parameters.Add(new SqlParameter("@dataPedido", dataPedido));
            comando.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
            comando.Parameters.Add(new SqlParameter("@tipoFrete", tipoFrete));
            comando.Parameters.Add(new SqlParameter("@frete", frete));
            comando.Parameters.Add(new SqlParameter("@entrega", entrega));
            comando.Parameters.Add(new SqlParameter("@pedidoAtivo", pedidoAtivo));
            comando.Parameters.Add(new SqlParameter("@lucro", lucro));
            comando.Parameters.Add(new SqlParameter("@porcentagemLucro", porcentagemLucro));

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

        internal Pedido InserirItensPedido(int idPedido, List<Produto> resultadoProduto)
        {
            foreach (var item in resultadoProduto)
            {
                    SqlConnection conn = new SqlConnection(conecta);
                    string sqlQuery = "INSERT INTO ItensPedido(idPed, idProdPed, quantidade, custoTotal, valorVendaProdTotal, custoProdUnitario, valorVendaProdUnitario)" +
                                      " VALUES (@idPed, @idProdPed, @quantidade, @custoTotal, @valorVendaProdTotal, @custoProdUnitario, @valorVendaProdUnitario)";
                    SqlCommand comando = new SqlCommand(sqlQuery, conn);
                    comando.Parameters.Add(new SqlParameter("@idPed", idPedido));
                    comando.Parameters.Add(new SqlParameter("@idProdPed", item.idProduto));
                    comando.Parameters.Add(new SqlParameter("@quantidade", item.quantidade));
                    comando.Parameters.Add(new SqlParameter("@custoTotal", item.custo));
                    comando.Parameters.Add(new SqlParameter("@valorVendaProdTotal", item.valorVendaProd));
                    comando.Parameters.Add(new SqlParameter("@custoProdUnitario", item.custo / item.quantidade));
                    comando.Parameters.Add(new SqlParameter("@valorVendaProdUnitario", item.valorVendaProd / item.quantidade));

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
            }            

            return null;
        }

        internal Pedido CalcularNumeroPedido()
        {
            Pedido pedido = new Pedido();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT MAX(idPedido) AS idPedido FROM Pedido";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var retornoBD = dr["idPedido"].ToString() ?? "0";
                if (retornoBD == "")
                    pedido.idPedido = 0;
                else
                    pedido.idPedido = Convert.ToInt32(retornoBD);
            }
            conn.Close();

            return pedido;
        }
        internal List<Pedido> ConsultarTodoPedidoAtivo()
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Pedido WHERE pedidoAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(dr["idPedido"].ToString());
                pedido.idClientePed = Convert.ToInt32(dr["idCli"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal int ConsultarProdutoItensPedidoPorValorVendaProd(int idPedido, int idProduto, double valorVendaProd)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT COUNT(1) FROM ItensPedido" +
                               " WHERE idPed = " + idPedido +
                               " AND idProdPed = " + idProduto +
                               " AND valorVendaProdUnitario = " + valorVendaProd;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            int resultado = Convert.ToInt32(dr[0].ToString());
            conn.Close();

            return resultado;
        }

        internal int ConsultarProdutoItensPedidoPorCusto(int idPedido, int idProduto, double custo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT COUNT(1) FROM ItensPedido" +
                               " WHERE idPed = " + idPedido +
                               " AND idProdPed = " + idProduto + 
                               " AND custoProdUnitario = " + custo;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            int resultado = Convert.ToInt32(dr[0].ToString());
            conn.Close();

            return resultado;
        }

        internal int ConsultarProdutoItensPedido(int idPedido, int idProduto)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT COUNT(1) FROM ItensPedido" +
                               " WHERE idPed = " + idPedido + 
                               " AND idProdPed = " + idProduto;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            int resultado = Convert.ToInt32(dr[0].ToString());
            conn.Close();

            return resultado;
        }        
        internal List<Pedido> ConsultarItensPedidoPorIdPedido(int idPedido)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT i.idPed, i.idProdPed, d.descricao, p.idCli, c.nomeCliente, c.nomeCachorro, i.quantidade, i.custoTotal, i.valorVendaProdTotal, i.custoProdUnitario, i.valorVendaProdUnitario" +
                               " FROM ItensPedido AS i" +
                               " INNER JOIN Pedido AS p ON p.idPedido = i.idPed" +
                               " INNER JOIN Produto AS d ON d.idProduto = i.idProdPed" +
                               " INNER JOIN Cliente AS c ON c.idCliente = p.idCli" +
                               " WHERE i.idPed = " + idPedido;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                Produto produto = new Produto();
                Cliente cliente = new Cliente();
                pedido.idPedido = Convert.ToInt32(dr["idPed"].ToString());
                pedido.idProdutoPed = Convert.ToInt32(dr["idProdPed"].ToString());
                produto.descricao = dr["descricao"].ToString();
                pedido.produto.descricao = produto.descricao;
                pedido.idClientePed = Convert.ToInt32(dr["idCli"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                pedido.cliente.nomeCliente = cliente.nomeCliente;
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pedido.cliente.nomeCachorro = cliente.nomeCachorro;
                produto.quantidade = Convert.ToInt32(dr["quantidade"].ToString());
                pedido.produto.quantidade = produto.quantidade;
                pedido.custoTotalProduto = Convert.ToDouble(dr["custoTotal"].ToString());
                pedido.valorVendaTotalProd = Convert.ToDouble(dr["valorVendaProdTotal"].ToString());
                pedido.custoUnitarioProd = Convert.ToDouble(dr["custoProdUnitario"].ToString());
                pedido.valorVendaUnitarioProd = Convert.ToDouble(dr["valorVendaProdUnitario"].ToString());

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }
        internal List<Pedido> ConsultarItensPedidoPorIdPedidoLista(int idPedido)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPed, d.descricao, p.quantidade, p.custoProdUnitario, p.custoTotal, p.valorVendaProdUnitario, p.valorVendaProdTotal" +
                               " FROM ItensPedido AS p" +
                               " INNER JOIN Produto AS d ON d.idProduto = p.idProdPed" +
                               " WHERE idPed = " + idPedido;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                Produto produto = new Produto();
                pedido.idPedido = Convert.ToInt32(dr["idPed"].ToString());
                produto.descricao = dr["descricao"].ToString();
                pedido.produto.descricao = produto.descricao;
                produto.quantidade = Convert.ToInt32(dr["quantidade"].ToString());
                pedido.produto.quantidade = produto.quantidade;
                pedido.custoUnitarioProd = Convert.ToDouble(dr["custoProdUnitario"].ToString());
                pedido.custoTotalProduto = Convert.ToDouble(dr["custoTotal"].ToString());
                pedido.valorVendaUnitarioProd = Convert.ToDouble(dr["valorVendaProdUnitario"].ToString());
                pedido.valorVendaTotalProd = Convert.ToDouble(dr["valorVendaProdTotal"].ToString());

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal List<Pedido> ConsultarPedidoPorId(int idPedido)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT i.idPed, i.idProdPed, d.descricao, p.idCli, c.nomeCliente, c.nomeCachorro, i.quantidade, i.custoTotal, i.custoProdUnitario, i.valorVendaProdUnitario," +
                               " i.valorVendaProdTotal, d.custo, d.valorVendaProd, p.valorVenda, p.tipoFrete, p.frete, p.dataPedido, p.entrega, p.lucro, p.porcentagemLucro" +
                               " FROM ItensPedido AS i" +
                               " INNER JOIN Pedido AS p ON p.idPedido = i.idPed" +
                               " INNER JOIN Produto AS d ON d.idProduto = i.idProdPed" +
                               " INNER JOIN Cliente AS c ON c.idCliente = p.idCli" +
                               " WHERE i.idPed = " + idPedido;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                Produto produto = new Produto();
                Cliente cliente = new Cliente();
                pedido.idPedido = Convert.ToInt32(dr["idPed"].ToString());
                pedido.idProdutoPed = Convert.ToInt32(dr["idProdPed"].ToString());
                produto.descricao = dr["descricao"].ToString();
                pedido.produto.descricao = produto.descricao;
                pedido.idClientePed = Convert.ToInt32(dr["idCli"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                pedido.cliente.nomeCliente = cliente.nomeCliente;
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pedido.cliente.nomeCachorro = cliente.nomeCachorro;
                produto.quantidade = Convert.ToInt32(dr["quantidade"].ToString());
                pedido.produto.quantidade = produto.quantidade;
                pedido.custoTotalProduto = Convert.ToDouble(dr["custoTotal"].ToString());
                pedido.valorVendaTotalProd = Convert.ToDouble(dr["valorVendaProdTotal"].ToString());
                pedido.custoUnitarioProd = Convert.ToDouble(dr["custoProdUnitario"].ToString());
                pedido.valorVendaUnitarioProd = Convert.ToDouble(dr["valorVendaProdUnitario"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal List<Pedido> ConsultarPedidoPorNumeroPedido(int numeroPedido)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPedido, c.nomeCliente, c.nomeCachorro, p.valorVenda, p.tipoFrete, p.frete, p.dataPedido, p.entrega, p.lucro, p.porcentagemLucro" +
                               " FROM Pedido AS p" +
                               " INNER JOIN Cliente AS c ON c.idCliente = p.idCli" +
                               " WHERE p.idPedido = " + numeroPedido +
                               " AND pedidoAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                pedido.idPedido = Convert.ToInt32(dr["idPedido"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pedido.cliente.nomeCliente = cliente.nomeCliente;
                pedido.cliente.nomeCachorro = cliente.nomeCachorro;

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }
        internal List<Pedido> ConsultarPedidoPorNomeCliente(string nomeCliente)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPedido, c.nomeCliente, c.nomeCachorro, p.valorVenda, p.tipoFrete, p.frete, p.dataPedido, p.entrega, p.lucro, p.porcentagemLucro" +
                               " FROM Pedido AS p" +
                               " INNER JOIN Cliente AS c ON c.idCliente = p.idCli" +
                               " WHERE (c.nomeCliente LIKE '%" + nomeCliente + "%'" +
                               " OR c.nomeCachorro LIKE '%" + nomeCliente + "%')" +
                               " AND p.pedidoAtivo = 'Sim'" +
                               " ORDER BY dataPedido";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                pedido.idPedido = Convert.ToInt32(dr["idPedido"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pedido.cliente.nomeCliente = cliente.nomeCliente;
                pedido.cliente.nomeCachorro = cliente.nomeCachorro;

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal List<Pedido> ConsultarPedidoPorProdutoExclusao(int idProd)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT i.idPed, i.idProdPed, i.quantidade, i.custoTotal, i.valorVendaProdTotal" +
                               " FROM ItensPedido AS i" +
                               " INNER JOIN Pedido AS p ON p.idPedido = i.idPed" +
                               " WHERE p.pedidoAtivo = 'Sim'" +
                               " AND i.idProdPed = " + idProd;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                Produto produto = new Produto();
                pedido.idPedido = Convert.ToInt32(dr["idPed"].ToString());
                pedido.idProdutoPed = Convert.ToInt32(dr["idProdPed"].ToString());
                produto.quantidade = Convert.ToInt32(dr["quantidade"].ToString());
                pedido.produto.quantidade = produto.quantidade;
                pedido.custoTotalProduto = Convert.ToDouble(dr["custoTotal"].ToString());
                produto.valorVendaProd = Convert.ToDouble(dr["valorVendaProdTotal"].ToString());
                pedido.produto.valorVendaProd = produto.valorVendaProd;

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal List<Pedido> ConsultarPedidoPorClienteExclusao(int idCli)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPedido, p.idCli, p.valorVenda, p.tipoFrete, p.frete, p.dataPedido, p.entrega, p.lucro, p.porcentagemLucro" +
                               " FROM Pedido AS P" +
                               " INNER JOIN Cliente AS c ON c.idCliente = p.idCli" +
                               " WHERE p.pedidoAtivo = 'Sim'" +
                               " AND p.idCli = " + idCli;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(dr["idPedido"].ToString());
                pedido.idClientePed = Convert.ToInt32(dr["idCli"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }
        internal List<Pedido> ConsultarUltimoPedidoPorCliente(int idClie)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT TOP(1)* FROM Pedido" +
                               " WHERE pedidoAtivo = 'Sim'" +
                               " AND idCli = " + idClie +
                               " ORDER BY dataPedido DESC";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(dr["idPedido"].ToString());
                pedido.idClientePed = Convert.ToInt32(dr["idCli"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal List<Pedido> ConsultarPedidoPorCliente(int idCli)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Pedido" +
                               " WHERE pedidoAtivo = 'Sim'" +
                               " AND idCli like '%" + idCli +
                               "%' ORDER BY dataPedido";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(dr["idPedido"].ToString());
                pedido.idClientePed = Convert.ToInt32(dr["idCli"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal List<Pedido> ConsultarPedidoPorTipoFrete(string dataPedidoMinima, string dataPedidoMaxima, string tipoFrete)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPedido, c.nomeCliente, c.nomeCachorro, p.valorVenda, p.tipoFrete, p.frete, p.dataPedido, p.entrega, p.lucro, p.porcentagemLucro" +
                               " FROM Pedido AS p" +
                               " INNER JOIN Cliente AS c ON c.idCliente = p.idCli" +
                               " WHERE tipoFrete = '"+ tipoFrete + "'" + 
                               " AND (cast(dataPedido AS DATE) >= '" + dataPedidoMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataPedidoMaxima + "')" + 
                               " ORDER BY dataPedido";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(dr["idPedido"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());

                Cliente cliente = new Cliente();
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pedido.cliente.nomeCliente = cliente.nomeCliente;
                pedido.cliente.nomeCachorro = cliente.nomeCachorro;

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal List<Pedido> ConsultarPedidoPorData(string dataPedidoMinima, string dataPedidoMaxima)
        {
            List<Pedido> lstPedido = new List<Pedido>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT p.idPedido, c.nomeCliente, c.nomeCachorro, p.valorVenda, p.tipoFrete, p.frete, p.dataPedido, p.entrega, p.lucro, p.porcentagemLucro" +
                               " FROM Pedido AS p" +
                               " INNER JOIN Cliente AS c ON c.idCliente = p.idCli" +
                               " WHERE (cast(dataPedido AS DATE) >= '" + dataPedidoMinima +
                               "' AND cast(dataPedido AS DATE) <= '" + dataPedidoMaxima +
                               "') AND pedidoAtivo = 'Sim'" + 
                               " ORDER BY dataPedido";          
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pedido pedido = new Pedido();
                pedido.idPedido = Convert.ToInt32(dr["idPedido"].ToString());
                pedido.valorVenda = Convert.ToDouble(dr["valorVenda"].ToString());
                pedido.tipoFrete = dr["tipoFrete"].ToString();
                pedido.frete = Convert.ToDouble(dr["frete"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                pedido.entrega = dr["entrega"].ToString();
                pedido.lucro = Convert.ToDouble(dr["lucro"].ToString());
                pedido.porcentagemLucro = Convert.ToDouble(dr["porcentagemLucro"].ToString());

                Cliente cliente = new Cliente();
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                pedido.cliente.nomeCliente = cliente.nomeCliente;
                pedido.cliente.nomeCachorro = cliente.nomeCachorro;

                lstPedido.Add(pedido);
            }
            conn.Close();

            return lstPedido;
        }

        internal Pedido ExcluirPedido(int idPedido)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Pedido SET pedidoAtivo = 'Não'" +
                               " WHERE idPedido = " + idPedido;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@idPedido", idPedido));

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

        internal Pedido ExcluirItemPedido(int idPedidoExcluir, int idProduto)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "DELETE  TOP(1) FROM ItensPedido" +
                               " WHERE idPed = " + idPedidoExcluir + 
                               " AND idProdPed = " + idProduto;
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

        internal List<Pedido> EditarItensPedido(int idPedido, List<Produto> resultadoProduto)
        {
            foreach (var item in resultadoProduto)
            {
                    SqlConnection conn = new SqlConnection(conecta);
                string sqlQuery = "UPDATE ItensPedido SET quantidade = @quantidade, custoTotal = @custoTotal, valorVendaProdTotal = @valorVendaProdTotal, custoProdUnitario = @custoProdUnitario, valorVendaProdUnitario = @valorVendaProdUnitario" +
                                  " WHERE idPed = " + idPedido +
                                  " AND idProdPed = " + item.idProduto;
                    SqlCommand comando = new SqlCommand(sqlQuery, conn);
                    comando.Parameters.Add(new SqlParameter("@quantidade", item.quantidade));
                    comando.Parameters.Add(new SqlParameter("@custoTotal", item.custo));
                    comando.Parameters.Add(new SqlParameter("@valorVendaProdTotal", item.valorVendaProd));
                    comando.Parameters.Add(new SqlParameter("@custoProdUnitario", item.custo / item.quantidade));
                    comando.Parameters.Add(new SqlParameter("@valorVendaProdUnitario", item.valorVendaProd / item.quantidade));

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
            }

            return null;
        }

        internal List<Pedido> EditarPedido(int idPedido, int idCli, DateTime dataPedido, double valorVenda, string tipoFrete, double frete, string entrega, double lucro, double porcentagemLucro)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Pedido SET idCli = @idCli, dataPedido = @dataPedido, valorVenda = @valorVenda, tipoFrete = @tipoFrete, frete = @frete, entrega = @entrega, lucro = @lucro, porcentagemLucro = @porcentagemLucro" +
                               " WHERE idPedido = " + idPedido;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@idCli", idCli));
            cmd.Parameters.Add(new SqlParameter("@dataPedido", dataPedido));
            cmd.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
            cmd.Parameters.Add(new SqlParameter("@tipoFrete", tipoFrete));
            cmd.Parameters.Add(new SqlParameter("@frete", frete));
            cmd.Parameters.Add(new SqlParameter("@entrega", entrega));
            cmd.Parameters.Add(new SqlParameter("@lucro", lucro));
            cmd.Parameters.Add(new SqlParameter("@porcentagemLucro", porcentagemLucro));

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
