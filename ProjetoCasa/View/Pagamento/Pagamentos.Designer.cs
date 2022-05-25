namespace ProjetoCasa
{
    partial class FormPagamento
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
            this.Label_NumeroPedidoPgto = new System.Windows.Forms.Label();
            this.Cbo_ClientePgto = new System.Windows.Forms.ComboBox();
            this.Label_ValorVendaPed = new System.Windows.Forms.Label();
            this.Label_CalculaValorVendaPed = new System.Windows.Forms.Label();
            this.Label_StatusPgtoPed = new System.Windows.Forms.Label();
            this.Cbo_StatusPgtoPed = new System.Windows.Forms.ComboBox();
            this.Label_TipoPgto = new System.Windows.Forms.Label();
            this.Cbo_TipoPgtoPed = new System.Windows.Forms.ComboBox();
            this.Label_ValorPago = new System.Windows.Forms.Label();
            this.Msk_ValorPago = new System.Windows.Forms.MaskedTextBox();
            this.Label_DataPgto = new System.Windows.Forms.Label();
            this.Date_DataPgto = new System.Windows.Forms.DateTimePicker();
            this.Btn_ListarPgto = new System.Windows.Forms.Button();
            this.Btn_SalvarPgto = new System.Windows.Forms.Button();
            this.Label_ClientePgto = new System.Windows.Forms.Label();
            this.Label_NumPedidoPgto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_NumeroPedidoPgto
            // 
            this.Label_NumeroPedidoPgto.AutoSize = true;
            this.Label_NumeroPedidoPgto.Location = new System.Drawing.Point(53, 62);
            this.Label_NumeroPedidoPgto.Name = "Label_NumeroPedidoPgto";
            this.Label_NumeroPedidoPgto.Size = new System.Drawing.Size(95, 13);
            this.Label_NumeroPedidoPgto.TabIndex = 11;
            this.Label_NumeroPedidoPgto.Text = "Número do Pedido";
            // 
            // Cbo_ClientePgto
            // 
            this.Cbo_ClientePgto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_ClientePgto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_ClientePgto.FormattingEnabled = true;
            this.Cbo_ClientePgto.Location = new System.Drawing.Point(153, 26);
            this.Cbo_ClientePgto.Name = "Cbo_ClientePgto";
            this.Cbo_ClientePgto.Size = new System.Drawing.Size(183, 23);
            this.Cbo_ClientePgto.TabIndex = 1;
            this.Cbo_ClientePgto.Text = "[Pesquisar]";
            this.Cbo_ClientePgto.DropDown += new System.EventHandler(this.Cbo_ClientePgto_DropDown);
            this.Cbo_ClientePgto.SelectedValueChanged += new System.EventHandler(this.Cbo_ClientePgto_SelectedValueChanged);
            // 
            // Label_ValorVendaPed
            // 
            this.Label_ValorVendaPed.AutoSize = true;
            this.Label_ValorVendaPed.Location = new System.Drawing.Point(67, 98);
            this.Label_ValorVendaPed.Name = "Label_ValorVendaPed";
            this.Label_ValorVendaPed.Size = new System.Drawing.Size(80, 13);
            this.Label_ValorVendaPed.TabIndex = 12;
            this.Label_ValorVendaPed.Text = "Valor da Venda";
            // 
            // Label_CalculaValorVendaPed
            // 
            this.Label_CalculaValorVendaPed.AutoSize = true;
            this.Label_CalculaValorVendaPed.Location = new System.Drawing.Point(150, 98);
            this.Label_CalculaValorVendaPed.Name = "Label_CalculaValorVendaPed";
            this.Label_CalculaValorVendaPed.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaValorVendaPed.TabIndex = 3;
            this.Label_CalculaValorVendaPed.Text = "R$0,00";
            // 
            // Label_StatusPgtoPed
            // 
            this.Label_StatusPgtoPed.AutoSize = true;
            this.Label_StatusPgtoPed.Location = new System.Drawing.Point(53, 137);
            this.Label_StatusPgtoPed.Name = "Label_StatusPgtoPed";
            this.Label_StatusPgtoPed.Size = new System.Drawing.Size(94, 13);
            this.Label_StatusPgtoPed.TabIndex = 13;
            this.Label_StatusPgtoPed.Text = "Status Pagamento";
            // 
            // Cbo_StatusPgtoPed
            // 
            this.Cbo_StatusPgtoPed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_StatusPgtoPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_StatusPgtoPed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_StatusPgtoPed.FormattingEnabled = true;
            this.Cbo_StatusPgtoPed.Location = new System.Drawing.Point(153, 133);
            this.Cbo_StatusPgtoPed.Name = "Cbo_StatusPgtoPed";
            this.Cbo_StatusPgtoPed.Size = new System.Drawing.Size(183, 23);
            this.Cbo_StatusPgtoPed.TabIndex = 4;
            this.Cbo_StatusPgtoPed.SelectedValueChanged += new System.EventHandler(this.Cbo_StatusPgtoPed_SelectedValueChanged);
            // 
            // Label_TipoPgto
            // 
            this.Label_TipoPgto.AutoSize = true;
            this.Label_TipoPgto.Location = new System.Drawing.Point(47, 186);
            this.Label_TipoPgto.Name = "Label_TipoPgto";
            this.Label_TipoPgto.Size = new System.Drawing.Size(100, 13);
            this.Label_TipoPgto.TabIndex = 14;
            this.Label_TipoPgto.Text = "Tipo do Pagamento";
            // 
            // Cbo_TipoPgtoPed
            // 
            this.Cbo_TipoPgtoPed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoPgtoPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_TipoPgtoPed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_TipoPgtoPed.FormattingEnabled = true;
            this.Cbo_TipoPgtoPed.Location = new System.Drawing.Point(153, 176);
            this.Cbo_TipoPgtoPed.Name = "Cbo_TipoPgtoPed";
            this.Cbo_TipoPgtoPed.Size = new System.Drawing.Size(183, 23);
            this.Cbo_TipoPgtoPed.TabIndex = 5;
            // 
            // Label_ValorPago
            // 
            this.Label_ValorPago.AutoSize = true;
            this.Label_ValorPago.Location = new System.Drawing.Point(88, 225);
            this.Label_ValorPago.Name = "Label_ValorPago";
            this.Label_ValorPago.Size = new System.Drawing.Size(59, 13);
            this.Label_ValorPago.TabIndex = 15;
            this.Label_ValorPago.Text = "Valor Pago";
            // 
            // Msk_ValorPago
            // 
            this.Msk_ValorPago.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_ValorPago.Location = new System.Drawing.Point(153, 221);
            this.Msk_ValorPago.Mask = "$####,##";
            this.Msk_ValorPago.Name = "Msk_ValorPago";
            this.Msk_ValorPago.Size = new System.Drawing.Size(183, 21);
            this.Msk_ValorPago.TabIndex = 6;
            this.Msk_ValorPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_ValorPago_KeyDown);
            // 
            // Label_DataPgto
            // 
            this.Label_DataPgto.AutoSize = true;
            this.Label_DataPgto.Location = new System.Drawing.Point(45, 256);
            this.Label_DataPgto.Name = "Label_DataPgto";
            this.Label_DataPgto.Size = new System.Drawing.Size(102, 13);
            this.Label_DataPgto.TabIndex = 16;
            this.Label_DataPgto.Text = "Data do Pagamento";
            // 
            // Date_DataPgto
            // 
            this.Date_DataPgto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataPgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataPgto.Location = new System.Drawing.Point(153, 256);
            this.Date_DataPgto.Name = "Date_DataPgto";
            this.Date_DataPgto.Size = new System.Drawing.Size(183, 21);
            this.Date_DataPgto.TabIndex = 7;
            // 
            // Btn_ListarPgto
            // 
            this.Btn_ListarPgto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ListarPgto.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_ListarPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListarPgto.Location = new System.Drawing.Point(13, 301);
            this.Btn_ListarPgto.Name = "Btn_ListarPgto";
            this.Btn_ListarPgto.Size = new System.Drawing.Size(121, 38);
            this.Btn_ListarPgto.TabIndex = 8;
            this.Btn_ListarPgto.Text = "Listar";
            this.Btn_ListarPgto.UseVisualStyleBackColor = false;
            this.Btn_ListarPgto.Click += new System.EventHandler(this.Btn_ListarPgto_Click);
            // 
            // Btn_SalvarPgto
            // 
            this.Btn_SalvarPgto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarPgto.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarPgto.Location = new System.Drawing.Point(215, 300);
            this.Btn_SalvarPgto.Name = "Btn_SalvarPgto";
            this.Btn_SalvarPgto.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarPgto.TabIndex = 9;
            this.Btn_SalvarPgto.Text = "Salvar";
            this.Btn_SalvarPgto.UseVisualStyleBackColor = false;
            this.Btn_SalvarPgto.Click += new System.EventHandler(this.Btn_SalvarPgto_Click);
            // 
            // Label_ClientePgto
            // 
            this.Label_ClientePgto.AutoSize = true;
            this.Label_ClientePgto.Location = new System.Drawing.Point(108, 30);
            this.Label_ClientePgto.Name = "Label_ClientePgto";
            this.Label_ClientePgto.Size = new System.Drawing.Size(39, 13);
            this.Label_ClientePgto.TabIndex = 10;
            this.Label_ClientePgto.Text = "Cliente";
            // 
            // Label_NumPedidoPgto
            // 
            this.Label_NumPedidoPgto.AutoSize = true;
            this.Label_NumPedidoPgto.Location = new System.Drawing.Point(150, 62);
            this.Label_NumPedidoPgto.Name = "Label_NumPedidoPgto";
            this.Label_NumPedidoPgto.Size = new System.Drawing.Size(13, 13);
            this.Label_NumPedidoPgto.TabIndex = 2;
            this.Label_NumPedidoPgto.Text = "0";
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 363);
            this.Controls.Add(this.Label_NumPedidoPgto);
            this.Controls.Add(this.Label_ClientePgto);
            this.Controls.Add(this.Btn_ListarPgto);
            this.Controls.Add(this.Btn_SalvarPgto);
            this.Controls.Add(this.Date_DataPgto);
            this.Controls.Add(this.Label_DataPgto);
            this.Controls.Add(this.Msk_ValorPago);
            this.Controls.Add(this.Label_ValorPago);
            this.Controls.Add(this.Cbo_TipoPgtoPed);
            this.Controls.Add(this.Label_TipoPgto);
            this.Controls.Add(this.Cbo_StatusPgtoPed);
            this.Controls.Add(this.Label_StatusPgtoPed);
            this.Controls.Add(this.Label_CalculaValorVendaPed);
            this.Controls.Add(this.Label_ValorVendaPed);
            this.Controls.Add(this.Cbo_ClientePgto);
            this.Controls.Add(this.Label_NumeroPedidoPgto);
            this.Name = "FormPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_NumeroPedidoPgto;
        private System.Windows.Forms.ComboBox Cbo_ClientePgto;
        private System.Windows.Forms.Label Label_ValorVendaPed;
        private System.Windows.Forms.Label Label_CalculaValorVendaPed;
        private System.Windows.Forms.Label Label_StatusPgtoPed;
        private System.Windows.Forms.ComboBox Cbo_StatusPgtoPed;
        private System.Windows.Forms.Label Label_TipoPgto;
        private System.Windows.Forms.ComboBox Cbo_TipoPgtoPed;
        private System.Windows.Forms.Label Label_ValorPago;
        private System.Windows.Forms.MaskedTextBox Msk_ValorPago;
        private System.Windows.Forms.Label Label_DataPgto;
        private System.Windows.Forms.DateTimePicker Date_DataPgto;
        private System.Windows.Forms.Button Btn_ListarPgto;
        private System.Windows.Forms.Button Btn_SalvarPgto;
        private System.Windows.Forms.Label Label_ClientePgto;
        private System.Windows.Forms.Label Label_NumPedidoPgto;
    }
}