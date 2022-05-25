namespace ProjetoCasa
{
    partial class FormProduto
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
            this.Label_NomeCachorro = new System.Windows.Forms.Label();
            this.Btn_SalvarProduto = new System.Windows.Forms.Button();
            this.Btn_ListarProduto = new System.Windows.Forms.Button();
            this.Label_Descricao = new System.Windows.Forms.Label();
            this.Txt_Descricao = new System.Windows.Forms.TextBox();
            this.Label_ValorVendaProd = new System.Windows.Forms.Label();
            this.Msk_CustoProduto = new System.Windows.Forms.MaskedTextBox();
            this.Msk_ValorVenda = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Label_NomeCachorro
            // 
            this.Label_NomeCachorro.AutoSize = true;
            this.Label_NomeCachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NomeCachorro.Location = new System.Drawing.Point(31, 64);
            this.Label_NomeCachorro.Name = "Label_NomeCachorro";
            this.Label_NomeCachorro.Size = new System.Drawing.Size(101, 15);
            this.Label_NomeCachorro.TabIndex = 7;
            this.Label_NomeCachorro.Text = "Custo do Produto";
            // 
            // Btn_SalvarProduto
            // 
            this.Btn_SalvarProduto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarProduto.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarProduto.Location = new System.Drawing.Point(236, 137);
            this.Btn_SalvarProduto.Name = "Btn_SalvarProduto";
            this.Btn_SalvarProduto.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarProduto.TabIndex = 5;
            this.Btn_SalvarProduto.Text = "Salvar";
            this.Btn_SalvarProduto.UseVisualStyleBackColor = false;
            this.Btn_SalvarProduto.Click += new System.EventHandler(this.Btn_SalvarProduto_Click);
            // 
            // Btn_ListarProduto
            // 
            this.Btn_ListarProduto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ListarProduto.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_ListarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListarProduto.Location = new System.Drawing.Point(34, 138);
            this.Btn_ListarProduto.Name = "Btn_ListarProduto";
            this.Btn_ListarProduto.Size = new System.Drawing.Size(121, 38);
            this.Btn_ListarProduto.TabIndex = 4;
            this.Btn_ListarProduto.Text = "Listar";
            this.Btn_ListarProduto.UseVisualStyleBackColor = false;
            this.Btn_ListarProduto.Click += new System.EventHandler(this.Btn_ListarProduto_Click);
            // 
            // Label_Descricao
            // 
            this.Label_Descricao.AutoSize = true;
            this.Label_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Descricao.Location = new System.Drawing.Point(70, 25);
            this.Label_Descricao.Name = "Label_Descricao";
            this.Label_Descricao.Size = new System.Drawing.Size(62, 15);
            this.Label_Descricao.TabIndex = 6;
            this.Label_Descricao.Text = "Descrição";
            // 
            // Txt_Descricao
            // 
            this.Txt_Descricao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descricao.Location = new System.Drawing.Point(138, 23);
            this.Txt_Descricao.Name = "Txt_Descricao";
            this.Txt_Descricao.Size = new System.Drawing.Size(199, 21);
            this.Txt_Descricao.TabIndex = 1;
            // 
            // Label_ValorVendaProd
            // 
            this.Label_ValorVendaProd.AutoSize = true;
            this.Label_ValorVendaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ValorVendaProd.Location = new System.Drawing.Point(42, 102);
            this.Label_ValorVendaProd.Name = "Label_ValorVendaProd";
            this.Label_ValorVendaProd.Size = new System.Drawing.Size(90, 15);
            this.Label_ValorVendaProd.TabIndex = 8;
            this.Label_ValorVendaProd.Text = "Valor de Venda";
            // 
            // Msk_CustoProduto
            // 
            this.Msk_CustoProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_CustoProduto.Location = new System.Drawing.Point(138, 62);
            this.Msk_CustoProduto.Mask = "$###,##";
            this.Msk_CustoProduto.Name = "Msk_CustoProduto";
            this.Msk_CustoProduto.Size = new System.Drawing.Size(199, 21);
            this.Msk_CustoProduto.TabIndex = 2;
            this.Msk_CustoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_CustoProduto_KeyDown);
            // 
            // Msk_ValorVenda
            // 
            this.Msk_ValorVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_ValorVenda.Location = new System.Drawing.Point(138, 100);
            this.Msk_ValorVenda.Mask = "$####,##";
            this.Msk_ValorVenda.Name = "Msk_ValorVenda";
            this.Msk_ValorVenda.Size = new System.Drawing.Size(199, 21);
            this.Msk_ValorVenda.TabIndex = 3;
            this.Msk_ValorVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_ValorVenda_KeyDown);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 191);
            this.Controls.Add(this.Msk_ValorVenda);
            this.Controls.Add(this.Msk_CustoProduto);
            this.Controls.Add(this.Label_ValorVendaProd);
            this.Controls.Add(this.Txt_Descricao);
            this.Controls.Add(this.Label_Descricao);
            this.Controls.Add(this.Btn_ListarProduto);
            this.Controls.Add(this.Btn_SalvarProduto);
            this.Controls.Add(this.Label_NomeCachorro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_NomeCachorro;
        private System.Windows.Forms.Button Btn_SalvarProduto;
        private System.Windows.Forms.Button Btn_ListarProduto;
        private System.Windows.Forms.Label Label_Descricao;
        private System.Windows.Forms.TextBox Txt_Descricao;
        private System.Windows.Forms.Label Label_ValorVendaProd;
        private System.Windows.Forms.MaskedTextBox Msk_CustoProduto;
        private System.Windows.Forms.MaskedTextBox Msk_ValorVenda;
    }
}