using ProjetoCasa.Controller;
using ProjetoCasa.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoCasa
{
    public partial class FormListarCliente : Form
    {
        public FormListarCliente()
        {
            InitializeComponent();
        }

        private void Btn_VoltarCadCli_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            this.Hide();
            this.Close();
            formCliente.ShowDialog();            
        }
        private void BuscarTodosClientes()
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_TodosClientes();
            LstView_ListaCliente.View = System.Windows.Forms.View.Details;
        }
        private void BuscarPorNomeCliente(string nomeCliente)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_NomeCliente(nomeCliente);
            LstView_ListaCliente.View = System.Windows.Forms.View.Details;
        }

        private void BuscarPorNomeCachorro(string nomeCachorro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_NomeCachorro(nomeCachorro);
            LstView_ListaCliente.View = System.Windows.Forms.View.Details;
        }
        private void FormListarCliente_Load(object sender, EventArgs e)
        {
            LimparFormLista();
            LstView_ListaCliente.FullRowSelect = true;
        }

        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();
            ColumnHeader columnHeader6 = new ColumnHeader();

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Nome do Cliente";
            columnHeader3.Text = "Nome do Cachorro";
            columnHeader4.Text = "Telefone";
            columnHeader5.Text = "E-mail";
            columnHeader6.Text = "Endereço";

            LstView_ListaCliente.Columns.Add(columnHeader1);
            LstView_ListaCliente.Columns.Add(columnHeader2);
            LstView_ListaCliente.Columns.Add(columnHeader3);
            LstView_ListaCliente.Columns.Add(columnHeader4);
            LstView_ListaCliente.Columns.Add(columnHeader5);
            LstView_ListaCliente.Columns.Add(columnHeader6);

            LstView_ListaCliente.GridLines = true;
        }

        private void PreencherListView_TodosClientes()
        {
            LimparFormLista();
            PreencherColumnHeader();
            ClienteController listarCliente = new ClienteController();
            int resultadoBusca = listarCliente.ConsultarTodoClienteAtivo().Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este cliente!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarCliente.ConsultarTodoClienteAtivo())
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idCliente.ToString(), item.nomeCliente.ToString(), item.nomeCachorro.ToString(),
                item.telefoneCliente.ToString(), item.emailCliente.ToString(),
                item.enderecoCliente.ToString()});
                    LstView_ListaCliente.Items.Add(listViewItem);
                    Label_CalculaQuantidadeCli.Text = Convert.ToString(LstView_ListaCliente.Items.Count);
                }
            }
        }

        private void PreencherListView_NomeCliente(string nomeCliente)
        {
            LimparFormLista();
            PreencherColumnHeader();
            ClienteController listarCliente = new ClienteController();
            int resultadoBusca = listarCliente.ConsultarClientePorNome(nomeCliente).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este cliente!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarCliente.ConsultarClientePorNome(nomeCliente))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idCliente.ToString(), item.nomeCliente.ToString(), item.nomeCachorro.ToString(),
                item.telefoneCliente.ToString(), item.emailCliente.ToString(),
                item.enderecoCliente.ToString()});
                    LstView_ListaCliente.Items.Add(listViewItem);
                    Label_CalculaQuantidadeCli.Text = Convert.ToString(LstView_ListaCliente.Items.Count);
                }
            }            
        }

        private void PreencherListView_NomeCachorro(string nomeCachorro)
        {
            LimparFormLista();
            PreencherColumnHeader();
            ClienteController listarCachorro = new ClienteController();
            int resultadoBusca = listarCachorro.ConsultarClientePorCachorro(nomeCachorro).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este cachorro!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarCachorro.ConsultarClientePorCachorro(nomeCachorro))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idCliente.ToString(), item.nomeCliente.ToString(), item.nomeCachorro.ToString(),
                item.telefoneCliente.ToString(), item.emailCliente.ToString(),
                item.enderecoCliente.ToString()});
                    LstView_ListaCliente.Items.Add(listViewItem);
                    Label_CalculaQuantidadeCli.Text = Convert.ToString(LstView_ListaCliente.Items.Count);
                }
            }
        }
        private void Btn_BuscarTodosClientes_Click(object sender, EventArgs e)
        {
            BuscarTodosClientes();
        }
        private void Btn_BuscarPorCliente_Click(object sender, EventArgs e)
        {
            Txt_CachorroBusca.Text = "";
            if (Txt_ClienteBusca.Text == "")
            {
                MessageBox.Show("Digite o nome do cliente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsNome(Txt_ClienteBusca.Text) == false)
            {
                MessageBox.Show("Nome do cliente não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_ClienteBusca.Text.Length > 70)
            {
                MessageBox.Show("Nome do cliente está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BuscarPorNomeCliente(Txt_ClienteBusca.Text);
        }

        private void Btn_BuscarPorCachorro_Click(object sender, EventArgs e)
        {
            Txt_ClienteBusca.Text = "";
            if (Txt_CachorroBusca.Text == "")
            {
                MessageBox.Show("Digite o nome do cachorro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsNome(Txt_CachorroBusca.Text) == false)
            {
                MessageBox.Show("Nome do cachorro não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_CachorroBusca.Text.Length > 50)
            {
                MessageBox.Show("Nome do cachorro está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            BuscarPorNomeCachorro(Txt_CachorroBusca.Text);
        }

        private void Btn_ExcluirCliente_Click(object sender, EventArgs e)
        {
            if (LstView_ListaCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaCliente.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }         

            else if (MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                PedidoController listarPedido = new PedidoController();
                int idCli = Convert.ToInt32(LstView_ListaCliente.SelectedItems[0].SubItems[0].Text);
                if (listarPedido.ConsultarPedidoPorClienteExclusao(idCli).Count >= 1)
                {
                    MessageBox.Show("Não é possível deletar este cliente, pois ele possui um ou mais pedidos cadastrados. Exclua o pedido para este cliente primeiro.",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ClienteController listarCliente = new ClienteController();
                    int idCliente = Convert.ToInt32(LstView_ListaCliente.SelectedItems[0].SubItems[0].Text);
                    listarCliente.ExcluirCliente(idCliente);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaCliente.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaCliente.SelectedItems[i];
                        LstView_ListaCliente.Items.Remove(lstRemove);
                    }
                    LstView_ListaCliente.Refresh();

                    Label_CalculaQuantidadeCli.Text = Convert.ToString(LstView_ListaCliente.Items.Count);
                }
            }

            else
                return;
        }

        private void LimparFormLista()
        {
            LstView_ListaCliente.Columns.Clear();
            LstView_ListaCliente.Items.Clear();
        }

        private void Btn_EditarCliente_Click(object sender, EventArgs e)
        {
            if (LstView_ListaCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaCliente.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClienteController listarCliente = new ClienteController();
            List<Cliente> clientesSelecionados = new List<Cliente>();
            int idCliente = Convert.ToInt32(LstView_ListaCliente.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarCliente.ConsultarClientePorId(idCliente))
            {
                Cliente cliente = new Cliente();
                cliente.idCliente = item.idCliente;
                cliente.nomeCliente = item.nomeCliente;
                cliente.nomeCachorro = item.nomeCachorro;
                cliente.telefoneCliente = item.telefoneCliente;
                cliente.emailCliente = item.emailCliente;
                cliente.enderecoCliente = item.enderecoCliente;
                cliente.clienteAtivo = item.clienteAtivo;

                clientesSelecionados.Add(cliente);
            }
            
            FormEditarCliente formEditarCliente = new FormEditarCliente(clientesSelecionados);
            formEditarCliente.ShowDialog();

            if (Txt_ClienteBusca.Text != "")
                PreencherListView_NomeCliente(Txt_ClienteBusca.Text);
            else
                PreencherListView_NomeCachorro(Txt_CachorroBusca.Text);
        }

        public static bool IsNome(string strNome)
        {
            for (int i = 0; i < strNome.Length; i++)
            {
                if (!Char.IsLetter(strNome, i))
                    return false;
            }
            return true;
        }

        private void LstView_ListaCliente_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete && LstView_ListaCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (e.KeyCode == Keys.Delete && LstView_ListaCliente.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (e.KeyCode == Keys.Delete && MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                PedidoController listarPedido = new PedidoController();
                int idCli = Convert.ToInt32(LstView_ListaCliente.SelectedItems[0].SubItems[0].Text);
                if (listarPedido.ConsultarPedidoPorClienteExclusao(idCli).Count >= 1)
                {
                    MessageBox.Show("Não é possível deletar este cliente, pois ele possui um ou mais pedidos cadastrados. Exclua o pedido para este cliente primeiro.",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ClienteController listarCliente = new ClienteController();
                    int idCliente = Convert.ToInt32(LstView_ListaCliente.SelectedItems[0].SubItems[0].Text);
                    listarCliente.ExcluirCliente(idCliente);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaCliente.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaCliente.SelectedItems[i];
                        LstView_ListaCliente.Items.Remove(lstRemove);
                    }
                    LstView_ListaCliente.Refresh();

                    Label_CalculaQuantidadeCli.Text = Convert.ToString(LstView_ListaCliente.Items.Count);
                }
            }

            else
                return;
        }        
    }
}
