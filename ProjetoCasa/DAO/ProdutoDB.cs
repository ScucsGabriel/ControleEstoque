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
    class ProdutoDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Produto InserirProduto(string descricao, double custo, double valorVendaProd, string respostaAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Produto(descricao, custo, valorVendaProd, produtoAtivo)" +
                              " VALUES (@descricao, @custo, @valorVendaProd, @respostaAtivo)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@descricao", descricao));
            comando.Parameters.Add(new SqlParameter("@custo", custo));
            comando.Parameters.Add(new SqlParameter("@valorVendaProd", valorVendaProd));
            comando.Parameters.Add(new SqlParameter("@respostaAtivo", respostaAtivo));

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

        internal List<Produto> ConsultarTodoProdutoAtivo()
        {
            List<Produto> lstProduto = new List<Produto>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Produto WHERE produtoAtivo = 'Sim' ORDER BY descricao";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Produto produto = new Produto();
                produto.idProduto = Convert.ToInt32(dr["idProduto"].ToString());
                produto.descricao = dr["descricao"].ToString();
                produto.custo = Convert.ToDouble(dr["custo"].ToString());
                produto.valorVendaProd = Convert.ToDouble(dr["valorVendaProd"].ToString());
                produto.produtoAtivo = dr["produtoAtivo"].ToString();

                lstProduto.Add(produto);
            }
            conn.Close();

            return lstProduto;
        }
        internal List<Produto> ConsultarTodoProduto()
        {
            List<Produto> lstProduto = new List<Produto>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Produto WHERE produtoAtivo = 'Sim' ORDER BY descricao";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Produto produto = new Produto();
                produto.idProduto = Convert.ToInt32(dr["idProduto"].ToString());
                produto.descricao = dr["descricao"].ToString();
                produto.custo = Convert.ToDouble(dr["custo"].ToString());
                produto.valorVendaProd = Convert.ToDouble(dr["valorVendaProd"].ToString());
                produto.produtoAtivo = dr["produtoAtivo"].ToString();

                lstProduto.Add(produto);
            }
            conn.Close();

            return lstProduto;
        }

        internal List<Produto> ConsultarProdutoPorId(int idProduto)
        {
            List<Produto> lstProduto = new List<Produto>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Produto WHERE idProduto = " + idProduto + " AND produtoAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Produto produto = new Produto();
                produto.idProduto = Convert.ToInt32(dr["idProduto"].ToString());
                produto.descricao = dr["descricao"].ToString();
                produto.custo = Convert.ToDouble(dr["custo"].ToString());
                produto.valorVendaProd = Convert.ToDouble(dr["valorVendaProd"].ToString());
                produto.produtoAtivo = dr["produtoAtivo"].ToString();

                lstProduto.Add(produto);
            }
            conn.Close();

            return lstProduto;
        }

        internal List<Produto> ConsultarProdutoPorDescricao(string descricao)
        {
            List<Produto> lstProduto = new List<Produto>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Produto WHERE descricao like '%" + descricao + "%' " +
                               " AND produtoAtivo = 'Sim' ORDER BY descricao";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Produto produto = new Produto();
                produto.idProduto = Convert.ToInt32(dr["idProduto"].ToString());
                produto.descricao = dr["descricao"].ToString();
                produto.custo = Convert.ToDouble(dr["custo"].ToString());
                produto.valorVendaProd = Convert.ToDouble(dr["valorVendaProd"].ToString());
                produto.produtoAtivo = dr["produtoAtivo"].ToString();

                lstProduto.Add(produto);
            }
            conn.Close();

            return lstProduto;
        }
        internal Produto ExcluirProduto(int idProduto)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Produto SET produtoAtivo = 'Não' WHERE idProduto = " + idProduto;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@idProduto", idProduto));

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

        internal List<Produto> EditarProduto(int idProduto, string descricao, double custo, double valorVendaProd, string respostaAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "Update Produto Set descricao = @descricao, custo = @custo, valorVendaProd = @valorVendaProd, produtoAtivo = @respostaAtivo" +
                               " WHERE idProduto = " + idProduto;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@descricao", descricao));
            cmd.Parameters.Add(new SqlParameter("@custo", custo));
            cmd.Parameters.Add(new SqlParameter("@valorVendaProd", valorVendaProd));
            cmd.Parameters.Add(new SqlParameter("@respostaAtivo", respostaAtivo));

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
