using ProjetoCasa.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCasa
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }          

        private void Btn_SalvarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string respostaAtivo = "Sim";
            ClienteController inserirCliente = new ClienteController();
            inserirCliente.InserirCliente(Txt_NomeCliente.Text.Trim(), Txt_NomeCachorro.Text.Trim(), Masked_Telefone.Text.Trim(),
                Txt_EmailCliente.Text.Trim(),  Txt_EnderecoCliente.Text.Trim(), respostaAtivo);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void Limpar()
        {
            Txt_NomeCliente.Text = "";
            Txt_NomeCachorro.Text = "";
            Masked_Telefone.Text = "";
            Txt_EmailCliente.Text = "";
            Txt_EnderecoCliente.Text = "";
        }

        private void Btn_ListarCliente_Click(object sender, EventArgs e)
        {
            FormListarCliente formListarCliente = new FormListarCliente();
            formListarCliente.ShowDialog();
            this.Close();
        }

        private void Btn_VoltarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarPreenchimento()
        {
            
            if (Txt_NomeCliente.Text == "")
            {
                MessageBox.Show("Nome do cliente está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeCliente.Text) == false)
            {
                MessageBox.Show("Nome do cliente não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeCliente.Text.Length > 70)
            {
                MessageBox.Show("Nome do cliente está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeCachorro.Text == "")
            {
                MessageBox.Show("Nome do cachorro está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeCachorro.Text) == false)
            {
                MessageBox.Show("Nome do cachorro não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeCachorro.Text.Length > 50)
            {
                MessageBox.Show("Nome do cachorro está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Masked_Telefone.MaskFull)
            {
                MessageBox.Show("Telefone está vazio ou incompleto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailCliente.Text == "")
            {
                MessageBox.Show("E-mail está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmail(Txt_EmailCliente.Text) == false)
            {
                MessageBox.Show("E-mail não está num formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailCliente.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EnderecoCliente.Text == "")
            {
                MessageBox.Show("Endereço está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EnderecoCliente.Text.Length > 200)
            {
                MessageBox.Show("Endereço está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
        public static bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
