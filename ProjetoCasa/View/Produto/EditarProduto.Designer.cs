namespace ProjetoCasa
{
    partial class FormEditarProduto
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
            this.Label_CustoEdit = new System.Windows.Forms.Label();
            this.Btn_SalvarEditProduto = new System.Windows.Forms.Button();
            this.Label_CodigoProdutoEdit = new System.Windows.Forms.Label();
            this.Label_CodigoProduto = new System.Windows.Forms.Label();
            this.Label_DescricaoEdit = new System.Windows.Forms.Label();
            this.Txt_DescricaoEdit = new System.Windows.Forms.TextBox();
            this.Label_ValorVendaProdEdit = new System.Windows.Forms.Label();
            this.Msk_CustoProdutoEdit = new System.Windows.Forms.MaskedTextBox();
            this.Msk_ValorVendaEdit = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Label_CustoEdit
            // 
            this.Label_CustoEdit.AutoSize = true;
            this.Label_CustoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CustoEdit.Location = new System.Drawing.Point(85, 76);
            this.Label_CustoEdit.Name = "Label_CustoEdit";
            this.Label_CustoEdit.Size = new System.Drawing.Size(38, 15);
            this.Label_CustoEdit.TabIndex = 8;
            this.Label_CustoEdit.Text = "Custo";
            // 
            // Btn_SalvarEditProduto
            // 
            this.Btn_SalvarEditProduto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarEditProduto.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarEditProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarEditProduto.Location = new System.Drawing.Point(207, 151);
            this.Btn_SalvarEditProduto.Name = "Btn_SalvarEditProduto";
            this.Btn_SalvarEditProduto.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarEditProduto.TabIndex = 5;
            this.Btn_SalvarEditProduto.Text = "Salvar";
            this.Btn_SalvarEditProduto.UseVisualStyleBackColor = false;
            this.Btn_SalvarEditProduto.Click += new System.EventHandler(this.Btn_SalvarEditProduto_Click);
            // 
            // Label_CodigoProdutoEdit
            // 
            this.Label_CodigoProdutoEdit.AutoSize = true;
            this.Label_CodigoProdutoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoProdutoEdit.Location = new System.Drawing.Point(77, 10);
            this.Label_CodigoProdutoEdit.Name = "Label_CodigoProdutoEdit";
            this.Label_CodigoProdutoEdit.Size = new System.Drawing.Size(46, 15);
            this.Label_CodigoProdutoEdit.TabIndex = 6;
            this.Label_CodigoProdutoEdit.Text = "Código";
            // 
            // Label_CodigoProduto
            // 
            this.Label_CodigoProduto.AutoSize = true;
            this.Label_CodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoProduto.Location = new System.Drawing.Point(126, 10);
            this.Label_CodigoProduto.Name = "Label_CodigoProduto";
            this.Label_CodigoProduto.Size = new System.Drawing.Size(14, 15);
            this.Label_CodigoProduto.TabIndex = 1;
            this.Label_CodigoProduto.Text = "0";
            // 
            // Label_DescricaoEdit
            // 
            this.Label_DescricaoEdit.AutoSize = true;
            this.Label_DescricaoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Label_DescricaoEdit.Location = new System.Drawing.Point(61, 40);
            this.Label_DescricaoEdit.Name = "Label_DescricaoEdit";
            this.Label_DescricaoEdit.Size = new System.Drawing.Size(62, 15);
            this.Label_DescricaoEdit.TabIndex = 7;
            this.Label_DescricaoEdit.Text = "Descrição";
            // 
            // Txt_DescricaoEdit
            // 
            this.Txt_DescricaoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DescricaoEdit.Location = new System.Drawing.Point(129, 38);
            this.Txt_DescricaoEdit.Name = "Txt_DescricaoEdit";
            this.Txt_DescricaoEdit.Size = new System.Drawing.Size(199, 21);
            this.Txt_DescricaoEdit.TabIndex = 2;
            // 
            // Label_ValorVendaProdEdit
            // 
            this.Label_ValorVendaProdEdit.AutoSize = true;
            this.Label_ValorVendaProdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ValorVendaProdEdit.Location = new System.Drawing.Point(33, 113);
            this.Label_ValorVendaProdEdit.Name = "Label_ValorVendaProdEdit";
            this.Label_ValorVendaProdEdit.Size = new System.Drawing.Size(90, 15);
            this.Label_ValorVendaProdEdit.TabIndex = 9;
            this.Label_ValorVendaProdEdit.Text = "Valor de Venda";
            // 
            // Msk_CustoProdutoEdit
            // 
            this.Msk_CustoProdutoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_CustoProdutoEdit.Location = new System.Drawing.Point(129, 74);
            this.Msk_CustoProdutoEdit.Mask = "$###,##";
            this.Msk_CustoProdutoEdit.Name = "Msk_CustoProdutoEdit";
            this.Msk_CustoProdutoEdit.Size = new System.Drawing.Size(199, 21);
            this.Msk_CustoProdutoEdit.TabIndex = 3;
            this.Msk_CustoProdutoEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_CustoProdutoEdit_KeyDown);
            // 
            // Msk_ValorVendaEdit
            // 
            this.Msk_ValorVendaEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_ValorVendaEdit.Location = new System.Drawing.Point(129, 111);
            this.Msk_ValorVendaEdit.Mask = "$###,##";
            this.Msk_ValorVendaEdit.Name = "Msk_ValorVendaEdit";
            this.Msk_ValorVendaEdit.Size = new System.Drawing.Size(199, 21);
            this.Msk_ValorVendaEdit.TabIndex = 4;
            this.Msk_ValorVendaEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_ValorVendaEdit_KeyDown);
            // 
            // FormEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 200);
            this.Controls.Add(this.Msk_ValorVendaEdit);
            this.Controls.Add(this.Msk_CustoProdutoEdit);
            this.Controls.Add(this.Label_ValorVendaProdEdit);
            this.Controls.Add(this.Txt_DescricaoEdit);
            this.Controls.Add(this.Label_DescricaoEdit);
            this.Controls.Add(this.Label_CodigoProduto);
            this.Controls.Add(this.Label_CodigoProdutoEdit);
            this.Controls.Add(this.Btn_SalvarEditProduto);
            this.Controls.Add(this.Label_CustoEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FormEditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_CustoEdit;
        private System.Windows.Forms.Button Btn_SalvarEditProduto;
        private System.Windows.Forms.Label Label_CodigoProdutoEdit;
        private System.Windows.Forms.Label Label_CodigoProduto;
        private System.Windows.Forms.Label Label_DescricaoEdit;
        private System.Windows.Forms.TextBox Txt_DescricaoEdit;
        private System.Windows.Forms.Label Label_ValorVendaProdEdit;
        private System.Windows.Forms.MaskedTextBox Msk_CustoProdutoEdit;
        private System.Windows.Forms.MaskedTextBox Msk_ValorVendaEdit;
    }
}