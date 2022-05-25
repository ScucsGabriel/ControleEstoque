using ProjetoCasa.Controller;
using ProjetoCasa.Model;
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
    public partial class FormListarPagamento : Form
    {
        public FormListarPagamento()
        {
            InitializeComponent();
        }

        private void Btn_VoltarCadPgto_Click(object sender, EventArgs e)
        {
            FormPagamento formPagamento = new FormPagamento();
            this.Hide();
            this.Close();
            formPagamento.ShowDialog();            
        }

        private void Btn_BuscarPorDataPgto_Click(object sender, EventArgs e)
        {
            Txt_ClientePgtoBusca.Text = "";
            Txt_NumeroPedidoPag.Text = "";
            Cbo_TipoPgtoPedListar.Text = "[Selecione]";
            Cbo_StatusPgtoPedListar.Text = "[Selecione]";
            if (Date_DataMaximaPgto.Value < Date_DataMinimaPgto.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorDataPagamento(Convert.ToDateTime(Date_DataMinimaPgto.Value),
                Convert.ToDateTime(Date_DataMaximaPgto.Value));
        }

        private void BuscarPorDataPagamento(DateTime dataMinimaPgto, DateTime dataMaximaPgto)
        {
            string stringDataMinimaPgto = dataMinimaPgto.ToString("yyyy-MM-dd");
            string stringDataMaximaPgto = dataMaximaPgto.ToString("yyyy-MM-dd");
            LstView_ListaPgto.Columns.Clear();
            LstView_ListaPgto.Items.Clear();
            LstView_ListaPgto.Refresh();
            PreencherColumnHeader();
            PreencherListView_DataPagamento(stringDataMinimaPgto, stringDataMaximaPgto);
            LstView_ListaPgto.View = System.Windows.Forms.View.Details;
        }

        private void BuscarPorTipoPagamento(DateTime dataMinimaPgto, DateTime dataMaximaPgto, string tipoPagamento)
        {
            string stringDataMinimaPgto = dataMinimaPgto.ToString("yyyy-MM-dd");
            string stringDataMaximaPgto = dataMaximaPgto.ToString("yyyy-MM-dd");
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_TipoPagamento(stringDataMinimaPgto, stringDataMaximaPgto, tipoPagamento);
            LstView_ListaPgto.View = System.Windows.Forms.View.Details;
        }
        private void BuscarPorStatusPagamento(DateTime dataMinimaPgto, DateTime dataMaximaPgto, string statusPagamento)
        {
            string stringDataMinimaPgto = dataMinimaPgto.ToString("yyyy-MM-dd");
            string stringDataMaximaPgto = dataMaximaPgto.ToString("yyyy-MM-dd");
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_StatusPagamento(stringDataMinimaPgto, stringDataMaximaPgto, statusPagamento);
            LstView_ListaPgto.View = System.Windows.Forms.View.Details;
        }
        private void FormListarPagamento_Load(object sender, EventArgs e)
        {
            LimparFormLista();
            Date_DataMinimaPgto.Value = DateTime.Today;
            LstView_ListaPgto.FullRowSelect = true;
            Cbo_StatusPgtoPedListar.Items.Clear();
            Cbo_TipoPgtoPedListar.Items.Clear();
            PreencherCombobox();
            Cbo_StatusPgtoPedListar.Text = "[Selecione]";
            Cbo_TipoPgtoPedListar.Text = "[Selecione]";
        }

        private void PreencherCombobox()
        {
            Cbo_StatusPgtoPedListar.Items.Add("[Selecione]");
            Cbo_StatusPgtoPedListar.Items.Add("Não Pago");
            Cbo_StatusPgtoPedListar.Items.Add("Adiantamento");
            Cbo_StatusPgtoPedListar.Items.Add("Pago Totalmente");
            Cbo_TipoPgtoPedListar.Items.Add("[Selecione]");
            Cbo_TipoPgtoPedListar.Items.Add("Cartão");
            Cbo_TipoPgtoPedListar.Items.Add("Dinheiro");
            Cbo_TipoPgtoPedListar.Items.Add("Transferência / Depósito");
        }
        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();
            ColumnHeader columnHeader6 = new ColumnHeader();
            ColumnHeader columnHeader7 = new ColumnHeader();
            ColumnHeader columnHeader8 = new ColumnHeader();
            ColumnHeader columnHeader9 = new ColumnHeader();
            ColumnHeader columnHeader10 = new ColumnHeader();

            columnHeader1.Text = "Código Pgto.";
            columnHeader2.Text = "Número do Pedido";
            columnHeader3.Text = "Nome do Cliente";
            columnHeader4.Text = "Nome do Cachorro";
            columnHeader5.Text = "Data do Pagamento";
            columnHeader6.Text = "Valor da Venda";
            columnHeader7.Text = "Valor Pago";
            columnHeader8.Text = "Valor a Receber";
            columnHeader9.Text = "Status do Pagamento";
            columnHeader10.Text = "Tipo do Pagamento";

            LstView_ListaPgto.Columns.Add(columnHeader1);
            LstView_ListaPgto.Columns.Add(columnHeader2);
            LstView_ListaPgto.Columns.Add(columnHeader3);
            LstView_ListaPgto.Columns.Add(columnHeader4);
            LstView_ListaPgto.Columns.Add(columnHeader5);
            LstView_ListaPgto.Columns.Add(columnHeader6);
            LstView_ListaPgto.Columns.Add(columnHeader7);
            LstView_ListaPgto.Columns.Add(columnHeader8);
            LstView_ListaPgto.Columns.Add(columnHeader9);
            LstView_ListaPgto.Columns.Add(columnHeader10);

            LstView_ListaPgto.GridLines = true;
        }       

        private void PreencherListView_StatusPagamento(string stringDataMinimaPgto, string stringDataMaximaPgto, string statusPagamento)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PagamentoController listarPagamento = new PagamentoController();
            int resultadoBusca = listarPagamento.ConsultarPagamentoPorStatusPgto(stringDataMinimaPgto, stringDataMaximaPgto, statusPagamento).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este status de pagamento!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string valorReceber;
                foreach (var item in listarPagamento.ConsultarPagamentoPorStatusPgto(stringDataMinimaPgto, stringDataMaximaPgto, statusPagamento))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPagamento.ToString(), item.idPedidoPag.ToString(), item.pedido.cliente.nomeCliente.ToString(),
                    item.pedido.cliente.nomeCachorro.ToString(), item.dataPagamento.ToString("dd-MM-yyyy"),
                    "R$" + item.pedido.valorVenda.ToString(), "R$" + item.valorPago.ToString(),
                    valorReceber = ((item.pedido.valorVenda - item.valorPago) == 0 ?
                    "" : "R$" + (item.pedido.valorVenda - item.valorPago).ToString()),
                    item.statusPagamentoPedido, item.tipoPagamento.Equals("[Selecione]") ? "" : item.tipoPagamento});
                    LstView_ListaPgto.Items.Add(listViewItem);

                    Label_CalcularQuantPgto.Text = Convert.ToString(LstView_ListaPgto.Items.Count);
                    Label_CalculaTotalLivreCaixa.Text = "R$" + (double.Parse(Label_CalculaTotalLivreCaixa.Text.Replace("R$", "")) +
                        item.valorPago).ToString();
                    if (item.tipoPagamento == "Dinheiro" && item.valorPago != 0)
                        Label_CalculaPedDinheiro.Text = "R$" + (double.Parse(Label_CalculaPedDinheiro.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Transferência / Depósito" && item.valorPago != 0)
                        Label_CalculaPedTransf.Text = "R$" + (double.Parse(Label_CalculaPedTransf.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Cartão" && item.valorPago != 0)
                        Label_CalculaPedCartao.Text = "R$" + (double.Parse(Label_CalculaPedCartao.Text.Replace("R$", "")) +
                            item.valorPago).ToString();

                }
                ColorirPorStatus();
            }            
        }

        private void PreencherListView_TipoPagamento(string stringDataMinimaPgto, string stringDataMaximaPgto, string tipoPagamento)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PagamentoController listarPagamento = new PagamentoController();
            int resultadoBusca = listarPagamento.ConsultarPagamentoPorTipoPgto(stringDataMinimaPgto, stringDataMaximaPgto, tipoPagamento).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este tipo de pagamento!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string valorReceber;
                foreach (var item in listarPagamento.ConsultarPagamentoPorTipoPgto(stringDataMinimaPgto, stringDataMaximaPgto, tipoPagamento))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPagamento.ToString(), item.idPedidoPag.ToString(), item.pedido.cliente.nomeCliente.ToString(),
                    item.pedido.cliente.nomeCachorro.ToString(), item.dataPagamento.ToString("dd-MM-yyyy"),
                    "R$" + item.pedido.valorVenda.ToString(), "R$" + item.valorPago.ToString(),
                    valorReceber = ((item.pedido.valorVenda - item.valorPago) == 0 ?
                    "" : "R$" + (item.pedido.valorVenda - item.valorPago).ToString()),
                    item.statusPagamentoPedido, item.tipoPagamento.Equals("[Selecione]") ? "" : item.tipoPagamento});
                    LstView_ListaPgto.Items.Add(listViewItem);

                    Label_CalcularQuantPgto.Text = Convert.ToString(LstView_ListaPgto.Items.Count);
                    Label_CalculaTotalLivreCaixa.Text = "R$" + (double.Parse(Label_CalculaTotalLivreCaixa.Text.Replace("R$", "")) + 
                        item.valorPago).ToString();
                    if (item.tipoPagamento == "Dinheiro" && item.valorPago != 0)
                        Label_CalculaPedDinheiro.Text = "R$" + (double.Parse(Label_CalculaPedDinheiro.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Transferência / Depósito" && item.valorPago != 0)
                        Label_CalculaPedTransf.Text = "R$" + (double.Parse(Label_CalculaPedTransf.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Cartão" && item.valorPago != 0)
                        Label_CalculaPedCartao.Text = "R$" + (double.Parse(Label_CalculaPedCartao.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                }
                ColorirPorStatus();
            }            
        }
        private void PreencherListView_DataPagamento(string dataMinimaPgto, string dataMaximaPgto)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PagamentoController listarPagamento = new PagamentoController();
            int resultadoBusca = listarPagamento.ConsultarPagamento(dataMinimaPgto, dataMaximaPgto).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string valorReceber;
                foreach (var item in listarPagamento.ConsultarPagamento(dataMinimaPgto, dataMaximaPgto))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPagamento.ToString(), item.idPedidoPag.ToString(), item.pedido.cliente.nomeCliente.ToString(), 
                    item.pedido.cliente.nomeCachorro.ToString(), item.dataPagamento.ToString("dd-MM-yyyy"), 
                    "R$" + item.pedido.valorVenda.ToString(), "R$" + item.valorPago.ToString(),
                    valorReceber = ((item.pedido.valorVenda - item.valorPago) == 0 ?
                    "" : "R$" + (item.pedido.valorVenda - item.valorPago).ToString()),
                    item.statusPagamentoPedido, item.tipoPagamento.Equals("[Selecione]") ? "" : item.tipoPagamento});
                    LstView_ListaPgto.Items.Add(listViewItem);

                    Label_CalcularQuantPgto.Text = Convert.ToString(LstView_ListaPgto.Items.Count);
                    Label_CalculaTotalLivreCaixa.Text = "R$" + (double.Parse(Label_CalculaTotalLivreCaixa.Text.Replace("R$", "")) +
                        item.valorPago).ToString();
                    if (item.tipoPagamento == "Dinheiro" && item.valorPago != 0)
                        Label_CalculaPedDinheiro.Text = "R$" + (double.Parse(Label_CalculaPedDinheiro.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Transferência / Depósito" && item.valorPago != 0)
                        Label_CalculaPedTransf.Text = "R$" + (double.Parse(Label_CalculaPedTransf.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Cartão" && item.valorPago != 0)
                        Label_CalculaPedCartao.Text = "R$" + (double.Parse(Label_CalculaPedCartao.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                }
                ColorirPorStatus();
            }            
        }

        private void ColorirPorStatus()
        {
            for (int i = 0; i < LstView_ListaPgto.Items.Count; i++)
            {
                if (LstView_ListaPgto.Items[i].SubItems[8].Text == "Não Pago")
                    LstView_ListaPgto.Items[i].BackColor = Color.Tomato;

                else if (LstView_ListaPgto.Items[i].SubItems[8].Text == "Adiantamento")
                    LstView_ListaPgto.Items[i].BackColor = Color.LightYellow;

                else if (LstView_ListaPgto.Items[i].SubItems[8].Text == "Pago Totalmente")
                    LstView_ListaPgto.Items[i].BackColor = Color.LightGreen;
            }
        }       

        private void Btn_BuscarPorStatusPgto_Click(object sender, EventArgs e)
        {
            Txt_ClientePgtoBusca.Text = "";
            Txt_NumeroPedidoPag.Text = "";
            Cbo_TipoPgtoPedListar.Text = "[Selecione]";
            if (Date_DataMaximaPgto.Value < Date_DataMinimaPgto.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cbo_StatusPgtoPedListar.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o status do pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorStatusPagamento(Date_DataMinimaPgto.Value, Date_DataMaximaPgto.Value, Cbo_StatusPgtoPedListar.Text);
        }

        private void Btn_BuscarPorTipoPgto_Click(object sender, EventArgs e)
        {
            Txt_ClientePgtoBusca.Text = "";
            Txt_NumeroPedidoPag.Text = "";
            Cbo_StatusPgtoPedListar.Text = "[Selecione]";
            if (Date_DataMaximaPgto.Value < Date_DataMinimaPgto.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cbo_TipoPgtoPedListar.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o tipo de pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorTipoPagamento(Date_DataMinimaPgto.Value, Date_DataMaximaPgto.Value, Cbo_TipoPgtoPedListar.Text);
        }

        private void Btn_ExcluirPgto_Click(object sender, EventArgs e)
        {
            if (LstView_ListaPgto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_ListaPgto.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    PagamentoController listarPagamento = new PagamentoController();
                    int idPagamento = Convert.ToInt32(LstView_ListaPgto.SelectedItems[0].SubItems[0].Text);
                    Label_CalculaPedDinheiro.Text = "R$0,00";
                    Label_CalculaPedTransf.Text = "R$0,00";
                    Label_CalculaPedCartao.Text = "R$0,00";
                    Label_CalculaTotalLivreCaixa.Text = "R$0,00";
                    listarPagamento.ExcluirPagamento(idPagamento);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaPgto.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaPgto.SelectedItems[i];
                        LstView_ListaPgto.Items.Remove(lstRemove);
                    }
                    LstView_ListaPgto.Refresh();

                    Label_CalcularQuantPgto.Text = Convert.ToString(LstView_ListaPgto.Items.Count);
                    for (int item = 0; item < LstView_ListaPgto.Items.Count; item++)
                    {
                        Label_CalculaTotalLivreCaixa.Text = "R$" + (double.Parse(Label_CalculaTotalLivreCaixa.Text.Replace("R$", "")) + 
                            double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaPgto.Items[item].SubItems[9].Text == "Dinheiro" &&
                            double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", "")) != 0)
                            Label_CalculaPedDinheiro.Text = "R$" + (double.Parse(Label_CalculaPedDinheiro.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaPgto.Items[item].SubItems[9].Text == "Transferência / Depósito" &&
                            double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", "")) != 0)
                            Label_CalculaPedTransf.Text = "R$" + (double.Parse(Label_CalculaPedTransf.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaPgto.Items[item].SubItems[9].Text == "Cartão" &&
                            double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", "")) != 0)
                            Label_CalculaPedCartao.Text = "R$" + (double.Parse(Label_CalculaPedCartao.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", ""))).ToString();
                    }
                }
            }
        }

        private void LimparFormLista()
        {
            LstView_ListaPgto.Columns.Clear();
            LstView_ListaPgto.Items.Clear();
            LstView_ListaPgto.FullRowSelect = true;
            Label_CalcularQuantPgto.Text = "0";
            Label_CalculaPedDinheiro.Text = "R$0,00";
            Label_CalculaPedTransf.Text = "R$0,00";
            Label_CalculaPedCartao.Text = "R$0,00";
            Label_CalculaTotalLivreCaixa.Text = "R$0,00";
        }

        private void Btn_EditarPgto_Click(object sender, EventArgs e)
        {
            if (LstView_ListaPgto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_ListaPgto.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PagamentoController listarPagamento = new PagamentoController();
            List<Pagamento> pagamentosSelecionados = new List<Pagamento>();
            int idPagamento = Convert.ToInt32(LstView_ListaPgto.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarPagamento.ConsultarPagamentoPorId(idPagamento))
            {
                Pagamento pagamento = new Pagamento();
                pagamento.idPagamento = item.idPagamento;
                pagamento.idPedidoPag = item.idPedidoPag;
                pagamento.pedido.idClientePed = item.pedido.idClientePed;
                pagamento.pedido.cliente.nomeCliente = item.pedido.cliente.nomeCliente;
                pagamento.pedido.cliente.nomeCachorro = item.pedido.cliente.nomeCachorro;
                pagamento.statusPagamentoPedido = item.statusPagamentoPedido;
                pagamento.tipoPagamento = item.tipoPagamento;
                pagamento.pedido.valorVenda = item.pedido.valorVenda;
                pagamento.valorPago = item.valorPago;
                pagamento.dataPagamento = item.dataPagamento;

                pagamentosSelecionados.Add(pagamento);
            }

            FormEditarPagamento formEditarPagamento = new FormEditarPagamento(pagamentosSelecionados);
            formEditarPagamento.ShowDialog();

            if (Txt_NumeroPedidoPag.Text != "")
                PreencherListView_NumeroPedido(Convert.ToInt32(Txt_NumeroPedidoPag.Text));
            else if (Txt_ClientePgtoBusca.Text != "")
                PreencherListView_NomeClienteOuCachorro(Txt_ClientePgtoBusca.Text);
            else if (Cbo_StatusPgtoPedListar.Text != "[Selecione]")
            {
                DateTime dataMinimaPgto = Date_DataMinimaPgto.Value;
                DateTime dataMaximaPgto = Date_DataMaximaPgto.Value;
                string stringDataMinimaPgto = dataMinimaPgto.ToString("yyyy-MM-dd");
                string stringDataMaximaPgto = dataMaximaPgto.ToString("yyyy-MM-dd");
                PreencherListView_StatusPagamento(stringDataMinimaPgto, stringDataMaximaPgto, Cbo_StatusPgtoPedListar.Text);
            }
            else if (Cbo_TipoPgtoPedListar.Text != "[Selecione]")
            {
                DateTime dataMinimaPgto = Date_DataMinimaPgto.Value;
                DateTime dataMaximaPgto = Date_DataMaximaPgto.Value;
                string stringDataMinimaPgto = dataMinimaPgto.ToString("yyyy-MM-dd");
                string stringDataMaximaPgto = dataMaximaPgto.ToString("yyyy-MM-dd");
                PreencherListView_TipoPagamento(stringDataMinimaPgto, stringDataMaximaPgto, Cbo_TipoPgtoPedListar.Text);
            }
            else
            {
                DateTime dataMinimaPgto = Date_DataMinimaPgto.Value;
                DateTime dataMaximaPgto = Date_DataMaximaPgto.Value;
                string stringDataMinimaPgto = dataMinimaPgto.ToString("yyyy-MM-dd");
                string stringDataMaximaPgto = dataMaximaPgto.ToString("yyyy-MM-dd");
                PreencherListView_DataPagamento(stringDataMinimaPgto, stringDataMaximaPgto);
            }
        }
        private void Btn_BuscarPorCliente_Click(object sender, EventArgs e)
        {
            Txt_NumeroPedidoPag.Text = "";
            Cbo_TipoPgtoPedListar.Text = "[Selecione]";
            Cbo_StatusPgtoPedListar.Text = "[Selecione]";
            if (Txt_ClientePgtoBusca.Text == "")
            {
                MessageBox.Show("Digite o cliente ou cachorro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_NumeroPedidoPag.Text.Length > 70)
            {
                MessageBox.Show("Nome do cliente está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorNomeClienteOuCachorro(Txt_ClientePgtoBusca.Text);

        }

        private void BuscarPorNomeClienteOuCachorro(string nomeClienteOuCachorro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_NomeClienteOuCachorro(nomeClienteOuCachorro);
            LstView_ListaPgto.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_NomeClienteOuCachorro(string nomeClienteOuCachorro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PagamentoController listarPagamento = new PagamentoController();
            int resultadoBusca = listarPagamento.ConsultarPagamentoPorClienteOuCachorro(nomeClienteOuCachorro).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este tipo de pagamento!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string valorReceber;
                foreach (var item in listarPagamento.ConsultarPagamentoPorClienteOuCachorro(nomeClienteOuCachorro))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPagamento.ToString(), item.idPedidoPag.ToString(), item.pedido.cliente.nomeCliente.ToString(),
                    item.pedido.cliente.nomeCachorro.ToString(), item.dataPagamento.ToString("dd-MM-yyyy"),
                    "R$" + item.pedido.valorVenda.ToString(), "R$" + item.valorPago.ToString(),
                    valorReceber = ((item.pedido.valorVenda - item.valorPago) == 0 ?
                    "" : "R$" + (item.pedido.valorVenda - item.valorPago).ToString()),
                    item.statusPagamentoPedido, item.tipoPagamento.Equals("[Selecione]") ? "" : item.tipoPagamento});
                    LstView_ListaPgto.Items.Add(listViewItem);

                    Label_CalcularQuantPgto.Text = Convert.ToString(LstView_ListaPgto.Items.Count);
                    Label_CalculaTotalLivreCaixa.Text = "R$" + (double.Parse(Label_CalculaTotalLivreCaixa.Text.Replace("R$", "")) +
                        item.valorPago).ToString();
                    if (item.tipoPagamento == "Dinheiro" && item.valorPago != 0)
                        Label_CalculaPedDinheiro.Text = "R$" + (double.Parse(Label_CalculaPedDinheiro.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Transferência / Depósito" && item.valorPago != 0)
                        Label_CalculaPedTransf.Text = "R$" + (double.Parse(Label_CalculaPedTransf.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Cartão" && item.valorPago != 0)
                        Label_CalculaPedCartao.Text = "R$" + (double.Parse(Label_CalculaPedCartao.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                }

                ColorirPorStatus();
            }
            
        }

        private void Btn_BuscarPorNumPedido_Click(object sender, EventArgs e)
        {
            Txt_ClientePgtoBusca.Text = "";
            Cbo_TipoPgtoPedListar.Text = "[Selecione]";
            Cbo_StatusPgtoPedListar.Text = "[Selecione]";
            if (Txt_NumeroPedidoPag.Text == "")
            {
                MessageBox.Show("Digite o número do pedido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_NumeroPedidoPag.Text.Length > 7)
            {
                MessageBox.Show("Número do pedido está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PreencherListView_NumeroPedido(Convert.ToInt32(Txt_NumeroPedidoPag.Text));
        }

        private void PreencherListView_NumeroPedido(int numeroPedido)
        {
            LstView_ListaPgto.Columns.Clear();
            LstView_ListaPgto.Items.Clear();
            LstView_ListaPgto.Refresh();
            PreencherColumnHeader();
            BuscarPorNumeroPedido(numeroPedido);
            LstView_ListaPgto.View = System.Windows.Forms.View.Details;
        }

        private void BuscarPorNumeroPedido(int numeroPedido)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PagamentoController listarPagamento = new PagamentoController();
            int resultadoBusca = listarPagamento.ConsultarPagamentoPorNumeroPedido(numeroPedido).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string valorReceber;
                foreach (var item in listarPagamento.ConsultarPagamentoPorNumeroPedido(numeroPedido))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPagamento.ToString(), item.idPedidoPag.ToString(), item.pedido.cliente.nomeCliente.ToString(),
                    item.pedido.cliente.nomeCachorro.ToString(), item.dataPagamento.ToString("dd-MM-yyyy"), 
                    "R$" + item.pedido.valorVenda.ToString(), "R$" + item.valorPago.ToString(),
                    valorReceber = ((item.pedido.valorVenda - item.valorPago) == 0 ?
                    "" : "R$" + (item.pedido.valorVenda - item.valorPago).ToString()),
                    item.statusPagamentoPedido, item.tipoPagamento.Equals("[Selecione]") ? "" : item.tipoPagamento});
                    LstView_ListaPgto.Items.Add(listViewItem);

                    Label_CalcularQuantPgto.Text = Convert.ToString(LstView_ListaPgto.Items.Count);
                    Label_CalculaTotalLivreCaixa.Text = "R$" + (double.Parse(Label_CalculaTotalLivreCaixa.Text.Replace("R$", "")) +
                        item.valorPago).ToString();
                    if (item.tipoPagamento == "Dinheiro" && item.valorPago != 0)
                        Label_CalculaPedDinheiro.Text = "R$" + (double.Parse(Label_CalculaPedDinheiro.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Transferência / Depósito" && item.valorPago != 0)
                        Label_CalculaPedTransf.Text = "R$" + (double.Parse(Label_CalculaPedTransf.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                    if (item.tipoPagamento == "Cartão" && item.valorPago != 0)
                        Label_CalculaPedCartao.Text = "R$" + (double.Parse(Label_CalculaPedCartao.Text.Replace("R$", "")) +
                            item.valorPago).ToString();
                }
                ColorirPorStatus();
            }
                        
        }

        private void LstView_ListaPgto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LstView_ListaPgto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.KeyCode == Keys.Delete && LstView_ListaPgto.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.KeyCode == Keys.Delete && MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    PagamentoController listarPagamento = new PagamentoController();
                    int idPagamento = Convert.ToInt32(LstView_ListaPgto.SelectedItems[0].SubItems[0].Text);
                    Label_CalculaPedDinheiro.Text = "R$0,00";
                    Label_CalculaPedTransf.Text = "R$0,00";
                    Label_CalculaPedCartao.Text = "R$0,00";
                    Label_CalculaTotalLivreCaixa.Text = "R$0,00";
                    listarPagamento.ExcluirPagamento(idPagamento);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaPgto.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaPgto.SelectedItems[i];
                        LstView_ListaPgto.Items.Remove(lstRemove);
                    }
                    LstView_ListaPgto.Refresh();

                    Label_CalcularQuantPgto.Text = Convert.ToString(LstView_ListaPgto.Items.Count);
                    for (int item = 0; item < LstView_ListaPgto.Items.Count; item++)
                    {
                        Label_CalculaTotalLivreCaixa.Text = "R$" + (double.Parse(Label_CalculaTotalLivreCaixa.Text.Replace("R$", "")) +
                            double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaPgto.Items[item].SubItems[9].Text == "Dinheiro" &&
                            double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", "")) != 0)
                            Label_CalculaPedDinheiro.Text = "R$" + (double.Parse(Label_CalculaPedDinheiro.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaPgto.Items[item].SubItems[9].Text == "Transferência / Depósito" &&
                            double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", "")) != 0)
                            Label_CalculaPedTransf.Text = "R$" + (double.Parse(Label_CalculaPedTransf.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaPgto.Items[item].SubItems[9].Text == "Cartão" &&
                            double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", "")) != 0)
                            Label_CalculaPedCartao.Text = "R$" + (double.Parse(Label_CalculaPedCartao.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaPgto.Items[item].SubItems[6].Text.Replace("R$", ""))).ToString();
                    }
                }
            }
        }
    }
}
