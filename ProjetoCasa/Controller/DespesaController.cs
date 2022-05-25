using ProjetoCasa.DAO;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Controller
{
    public class DespesaController
    {
        public Despesa InserirDespesa(DateTime datas, string despesa, double valorDespesa, string formaPagamento, string responsavelCartao, DateTime dataCartao, string statusPagamento, string despesaAtiva)
        {
            return new DespesaDB().InserirDespesa(datas, despesa, valorDespesa, formaPagamento, responsavelCartao, dataCartao, statusPagamento, despesaAtiva);
        }

        public List<Despesa> ConsultarDespesa(string dataDespesaMinima, string dataDespesaMaxima)
        {
            return new DespesaDB().ConsultarDespesa(dataDespesaMinima, dataDespesaMaxima);
        }
        public List<Despesa> ConsultarDespesaPorDataCartao(string dataCartaoMinima, string dataCartaoMaxima)
        {
            return new DespesaDB().ConsultarDespesaPorDataCartao(dataCartaoMinima, dataCartaoMaxima);
        }
        public List<Despesa> ConsultarDespesaPorStatusPgtoDesp(string dataCartaoMinima, string dataCartaoMaxima, string statusPgtoDesp)
        {
            return new DespesaDB().ConsultarDespesaPorStatusPgtoDesp(dataCartaoMinima, dataCartaoMaxima, statusPgtoDesp);
        }

        public List<Despesa> ConsultarDespesaPorFormaPgtoDesp(string dataCartaoMinima, string dataCartaoMaxima, string formaPgtoDesp)
        {
            return new DespesaDB().ConsultarDespesaPorFormaPgtoDesp(dataCartaoMinima, dataCartaoMaxima, formaPgtoDesp);
        }

        public List<Despesa> ConsultarDespesaPorResponsavelCartao(string dataCartaoMinima, string dataCartaoMaxima, string responsavelCartao)
        {
            return new DespesaDB().ConsultarDespesaPorResponsavelCartao(dataCartaoMinima, dataCartaoMaxima, responsavelCartao);
        }

        public List<Despesa> ConsultarDespesaPorDespesa(string dataDespesaMinima, string dataDespesaMaxima, string despesaBuscaDesp)
        {
            return new DespesaDB().ConsultarDespesaPorDespesa(dataDespesaMinima, dataDespesaMaxima, despesaBuscaDesp);
        }

        public List<Despesa> ConsultarDespesaPorId(int idDespesa)
        {
            return new DespesaDB().ConsultarDespesaPorId(idDespesa);
        }

        public List<Despesa> ConsultarTodaDespesa()
        {
            return new DespesaDB().ConsultarTodaDespesa();
        }

        public Despesa ExcluirDespesa(int idDespesa)
        {
            return new DespesaDB().ExcluirDespesa(idDespesa);
        }

        public List<Despesa> EditarDespesa(int idDespesa, DateTime datas, string despesa, double valorDespesa, string formaPagamento, string responsavelCartao, DateTime dataCartao, string statusPagamento)
        {
            return new DespesaDB().EditarDespesa(idDespesa, datas, despesa, valorDespesa, formaPagamento, responsavelCartao, dataCartao, statusPagamento);
        }
    }
}
