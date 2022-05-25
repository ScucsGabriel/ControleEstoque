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
    public partial class FormEditarDespesa : Form
    {
        private string formaPagamento;
        private string responsavelCartao;
        private string statusPagamento;
        private double valorDespesa;
        public FormEditarDespesa(List<Despesa> listaDespesa)
        {
            InitializeComponent();
            foreach (var item in listaDespesa)
            {
                Label_CodigoDespesa.Text = item.idDespesa.ToString();
                Date_DatasEdit.Value = item.datas;
                Txt_DespesaEdit.Text = item.despesa;
                valorDespesa = item.valorDespesa;
                Msk_ValorDespesaEdit.Text = item.valorDespesa.ToString();
                while (double.Parse(Msk_ValorDespesaEdit.Text.Replace(" ", "").Replace("R$", ""), CultureInfo.InvariantCulture) != valorDespesa)
                {
                    Msk_ValorDespesaEdit.Text = " " + Msk_ValorDespesaEdit.Text;
                }
                formaPagamento = item.formaPagamento;
                responsavelCartao = item.responsavelCartao;
                Date_DataCartaoEdit.Value = Convert.ToDateTime(item.dataCartao);
                statusPagamento = item.statusPagamento;
            }
        }
        private void Btn_SalvarEditDespesa_Click(object sender, EventArgs e)
        {
            if(!ValidarPreenchimento())
                return;

            if (Date_DataCartaoEdit.Text == " ")
                Date_DataCartaoEdit.Value = Convert.ToDateTime("1753-01-01");

            string formatadorValorDespesa = Msk_ValorDespesaEdit.Text.Replace(" ", "").Replace("R$", "").Trim();
            double valorDespesa = double.Parse(formatadorValorDespesa, CultureInfo.InvariantCulture);

            DespesaController editarDespesa = new DespesaController();
            editarDespesa.EditarDespesa(Convert.ToInt32(Label_CodigoDespesa.Text), Convert.ToDateTime(Date_DatasEdit.Value), 
                Txt_DespesaEdit.Text.Trim(), valorDespesa, Cbo_FormaPgtoEdit.Text, Cbo_RespCartaoEdit.Text,
                Convert.ToDateTime(Date_DataCartaoEdit.Value), Cbo_StatusPgtoDespEdit.Text);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Limpar()
        {
            Cbo_RespCartaoEdit.Items.Clear();
            Date_DatasEdit.Value = DateTime.Now;
            Txt_DespesaEdit.Text = "";
            Msk_ValorDespesaEdit.Text = "";
            Cbo_FormaPgtoEdit.Text = "[Selecione]";
            ZerarCampoData();
            Date_DataCartaoEdit.Enabled = false;
            Cbo_StatusPgtoDespEdit.Text = "[Selecione]";
        }
        private bool ValidarPreenchimento()
        {
            if (Txt_DespesaEdit.Text == "")
            {
                MessageBox.Show("Despesa está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_DespesaEdit.Text.Length > 70)
            {
                MessageBox.Show("Despesa está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Msk_ValorDespesaEdit.Text == "R$     .")
            {
                MessageBox.Show("Valor da venda está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_FormaPgtoEdit.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione a forma de pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_FormaPgtoEdit.Text == "Crédito" && Date_DataCartaoEdit.Text == " ")
            {
                MessageBox.Show("Selecione a data do cartão de crédito.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Date_DataCartaoEdit.Value == Convert.ToDateTime("1753-01-01") && Cbo_FormaPgtoEdit.Text == "Crédito")
            {
                MessageBox.Show("Verifique a data do cartão de crédito.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if ((Cbo_RespCartaoEdit.Text == "" || Cbo_RespCartaoEdit.Text == "[Selecione]") && Cbo_FormaPgtoEdit.Text == "Crédito")
            {
                MessageBox.Show("Escolha um responsável do cartão.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (Cbo_StatusPgtoDespEdit.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o status do pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FormEditarDespesa_Load(object sender, EventArgs e)
        {
            Cbo_FormaPgtoEdit.Items.Clear();
            Cbo_RespCartaoEdit.Items.Clear();
            Cbo_StatusPgtoDespEdit.Items.Clear();
            PreencherCombobox();
            Cbo_FormaPgtoEdit.Text = formaPagamento;
            Cbo_RespCartaoEdit.Text = responsavelCartao;
            Cbo_StatusPgtoDespEdit.Text = statusPagamento;
        }

        private void PreencherCombobox()
        {
            Cbo_FormaPgtoEdit.Items.Add("[Selecione]");
            Cbo_FormaPgtoEdit.Items.Add("Dinheiro");
            Cbo_FormaPgtoEdit.Items.Add("Débito");
            Cbo_FormaPgtoEdit.Items.Add("Crédito");
            Cbo_StatusPgtoDespEdit.Items.Add("[Selecione]");
            Cbo_StatusPgtoDespEdit.Items.Add("Não Pago");
            Cbo_StatusPgtoDespEdit.Items.Add("Pago");
        }

        private void PreencherComboboxRespCartao()
        {
            Cbo_RespCartaoEdit.Items.Add("[Selecione]");
            Cbo_RespCartaoEdit.Items.Add("Adilson");
            Cbo_RespCartaoEdit.Items.Add("Ariane");
            Cbo_RespCartaoEdit.Items.Add("Gabriel");
            Cbo_RespCartaoEdit.Items.Add("Guilherme");
            Cbo_RespCartaoEdit.Items.Add("Rosimar");
        }
        private void Date_DataCartaoEdit_DropDown(object sender, EventArgs e)
        {
            Date_DataCartaoEdit.Format = DateTimePickerFormat.Short;
            Date_DataCartaoEdit.Refresh();
        }
        private void ZerarCampoData()
        {
            Date_DataCartaoEdit.Format = DateTimePickerFormat.Custom;
            Date_DataCartaoEdit.CustomFormat = " ";
            Date_DataCartaoEdit.Refresh();
        }

        private void Cbo_FormaPgtoEdit_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(Cbo_FormaPgtoEdit.SelectedItem) == null || Convert.ToString(Cbo_FormaPgtoEdit.SelectedItem) == "")
                return;
            if (Convert.ToString(Cbo_FormaPgtoEdit.SelectedItem) == "Crédito")
            {
                PreencherComboboxRespCartao();
                Cbo_RespCartaoEdit.Text = "[Selecione]";
                Date_DataCartaoEdit.Enabled = true;
                Cbo_RespCartaoEdit.Enabled = true;
            }
            else
            {
                Cbo_RespCartaoEdit.Items.Clear();              
                ZerarCampoData();
                Date_DataCartaoEdit.Enabled = false;                
                Cbo_RespCartaoEdit.Enabled = false;
            }
        }

        private void Msk_ValorDespesaEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_ValorDespesaEdit.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_ValorDespesaEdit.SelectionStart = resultado;
            }
        }
    }
}
