using ProjetoCasa.Controller;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCasa
{
    public partial class FormEditarPagamento : Form
    {
        private string nomeCliente;
        private int idPedidoPagamento;
        private double valorVendaPedido;
        private string statusPagamentoPedido;
        private string tipoPagamento;
        private double valorPago;
        public FormEditarPagamento(List<Pagamento> listaPagamento)
        {
            InitializeComponent();
            foreach (var item in listaPagamento)
            {
                Label_CodigoPagamento.Text = item.idPagamento.ToString();
                Cbo_ClientePgtoEdit.ValueMember = Convert.ToString(item.pedido.idClientePed);
                Cbo_ClientePgtoEdit.Text = item.pedido.cliente.nomeCliente + " - " + item.pedido.cliente.nomeCachorro;
                nomeCliente = Cbo_ClientePgtoEdit.Text;
                Label_NumPedidoPgtoEdit.Text = item.idPedidoPag.ToString();
                idPedidoPagamento = Convert.ToInt32(Label_NumPedidoPgtoEdit.Text);
                Label_CalculaValorVendaPedEdit.Text = "R$" + item.pedido.valorVenda.ToString();
                valorVendaPedido = Convert.ToDouble(Label_CalculaValorVendaPedEdit.Text.Replace("R$", ""), CultureInfo.InvariantCulture);
                statusPagamentoPedido = item.statusPagamentoPedido;
                tipoPagamento = item.tipoPagamento;
                valorPago = item.valorPago;
                Msk_ValorPagoEdit.Text = item.valorPago.ToString();
                while (double.Parse(Msk_ValorPagoEdit.Text.Replace(" ", "").Replace("R$", ""), CultureInfo.InvariantCulture) != valorPago)
                {
                    Msk_ValorPagoEdit.Text = " " + Msk_ValorPagoEdit.Text;
                }
                Date_DataPgtoEdit.Value = Convert.ToDateTime(item.dataPagamento);
            }
        }

        private void Btn_SalvarPgto_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            double valorPago;
            PagamentoController inserirPagamento = new PagamentoController();
            string formatadorValorPago = Msk_ValorPagoEdit.Text.Replace(" ", "").Replace("R$", "").Trim();
            if (formatadorValorPago != ".")
                valorPago = double.Parse(formatadorValorPago, CultureInfo.InvariantCulture);
            else
                valorPago = 0;

            inserirPagamento.EditarPagamento(Convert.ToInt32(Label_CodigoPagamento.Text), Convert.ToInt32(Label_NumPedidoPgtoEdit.Text), Convert.ToDateTime(Date_DataPgtoEdit.Value),
                Cbo_TipoPgtoPedEdit.Text, valorPago, Cbo_StatusPgtoPedEdit.Text);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Limpar()
        {
            Cbo_ClientePgtoEdit.Items.Clear();
            Cbo_ClientePgtoEdit.Text = "[Pesquisar]";
            Label_NumPedidoPgtoEdit.Text = "0";
            Label_CalculaValorVendaPedEdit.Text = "R$0,00";            
            Cbo_StatusPgtoPedEdit.Text = "[Selecione]";            
            Cbo_TipoPgtoPedEdit.Text = "[Selecione]";
            Msk_ValorPagoEdit.Text = "";
            Date_DataPgtoEdit.Value = DateTime.Now;
        }

        private bool ValidarPreenchimento()
        {
            if (Cbo_ClientePgtoEdit.Text != nomeCliente)
            {
                if (Cbo_ClientePgtoEdit.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Necessário pesquisar e selecionar o cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (Label_NumPedidoPgtoEdit.Text == "0")
            {
                MessageBox.Show("Verifique se esse cliente possui um pedido registrado, pois não há número de pedido para ele.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Label_CalculaValorVendaPedEdit.Text == "R$0.00")
            {
                MessageBox.Show("Verifique se esse cliente possui um pedido registrado, pois não há valor de venda registrado para ele.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_StatusPgtoPedEdit.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o status do pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_StatusPgtoPedEdit.Text != "Não Pago" && Cbo_TipoPgtoPedEdit.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o tipo de pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_StatusPgtoPedEdit.Text != "Não Pago" && Msk_ValorPagoEdit.Text == "R$    .")
            {
                MessageBox.Show("Digite o valor pago.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_StatusPgtoPedEdit.Text == "Não Pago" && Date_DataPgtoEdit.Value <= DateTime.Now)
            {
                MessageBox.Show("Selecione a data que o pagamento será efetuado, pois o status está como Adiantamento ou Não Pago.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!(Msk_ValorPagoEdit.Text == "R$    .") && double.Parse(Msk_ValorPagoEdit.Text.Replace("R$", "").Replace(" ", ""), CultureInfo.InvariantCulture) > double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture))
            {
                MessageBox.Show("O valor pago está maior do que o valor da venda.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!(Msk_ValorPagoEdit.Text == "R$    .") && double.Parse(Msk_ValorPagoEdit.Text.Replace("R$", "").Replace(" ", ""), CultureInfo.InvariantCulture) < double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture) && Cbo_StatusPgtoPedEdit.Text == "Pago Totalmente")
            {
                MessageBox.Show("O valor pago está menor do que o valor da venda, sendo que o status é Pago Totalmente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!(Msk_ValorPagoEdit.Text == "R$    .") && double.Parse(Msk_ValorPagoEdit.Text.Replace("R$", "").Replace(" ", ""), CultureInfo.InvariantCulture) == double.Parse(Label_CalculaValorVendaPedEdit.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture) && Cbo_StatusPgtoPedEdit.Text == "Adiantamento")
            {
                MessageBox.Show("O valor pago está igual ao valor da venda, sendo que o status é Adiantamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Cbo_ClientePgtoEdit_DropDown(object sender, EventArgs e)
        {
            if (!Cbo_ClientePgtoEdit.Text.Equals(""))
            {
                Cbo_ClientePgtoEdit.Items.Clear();
                ClienteController listarCliente = new ClienteController();
                foreach (var item in listarCliente.ConsultarClientePorNome(Cbo_ClientePgtoEdit.Text))
                {
                    Cbo_ClientePgtoEdit.Items.Add(item);
                }
            }
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            Cbo_ClientePgtoEdit.Items.Clear();
            Cbo_StatusPgtoPedEdit.Items.Clear();
            Cbo_TipoPgtoPedEdit.Items.Clear();            
            PreencherCombobox();
            Cbo_StatusPgtoPedEdit.Text = statusPagamentoPedido;
            Cbo_TipoPgtoPedEdit.Text = tipoPagamento;
        }

        private void PreencherCombobox()
        {
            Cbo_StatusPgtoPedEdit.Items.Add("[Selecione]");
            Cbo_StatusPgtoPedEdit.Items.Add("Não Pago");
            Cbo_StatusPgtoPedEdit.Items.Add("Adiantamento");
            Cbo_StatusPgtoPedEdit.Items.Add("Pago Totalmente");            
            Cbo_TipoPgtoPedEdit.Items.Add("[Selecione]");
            Cbo_TipoPgtoPedEdit.Items.Add("Cartão");
            Cbo_TipoPgtoPedEdit.Items.Add("Dinheiro");
            Cbo_TipoPgtoPedEdit.Items.Add("Transferência / Depósito");
        }

        private void Cbo_ClientePgtoEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!Cbo_ClientePgtoEdit.Text.Equals("[Pesquisar]") && !Cbo_ClientePgtoEdit.Text.Equals(""))
            {
                PedidoController pesquisarPedido = new PedidoController();
                Cliente resultadoCliente = (Cliente)Cbo_ClientePgtoEdit.SelectedItem;
                int resultadoIdCliente = resultadoCliente.idCliente;
                if (pesquisarPedido.ConsultarUltimoPedidoPorCliente(resultadoIdCliente).Count == 0)
                {
                    Label_NumPedidoPgtoEdit.Text = "0";
                    Label_CalculaValorVendaPedEdit.Text = "R$0.00";
                }
                else
                {
                    foreach (var item in pesquisarPedido.ConsultarUltimoPedidoPorCliente(resultadoIdCliente))
                    {
                        Label_NumPedidoPgtoEdit.Text = item.idPedido.ToString();
                        Label_CalculaValorVendaPedEdit.Text = "R$" + item.valorVenda.ToString();
                    }
                }
            }
        }

        private void Cbo_StatusPgtoPed_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cbo_StatusPgtoPedEdit.Text == "Não Pago")
            {
                Cbo_TipoPgtoPedEdit.Text = "[Selecione]";
                Msk_ValorPagoEdit.Text = "";
                Cbo_TipoPgtoPedEdit.Enabled = false;
                Msk_ValorPagoEdit.Enabled = false;
            }
            else 
            {
                Cbo_TipoPgtoPedEdit.Enabled = true;
                Msk_ValorPagoEdit.Enabled = true;
            }
        }

        private void Msk_ValorPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_ValorPagoEdit.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_ValorPagoEdit.SelectionStart = resultado;
            }
        }        
    }
}
