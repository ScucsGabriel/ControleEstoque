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
    public partial class FormListarDespesa : Form
    {
        private int resultadoBuscaData;
        public FormListarDespesa()
        {
            InitializeComponent();
        }

        private void Btn_VoltarCadDesp_Click(object sender, EventArgs e)
        {
            FormDespesa formDespesa = new FormDespesa();
            this.Hide();
            this.Close();
            formDespesa.ShowDialog();            
        }

        private void Btn_BuscarPorDataDesp_Click(object sender, EventArgs e)
        {
            resultadoBuscaData = 1;
            Txt_DespesaBuscaDesp.Text = "";
            Cbo_FormaPgtoDespLista.Text = "[Selecione]";
            Cbo_RespCartaoLista.Text = "[Selecione]";
            Cbo_StatusPgtoDespLista.Text = "[Selecione]";
            if (Date_DataMaximaDesp.Value < Date_DataMinimaDesp.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorDataDespesa(Convert.ToDateTime(Date_DataMinimaDesp.Value),
                Convert.ToDateTime(Date_DataMaximaDesp.Value));
        }

        private void BuscarPorDataDespesa(DateTime dataMinimaDesp, DateTime dataMaximaDesp)
        {
            string stringDataMinimaDesp = dataMinimaDesp.ToString("yyyy-MM-dd");
            string stringDataMaximaDesp = dataMaximaDesp.ToString("yyyy-MM-dd");
            LstView_ListaDesp.Columns.Clear();
            LstView_ListaDesp.Items.Clear();
            LstView_ListaDesp.Refresh();
            PreencherColumnHeader();
            PreencherListView_BuscarPorDataDespesa(stringDataMinimaDesp, stringDataMaximaDesp);
            LstView_ListaDesp.View = System.Windows.Forms.View.Details;
        }

        private void BuscarPorDespesa(DateTime dataMinimaDesp, DateTime dataMaximaDesp, string despesaBuscaDesp)
        {
            string stringDataMinimaDesp = dataMinimaDesp.ToString("yyyy-MM-dd");
            string stringDataMaximaDesp = dataMaximaDesp.ToString("yyyy-MM-dd");
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_BuscarPorDespesa(stringDataMinimaDesp, stringDataMaximaDesp, despesaBuscaDesp);
            LstView_ListaDesp.View = System.Windows.Forms.View.Details;
        }
        private void FormListarDespesa_Load_1(object sender, EventArgs e)
        {
            LimparFormLista();
            Date_DataMinimaDesp.Value = DateTime.Today;
            LstView_ListaDesp.FullRowSelect = true;
            Cbo_FormaPgtoDespLista.Items.Clear();
            Cbo_RespCartaoLista.Items.Clear();
            Cbo_StatusPgtoDespLista.Items.Clear();
            PreencherCombobox();
            Cbo_FormaPgtoDespLista.Text = "[Selecione]";
            Cbo_RespCartaoLista.Text = "[Selecione]";
            Cbo_StatusPgtoDespLista.Text = "[Selecione]";
        }

        private void PreencherCombobox()
        {
            Cbo_FormaPgtoDespLista.Items.Add("[Selecione]");
            Cbo_FormaPgtoDespLista.Items.Add("Dinheiro");
            Cbo_FormaPgtoDespLista.Items.Add("Débito");
            Cbo_FormaPgtoDespLista.Items.Add("Crédito");
            Cbo_RespCartaoLista.Items.Add("[Selecione]");
            Cbo_RespCartaoLista.Items.Add("Adilson");
            Cbo_RespCartaoLista.Items.Add("Ariane");
            Cbo_RespCartaoLista.Items.Add("Gabriel");
            Cbo_RespCartaoLista.Items.Add("Guilherme");
            Cbo_RespCartaoLista.Items.Add("Rosimar");
            Cbo_StatusPgtoDespLista.Items.Add("[Selecione]");
            Cbo_StatusPgtoDespLista.Items.Add("Não Pago");
            Cbo_StatusPgtoDespLista.Items.Add("Pago");
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

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Datas";
            columnHeader3.Text = "Despesa";
            columnHeader4.Text = "Valor";
            columnHeader5.Text = "Forma de Pagamento";
            columnHeader6.Text = "Data do Cartão";
            columnHeader7.Text = "Responsável Cartão";
            columnHeader8.Text = "Status Pagamento";

            LstView_ListaDesp.Columns.Add(columnHeader1);
            LstView_ListaDesp.Columns.Add(columnHeader2);
            LstView_ListaDesp.Columns.Add(columnHeader3);
            LstView_ListaDesp.Columns.Add(columnHeader4);
            LstView_ListaDesp.Columns.Add(columnHeader5);
            LstView_ListaDesp.Columns.Add(columnHeader6);
            LstView_ListaDesp.Columns.Add(columnHeader7);
            LstView_ListaDesp.Columns.Add(columnHeader8);

            LstView_ListaDesp.GridLines = true;
        }
        private void PreencherListView_BuscarPorDataDespesa(string dataMinimaDesp, string dataMaximaDesp)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesa(dataMinimaDesp, dataMaximaDesp).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesa(dataMinimaDesp, dataMaximaDesp))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), item.datas.ToString("dd-MM-yyyy"),
                    item.despesa.ToString(), "R$" + item.valorDespesa.ToString(),
                    item.formaPagamento.ToString(), item.dataCartao.Value.Equals(Convert.ToDateTime("01-01-1753")) ? "" :
                    item.dataCartao.Value.ToString("dd-MM-yyyy"), item.responsavelCartao.Equals("") ? "" : item.responsavelCartao,
                    item.statusPagamento.ToString() });
                    LstView_ListaDesp.Items.Add(listViewItem);

                    Label_CalcularQuantDesp.Text = Convert.ToString(LstView_ListaDesp.Items.Count);
                    Label_CalculaValorTotalDesp.Text = "R$" + (double.Parse(Label_CalculaValorTotalDesp.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                    if ((item.formaPagamento == "Dinheiro" || item.formaPagamento == "Débito") && item.valorDespesa != 0)
                        Label_CalculaValorDinDeb.Text = "R$" + (double.Parse(Label_CalculaValorDinDeb.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.formaPagamento == "Crédito" && item.valorDespesa != 0)
                        Label_CalculaValorCredito.Text = "R$" + (double.Parse(Label_CalculaValorCredito.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.statusPagamento == "Pago")
                        Label_CalculaValorPago.Text = "R$" + (double.Parse(Label_CalculaValorPago.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                }
                ColorirPorStatus();
            }
        }

        private void PreencherListView_BuscarPorDespesa(string dataMinimaDesp, string dataMaximaDesp, string despesaBuscaDesp)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesaPorDespesa(dataMinimaDesp, dataMaximaDesp, despesaBuscaDesp).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para esta despesa!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesaPorDespesa(dataMinimaDesp, dataMaximaDesp, despesaBuscaDesp))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), item.datas.ToString("dd-MM-yyyy"),
                    item.despesa.ToString(), "R$" + item.valorDespesa.ToString(),
                    item.formaPagamento.ToString(), item.dataCartao.Value.Equals(Convert.ToDateTime("01-01-1753")) ? "" : 
                    item.dataCartao.Value.ToString("dd-MM-yyyy"), item.responsavelCartao.Equals("") ? "" : item.responsavelCartao,
                    item.statusPagamento.ToString() });
                    LstView_ListaDesp.Items.Add(listViewItem);

                    Label_CalcularQuantDesp.Text = Convert.ToString(LstView_ListaDesp.Items.Count);
                    Label_CalculaValorTotalDesp.Text = "R$" + (double.Parse(Label_CalculaValorTotalDesp.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                    if ((item.formaPagamento == "Dinheiro" || item.formaPagamento == "Débito") && item.valorDespesa != 0)
                        Label_CalculaValorDinDeb.Text = "R$" + (double.Parse(Label_CalculaValorDinDeb.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.formaPagamento == "Crédito" && item.valorDespesa != 0)
                        Label_CalculaValorCredito.Text = "R$" + (double.Parse(Label_CalculaValorCredito.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.statusPagamento == "Pago")
                        Label_CalculaValorPago.Text = "R$" + (double.Parse(Label_CalculaValorPago.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                }
                ColorirPorStatus();
            }
        }

        private void Btn_BuscarPorDespesaDesp_Click(object sender, EventArgs e)
        {
            Cbo_FormaPgtoDespLista.Text = "[Selecione]";
            Cbo_RespCartaoLista.Text = "[Selecione]";
            Cbo_StatusPgtoDespLista.Text = "[Selecione]";
            if (Date_DataMaximaDesp.Value < Date_DataMinimaDesp.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_DespesaBuscaDesp.Text == "")
            {
                MessageBox.Show("Digite a despesa.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_DespesaBuscaDesp.Text.Length > 70)
            {
                MessageBox.Show("Despesa está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorDespesa(Date_DataMinimaDesp.Value, Date_DataMaximaDesp.Value, Txt_DespesaBuscaDesp.Text);
        }

        private void Btn_ExcluirDespesa_Click(object sender, EventArgs e)
        {
            if (LstView_ListaDesp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_ListaDesp.SelectedItems.Count > 1)
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
                    DespesaController listarDespesa = new DespesaController();
                    int idDespesa = Convert.ToInt32(LstView_ListaDesp.SelectedItems[0].SubItems[0].Text);
                    Label_CalculaValorDinDeb.Text = "R$0,00";
                    Label_CalculaValorCredito.Text = "R$0,00";
                    Label_CalculaValorTotalDesp.Text = "R$0,00";
                    Label_CalculaValorPago.Text = "R$0,00";
                    listarDespesa.ExcluirDespesa(idDespesa);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaDesp.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaDesp.SelectedItems[i];
                        LstView_ListaDesp.Items.Remove(lstRemove);
                    }
                    LstView_ListaDesp.Refresh();

                    Label_CalcularQuantDesp.Text = Convert.ToString(LstView_ListaDesp.Items.Count);
                    for (int item = 0; item < LstView_ListaDesp.Items.Count; item++)
                    {
                        Label_CalculaValorTotalDesp.Text = "R$" + (double.Parse(Label_CalculaValorTotalDesp.Text.Replace("R$", "")) +
                            double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", ""))).ToString();
                        if ((LstView_ListaDesp.Items[item].SubItems[4].Text == "Dinheiro" || LstView_ListaDesp.Items[item].SubItems[4].Text == "Débito") &&
                            double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", "")) != 0)
                            Label_CalculaValorDinDeb.Text = "R$" + (double.Parse(Label_CalculaValorDinDeb.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaDesp.Items[item].SubItems[4].Text == "Crédito" &&
                            double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", "")) != 0)
                            Label_CalculaValorCredito.Text = "R$" + (double.Parse(Label_CalculaValorCredito.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaDesp.Items[item].SubItems[7].Text == "Pago")
                            Label_CalculaValorPago.Text = "R$" + (double.Parse(Label_CalculaValorPago.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", ""))).ToString();
                    }

                }
            }
        }

        private void LimparFormLista()
        {
            LstView_ListaDesp.Columns.Clear();
            LstView_ListaDesp.Items.Clear();
            LstView_ListaDesp.FullRowSelect = true;
            Label_CalcularQuantDesp.Text = "0";
            Label_CalculaValorDinDeb.Text = "R$0,00";
            Label_CalculaValorCredito.Text = "R$0,00";
            Label_CalculaValorTotalDesp.Text = "R$0,00";
            Label_CalculaValorPago.Text = "R$0,00";
        }

        private void Btn_EditarDespesa_Click(object sender, EventArgs e)
        {
            if (LstView_ListaDesp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_ListaDesp.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DespesaController listarDespesa = new DespesaController();
            List<Despesa> despesasSelecionadas = new List<Despesa>();
            int idDespesa = Convert.ToInt32(LstView_ListaDesp.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarDespesa.ConsultarDespesaPorId(idDespesa))
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = item.idDespesa;
                despesa.datas = item.datas;
                despesa.despesa = item.despesa;
                despesa.valorDespesa = item.valorDespesa;
                despesa.formaPagamento = item.formaPagamento;
                despesa.dataCartao = item.dataCartao;
                despesa.responsavelCartao = item.responsavelCartao;
                despesa.statusPagamento = item.statusPagamento;                

                despesasSelecionadas.Add(despesa);
            }

            FormEditarDespesa formEditarDespesa = new FormEditarDespesa(despesasSelecionadas);
            formEditarDespesa.ShowDialog();

            if (Txt_DespesaBuscaDesp.Text != "")
            {
                DateTime dataMinimaDesp = Date_DataMinimaDesp.Value;
                DateTime dataMaximaDesp = Date_DataMaximaDesp.Value;
                string stringDataMinimaDesp = dataMinimaDesp.ToString("yyyy-MM-dd");
                string stringDataMaximaDesp = dataMaximaDesp.ToString("yyyy-MM-dd");
                PreencherListView_BuscarPorDespesa(stringDataMinimaDesp, stringDataMaximaDesp, Txt_DespesaBuscaDesp.Text);
            }
            else if (Cbo_FormaPgtoDespLista.Text != "[Selecione]")
            {
                DateTime dataMinimaDesp = Date_DataMinimaDesp.Value;
                DateTime dataMaximaDesp = Date_DataMaximaDesp.Value;
                string stringDataMinimaDesp = dataMinimaDesp.ToString("yyyy-MM-dd");
                string stringDataMaximaDesp = dataMaximaDesp.ToString("yyyy-MM-dd");
                PreencherListView_FormaPgtoDesp(stringDataMinimaDesp, stringDataMaximaDesp, Cbo_FormaPgtoDespLista.Text);
            }
            else if (Cbo_RespCartaoLista.Text != "[Selecione]")
            {
                DateTime dataMinimaDesp = Date_DataMinimaDesp.Value;
                DateTime dataMaximaDesp = Date_DataMaximaDesp.Value;
                string stringDataMinimaDesp = dataMinimaDesp.ToString("yyyy-MM-dd");
                string stringDataMaximaDesp = dataMaximaDesp.ToString("yyyy-MM-dd");
                PreencherListView_RespCartao(stringDataMinimaDesp, stringDataMaximaDesp, Cbo_RespCartaoLista.Text);
            }
            else if (Cbo_StatusPgtoDespLista.Text != "[Selecione]")
            {
                DateTime dataMinimaDesp = Date_DataMinimaDesp.Value;
                DateTime dataMaximaDesp = Date_DataMaximaDesp.Value;
                string stringDataMinimaDesp = dataMinimaDesp.ToString("yyyy-MM-dd");
                string stringDataMaximaDesp = dataMaximaDesp.ToString("yyyy-MM-dd");
                PreencherListView_StatusPgtoDesp(stringDataMinimaDesp, stringDataMaximaDesp, Cbo_StatusPgtoDespLista.Text);
            }
            else if (resultadoBuscaData == 1)
            {
                DateTime dataMinimaDesp = Date_DataMinimaDesp.Value;
                DateTime dataMaximaDesp = Date_DataMaximaDesp.Value;
                string stringDataMinimaDesp = dataMinimaDesp.ToString("yyyy-MM-dd");
                string stringDataMaximaDesp = dataMaximaDesp.ToString("yyyy-MM-dd");
                PreencherListView_BuscarPorDataDespesa(stringDataMinimaDesp, stringDataMaximaDesp);
            }
            else if (resultadoBuscaData == 2)
            {
                DateTime dataMinimaDesp = Date_DataMinimaDesp.Value;
                DateTime dataMaximaDesp = Date_DataMaximaDesp.Value;
                string stringDataMinimaDesp = dataMinimaDesp.ToString("yyyy-MM-dd");
                string stringDataMaximaDesp = dataMaximaDesp.ToString("yyyy-MM-dd");
                PreencherListView_BuscarPorDataCartao(stringDataMinimaDesp, stringDataMaximaDesp);
            }
        }
        private void Btn_BuscarPorDataCartao_Click(object sender, EventArgs e)
        {
            resultadoBuscaData = 2;
            Txt_DespesaBuscaDesp.Text = "";
            Cbo_FormaPgtoDespLista.Text = "[Selecione]";
            Cbo_RespCartaoLista.Text = "[Selecione]";
            Cbo_StatusPgtoDespLista.Text = "[Selecione]";
            if (Date_DataMaximaDesp.Value < Date_DataMinimaDesp.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorDataCartao(Convert.ToDateTime(Date_DataMinimaDesp.Value),
                Convert.ToDateTime(Date_DataMaximaDesp.Value));
        }

        private void BuscarPorDataCartao(DateTime dataMinima, DateTime dataMaxima)
        {
            string stringDataMinimaDesp = dataMinima.ToString("yyyy-MM-dd");
            string stringDataMaximaDesp = dataMaxima.ToString("yyyy-MM-dd");
            LstView_ListaDesp.Columns.Clear();
            LstView_ListaDesp.Items.Clear();
            LstView_ListaDesp.Refresh();
            PreencherColumnHeader();
            PreencherListView_BuscarPorDataCartao(stringDataMinimaDesp, stringDataMaximaDesp);
            LstView_ListaDesp.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_BuscarPorDataCartao(string dataMinima, string dataMaxima)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesaPorDataCartao(dataMinima, dataMaxima).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesaPorDataCartao(dataMinima, dataMaxima))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), item.datas.ToString("dd-MM-yyyy"),
                    item.despesa.ToString(), "R$" + item.valorDespesa.ToString(),
                    item.formaPagamento.ToString(), item.dataCartao.Value.Equals(Convert.ToDateTime("01-01-1753")) ? "" :
                    item.dataCartao.Value.ToString("dd-MM-yyyy"), item.responsavelCartao.Equals("") ? "" : item.responsavelCartao,
                    item.statusPagamento.ToString() });
                    LstView_ListaDesp.Items.Add(listViewItem);

                    Label_CalcularQuantDesp.Text = Convert.ToString(LstView_ListaDesp.Items.Count);
                    Label_CalculaValorTotalDesp.Text = "R$" + (double.Parse(Label_CalculaValorTotalDesp.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                    if ((item.formaPagamento == "Dinheiro" || item.formaPagamento == "Débito") && item.valorDespesa != 0)
                        Label_CalculaValorDinDeb.Text = "R$" + (double.Parse(Label_CalculaValorDinDeb.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.formaPagamento == "Crédito" && item.valorDespesa != 0)
                        Label_CalculaValorCredito.Text = "R$" + (double.Parse(Label_CalculaValorCredito.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.statusPagamento == "Pago")
                        Label_CalculaValorPago.Text = "R$" + (double.Parse(Label_CalculaValorPago.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                }
                ColorirPorStatus();
            }
        }
        private void Btn_BuscarFormaPgtoDesp_Click(object sender, EventArgs e)
        {
            Txt_DespesaBuscaDesp.Text = "";
            Cbo_RespCartaoLista.Text = "[Selecione]";
            Cbo_StatusPgtoDespLista.Text = "[Selecione]";
            if (Date_DataMaximaDesp.Value < Date_DataMinimaDesp.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cbo_FormaPgtoDespLista.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione a forma de pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorFormaPgtoDesp(Date_DataMinimaDesp.Value, Date_DataMaximaDesp.Value, Cbo_FormaPgtoDespLista.Text);
        }
        private void BuscarPorFormaPgtoDesp(DateTime dataMinima, DateTime dataMaxima, string formaPagamentoDesp)
        {
            string stringDataMinimaDesp = dataMinima.ToString("yyyy-MM-dd");
            string stringDataMaximaDesp = dataMaxima.ToString("yyyy-MM-dd");
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_FormaPgtoDesp(stringDataMinimaDesp, stringDataMaximaDesp, formaPagamentoDesp);
            LstView_ListaDesp.View = System.Windows.Forms.View.Details;
        }
        private void PreencherListView_FormaPgtoDesp(string stringDataMinimaDesp, string stringDataMaximaDesp, string formaPagamentoDesp)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesaPorFormaPgtoDesp(stringDataMinimaDesp, stringDataMaximaDesp, formaPagamentoDesp).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para esta forma de pagamento!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesaPorFormaPgtoDesp(stringDataMinimaDesp, stringDataMaximaDesp, formaPagamentoDesp))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), item.datas.ToString("dd-MM-yyyy"),
                    item.despesa.ToString(), "R$" + item.valorDespesa.ToString(),
                    item.formaPagamento.ToString(), item.dataCartao.Value.Equals(Convert.ToDateTime("01-01-1753")) ? "" :
                    item.dataCartao.Value.ToString("dd-MM-yyyy"), item.responsavelCartao.Equals("") ? "" : item.responsavelCartao,
                    item.statusPagamento.ToString() });
                    LstView_ListaDesp.Items.Add(listViewItem);

                    Label_CalcularQuantDesp.Text = Convert.ToString(LstView_ListaDesp.Items.Count);
                    Label_CalculaValorTotalDesp.Text = "R$" + (double.Parse(Label_CalculaValorTotalDesp.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                    if ((item.formaPagamento == "Dinheiro" || item.formaPagamento == "Débito") && item.valorDespesa != 0)
                        Label_CalculaValorDinDeb.Text = "R$" + (double.Parse(Label_CalculaValorDinDeb.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.formaPagamento == "Crédito" && item.valorDespesa != 0)
                        Label_CalculaValorCredito.Text = "R$" + (double.Parse(Label_CalculaValorCredito.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.statusPagamento == "Pago")
                        Label_CalculaValorPago.Text = "R$" + (double.Parse(Label_CalculaValorPago.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                }
                ColorirPorStatus();
            }
        }

        private void Btn_BuscarStatusPgtoDesp_Click(object sender, EventArgs e)
        {
            Txt_DespesaBuscaDesp.Text = "";
            Cbo_FormaPgtoDespLista.Text = "[Selecione]";
            Cbo_RespCartaoLista.Text = "[Selecione]";
            if (Date_DataMaximaDesp.Value < Date_DataMinimaDesp.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cbo_StatusPgtoDespLista.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o status do pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorStatusPgtoDesp(Date_DataMinimaDesp.Value, Date_DataMaximaDesp.Value, Cbo_StatusPgtoDespLista.Text);
        }
        private void BuscarPorStatusPgtoDesp(DateTime dataMinima, DateTime dataMaxima, string statusPagamentoDesp)
        {
            string stringDataMinimaDesp = dataMinima.ToString("yyyy-MM-dd");
            string stringDataMaximaDesp = dataMaxima.ToString("yyyy-MM-dd");
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_StatusPgtoDesp(stringDataMinimaDesp, stringDataMaximaDesp, statusPagamentoDesp);
            LstView_ListaDesp.View = System.Windows.Forms.View.Details;
        }
        private void PreencherListView_StatusPgtoDesp(string stringDataMinimaDesp, string stringDataMaximaDesp, string statusPagamentoDesp)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesaPorStatusPgtoDesp(stringDataMinimaDesp, stringDataMaximaDesp, statusPagamentoDesp).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para esta forma de pagamento!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesaPorStatusPgtoDesp(stringDataMinimaDesp, stringDataMaximaDesp, statusPagamentoDesp))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), item.datas.ToString("dd-MM-yyyy"),
                    item.despesa.ToString(), "R$" + item.valorDespesa.ToString(),
                    item.formaPagamento.ToString(), item.dataCartao.Value.Equals(Convert.ToDateTime("01-01-1753")) ? "" :
                    item.dataCartao.Value.ToString("dd-MM-yyyy"), item.responsavelCartao.Equals("") ? "" : item.responsavelCartao,
                    item.statusPagamento.ToString() });
                    LstView_ListaDesp.Items.Add(listViewItem);

                    Label_CalcularQuantDesp.Text = Convert.ToString(LstView_ListaDesp.Items.Count);
                    Label_CalculaValorTotalDesp.Text = "R$" + (double.Parse(Label_CalculaValorTotalDesp.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                    if ((item.formaPagamento == "Dinheiro" || item.formaPagamento == "Débito") && item.valorDespesa != 0)
                        Label_CalculaValorDinDeb.Text = "R$" + (double.Parse(Label_CalculaValorDinDeb.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.formaPagamento == "Crédito" && item.valorDespesa != 0)
                        Label_CalculaValorCredito.Text = "R$" + (double.Parse(Label_CalculaValorCredito.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.statusPagamento == "Pago")
                        Label_CalculaValorPago.Text = "R$" + (double.Parse(Label_CalculaValorPago.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                }
                ColorirPorStatus();
            }
        }

        private void Btn_BuscarPorRespCartao_Click(object sender, EventArgs e)
        {
            Txt_DespesaBuscaDesp.Text = "";
            Cbo_FormaPgtoDespLista.Text = "[Selecione]";
            Cbo_StatusPgtoDespLista.Text = "[Selecione]";
            if (Date_DataMaximaDesp.Value < Date_DataMinimaDesp.Value)
            {
                MessageBox.Show("A data máxima não pode ser menor que a data mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cbo_RespCartaoLista.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o responsável do cartão.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorResponsavelCartao(Date_DataMinimaDesp.Value, Date_DataMaximaDesp.Value, Cbo_RespCartaoLista.Text);
        }

        private void ColorirPorStatus()
        {
            for (int i = 0; i < LstView_ListaDesp.Items.Count; i++)
            {
                if (LstView_ListaDesp.Items[i].SubItems[7].Text == "Não Pago")
                    LstView_ListaDesp.Items[i].BackColor = Color.Tomato;

                else if (LstView_ListaDesp.Items[i].SubItems[7].Text == "Pago")
                    LstView_ListaDesp.Items[i].BackColor = Color.LightGreen;
            }
        }

        private void BuscarPorResponsavelCartao(DateTime dataMinima, DateTime dataMaxima, string responsavelCartao)
        {
            string stringDataMinimaDesp = dataMinima.ToString("yyyy-MM-dd");
            string stringDataMaximaDesp = dataMaxima.ToString("yyyy-MM-dd");
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_RespCartao(stringDataMinimaDesp, stringDataMaximaDesp, responsavelCartao);
            LstView_ListaDesp.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_RespCartao(string stringDataMinimaDesp, string stringDataMaximaDesp, string responsavelCartao)
        {
            LimparFormLista();
            PreencherColumnHeader();
            DespesaController listarDespesa = new DespesaController();
            int resultadoBusca = listarDespesa.ConsultarDespesaPorResponsavelCartao(stringDataMinimaDesp, stringDataMaximaDesp, responsavelCartao).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este responsável!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarDespesa.ConsultarDespesaPorResponsavelCartao(stringDataMinimaDesp, stringDataMaximaDesp, responsavelCartao))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idDespesa.ToString(), item.datas.ToString("dd-MM-yyyy"),
                    item.despesa.ToString(), "R$" + item.valorDespesa.ToString(),
                    item.formaPagamento.ToString(), item.dataCartao.Value.Equals(Convert.ToDateTime("01-01-1753")) ? "" :
                    item.dataCartao.Value.ToString("dd-MM-yyyy"), item.responsavelCartao.Equals("") ? "" : item.responsavelCartao,
                    item.statusPagamento.ToString() });
                    LstView_ListaDesp.Items.Add(listViewItem);

                    Label_CalcularQuantDesp.Text = Convert.ToString(LstView_ListaDesp.Items.Count);
                    Label_CalculaValorTotalDesp.Text = "R$" + (double.Parse(Label_CalculaValorTotalDesp.Text.Replace("R$", "")) +
                        item.valorDespesa).ToString();
                    if ((item.formaPagamento == "Dinheiro" || item.formaPagamento == "Débito") && item.valorDespesa != 0)
                        Label_CalculaValorDinDeb.Text = "R$" + (double.Parse(Label_CalculaValorDinDeb.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.formaPagamento == "Crédito" && item.valorDespesa != 0)
                        Label_CalculaValorCredito.Text = "R$" + (double.Parse(Label_CalculaValorCredito.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                    if (item.statusPagamento == "Pago")
                        Label_CalculaValorPago.Text = "R$" + (double.Parse(Label_CalculaValorPago.Text.Replace("R$", "")) +
                            item.valorDespesa).ToString();
                }
                ColorirPorStatus();
            }
        }

        private void LstView_ListaDesp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LstView_ListaDesp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.KeyCode == Keys.Delete && LstView_ListaDesp.SelectedItems.Count > 1)
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
                    DespesaController listarDespesa = new DespesaController();
                    int idDespesa = Convert.ToInt32(LstView_ListaDesp.SelectedItems[0].SubItems[0].Text);
                    Label_CalculaValorDinDeb.Text = "R$0,00";
                    Label_CalculaValorCredito.Text = "R$0,00";
                    Label_CalculaValorTotalDesp.Text = "R$0,00";
                    Label_CalculaValorPago.Text = "R$0,00";
                    listarDespesa.ExcluirDespesa(idDespesa);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaDesp.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaDesp.SelectedItems[i];
                        LstView_ListaDesp.Items.Remove(lstRemove);
                    }
                    LstView_ListaDesp.Refresh();

                    Label_CalcularQuantDesp.Text = Convert.ToString(LstView_ListaDesp.Items.Count);
                    for (int item = 0; item < LstView_ListaDesp.Items.Count; item++)
                    {
                        Label_CalculaValorTotalDesp.Text = "R$" + (double.Parse(Label_CalculaValorTotalDesp.Text.Replace("R$", "")) +
                            double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", ""))).ToString();
                        if ((LstView_ListaDesp.Items[item].SubItems[4].Text == "Dinheiro" || LstView_ListaDesp.Items[item].SubItems[4].Text == "Débito") &&
                            double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", "")) != 0)
                            Label_CalculaValorDinDeb.Text = "R$" + (double.Parse(Label_CalculaValorDinDeb.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaDesp.Items[item].SubItems[4].Text == "Crédito" &&
                            double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", "")) != 0)
                            Label_CalculaValorCredito.Text = "R$" + (double.Parse(Label_CalculaValorCredito.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", ""))).ToString();
                        if (LstView_ListaDesp.Items[item].SubItems[7].Text == "Pago")
                            Label_CalculaValorPago.Text = "R$" + (double.Parse(Label_CalculaValorPago.Text.Replace("R$", "")) +
                                double.Parse(LstView_ListaDesp.Items[item].SubItems[3].Text.Replace("R$", ""))).ToString();
                    }
                }
            }
        }        
    }
}
