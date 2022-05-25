using ProjetoCasa.View.Relatorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCasa
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Tsb_Despesas_Click(object sender, EventArgs e)
        {
            FormDespesa formDespesa = new FormDespesa();
            formDespesa.ShowDialog();
        }

        private void Tsb_Pedidos_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            formPedido.ShowDialog();
        }

        private void Tsb_Clientes_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void Tsb_Produtos_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
        }

        private void Tsb_Pagamento_Click(object sender, EventArgs e)
        {
            FormPagamento formPagamento = new FormPagamento();
            formPagamento.ShowDialog();
        }

        private void Tsb_Relatorios_Click(object sender, EventArgs e)
        {
            FormRelatorio formRelatorio = new FormRelatorio();
            formRelatorio.ShowDialog();
        }
    }
}
