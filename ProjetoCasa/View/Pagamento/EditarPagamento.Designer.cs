namespace ProjetoCasa
{
    partial class FormEditarPagamento
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
            this.Label_NumeroPedidoPgtoEdit = new System.Windows.Forms.Label();
            this.Cbo_ClientePgtoEdit = new System.Windows.Forms.ComboBox();
            this.Label_ValorVendaPedEdit = new System.Windows.Forms.Label();
            this.Label_CalculaValorVendaPedEdit = new System.Windows.Forms.Label();
            this.Label_StatusPgtoPedEdit = new System.Windows.Forms.Label();
            this.Cbo_StatusPgtoPedEdit = new System.Windows.Forms.ComboBox();
            this.Label_TipoPgtoEdit = new System.Windows.Forms.Label();
            this.Cbo_TipoPgtoPedEdit = new System.Windows.Forms.ComboBox();
            this.Label_ValorPagoEdit = new System.Windows.Forms.Label();
            this.Msk_ValorPagoEdit = new System.Windows.Forms.MaskedTextBox();
            this.Label_DataPgtoEdit = new System.Windows.Forms.Label();
            this.Date_DataPgtoEdit = new System.Windows.Forms.DateTimePicker();
            this.Btn_ListarPgtoEdit = new System.Windows.Forms.Button();
            this.Btn_SalvarPgtoEdit = new System.Windows.Forms.Button();
            this.Label_CodigoPagamento = new System.Windows.Forms.Label();
            this.Label_CodigoPagamentoEdit = new System.Windows.Forms.Label();
            this.Label_ClientePgtoEdit = new System.Windows.Forms.Label();
            this.Label_NumPedidoPgtoEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_NumeroPedidoPgtoEdit
            // 
            this.Label_NumeroPedidoPgtoEdit.AutoSize = true;
            this.Label_NumeroPedidoPgtoEdit.Location = new System.Drawing.Point(57, 84);
            this.Label_NumeroPedidoPgtoEdit.Name = "Label_NumeroPedidoPgtoEdit";
            this.Label_NumeroPedidoPgtoEdit.Size = new System.Drawing.Size(95, 13);
            this.Label_NumeroPedidoPgtoEdit.TabIndex = 13;
            this.Label_NumeroPedidoPgtoEdit.Text = "Número do Pedido";
            // 
            // Cbo_ClientePgtoEdit
            // 
            this.Cbo_ClientePgtoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_ClientePgtoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_ClientePgtoEdit.FormattingEnabled = true;
            this.Cbo_ClientePgtoEdit.Location = new System.Drawing.Point(157, 40);
            this.Cbo_ClientePgtoEdit.Name = "Cbo_ClientePgtoEdit";
            this.Cbo_ClientePgtoEdit.Size = new System.Drawing.Size(183, 23);
            this.Cbo_ClientePgtoEdit.TabIndex = 2;
            this.Cbo_ClientePgtoEdit.Text = "[Pesquisar]";
            this.Cbo_ClientePgtoEdit.DropDown += new System.EventHandler(this.Cbo_ClientePgtoEdit_DropDown);
            this.Cbo_ClientePgtoEdit.SelectedValueChanged += new System.EventHandler(this.Cbo_ClientePgtoEdit_SelectedValueChanged);
            // 
            // Label_ValorVendaPedEdit
            // 
            this.Label_ValorVendaPedEdit.AutoSize = true;
            this.Label_ValorVendaPedEdit.Location = new System.Drawing.Point(71, 125);
            this.Label_ValorVendaPedEdit.Name = "Label_ValorVendaPedEdit";
            this.Label_ValorVendaPedEdit.Size = new System.Drawing.Size(80, 13);
            this.Label_ValorVendaPedEdit.TabIndex = 14;
            this.Label_ValorVendaPedEdit.Text = "Valor da Venda";
            // 
            // Label_CalculaValorVendaPedEdit
            // 
            this.Label_CalculaValorVendaPedEdit.AutoSize = true;
            this.Label_CalculaValorVendaPedEdit.Location = new System.Drawing.Point(154, 125);
            this.Label_CalculaValorVendaPedEdit.Name = "Label_CalculaValorVendaPedEdit";
            this.Label_CalculaValorVendaPedEdit.Size = new System.Drawing.Size(42, 13);
            this.Label_CalculaValorVendaPedEdit.TabIndex = 4;
            this.Label_CalculaValorVendaPedEdit.Text = "R$0,00";
            // 
            // Label_StatusPgtoPedEdit
            // 
            this.Label_StatusPgtoPedEdit.AutoSize = true;
            this.Label_StatusPgtoPedEdit.Location = new System.Drawing.Point(57, 164);
            this.Label_StatusPgtoPedEdit.Name = "Label_StatusPgtoPedEdit";
            this.Label_StatusPgtoPedEdit.Size = new System.Drawing.Size(94, 13);
            this.Label_StatusPgtoPedEdit.TabIndex = 15;
            this.Label_StatusPgtoPedEdit.Text = "Status Pagamento";
            // 
            // Cbo_StatusPgtoPedEdit
            // 
            this.Cbo_StatusPgtoPedEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_StatusPgtoPedEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_StatusPgtoPedEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_StatusPgtoPedEdit.FormattingEnabled = true;
            this.Cbo_StatusPgtoPedEdit.Location = new System.Drawing.Point(157, 160);
            this.Cbo_StatusPgtoPedEdit.Name = "Cbo_StatusPgtoPedEdit";
            this.Cbo_StatusPgtoPedEdit.Size = new System.Drawing.Size(183, 23);
            this.Cbo_StatusPgtoPedEdit.TabIndex = 5;
            this.Cbo_StatusPgtoPedEdit.SelectedValueChanged += new System.EventHandler(this.Cbo_StatusPgtoPed_SelectedValueChanged);
            // 
            // Label_TipoPgtoEdit
            // 
            this.Label_TipoPgtoEdit.AutoSize = true;
            this.Label_TipoPgtoEdit.Location = new System.Drawing.Point(51, 213);
            this.Label_TipoPgtoEdit.Name = "Label_TipoPgtoEdit";
            this.Label_TipoPgtoEdit.Size = new System.Drawing.Size(100, 13);
            this.Label_TipoPgtoEdit.TabIndex = 16;
            this.Label_TipoPgtoEdit.Text = "Tipo do Pagamento";
            // 
            // Cbo_TipoPgtoPedEdit
            // 
            this.Cbo_TipoPgtoPedEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoPgtoPedEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_TipoPgtoPedEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_TipoPgtoPedEdit.FormattingEnabled = true;
            this.Cbo_TipoPgtoPedEdit.Location = new System.Drawing.Point(157, 203);
            this.Cbo_TipoPgtoPedEdit.Name = "Cbo_TipoPgtoPedEdit";
            this.Cbo_TipoPgtoPedEdit.Size = new System.Drawing.Size(183, 23);
            this.Cbo_TipoPgtoPedEdit.TabIndex = 6;
            // 
            // Label_ValorPagoEdit
            // 
            this.Label_ValorPagoEdit.AutoSize = true;
            this.Label_ValorPagoEdit.Location = new System.Drawing.Point(92, 252);
            this.Label_ValorPagoEdit.Name = "Label_ValorPagoEdit";
            this.Label_ValorPagoEdit.Size = new System.Drawing.Size(59, 13);
            this.Label_ValorPagoEdit.TabIndex = 17;
            this.Label_ValorPagoEdit.Text = "Valor Pago";
            // 
            // Msk_ValorPagoEdit
            // 
            this.Msk_ValorPagoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_ValorPagoEdit.Location = new System.Drawing.Point(157, 248);
            this.Msk_ValorPagoEdit.Mask = "$####,##";
            this.Msk_ValorPagoEdit.Name = "Msk_ValorPagoEdit";
            this.Msk_ValorPagoEdit.Size = new System.Drawing.Size(183, 21);
            this.Msk_ValorPagoEdit.TabIndex = 7;
            this.Msk_ValorPagoEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_ValorPago_KeyDown);
            // 
            // Label_DataPgtoEdit
            // 
            this.Label_DataPgtoEdit.AutoSize = true;
            this.Label_DataPgtoEdit.Location = new System.Drawing.Point(49, 283);
            this.Label_DataPgtoEdit.Name = "Label_DataPgtoEdit";
            this.Label_DataPgtoEdit.Size = new System.Drawing.Size(102, 13);
            this.Label_DataPgtoEdit.TabIndex = 18;
            this.Label_DataPgtoEdit.Text = "Data do Pagamento";
            // 
            // Date_DataPgtoEdit
            // 
            this.Date_DataPgtoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataPgtoEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataPgtoEdit.Location = new System.Drawing.Point(157, 283);
            this.Date_DataPgtoEdit.Name = "Date_DataPgtoEdit";
            this.Date_DataPgtoEdit.Size = new System.Drawing.Size(183, 21);
            this.Date_DataPgtoEdit.TabIndex = 8;
            // 
            // Btn_ListarPgtoEdit
            // 
            this.Btn_ListarPgtoEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ListarPgtoEdit.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_ListarPgtoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListarPgtoEdit.Location = new System.Drawing.Point(17, 328);
            this.Btn_ListarPgtoEdit.Name = "Btn_ListarPgtoEdit";
            this.Btn_ListarPgtoEdit.Size = new System.Drawing.Size(121, 38);
            this.Btn_ListarPgtoEdit.TabIndex = 9;
            this.Btn_ListarPgtoEdit.Text = "Listar";
            this.Btn_ListarPgtoEdit.UseVisualStyleBackColor = false;
            // 
            // Btn_SalvarPgtoEdit
            // 
            this.Btn_SalvarPgtoEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarPgtoEdit.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarPgtoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarPgtoEdit.Location = new System.Drawing.Point(219, 327);
            this.Btn_SalvarPgtoEdit.Name = "Btn_SalvarPgtoEdit";
            this.Btn_SalvarPgtoEdit.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarPgtoEdit.TabIndex = 10;
            this.Btn_SalvarPgtoEdit.Text = "Salvar";
            this.Btn_SalvarPgtoEdit.UseVisualStyleBackColor = false;
            this.Btn_SalvarPgtoEdit.Click += new System.EventHandler(this.Btn_SalvarPgto_Click);
            // 
            // Label_CodigoPagamento
            // 
            this.Label_CodigoPagamento.AutoSize = true;
            this.Label_CodigoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoPagamento.Location = new System.Drawing.Point(154, 9);
            this.Label_CodigoPagamento.Name = "Label_CodigoPagamento";
            this.Label_CodigoPagamento.Size = new System.Drawing.Size(14, 15);
            this.Label_CodigoPagamento.TabIndex = 1;
            this.Label_CodigoPagamento.Text = "0";
            // 
            // Label_CodigoPagamentoEdit
            // 
            this.Label_CodigoPagamentoEdit.AutoSize = true;
            this.Label_CodigoPagamentoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoPagamentoEdit.Location = new System.Drawing.Point(105, 9);
            this.Label_CodigoPagamentoEdit.Name = "Label_CodigoPagamentoEdit";
            this.Label_CodigoPagamentoEdit.Size = new System.Drawing.Size(46, 15);
            this.Label_CodigoPagamentoEdit.TabIndex = 11;
            this.Label_CodigoPagamentoEdit.Text = "Código";
            // 
            // Label_ClientePgtoEdit
            // 
            this.Label_ClientePgtoEdit.AutoSize = true;
            this.Label_ClientePgtoEdit.Location = new System.Drawing.Point(112, 44);
            this.Label_ClientePgtoEdit.Name = "Label_ClientePgtoEdit";
            this.Label_ClientePgtoEdit.Size = new System.Drawing.Size(39, 13);
            this.Label_ClientePgtoEdit.TabIndex = 12;
            this.Label_ClientePgtoEdit.Text = "Cliente";
            // 
            // Label_NumPedidoPgtoEdit
            // 
            this.Label_NumPedidoPgtoEdit.AutoSize = true;
            this.Label_NumPedidoPgtoEdit.Location = new System.Drawing.Point(155, 84);
            this.Label_NumPedidoPgtoEdit.Name = "Label_NumPedidoPgtoEdit";
            this.Label_NumPedidoPgtoEdit.Size = new System.Drawing.Size(13, 13);
            this.Label_NumPedidoPgtoEdit.TabIndex = 3;
            this.Label_NumPedidoPgtoEdit.Text = "0";
            // 
            // FormEditarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 376);
            this.Controls.Add(this.Label_NumPedidoPgtoEdit);
            this.Controls.Add(this.Label_ClientePgtoEdit);
            this.Controls.Add(this.Label_CodigoPagamento);
            this.Controls.Add(this.Label_CodigoPagamentoEdit);
            this.Controls.Add(this.Btn_ListarPgtoEdit);
            this.Controls.Add(this.Btn_SalvarPgtoEdit);
            this.Controls.Add(this.Date_DataPgtoEdit);
            this.Controls.Add(this.Label_DataPgtoEdit);
            this.Controls.Add(this.Msk_ValorPagoEdit);
            this.Controls.Add(this.Label_ValorPagoEdit);
            this.Controls.Add(this.Cbo_TipoPgtoPedEdit);
            this.Controls.Add(this.Label_TipoPgtoEdit);
            this.Controls.Add(this.Cbo_StatusPgtoPedEdit);
            this.Controls.Add(this.Label_StatusPgtoPedEdit);
            this.Controls.Add(this.Label_CalculaValorVendaPedEdit);
            this.Controls.Add(this.Label_ValorVendaPedEdit);
            this.Controls.Add(this.Cbo_ClientePgtoEdit);
            this.Controls.Add(this.Label_NumeroPedidoPgtoEdit);
            this.Name = "FormEditarPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_NumeroPedidoPgtoEdit;
        private System.Windows.Forms.ComboBox Cbo_ClientePgtoEdit;
        private System.Windows.Forms.Label Label_ValorVendaPedEdit;
        private System.Windows.Forms.Label Label_CalculaValorVendaPedEdit;
        private System.Windows.Forms.Label Label_StatusPgtoPedEdit;
        private System.Windows.Forms.ComboBox Cbo_StatusPgtoPedEdit;
        private System.Windows.Forms.Label Label_TipoPgtoEdit;
        private System.Windows.Forms.ComboBox Cbo_TipoPgtoPedEdit;
        private System.Windows.Forms.Label Label_ValorPagoEdit;
        private System.Windows.Forms.MaskedTextBox Msk_ValorPagoEdit;
        private System.Windows.Forms.Label Label_DataPgtoEdit;
        private System.Windows.Forms.DateTimePicker Date_DataPgtoEdit;
        private System.Windows.Forms.Button Btn_ListarPgtoEdit;
        private System.Windows.Forms.Button Btn_SalvarPgtoEdit;
        private System.Windows.Forms.Label Label_CodigoPagamento;
        private System.Windows.Forms.Label Label_CodigoPagamentoEdit;
        private System.Windows.Forms.Label Label_ClientePgtoEdit;
        private System.Windows.Forms.Label Label_NumPedidoPgtoEdit;
    }
}