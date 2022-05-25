namespace ProjetoCasa
{
    partial class FormListarDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_DataMinimaDesp = new System.Windows.Forms.Label();
            this.Date_DataMinimaDesp = new System.Windows.Forms.DateTimePicker();
            this.Label_DataMaximaDesp = new System.Windows.Forms.Label();
            this.Date_DataMaximaDesp = new System.Windows.Forms.DateTimePicker();
            this.Btn_BuscarPorDataDesp = new System.Windows.Forms.Button();
            this.Btn_VoltarCadDesp = new System.Windows.Forms.Button();
            this.LstView_ListaDesp = new System.Windows.Forms.ListView();
            this.Label_DespesaBusca = new System.Windows.Forms.Label();
            this.Txt_DespesaBuscaDesp = new System.Windows.Forms.TextBox();
            this.Btn_BuscarPorDespesaDesp = new System.Windows.Forms.Button();
            this.Label_QuantidadeDespesas = new System.Windows.Forms.Label();
            this.Label_CalcularQuantDesp = new System.Windows.Forms.Label();
            this.Btn_ExcluirDespesa = new System.Windows.Forms.Button();
            this.Btn_EditarDespesa = new System.Windows.Forms.Button();
            this.Btn_BuscarPorDataCartao = new System.Windows.Forms.Button();
            this.Label_RespCartaoBusca = new System.Windows.Forms.Label();
            this.Btn_BuscarPorRespCartao = new System.Windows.Forms.Button();
            this.Label_ValorDinheiroDebito = new System.Windows.Forms.Label();
            this.Label_CalculaValorDinDeb = new System.Windows.Forms.Label();
            this.Label_ValorCredito = new System.Windows.Forms.Label();
            this.Label_CalculaValorCredito = new System.Windows.Forms.Label();
            this.Label_ValorTotalDespesas = new System.Windows.Forms.Label();
            this.Label_CalculaValorTotalDesp = new System.Windows.Forms.Label();
            this.Cbo_RespCartaoLista = new System.Windows.Forms.ComboBox();
            this.Label_FormaPgtoDespLista = new System.Windows.Forms.Label();
            this.Cbo_FormaPgtoDespLista = new System.Windows.Forms.ComboBox();
            this.Label_StatusPagamentoDespLista = new System.Windows.Forms.Label();
            this.Cbo_StatusPgtoDespLista = new System.Windows.Forms.ComboBox();
            this.Btn_BuscarFormaPgtoDesp = new System.Windows.Forms.Button();
            this.Btn_BuscarStatusPgtoDesp = new System.Windows.Forms.Button();
            this.Label_ValorTotalPago = new System.Windows.Forms.Label();
            this.Label_CalculaValorPago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_DataMinimaDesp
            // 
            this.Label_DataMinimaDesp.AutoSize = true;
            this.Label_DataMinimaDesp.Location = new System.Drawing.Point(61, 37);
            this.Label_DataMinimaDesp.Name = "Label_DataMinimaDesp";
            this.Label_DataMinimaDesp.Size = new System.Drawing.Size(68, 13);
            this.Label_DataMinimaDesp.TabIndex = 17;
            this.Label_DataMinimaDesp.Text = "Data Mínima";
            // 
            // Date_DataMinimaDesp
            // 
            this.Date_DataMinimaDesp.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataMinimaDesp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataMinimaDesp.Location = new System.Drawing.Point(135, 30);
            this.Date_DataMinimaDesp.Name = "Date_DataMinimaDesp";
            this.Date_DataMinimaDesp.Size = new System.Drawing.Size(237, 20);
            this.Date_DataMinimaDesp.TabIndex = 1;
            // 
            // Label_DataMaximaDesp
            // 
            this.Label_DataMaximaDesp.AutoSize = true;
            this.Label_DataMaximaDesp.Location = new System.Drawing.Point(383, 37);
            this.Label_DataMaximaDesp.Name = "Label_DataMaximaDesp";
            this.Label_DataMaximaDesp.Size = new System.Drawing.Size(69, 13);
            this.Label_DataMaximaDesp.TabIndex = 18;
            this.Label_DataMaximaDesp.Text = "Data Máxima";
            // 
            // Date_DataMaximaDesp
            // 
            this.Date_DataMaximaDesp.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataMaximaDesp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataMaximaDesp.Location = new System.Drawing.Point(458, 31);
            this.Date_DataMaximaDesp.Name = "Date_DataMaximaDesp";
            this.Date_DataMaximaDesp.Size = new System.Drawing.Size(237, 20);
            this.Date_DataMaximaDesp.TabIndex = 2;
            // 
            // Btn_BuscarPorDataDesp
            // 
            this.Btn_BuscarPorDataDesp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorDataDesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarPorDataDesp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorDataDesp.Location = new System.Drawing.Point(29, 101);
            this.Btn_BuscarPorDataDesp.Name = "Btn_BuscarPorDataDesp";
            this.Btn_BuscarPorDataDesp.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorDataDesp.TabIndex = 7;
            this.Btn_BuscarPorDataDesp.Text = "Buscar por Data (Desp.)";
            this.Btn_BuscarPorDataDesp.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorDataDesp.Click += new System.EventHandler(this.Btn_BuscarPorDataDesp_Click);
            // 
            // Btn_VoltarCadDesp
            // 
            this.Btn_VoltarCadDesp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarCadDesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCadDesp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarCadDesp.Location = new System.Drawing.Point(1153, 102);
            this.Btn_VoltarCadDesp.Name = "Btn_VoltarCadDesp";
            this.Btn_VoltarCadDesp.Size = new System.Drawing.Size(134, 31);
            this.Btn_VoltarCadDesp.TabIndex = 15;
            this.Btn_VoltarCadDesp.Text = "Voltar";
            this.Btn_VoltarCadDesp.UseVisualStyleBackColor = false;
            this.Btn_VoltarCadDesp.Click += new System.EventHandler(this.Btn_VoltarCadDesp_Click);
            // 
            // LstView_ListaDesp
            // 
            this.LstView_ListaDesp.AllowColumnReorder = true;
            this.LstView_ListaDesp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaDesp.HideSelection = false;
            this.LstView_ListaDesp.Location = new System.Drawing.Point(29, 146);
            this.LstView_ListaDesp.Name = "LstView_ListaDesp";
            this.LstView_ListaDesp.Size = new System.Drawing.Size(1310, 474);
            this.LstView_ListaDesp.TabIndex = 16;
            this.LstView_ListaDesp.UseCompatibleStateImageBehavior = false;
            this.LstView_ListaDesp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_ListaDesp_KeyDown);
            // 
            // Label_DespesaBusca
            // 
            this.Label_DespesaBusca.AutoSize = true;
            this.Label_DespesaBusca.Location = new System.Drawing.Point(760, 38);
            this.Label_DespesaBusca.Name = "Label_DespesaBusca";
            this.Label_DespesaBusca.Size = new System.Drawing.Size(49, 13);
            this.Label_DespesaBusca.TabIndex = 19;
            this.Label_DespesaBusca.Text = "Despesa";
            // 
            // Txt_DespesaBuscaDesp
            // 
            this.Txt_DespesaBuscaDesp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DespesaBuscaDesp.Location = new System.Drawing.Point(815, 29);
            this.Txt_DespesaBuscaDesp.Name = "Txt_DespesaBuscaDesp";
            this.Txt_DespesaBuscaDesp.Size = new System.Drawing.Size(237, 21);
            this.Txt_DespesaBuscaDesp.TabIndex = 3;
            // 
            // Btn_BuscarPorDespesaDesp
            // 
            this.Btn_BuscarPorDespesaDesp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorDespesaDesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarPorDespesaDesp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorDespesaDesp.Location = new System.Drawing.Point(310, 100);
            this.Btn_BuscarPorDespesaDesp.Name = "Btn_BuscarPorDespesaDesp";
            this.Btn_BuscarPorDespesaDesp.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorDespesaDesp.TabIndex = 9;
            this.Btn_BuscarPorDespesaDesp.Text = "Buscar por Despesa";
            this.Btn_BuscarPorDespesaDesp.UseMnemonic = false;
            this.Btn_BuscarPorDespesaDesp.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorDespesaDesp.Click += new System.EventHandler(this.Btn_BuscarPorDespesaDesp_Click);
            // 
            // Label_QuantidadeDespesas
            // 
            this.Label_QuantidadeDespesas.AutoSize = true;
            this.Label_QuantidadeDespesas.Location = new System.Drawing.Point(27, 636);
            this.Label_QuantidadeDespesas.Name = "Label_QuantidadeDespesas";
            this.Label_QuantidadeDespesas.Size = new System.Drawing.Size(127, 13);
            this.Label_QuantidadeDespesas.TabIndex = 23;
            this.Label_QuantidadeDespesas.Text = "Quantidade de Despesas";
            // 
            // Label_CalcularQuantDesp
            // 
            this.Label_CalcularQuantDesp.AutoSize = true;
            this.Label_CalcularQuantDesp.Location = new System.Drawing.Point(27, 659);
            this.Label_CalcularQuantDesp.Name = "Label_CalcularQuantDesp";
            this.Label_CalcularQuantDesp.Size = new System.Drawing.Size(13, 13);
            this.Label_CalcularQuantDesp.TabIndex = 24;
            this.Label_CalcularQuantDesp.Text = "0";
            // 
            // Btn_ExcluirDespesa
            // 
            this.Btn_ExcluirDespesa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirDespesa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirDespesa.Location = new System.Drawing.Point(1013, 101);
            this.Btn_ExcluirDespesa.Name = "Btn_ExcluirDespesa";
            this.Btn_ExcluirDespesa.Size = new System.Drawing.Size(134, 32);
            this.Btn_ExcluirDespesa.TabIndex = 14;
            this.Btn_ExcluirDespesa.Text = "Excluir";
            this.Btn_ExcluirDespesa.UseVisualStyleBackColor = false;
            this.Btn_ExcluirDespesa.Click += new System.EventHandler(this.Btn_ExcluirDespesa_Click);
            // 
            // Btn_EditarDespesa
            // 
            this.Btn_EditarDespesa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarDespesa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarDespesa.Location = new System.Drawing.Point(873, 100);
            this.Btn_EditarDespesa.Name = "Btn_EditarDespesa";
            this.Btn_EditarDespesa.Size = new System.Drawing.Size(134, 32);
            this.Btn_EditarDespesa.TabIndex = 13;
            this.Btn_EditarDespesa.Text = "Editar";
            this.Btn_EditarDespesa.UseVisualStyleBackColor = false;
            this.Btn_EditarDespesa.Click += new System.EventHandler(this.Btn_EditarDespesa_Click);
            // 
            // Btn_BuscarPorDataCartao
            // 
            this.Btn_BuscarPorDataCartao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorDataCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarPorDataCartao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorDataCartao.Location = new System.Drawing.Point(169, 101);
            this.Btn_BuscarPorDataCartao.Name = "Btn_BuscarPorDataCartao";
            this.Btn_BuscarPorDataCartao.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorDataCartao.TabIndex = 8;
            this.Btn_BuscarPorDataCartao.Text = "Buscar por Data (Cartão)";
            this.Btn_BuscarPorDataCartao.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorDataCartao.Click += new System.EventHandler(this.Btn_BuscarPorDataCartao_Click);
            // 
            // Label_RespCartaoBusca
            // 
            this.Label_RespCartaoBusca.AutoSize = true;
            this.Label_RespCartaoBusca.Location = new System.Drawing.Point(383, 64);
            this.Label_RespCartaoBusca.Name = "Label_RespCartaoBusca";
            this.Label_RespCartaoBusca.Size = new System.Drawing.Size(69, 13);
            this.Label_RespCartaoBusca.TabIndex = 21;
            this.Label_RespCartaoBusca.Text = "Resp. Cartão";
            // 
            // Btn_BuscarPorRespCartao
            // 
            this.Btn_BuscarPorRespCartao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorRespCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarPorRespCartao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorRespCartao.Location = new System.Drawing.Point(590, 101);
            this.Btn_BuscarPorRespCartao.Name = "Btn_BuscarPorRespCartao";
            this.Btn_BuscarPorRespCartao.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorRespCartao.TabIndex = 11;
            this.Btn_BuscarPorRespCartao.Text = "Buscar por Resp. Cartão";
            this.Btn_BuscarPorRespCartao.UseMnemonic = false;
            this.Btn_BuscarPorRespCartao.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorRespCartao.Click += new System.EventHandler(this.Btn_BuscarPorRespCartao_Click);
            // 
            // Label_ValorDinheiroDebito
            // 
            this.Label_ValorDinheiroDebito.AutoSize = true;
            this.Label_ValorDinheiroDebito.Location = new System.Drawing.Point(188, 636);
            this.Label_ValorDinheiroDebito.Name = "Label_ValorDinheiroDebito";
            this.Label_ValorDinheiroDebito.Size = new System.Drawing.Size(142, 13);
            this.Label_ValorDinheiroDebito.TabIndex = 25;
            this.Label_ValorDinheiroDebito.Text = "Valor Total (Dinheiro/Débito)";
            // 
            // Label_CalculaValorDinDeb
            // 
            this.Label_CalculaValorDinDeb.AutoSize = true;
            this.Label_CalculaValorDinDeb.Location = new System.Drawing.Point(188, 659);
            this.Label_CalculaValorDinDeb.Name = "Label_CalculaValorDinDeb";
            this.Label_CalculaValorDinDeb.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaValorDinDeb.TabIndex = 26;
            this.Label_CalculaValorDinDeb.Text = "R$0,00";
            // 
            // Label_ValorCredito
            // 
            this.Label_ValorCredito.AutoSize = true;
            this.Label_ValorCredito.Location = new System.Drawing.Point(361, 636);
            this.Label_ValorCredito.Name = "Label_ValorCredito";
            this.Label_ValorCredito.Size = new System.Drawing.Size(100, 13);
            this.Label_ValorCredito.TabIndex = 27;
            this.Label_ValorCredito.Text = "Valor Total (Crédito)";
            // 
            // Label_CalculaValorCredito
            // 
            this.Label_CalculaValorCredito.AutoSize = true;
            this.Label_CalculaValorCredito.Location = new System.Drawing.Point(361, 659);
            this.Label_CalculaValorCredito.Name = "Label_CalculaValorCredito";
            this.Label_CalculaValorCredito.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaValorCredito.TabIndex = 28;
            this.Label_CalculaValorCredito.Text = "R$0,00";
            // 
            // Label_ValorTotalDespesas
            // 
            this.Label_ValorTotalDespesas.AutoSize = true;
            this.Label_ValorTotalDespesas.Location = new System.Drawing.Point(490, 636);
            this.Label_ValorTotalDespesas.Name = "Label_ValorTotalDespesas";
            this.Label_ValorTotalDespesas.Size = new System.Drawing.Size(123, 13);
            this.Label_ValorTotalDespesas.TabIndex = 29;
            this.Label_ValorTotalDespesas.Text = "Valor Total de Despesas";
            // 
            // Label_CalculaValorTotalDesp
            // 
            this.Label_CalculaValorTotalDesp.AutoSize = true;
            this.Label_CalculaValorTotalDesp.Location = new System.Drawing.Point(490, 659);
            this.Label_CalculaValorTotalDesp.Name = "Label_CalculaValorTotalDesp";
            this.Label_CalculaValorTotalDesp.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaValorTotalDesp.TabIndex = 30;
            this.Label_CalculaValorTotalDesp.Text = "R$0,00";
            // 
            // Cbo_RespCartaoLista
            // 
            this.Cbo_RespCartaoLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_RespCartaoLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_RespCartaoLista.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_RespCartaoLista.FormattingEnabled = true;
            this.Cbo_RespCartaoLista.Location = new System.Drawing.Point(458, 60);
            this.Cbo_RespCartaoLista.Name = "Cbo_RespCartaoLista";
            this.Cbo_RespCartaoLista.Size = new System.Drawing.Size(237, 23);
            this.Cbo_RespCartaoLista.TabIndex = 5;
            // 
            // Label_FormaPgtoDespLista
            // 
            this.Label_FormaPgtoDespLista.AutoSize = true;
            this.Label_FormaPgtoDespLista.Location = new System.Drawing.Point(23, 64);
            this.Label_FormaPgtoDespLista.Name = "Label_FormaPgtoDespLista";
            this.Label_FormaPgtoDespLista.Size = new System.Drawing.Size(108, 13);
            this.Label_FormaPgtoDespLista.TabIndex = 20;
            this.Label_FormaPgtoDespLista.Text = "Forma de Pagamento";
            // 
            // Cbo_FormaPgtoDespLista
            // 
            this.Cbo_FormaPgtoDespLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_FormaPgtoDespLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_FormaPgtoDespLista.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_FormaPgtoDespLista.FormattingEnabled = true;
            this.Cbo_FormaPgtoDespLista.Location = new System.Drawing.Point(137, 60);
            this.Cbo_FormaPgtoDespLista.Name = "Cbo_FormaPgtoDespLista";
            this.Cbo_FormaPgtoDespLista.Size = new System.Drawing.Size(235, 23);
            this.Cbo_FormaPgtoDespLista.TabIndex = 4;
            // 
            // Label_StatusPagamentoDespLista
            // 
            this.Label_StatusPagamentoDespLista.AutoSize = true;
            this.Label_StatusPagamentoDespLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StatusPagamentoDespLista.Location = new System.Drawing.Point(705, 62);
            this.Label_StatusPagamentoDespLista.Name = "Label_StatusPagamentoDespLista";
            this.Label_StatusPagamentoDespLista.Size = new System.Drawing.Size(108, 15);
            this.Label_StatusPagamentoDespLista.TabIndex = 22;
            this.Label_StatusPagamentoDespLista.Text = "Status Pagamento";
            // 
            // Cbo_StatusPgtoDespLista
            // 
            this.Cbo_StatusPgtoDespLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_StatusPgtoDespLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_StatusPgtoDespLista.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_StatusPgtoDespLista.FormattingEnabled = true;
            this.Cbo_StatusPgtoDespLista.Location = new System.Drawing.Point(815, 54);
            this.Cbo_StatusPgtoDespLista.Name = "Cbo_StatusPgtoDespLista";
            this.Cbo_StatusPgtoDespLista.Size = new System.Drawing.Size(237, 23);
            this.Cbo_StatusPgtoDespLista.TabIndex = 6;
            // 
            // Btn_BuscarFormaPgtoDesp
            // 
            this.Btn_BuscarFormaPgtoDesp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarFormaPgtoDesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarFormaPgtoDesp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarFormaPgtoDesp.Location = new System.Drawing.Point(450, 101);
            this.Btn_BuscarFormaPgtoDesp.Name = "Btn_BuscarFormaPgtoDesp";
            this.Btn_BuscarFormaPgtoDesp.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarFormaPgtoDesp.TabIndex = 10;
            this.Btn_BuscarFormaPgtoDesp.Text = "Buscar por Forma Pgto.";
            this.Btn_BuscarFormaPgtoDesp.UseMnemonic = false;
            this.Btn_BuscarFormaPgtoDesp.UseVisualStyleBackColor = false;
            this.Btn_BuscarFormaPgtoDesp.Click += new System.EventHandler(this.Btn_BuscarFormaPgtoDesp_Click);
            // 
            // Btn_BuscarStatusPgtoDesp
            // 
            this.Btn_BuscarStatusPgtoDesp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarStatusPgtoDesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarStatusPgtoDesp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarStatusPgtoDesp.Location = new System.Drawing.Point(733, 100);
            this.Btn_BuscarStatusPgtoDesp.Name = "Btn_BuscarStatusPgtoDesp";
            this.Btn_BuscarStatusPgtoDesp.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarStatusPgtoDesp.TabIndex = 12;
            this.Btn_BuscarStatusPgtoDesp.Text = "Buscar por Status Pgto.";
            this.Btn_BuscarStatusPgtoDesp.UseMnemonic = false;
            this.Btn_BuscarStatusPgtoDesp.UseVisualStyleBackColor = false;
            this.Btn_BuscarStatusPgtoDesp.Click += new System.EventHandler(this.Btn_BuscarStatusPgtoDesp_Click);
            // 
            // Label_ValorTotalPago
            // 
            this.Label_ValorTotalPago.AutoSize = true;
            this.Label_ValorTotalPago.Location = new System.Drawing.Point(638, 636);
            this.Label_ValorTotalPago.Name = "Label_ValorTotalPago";
            this.Label_ValorTotalPago.Size = new System.Drawing.Size(86, 13);
            this.Label_ValorTotalPago.TabIndex = 31;
            this.Label_ValorTotalPago.Text = "Valor Total Pago";
            // 
            // Label_CalculaValorPago
            // 
            this.Label_CalculaValorPago.AutoSize = true;
            this.Label_CalculaValorPago.Location = new System.Drawing.Point(638, 659);
            this.Label_CalculaValorPago.Name = "Label_CalculaValorPago";
            this.Label_CalculaValorPago.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaValorPago.TabIndex = 32;
            this.Label_CalculaValorPago.Text = "R$0,00";
            // 
            // FormListarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 693);
            this.Controls.Add(this.Label_CalculaValorPago);
            this.Controls.Add(this.Label_ValorTotalPago);
            this.Controls.Add(this.Btn_BuscarStatusPgtoDesp);
            this.Controls.Add(this.Btn_BuscarFormaPgtoDesp);
            this.Controls.Add(this.Cbo_StatusPgtoDespLista);
            this.Controls.Add(this.Label_StatusPagamentoDespLista);
            this.Controls.Add(this.Cbo_FormaPgtoDespLista);
            this.Controls.Add(this.Label_FormaPgtoDespLista);
            this.Controls.Add(this.Cbo_RespCartaoLista);
            this.Controls.Add(this.Label_CalculaValorTotalDesp);
            this.Controls.Add(this.Label_ValorTotalDespesas);
            this.Controls.Add(this.Label_CalculaValorCredito);
            this.Controls.Add(this.Label_ValorCredito);
            this.Controls.Add(this.Label_CalculaValorDinDeb);
            this.Controls.Add(this.Label_ValorDinheiroDebito);
            this.Controls.Add(this.Btn_BuscarPorRespCartao);
            this.Controls.Add(this.Label_RespCartaoBusca);
            this.Controls.Add(this.Btn_BuscarPorDataCartao);
            this.Controls.Add(this.Btn_EditarDespesa);
            this.Controls.Add(this.Btn_ExcluirDespesa);
            this.Controls.Add(this.Label_CalcularQuantDesp);
            this.Controls.Add(this.Label_QuantidadeDespesas);
            this.Controls.Add(this.Btn_BuscarPorDespesaDesp);
            this.Controls.Add(this.Txt_DespesaBuscaDesp);
            this.Controls.Add(this.Label_DespesaBusca);
            this.Controls.Add(this.LstView_ListaDesp);
            this.Controls.Add(this.Btn_VoltarCadDesp);
            this.Controls.Add(this.Btn_BuscarPorDataDesp);
            this.Controls.Add(this.Date_DataMaximaDesp);
            this.Controls.Add(this.Label_DataMaximaDesp);
            this.Controls.Add(this.Date_DataMinimaDesp);
            this.Controls.Add(this.Label_DataMinimaDesp);
            this.Name = "FormListarDespesa";
            this.Text = "Lista de Despesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListarDespesa_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_DataMinimaDesp;
        private System.Windows.Forms.DateTimePicker Date_DataMinimaDesp;
        private System.Windows.Forms.Label Label_DataMaximaDesp;
        private System.Windows.Forms.DateTimePicker Date_DataMaximaDesp;
        private System.Windows.Forms.Button Btn_BuscarPorDataDesp;
        private System.Windows.Forms.Button Btn_VoltarCadDesp;
        private System.Windows.Forms.ListView LstView_ListaDesp;
        private System.Windows.Forms.Label Label_DespesaBusca;
        private System.Windows.Forms.TextBox Txt_DespesaBuscaDesp;
        private System.Windows.Forms.Button Btn_BuscarPorDespesaDesp;
        private System.Windows.Forms.Label Label_QuantidadeDespesas;
        private System.Windows.Forms.Label Label_CalcularQuantDesp;
        private System.Windows.Forms.Button Btn_ExcluirDespesa;
        private System.Windows.Forms.Button Btn_EditarDespesa;
        private System.Windows.Forms.Button Btn_BuscarPorDataCartao;
        private System.Windows.Forms.Label Label_RespCartaoBusca;
        private System.Windows.Forms.Button Btn_BuscarPorRespCartao;
        private System.Windows.Forms.Label Label_ValorDinheiroDebito;
        private System.Windows.Forms.Label Label_CalculaValorDinDeb;
        private System.Windows.Forms.Label Label_ValorCredito;
        private System.Windows.Forms.Label Label_CalculaValorCredito;
        private System.Windows.Forms.Label Label_ValorTotalDespesas;
        private System.Windows.Forms.Label Label_CalculaValorTotalDesp;
        private System.Windows.Forms.ComboBox Cbo_RespCartaoLista;
        private System.Windows.Forms.Label Label_FormaPgtoDespLista;
        private System.Windows.Forms.ComboBox Cbo_FormaPgtoDespLista;
        private System.Windows.Forms.Label Label_StatusPagamentoDespLista;
        private System.Windows.Forms.ComboBox Cbo_StatusPgtoDespLista;
        private System.Windows.Forms.Button Btn_BuscarFormaPgtoDesp;
        private System.Windows.Forms.Button Btn_BuscarStatusPgtoDesp;
        private System.Windows.Forms.Label Label_ValorTotalPago;
        private System.Windows.Forms.Label Label_CalculaValorPago;
    }
}