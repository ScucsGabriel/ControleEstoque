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
    public partial class FormListarProduto : Form
    {
        public FormListarProduto()
        {
            InitializeComponent();
        }

        private void Btn_VoltarCadProd_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            this.Hide();
            this.Close();
            formProduto.ShowDialog();
            
        }
        private void BuscarPorDescricao(string descricao)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_Descricao(descricao);
            LstView_ListaProduto.View = System.Windows.Forms.View.Details;
        }
        private void FormListarProduto_Load(object sender, EventArgs e)
        {
            LimparFormLista();
            LstView_ListaProduto.FullRowSelect = true;
        }

        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Descrição";
            columnHeader3.Text = "Custo";
            columnHeader4.Text = "Valor de Venda";

            LstView_ListaProduto.Columns.Add(columnHeader1);
            LstView_ListaProduto.Columns.Add(columnHeader2);
            LstView_ListaProduto.Columns.Add(columnHeader3);
            LstView_ListaProduto.Columns.Add(columnHeader4);


            LstView_ListaProduto.GridLines = true;
        }        

        private void PreencherListView_Descricao(string descricao)
        {
            LimparFormLista();
            PreencherColumnHeader();
            ProdutoController listarProduto = new ProdutoController();
            int resultadoBusca = listarProduto.ConsultarProdutoPorDescricao(descricao).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para esta descrição!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarProduto.ConsultarProdutoPorDescricao(descricao))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idProduto.ToString(), item.descricao.ToString(), "R$" + item.custo.ToString(),
                    "R$" + item.valorVendaProd.ToString()});
                    LstView_ListaProduto.Items.Add(listViewItem);
                    Label_CalculaQuantidadeProd.Text = Convert.ToString(LstView_ListaProduto.Items.Count);
                }
            }            
        }
        private void Btn_BuscarPorProduto_Click(object sender, EventArgs e)
        {
            if (Txt_DescricaoBusca.Text == "")
            {
                MessageBox.Show("Digite a descrição!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_DescricaoBusca.Text.Length > 120)
            {
                MessageBox.Show("Descrição está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorDescricao(Txt_DescricaoBusca.Text);
        }
        private void Btn_ExcluirProduto_Click(object sender, EventArgs e)
        {
            if (LstView_ListaProduto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaProduto.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            else if (MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                PedidoController listarPedido = new PedidoController();
                int idProd = Convert.ToInt32(LstView_ListaProduto.SelectedItems[0].SubItems[0].Text);
                if (listarPedido.ConsultarPedidoPorProdutoExclusao(idProd).Count >= 1)
                {
                    MessageBox.Show("Não é possível deletar este produto, pois ele possui um ou mais pedidos cadastrados. Exclua o pedido para este produto primeiro.",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ProdutoController listarProduto = new ProdutoController();
                    int idProduto = Convert.ToInt32(LstView_ListaProduto.SelectedItems[0].SubItems[0].Text);
                    listarProduto.ExcluirProduto(idProduto);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaProduto.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaProduto.SelectedItems[i];
                        LstView_ListaProduto.Items.Remove(lstRemove);
                    }
                    LstView_ListaProduto.Refresh();

                    Label_CalculaQuantidadeProd.Text = Convert.ToString(LstView_ListaProduto.Items.Count);
                }
            }

            else
                return;
        }
        private void LimparFormLista()
        {
            LstView_ListaProduto.Columns.Clear();
            LstView_ListaProduto.Items.Clear();
        }
        private void Btn_EditarProduto_Click(object sender, EventArgs e)
        {
            if (LstView_ListaProduto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaProduto.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProdutoController listarProduto = new ProdutoController();
            List<Produto> produtosSelecionados = new List<Produto>();
            int idProduto = Convert.ToInt32(LstView_ListaProduto.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarProduto.ConsultarProdutoPorId(idProduto))
            {
                Produto produto = new Produto();
                produto.idProduto = item.idProduto;
                produto.descricao = item.descricao;
                produto.custo = item.custo;
                produto.valorVendaProd = item.valorVendaProd;
                produto.produtoAtivo = item.produtoAtivo;

                produtosSelecionados.Add(produto);
            }

            FormEditarProduto formEditarProduto = new FormEditarProduto(produtosSelecionados);
            formEditarProduto.ShowDialog();

            if (Txt_DescricaoBusca.Text != "")
                PreencherListView_Descricao(Txt_DescricaoBusca.Text);
            else
                PreencherListView_Todos();
        }
        private void LstView_ListaProduto_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LstView_ListaProduto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (e.KeyCode == Keys.Delete && LstView_ListaProduto.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (e.KeyCode == Keys.Delete && MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                PedidoController listarPedido = new PedidoController();
                int idProd = Convert.ToInt32(LstView_ListaProduto.SelectedItems[0].SubItems[0].Text);
                if (listarPedido.ConsultarPedidoPorProdutoExclusao(idProd).Count >= 1)
                {
                    MessageBox.Show("Não é possível deletar este produto, pois ele possui um ou mais pedidos cadastrados. Exclua o pedido para este produto primeiro.",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ProdutoController listarProduto = new ProdutoController();
                    int idProduto = Convert.ToInt32(LstView_ListaProduto.SelectedItems[0].SubItems[0].Text);
                    listarProduto.ExcluirProduto(idProduto);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaProduto.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaProduto.SelectedItems[i];
                        LstView_ListaProduto.Items.Remove(lstRemove);
                    }
                    LstView_ListaProduto.Refresh();

                    Label_CalculaQuantidadeProd.Text = Convert.ToString(LstView_ListaProduto.Items.Count);
                }
            }

            else
                return;
        }

        private void Btn_BuscarTodos_Click(object sender, EventArgs e)
        {
            BuscarTodos();
        }

        private void BuscarTodos()
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_Todos();
            LstView_ListaProduto.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_Todos()
        {
            LimparFormLista();
            PreencherColumnHeader();
            ProdutoController listarProduto = new ProdutoController();
            int resultadoBusca = listarProduto.ConsultarTodoProduto().Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para esta descrição!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarProduto.ConsultarTodoProduto())
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idProduto.ToString(), item.descricao.ToString(), "R$" + item.custo.ToString(),
                    "R$" + item.valorVendaProd.ToString()});
                    LstView_ListaProduto.Items.Add(listViewItem);
                    Label_CalculaQuantidadeProd.Text = Convert.ToString(LstView_ListaProduto.Items.Count);
                }
            }
        }
    }
}
