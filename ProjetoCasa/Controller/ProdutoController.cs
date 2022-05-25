using ProjetoCasa.DAO;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Controller
{
    public class ProdutoController
    {
        public Produto InserirProduto(string descricao, double custo, double valorVendaProd, string respostaAtivo)
        {
            return new ProdutoDB().InserirProduto(descricao, custo, valorVendaProd, respostaAtivo);
        }

        public List<Produto> ConsultarProdutoPorDescricao(string descricao)
        {
            return new ProdutoDB().ConsultarProdutoPorDescricao(descricao);
        }
        public List<Produto> ConsultarProdutoPorId(int idProduto)
        {
            return new ProdutoDB().ConsultarProdutoPorId(idProduto);
        }
        public List<Produto> ConsultarTodoProduto()
        {
            return new ProdutoDB().ConsultarTodoProduto();
        }
        public List<Produto> ConsultarTodoProdutoAtivo()
        {
            return new ProdutoDB().ConsultarTodoProdutoAtivo();
        }

        public Produto ExcluirProduto(int idProduto)
        {
            return new ProdutoDB().ExcluirProduto(idProduto);
        }

        public List<Produto> EditarProduto(int idProduto, string descricao, double custo, double valorVendaProd, string respostaAtivo)
        {
            return new ProdutoDB().EditarProduto(idProduto, descricao, custo, valorVendaProd, respostaAtivo);
        }
    }
}
