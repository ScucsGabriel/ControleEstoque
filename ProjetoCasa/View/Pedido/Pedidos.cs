using ProjetoCasa.Controller;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace ProjetoCasa
{
    public partial class FormPedido : Form
    {
        private double ajusteValorVenda = 0;
        public FormPedido()
        {
            InitializeComponent();            
        }       

        private void Btn_SalvarPedido_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string formatadorFrete = Msk_Frete.Text.Replace(" ", "").Replace("R$", "").Trim();
            double frete;
            if (formatadorFrete == ".")
                frete = 0;
            else
                frete = double.Parse(formatadorFrete, CultureInfo.InvariantCulture);

            string tipoFrete;
            if (Rdb_FreteProprio.Checked)
                tipoFrete = "Próprio";
            else if (Rdb_FreteTerceiro.Checked)
                tipoFrete = "Terceiro";
            else
                tipoFrete = "";

            double conferenciaVenda = 0, conferenciaValorVendaTotal = 0;

            conferenciaValorVendaTotal = double.Parse(Label_CalculaValorVendaPed.Text.Replace(",", ".").Replace("R$", ""), CultureInfo.InvariantCulture);
            for (int item = 0; item < Lst_ListaProdutos.Items.Count; item++)
            {
                conferenciaVenda = conferenciaVenda + double.Parse(Lst_ListaProdutos.Items[item].SubItems[3].Text.Replace("R$", "").Trim());
            }

            conferenciaVenda = conferenciaVenda + frete;

            if (conferenciaVenda < conferenciaValorVendaTotal || conferenciaValorVendaTotal < conferenciaVenda)
            {
                if (MessageBox.Show("O valor da venda está diferente do que a somatória do valor de venda de produtos com o frete!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            string formatadorValorVenda = Label_CalculaValorVendaPed.Text.Replace(" ", "").Replace("R$", "").Replace(",", ".").Trim();            
            double valorVenda = double.Parse(formatadorValorVenda, CultureInfo.InvariantCulture);          
            double valorVendaTotal = 0;
            double custoTotal = 0;
            double lucro = 0;
            double porcentagemLucro = 0;

            Cliente resultadoCliente = (Cliente)Cbo_NomeCliente.SelectedItem;
            List<Produto> resultadoProduto = new List<Produto>();
            int i = 0;
            while (i < Lst_ListaProdutos.Items.Count)
            {
                
                int idProduto = Convert.ToInt32(Lst_ListaProdutos.Items[i].SubItems[0].Text);
                string descricao = Lst_ListaProdutos.Items[i].SubItems[1].Text;
                double custo = Convert.ToDouble(Lst_ListaProdutos.Items[i].SubItems[2].Text.Replace("R$", ""));
                double valorVendaProd = Convert.ToDouble(Lst_ListaProdutos.Items[i].SubItems[3].Text.Replace("R$", ""));

                if (resultadoProduto.Exists(x => x.descricao == descricao))
                {
                    var item = resultadoProduto.Find(x => x.descricao == descricao);
                    item.quantidade = item.quantidade + 1;
                    item.custo = item.custo + custo;
                    item.valorVendaProd = item.valorVendaProd + valorVendaProd;
                    valorVendaTotal = valorVendaTotal + valorVendaProd;
                    lucro = lucro + (valorVendaProd - custo);
                    custoTotal = custoTotal + custo;                    
                }
                else
                {
                    Produto produto = new Produto()
                    {
                        idProduto = idProduto,
                        descricao = descricao,
                        custo = custo,
                        valorVendaProd = valorVendaProd,
                        quantidade = 1

                    };
                    
                    valorVendaTotal = valorVendaTotal + valorVendaProd;
                    lucro = lucro + (valorVendaProd - custo);
                    custoTotal = custoTotal + custo;
                    resultadoProduto.Add(produto);
                }
                i++;
            }

            if (valorVenda  < valorVendaTotal)
                lucro = lucro - (valorVendaTotal - valorVenda);

            if (frete != 0)
                porcentagemLucro = (lucro / (valorVenda - frete)) * 100;
            else
                porcentagemLucro = (lucro / valorVenda) * 100;

            string formatadorLucro = lucro.ToString("F2").Replace(",", ".").Trim();
            string formatadorPorcentagemLucro = porcentagemLucro.ToString("F2").Replace(",", ".").Trim();
            double valorLucro = double.Parse(formatadorLucro, CultureInfo.InvariantCulture);
            double valorPorcentagemLucro = double.Parse(formatadorPorcentagemLucro, CultureInfo.InvariantCulture);

            int resultadoIdCliente = resultadoCliente.idCliente;
            string pedidoAtivo = "Sim";
            PedidoController inserirPedido = new PedidoController();
            inserirPedido.InserirPedido(resultadoIdCliente, Convert.ToDateTime(Date_DataPedido.Value), valorVenda, tipoFrete, frete, Txt_Entrega.Text.Trim(), pedidoAtivo, valorLucro, valorPorcentagemLucro);
            inserirPedido.InserirItensPedido(Convert.ToInt32(Label_GeraNumPed.Text), resultadoProduto);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            LimparFormLista();
            PreencherColumnHeader();
        }

        private void Limpar()
        {
            Label_GeraNumPed.Text = Convert.ToString(Convert.ToInt32(Label_GeraNumPed.Text) + 1);
            Cbo_NomeCliente.Items.Clear();
            Cbo_Descricao.Items.Clear();
            PreencherCombobox();
            Cbo_NomeCliente.Text = "[Pesquisar]";
            Cbo_Descricao.Text = "[Selecione]";
            Label_CalculaTotalProdutos.Text = "R$0,00";
            Date_DataPedido.Value = DateTime.Now;
            Label_CalculaValorVendaPed.Text = "R$0,00";
            Chk_Frete.Checked = false;
            Rdb_FreteProprio.Checked = false;
            Rdb_FreteTerceiro.Checked = false;
            Rdb_FreteProprio.Enabled = false;
            Rdb_FreteTerceiro.Enabled = false;
            Msk_Frete.Text = "";
            Msk_Frete.Enabled = false;
            Txt_Entrega.Text = "";
        }

        private void Btn_ListarPedido_Click(object sender, EventArgs e)
        {
            FormListarPedido formListarPedido = new FormListarPedido();
            formListarPedido.ShowDialog();
            this.Close();
        }
        private bool ValidarPreenchimento()
        {
            if (Cbo_NomeCliente.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Necessário pesquisar e selecionar o cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Lst_ListaProdutos.Items.Count < 1)
            {
                MessageBox.Show("Necessário selecionar pelo menos um produto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Label_CalculaValorVendaPed.Text == "R$0,00")
            {
                MessageBox.Show("Valor da venda está zerado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((Rdb_FreteProprio.Checked == false && Rdb_FreteTerceiro.Checked == false) && Chk_Frete.Checked == true)
            {
                MessageBox.Show("Selecione o tipo do frete.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Msk_Frete.Text == "R$    ." && Chk_Frete.Checked == true)
            {
                MessageBox.Show("Valor do frete está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Entrega.Text == "")
            {
                MessageBox.Show("Entrega está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Entrega.Text.Length > 100)
            {
                MessageBox.Show("Entrega está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void PreencherCombobox()
        {
            ProdutoController descricao = new ProdutoController();
            foreach (var item in descricao.ConsultarTodoProdutoAtivo())
            {
                Cbo_Descricao.Items.Add(item);
            }
        }
        private void FormPedido_Load(object sender, EventArgs e)
        {            
            Cbo_NomeCliente.Items.Clear();
            Cbo_Descricao.Items.Clear();
            PreencherColumnHeader();
            Lst_ListaProdutos.View = System.Windows.Forms.View.Details;
            PreencherCombobox();

            PedidoController listarPedido = new PedidoController();
            var item = listarPedido.CalcularNumeroPedido();
            if (item.idPedido == 0)
                Label_GeraNumPed.Text = Convert.ToString(1);
            else
                Label_GeraNumPed.Text = Convert.ToString(item.idPedido + 1);

            Label_GeraNumPed.Refresh();
            Lst_ListaProdutos.FullRowSelect = true;           
        }
        private void Cbo_Descricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto resultadoProduto = (Produto)Cbo_Descricao.SelectedItem;
            int idProduto = resultadoProduto.idProduto;
            string descricao = resultadoProduto.descricao;
            double custo = resultadoProduto.custo;
            double valorVendaProd = resultadoProduto.valorVendaProd;
            ListViewItem lstViewItem = new ListViewItem(new[] { idProduto.ToString(), descricao.ToString(), "R$" + custo.ToString(), "R$" + valorVendaProd.ToString() });
            Lst_ListaProdutos.Items.Add(lstViewItem);
            Label_CalculaTotalProdutos.Text = "R$" + (double.Parse(Label_CalculaTotalProdutos.Text.Replace("R$", "").Replace(",", ".")) + valorVendaProd).ToString();
            Label_CalculaValorVendaPed.Text = "R$" + (double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", ".")) + valorVendaProd).ToString();
        }
        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Produto";
            columnHeader3.Text = "Custo";
            columnHeader4.Text = "Valor de Venda";

            Lst_ListaProdutos.Columns.Add(columnHeader1);
            Lst_ListaProdutos.Columns.Add(columnHeader2);
            Lst_ListaProdutos.Columns.Add(columnHeader3);
            Lst_ListaProdutos.Columns.Add(columnHeader4);

            Lst_ListaProdutos.GridLines = true;            
        }
        private void LimparFormLista()
        {
            Lst_ListaProdutos.Columns.Clear();
            Lst_ListaProdutos.Items.Clear();
        }
        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            for (int i = Lst_ListaProdutos.SelectedItems.Count - 1; i >= 0; i--)
            {
                Label_CalculaTotalProdutos.Text = "R$" + (double.Parse(Label_CalculaTotalProdutos.Text.Replace("R$", "").Replace(",", "."))
                        - double.Parse(Lst_ListaProdutos.SelectedItems[i].SubItems[3].Text.Replace("R$", ""))).ToString();
                Label_CalculaValorVendaPed.Text = "R$" + (double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."))
                        - double.Parse(Lst_ListaProdutos.SelectedItems[i].SubItems[3].Text.Replace("R$", ""))).ToString();
                ListViewItem lstRemove = Lst_ListaProdutos.SelectedItems[i];
                Lst_ListaProdutos.Items.Remove(lstRemove);                
            }
        }
        private void Lst_ListaProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && Lst_ListaProdutos.SelectedItems.Count > 0)
            {
                for (int i = Lst_ListaProdutos.SelectedItems.Count - 1; i >= 0; i--)
                {
                    Label_CalculaTotalProdutos.Text = "R$" + (double.Parse(Label_CalculaTotalProdutos.Text.Replace("R$", "").Replace(",", "."))
                        - double.Parse(Lst_ListaProdutos.SelectedItems[i].SubItems[3].Text.Replace("R$", ""))).ToString();
                    Label_CalculaValorVendaPed.Text = "R$" + (double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."))
                        - double.Parse(Lst_ListaProdutos.SelectedItems[i].SubItems[3].Text.Replace("R$", ""))).ToString();
                    ListViewItem lstRemove = Lst_ListaProdutos.SelectedItems[i];
                    Lst_ListaProdutos.Items.Remove(lstRemove);                    
                }
            }
        }
        private void Cbo_NomeCliente_DropDown(object sender, EventArgs e)
        {
            if (!Cbo_NomeCliente.Text.Equals("[Pesquisar]") && !Cbo_NomeCliente.Text.Equals(""))
            {
                Cbo_NomeCliente.Items.Clear();
                ClienteController listarCliente = new ClienteController();
                foreach (var item in listarCliente.ConsultarClientePorNome(Cbo_NomeCliente.Text))
                {
                    Cbo_NomeCliente.Items.Add(item);
                }
            }
        }
        private void Cbo_Descricao_DropDown(object sender, EventArgs e)
        {
            if (!Cbo_Descricao.Text.Equals("[Selecione]") || Cbo_Descricao.Text.Equals(""))
            {
                Cbo_Descricao.Items.Clear();
                ProdutoController listarProduto = new ProdutoController();
                foreach (var item in listarProduto.ConsultarProdutoPorDescricao(Cbo_Descricao.Text))
                {
                    Cbo_Descricao.Items.Add(item);
                }
            }
        }
        private void Chk_Frete_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Frete.Checked == true)
            {
                Rdb_FreteProprio.Enabled = true;
                Rdb_FreteTerceiro.Enabled = true;
                Msk_Frete.Enabled = true;
            }
            else
            {
                Rdb_FreteProprio.Checked = false;
                Rdb_FreteTerceiro.Checked = false;
                Rdb_FreteProprio.Enabled = false;
                Rdb_FreteTerceiro.Enabled = false;
                Msk_Frete.Enabled = false;
                Msk_Frete.Text = "";
                Label_CalculaValorVendaPed.Text = "R$" + ((double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture)) -
                   ajusteValorVenda).ToString();
                ajusteValorVenda = 0;
                if (Label_CalculaTotalProdutos.Text == "R$0,00")
                    Label_CalculaValorVendaPed.Text = "R$0,00";
            }
        }

        private void Msk_Frete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_Frete.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_Frete.SelectionStart = resultado;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (Msk_Frete.Text.Replace("R$", "").Replace(" ", "").Replace(",", ".").Trim() != ".")
                {
                    Label_CalculaValorVendaPed.Text = "R$" + ((double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture)) -
                   ajusteValorVenda).ToString();
                    ajusteValorVenda = double.Parse(Msk_Frete.Text.Replace("R$", "").Replace(" ", "").Replace(",", "."));
                    Label_CalculaValorVendaPed.Text = "R$" + ((double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture)) +
                   ajusteValorVenda).ToString();
                }
                if (Msk_Frete.Text.Replace("R$", "").Replace(" ", "").Replace(",", ".").Trim() == ".")
                {
                    Label_CalculaValorVendaPed.Text = "R$" + ((double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture)) -
                   ajusteValorVenda).ToString();
                    ajusteValorVenda = 0;
                }
            }
        }
    }
}
