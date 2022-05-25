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
    public partial class FormListarItensPedido : Form
    {
        public FormListarItensPedido(List<Pedido> listaItensPedido)
        {                        
            InitializeComponent();
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_ItensPedido(listaItensPedido);
            LstView_ListaItensPed.View = System.Windows.Forms.View.Details;
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
            columnHeader2.Text = "Produto";
            columnHeader3.Text = "Quantidade";
            columnHeader4.Text = "Custo Unitário";
            columnHeader5.Text = "Custo Total";
            columnHeader6.Text = "Valor de Venda Unitário";
            columnHeader7.Text = "Valor de Venda Total";
            columnHeader8.Text = "Lucro Unitário";
            columnHeader9.Text = "Lucro Total";
            columnHeader10.Text = "% Lucro";

            LstView_ListaItensPed.Columns.Add(columnHeader1);
            LstView_ListaItensPed.Columns.Add(columnHeader2);
            LstView_ListaItensPed.Columns.Add(columnHeader3);
            LstView_ListaItensPed.Columns.Add(columnHeader4);
            LstView_ListaItensPed.Columns.Add(columnHeader5);
            LstView_ListaItensPed.Columns.Add(columnHeader6);
            LstView_ListaItensPed.Columns.Add(columnHeader7);
            LstView_ListaItensPed.Columns.Add(columnHeader8);
            LstView_ListaItensPed.Columns.Add(columnHeader9);
            LstView_ListaItensPed.Columns.Add(columnHeader10);

            LstView_ListaItensPed.GridLines = true;
        }
        private void PreencherListView_ItensPedido(List<Pedido> listaItensPedido)
        {
            int idPedido = listaItensPedido[0].idPedido;
            double frete = 0;
            PedidoController listarPedido = new PedidoController();
            foreach (var item in listarPedido.ConsultarItensPedidoPorIdPedidoLista(idPedido))
            {
              ListViewItem listViewItem = new ListViewItem(new[]
                {item.idPedido.ToString(), item.produto.descricao.ToString(), item.produto.quantidade.ToString(),
                "R$" + item.custoUnitarioProd.ToString(), "R$" + item.custoTotalProduto.ToString(),
                "R$" + item.valorVendaUnitarioProd.ToString(), "R$" + item.valorVendaTotalProd.ToString(),
                "R$" + (item.valorVendaUnitarioProd - item.custoUnitarioProd).ToString("F2"),
                "R$" + (item.valorVendaTotalProd - item.custoTotalProduto).ToString("F2"),
                item.valorVendaUnitarioProd - item.custoUnitarioProd == 0 ? "0%" : 
                (((item.valorVendaUnitarioProd - item.custoUnitarioProd) / item.valorVendaUnitarioProd) * 100).ToString("F2") + "%"});
                LstView_ListaItensPed.Items.Add(listViewItem);

                Label_CalculaQuantidadeItens.Text = (Convert.ToInt32(Label_CalculaQuantidadeItens.Text) + item.produto.quantidade).ToString();
                Label_SomaCustoTotal.Text = "R$" + (double.Parse(Label_SomaCustoTotal.Text.Replace("R$", "")) + item.custoTotalProduto).ToString();
                Label_SomaVendaTotal.Text = "R$" + (double.Parse(Label_SomaVendaTotal.Text.Replace("R$", "")) + item.valorVendaTotalProd).ToString();
                Label_SomaLucroTotal.Text = "R$" + (double.Parse(Label_SomaLucroTotal.Text.Replace("R$", "")) +
                    (double.Parse(listViewItem.SubItems[8].Text.Replace("R$", "")))).ToString();
            }

            if(frete != 0)
                Label_CalculoPorcMediaLucro.Text = (((double.Parse(Label_SomaLucroTotal.Text.Replace("R$", ""))) /
                    (double.Parse(Label_SomaVendaTotal.Text.Replace("R$", "")) - frete)) * 100).ToString("F2") + "%";
            else
                Label_CalculoPorcMediaLucro.Text = (((double.Parse(Label_SomaLucroTotal.Text.Replace("R$", ""))) /
                        double.Parse(Label_SomaVendaTotal.Text.Replace("R$", ""))) * 100).ToString("F2") + "%";
        }        
        private void LimparFormLista()
        {
            LstView_ListaItensPed.Columns.Clear();
            LstView_ListaItensPed.Items.Clear();
            LstView_ListaItensPed.FullRowSelect = true;
        }
        private void Btn_EditarPedido_Click(object sender, EventArgs e)
        {
            PedidoController listarPedido = new PedidoController();
            List<Pedido> pedidosSelecionados = new List<Pedido>();
            int idPedido = Convert.ToInt32(LstView_ListaItensPed.Items[0].SubItems[0].Text);

            foreach (var item in listarPedido.ConsultarPedidoPorId(idPedido))
            {
                Pedido pedido = new Pedido();
                pedido.idPedido = item.idPedido;
                pedido.idClientePed = item.idClientePed;
                pedido.cliente.nomeCliente = item.cliente.nomeCliente;
                pedido.cliente.nomeCachorro = item.cliente.nomeCachorro;
                pedido.idProdutoPed = item.idProdutoPed;
                pedido.custoUnitarioProd = item.custoUnitarioProd;
                pedido.produto.descricao = item.produto.descricao;
                pedido.produto.quantidade = item.produto.quantidade;
                pedido.valorVendaUnitarioProd = item.valorVendaUnitarioProd;
                pedido.dataPedido = item.dataPedido;
                pedido.custoTotalProduto = item.custoTotalProduto;
                pedido.valorVenda = item.valorVenda;
                pedido.tipoFrete = item.tipoFrete;
                pedido.frete = item.frete;
                pedido.entrega = item.entrega;

                pedidosSelecionados.Add(pedido);
            }

            FormEditarPedido formEditarPedido = new FormEditarPedido(pedidosSelecionados);
            formEditarPedido.ShowDialog();

            LstView_ListaItensPed.Items.Clear();
            Label_CalculaQuantidadeItens.Text = "0";
            Label_SomaCustoTotal.Text = "R$0,00";
            Label_SomaVendaTotal.Text = "R$0,00";
            Label_SomaLucroTotal.Text = "R$0,00";
            Label_CalculoPorcMediaLucro.Text = "0%";
            PreencherListView_ItensPedido(pedidosSelecionados);
        }
        private void FormListarItensPedido_Load(object sender, EventArgs e)
        {
            LstView_ListaItensPed.FullRowSelect = true;
        }
    }
}
