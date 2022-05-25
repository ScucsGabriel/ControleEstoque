namespace ProjetoCasa
{
    partial class FormListarPedido
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
            this.components = new System.ComponentModel.Container();
            this.Label_DataMinimaPed = new System.Windows.Forms.Label();
            this.Date_DataMinimaPed = new System.Windows.Forms.DateTimePicker();
            this.Label_DataMaximaPed = new System.Windows.Forms.Label();
            this.Date_DataMaximaPed = new System.Windows.Forms.DateTimePicker();
            this.Btn_BuscarPorDataPed = new System.Windows.Forms.Button();
            this.Btn_VoltarCadPed = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LstView_ListaPed = new System.Windows.Forms.ListView();
            this.Label_ClientePed = new System.Windows.Forms.Label();
            this.Txt_ClienteBuscaPed = new System.Windows.Forms.TextBox();
            this.Btn_BuscarPorClientePed = new System.Windows.Forms.Button();
            this.Label_QuantidadeVendas = new System.Windows.Forms.Label();
            this.Label_CalculaQuantidade = new System.Windows.Forms.Label();
            this.Btn_ExcluirPedido = new System.Windows.Forms.Button();
            this.Label_NumeroPedidoList = new System.Windows.Forms.Label();
            this.Txt_BuscaNumeroPedido = new System.Windows.Forms.TextBox();
            this.Btn_BuscarNumeroPedido = new System.Windows.Forms.Button();
            this.Btn_DetalhesPedido = new System.Windows.Forms.Button();
            this.Label_TotaisVenda = new System.Windows.Forms.Label();
            this.Label_SomaTotaisVenda = new System.Windows.Forms.Label();
            this.Label_TotalLucro = new System.Windows.Forms.Label();
            this.Label_SomaTotalLucro = new System.Windows.Forms.Label();
            this.Label_PorcMediaLucro = new System.Windows.Forms.Label();
            this.Label_CalculaPorcMedia = new System.Windows.Forms.Label();
            this.Label_FreteTotal = new System.Windows.Forms.Label();
            this.Label_CalculaFreteTotal = new System.Windows.Forms.Label();
            this.Label_TipoFrete = new System.Windows.Forms.Label();
            this.Cbo_TipoFrete = new System.Windows.Forms.ComboBox();
            this.Btn_BuscarPorTipoFrete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_DataMinimaPed
            // 
            this.Label_DataMinimaPed.AutoSize = true;
            this.Label_DataMinimaPed.Location = new System.Drawing.Point(65, 32);
            this.Label_DataMinimaPed.Name = "Label_DataMinimaPed";
            this.Label_DataMinimaPed.Size = new System.Drawing.Size(68, 13);
            this.Label_DataMinimaPed.TabIndex = 14;
            this.Label_DataMinimaPed.Text = "Data Mínima";
            // 
            // Date_DataMinimaPed
            // 
            this.Date_DataMinimaPed.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataMinimaPed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataMinimaPed.Location = new System.Drawing.Point(139, 26);
            this.Date_DataMinimaPed.Name = "Date_DataMinimaPed";
            this.Date_DataMinimaPed.Size = new System.Drawing.Size(237, 20);
            this.Date_DataMinimaPed.TabIndex = 1;
            // 
            // Label_DataMaximaPed
            // 
            this.Label_DataMaximaPed.AutoSize = true;
            this.Label_DataMaximaPed.Location = new System.Drawing.Point(388, 33);
            this.Label_DataMaximaPed.Name = "Label_DataMaximaPed";
            this.Label_DataMaximaPed.Size = new System.Drawing.Size(69, 13);
            this.Label_DataMaximaPed.TabIndex = 15;
            this.Label_DataMaximaPed.Text = "Data Máxima";
            // 
            // Date_DataMaximaPed
            // 
            this.Date_DataMaximaPed.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataMaximaPed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataMaximaPed.Location = new System.Drawing.Point(469, 28);
            this.Date_DataMaximaPed.Name = "Date_DataMaximaPed";
            this.Date_DataMaximaPed.Size = new System.Drawing.Size(237, 20);
            this.Date_DataMaximaPed.TabIndex = 2;
            // 
            // Btn_BuscarPorDataPed
            // 
            this.Btn_BuscarPorDataPed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorDataPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarPorDataPed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorDataPed.Location = new System.Drawing.Point(26, 94);
            this.Btn_BuscarPorDataPed.Name = "Btn_BuscarPorDataPed";
            this.Btn_BuscarPorDataPed.Size = new System.Drawing.Size(134, 33);
            this.Btn_BuscarPorDataPed.TabIndex = 6;
            this.Btn_BuscarPorDataPed.Text = "Buscar por Data";
            this.Btn_BuscarPorDataPed.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorDataPed.Click += new System.EventHandler(this.Btn_BuscarPorDataPed_Click);
            // 
            // Btn_VoltarCadPed
            // 
            this.Btn_VoltarCadPed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarCadPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCadPed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarCadPed.Location = new System.Drawing.Point(864, 91);
            this.Btn_VoltarCadPed.Name = "Btn_VoltarCadPed";
            this.Btn_VoltarCadPed.Size = new System.Drawing.Size(134, 34);
            this.Btn_VoltarCadPed.TabIndex = 12;
            this.Btn_VoltarCadPed.Text = "Voltar";
            this.Btn_VoltarCadPed.UseVisualStyleBackColor = false;
            this.Btn_VoltarCadPed.Click += new System.EventHandler(this.Btn_VoltarCadPed_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            // 
            // pedidoBindingSource1
            // 
            this.pedidoBindingSource1.DataMember = "Pedido";
            // 
            // LstView_ListaPed
            // 
            this.LstView_ListaPed.AllowColumnReorder = true;
            this.LstView_ListaPed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaPed.HideSelection = false;
            this.LstView_ListaPed.Location = new System.Drawing.Point(26, 143);
            this.LstView_ListaPed.Name = "LstView_ListaPed";
            this.LstView_ListaPed.Size = new System.Drawing.Size(1319, 466);
            this.LstView_ListaPed.TabIndex = 13;
            this.LstView_ListaPed.UseCompatibleStateImageBehavior = false;
            this.LstView_ListaPed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_ListaPed_KeyDown);
            // 
            // Label_ClientePed
            // 
            this.Label_ClientePed.AutoSize = true;
            this.Label_ClientePed.Location = new System.Drawing.Point(40, 69);
            this.Label_ClientePed.Name = "Label_ClientePed";
            this.Label_ClientePed.Size = new System.Drawing.Size(93, 13);
            this.Label_ClientePed.TabIndex = 17;
            this.Label_ClientePed.Text = "Cliente / Cachorro";
            // 
            // Txt_ClienteBuscaPed
            // 
            this.Txt_ClienteBuscaPed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ClienteBuscaPed.Location = new System.Drawing.Point(139, 61);
            this.Txt_ClienteBuscaPed.Name = "Txt_ClienteBuscaPed";
            this.Txt_ClienteBuscaPed.Size = new System.Drawing.Size(237, 21);
            this.Txt_ClienteBuscaPed.TabIndex = 4;
            // 
            // Btn_BuscarPorClientePed
            // 
            this.Btn_BuscarPorClientePed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorClientePed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BuscarPorClientePed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorClientePed.Location = new System.Drawing.Point(306, 92);
            this.Btn_BuscarPorClientePed.Name = "Btn_BuscarPorClientePed";
            this.Btn_BuscarPorClientePed.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarPorClientePed.TabIndex = 8;
            this.Btn_BuscarPorClientePed.Text = "Buscar por Cliente";
            this.Btn_BuscarPorClientePed.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorClientePed.Click += new System.EventHandler(this.Btn_BuscarPorClientePed_Click);
            // 
            // Label_QuantidadeVendas
            // 
            this.Label_QuantidadeVendas.AutoSize = true;
            this.Label_QuantidadeVendas.Location = new System.Drawing.Point(25, 623);
            this.Label_QuantidadeVendas.Name = "Label_QuantidadeVendas";
            this.Label_QuantidadeVendas.Size = new System.Drawing.Size(118, 13);
            this.Label_QuantidadeVendas.TabIndex = 19;
            this.Label_QuantidadeVendas.Text = "Quantidade de Pedidos";
            // 
            // Label_CalculaQuantidade
            // 
            this.Label_CalculaQuantidade.AutoSize = true;
            this.Label_CalculaQuantidade.Location = new System.Drawing.Point(25, 654);
            this.Label_CalculaQuantidade.Name = "Label_CalculaQuantidade";
            this.Label_CalculaQuantidade.Size = new System.Drawing.Size(13, 13);
            this.Label_CalculaQuantidade.TabIndex = 20;
            this.Label_CalculaQuantidade.Text = "0";
            // 
            // Btn_ExcluirPedido
            // 
            this.Btn_ExcluirPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirPedido.Location = new System.Drawing.Point(724, 93);
            this.Btn_ExcluirPedido.Name = "Btn_ExcluirPedido";
            this.Btn_ExcluirPedido.Size = new System.Drawing.Size(134, 33);
            this.Btn_ExcluirPedido.TabIndex = 11;
            this.Btn_ExcluirPedido.Text = "Excluir";
            this.Btn_ExcluirPedido.UseVisualStyleBackColor = false;
            this.Btn_ExcluirPedido.Click += new System.EventHandler(this.Btn_ExcluirPedido_Click);
            // 
            // Label_NumeroPedidoList
            // 
            this.Label_NumeroPedidoList.AutoSize = true;
            this.Label_NumeroPedidoList.Location = new System.Drawing.Point(719, 32);
            this.Label_NumeroPedidoList.Name = "Label_NumeroPedidoList";
            this.Label_NumeroPedidoList.Size = new System.Drawing.Size(95, 13);
            this.Label_NumeroPedidoList.TabIndex = 16;
            this.Label_NumeroPedidoList.Text = "Número do Pedido";
            // 
            // Txt_BuscaNumeroPedido
            // 
            this.Txt_BuscaNumeroPedido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BuscaNumeroPedido.Location = new System.Drawing.Point(820, 28);
            this.Txt_BuscaNumeroPedido.Name = "Txt_BuscaNumeroPedido";
            this.Txt_BuscaNumeroPedido.Size = new System.Drawing.Size(237, 21);
            this.Txt_BuscaNumeroPedido.TabIndex = 3;
            // 
            // Btn_BuscarNumeroPedido
            // 
            this.Btn_BuscarNumeroPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_BuscarNumeroPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarNumeroPedido.Location = new System.Drawing.Point(166, 92);
            this.Btn_BuscarNumeroPedido.Name = "Btn_BuscarNumeroPedido";
            this.Btn_BuscarNumeroPedido.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarNumeroPedido.TabIndex = 7;
            this.Btn_BuscarNumeroPedido.Text = "Buscar por Número";
            this.Btn_BuscarNumeroPedido.UseVisualStyleBackColor = false;
            this.Btn_BuscarNumeroPedido.Click += new System.EventHandler(this.Btn_BuscarNumeroPedido_Click);
            // 
            // Btn_DetalhesPedido
            // 
            this.Btn_DetalhesPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_DetalhesPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DetalhesPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_DetalhesPedido.Location = new System.Drawing.Point(584, 93);
            this.Btn_DetalhesPedido.Name = "Btn_DetalhesPedido";
            this.Btn_DetalhesPedido.Size = new System.Drawing.Size(134, 33);
            this.Btn_DetalhesPedido.TabIndex = 10;
            this.Btn_DetalhesPedido.Text = "Detalhes";
            this.Btn_DetalhesPedido.UseVisualStyleBackColor = false;
            this.Btn_DetalhesPedido.Click += new System.EventHandler(this.Btn_DetalhesPedido_Click);
            // 
            // Label_TotaisVenda
            // 
            this.Label_TotaisVenda.AutoSize = true;
            this.Label_TotaisVenda.Location = new System.Drawing.Point(303, 623);
            this.Label_TotaisVenda.Name = "Label_TotaisVenda";
            this.Label_TotaisVenda.Size = new System.Drawing.Size(187, 13);
            this.Label_TotaisVenda.TabIndex = 23;
            this.Label_TotaisVenda.Text = "Soma de Totais da Venda (Sem Frete)";
            // 
            // Label_SomaTotaisVenda
            // 
            this.Label_SomaTotaisVenda.AutoSize = true;
            this.Label_SomaTotaisVenda.Location = new System.Drawing.Point(303, 654);
            this.Label_SomaTotaisVenda.Name = "Label_SomaTotaisVenda";
            this.Label_SomaTotaisVenda.Size = new System.Drawing.Size(42, 13);
            this.Label_SomaTotaisVenda.TabIndex = 24;
            this.Label_SomaTotaisVenda.Text = "R$0,00";
            // 
            // Label_TotalLucro
            // 
            this.Label_TotalLucro.AutoSize = true;
            this.Label_TotalLucro.Location = new System.Drawing.Point(507, 623);
            this.Label_TotalLucro.Name = "Label_TotalLucro";
            this.Label_TotalLucro.Size = new System.Drawing.Size(106, 13);
            this.Label_TotalLucro.TabIndex = 25;
            this.Label_TotalLucro.Text = "Soma Total de Lucro";
            // 
            // Label_SomaTotalLucro
            // 
            this.Label_SomaTotalLucro.AutoSize = true;
            this.Label_SomaTotalLucro.Location = new System.Drawing.Point(512, 654);
            this.Label_SomaTotalLucro.Name = "Label_SomaTotalLucro";
            this.Label_SomaTotalLucro.Size = new System.Drawing.Size(42, 13);
            this.Label_SomaTotalLucro.TabIndex = 26;
            this.Label_SomaTotalLucro.Text = "R$0,00";
            // 
            // Label_PorcMediaLucro
            // 
            this.Label_PorcMediaLucro.AutoSize = true;
            this.Label_PorcMediaLucro.Location = new System.Drawing.Point(619, 623);
            this.Label_PorcMediaLucro.Name = "Label_PorcMediaLucro";
            this.Label_PorcMediaLucro.Size = new System.Drawing.Size(87, 13);
            this.Label_PorcMediaLucro.TabIndex = 27;
            this.Label_PorcMediaLucro.Text = "% Total de Lucro";
            // 
            // Label_CalculaPorcMedia
            // 
            this.Label_CalculaPorcMedia.AutoSize = true;
            this.Label_CalculaPorcMedia.Location = new System.Drawing.Point(619, 654);
            this.Label_CalculaPorcMedia.Name = "Label_CalculaPorcMedia";
            this.Label_CalculaPorcMedia.Size = new System.Drawing.Size(21, 13);
            this.Label_CalculaPorcMedia.TabIndex = 28;
            this.Label_CalculaPorcMedia.Text = "0%";
            // 
            // Label_FreteTotal
            // 
            this.Label_FreteTotal.AutoSize = true;
            this.Label_FreteTotal.Location = new System.Drawing.Point(159, 623);
            this.Label_FreteTotal.Name = "Label_FreteTotal";
            this.Label_FreteTotal.Size = new System.Drawing.Size(123, 13);
            this.Label_FreteTotal.TabIndex = 21;
            this.Label_FreteTotal.Text = "Soma de Totais de Frete";
            // 
            // Label_CalculaFreteTotal
            // 
            this.Label_CalculaFreteTotal.AutoSize = true;
            this.Label_CalculaFreteTotal.Location = new System.Drawing.Point(159, 654);
            this.Label_CalculaFreteTotal.Name = "Label_CalculaFreteTotal";
            this.Label_CalculaFreteTotal.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaFreteTotal.TabIndex = 22;
            this.Label_CalculaFreteTotal.Text = "R$0,00";
            // 
            // Label_TipoFrete
            // 
            this.Label_TipoFrete.AutoSize = true;
            this.Label_TipoFrete.Location = new System.Drawing.Point(387, 62);
            this.Label_TipoFrete.Name = "Label_TipoFrete";
            this.Label_TipoFrete.Size = new System.Drawing.Size(70, 13);
            this.Label_TipoFrete.TabIndex = 18;
            this.Label_TipoFrete.Text = "Tipo de Frete";
            // 
            // Cbo_TipoFrete
            // 
            this.Cbo_TipoFrete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoFrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_TipoFrete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_TipoFrete.FormattingEnabled = true;
            this.Cbo_TipoFrete.Location = new System.Drawing.Point(469, 57);
            this.Cbo_TipoFrete.Name = "Cbo_TipoFrete";
            this.Cbo_TipoFrete.Size = new System.Drawing.Size(237, 23);
            this.Cbo_TipoFrete.TabIndex = 5;
            // 
            // Btn_BuscarPorTipoFrete
            // 
            this.Btn_BuscarPorTipoFrete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorTipoFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_BuscarPorTipoFrete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorTipoFrete.Location = new System.Drawing.Point(446, 92);
            this.Btn_BuscarPorTipoFrete.Name = "Btn_BuscarPorTipoFrete";
            this.Btn_BuscarPorTipoFrete.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarPorTipoFrete.TabIndex = 9;
            this.Btn_BuscarPorTipoFrete.Text = "Buscar por Tipo de Frete";
            this.Btn_BuscarPorTipoFrete.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorTipoFrete.Click += new System.EventHandler(this.Btn_BuscarPorTipoFrete_Click);
            // 
            // FormListarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 686);
            this.Controls.Add(this.Btn_BuscarPorTipoFrete);
            this.Controls.Add(this.Cbo_TipoFrete);
            this.Controls.Add(this.Label_TipoFrete);
            this.Controls.Add(this.Label_CalculaFreteTotal);
            this.Controls.Add(this.Label_FreteTotal);
            this.Controls.Add(this.Label_CalculaPorcMedia);
            this.Controls.Add(this.Label_PorcMediaLucro);
            this.Controls.Add(this.Label_SomaTotalLucro);
            this.Controls.Add(this.Label_TotalLucro);
            this.Controls.Add(this.Label_SomaTotaisVenda);
            this.Controls.Add(this.Label_TotaisVenda);
            this.Controls.Add(this.Btn_DetalhesPedido);
            this.Controls.Add(this.Btn_BuscarNumeroPedido);
            this.Controls.Add(this.Txt_BuscaNumeroPedido);
            this.Controls.Add(this.Label_NumeroPedidoList);
            this.Controls.Add(this.Btn_ExcluirPedido);
            this.Controls.Add(this.Label_CalculaQuantidade);
            this.Controls.Add(this.Label_QuantidadeVendas);
            this.Controls.Add(this.Btn_BuscarPorClientePed);
            this.Controls.Add(this.Txt_ClienteBuscaPed);
            this.Controls.Add(this.Label_ClientePed);
            this.Controls.Add(this.LstView_ListaPed);
            this.Controls.Add(this.Btn_VoltarCadPed);
            this.Controls.Add(this.Btn_BuscarPorDataPed);
            this.Controls.Add(this.Date_DataMaximaPed);
            this.Controls.Add(this.Label_DataMaximaPed);
            this.Controls.Add(this.Date_DataMinimaPed);
            this.Controls.Add(this.Label_DataMinimaPed);
            this.Name = "FormListarPedido";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Lista de Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_DataMinimaPed;
        private System.Windows.Forms.DateTimePicker Date_DataMinimaPed;
        private System.Windows.Forms.Label Label_DataMaximaPed;
        private System.Windows.Forms.DateTimePicker Date_DataMaximaPed;
        private System.Windows.Forms.Button Btn_BuscarPorDataPed;
        private System.Windows.Forms.Button Btn_VoltarCadPed;
        //private BD_ProjetoCasaDataSet bD_ProjetoCasaDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        //private BD_ProjetoCasaDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        //private ProjetoCasaDataSet projetoCasaDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        //private ProjetoCasaDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        //private ProjetoCasaDataSet1 projetoCasaDataSet1;
        private System.Windows.Forms.BindingSource pedidoBindingSource1;
        //private ProjetoCasaDataSet1TableAdapters.PedidoTableAdapter pedidoTableAdapter1;
        private System.Windows.Forms.ListView LstView_ListaPed;
        private System.Windows.Forms.Label Label_ClientePed;
        private System.Windows.Forms.TextBox Txt_ClienteBuscaPed;
        private System.Windows.Forms.Button Btn_BuscarPorClientePed;
        private System.Windows.Forms.Label Label_QuantidadeVendas;
        private System.Windows.Forms.Label Label_CalculaQuantidade;
        private System.Windows.Forms.Button Btn_ExcluirPedido;
        private System.Windows.Forms.Label Label_NumeroPedidoList;
        private System.Windows.Forms.TextBox Txt_BuscaNumeroPedido;
        private System.Windows.Forms.Button Btn_BuscarNumeroPedido;
        private System.Windows.Forms.Button Btn_DetalhesPedido;
        private System.Windows.Forms.Label Label_TotaisVenda;
        private System.Windows.Forms.Label Label_SomaTotaisVenda;
        private System.Windows.Forms.Label Label_TotalLucro;
        private System.Windows.Forms.Label Label_SomaTotalLucro;
        private System.Windows.Forms.Label Label_PorcMediaLucro;
        private System.Windows.Forms.Label Label_CalculaPorcMedia;
        private System.Windows.Forms.Label Label_FreteTotal;
        private System.Windows.Forms.Label Label_CalculaFreteTotal;
        private System.Windows.Forms.Label Label_TipoFrete;
        private System.Windows.Forms.ComboBox Cbo_TipoFrete;
        private System.Windows.Forms.Button Btn_BuscarPorTipoFrete;
    }
}