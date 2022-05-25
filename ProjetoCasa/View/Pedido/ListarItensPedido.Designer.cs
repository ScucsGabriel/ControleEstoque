namespace ProjetoCasa
{
    partial class FormListarItensPedido
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
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LstView_ListaItensPed = new System.Windows.Forms.ListView();
            this.Btn_EditarPedido = new System.Windows.Forms.Button();
            this.Label_QuantidadeItens = new System.Windows.Forms.Label();
            this.Label_CalculaQuantidadeItens = new System.Windows.Forms.Label();
            this.Label_CustoTotal = new System.Windows.Forms.Label();
            this.Label_SomaCustoTotal = new System.Windows.Forms.Label();
            this.Label_VendaTotal = new System.Windows.Forms.Label();
            this.Label_SomaVendaTotal = new System.Windows.Forms.Label();
            this.Label_LucroTotal = new System.Windows.Forms.Label();
            this.Label_SomaLucroTotal = new System.Windows.Forms.Label();
            this.Label_PorcLucro = new System.Windows.Forms.Label();
            this.Label_CalculoPorcMediaLucro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // LstView_ListaItensPed
            // 
            this.LstView_ListaItensPed.AllowColumnReorder = true;
            this.LstView_ListaItensPed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaItensPed.HideSelection = false;
            this.LstView_ListaItensPed.Location = new System.Drawing.Point(26, 69);
            this.LstView_ListaItensPed.Name = "LstView_ListaItensPed";
            this.LstView_ListaItensPed.Size = new System.Drawing.Size(785, 177);
            this.LstView_ListaItensPed.TabIndex = 2;
            this.LstView_ListaItensPed.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_EditarPedido
            // 
            this.Btn_EditarPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarPedido.Location = new System.Drawing.Point(26, 12);
            this.Btn_EditarPedido.Name = "Btn_EditarPedido";
            this.Btn_EditarPedido.Size = new System.Drawing.Size(134, 34);
            this.Btn_EditarPedido.TabIndex = 1;
            this.Btn_EditarPedido.Text = "Editar";
            this.Btn_EditarPedido.UseVisualStyleBackColor = false;
            this.Btn_EditarPedido.Click += new System.EventHandler(this.Btn_EditarPedido_Click);
            // 
            // Label_QuantidadeItens
            // 
            this.Label_QuantidadeItens.AutoSize = true;
            this.Label_QuantidadeItens.Location = new System.Drawing.Point(23, 270);
            this.Label_QuantidadeItens.Name = "Label_QuantidadeItens";
            this.Label_QuantidadeItens.Size = new System.Drawing.Size(103, 13);
            this.Label_QuantidadeItens.TabIndex = 3;
            this.Label_QuantidadeItens.Text = "Quantidade de Itens";
            // 
            // Label_CalculaQuantidadeItens
            // 
            this.Label_CalculaQuantidadeItens.AutoSize = true;
            this.Label_CalculaQuantidadeItens.Location = new System.Drawing.Point(23, 299);
            this.Label_CalculaQuantidadeItens.Name = "Label_CalculaQuantidadeItens";
            this.Label_CalculaQuantidadeItens.Size = new System.Drawing.Size(13, 13);
            this.Label_CalculaQuantidadeItens.TabIndex = 4;
            this.Label_CalculaQuantidadeItens.Text = "0";
            // 
            // Label_CustoTotal
            // 
            this.Label_CustoTotal.AutoSize = true;
            this.Label_CustoTotal.Location = new System.Drawing.Point(153, 270);
            this.Label_CustoTotal.Name = "Label_CustoTotal";
            this.Label_CustoTotal.Size = new System.Drawing.Size(106, 13);
            this.Label_CustoTotal.TabIndex = 5;
            this.Label_CustoTotal.Text = "Soma de Custo Total";
            // 
            // Label_SomaCustoTotal
            // 
            this.Label_SomaCustoTotal.AutoSize = true;
            this.Label_SomaCustoTotal.Location = new System.Drawing.Point(153, 299);
            this.Label_SomaCustoTotal.Name = "Label_SomaCustoTotal";
            this.Label_SomaCustoTotal.Size = new System.Drawing.Size(42, 13);
            this.Label_SomaCustoTotal.TabIndex = 6;
            this.Label_SomaCustoTotal.Text = "R$0,00";
            // 
            // Label_VendaTotal
            // 
            this.Label_VendaTotal.AutoSize = true;
            this.Label_VendaTotal.Location = new System.Drawing.Point(291, 270);
            this.Label_VendaTotal.Name = "Label_VendaTotal";
            this.Label_VendaTotal.Size = new System.Drawing.Size(110, 13);
            this.Label_VendaTotal.TabIndex = 7;
            this.Label_VendaTotal.Text = "Soma de Venda Total";
            // 
            // Label_SomaVendaTotal
            // 
            this.Label_SomaVendaTotal.AutoSize = true;
            this.Label_SomaVendaTotal.Location = new System.Drawing.Point(291, 299);
            this.Label_SomaVendaTotal.Name = "Label_SomaVendaTotal";
            this.Label_SomaVendaTotal.Size = new System.Drawing.Size(42, 13);
            this.Label_SomaVendaTotal.TabIndex = 8;
            this.Label_SomaVendaTotal.Text = "R$0,00";
            // 
            // Label_LucroTotal
            // 
            this.Label_LucroTotal.AutoSize = true;
            this.Label_LucroTotal.Location = new System.Drawing.Point(433, 270);
            this.Label_LucroTotal.Name = "Label_LucroTotal";
            this.Label_LucroTotal.Size = new System.Drawing.Size(106, 13);
            this.Label_LucroTotal.TabIndex = 9;
            this.Label_LucroTotal.Text = "Soma de Lucro Total";
            // 
            // Label_SomaLucroTotal
            // 
            this.Label_SomaLucroTotal.AutoSize = true;
            this.Label_SomaLucroTotal.Location = new System.Drawing.Point(433, 299);
            this.Label_SomaLucroTotal.Name = "Label_SomaLucroTotal";
            this.Label_SomaLucroTotal.Size = new System.Drawing.Size(42, 13);
            this.Label_SomaLucroTotal.TabIndex = 10;
            this.Label_SomaLucroTotal.Text = "R$0,00";
            // 
            // Label_PorcLucro
            // 
            this.Label_PorcLucro.AutoSize = true;
            this.Label_PorcLucro.Location = new System.Drawing.Point(557, 270);
            this.Label_PorcLucro.Name = "Label_PorcLucro";
            this.Label_PorcLucro.Size = new System.Drawing.Size(87, 13);
            this.Label_PorcLucro.TabIndex = 11;
            this.Label_PorcLucro.Text = "% Total de Lucro";
            // 
            // Label_CalculoPorcMediaLucro
            // 
            this.Label_CalculoPorcMediaLucro.AutoSize = true;
            this.Label_CalculoPorcMediaLucro.Location = new System.Drawing.Point(557, 299);
            this.Label_CalculoPorcMediaLucro.Name = "Label_CalculoPorcMediaLucro";
            this.Label_CalculoPorcMediaLucro.Size = new System.Drawing.Size(21, 13);
            this.Label_CalculoPorcMediaLucro.TabIndex = 12;
            this.Label_CalculoPorcMediaLucro.Text = "0%";
            // 
            // FormListarItensPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 338);
            this.Controls.Add(this.Label_CalculoPorcMediaLucro);
            this.Controls.Add(this.Label_PorcLucro);
            this.Controls.Add(this.Label_SomaLucroTotal);
            this.Controls.Add(this.Label_LucroTotal);
            this.Controls.Add(this.Label_SomaVendaTotal);
            this.Controls.Add(this.Label_VendaTotal);
            this.Controls.Add(this.Label_SomaCustoTotal);
            this.Controls.Add(this.Label_CustoTotal);
            this.Controls.Add(this.Label_CalculaQuantidadeItens);
            this.Controls.Add(this.Label_QuantidadeItens);
            this.Controls.Add(this.Btn_EditarPedido);
            this.Controls.Add(this.LstView_ListaItensPed);
            this.Name = "FormListarItensPedido";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Lista de Itens";
            this.Load += new System.EventHandler(this.FormListarItensPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ListView LstView_ListaItensPed;
        private System.Windows.Forms.Button Btn_EditarPedido;
        private System.Windows.Forms.Label Label_QuantidadeItens;
        private System.Windows.Forms.Label Label_CalculaQuantidadeItens;
        private System.Windows.Forms.Label Label_CustoTotal;
        private System.Windows.Forms.Label Label_SomaCustoTotal;
        private System.Windows.Forms.Label Label_VendaTotal;
        private System.Windows.Forms.Label Label_SomaVendaTotal;
        private System.Windows.Forms.Label Label_LucroTotal;
        private System.Windows.Forms.Label Label_SomaLucroTotal;
        private System.Windows.Forms.Label Label_PorcLucro;
        private System.Windows.Forms.Label Label_CalculoPorcMediaLucro;
    }
}