namespace ProjetoCasa
{
    partial class FormPedido
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
            this.Label_Cliente = new System.Windows.Forms.Label();
            this.Label_Produto = new System.Windows.Forms.Label();
            this.Btn_SalvarPedido = new System.Windows.Forms.Button();
            this.Label_DataPedido = new System.Windows.Forms.Label();
            this.Btn_ListarPedido = new System.Windows.Forms.Button();
            this.Date_DataPedido = new System.Windows.Forms.DateTimePicker();
            this.Label_ValorVenda = new System.Windows.Forms.Label();
            this.Txt_Entrega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Entrega = new System.Windows.Forms.Label();
            this.Cbo_NomeCliente = new System.Windows.Forms.ComboBox();
            this.Cbo_Descricao = new System.Windows.Forms.ComboBox();
            this.Label_GeraNumPed = new System.Windows.Forms.Label();
            this.Lst_ListaProdutos = new System.Windows.Forms.ListView();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.Msk_Frete = new System.Windows.Forms.MaskedTextBox();
            this.Chk_Frete = new System.Windows.Forms.CheckBox();
            this.Rdb_FreteProprio = new System.Windows.Forms.RadioButton();
            this.Rdb_FreteTerceiro = new System.Windows.Forms.RadioButton();
            this.Label_TotalProdutos = new System.Windows.Forms.Label();
            this.Label_CalculaTotalProdutos = new System.Windows.Forms.Label();
            this.Label_CalculaValorVendaPed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Cliente
            // 
            this.Label_Cliente.AutoSize = true;
            this.Label_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cliente.Location = new System.Drawing.Point(125, 45);
            this.Label_Cliente.Name = "Label_Cliente";
            this.Label_Cliente.Size = new System.Drawing.Size(45, 15);
            this.Label_Cliente.TabIndex = 17;
            this.Label_Cliente.Text = "Cliente";
            // 
            // Label_Produto
            // 
            this.Label_Produto.AutoSize = true;
            this.Label_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Produto.Location = new System.Drawing.Point(114, 88);
            this.Label_Produto.Name = "Label_Produto";
            this.Label_Produto.Size = new System.Drawing.Size(56, 15);
            this.Label_Produto.TabIndex = 18;
            this.Label_Produto.Text = "Produtos";
            // 
            // Btn_SalvarPedido
            // 
            this.Btn_SalvarPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarPedido.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarPedido.Location = new System.Drawing.Point(268, 450);
            this.Btn_SalvarPedido.Name = "Btn_SalvarPedido";
            this.Btn_SalvarPedido.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarPedido.TabIndex = 15;
            this.Btn_SalvarPedido.Text = "Salvar";
            this.Btn_SalvarPedido.UseVisualStyleBackColor = false;
            this.Btn_SalvarPedido.Click += new System.EventHandler(this.Btn_SalvarPedido_Click);
            // 
            // Label_DataPedido
            // 
            this.Label_DataPedido.AutoSize = true;
            this.Label_DataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DataPedido.Location = new System.Drawing.Point(76, 281);
            this.Label_DataPedido.Name = "Label_DataPedido";
            this.Label_DataPedido.Size = new System.Drawing.Size(92, 15);
            this.Label_DataPedido.TabIndex = 19;
            this.Label_DataPedido.Text = "Data do Pedido";
            // 
            // Btn_ListarPedido
            // 
            this.Btn_ListarPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ListarPedido.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_ListarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListarPedido.Location = new System.Drawing.Point(14, 451);
            this.Btn_ListarPedido.Name = "Btn_ListarPedido";
            this.Btn_ListarPedido.Size = new System.Drawing.Size(121, 38);
            this.Btn_ListarPedido.TabIndex = 13;
            this.Btn_ListarPedido.Text = "Listar";
            this.Btn_ListarPedido.UseVisualStyleBackColor = false;
            this.Btn_ListarPedido.Click += new System.EventHandler(this.Btn_ListarPedido_Click);
            // 
            // Date_DataPedido
            // 
            this.Date_DataPedido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataPedido.Location = new System.Drawing.Point(174, 277);
            this.Date_DataPedido.Name = "Date_DataPedido";
            this.Date_DataPedido.Size = new System.Drawing.Size(204, 21);
            this.Date_DataPedido.TabIndex = 7;
            // 
            // Label_ValorVenda
            // 
            this.Label_ValorVenda.AutoSize = true;
            this.Label_ValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ValorVenda.Location = new System.Drawing.Point(81, 383);
            this.Label_ValorVenda.Name = "Label_ValorVenda";
            this.Label_ValorVenda.Size = new System.Drawing.Size(89, 15);
            this.Label_ValorVenda.TabIndex = 21;
            this.Label_ValorVenda.Text = "Total da Venda";
            // 
            // Txt_Entrega
            // 
            this.Txt_Entrega.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Entrega.Location = new System.Drawing.Point(174, 413);
            this.Txt_Entrega.Name = "Txt_Entrega";
            this.Txt_Entrega.Size = new System.Drawing.Size(204, 21);
            this.Txt_Entrega.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Número do Pedido";
            // 
            // Label_Entrega
            // 
            this.Label_Entrega.AutoSize = true;
            this.Label_Entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Entrega.Location = new System.Drawing.Point(118, 415);
            this.Label_Entrega.Name = "Label_Entrega";
            this.Label_Entrega.Size = new System.Drawing.Size(50, 15);
            this.Label_Entrega.TabIndex = 22;
            this.Label_Entrega.Text = "Entrega";
            // 
            // Cbo_NomeCliente
            // 
            this.Cbo_NomeCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_NomeCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_NomeCliente.FormattingEnabled = true;
            this.Cbo_NomeCliente.Location = new System.Drawing.Point(176, 43);
            this.Cbo_NomeCliente.Name = "Cbo_NomeCliente";
            this.Cbo_NomeCliente.Size = new System.Drawing.Size(204, 23);
            this.Cbo_NomeCliente.TabIndex = 2;
            this.Cbo_NomeCliente.Text = "[Pesquisar]";
            this.Cbo_NomeCliente.DropDown += new System.EventHandler(this.Cbo_NomeCliente_DropDown);
            // 
            // Cbo_Descricao
            // 
            this.Cbo_Descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Descricao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Descricao.FormattingEnabled = true;
            this.Cbo_Descricao.Location = new System.Drawing.Point(176, 82);
            this.Cbo_Descricao.Name = "Cbo_Descricao";
            this.Cbo_Descricao.Size = new System.Drawing.Size(204, 23);
            this.Cbo_Descricao.TabIndex = 3;
            this.Cbo_Descricao.Text = "[Selecione]";
            this.Cbo_Descricao.DropDown += new System.EventHandler(this.Cbo_Descricao_DropDown);
            this.Cbo_Descricao.SelectedIndexChanged += new System.EventHandler(this.Cbo_Descricao_SelectedIndexChanged);
            // 
            // Label_GeraNumPed
            // 
            this.Label_GeraNumPed.AutoSize = true;
            this.Label_GeraNumPed.Location = new System.Drawing.Point(173, 21);
            this.Label_GeraNumPed.Name = "Label_GeraNumPed";
            this.Label_GeraNumPed.Size = new System.Drawing.Size(13, 13);
            this.Label_GeraNumPed.TabIndex = 1;
            this.Label_GeraNumPed.Text = "0";
            // 
            // Lst_ListaProdutos
            // 
            this.Lst_ListaProdutos.AllowColumnReorder = true;
            this.Lst_ListaProdutos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_ListaProdutos.FullRowSelect = true;
            this.Lst_ListaProdutos.GridLines = true;
            this.Lst_ListaProdutos.HideSelection = false;
            this.Lst_ListaProdutos.Location = new System.Drawing.Point(75, 106);
            this.Lst_ListaProdutos.Name = "Lst_ListaProdutos";
            this.Lst_ListaProdutos.Size = new System.Drawing.Size(314, 137);
            this.Lst_ListaProdutos.TabIndex = 4;
            this.Lst_ListaProdutos.UseCompatibleStateImageBehavior = false;
            this.Lst_ListaProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lst_ListaProdutos_KeyDown);
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_Remover.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_Remover.Location = new System.Drawing.Point(141, 451);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(121, 38);
            this.Btn_Remover.TabIndex = 14;
            this.Btn_Remover.Text = "Remover da Lista";
            this.Btn_Remover.UseVisualStyleBackColor = false;
            this.Btn_Remover.Click += new System.EventHandler(this.Btn_Remover_Click);
            // 
            // Msk_Frete
            // 
            this.Msk_Frete.Enabled = false;
            this.Msk_Frete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_Frete.Location = new System.Drawing.Point(174, 340);
            this.Msk_Frete.Mask = "$####,##";
            this.Msk_Frete.Name = "Msk_Frete";
            this.Msk_Frete.Size = new System.Drawing.Size(204, 21);
            this.Msk_Frete.TabIndex = 10;
            this.Msk_Frete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_Frete_KeyDown);
            // 
            // Chk_Frete
            // 
            this.Chk_Frete.AutoSize = true;
            this.Chk_Frete.Location = new System.Drawing.Point(118, 315);
            this.Chk_Frete.Name = "Chk_Frete";
            this.Chk_Frete.Size = new System.Drawing.Size(50, 17);
            this.Chk_Frete.TabIndex = 20;
            this.Chk_Frete.Text = "Frete";
            this.Chk_Frete.UseVisualStyleBackColor = true;
            this.Chk_Frete.CheckedChanged += new System.EventHandler(this.Chk_Frete_CheckedChanged);
            // 
            // Rdb_FreteProprio
            // 
            this.Rdb_FreteProprio.AutoSize = true;
            this.Rdb_FreteProprio.Enabled = false;
            this.Rdb_FreteProprio.Location = new System.Drawing.Point(172, 314);
            this.Rdb_FreteProprio.Name = "Rdb_FreteProprio";
            this.Rdb_FreteProprio.Size = new System.Drawing.Size(58, 17);
            this.Rdb_FreteProprio.TabIndex = 8;
            this.Rdb_FreteProprio.TabStop = true;
            this.Rdb_FreteProprio.Text = "Próprio";
            this.Rdb_FreteProprio.UseVisualStyleBackColor = true;
            // 
            // Rdb_FreteTerceiro
            // 
            this.Rdb_FreteTerceiro.AutoSize = true;
            this.Rdb_FreteTerceiro.Enabled = false;
            this.Rdb_FreteTerceiro.Location = new System.Drawing.Point(314, 314);
            this.Rdb_FreteTerceiro.Name = "Rdb_FreteTerceiro";
            this.Rdb_FreteTerceiro.Size = new System.Drawing.Size(64, 17);
            this.Rdb_FreteTerceiro.TabIndex = 9;
            this.Rdb_FreteTerceiro.TabStop = true;
            this.Rdb_FreteTerceiro.Text = "Terceiro";
            this.Rdb_FreteTerceiro.UseVisualStyleBackColor = true;
            // 
            // Label_TotalProdutos
            // 
            this.Label_TotalProdutos.AutoSize = true;
            this.Label_TotalProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalProdutos.Location = new System.Drawing.Point(155, 246);
            this.Label_TotalProdutos.Name = "Label_TotalProdutos";
            this.Label_TotalProdutos.Size = new System.Drawing.Size(109, 15);
            this.Label_TotalProdutos.TabIndex = 5;
            this.Label_TotalProdutos.Text = "Total dos Produtos";
            // 
            // Label_CalculaTotalProdutos
            // 
            this.Label_CalculaTotalProdutos.AutoSize = true;
            this.Label_CalculaTotalProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CalculaTotalProdutos.Location = new System.Drawing.Point(265, 246);
            this.Label_CalculaTotalProdutos.Name = "Label_CalculaTotalProdutos";
            this.Label_CalculaTotalProdutos.Size = new System.Drawing.Size(47, 15);
            this.Label_CalculaTotalProdutos.TabIndex = 6;
            this.Label_CalculaTotalProdutos.Text = "R$0,00";
            // 
            // Label_CalculaValorVendaPed
            // 
            this.Label_CalculaValorVendaPed.AutoSize = true;
            this.Label_CalculaValorVendaPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CalculaValorVendaPed.Location = new System.Drawing.Point(171, 383);
            this.Label_CalculaValorVendaPed.Name = "Label_CalculaValorVendaPed";
            this.Label_CalculaValorVendaPed.Size = new System.Drawing.Size(47, 15);
            this.Label_CalculaValorVendaPed.TabIndex = 11;
            this.Label_CalculaValorVendaPed.Text = "R$0,00";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 497);
            this.Controls.Add(this.Label_CalculaValorVendaPed);
            this.Controls.Add(this.Label_CalculaTotalProdutos);
            this.Controls.Add(this.Label_TotalProdutos);
            this.Controls.Add(this.Rdb_FreteTerceiro);
            this.Controls.Add(this.Rdb_FreteProprio);
            this.Controls.Add(this.Chk_Frete);
            this.Controls.Add(this.Msk_Frete);
            this.Controls.Add(this.Btn_Remover);
            this.Controls.Add(this.Lst_ListaProdutos);
            this.Controls.Add(this.Label_GeraNumPed);
            this.Controls.Add(this.Cbo_Descricao);
            this.Controls.Add(this.Cbo_NomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Entrega);
            this.Controls.Add(this.Label_Entrega);
            this.Controls.Add(this.Label_ValorVenda);
            this.Controls.Add(this.Date_DataPedido);
            this.Controls.Add(this.Btn_ListarPedido);
            this.Controls.Add(this.Label_DataPedido);
            this.Controls.Add(this.Btn_SalvarPedido);
            this.Controls.Add(this.Label_Produto);
            this.Controls.Add(this.Label_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Cliente;
        private System.Windows.Forms.Label Label_Produto;
        private System.Windows.Forms.Button Btn_SalvarPedido;
        private System.Windows.Forms.Label Label_DataPedido;
        private System.Windows.Forms.Button Btn_ListarPedido;
        private System.Windows.Forms.DateTimePicker Date_DataPedido;
        private System.Windows.Forms.Label Label_ValorVenda;
        private System.Windows.Forms.TextBox Txt_Entrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Entrega;
        private System.Windows.Forms.ComboBox Cbo_NomeCliente;
        private System.Windows.Forms.ComboBox Cbo_Descricao;
        private System.Windows.Forms.Label Label_GeraNumPed;
        private System.Windows.Forms.ListView Lst_ListaProdutos;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.MaskedTextBox Msk_Frete;
        private System.Windows.Forms.CheckBox Chk_Frete;
        private System.Windows.Forms.RadioButton Rdb_FreteProprio;
        private System.Windows.Forms.RadioButton Rdb_FreteTerceiro;
        private System.Windows.Forms.Label Label_TotalProdutos;
        private System.Windows.Forms.Label Label_CalculaTotalProdutos;
        private System.Windows.Forms.Label Label_CalculaValorVendaPed;
    }
}