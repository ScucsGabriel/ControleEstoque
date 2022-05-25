using ProjetoCasa.Controller;
using ProjetoCasa.Model;
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
    public partial class FormEditarCliente : Form
    {
        public FormEditarCliente(List<Cliente> listaCliente)
        {               
            InitializeComponent();
            foreach (var item in listaCliente)
            {
                Label_CodigoCliente.Text = item.idCliente.ToString();
                Txt_NomeClienteEdit.Text = item.nomeCliente.ToString();
                Txt_NomeCachorroEdit.Text = item.nomeCachorro;
                Masked_TelefoneEdit.Text = item.telefoneCliente;
                Txt_EmailEdit.Text = item.emailCliente;
                Txt_EnderecoEdit.Text = item.enderecoCliente;
            }
        }         

        private void Btn_SalvarEditCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string respostaAtivo = "Sim";
            ClienteController editarCliente = new ClienteController();
            editarCliente.EditarCliente(Convert.ToInt32(Label_CodigoCliente.Text), Txt_NomeClienteEdit.Text.Trim(),
                Txt_NomeCachorroEdit.Text.Trim(), Masked_TelefoneEdit.Text.Trim(), Txt_EmailEdit.Text.Trim(), 
                Txt_EnderecoEdit.Text.Trim(), respostaAtivo);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Limpar()
        {
            Txt_NomeClienteEdit.Text = "";
            Txt_NomeCachorroEdit.Text = "";
            Masked_TelefoneEdit.Text = "";
            Txt_EmailEdit.Text = "";
            Txt_EnderecoEdit.Text = "";
        }

        private void Btn_ListarEditCliente_Click(object sender, EventArgs e)
        {
            FormListarCliente formListarCliente = new FormListarCliente();
            formListarCliente.Show();
            this.Close();
        }

        private bool ValidarPreenchimento()
        {
            if (Txt_NomeClienteEdit.Text == "")
            {
                MessageBox.Show("Nome do cliente está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeClienteEdit.Text) == false)
            {
                MessageBox.Show("Nome do cliente não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeClienteEdit.Text.Length > 70)
            {
                MessageBox.Show("Nome do cliente está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeCachorroEdit.Text == "")
            {
                MessageBox.Show("Nome do cachorro está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeCachorroEdit.Text) == false)
            {
                MessageBox.Show("Nome do cachorro não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeCachorroEdit.Text.Length > 50)
            {
                MessageBox.Show("Nome do cachorro está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Masked_TelefoneEdit.MaskFull)
            {
                MessageBox.Show("Telefone está vazio ou incompleto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailEdit.Text == "")
            {
                MessageBox.Show("E-mail está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmail(Txt_EmailEdit.Text) == false)
            {
                MessageBox.Show("E-mail não está num formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailEdit.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EnderecoEdit.Text == "")
            {
                MessageBox.Show("Endereço está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EnderecoEdit.Text.Length > 200)
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
