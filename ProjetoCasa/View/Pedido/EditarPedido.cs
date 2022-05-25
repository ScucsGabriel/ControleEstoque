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
    public partial class FormEditarPedido : Form
    {
        private string nomeCliente;
        private ListViewItem listaExcluir = new ListViewItem();
        private int idPedidoExcluir;
        private double valorVenda;
        private double ajusteValorVenda;
        public FormEditarPedido(List<Pedido> listaPedido)
        {               
            InitializeComponent();
            foreach (var item in listaPedido)
            {
                idPedidoExcluir = item.idPedido;
                Label_CodigoPedido.Text = item.idPedido.ToString();
                Cbo_NomeClienteEdit.ValueMember = Convert.ToString(item.idClientePed);
                Cbo_NomeClienteEdit.Text = item.cliente.nomeCliente + " - " + item.cliente.nomeCachorro;
                nomeCliente = Cbo_NomeClienteEdit.Text;
                Cbo_DescricaoEdit.Text = "[Selecione]";
                valorVenda = item.valorVenda;
                ajusteValorVenda = item.frete;
                Label_CalculaValorVendaPedEdit.Text = "R$" + item.valorVenda.ToString();
                if (item.frete != 0)
                {
                    Chk_FreteEdit.Checked = true;
                    Rdb_FreteProprioEdit.Enabled = true;
                    Rdb_FreteTerceiroEdit.Enabled = true;
                    Msk_FreteEdit.Enabled = true;
                    if (item.tipoFrete == "Próprio")
                        Rdb_FreteProprioEdit.Checked = true;
                    else if (item.tipoFrete == "Terceiro")
                        Rdb_FreteTerceiroEdit.Checked = true;
                    Msk_FreteEdit.Text = item.frete.ToString();
                }
                else
                {
                    Chk_FreteEdit.Checked = false;
                    Rdb_FreteProprioEdit.Enabled = false;
                    Rdb_FreteTerceiroEdit.Enabled = false;
                    Rdb_FreteProprioEdit.Checked = false;
                    Rdb_FreteTerceiroEdit.Checked = false;
                    Msk_FreteEdit.Enabled = false;
                }
                Date_DataPedidoEdit.Value = item.dataPedido;                
                Txt_EntregaEdit.Text = item.entrega;
            }
            PreencherListView(listaPedido);
            Lst_ListaProdutosEdit.FullRowSelect = true;
        }

        private void PreencherListView(List<Pedido> listaPedido)
        {
            foreach (var item in listaPedido)
            {
                ListViewItem listViewItem = new ListViewItem(new[]
                {item.idProdutoPed.ToString(), item.produto.descricao.ToString(), "R$" + item.custoUnitarioProd.ToString(),
                    "R$" + item.valorVendaUnitarioProd.ToString()});
                Lst_ListaProdutosEdit.Items.Add(listViewItem);
                if (item.produto.quantidade > 1)
                {
                    for (int i = 1; i < item.produto.quantidade; i++)
                    {
                        var clone = listViewItem.Clone() as ListViewItem;
                        this.Lst_ListaProdutosEdit.Items.Add(clone);
                    }
                }
                Label_CalculaTotalProdutosEdit.Text = "R$" + (double.Parse(Label_CalculaTotalProdutosEdit.Text.Replace("R$", "").Replace(",", ".")) +
                    item.valorVendaUnitarioProd).ToString();
            }
        }
        private void Btn_SalvarEditPedido_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string formatadorFrete = Msk_FreteEdit.Text.Replace(" ", "").Replace("R$", "").Trim();
            double frete;
            if (formatadorFrete == ".")
                frete = 0;
            else
                frete = double.Parse(formatadorFrete, CultureInfo.InvariantCulture);

            string tipoFrete;
            if (Rdb_FreteProprioEdit.Checked)
                tipoFrete = "Próprio";
            else if (Rdb_FreteTerceiroEdit.Checked)
                tipoFrete = "Terceiro";
            else
                tipoFrete = "";

            double conferenciaVenda = 0;
            for (int item = 0; item < Lst_ListaProdutosEdit.Items.Count; item++)
            {
                conferenciaVenda = conferenciaVenda + double.Parse(Lst_ListaProdutosEdit.Items[item].SubItems[3].Text.Replace("R$", "").Trim());
            }

            conferenciaVenda = conferenciaVenda + frete;
            double converenciaVendaDigitada = double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace(",", ".").Replace("R$", ""), CultureInfo.InvariantCulture);

            if (conferenciaVenda < converenciaVendaDigitada ||
                converenciaVendaDigitada < conferenciaVenda)
            {
                if (MessageBox.Show("O valor da venda está diferente do que a somatória do valor de venda de produtos com o frete!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            if (listaExcluir.Text != "")
            {
                foreach (var item in listaExcluir.Text)
                {
                    PedidoController removerItempedido = new PedidoController();
                    removerItempedido.ExcluirItemPedido(idPedidoExcluir, Convert.ToInt32(listaExcluir.Text));
                }                
            }

            string formatadorValorVenda = Label_CalculaValorVendaPedEdit.Text.Replace(" ", "").Replace("R$", "").Replace(",", ".").Trim();           
            double valorVenda = double.Parse(formatadorValorVenda, CultureInfo.InvariantCulture);           
            double valorVendaTotal = 0;
            double custoTotal = 0;
            double lucro = 0;
            double porcentagemLucro = 0;

            Cliente resultadoCliente = (Cliente)Cbo_NomeClienteEdit.SelectedItem;
            List<Produto> resultadoProduto = new List<Produto>();
            int idPedido = Convert.ToInt32(Label_CodigoPedido.Text);
            int i = 0;
            while (i < Lst_ListaProdutosEdit.Items.Count)
            {

                int idProduto = Convert.ToInt32(Lst_ListaProdutosEdit.Items[i].SubItems[0].Text);
                string descricao = Lst_ListaProdutosEdit.Items[i].SubItems[1].Text;
                double custo = Convert.ToDouble(Lst_ListaProdutosEdit.Items[i].SubItems[2].Text.Replace("R$", ""));
                double valorVendaProd = Convert.ToDouble(Lst_ListaProdutosEdit.Items[i].SubItems[3].Text.Replace("R$", ""));

                if (resultadoProduto.Exists(x => x.descricao == descricao))
                {
                    var item = resultadoProduto.Find(x => x.descricao == descricao);
                    item.quantidade = item.quantidade + 1;
                    item.custo = item.custo + custo;
                    item.valorVendaProd = item.valorVendaProd + valorVendaProd;
                    valorVendaTotal = valorVendaTotal + valorVendaProd;
                    lucro = lucro + (valorVendaProd - custo);
                    porcentagemLucro = porcentagemLucro + ((lucro * 100) / custo);
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

            if (valorVenda < valorVendaTotal)
                lucro = lucro - (valorVendaTotal - valorVenda);

            if (frete != 0)
                porcentagemLucro = (lucro / (valorVenda - frete)) * 100;
            else
                porcentagemLucro = (lucro / valorVenda) * 100;

            int idResultado;
            if (resultadoCliente == null)
                idResultado = Convert.ToInt32(Cbo_NomeClienteEdit.DisplayMember);
            else
                idResultado = resultadoCliente.idCliente;
            int resultadoIdCliente = idResultado;

            foreach (var item in resultadoProduto)
            {
                int idProdutoInsert = item.idProduto;
                PedidoController inserirPedido = new PedidoController();
                if (inserirPedido.ConsultarProdutoItensPedido(idPedido, idProdutoInsert) == 0)
                {
                    List<Produto> produtoInserir = new List<Produto>();
                    Produto produtoInsert = new Produto()
                    {
                        idProduto = item.idProduto,
                        descricao = item.descricao,
                        custo = item.custo,
                        valorVendaProd = item.valorVendaProd,
                        quantidade = item.quantidade
                    };
                    produtoInserir.Add(produtoInsert);
                    inserirPedido.InserirItensPedido(idPedido, produtoInserir);
                }
            }

            string formatadorLucro = lucro.ToString("F2").Replace(",", ".").Trim();
            string formatadorPorcentagemLucro = porcentagemLucro.ToString("F2").Replace(",", ".").Trim();
            double valorLucro = double.Parse(formatadorLucro, CultureInfo.InvariantCulture);
            double valorPorcentagemLucro = double.Parse(formatadorPorcentagemLucro, CultureInfo.InvariantCulture);

            PedidoController editarPedido = new PedidoController();
            editarPedido.EditarPedido(idPedido, resultadoIdCliente, Convert.ToDateTime(Date_DataPedidoEdit.Value), valorVenda, tipoFrete, frete, Txt_EntregaEdit.Text.Trim(), valorLucro, valorPorcentagemLucro);
            editarPedido.EditarItensPedido(idPedido, resultadoProduto);
            
            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Limpar()
        {
            Label_CodigoPedido.Text = "0";
            Cbo_NomeClienteEdit.Items.Clear();
            Cbo_DescricaoEdit.Items.Clear();
            PreencherCombobox();
            Cbo_NomeClienteEdit.Text = "[Pesquisar]";
            Cbo_DescricaoEdit.Text = "[Selecione]";
            Label_CalculaTotalProdutosEdit.Text = "R$0,00";
            Date_DataPedidoEdit.Value = DateTime.Now;
            Label_CalculaValorVendaPedEdit.Text = "R$0,00";
            Chk_FreteEdit.Checked = false;
            Rdb_FreteProprioEdit.Checked = false;
            Rdb_FreteTerceiroEdit.Checked = false;
            Rdb_FreteProprioEdit.Enabled = false;
            Rdb_FreteTerceiroEdit.Enabled = false;
            Msk_FreteEdit.Text = "";
            Msk_FreteEdit.Enabled = false;
            Txt_EntregaEdit.Text = "";
        }

        private void Btn_ListarEditPedido_Click(object sender, EventArgs e)
        {
            FormListarPedido formListarPedido = new FormListarPedido();
            formListarPedido.Show();
            this.Close();
        }
        private bool ValidarPreenchimento() 
        {
            if (Cbo_NomeClienteEdit.Text != nomeCliente)
            {
                if (Cbo_NomeClienteEdit.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Necessário pesquisar e selecionar o cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (Lst_ListaProdutosEdit.Items.Count < 1)
            {
                MessageBox.Show("Necessário selecionar pelo menos um produto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Label_CalculaValorVendaPedEdit.Text == "R$0,00")
            {
                MessageBox.Show("Valor da venda está zerado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((Rdb_FreteProprioEdit.Checked == false && Rdb_FreteTerceiroEdit.Checked == false) && Chk_FreteEdit.Checked == true)
            {
                MessageBox.Show("Selecione o tipo do frete.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Msk_FreteEdit.Text == "R$    ." && Chk_FreteEdit.Checked == true)
            {
                MessageBox.Show("Valor do frete está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EntregaEdit.Text == "")
            {
                MessageBox.Show("Entrega está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EntregaEdit.Text.Length > 100)
            {
                MessageBox.Show("Entrega está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void PreencherCombobox() 
        {
            ProdutoController descricao = new ProdutoController();
            foreach (var item in descricao.ConsultarTodoProdutoAtivo())
            {
                Cbo_DescricaoEdit.Items.Add(item);
            }
        }
        private void FormEditarPedido_Load(object sender, EventArgs e)
        {
            Cbo_NomeClienteEdit.Items.Clear();
            Cbo_DescricaoEdit.Items.Clear();
            PreencherCombobox();
            PreencherColumnHeader();
            Lst_ListaProdutosEdit.View = System.Windows.Forms.View.Details;
        }

        private void Cbo_DescricaoEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto resultadoProduto = (Produto)Cbo_DescricaoEdit.SelectedItem;
            int idProduto = resultadoProduto.idProduto;
            string descricao = resultadoProduto.descricao;
            double custo = resultadoProduto.custo;
            double valorVendaProd = resultadoProduto.valorVendaProd;
            ListViewItem lstViewItem = new ListViewItem(new[] { idProduto.ToString(), descricao.ToString(), "R$" + custo.ToString(), "R$" + valorVendaProd.ToString() });
            Lst_ListaProdutosEdit.Items.Add(lstViewItem);
            Label_CalculaTotalProdutosEdit.Text = "R$" + (double.Parse(Label_CalculaTotalProdutosEdit.Text.Replace("R$", "").Replace(",", ".")) + valorVendaProd).ToString();
            Label_CalculaValorVendaPedEdit.Text = "R$" + (double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", ".")) + valorVendaProd).ToString();
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

            Lst_ListaProdutosEdit.Columns.Add(columnHeader1);
            Lst_ListaProdutosEdit.Columns.Add(columnHeader2);
            Lst_ListaProdutosEdit.Columns.Add(columnHeader3);
            Lst_ListaProdutosEdit.Columns.Add(columnHeader4);

            Lst_ListaProdutosEdit.GridLines = true;
        }
        private void Btn_RemoverEdit_Click(object sender, EventArgs e)
        {
           for (int i = Lst_ListaProdutosEdit.SelectedItems.Count - 1; i >= 0; i--)
           {
              Label_CalculaTotalProdutosEdit.Text = "R$" + (double.Parse(Label_CalculaTotalProdutosEdit.Text.Replace("R$", "").Replace(",", "."))
                      - double.Parse(Lst_ListaProdutosEdit.SelectedItems[i].SubItems[3].Text.Replace("R$", ""))).ToString();
              Label_CalculaValorVendaPedEdit.Text = "R$" + (double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."))
                      - double.Parse(Lst_ListaProdutosEdit.SelectedItems[i].SubItems[3].Text.Replace("R$", ""))).ToString();
                ListViewItem lstRemove = Lst_ListaProdutosEdit.SelectedItems[i];
              listaExcluir = Lst_ListaProdutosEdit.SelectedItems[i];
              Lst_ListaProdutosEdit.Items.Remove(lstRemove);
           }
        }

        private void Lst_ListaProdutosEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && Lst_ListaProdutosEdit.SelectedItems.Count > 0)
            {
                    for (int i = Lst_ListaProdutosEdit.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        Label_CalculaTotalProdutosEdit.Text = "R$" + (double.Parse(Label_CalculaTotalProdutosEdit.Text.Replace("R$", "").Replace(",", "."))
                        - double.Parse(Lst_ListaProdutosEdit.SelectedItems[i].SubItems[3].Text.Replace("R$", ""))).ToString();
                        Label_CalculaValorVendaPedEdit.Text = "R$" + (double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."))
                        - double.Parse(Lst_ListaProdutosEdit.SelectedItems[i].SubItems[3].Text.Replace("R$", ""))).ToString();
                        ListViewItem lstRemove = Lst_ListaProdutosEdit.SelectedItems[i];
                        listaExcluir = Lst_ListaProdutosEdit.SelectedItems[i];
                        Lst_ListaProdutosEdit.Items.Remove(lstRemove);
                    }
            }
        }

        private void Cbo_NomeClienteEdit_DropDown(object sender, EventArgs e)
        {
            if (!Cbo_NomeClienteEdit.Text.Equals(""))
            {
                Cbo_NomeClienteEdit.Items.Clear();
                ClienteController listarCliente = new ClienteController();
                foreach (var item in listarCliente.ConsultarClientePorNome(Cbo_NomeClienteEdit.Text))
                {
                    Cbo_NomeClienteEdit.Items.Add(item);
                }
            }
        }
        private void Cbo_DescricaoEdit_DropDown(object sender, EventArgs e)
        {
            if (!Cbo_DescricaoEdit.Text.Equals("[Selecione]") || !Cbo_DescricaoEdit.Text.Equals(""))
            {
                Cbo_DescricaoEdit.Items.Clear();
                ProdutoController listarProduto = new ProdutoController();
                foreach (var item in listarProduto.ConsultarProdutoPorDescricao(Cbo_DescricaoEdit.Text))
                {
                    Cbo_DescricaoEdit.Items.Add(item);
                }
            }
        }

        private void Chk_FreteEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_FreteEdit.Checked == true)
            {
                Rdb_FreteProprioEdit.Enabled = true;
                Rdb_FreteTerceiroEdit.Enabled = true;
                Msk_FreteEdit.Enabled = true;
            }
            else
            {
                Rdb_FreteProprioEdit.Checked = false;
                Rdb_FreteTerceiroEdit.Checked = false;
                Rdb_FreteProprioEdit.Enabled = false;
                Rdb_FreteTerceiroEdit.Enabled = false;
                Msk_FreteEdit.Enabled = false;
                Msk_FreteEdit.Text = "";
                Label_CalculaValorVendaPedEdit.Text = "R$" + ((double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture)) -
                   ajusteValorVenda).ToString();
                ajusteValorVenda = 0;
                if (Label_CalculaTotalProdutosEdit.Text == "R$0,00")
                    Label_CalculaValorVendaPedEdit.Text = "R$0,00";
            }
        }

        private void Msk_FreteEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_FreteEdit.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_FreteEdit.SelectionStart = resultado;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (Msk_FreteEdit.Text.Replace("R$", "").Replace(" ", "").Replace(",", ".").Trim() != ".")
                {
                    Label_CalculaValorVendaPedEdit.Text = "R$" + ((double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture)) -
                   ajusteValorVenda).ToString();
                    ajusteValorVenda = double.Parse(Msk_FreteEdit.Text.Replace("R$", "").Replace(" ", "").Replace(",", "."));
                    Label_CalculaValorVendaPedEdit.Text = "R$" + ((double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture)) +
                   ajusteValorVenda).ToString();
                }
                if (Msk_FreteEdit.Text.Replace("R$", "").Replace(" ", "").Replace(",", ".").Trim() == ".")
                {
                    Label_CalculaValorVendaPedEdit.Text = "R$" + ((double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture)) -
                   ajusteValorVenda).ToString();
                    ajusteValorVenda = 0;
                }
            }
        }
    }
}
