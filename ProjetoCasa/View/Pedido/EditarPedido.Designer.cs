namespace ProjetoCasa
{
    partial class FormEditarPedido
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
            this.Label_ClienteEdit = new System.Windows.Forms.Label();
            this.Label_ProdutoEdit = new System.Windows.Forms.Label();
            this.Btn_SalvarEditPedido = new System.Windows.Forms.Button();
            this.Label_DataPedidoEdit = new System.Windows.Forms.Label();
            this.Date_DataPedidoEdit = new System.Windows.Forms.DateTimePicker();
            this.Label_ValorVendaEdit = new System.Windows.Forms.Label();
            this.Label_EntregaEdit = new System.Windows.Forms.Label();
            this.Txt_EntregaEdit = new System.Windows.Forms.TextBox();
            this.Label_CodigoPedido = new System.Windows.Forms.Label();
            this.Cbo_NomeClienteEdit = new System.Windows.Forms.ComboBox();
            this.Cbo_DescricaoEdit = new System.Windows.Forms.ComboBox();
            this.Label_NumeroPedidoEdit = new System.Windows.Forms.Label();
            this.Lst_ListaProdutosEdit = new System.Windows.Forms.ListView();
            this.Btn_RemoverEdit = new System.Windows.Forms.Button();
            this.Chk_FreteEdit = new System.Windows.Forms.CheckBox();
            this.Msk_FreteEdit = new System.Windows.Forms.MaskedTextBox();
            this.Rdb_FreteProprioEdit = new System.Windows.Forms.RadioButton();
            this.Rdb_FreteTerceiroEdit = new System.Windows.Forms.RadioButton();
            this.Label_CalculaTotalProdutosEdit = new System.Windows.Forms.Label();
            this.Label_TotalProdutosEdit = new System.Windows.Forms.Label();
            this.Label_CalculaValorVendaPedEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_ClienteEdit
            // 
            this.Label_ClienteEdit.AutoSize = true;
            this.Label_ClienteEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ClienteEdit.Location = new System.Drawing.Point(91, 46);
            this.Label_ClienteEdit.Name = "Label_ClienteEdit";
            this.Label_ClienteEdit.Size = new System.Drawing.Size(45, 15);
            this.Label_ClienteEdit.TabIndex = 16;
            this.Label_ClienteEdit.Text = "Cliente";
            // 
            // Label_ProdutoEdit
            // 
            this.Label_ProdutoEdit.AutoSize = true;
            this.Label_ProdutoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ProdutoEdit.Location = new System.Drawing.Point(80, 81);
            this.Label_ProdutoEdit.Name = "Label_ProdutoEdit";
            this.Label_ProdutoEdit.Size = new System.Drawing.Size(56, 15);
            this.Label_ProdutoEdit.TabIndex = 17;
            this.Label_ProdutoEdit.Text = "Produtos";
            // 
            // Btn_SalvarEditPedido
            // 
            this.Btn_SalvarEditPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarEditPedido.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarEditPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarEditPedido.Location = new System.Drawing.Point(225, 471);
            this.Btn_SalvarEditPedido.Name = "Btn_SalvarEditPedido";
            this.Btn_SalvarEditPedido.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarEditPedido.TabIndex = 14;
            this.Btn_SalvarEditPedido.Text = "Salvar";
            this.Btn_SalvarEditPedido.UseVisualStyleBackColor = false;
            this.Btn_SalvarEditPedido.Click += new System.EventHandler(this.Btn_SalvarEditPedido_Click);
            // 
            // Label_DataPedidoEdit
            // 
            this.Label_DataPedidoEdit.AutoSize = true;
            this.Label_DataPedidoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DataPedidoEdit.Location = new System.Drawing.Point(44, 294);
            this.Label_DataPedidoEdit.Name = "Label_DataPedidoEdit";
            this.Label_DataPedidoEdit.Size = new System.Drawing.Size(92, 15);
            this.Label_DataPedidoEdit.TabIndex = 18;
            this.Label_DataPedidoEdit.Text = "Data do Pedido";
            // 
            // Date_DataPedidoEdit
            // 
            this.Date_DataPedidoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataPedidoEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataPedidoEdit.Location = new System.Drawing.Point(142, 290);
            this.Date_DataPedidoEdit.Name = "Date_DataPedidoEdit";
            this.Date_DataPedidoEdit.Size = new System.Drawing.Size(204, 21);
            this.Date_DataPedidoEdit.TabIndex = 7;
            // 
            // Label_ValorVendaEdit
            // 
            this.Label_ValorVendaEdit.AutoSize = true;
            this.Label_ValorVendaEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ValorVendaEdit.Location = new System.Drawing.Point(48, 403);
            this.Label_ValorVendaEdit.Name = "Label_ValorVendaEdit";
            this.Label_ValorVendaEdit.Size = new System.Drawing.Size(90, 15);
            this.Label_ValorVendaEdit.TabIndex = 20;
            this.Label_ValorVendaEdit.Text = "Valor da Venda";
            // 
            // Label_EntregaEdit
            // 
            this.Label_EntregaEdit.AutoSize = true;
            this.Label_EntregaEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EntregaEdit.Location = new System.Drawing.Point(86, 437);
            this.Label_EntregaEdit.Name = "Label_EntregaEdit";
            this.Label_EntregaEdit.Size = new System.Drawing.Size(50, 15);
            this.Label_EntregaEdit.TabIndex = 21;
            this.Label_EntregaEdit.Text = "Entrega";
            // 
            // Txt_EntregaEdit
            // 
            this.Txt_EntregaEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EntregaEdit.Location = new System.Drawing.Point(142, 435);
            this.Txt_EntregaEdit.Name = "Txt_EntregaEdit";
            this.Txt_EntregaEdit.Size = new System.Drawing.Size(204, 21);
            this.Txt_EntregaEdit.TabIndex = 12;
            // 
            // Label_CodigoPedido
            // 
            this.Label_CodigoPedido.AutoSize = true;
            this.Label_CodigoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoPedido.Location = new System.Drawing.Point(139, 22);
            this.Label_CodigoPedido.Name = "Label_CodigoPedido";
            this.Label_CodigoPedido.Size = new System.Drawing.Size(14, 15);
            this.Label_CodigoPedido.TabIndex = 1;
            this.Label_CodigoPedido.Text = "0";
            // 
            // Cbo_NomeClienteEdit
            // 
            this.Cbo_NomeClienteEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_NomeClienteEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_NomeClienteEdit.FormattingEnabled = true;
            this.Cbo_NomeClienteEdit.Location = new System.Drawing.Point(142, 44);
            this.Cbo_NomeClienteEdit.Name = "Cbo_NomeClienteEdit";
            this.Cbo_NomeClienteEdit.Size = new System.Drawing.Size(204, 23);
            this.Cbo_NomeClienteEdit.TabIndex = 2;
            this.Cbo_NomeClienteEdit.DropDown += new System.EventHandler(this.Cbo_NomeClienteEdit_DropDown);
            // 
            // Cbo_DescricaoEdit
            // 
            this.Cbo_DescricaoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_DescricaoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_DescricaoEdit.FormattingEnabled = true;
            this.Cbo_DescricaoEdit.Location = new System.Drawing.Point(142, 79);
            this.Cbo_DescricaoEdit.Name = "Cbo_DescricaoEdit";
            this.Cbo_DescricaoEdit.Size = new System.Drawing.Size(204, 23);
            this.Cbo_DescricaoEdit.TabIndex = 3;
            this.Cbo_DescricaoEdit.DropDown += new System.EventHandler(this.Cbo_DescricaoEdit_DropDown);
            this.Cbo_DescricaoEdit.SelectedIndexChanged += new System.EventHandler(this.Cbo_DescricaoEdit_SelectedIndexChanged);
            // 
            // Label_NumeroPedidoEdit
            // 
            this.Label_NumeroPedidoEdit.AutoSize = true;
            this.Label_NumeroPedidoEdit.Location = new System.Drawing.Point(43, 24);
            this.Label_NumeroPedidoEdit.Name = "Label_NumeroPedidoEdit";
            this.Label_NumeroPedidoEdit.Size = new System.Drawing.Size(95, 13);
            this.Label_NumeroPedidoEdit.TabIndex = 15;
            this.Label_NumeroPedidoEdit.Text = "Número do Pedido";
            // 
            // Lst_ListaProdutosEdit
            // 
            this.Lst_ListaProdutosEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_ListaProdutosEdit.HideSelection = false;
            this.Lst_ListaProdutosEdit.Location = new System.Drawing.Point(29, 106);
            this.Lst_ListaProdutosEdit.Name = "Lst_ListaProdutosEdit";
            this.Lst_ListaProdutosEdit.Size = new System.Drawing.Size(317, 143);
            this.Lst_ListaProdutosEdit.TabIndex = 4;
            this.Lst_ListaProdutosEdit.UseCompatibleStateImageBehavior = false;
            this.Lst_ListaProdutosEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lst_ListaProdutosEdit_KeyDown);
            // 
            // Btn_RemoverEdit
            // 
            this.Btn_RemoverEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_RemoverEdit.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_RemoverEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_RemoverEdit.Location = new System.Drawing.Point(34, 475);
            this.Btn_RemoverEdit.Name = "Btn_RemoverEdit";
            this.Btn_RemoverEdit.Size = new System.Drawing.Size(121, 38);
            this.Btn_RemoverEdit.TabIndex = 13;
            this.Btn_RemoverEdit.Text = "Remover da Lista";
            this.Btn_RemoverEdit.UseVisualStyleBackColor = false;
            this.Btn_RemoverEdit.Click += new System.EventHandler(this.Btn_RemoverEdit_Click);
            // 
            // Chk_FreteEdit
            // 
            this.Chk_FreteEdit.AutoSize = true;
            this.Chk_FreteEdit.Location = new System.Drawing.Point(86, 332);
            this.Chk_FreteEdit.Name = "Chk_FreteEdit";
            this.Chk_FreteEdit.Size = new System.Drawing.Size(50, 17);
            this.Chk_FreteEdit.TabIndex = 19;
            this.Chk_FreteEdit.Text = "Frete";
            this.Chk_FreteEdit.UseVisualStyleBackColor = true;
            this.Chk_FreteEdit.CheckedChanged += new System.EventHandler(this.Chk_FreteEdit_CheckedChanged);
            // 
            // Msk_FreteEdit
            // 
            this.Msk_FreteEdit.Enabled = false;
            this.Msk_FreteEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_FreteEdit.Location = new System.Drawing.Point(142, 361);
            this.Msk_FreteEdit.Mask = "$####,##";
            this.Msk_FreteEdit.Name = "Msk_FreteEdit";
            this.Msk_FreteEdit.Size = new System.Drawing.Size(204, 21);
            this.Msk_FreteEdit.TabIndex = 10;
            this.Msk_FreteEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_FreteEdit_KeyDown);
            // 
            // Rdb_FreteProprioEdit
            // 
            this.Rdb_FreteProprioEdit.AutoSize = true;
            this.Rdb_FreteProprioEdit.Enabled = false;
            this.Rdb_FreteProprioEdit.Location = new System.Drawing.Point(142, 331);
            this.Rdb_FreteProprioEdit.Name = "Rdb_FreteProprioEdit";
            this.Rdb_FreteProprioEdit.Size = new System.Drawing.Size(58, 17);
            this.Rdb_FreteProprioEdit.TabIndex = 8;
            this.Rdb_FreteProprioEdit.TabStop = true;
            this.Rdb_FreteProprioEdit.Text = "Próprio";
            this.Rdb_FreteProprioEdit.UseVisualStyleBackColor = true;
            // 
            // Rdb_FreteTerceiroEdit
            // 
            this.Rdb_FreteTerceiroEdit.AutoSize = true;
            this.Rdb_FreteTerceiroEdit.Enabled = false;
            this.Rdb_FreteTerceiroEdit.Location = new System.Drawing.Point(282, 332);
            this.Rdb_FreteTerceiroEdit.Name = "Rdb_FreteTerceiroEdit";
            this.Rdb_FreteTerceiroEdit.Size = new System.Drawing.Size(64, 17);
            this.Rdb_FreteTerceiroEdit.TabIndex = 9;
            this.Rdb_FreteTerceiroEdit.TabStop = true;
            this.Rdb_FreteTerceiroEdit.Text = "Terceiro";
            this.Rdb_FreteTerceiroEdit.UseVisualStyleBackColor = true;
            // 
            // Label_CalculaTotalProdutosEdit
            // 
            this.Label_CalculaTotalProdutosEdit.AutoSize = true;
            this.Label_CalculaTotalProdutosEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CalculaTotalProdutosEdit.Location = new System.Drawing.Point(222, 252);
            this.Label_CalculaTotalProdutosEdit.Name = "Label_CalculaTotalProdutosEdit";
            this.Label_CalculaTotalProdutosEdit.Size = new System.Drawing.Size(47, 15);
            this.Label_CalculaTotalProdutosEdit.TabIndex = 6;
            this.Label_CalculaTotalProdutosEdit.Text = "R$0,00";
            // 
            // Label_TotalProdutosEdit
            // 
            this.Label_TotalProdutosEdit.AutoSize = true;
            this.Label_TotalProdutosEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalProdutosEdit.Location = new System.Drawing.Point(112, 252);
            this.Label_TotalProdutosEdit.Name = "Label_TotalProdutosEdit";
            this.Label_TotalProdutosEdit.Size = new System.Drawing.Size(109, 15);
            this.Label_TotalProdutosEdit.TabIndex = 5;
            this.Label_TotalProdutosEdit.Text = "Total dos Produtos";
            // 
            // Label_CalculaValorVendaPedEdit
            // 
            this.Label_CalculaValorVendaPedEdit.AutoSize = true;
            this.Label_CalculaValorVendaPedEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CalculaValorVendaPedEdit.Location = new System.Drawing.Point(139, 403);
            this.Label_CalculaValorVendaPedEdit.Name = "Label_CalculaValorVendaPedEdit";
            this.Label_CalculaValorVendaPedEdit.Size = new System.Drawing.Size(47, 15);
            this.Label_CalculaValorVendaPedEdit.TabIndex = 11;
            this.Label_CalculaValorVendaPedEdit.Text = "R$0,00";
            // 
            // FormEditarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 520);
            this.Controls.Add(this.Label_CalculaValorVendaPedEdit);
            this.Controls.Add(this.Label_CalculaTotalProdutosEdit);
            this.Controls.Add(this.Label_TotalProdutosEdit);
            this.Controls.Add(this.Rdb_FreteTerceiroEdit);
            this.Controls.Add(this.Rdb_FreteProprioEdit);
            this.Controls.Add(this.Chk_FreteEdit);
            this.Controls.Add(this.Msk_FreteEdit);
            this.Controls.Add(this.Btn_RemoverEdit);
            this.Controls.Add(this.Lst_ListaProdutosEdit);
            this.Controls.Add(this.Label_NumeroPedidoEdit);
            this.Controls.Add(this.Cbo_DescricaoEdit);
            this.Controls.Add(this.Cbo_NomeClienteEdit);
            this.Controls.Add(this.Label_CodigoPedido);
            this.Controls.Add(this.Txt_EntregaEdit);
            this.Controls.Add(this.Label_EntregaEdit);
            this.Controls.Add(this.Label_ValorVendaEdit);
            this.Controls.Add(this.Date_DataPedidoEdit);
            this.Controls.Add(this.Label_DataPedidoEdit);
            this.Controls.Add(this.Btn_SalvarEditPedido);
            this.Controls.Add(this.Label_ProdutoEdit);
            this.Controls.Add(this.Label_ClienteEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FormEditarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FormEditarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ClienteEdit;
        private System.Windows.Forms.Label Label_ProdutoEdit;
        private System.Windows.Forms.Button Btn_SalvarEditPedido;
        private System.Windows.Forms.Label Label_DataPedidoEdit;
        private System.Windows.Forms.DateTimePicker Date_DataPedidoEdit;
        private System.Windows.Forms.Label Label_ValorVendaEdit;
        private System.Windows.Forms.Label Label_EntregaEdit;
        private System.Windows.Forms.TextBox Txt_EntregaEdit;
        private System.Windows.Forms.Label Label_CodigoPedido;
        private System.Windows.Forms.ComboBox Cbo_NomeClienteEdit;
        private System.Windows.Forms.ComboBox Cbo_DescricaoEdit;
        private System.Windows.Forms.Label Label_NumeroPedidoEdit;
        private System.Windows.Forms.ListView Lst_ListaProdutosEdit;
        private System.Windows.Forms.Button Btn_RemoverEdit;
        private System.Windows.Forms.CheckBox Chk_FreteEdit;
        private System.Windows.Forms.MaskedTextBox Msk_FreteEdit;
        private System.Windows.Forms.RadioButton Rdb_FreteProprioEdit;
        private System.Windows.Forms.RadioButton Rdb_FreteTerceiroEdit;
        private System.Windows.Forms.Label Label_CalculaTotalProdutosEdit;
        private System.Windows.Forms.Label Label_TotalProdutosEdit;
        private System.Windows.Forms.Label Label_CalculaValorVendaPedEdit;
    }
}