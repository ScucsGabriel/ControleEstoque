using ProjetoCasa.Controller;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCasa
{
    public partial class FormEditarProduto : Form
    {
        private double custo;
        private double valorVendaProd;
        public FormEditarProduto(List<Produto> listaProduto)
        { 
            InitializeComponent();
            foreach (var item in listaProduto)
            {
                Label_CodigoProduto.Text = item.idProduto.ToString();
                Txt_DescricaoEdit.Text = item.descricao.ToString();
                custo = item.custo;
                Msk_CustoProdutoEdit.Text = item.custo.ToString();
                while (double.Parse(Msk_CustoProdutoEdit.Text.Replace(" ", "").Replace("R$", ""), CultureInfo.InvariantCulture) != custo)
                {
                    Msk_CustoProdutoEdit.Text = " " + Msk_CustoProdutoEdit.Text;
                }
                valorVendaProd = item.valorVendaProd;
                Msk_ValorVendaEdit.Text = item.valorVendaProd.ToString();
                while (double.Parse(Msk_ValorVendaEdit.Text.Replace(" ", "").Replace("R$", ""), CultureInfo.InvariantCulture) != valorVendaProd)
                {
                    Msk_ValorVendaEdit.Text = " " + Msk_ValorVendaEdit.Text;
                }
            }
        }         

        private void Btn_SalvarEditProduto_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string respostaAtivo = "Sim";
            string formatadorCusto = Msk_CustoProdutoEdit.Text.Replace(" ", "").Replace("R$", "").Trim();
            string formatadorValorVendaProd = Msk_ValorVendaEdit.Text.Replace(" ", "").Replace("R$", "").Trim();
            double custo = double.Parse(formatadorCusto, CultureInfo.InvariantCulture);
            double valorVendaProd = double.Parse(formatadorValorVendaProd, CultureInfo.InvariantCulture);

            ProdutoController editarProduto = new ProdutoController();
            editarProduto.EditarProduto(Convert.ToInt32(Label_CodigoProduto.Text), Txt_DescricaoEdit.Text.Trim(),
                custo, valorVendaProd, respostaAtivo);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Limpar()
        {
            Txt_DescricaoEdit.Text = "";
            Msk_CustoProdutoEdit.Text = "";
            Msk_ValorVendaEdit.Text = "";
        }

        private void Btn_ListarEditProduto_Click(object sender, EventArgs e)
        {
            FormListarProduto formListarProduto = new FormListarProduto();
            formListarProduto.Show();
            this.Close();
        }
        private bool ValidarPreenchimento()
        {
            if (Txt_DescricaoEdit.Text == "")
            {
                MessageBox.Show("Descrição está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_DescricaoEdit.Text.Length > 120)
            {
                MessageBox.Show("Descrição está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Msk_CustoProdutoEdit.Text == "R$   .")
            {
                MessageBox.Show("Custo está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Msk_ValorVendaEdit.Text == "R$   .")
            {
                MessageBox.Show("Valor da venda está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Msk_CustoProdutoEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_CustoProdutoEdit.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_CustoProdutoEdit.SelectionStart = resultado;
            }
        }

        private void Msk_ValorVendaEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_ValorVendaEdit.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_ValorVendaEdit.SelectionStart = resultado;
            }
        }
    }
}
