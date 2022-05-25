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
    class DespesaDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Despesa InserirDespesa(DateTime datas, string despesa, double valorDespesa, string formaPagamento, string responsavelCartao, DateTime dataCartao, string statusPagamento, string despesaAtiva)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Despesa(datas, despesa, valorDespesa, formaPagamento, responsavelCartao, dataCartao, statusPagamento, despesaAtiva)" +
                              " VALUES (@datas, @despesa, @valorDespesa, @formaPagamento, @responsavelCartao, @dataCartao, @statusPagamento, @despesaAtiva)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@datas", datas));
            comando.Parameters.Add(new SqlParameter("@despesa", despesa));
            comando.Parameters.Add(new SqlParameter("@valorDespesa", valorDespesa));
            comando.Parameters.Add(new SqlParameter("@formaPagamento", formaPagamento));
            comando.Parameters.Add(new SqlParameter("@responsavelCartao", responsavelCartao));
            comando.Parameters.Add(new SqlParameter("@dataCartao", dataCartao));
            comando.Parameters.Add(new SqlParameter("@statusPagamento", statusPagamento));
            comando.Parameters.Add(new SqlParameter("@despesaAtiva", despesaAtiva));

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

        internal List<Despesa> ConsultarDespesaPorId(int idDespesa)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa WHERE idDespesa = " + idDespesa;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["idDespesa"].ToString());
                despesa.datas = Convert.ToDateTime(dr["datas"].ToString());
                despesa.despesa = dr["despesa"].ToString();
                despesa.valorDespesa = Convert.ToDouble(dr["valorDespesa"].ToString());
                despesa.formaPagamento = dr["formaPagamento"].ToString();
                despesa.responsavelCartao = dr["responsavelCartao"].ToString();
                despesa.dataCartao = Convert.ToDateTime(dr["dataCartao"].ToString());
                despesa.statusPagamento = dr["statusPagamento"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarTodaDespesa()
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["idDespesa"].ToString());
                despesa.datas = Convert.ToDateTime(dr["datas"].ToString());
                despesa.despesa = dr["despesa"].ToString();
                despesa.valorDespesa = Convert.ToDouble(dr["valorDespesa"].ToString());
                despesa.formaPagamento = dr["formaPagamento"].ToString();
                despesa.responsavelCartao = dr["responsavelCartao"].ToString();
                despesa.dataCartao = Convert.ToDateTime(dr["dataCartao"].ToString());
                despesa.statusPagamento = dr["statusPagamento"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }
        
        internal List<Despesa> ConsultarDespesaPorStatusPgtoDesp(string dataCartaoMinima, string dataCartaoMaxima, string statusPgtoDesp)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa" +
                               " WHERE despesaAtiva = 'Sim' AND" +
                               " statusPagamento = '" + statusPgtoDesp + "'" +
                               " AND(CAST(dataCartao AS DATE) >= '" + dataCartaoMinima +
                               "' AND cast(dataCartao AS DATE) <= '" + dataCartaoMaxima + "')" +
                               " ORDER BY dataCartao";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["idDespesa"].ToString());
                despesa.datas = Convert.ToDateTime(dr["datas"].ToString());
                despesa.despesa = dr["despesa"].ToString();
                despesa.valorDespesa = Convert.ToDouble(dr["valorDespesa"].ToString());
                despesa.formaPagamento = dr["formaPagamento"].ToString();
                despesa.responsavelCartao = dr["responsavelCartao"].ToString();
                despesa.dataCartao = Convert.ToDateTime(dr["dataCartao"].ToString());
                despesa.statusPagamento = dr["statusPagamento"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarDespesaPorFormaPgtoDesp(string dataCartaoMinima, string dataCartaoMaxima, string formaPgtoDesp)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa" +
                               " WHERE despesaAtiva = 'Sim' AND" +
                               " formaPagamento like '%" + formaPgtoDesp + "%'" +
                               " AND(CAST(dataCartao AS DATE) >= '" + dataCartaoMinima +
                               "' AND cast(dataCartao AS DATE) <= '" + dataCartaoMaxima + "')" +
                               " ORDER BY dataCartao";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["idDespesa"].ToString());
                despesa.datas = Convert.ToDateTime(dr["datas"].ToString());
                despesa.despesa = dr["despesa"].ToString();
                despesa.valorDespesa = Convert.ToDouble(dr["valorDespesa"].ToString());
                despesa.formaPagamento = dr["formaPagamento"].ToString();
                despesa.responsavelCartao = dr["responsavelCartao"].ToString();
                despesa.dataCartao = Convert.ToDateTime(dr["dataCartao"].ToString());
                despesa.statusPagamento = dr["statusPagamento"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarDespesaPorResponsavelCartao(string dataCartaoMinima, string dataCartaoMaxima, string responsavelCartao)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa" +
                               " WHERE despesaAtiva = 'Sim' AND" +
                               " responsavelCartao like '%" + responsavelCartao + "%'" +
                               " AND(CAST(dataCartao AS DATE) >= '" + dataCartaoMinima +
                               "' AND cast(dataCartao AS DATE) <= '" + dataCartaoMaxima + "')" +
                               " ORDER BY dataCartao";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["idDespesa"].ToString());
                despesa.datas = Convert.ToDateTime(dr["datas"].ToString());
                despesa.despesa = dr["despesa"].ToString();
                despesa.valorDespesa = Convert.ToDouble(dr["valorDespesa"].ToString());
                despesa.formaPagamento = dr["formaPagamento"].ToString();
                despesa.responsavelCartao = dr["responsavelCartao"].ToString();
                despesa.dataCartao = Convert.ToDateTime(dr["dataCartao"].ToString());
                despesa.statusPagamento = dr["statusPagamento"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarDespesaPorDespesa(string dataDespesaMinima, string dataDespesaMaxima, string despesaBuscaDesp)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa" +
                               " WHERE despesaAtiva = 'Sim' AND" +
                               " despesa like '%" + despesaBuscaDesp + "%'" +
                               " AND (CAST(datas AS DATE) >= '" + dataDespesaMinima +
                               "' AND cast(datas AS DATE) <= '" + dataDespesaMaxima + "')" + 
                               " ORDER BY datas";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["idDespesa"].ToString());
                despesa.datas = Convert.ToDateTime(dr["datas"].ToString());
                despesa.despesa = dr["despesa"].ToString();
                despesa.valorDespesa = Convert.ToDouble(dr["valorDespesa"].ToString());
                despesa.formaPagamento = dr["formaPagamento"].ToString();
                despesa.responsavelCartao = dr["responsavelCartao"].ToString();
                despesa.dataCartao = Convert.ToDateTime(dr["dataCartao"].ToString());
                despesa.statusPagamento = dr["statusPagamento"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarDespesaPorDataCartao(string dataCartaoMinima, string dataCartaoMaxima)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa" +
                               " WHERE despesaAtiva = 'Sim' AND" +
                               " CAST(dataCartao AS DATE) >= '" + dataCartaoMinima +
                               "' AND cast(dataCartao AS DATE) <= '" + dataCartaoMaxima + "' ORDER BY dataCartao";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["idDespesa"].ToString());
                despesa.datas = Convert.ToDateTime(dr["datas"].ToString());
                despesa.despesa = dr["despesa"].ToString();
                despesa.valorDespesa = Convert.ToDouble(dr["valorDespesa"].ToString());
                despesa.formaPagamento = dr["formaPagamento"].ToString();
                despesa.responsavelCartao = dr["responsavelCartao"].ToString();
                despesa.dataCartao = Convert.ToDateTime(dr["dataCartao"].ToString());
                despesa.statusPagamento = dr["statusPagamento"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarDespesa(string dataDespesaMinima, string dataDespesaMaxima)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa" +
                               " WHERE despesaAtiva = 'Sim' AND" +
                               " CAST(datas AS DATE) >= '" + dataDespesaMinima +
                               "' AND cast(datas AS DATE) <= '" + dataDespesaMaxima + "' ORDER BY datas";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["idDespesa"].ToString());
                despesa.datas = Convert.ToDateTime(dr["datas"].ToString());
                despesa.despesa = dr["despesa"].ToString();
                despesa.valorDespesa = Convert.ToDouble(dr["valorDespesa"].ToString());
                despesa.formaPagamento = dr["formaPagamento"].ToString();
                despesa.responsavelCartao = dr["responsavelCartao"].ToString();
                despesa.dataCartao = Convert.ToDateTime(dr["dataCartao"].ToString());
                despesa.statusPagamento = dr["statusPagamento"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal Despesa ExcluirDespesa(int idDespesa)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Despesa SET despesaAtiva = 'Não'" +
                               " WHERE idDespesa = " + idDespesa;
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

        internal List<Despesa> EditarDespesa(int idDespesa, DateTime datas, string despesa, double valorDespesa, string formaPagamento, string responsavelCartao, DateTime dataCartao, string statusPagamento)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Despesa SET datas = @datas, despesa = @despesa, valorDespesa = @valorDespesa, formaPagamento = @formaPagamento, responsavelCartao = @responsavelCartao, dataCartao = @dataCartao, statusPagamento = @statusPagamento" +
                               " WHERE idDespesa = " + idDespesa;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@datas", datas));
            cmd.Parameters.Add(new SqlParameter("@despesa", despesa));
            cmd.Parameters.Add(new SqlParameter("@valorDespesa", valorDespesa));
            cmd.Parameters.Add(new SqlParameter("@formaPagamento", formaPagamento));
            cmd.Parameters.Add(new SqlParameter("@responsavelCartao", responsavelCartao));
            cmd.Parameters.Add(new SqlParameter("@dataCartao", dataCartao));
            cmd.Parameters.Add(new SqlParameter("@statusPagamento", statusPagamento));

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
