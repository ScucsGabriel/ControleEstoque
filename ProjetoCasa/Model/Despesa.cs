using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCasa.Model
{
    public class Despesa
    {
        public int idDespesa { get; set; }
        public DateTime datas { get; set; }
        public string despesa { get; set; }
        public double valorDespesa { get; set; }
        public string formaPagamento { get; set; }
        public DateTime? dataCartao { get; set; }
        public string statusPagamento { get; set; }
        public string responsavelCartao { get; set; }
        public string despesaAtiva { get; set; }
    }
}
