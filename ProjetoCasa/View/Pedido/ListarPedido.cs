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
using System.Windows.Input;

namespace ProjetoCasa
{
    public partial class FormListarPedido : Form
    {
        public FormListarPedido()
        {
            InitializeComponent();
        }

        private void Btn_VoltarCadPed_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            this.Hide();
            this.Close();
            formPedido.ShowDialog();
            
        }

        private void Btn_BuscarPorTipoFrete_Click(object sender, EventArgs e)
        {
            Txt_ClienteBuscaPed.Text = "";
            Txt_BuscaNumeroPedido.Text = "";
            if (Date_DataMaximaPed.Value < Date_DataMinimaPed.Value)
            {
                MessageBox.Show("A Data Máxima não pode ser menor que a Data Mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cbo_TipoFrete.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o tipo de frete!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            BuscaPorFrete(Convert.ToDateTime(Date_DataMinimaPed.Value),
                Convert.ToDateTime(Date_DataMaximaPed.Value), Cbo_TipoFrete.Text);           

        }

        private void Btn_BuscarPorDataPed_Click(object sender, EventArgs e)
        {
            Txt_ClienteBuscaPed.Text = "";
            Txt_BuscaNumeroPedido.Text = "";
            Cbo_TipoFrete.Text = "[Selecione]";
            if (Date_DataMaximaPed.Value < Date_DataMinimaPed.Value)
            {
                MessageBox.Show("A Data Máxima não pode ser menor que a Data Mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorDataPedido(Convert.ToDateTime(Date_DataMinimaPed.Value),
                Convert.ToDateTime(Date_DataMaximaPed.Value));
        }

        private void BuscaPorFrete(DateTime dataMinimaPed, DateTime dataMaximaPed, string tipoFrete)
        {
            string stringDataMinimaPed = dataMinimaPed.ToString("yyyy-MM-dd");
            string stringDataMaximaPed = dataMaximaPed.ToString("yyyy-MM-dd");
            PreencherColumnHeader();
            PreencherListView_BuscaPorFrete(stringDataMinimaPed, stringDataMaximaPed, tipoFrete);
            LstView_ListaPed.View = System.Windows.Forms.View.Details;
        }
        private void BuscarPorDataPedido(DateTime dataMinimaPed, DateTime dataMaximaPed)
        {
            string stringDataMinimaPed = dataMinimaPed.ToString("yyyy-MM-dd");
            string stringDataMaximaPed = dataMaximaPed.ToString("yyyy-MM-dd");
            PreencherColumnHeader();
            PreencherListView_DataPedido(stringDataMinimaPed, stringDataMaximaPed);
            LstView_ListaPed.View = System.Windows.Forms.View.Details;
        }
        private void BuscarPorNumeroPedido(int numeroPedido)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_NumeroPedido(numeroPedido);
            LstView_ListaPed.View = System.Windows.Forms.View.Details;
        }
        private void BuscarPorNomeClienteCachorro(string nomeClienteBuscaPed)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_NomeClienteCachorro(nomeClienteBuscaPed);
            LstView_ListaPed.View = System.Windows.Forms.View.Details;
        }
        private void FormListarPedido_Load(object sender, EventArgs e)
        {
            LimparFormLista();
            Date_DataMinimaPed.Value = DateTime.Today;
            Cbo_TipoFrete.Items.Clear();
            PreencherCombobox();
            Cbo_TipoFrete.Text = "[Selecione]";
        }

        private void PreencherCombobox()
        {
            Cbo_TipoFrete.Items.Add("[Selecione]");
            Cbo_TipoFrete.Items.Add("Próprio");
            Cbo_TipoFrete.Items.Add("Terceiro");
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

            columnHeader1.Text = "Número do Pedido";
            columnHeader2.Text = "Nome do Cliente";
            columnHeader3.Text = "Nome do Cachorro";
            columnHeader4.Text = "Total da Venda";
            columnHeader5.Text = "Tipo de Frete";
            columnHeader6.Text = "Frete";
            columnHeader7.Text = "Data do Pedido";
            columnHeader8.Text = "Entrega";
            columnHeader9.Text = "Lucro";
            columnHeader10.Text = "% Lucro";

            LstView_ListaPed.Columns.Add(columnHeader1);
            LstView_ListaPed.Columns.Add(columnHeader2);
            LstView_ListaPed.Columns.Add(columnHeader3);
            LstView_ListaPed.Columns.Add(columnHeader4);
            LstView_ListaPed.Columns.Add(columnHeader5);
            LstView_ListaPed.Columns.Add(columnHeader6);
            LstView_ListaPed.Columns.Add(columnHeader7);
            LstView_ListaPed.Columns.Add(columnHeader8);
            LstView_ListaPed.Columns.Add(columnHeader9);
            LstView_ListaPed.Columns.Add(columnHeader10);

            LstView_ListaPed.GridLines = true;
        }

        private void PreencherListView_BuscaPorFrete(string dataMinimaPed, string dataMaximaPed, string tipoFrete)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PedidoController listarPedido = new PedidoController();
            int resultadoBusca = listarPedido.ConsultarPedidoPorTipoFrete(dataMinimaPed, dataMaximaPed, tipoFrete).Count;
            double somaFreteTotal = 0;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarPedido.ConsultarPedidoPorTipoFrete(dataMinimaPed, dataMaximaPed, tipoFrete))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPedido.ToString(), item.cliente.nomeCliente.ToString(),
                    item.cliente.nomeCachorro.ToString(), "R$" + item.valorVenda.ToString(), item.tipoFrete,
                    item.frete == 0 ? "" : "R$" + item.frete.ToString(), item.dataPedido.Date.ToString("dd-MM-yyyy"),
                    item.entrega.ToString(), "R$" + item.lucro.ToString(), item.porcentagemLucro.ToString() + "%"});
                    LstView_ListaPed.Items.Add(listViewItem);

                    Label_CalculaQuantidade.Text = Convert.ToString(LstView_ListaPed.Items.Count);
                    Label_CalculaFreteTotal.Text = "R$" + (double.Parse(Label_CalculaFreteTotal.Text.Replace("R$", "")) + item.frete).ToString();
                    Label_SomaTotaisVenda.Text = "R$" + (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) +
                        (item.valorVenda - item.frete)).ToString();
                    Label_SomaTotalLucro.Text = "R$" + (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) + item.lucro).ToString();
                    Label_CalculaPorcMedia.Text = (double.Parse(Label_CalculaPorcMedia.Text.Replace("%", "")) + item.porcentagemLucro).ToString();
                    somaFreteTotal = somaFreteTotal + item.frete;
                }

                Label_CalculaPorcMedia.Text = (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) /
                    (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) - somaFreteTotal) * 100).ToString("N2") + "%";
            }
        }
        private void PreencherListView_DataPedido(string dataMinimaPed, string dataMaximaPed)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PedidoController listarPedido = new PedidoController();
            int resultadoBusca = listarPedido.ConsultarPedidoPorData(dataMinimaPed, dataMaximaPed).Count;
            double somaFreteTotal = 0;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarPedido.ConsultarPedidoPorData(dataMinimaPed, dataMaximaPed))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPedido.ToString(), item.cliente.nomeCliente.ToString(),
                    item.cliente.nomeCachorro.ToString(), "R$" + item.valorVenda.ToString(), item.tipoFrete,
                    item.frete == 0 ? "" : "R$" + item.frete.ToString(), item.dataPedido.Date.ToString("dd-MM-yyyy"), 
                    item.entrega.ToString(), "R$" + item.lucro.ToString(), item.porcentagemLucro.ToString() + "%"});
                    LstView_ListaPed.Items.Add(listViewItem);

                    Label_CalculaQuantidade.Text = Convert.ToString(LstView_ListaPed.Items.Count);
                    Label_CalculaFreteTotal.Text = "R$" + (double.Parse(Label_CalculaFreteTotal.Text.Replace("R$", "")) + item.frete).ToString();
                    Label_SomaTotaisVenda.Text = "R$" + (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) + 
                        (item.valorVenda - item.frete)).ToString();
                    Label_SomaTotalLucro.Text = "R$" + (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) + item.lucro).ToString();
                    Label_CalculaPorcMedia.Text = (double.Parse(Label_CalculaPorcMedia.Text.Replace("%", "")) + item.porcentagemLucro).ToString();
                    somaFreteTotal = somaFreteTotal + item.frete;
                }

                Label_CalculaPorcMedia.Text = (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) /
                    (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) - somaFreteTotal) * 100).ToString("N2") + "%";
            }
        }

        private void PreencherListView_NumeroPedido(int numeroPedido)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PedidoController listarPedido = new PedidoController();
            int resultadoBusca = listarPedido.ConsultarPedidoPorNumeroPedido(numeroPedido).Count;
            double somaFreteTotal = 0;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este número de pedido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarPedido.ConsultarPedidoPorNumeroPedido(numeroPedido))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPedido.ToString(), item.cliente.nomeCliente.ToString(),
                    item.cliente.nomeCachorro.ToString(), "R$" + item.valorVenda.ToString(), item.tipoFrete,
                    item.frete == 0 ? "" : "R$" + item.frete.ToString(), item.dataPedido.Date.ToString("dd-MM-yyyy"), 
                    item.entrega.ToString(), "R$" + item.lucro.ToString(), item.porcentagemLucro.ToString() + "%"});
                    LstView_ListaPed.Items.Add(listViewItem);

                    Label_CalculaQuantidade.Text = Convert.ToString(LstView_ListaPed.Items.Count);
                    Label_CalculaFreteTotal.Text = "R$" + (double.Parse(Label_CalculaFreteTotal.Text.Replace("R$", "")) + item.frete).ToString();
                    Label_SomaTotaisVenda.Text = "R$" + (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) + 
                        (item.valorVenda - item.frete)).ToString();
                    Label_SomaTotalLucro.Text = "R$" + (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) + item.lucro).ToString();
                    Label_CalculaPorcMedia.Text = (double.Parse(Label_CalculaPorcMedia.Text.Replace("%", "")) + item.porcentagemLucro).ToString();
                    somaFreteTotal = somaFreteTotal + item.frete;
                }

                Label_CalculaPorcMedia.Text = (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) /
                    (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) - somaFreteTotal) * 100).ToString("N2") + "%";
            }
        }

        private void PreencherListView_NomeClienteCachorro(string nomeClienteBuscaPed)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PedidoController listarPedido = new PedidoController();
            int resultadoBusca = listarPedido.ConsultarPedidoPorNomeCliente(nomeClienteBuscaPed).Count;
            double somaFreteTotal = 0;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este nome!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarPedido.ConsultarPedidoPorNomeCliente(nomeClienteBuscaPed))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idPedido.ToString(), item.cliente.nomeCliente.ToString(),
                    item.cliente.nomeCachorro.ToString(), "R$" + item.valorVenda.ToString(), item.tipoFrete,
                    item.frete == 0 ? "" : "R$" + item.frete.ToString(), item.dataPedido.Date.ToString("dd-MM-yyyy"),
                    item.entrega.ToString(), "R$" + item.lucro.ToString(), item.porcentagemLucro.ToString() + "%"});
                    LstView_ListaPed.Items.Add(listViewItem);

                    Label_CalculaQuantidade.Text = Convert.ToString(LstView_ListaPed.Items.Count);
                    Label_CalculaFreteTotal.Text = "R$" + (double.Parse(Label_CalculaFreteTotal.Text.Replace("R$", "")) + item.frete).ToString();
                    Label_SomaTotaisVenda.Text = "R$" + (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) + 
                        (item.valorVenda - item.frete)).ToString();
                    Label_SomaTotalLucro.Text = "R$" + (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) + item.lucro).ToString();
                    Label_CalculaPorcMedia.Text = (double.Parse(Label_CalculaPorcMedia.Text.Replace("%", "")) + item.porcentagemLucro).ToString();
                    somaFreteTotal = somaFreteTotal + item.frete;
                }

                Label_CalculaPorcMedia.Text = (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) /
                    (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) - somaFreteTotal) * 100).ToString("N2") + "%";
            }
        }
        private void Btn_BuscarPorClientePed_Click(object sender, EventArgs e)
        {
            Txt_BuscaNumeroPedido.Text = "";
            Cbo_TipoFrete.Text = "[Selecione]";
            if (Txt_ClienteBuscaPed.Text == "")
            {
               MessageBox.Show("Digite o cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
            else if (IsNome(Txt_ClienteBuscaPed.Text) == false)
            {
                MessageBox.Show("Nome do cliente ou cachorro não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_ClienteBuscaPed.Text.Length > 70)
            {
                MessageBox.Show("Nome do cliente ou cachorro está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BuscarPorNomeClienteCachorro(Txt_ClienteBuscaPed.Text);
        }

        private void Btn_BuscarNumeroPedido_Click(object sender, EventArgs e)
        {
            Txt_ClienteBuscaPed.Text = "";
            Cbo_TipoFrete.Text = "[Selecione]";
            if (Txt_BuscaNumeroPedido.Text == "")
            {
                MessageBox.Show("Digite o número do pedido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsNumero(Txt_BuscaNumeroPedido.Text) == false)
            {
                MessageBox.Show("Número do pedido não contém somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToInt32(Txt_BuscaNumeroPedido.Text) > 7)
            {
                MessageBox.Show("Número do pedido está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numeroPedido = Convert.ToInt32(Txt_BuscaNumeroPedido.Text);

            BuscarPorNumeroPedido(numeroPedido);
        }

        private void Btn_ExcluirPedido_Click(object sender, EventArgs e)
        {
            if (LstView_ListaPed.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_ListaPed.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                double somaFreteTotal = 0;
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    PedidoController listarPedido = new PedidoController();
                    int idPedido = Convert.ToInt32(LstView_ListaPed.SelectedItems[0].SubItems[0].Text);
                    Label_SomaTotaisVenda.Text = "R$0,00";
                    Label_SomaTotalLucro.Text = "R$0,00";
                    Label_CalculaPorcMedia.Text = "0%";
                    Label_CalculaFreteTotal.Text = "R$0,00";
                    listarPedido.ExcluirPedido(idPedido);                    
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaPed.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaPed.SelectedItems[i];
                        LstView_ListaPed.Items.Remove(lstRemove);
                    }

                    LstView_ListaPed.Refresh();
                    Label_CalculaQuantidade.Text = Convert.ToString(LstView_ListaPed.Items.Count);
                    for (int item = 0; item < LstView_ListaPed.Items.Count; item++)
                    {
                        Label_CalculaFreteTotal.Text = "R$" + (double.Parse(Label_CalculaFreteTotal.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture) + 
                            (LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".").ToString() == "" ? 0 : 
                            double.Parse(LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".")))).ToString();
                        Label_SomaTotaisVenda.Text = "R$" + (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", ""), CultureInfo.InvariantCulture) + 
                            double.Parse(LstView_ListaPed.Items[item].SubItems[3].Text.Replace("R$", ""), CultureInfo.InvariantCulture) -
                            (LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".").ToString() == "" ? 0 :
                            double.Parse(LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".")))).ToString();
                        Label_SomaTotalLucro.Text = "R$" + (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "").Replace(",", ".")) + 
                            double.Parse(LstView_ListaPed.Items[item].SubItems[8].Text.Replace("R$", ""), CultureInfo.InvariantCulture)).ToString(); ;
                        Label_CalculaPorcMedia.Text = (double.Parse(Label_CalculaPorcMedia.Text.Replace("%", "").Replace(",", ".")) + 
                            double.Parse(LstView_ListaPed.Items[item].SubItems[9].Text.Replace("%", ""), CultureInfo.InvariantCulture)).ToString();
                        somaFreteTotal = somaFreteTotal +
                            (LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".").ToString() == "" ? 0 :
                            double.Parse(LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".")));
                }
                }
                if (Convert.ToInt32(Label_CalculaQuantidade.Text) <= 0)
                    Label_CalculaPorcMedia.Text = "0%";
                else
                    Label_CalculaPorcMedia.Text = (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) /
                    (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) - somaFreteTotal) * 100).ToString("N2") + "%";

            }
            else
                return;
        }
        private void LimparFormLista()
        {
            LstView_ListaPed.Columns.Clear();
            LstView_ListaPed.Items.Clear();
            LstView_ListaPed.FullRowSelect = true;
            Label_CalculaFreteTotal.Text = "R$0,00";
            Label_CalculaQuantidade.Text = "0";
            Label_SomaTotaisVenda.Text = "R$0,00";
            Label_SomaTotalLucro.Text = "R$0,00";
            Label_CalculaPorcMedia.Text = "0%";
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
                if (!Char.IsNumber(strNumero, i))
                    return false;
            }
            return true;
        }

        private void Btn_DetalhesPedido_Click(object sender, EventArgs e)
        {
            if (LstView_ListaPed.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LstView_ListaPed.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PedidoController listarPedido = new PedidoController();
            List<Pedido> pedidosSelecionados = new List<Pedido>();
            int idPedido = Convert.ToInt32(LstView_ListaPed.SelectedItems[0].SubItems[0].Text);

            foreach (var item in listarPedido.ConsultarItensPedidoPorIdPedido(idPedido))
            {
                Pedido pedido = new Pedido();
                pedido.idPedido = item.idPedido;
                pedido.idClientePed = item.idClientePed;
                pedido.cliente.nomeCliente = item.cliente.nomeCliente;
                pedido.cliente.nomeCachorro = item.cliente.nomeCachorro;
                pedido.idProdutoPed = item.idProdutoPed;
                pedido.produto.quantidade = item.produto.quantidade;
                pedido.produto.descricao = item.produto.descricao;
                pedido.produto.custo = item.produto.custo;
                pedido.custoTotalProduto = item.custoTotalProduto;
                pedido.produto.valorVendaProd = item.produto.valorVendaProd;

                pedidosSelecionados.Add(pedido);
            }

            FormListarItensPedido formListarItensPedido = new FormListarItensPedido(pedidosSelecionados);
            formListarItensPedido.ShowDialog();

            PreencherColumnHeader();
            if (Txt_ClienteBuscaPed.Text != "")
                PreencherListView_NomeClienteCachorro(Txt_ClienteBuscaPed.Text);
            else if (Txt_BuscaNumeroPedido.Text != "")
                PreencherListView_NumeroPedido(Convert.ToInt32(Txt_BuscaNumeroPedido.Text));
            else if (Cbo_TipoFrete.Text != "[Selecione]")
            {
                DateTime dataMinimaPedido = Date_DataMinimaPed.Value;
                DateTime dataMaximaPedido = Date_DataMaximaPed.Value;
                string stringDataMinimaPed = dataMinimaPedido.ToString("yyyy-MM-dd");
                string stringDataMaximaPed = dataMaximaPedido.ToString("yyyy-MM-dd");
                PreencherListView_BuscaPorFrete(stringDataMinimaPed, stringDataMaximaPed, Cbo_TipoFrete.Text);
            }
            else
            {
                DateTime dataMinimaPedido = Date_DataMinimaPed.Value;
                DateTime dataMaximaPedido = Date_DataMaximaPed.Value;
                string stringDataMinimaPed = dataMinimaPedido.ToString("yyyy-MM-dd");
                string stringDataMaximaPed = dataMaximaPedido.ToString("yyyy-MM-dd");
                PreencherListView_DataPedido(stringDataMinimaPed, stringDataMaximaPed);
            }
        }
        private void LstView_ListaPed_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LstView_ListaPed.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (e.KeyCode == Keys.Delete && LstView_ListaPed.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (e.KeyCode == Keys.Delete && MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                double somaFreteTotal = 0;
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    PedidoController listarPedido = new PedidoController();
                    int idPedido = Convert.ToInt32(LstView_ListaPed.SelectedItems[0].SubItems[0].Text);
                    Label_SomaTotaisVenda.Text = "R$0,00";
                    Label_SomaTotalLucro.Text = "R$0,00";
                    Label_CalculaPorcMedia.Text = "0%";
                    Label_CalculaFreteTotal.Text = "R$0,00";
                    listarPedido.ExcluirPedido(idPedido);                    
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaPed.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaPed.SelectedItems[i];
                        LstView_ListaPed.Items.Remove(lstRemove);
                    }

                    LstView_ListaPed.Refresh();
                    Label_CalculaQuantidade.Text = Convert.ToString(LstView_ListaPed.Items.Count);
                    for (int item = 0; item < LstView_ListaPed.Items.Count; item++)
                    {
                        Label_CalculaFreteTotal.Text = "R$" + (double.Parse(Label_CalculaFreteTotal.Text.Replace("R$", "").Replace(",", "."), CultureInfo.InvariantCulture) +
                            (LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".").ToString() == "" ? 0 :
                            double.Parse(LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".")))).ToString();
                        Label_SomaTotaisVenda.Text = "R$" + (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", ""), CultureInfo.InvariantCulture) +
                            double.Parse(LstView_ListaPed.Items[item].SubItems[3].Text.Replace("R$", ""), CultureInfo.InvariantCulture) -
                            (LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".").ToString() == "" ? 0 :
                            double.Parse(LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".")))).ToString();
                        Label_SomaTotalLucro.Text = "R$" + (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "").Replace(",", ".")) +
                            double.Parse(LstView_ListaPed.Items[item].SubItems[8].Text.Replace("R$", ""), CultureInfo.InvariantCulture)).ToString(); ;
                        Label_CalculaPorcMedia.Text = (double.Parse(Label_CalculaPorcMedia.Text.Replace("%", "").Replace(",", ".")) +
                            double.Parse(LstView_ListaPed.Items[item].SubItems[9].Text.Replace("%", ""), CultureInfo.InvariantCulture)).ToString();
                        somaFreteTotal = somaFreteTotal +
                            (LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".").ToString() == "" ? 0 :
                            double.Parse(LstView_ListaPed.Items[item].SubItems[5].Text.Replace("R$", "").Replace(",", ".")));
                    }
                }

                if (Convert.ToInt32(Label_CalculaQuantidade.Text) <= 0)
                    Label_CalculaPorcMedia.Text = "0%";
                else
                    Label_CalculaPorcMedia.Text = (double.Parse(Label_SomaTotalLucro.Text.Replace("R$", "")) /
                    (double.Parse(Label_SomaTotaisVenda.Text.Replace("R$", "")) - somaFreteTotal) * 100).ToString("N2") + "%";
            }
            else
                return;
        }        
    }
}
