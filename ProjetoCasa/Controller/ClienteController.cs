using ProjetoCasa.DAO;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Controller
{
    public class ClienteController
    {
        public Cliente InserirCliente(string nomeCliente, string nomeCachorro, string telefoneCliente, string emailCliente, string enderecoCliente, string respostaAtivo)
        {
            return new ClienteDB().InserirCliente(nomeCliente, nomeCachorro, telefoneCliente, emailCliente, enderecoCliente, respostaAtivo);
        }
        
        public List<Cliente> ConsultarClientePorNome(string nomeCliente)
        {
            return new ClienteDB().ConsultarClientePorNome(nomeCliente);
        }

        public List<Cliente> ConsultarClientePorCachorro(string nomeCachorro)
        {
            return new ClienteDB().ConsultarClientePorCachorro(nomeCachorro);
        }
        public List<Cliente> ConsultarClientePorId(int idCliente)
        {
            return new ClienteDB().ConsultarClientePorId(idCliente);
        }
        public List<Cliente> ConsultarTodoCliente()
        {
            return new ClienteDB().ConsultarTodoCliente();
        }
        public List<Cliente> ConsultarTodoClienteAtivo()
        {
            return new ClienteDB().ConsultarTodoClienteAtivo();
        }

        public Cliente ExcluirCliente(int idCliente)
        {
            return new ClienteDB().ExcluirCliente(idCliente);
        }

        public List<Cliente> EditarCliente(int idCliente, string nomeCliente, string nomeCachorro, string telefoneCliente, string emailCliente, string enderecoCliente, string respostaAtivo)
        {
            return new ClienteDB().EditarCliente(idCliente, nomeCliente, nomeCachorro, telefoneCliente, emailCliente, enderecoCliente, respostaAtivo);
        }
    }
}
