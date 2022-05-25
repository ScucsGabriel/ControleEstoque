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
    public partial class FormPagamento : Form
    {
        public FormPagamento()
        {
            InitializeComponent();
        }

        private void Btn_ListarPgto_Click(object sender, EventArgs e)
        {
            FormListarPagamento formListarPagamento = new FormListarPagamento();
            formListarPagamento.ShowDialog();
            this.Close();
        }

        private void Btn_SalvarPgto_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string pagamentoAtivo = "Sim";
            double valorPago;

            PagamentoController inserirPagamento = new PagamentoController();
            string formatadorValorPago = Msk_ValorPago.Text.Replace(" ", "").Replace("R$", "").Trim();
            if (formatadorValorPago != ".")
                valorPago = double.Parse(formatadorValorPago, CultureInfo.InvariantCulture);
            else
                valorPago = 0;

            inserirPagamento.InserirPagamento(Convert.ToInt32(Label_NumPedidoPgto.Text), Convert.ToDateTime(Date_DataPgto.Value),
                Cbo_TipoPgtoPed.Text, valorPago, Cbo_StatusPgtoPed.Text, pagamentoAtivo);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void Limpar()
        {
            Cbo_ClientePgto.Items.Clear();
            Cbo_ClientePgto.Text = "[Pesquisar]";
            Label_NumPedidoPgto.Text = "0";
            Label_CalculaValorVendaPed.Text = "R$0,00";            
            Cbo_StatusPgtoPed.Text = "[Selecione]";            
            Cbo_TipoPgtoPed.Text = "[Selecione]";
            Msk_ValorPago.Text = "";
            Date_DataPgto.Value = DateTime.Now;
        }
        private bool ValidarPreenchimento()
        {
            if (Cbo_ClientePgto.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Necessário pesquisar e selecionar o cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Label_NumPedidoPgto.Text == "0")
            {
                MessageBox.Show("Verifique se esse cliente possui um pedido registrado, pois não há número de pedido para ele.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Label_CalculaValorVendaPed.Text == "R$0,00")
            {
                MessageBox.Show("Verifique se esse cliente possui um pedido registrado, pois não há valor de venda registrado para ele.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_StatusPgtoPed.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o status do pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_StatusPgtoPed.Text != "Não Pago" && Cbo_TipoPgtoPed.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o tipo de pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_StatusPgtoPed.Text != "Não Pago" && Msk_ValorPago.Text == "R$    .")
            {
                MessageBox.Show("Digite o valor pago.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_StatusPgtoPed.Text == "Não Pago" && Date_DataPgto.Value <= DateTime.Now)
            {
                MessageBox.Show("Selecione a data que o pagamento será efetuado, pois o status está como Adiantamento ou Não Pago.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!(Msk_ValorPago.Text == "R$    .") && double.Parse(Msk_ValorPago.Text.Replace("R$", "").Replace(" ", ""), CultureInfo.InvariantCulture) > double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture))
            {
                MessageBox.Show("O valor pago está maior do que o valor da venda.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!(Msk_ValorPago.Text == "R$    .") && double.Parse(Msk_ValorPago.Text.Replace("R$", "").Replace(" ", ""), CultureInfo.InvariantCulture) < double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture) && Cbo_StatusPgtoPed.Text == "Pago Totalmente")
            {
                MessageBox.Show("O valor pago está menor do que o valor da venda, sendo que o status é Pago Totalmente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!(Msk_ValorPago.Text == "R$    .") && double.Parse(Msk_ValorPago.Text.Replace("R$", "").Replace(" ", ""), CultureInfo.InvariantCulture) == double.Parse(Label_CalculaValorVendaPed.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture) && Cbo_StatusPgtoPed.Text == "Adiantamento")
            {
                MessageBox.Show("O valor pago está igual ao valor da venda, sendo que o status é Adiantamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Cbo_ClientePgto_DropDown(object sender, EventArgs e)
        {
            if (!Cbo_ClientePgto.Text.Equals("[Pesquisar]") && !Cbo_ClientePgto.Text.Equals(""))
            {
                Cbo_ClientePgto.Items.Clear();
                ClienteController listarCliente = new ClienteController();
                foreach (var item in listarCliente.ConsultarClientePorNome(Cbo_ClientePgto.Text))
                {
                    Cbo_ClientePgto.Items.Add(item);
                }
            }
        }
        public static bool IsNome(string strNome)
        {
            for (int i = 0; i < strNome.Length; i++)
            {
                if (!Char.IsLetter(strNome, i) && !Char.IsWhiteSpace(strNome, i))
                    return false;
            }
            return true;
        }

        public static bool IsNumero(string strNumero)
        {
            for (int i = 0; i < strNumero.Length; i++)
            {
                if (!Char.IsDigit(strNumero, i))
                    return false;
            }
            return true;
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            Cbo_ClientePgto.Items.Clear();
            Cbo_StatusPgtoPed.Items.Clear();
            Cbo_TipoPgtoPed.Items.Clear();
            PreencherCombobox();
            Cbo_StatusPgtoPed.Text = "[Selecione]";
            Cbo_TipoPgtoPed.Text = "[Selecione]";
        }
        private void PreencherCombobox()
        {
            Cbo_StatusPgtoPed.Items.Add("[Selecione]");
            Cbo_StatusPgtoPed.Items.Add("Não Pago");
            Cbo_StatusPgtoPed.Items.Add("Adiantamento");
            Cbo_StatusPgtoPed.Items.Add("Pago Totalmente");            
            Cbo_TipoPgtoPed.Items.Add("[Selecione]");
            Cbo_TipoPgtoPed.Items.Add("Cartão");
            Cbo_TipoPgtoPed.Items.Add("Dinheiro");
            Cbo_TipoPgtoPed.Items.Add("Transferência / Depósito");
        }

        private void Cbo_ClientePgto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!Cbo_ClientePgto.Text.Equals("[Pesquisar]") && !Cbo_ClientePgto.Text.Equals(""))
            {
                PedidoController pesquisarPedido = new PedidoController();
                Cliente resultadoCliente = (Cliente)Cbo_ClientePgto.SelectedItem;
                int resultadoIdCliente = resultadoCliente.idCliente;
                if (pesquisarPedido.ConsultarUltimoPedidoPorCliente(resultadoIdCliente).Count == 0)
                {
                    Label_NumPedidoPgto.Text = "0";
                    Label_CalculaValorVendaPed.Text = "R$0.00";
                }
                else
                {
                    foreach (var item in pesquisarPedido.ConsultarUltimoPedidoPorCliente(resultadoIdCliente))
                    {
                        Label_NumPedidoPgto.Text = item.idPedido.ToString();
                        Label_CalculaValorVendaPed.Text = "R$" + item.valorVenda.ToString();
                    }
                }
            }
        }

        private void Cbo_StatusPgtoPed_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cbo_StatusPgtoPed.Text == "Não Pago")
            {
                Cbo_TipoPgtoPed.Text = "[Selecione]";
                Msk_ValorPago.Text = "";
                Cbo_TipoPgtoPed.Enabled = false;
                Msk_ValorPago.Enabled = false;
            }
            else 
            {
                Cbo_TipoPgtoPed.Enabled = true;
                Msk_ValorPago.Enabled = true;
            }
        }

        private void Msk_ValorPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_ValorPago.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_ValorPago.SelectionStart = resultado;
            }
        }
    }
}
