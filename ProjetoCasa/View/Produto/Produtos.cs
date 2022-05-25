using ProjetoCasa.Controller;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ProjetoCasa
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }          

        private void Btn_SalvarProduto_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string respostaAtivo = "Sim";
            string formatadorCusto = Msk_CustoProduto.Text.Replace(" ", "").Replace("R$", "").Trim();
            string formatadorValorVendaProd = Msk_ValorVenda.Text.Replace(" ", "").Replace("R$", "").Trim();
            double custo = double.Parse(formatadorCusto, CultureInfo.InvariantCulture);
            double valorVendaProd = double.Parse(formatadorValorVendaProd, CultureInfo.InvariantCulture);

            ProdutoController inserirProduto = new ProdutoController();
            inserirProduto.InserirProduto(Txt_Descricao.Text.Trim(), custo, valorVendaProd, respostaAtivo);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void Limpar()
        {
            Txt_Descricao.Text = "";
            Msk_CustoProduto.Text = "";
            Msk_ValorVenda.Text = "";
        }

        private void Btn_ListarProduto_Click(object sender, EventArgs e)
        {
            FormListarProduto formListarProduto = new FormListarProduto();
            formListarProduto.ShowDialog();
            this.Close();
        }
        private bool ValidarPreenchimento()
        {
            if (Txt_Descricao.Text == "")
            {
                MessageBox.Show("Descrição está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Descricao.Text.Length > 120)
            {
                MessageBox.Show("Descrição está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Msk_CustoProduto.Text == "R$   .")
            {
                MessageBox.Show("Custo está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Msk_ValorVenda.Text == "R$    .")
            {
                MessageBox.Show("Valor da venda está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Msk_CustoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_CustoProduto.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_CustoProduto.SelectionStart = resultado;
            }
        }

        private void Msk_ValorVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_ValorVenda.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_ValorVenda.SelectionStart = resultado;
            }
        }
    }
}
