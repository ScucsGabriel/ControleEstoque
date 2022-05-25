namespace ProjetoCasa
{
    partial class FormListarProduto
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
            this.Btn_BuscarPorDescricao = new System.Windows.Forms.Button();
            this.Btn_VoltarCadProd = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LstView_ListaProduto = new System.Windows.Forms.ListView();
            this.Label_BuscaDescricao = new System.Windows.Forms.Label();
            this.Txt_DescricaoBusca = new System.Windows.Forms.TextBox();
            this.Label_QuantidadeProdutos = new System.Windows.Forms.Label();
            this.Label_CalculaQuantidadeProd = new System.Windows.Forms.Label();
            this.Btn_ExcluirProduto = new System.Windows.Forms.Button();
            this.Btn_EditarProduto = new System.Windows.Forms.Button();
            this.Btn_BuscarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_BuscarPorDescricao
            // 
            this.Btn_BuscarPorDescricao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_BuscarPorDescricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorDescricao.Location = new System.Drawing.Point(357, 20);
            this.Btn_BuscarPorDescricao.Name = "Btn_BuscarPorDescricao";
            this.Btn_BuscarPorDescricao.Size = new System.Drawing.Size(134, 33);
            this.Btn_BuscarPorDescricao.TabIndex = 2;
            this.Btn_BuscarPorDescricao.Text = "Buscar por Descrição";
            this.Btn_BuscarPorDescricao.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorDescricao.Click += new System.EventHandler(this.Btn_BuscarPorProduto_Click);
            // 
            // Btn_VoltarCadProd
            // 
            this.Btn_VoltarCadProd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarCadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCadProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarCadProd.Location = new System.Drawing.Point(917, 20);
            this.Btn_VoltarCadProd.Name = "Btn_VoltarCadProd";
            this.Btn_VoltarCadProd.Size = new System.Drawing.Size(134, 34);
            this.Btn_VoltarCadProd.TabIndex = 6;
            this.Btn_VoltarCadProd.Text = "Voltar";
            this.Btn_VoltarCadProd.UseVisualStyleBackColor = false;
            this.Btn_VoltarCadProd.Click += new System.EventHandler(this.Btn_VoltarCadProd_Click);
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
            // LstView_ListaProduto
            // 
            this.LstView_ListaProduto.AllowColumnReorder = true;
            this.LstView_ListaProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaProduto.HideSelection = false;
            this.LstView_ListaProduto.Location = new System.Drawing.Point(26, 66);
            this.LstView_ListaProduto.Name = "LstView_ListaProduto";
            this.LstView_ListaProduto.Size = new System.Drawing.Size(1313, 536);
            this.LstView_ListaProduto.TabIndex = 7;
            this.LstView_ListaProduto.UseCompatibleStateImageBehavior = false;
            this.LstView_ListaProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_ListaProduto_KeyDown);
            // 
            // Label_BuscaDescricao
            // 
            this.Label_BuscaDescricao.AutoSize = true;
            this.Label_BuscaDescricao.Location = new System.Drawing.Point(24, 35);
            this.Label_BuscaDescricao.Name = "Label_BuscaDescricao";
            this.Label_BuscaDescricao.Size = new System.Drawing.Size(55, 13);
            this.Label_BuscaDescricao.TabIndex = 8;
            this.Label_BuscaDescricao.Text = "Descrição";
            // 
            // Txt_DescricaoBusca
            // 
            this.Txt_DescricaoBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DescricaoBusca.Location = new System.Drawing.Point(95, 28);
            this.Txt_DescricaoBusca.Name = "Txt_DescricaoBusca";
            this.Txt_DescricaoBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_DescricaoBusca.TabIndex = 1;
            // 
            // Label_QuantidadeProdutos
            // 
            this.Label_QuantidadeProdutos.AutoSize = true;
            this.Label_QuantidadeProdutos.Location = new System.Drawing.Point(24, 615);
            this.Label_QuantidadeProdutos.Name = "Label_QuantidadeProdutos";
            this.Label_QuantidadeProdutos.Size = new System.Drawing.Size(122, 13);
            this.Label_QuantidadeProdutos.TabIndex = 9;
            this.Label_QuantidadeProdutos.Text = "Quantidade de Produtos";
            // 
            // Label_CalculaQuantidadeProd
            // 
            this.Label_CalculaQuantidadeProd.AutoSize = true;
            this.Label_CalculaQuantidadeProd.Location = new System.Drawing.Point(24, 645);
            this.Label_CalculaQuantidadeProd.Name = "Label_CalculaQuantidadeProd";
            this.Label_CalculaQuantidadeProd.Size = new System.Drawing.Size(13, 13);
            this.Label_CalculaQuantidadeProd.TabIndex = 10;
            this.Label_CalculaQuantidadeProd.Text = "0";
            // 
            // Btn_ExcluirProduto
            // 
            this.Btn_ExcluirProduto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirProduto.Location = new System.Drawing.Point(777, 20);
            this.Btn_ExcluirProduto.Name = "Btn_ExcluirProduto";
            this.Btn_ExcluirProduto.Size = new System.Drawing.Size(134, 33);
            this.Btn_ExcluirProduto.TabIndex = 5;
            this.Btn_ExcluirProduto.Text = "Excluir";
            this.Btn_ExcluirProduto.UseVisualStyleBackColor = false;
            this.Btn_ExcluirProduto.Click += new System.EventHandler(this.Btn_ExcluirProduto_Click);
            // 
            // Btn_EditarProduto
            // 
            this.Btn_EditarProduto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarProduto.Location = new System.Drawing.Point(637, 20);
            this.Btn_EditarProduto.Name = "Btn_EditarProduto";
            this.Btn_EditarProduto.Size = new System.Drawing.Size(134, 34);
            this.Btn_EditarProduto.TabIndex = 4;
            this.Btn_EditarProduto.Text = "Editar";
            this.Btn_EditarProduto.UseVisualStyleBackColor = false;
            this.Btn_EditarProduto.Click += new System.EventHandler(this.Btn_EditarProduto_Click);
            // 
            // Btn_BuscarTodos
            // 
            this.Btn_BuscarTodos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_BuscarTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarTodos.Location = new System.Drawing.Point(497, 21);
            this.Btn_BuscarTodos.Name = "Btn_BuscarTodos";
            this.Btn_BuscarTodos.Size = new System.Drawing.Size(134, 33);
            this.Btn_BuscarTodos.TabIndex = 3;
            this.Btn_BuscarTodos.Text = "Buscar Todos";
            this.Btn_BuscarTodos.UseVisualStyleBackColor = false;
            this.Btn_BuscarTodos.Click += new System.EventHandler(this.Btn_BuscarTodos_Click);
            // 
            // FormListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 665);
            this.Controls.Add(this.Btn_BuscarTodos);
            this.Controls.Add(this.Btn_EditarProduto);
            this.Controls.Add(this.Btn_ExcluirProduto);
            this.Controls.Add(this.Label_CalculaQuantidadeProd);
            this.Controls.Add(this.Label_QuantidadeProdutos);
            this.Controls.Add(this.Txt_DescricaoBusca);
            this.Controls.Add(this.Label_BuscaDescricao);
            this.Controls.Add(this.LstView_ListaProduto);
            this.Controls.Add(this.Btn_VoltarCadProd);
            this.Controls.Add(this.Btn_BuscarPorDescricao);
            this.Name = "FormListarProduto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Lista de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_BuscarPorDescricao;
        private System.Windows.Forms.Button Btn_VoltarCadProd;
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
        private System.Windows.Forms.ListView LstView_ListaProduto;
        private System.Windows.Forms.Label Label_BuscaDescricao;
        private System.Windows.Forms.TextBox Txt_DescricaoBusca;
        private System.Windows.Forms.Label Label_QuantidadeProdutos;
        private System.Windows.Forms.Label Label_CalculaQuantidadeProd;
        private System.Windows.Forms.Button Btn_ExcluirProduto;
        private System.Windows.Forms.Button Btn_EditarProduto;
        private System.Windows.Forms.Button Btn_BuscarTodos;
    }
}