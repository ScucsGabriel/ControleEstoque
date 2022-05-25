namespace ProjetoCasa
{
    partial class FormListarPagamento
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
            this.Label_DataMinimaPgto = new System.Windows.Forms.Label();
            this.Date_DataMinimaPgto = new System.Windows.Forms.DateTimePicker();
            this.Label_DataMaximaPgto = new System.Windows.Forms.Label();
            this.Date_DataMaximaPgto = new System.Windows.Forms.DateTimePicker();
            this.Btn_BuscarPorDataPgto = new System.Windows.Forms.Button();
            this.Btn_VoltarCadPgto = new System.Windows.Forms.Button();
            this.LstView_ListaPgto = new System.Windows.Forms.ListView();
            this.Label_NumeroPedidoPag = new System.Windows.Forms.Label();
            this.Txt_NumeroPedidoPag = new System.Windows.Forms.TextBox();
            this.Btn_BuscarPorTipoPgto = new System.Windows.Forms.Button();
            this.Label_QuantidadePgto = new System.Windows.Forms.Label();
            this.Label_CalcularQuantPgto = new System.Windows.Forms.Label();
            this.Btn_ExcluirPgto = new System.Windows.Forms.Button();
            this.Btn_EditarPgto = new System.Windows.Forms.Button();
            this.Btn_BuscarPorNumPedido = new System.Windows.Forms.Button();
            this.Label_TipoPgtoPed = new System.Windows.Forms.Label();
            this.Btn_BuscarPorStatusPgto = new System.Windows.Forms.Button();
            this.Label_StatusPgtoPed = new System.Windows.Forms.Label();
            this.Cbo_TipoPgtoPedListar = new System.Windows.Forms.ComboBox();
            this.Cbo_StatusPgtoPedListar = new System.Windows.Forms.ComboBox();
            this.Label_ClientePgtoPedido = new System.Windows.Forms.Label();
            this.Txt_ClientePgtoBusca = new System.Windows.Forms.TextBox();
            this.Btn_BuscarPorCliente = new System.Windows.Forms.Button();
            this.Label_PedidosDinheiro = new System.Windows.Forms.Label();
            this.Label_CalculaPedDinheiro = new System.Windows.Forms.Label();
            this.Label_PedidosTransferencia = new System.Windows.Forms.Label();
            this.Label_CalculaPedTransf = new System.Windows.Forms.Label();
            this.Label_PedidosCartao = new System.Windows.Forms.Label();
            this.Label_CalculaPedCartao = new System.Windows.Forms.Label();
            this.Label_TotalLivreCaixa = new System.Windows.Forms.Label();
            this.Label_CalculaTotalLivreCaixa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_DataMinimaPgto
            // 
            this.Label_DataMinimaPgto.AutoSize = true;
            this.Label_DataMinimaPgto.Location = new System.Drawing.Point(43, 36);
            this.Label_DataMinimaPgto.Name = "Label_DataMinimaPgto";
            this.Label_DataMinimaPgto.Size = new System.Drawing.Size(68, 13);
            this.Label_DataMinimaPgto.TabIndex = 16;
            this.Label_DataMinimaPgto.Text = "Data Mínima";
            // 
            // Date_DataMinimaPgto
            // 
            this.Date_DataMinimaPgto.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataMinimaPgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataMinimaPgto.Location = new System.Drawing.Point(117, 30);
            this.Date_DataMinimaPgto.Name = "Date_DataMinimaPgto";
            this.Date_DataMinimaPgto.Size = new System.Drawing.Size(237, 20);
            this.Date_DataMinimaPgto.TabIndex = 1;
            // 
            // Label_DataMaximaPgto
            // 
            this.Label_DataMaximaPgto.AutoSize = true;
            this.Label_DataMaximaPgto.Location = new System.Drawing.Point(366, 36);
            this.Label_DataMaximaPgto.Name = "Label_DataMaximaPgto";
            this.Label_DataMaximaPgto.Size = new System.Drawing.Size(69, 13);
            this.Label_DataMaximaPgto.TabIndex = 17;
            this.Label_DataMaximaPgto.Text = "Data Máxima";
            // 
            // Date_DataMaximaPgto
            // 
            this.Date_DataMaximaPgto.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataMaximaPgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataMaximaPgto.Location = new System.Drawing.Point(441, 30);
            this.Date_DataMaximaPgto.Name = "Date_DataMaximaPgto";
            this.Date_DataMaximaPgto.Size = new System.Drawing.Size(237, 20);
            this.Date_DataMaximaPgto.TabIndex = 2;
            // 
            // Btn_BuscarPorDataPgto
            // 
            this.Btn_BuscarPorDataPgto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorDataPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarPorDataPgto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorDataPgto.Location = new System.Drawing.Point(29, 98);
            this.Btn_BuscarPorDataPgto.Name = "Btn_BuscarPorDataPgto";
            this.Btn_BuscarPorDataPgto.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorDataPgto.TabIndex = 7;
            this.Btn_BuscarPorDataPgto.Text = "Buscar por Data Pgto.";
            this.Btn_BuscarPorDataPgto.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorDataPgto.Click += new System.EventHandler(this.Btn_BuscarPorDataPgto_Click);
            // 
            // Btn_VoltarCadPgto
            // 
            this.Btn_VoltarCadPgto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarCadPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCadPgto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarCadPgto.Location = new System.Drawing.Point(1009, 97);
            this.Btn_VoltarCadPgto.Name = "Btn_VoltarCadPgto";
            this.Btn_VoltarCadPgto.Size = new System.Drawing.Size(134, 33);
            this.Btn_VoltarCadPgto.TabIndex = 14;
            this.Btn_VoltarCadPgto.Text = "Voltar";
            this.Btn_VoltarCadPgto.UseVisualStyleBackColor = false;
            this.Btn_VoltarCadPgto.Click += new System.EventHandler(this.Btn_VoltarCadPgto_Click);
            // 
            // LstView_ListaPgto
            // 
            this.LstView_ListaPgto.AllowColumnReorder = true;
            this.LstView_ListaPgto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaPgto.HideSelection = false;
            this.LstView_ListaPgto.Location = new System.Drawing.Point(29, 146);
            this.LstView_ListaPgto.Name = "LstView_ListaPgto";
            this.LstView_ListaPgto.Size = new System.Drawing.Size(1310, 453);
            this.LstView_ListaPgto.TabIndex = 15;
            this.LstView_ListaPgto.UseCompatibleStateImageBehavior = false;
            this.LstView_ListaPgto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_ListaPgto_KeyDown);
            // 
            // Label_NumeroPedidoPag
            // 
            this.Label_NumeroPedidoPag.AutoSize = true;
            this.Label_NumeroPedidoPag.Location = new System.Drawing.Point(690, 34);
            this.Label_NumeroPedidoPag.Name = "Label_NumeroPedidoPag";
            this.Label_NumeroPedidoPag.Size = new System.Drawing.Size(70, 13);
            this.Label_NumeroPedidoPag.TabIndex = 18;
            this.Label_NumeroPedidoPag.Text = "N° do Pedido";
            // 
            // Txt_NumeroPedidoPag
            // 
            this.Txt_NumeroPedidoPag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroPedidoPag.Location = new System.Drawing.Point(766, 30);
            this.Txt_NumeroPedidoPag.Name = "Txt_NumeroPedidoPag";
            this.Txt_NumeroPedidoPag.Size = new System.Drawing.Size(237, 21);
            this.Txt_NumeroPedidoPag.TabIndex = 3;
            // 
            // Btn_BuscarPorTipoPgto
            // 
            this.Btn_BuscarPorTipoPgto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorTipoPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarPorTipoPgto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorTipoPgto.Location = new System.Drawing.Point(589, 97);
            this.Btn_BuscarPorTipoPgto.Name = "Btn_BuscarPorTipoPgto";
            this.Btn_BuscarPorTipoPgto.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorTipoPgto.TabIndex = 11;
            this.Btn_BuscarPorTipoPgto.Text = "Buscar por Tipo Pgto.";
            this.Btn_BuscarPorTipoPgto.UseMnemonic = false;
            this.Btn_BuscarPorTipoPgto.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorTipoPgto.Click += new System.EventHandler(this.Btn_BuscarPorTipoPgto_Click);
            // 
            // Label_QuantidadePgto
            // 
            this.Label_QuantidadePgto.AutoSize = true;
            this.Label_QuantidadePgto.Location = new System.Drawing.Point(26, 614);
            this.Label_QuantidadePgto.Name = "Label_QuantidadePgto";
            this.Label_QuantidadePgto.Size = new System.Drawing.Size(139, 13);
            this.Label_QuantidadePgto.TabIndex = 22;
            this.Label_QuantidadePgto.Text = "Quantidade de Pagamentos";
            // 
            // Label_CalcularQuantPgto
            // 
            this.Label_CalcularQuantPgto.AutoSize = true;
            this.Label_CalcularQuantPgto.Location = new System.Drawing.Point(26, 639);
            this.Label_CalcularQuantPgto.Name = "Label_CalcularQuantPgto";
            this.Label_CalcularQuantPgto.Size = new System.Drawing.Size(13, 13);
            this.Label_CalcularQuantPgto.TabIndex = 23;
            this.Label_CalcularQuantPgto.Text = "0";
            // 
            // Btn_ExcluirPgto
            // 
            this.Btn_ExcluirPgto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirPgto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirPgto.Location = new System.Drawing.Point(869, 98);
            this.Btn_ExcluirPgto.Name = "Btn_ExcluirPgto";
            this.Btn_ExcluirPgto.Size = new System.Drawing.Size(134, 32);
            this.Btn_ExcluirPgto.TabIndex = 13;
            this.Btn_ExcluirPgto.Text = "Excluir";
            this.Btn_ExcluirPgto.UseVisualStyleBackColor = false;
            this.Btn_ExcluirPgto.Click += new System.EventHandler(this.Btn_ExcluirPgto_Click);
            // 
            // Btn_EditarPgto
            // 
            this.Btn_EditarPgto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarPgto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarPgto.Location = new System.Drawing.Point(729, 97);
            this.Btn_EditarPgto.Name = "Btn_EditarPgto";
            this.Btn_EditarPgto.Size = new System.Drawing.Size(134, 32);
            this.Btn_EditarPgto.TabIndex = 12;
            this.Btn_EditarPgto.Text = "Editar";
            this.Btn_EditarPgto.UseVisualStyleBackColor = false;
            this.Btn_EditarPgto.Click += new System.EventHandler(this.Btn_EditarPgto_Click);
            // 
            // Btn_BuscarPorNumPedido
            // 
            this.Btn_BuscarPorNumPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarPorNumPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorNumPedido.Location = new System.Drawing.Point(169, 100);
            this.Btn_BuscarPorNumPedido.Name = "Btn_BuscarPorNumPedido";
            this.Btn_BuscarPorNumPedido.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorNumPedido.TabIndex = 8;
            this.Btn_BuscarPorNumPedido.Text = "Buscar por Nº Pedido";
            this.Btn_BuscarPorNumPedido.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorNumPedido.Click += new System.EventHandler(this.Btn_BuscarPorNumPedido_Click);
            // 
            // Label_TipoPgtoPed
            // 
            this.Label_TipoPgtoPed.AutoSize = true;
            this.Label_TipoPgtoPed.Location = new System.Drawing.Point(704, 59);
            this.Label_TipoPgtoPed.Name = "Label_TipoPgtoPed";
            this.Label_TipoPgtoPed.Size = new System.Drawing.Size(56, 13);
            this.Label_TipoPgtoPed.TabIndex = 21;
            this.Label_TipoPgtoPed.Text = "Tipo Pgto.";
            // 
            // Btn_BuscarPorStatusPgto
            // 
            this.Btn_BuscarPorStatusPgto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorStatusPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarPorStatusPgto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorStatusPgto.Location = new System.Drawing.Point(450, 97);
            this.Btn_BuscarPorStatusPgto.Name = "Btn_BuscarPorStatusPgto";
            this.Btn_BuscarPorStatusPgto.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorStatusPgto.TabIndex = 10;
            this.Btn_BuscarPorStatusPgto.Text = "Buscar por Status Pgto.";
            this.Btn_BuscarPorStatusPgto.UseMnemonic = false;
            this.Btn_BuscarPorStatusPgto.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorStatusPgto.Click += new System.EventHandler(this.Btn_BuscarPorStatusPgto_Click);
            // 
            // Label_StatusPgtoPed
            // 
            this.Label_StatusPgtoPed.AutoSize = true;
            this.Label_StatusPgtoPed.Location = new System.Drawing.Point(370, 60);
            this.Label_StatusPgtoPed.Name = "Label_StatusPgtoPed";
            this.Label_StatusPgtoPed.Size = new System.Drawing.Size(65, 13);
            this.Label_StatusPgtoPed.TabIndex = 20;
            this.Label_StatusPgtoPed.Text = "Status Pgto.";
            // 
            // Cbo_TipoPgtoPedListar
            // 
            this.Cbo_TipoPgtoPedListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoPgtoPedListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_TipoPgtoPedListar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_TipoPgtoPedListar.FormattingEnabled = true;
            this.Cbo_TipoPgtoPedListar.Location = new System.Drawing.Point(766, 56);
            this.Cbo_TipoPgtoPedListar.Name = "Cbo_TipoPgtoPedListar";
            this.Cbo_TipoPgtoPedListar.Size = new System.Drawing.Size(237, 23);
            this.Cbo_TipoPgtoPedListar.TabIndex = 6;
            // 
            // Cbo_StatusPgtoPedListar
            // 
            this.Cbo_StatusPgtoPedListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_StatusPgtoPedListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_StatusPgtoPedListar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_StatusPgtoPedListar.FormattingEnabled = true;
            this.Cbo_StatusPgtoPedListar.Location = new System.Drawing.Point(441, 55);
            this.Cbo_StatusPgtoPedListar.Name = "Cbo_StatusPgtoPedListar";
            this.Cbo_StatusPgtoPedListar.Size = new System.Drawing.Size(237, 23);
            this.Cbo_StatusPgtoPedListar.TabIndex = 5;
            // 
            // Label_ClientePgtoPedido
            // 
            this.Label_ClientePgtoPedido.AutoSize = true;
            this.Label_ClientePgtoPedido.Location = new System.Drawing.Point(28, 62);
            this.Label_ClientePgtoPedido.Name = "Label_ClientePgtoPedido";
            this.Label_ClientePgtoPedido.Size = new System.Drawing.Size(87, 13);
            this.Label_ClientePgtoPedido.TabIndex = 19;
            this.Label_ClientePgtoPedido.Text = "Cliente/Cachorro";
            // 
            // Txt_ClientePgtoBusca
            // 
            this.Txt_ClientePgtoBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ClientePgtoBusca.Location = new System.Drawing.Point(117, 60);
            this.Txt_ClientePgtoBusca.Name = "Txt_ClientePgtoBusca";
            this.Txt_ClientePgtoBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_ClientePgtoBusca.TabIndex = 4;
            // 
            // Btn_BuscarPorCliente
            // 
            this.Btn_BuscarPorCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarPorCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorCliente.Location = new System.Drawing.Point(310, 99);
            this.Btn_BuscarPorCliente.Name = "Btn_BuscarPorCliente";
            this.Btn_BuscarPorCliente.Size = new System.Drawing.Size(134, 31);
            this.Btn_BuscarPorCliente.TabIndex = 9;
            this.Btn_BuscarPorCliente.Text = "Buscar por Cliente";
            this.Btn_BuscarPorCliente.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorCliente.Click += new System.EventHandler(this.Btn_BuscarPorCliente_Click);
            // 
            // Label_PedidosDinheiro
            // 
            this.Label_PedidosDinheiro.AutoSize = true;
            this.Label_PedidosDinheiro.Location = new System.Drawing.Point(196, 614);
            this.Label_PedidosDinheiro.Name = "Label_PedidosDinheiro";
            this.Label_PedidosDinheiro.Size = new System.Drawing.Size(104, 13);
            this.Label_PedidosDinheiro.TabIndex = 24;
            this.Label_PedidosDinheiro.Text = "Pedidos em Dinheiro";
            // 
            // Label_CalculaPedDinheiro
            // 
            this.Label_CalculaPedDinheiro.AutoSize = true;
            this.Label_CalculaPedDinheiro.Location = new System.Drawing.Point(196, 639);
            this.Label_CalculaPedDinheiro.Name = "Label_CalculaPedDinheiro";
            this.Label_CalculaPedDinheiro.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaPedDinheiro.TabIndex = 25;
            this.Label_CalculaPedDinheiro.Text = "R$0,00";
            // 
            // Label_PedidosTransferencia
            // 
            this.Label_PedidosTransferencia.AutoSize = true;
            this.Label_PedidosTransferencia.Location = new System.Drawing.Point(335, 614);
            this.Label_PedidosTransferencia.Name = "Label_PedidosTransferencia";
            this.Label_PedidosTransferencia.Size = new System.Drawing.Size(152, 13);
            this.Label_PedidosTransferencia.TabIndex = 26;
            this.Label_PedidosTransferencia.Text = "Pedidos em Transferência C/C";
            // 
            // Label_CalculaPedTransf
            // 
            this.Label_CalculaPedTransf.AutoSize = true;
            this.Label_CalculaPedTransf.Location = new System.Drawing.Point(335, 639);
            this.Label_CalculaPedTransf.Name = "Label_CalculaPedTransf";
            this.Label_CalculaPedTransf.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaPedTransf.TabIndex = 27;
            this.Label_CalculaPedTransf.Text = "R$0,00";
            // 
            // Label_PedidosCartao
            // 
            this.Label_PedidosCartao.AutoSize = true;
            this.Label_PedidosCartao.Location = new System.Drawing.Point(513, 614);
            this.Label_PedidosCartao.Name = "Label_PedidosCartao";
            this.Label_PedidosCartao.Size = new System.Drawing.Size(96, 13);
            this.Label_PedidosCartao.TabIndex = 28;
            this.Label_PedidosCartao.Text = "Pedidos em Cartão";
            // 
            // Label_CalculaPedCartao
            // 
            this.Label_CalculaPedCartao.AutoSize = true;
            this.Label_CalculaPedCartao.Location = new System.Drawing.Point(513, 639);
            this.Label_CalculaPedCartao.Name = "Label_CalculaPedCartao";
            this.Label_CalculaPedCartao.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaPedCartao.TabIndex = 29;
            this.Label_CalculaPedCartao.Text = "R$0,00";
            // 
            // Label_TotalLivreCaixa
            // 
            this.Label_TotalLivreCaixa.AutoSize = true;
            this.Label_TotalLivreCaixa.Location = new System.Drawing.Point(646, 614);
            this.Label_TotalLivreCaixa.Name = "Label_TotalLivreCaixa";
            this.Label_TotalLivreCaixa.Size = new System.Drawing.Size(86, 13);
            this.Label_TotalLivreCaixa.TabIndex = 30;
            this.Label_TotalLivreCaixa.Text = "Total Livre Caixa";
            // 
            // Label_CalculaTotalLivreCaixa
            // 
            this.Label_CalculaTotalLivreCaixa.AutoSize = true;
            this.Label_CalculaTotalLivreCaixa.Location = new System.Drawing.Point(646, 639);
            this.Label_CalculaTotalLivreCaixa.Name = "Label_CalculaTotalLivreCaixa";
            this.Label_CalculaTotalLivreCaixa.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaTotalLivreCaixa.TabIndex = 31;
            this.Label_CalculaTotalLivreCaixa.Text = "R$0,00";
            // 
            // FormListarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 665);
            this.Controls.Add(this.Label_CalculaTotalLivreCaixa);
            this.Controls.Add(this.Label_TotalLivreCaixa);
            this.Controls.Add(this.Label_CalculaPedCartao);
            this.Controls.Add(this.Label_PedidosCartao);
            this.Controls.Add(this.Label_CalculaPedTransf);
            this.Controls.Add(this.Label_PedidosTransferencia);
            this.Controls.Add(this.Label_CalculaPedDinheiro);
            this.Controls.Add(this.Label_PedidosDinheiro);
            this.Controls.Add(this.Btn_BuscarPorCliente);
            this.Controls.Add(this.Txt_ClientePgtoBusca);
            this.Controls.Add(this.Label_ClientePgtoPedido);
            this.Controls.Add(this.Cbo_StatusPgtoPedListar);
            this.Controls.Add(this.Cbo_TipoPgtoPedListar);
            this.Controls.Add(this.Label_StatusPgtoPed);
            this.Controls.Add(this.Btn_BuscarPorStatusPgto);
            this.Controls.Add(this.Label_TipoPgtoPed);
            this.Controls.Add(this.Btn_BuscarPorNumPedido);
            this.Controls.Add(this.Btn_EditarPgto);
            this.Controls.Add(this.Btn_ExcluirPgto);
            this.Controls.Add(this.Label_CalcularQuantPgto);
            this.Controls.Add(this.Label_QuantidadePgto);
            this.Controls.Add(this.Btn_BuscarPorTipoPgto);
            this.Controls.Add(this.Txt_NumeroPedidoPag);
            this.Controls.Add(this.Label_NumeroPedidoPag);
            this.Controls.Add(this.LstView_ListaPgto);
            this.Controls.Add(this.Btn_VoltarCadPgto);
            this.Controls.Add(this.Btn_BuscarPorDataPgto);
            this.Controls.Add(this.Date_DataMaximaPgto);
            this.Controls.Add(this.Label_DataMaximaPgto);
            this.Controls.Add(this.Date_DataMinimaPgto);
            this.Controls.Add(this.Label_DataMinimaPgto);
            this.Name = "FormListarPagamento";
            this.Text = "Lista de Pagamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListarPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_DataMinimaPgto;
        private System.Windows.Forms.DateTimePicker Date_DataMinimaPgto;
        private System.Windows.Forms.Label Label_DataMaximaPgto;
        private System.Windows.Forms.DateTimePicker Date_DataMaximaPgto;
        private System.Windows.Forms.Button Btn_BuscarPorDataPgto;
        private System.Windows.Forms.Button Btn_VoltarCadPgto;
        private System.Windows.Forms.ListView LstView_ListaPgto;
        private System.Windows.Forms.Label Label_NumeroPedidoPag;
        private System.Windows.Forms.TextBox Txt_NumeroPedidoPag;
        private System.Windows.Forms.Button Btn_BuscarPorTipoPgto;
        private System.Windows.Forms.Label Label_QuantidadePgto;
        private System.Windows.Forms.Label Label_CalcularQuantPgto;
        private System.Windows.Forms.Button Btn_ExcluirPgto;
        private System.Windows.Forms.Button Btn_EditarPgto;
        private System.Windows.Forms.Button Btn_BuscarPorNumPedido;
        private System.Windows.Forms.Label Label_TipoPgtoPed;
        private System.Windows.Forms.Button Btn_BuscarPorStatusPgto;
        private System.Windows.Forms.Label Label_StatusPgtoPed;
        private System.Windows.Forms.ComboBox Cbo_TipoPgtoPedListar;
        private System.Windows.Forms.ComboBox Cbo_StatusPgtoPedListar;
        private System.Windows.Forms.Label Label_ClientePgtoPedido;
        private System.Windows.Forms.TextBox Txt_ClientePgtoBusca;
        private System.Windows.Forms.Button Btn_BuscarPorCliente;
        private System.Windows.Forms.Label Label_PedidosDinheiro;
        private System.Windows.Forms.Label Label_CalculaPedDinheiro;
        private System.Windows.Forms.Label Label_PedidosTransferencia;
        private System.Windows.Forms.Label Label_CalculaPedTransf;
        private System.Windows.Forms.Label Label_PedidosCartao;
        private System.Windows.Forms.Label Label_CalculaPedCartao;
        private System.Windows.Forms.Label Label_TotalLivreCaixa;
        private System.Windows.Forms.Label Label_CalculaTotalLivreCaixa;
    }
}