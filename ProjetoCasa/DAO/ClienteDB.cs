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
    class ClienteDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Cliente InserirCliente(string nomeCliente, string nomeCachorro, string telefoneCliente, string emailCliente, string enderecoCliente, string respostaAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Cliente(nomeCliente, nomeCachorro, telefoneCliente, emailCliente, enderecoCliente, clienteAtivo)" +
                " VALUES (@nomeCliente, @nomeCachorro, @telefoneCliente, @emailCliente, @enderecoCliente, @respostaAtivo)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@nomeCliente", nomeCliente));
            comando.Parameters.Add(new SqlParameter("@nomeCachorro", nomeCachorro));
            comando.Parameters.Add(new SqlParameter("@telefoneCliente", telefoneCliente));
            comando.Parameters.Add(new SqlParameter("@emailCliente", emailCliente));
            comando.Parameters.Add(new SqlParameter("@enderecoCliente", enderecoCliente));
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

        internal List<Cliente> ConsultarTodoClienteAtivo()
        {
            List<Cliente> lstCliente = new List<Cliente>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Cliente WHERE clienteAtivo = 'Sim' ORDER BY nomeCliente";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                cliente.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                cliente.telefoneCliente = dr["telefoneCliente"].ToString();
                cliente.emailCliente = dr["emailCliente"].ToString();
                cliente.enderecoCliente = dr["enderecoCliente"].ToString();
                cliente.clienteAtivo = dr["clienteAtivo"].ToString();

                lstCliente.Add(cliente);
            }
            conn.Close();

            return lstCliente;
        }
        internal List<Cliente> ConsultarTodoCliente()
        {
            List<Cliente> lstCliente = new List<Cliente>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Cliente";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                cliente.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                cliente.telefoneCliente = dr["telefoneCliente"].ToString();
                cliente.emailCliente = dr["emailCliente"].ToString();
                cliente.enderecoCliente = dr["enderecoCliente"].ToString();
                cliente.clienteAtivo = dr["clienteAtivo"].ToString();

                lstCliente.Add(cliente);
            }
            conn.Close();

            return lstCliente;
        }

        internal List<Cliente> ConsultarClientePorId(int idCliente)
        {
            List<Cliente> lstCliente = new List<Cliente>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Cliente WHERE idCliente = " + idCliente + "AND clienteAtivo = 'Sim'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                cliente.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                cliente.telefoneCliente = dr["telefoneCliente"].ToString();
                cliente.emailCliente = dr["emailCliente"].ToString();
                cliente.enderecoCliente = dr["enderecoCliente"].ToString();
                cliente.clienteAtivo = dr["clienteAtivo"].ToString();

                lstCliente.Add(cliente);
            }
            conn.Close();

            return lstCliente;
        }       

        internal List<Cliente> ConsultarClientePorNome(string nomeCliente)
        {
            List<Cliente> lstCliente = new List<Cliente>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Cliente WHERE clienteAtivo = 'Sim'" +
                               " AND (nomeCliente LIKE '%" + nomeCliente + "%'" +
                               " OR nomeCachorro LIKE '%" + nomeCliente + "%')" +
                               " ORDER BY nomeCliente";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                cliente.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                cliente.nomeCliente = dr["nomeCliente"].ToString();
                cliente.nomeCachorro = dr["nomeCachorro"].ToString();
                cliente.telefoneCliente = dr["telefoneCliente"].ToString();
                cliente.emailCliente = dr["emailCliente"].ToString();
                cliente.enderecoCliente = dr["enderecoCliente"].ToString();
                cliente.clienteAtivo = dr["clienteAtivo"].ToString();

                lstCliente.Add(cliente);
            }
            conn.Close();

            return lstCliente;
        }

        internal List<Cliente> ConsultarClientePorCachorro(string nomeCachorro)
        {
            List<Cliente> lstCachorro = new List<Cliente>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Cliente WHERE nomeCachorro like '%" + nomeCachorro + "%' " +
                               " AND clienteAtivo = 'Sim' ORDER BY nomeCachorro";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Cliente cachorro = new Cliente();
                cachorro.idCliente = Convert.ToInt32(dr["idCliente"].ToString());
                cachorro.nomeCliente = dr["nomeCliente"].ToString();
                cachorro.nomeCachorro = dr["nomeCachorro"].ToString();
                cachorro.telefoneCliente = dr["telefoneCliente"].ToString();
                cachorro.emailCliente = dr["emailCliente"].ToString();
                cachorro.enderecoCliente = dr["enderecoCliente"].ToString();
                cachorro.clienteAtivo = dr["clienteAtivo"].ToString();

                lstCachorro.Add(cachorro);
            }
            conn.Close();

            return lstCachorro;
        }

        internal Cliente ExcluirCliente(int idCliente)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Cliente SET clienteAtivo = 'Não'" +
                               " WHERE idCliente = "+ idCliente;
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

        internal List<Cliente> EditarCliente(int idCliente, string nomeCliente, string nomeCachorro, string telefoneCliente, string emailCliente, string enderecoCliente, string respostaAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Cliente SET nomeCliente = @nomeCliente, nomeCachorro = @nomeCachorro, telefoneCliente = @telefoneCliente, emailCliente = @emailCliente, enderecoCliente = @enderecoCliente, clienteAtivo = @respostaAtivo" +
                               " WHERE idCliente = " + idCliente;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@nomeCliente", nomeCliente));
            cmd.Parameters.Add(new SqlParameter("@nomeCachorro", nomeCachorro));
            cmd.Parameters.Add(new SqlParameter("@telefoneCliente", telefoneCliente));
            cmd.Parameters.Add(new SqlParameter("@emailCliente", emailCliente));
            cmd.Parameters.Add(new SqlParameter("@enderecoCliente", enderecoCliente));
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
