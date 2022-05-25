using ProjetoCasa.Controller;
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
using System.Windows.Resources;

namespace ProjetoCasa
{
    public partial class FormDespesa : Form
    {
        public FormDespesa()
        {
            InitializeComponent();
        }
        private void Btn_SalvarDespesa_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            if (Date_DataCartao.Text == " ")
                Date_DataCartao.Value = Convert.ToDateTime("1753-01-01");

            string despesaAtiva = "Sim";

            DespesaController inserirDespesa = new DespesaController();
            string formatadorValorDespesa = Msk_ValorDespesa.Text.Replace(" ", "").Replace("R$", "").Trim();
            double valorDespesa = double.Parse(formatadorValorDespesa, CultureInfo.InvariantCulture);

            inserirDespesa.InserirDespesa(Convert.ToDateTime(Date_Datas.Value), 
                Txt_Despesa.Text.Trim(), valorDespesa, Cbo_FormaPgto.Text, Cbo_RespCartao.Text, 
                Convert.ToDateTime(Date_DataCartao.Value), Cbo_StatusPgtoDesp.Text.Trim(), despesaAtiva);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void Limpar()
        {
            Date_Datas.Value = DateTime.Now;
            Txt_Despesa.Text = "";
            Msk_ValorDespesa.Text = "";
            Cbo_FormaPgto.Text = "[Selecione]";
            Cbo_RespCartao.Items.Clear();
            ZerarCampoData();
            Date_DataCartao.Enabled = false;
            Cbo_StatusPgtoDesp.Text = "[Selecione]";
        }
        private void Btn_ListarDespesa_Click(object sender, EventArgs e)
        {
            FormListarDespesa formListarDespesa = new FormListarDespesa();
            formListarDespesa.ShowDialog();
            this.Close();
        }
        private bool ValidarPreenchimento()
        {
            if (Txt_Despesa.Text == "")
            {
                MessageBox.Show("Despesa está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Despesa.Text.Length > 70)
            {
                MessageBox.Show("Despesa está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Msk_ValorDespesa.Text == "R$     .")
            {
                MessageBox.Show("Valor da venda está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_FormaPgto.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione a forma de pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbo_FormaPgto.Text == "Crédito" && Date_DataCartao.Text == " ")
            {
                MessageBox.Show("Selecione a data do cartão de crédito.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Date_DataCartao.Value == Convert.ToDateTime("1753-01-01") && Cbo_FormaPgto.Text == "Crédito")
            {
                MessageBox.Show("Verifique a data do cartão de crédito.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if ((Cbo_RespCartao.Text == "" || Cbo_RespCartao.Text == "[Selecione]") && Cbo_FormaPgto.Text == "Crédito")
            {
                MessageBox.Show("Escolha um responsável do cartão.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (Cbo_StatusPgtoDesp.Text == "[Selecione]")
            {
                MessageBox.Show("Selecione o status do pagamento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FormDespesa_Load(object sender, EventArgs e)
        {
            Cbo_FormaPgto.Items.Clear();
            Cbo_RespCartao.Items.Clear();
            Cbo_StatusPgtoDesp.Items.Clear();
            PreencherCombobox();
            Cbo_FormaPgto.Text = "[Selecione]";
            Cbo_RespCartao.Text = "[Selecione]";
            Cbo_StatusPgtoDesp.Text = "[Selecione]";
            Date_DataCartao.Format = DateTimePickerFormat.Custom;
            Date_DataCartao.CustomFormat = " ";
        }

        private void PreencherCombobox()
        {
            Cbo_FormaPgto.Items.Add("[Selecione]");
            Cbo_FormaPgto.Items.Add("Dinheiro");
            Cbo_FormaPgto.Items.Add("Débito");
            Cbo_FormaPgto.Items.Add("Crédito");
            Cbo_RespCartao.Items.Add("[Selecione]");
            Cbo_RespCartao.Items.Add("Adilson");
            Cbo_RespCartao.Items.Add("Ariane");
            Cbo_RespCartao.Items.Add("Gabriel");
            Cbo_RespCartao.Items.Add("Guilherme");
            Cbo_RespCartao.Items.Add("Rosimar");
            Cbo_StatusPgtoDesp.Items.Add("[Selecione]");
            Cbo_StatusPgtoDesp.Items.Add("Não Pago");
            Cbo_StatusPgtoDesp.Items.Add("Pago");
        }

        private void PreencherComboboxRespCartao()
        {
            Cbo_RespCartao.Items.Add("[Selecione]");
            Cbo_RespCartao.Items.Add("Adilson");
            Cbo_RespCartao.Items.Add("Ariane");
            Cbo_RespCartao.Items.Add("Gabriel");
            Cbo_RespCartao.Items.Add("Guilherme");
            Cbo_RespCartao.Items.Add("Rosimar");
        }

        private void Date_DataCartao_DropDown(object sender, EventArgs e)
        {
            Date_DataCartao.Format = DateTimePickerFormat.Short;
        }
        private void ZerarCampoData()
        {
            Date_DataCartao.Format = DateTimePickerFormat.Custom;
            Date_DataCartao.CustomFormat = " ";
        }
        private void Cbo_FormaPgto_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(Cbo_FormaPgto.SelectedItem) == "Crédito")
            {
                PreencherComboboxRespCartao();
                Cbo_RespCartao.Text = "[Selecione]";
                Date_DataCartao.Enabled = true;
                Cbo_RespCartao.Enabled = true;
            }
            else
            {
                Cbo_RespCartao.Items.Clear();
                ZerarCampoData();
                Date_DataCartao.Enabled = false;                
                Cbo_RespCartao.Enabled = false;                
            }
        }
        private void Msk_ValorDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod)
            {
                string buscaPonto = Msk_ValorDespesa.Text;
                int resultado = buscaPonto.IndexOf(".");
                Msk_ValorDespesa.SelectionStart = resultado;
            }
        }
    }
}
