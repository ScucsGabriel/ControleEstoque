namespace ProjetoCasa
{
    partial class FormListarCliente
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
            this.Btn_BuscarPorCliente = new System.Windows.Forms.Button();
            this.Btn_VoltarCadCli = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LstView_ListaCliente = new System.Windows.Forms.ListView();
            this.Label_BuscaNomeCliente = new System.Windows.Forms.Label();
            this.Txt_ClienteBusca = new System.Windows.Forms.TextBox();
            this.Btn_BuscarPorCachorro = new System.Windows.Forms.Button();
            this.Label_QuantidadeClientes = new System.Windows.Forms.Label();
            this.Label_CalculaQuantidadeCli = new System.Windows.Forms.Label();
            this.Btn_ExcluirCliente = new System.Windows.Forms.Button();
            this.Btn_EditarCliente = new System.Windows.Forms.Button();
            this.Label_BuscaNomeCachorro = new System.Windows.Forms.Label();
            this.Txt_CachorroBusca = new System.Windows.Forms.TextBox();
            this.Btn_BuscarTodosClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_BuscarPorCliente
            // 
            this.Btn_BuscarPorCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_BuscarPorCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorCliente.Location = new System.Drawing.Point(25, 61);
            this.Btn_BuscarPorCliente.Name = "Btn_BuscarPorCliente";
            this.Btn_BuscarPorCliente.Size = new System.Drawing.Size(134, 33);
            this.Btn_BuscarPorCliente.TabIndex = 3;
            this.Btn_BuscarPorCliente.Text = "Buscar por Cliente";
            this.Btn_BuscarPorCliente.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorCliente.Click += new System.EventHandler(this.Btn_BuscarPorCliente_Click);
            // 
            // Btn_VoltarCadCli
            // 
            this.Btn_VoltarCadCli.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCadCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarCadCli.Location = new System.Drawing.Point(725, 58);
            this.Btn_VoltarCadCli.Name = "Btn_VoltarCadCli";
            this.Btn_VoltarCadCli.Size = new System.Drawing.Size(134, 34);
            this.Btn_VoltarCadCli.TabIndex = 8;
            this.Btn_VoltarCadCli.Text = "Voltar";
            this.Btn_VoltarCadCli.UseVisualStyleBackColor = false;
            this.Btn_VoltarCadCli.Click += new System.EventHandler(this.Btn_VoltarCadCli_Click);
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
            // LstView_ListaCliente
            // 
            this.LstView_ListaCliente.AllowColumnReorder = true;
            this.LstView_ListaCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaCliente.HideSelection = false;
            this.LstView_ListaCliente.Location = new System.Drawing.Point(25, 110);
            this.LstView_ListaCliente.Name = "LstView_ListaCliente";
            this.LstView_ListaCliente.Size = new System.Drawing.Size(1308, 499);
            this.LstView_ListaCliente.TabIndex = 9;
            this.LstView_ListaCliente.UseCompatibleStateImageBehavior = false;
            this.LstView_ListaCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstView_ListaCliente_KeyDown);
            // 
            // Label_BuscaNomeCliente
            // 
            this.Label_BuscaNomeCliente.AutoSize = true;
            this.Label_BuscaNomeCliente.Location = new System.Drawing.Point(23, 31);
            this.Label_BuscaNomeCliente.Name = "Label_BuscaNomeCliente";
            this.Label_BuscaNomeCliente.Size = new System.Drawing.Size(85, 13);
            this.Label_BuscaNomeCliente.TabIndex = 10;
            this.Label_BuscaNomeCliente.Text = "Nome do Cliente";
            // 
            // Txt_ClienteBusca
            // 
            this.Txt_ClienteBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ClienteBusca.Location = new System.Drawing.Point(114, 27);
            this.Txt_ClienteBusca.Name = "Txt_ClienteBusca";
            this.Txt_ClienteBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_ClienteBusca.TabIndex = 1;
            // 
            // Btn_BuscarPorCachorro
            // 
            this.Btn_BuscarPorCachorro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorCachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_BuscarPorCachorro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorCachorro.Location = new System.Drawing.Point(165, 61);
            this.Btn_BuscarPorCachorro.Name = "Btn_BuscarPorCachorro";
            this.Btn_BuscarPorCachorro.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarPorCachorro.TabIndex = 4;
            this.Btn_BuscarPorCachorro.Text = "Buscar por Cachorro";
            this.Btn_BuscarPorCachorro.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorCachorro.Click += new System.EventHandler(this.Btn_BuscarPorCachorro_Click);
            // 
            // Label_QuantidadeClientes
            // 
            this.Label_QuantidadeClientes.AutoSize = true;
            this.Label_QuantidadeClientes.Location = new System.Drawing.Point(22, 623);
            this.Label_QuantidadeClientes.Name = "Label_QuantidadeClientes";
            this.Label_QuantidadeClientes.Size = new System.Drawing.Size(117, 13);
            this.Label_QuantidadeClientes.TabIndex = 12;
            this.Label_QuantidadeClientes.Text = "Quantidade de Clientes";
            // 
            // Label_CalculaQuantidadeCli
            // 
            this.Label_CalculaQuantidadeCli.AutoSize = true;
            this.Label_CalculaQuantidadeCli.Location = new System.Drawing.Point(22, 654);
            this.Label_CalculaQuantidadeCli.Name = "Label_CalculaQuantidadeCli";
            this.Label_CalculaQuantidadeCli.Size = new System.Drawing.Size(13, 13);
            this.Label_CalculaQuantidadeCli.TabIndex = 13;
            this.Label_CalculaQuantidadeCli.Text = "0";
            // 
            // Btn_ExcluirCliente
            // 
            this.Btn_ExcluirCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirCliente.Location = new System.Drawing.Point(585, 59);
            this.Btn_ExcluirCliente.Name = "Btn_ExcluirCliente";
            this.Btn_ExcluirCliente.Size = new System.Drawing.Size(134, 33);
            this.Btn_ExcluirCliente.TabIndex = 7;
            this.Btn_ExcluirCliente.Text = "Excluir";
            this.Btn_ExcluirCliente.UseVisualStyleBackColor = false;
            this.Btn_ExcluirCliente.Click += new System.EventHandler(this.Btn_ExcluirCliente_Click);
            // 
            // Btn_EditarCliente
            // 
            this.Btn_EditarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarCliente.Location = new System.Drawing.Point(445, 59);
            this.Btn_EditarCliente.Name = "Btn_EditarCliente";
            this.Btn_EditarCliente.Size = new System.Drawing.Size(134, 34);
            this.Btn_EditarCliente.TabIndex = 6;
            this.Btn_EditarCliente.Text = "Editar";
            this.Btn_EditarCliente.UseVisualStyleBackColor = false;
            this.Btn_EditarCliente.Click += new System.EventHandler(this.Btn_EditarCliente_Click);
            // 
            // Label_BuscaNomeCachorro
            // 
            this.Label_BuscaNomeCachorro.AutoSize = true;
            this.Label_BuscaNomeCachorro.Location = new System.Drawing.Point(357, 31);
            this.Label_BuscaNomeCachorro.Name = "Label_BuscaNomeCachorro";
            this.Label_BuscaNomeCachorro.Size = new System.Drawing.Size(96, 13);
            this.Label_BuscaNomeCachorro.TabIndex = 11;
            this.Label_BuscaNomeCachorro.Text = "Nome do Cachorro";
            // 
            // Txt_CachorroBusca
            // 
            this.Txt_CachorroBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CachorroBusca.Location = new System.Drawing.Point(459, 27);
            this.Txt_CachorroBusca.Name = "Txt_CachorroBusca";
            this.Txt_CachorroBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_CachorroBusca.TabIndex = 2;
            // 
            // Btn_BuscarTodosClientes
            // 
            this.Btn_BuscarTodosClientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarTodosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_BuscarTodosClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarTodosClientes.Location = new System.Drawing.Point(305, 59);
            this.Btn_BuscarTodosClientes.Name = "Btn_BuscarTodosClientes";
            this.Btn_BuscarTodosClientes.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarTodosClientes.TabIndex = 5;
            this.Btn_BuscarTodosClientes.Text = "Buscar Todos";
            this.Btn_BuscarTodosClientes.UseVisualStyleBackColor = false;
            this.Btn_BuscarTodosClientes.Click += new System.EventHandler(this.Btn_BuscarTodosClientes_Click);
            // 
            // FormListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 684);
            this.Controls.Add(this.Btn_BuscarTodosClientes);
            this.Controls.Add(this.Txt_CachorroBusca);
            this.Controls.Add(this.Label_BuscaNomeCachorro);
            this.Controls.Add(this.Btn_EditarCliente);
            this.Controls.Add(this.Btn_ExcluirCliente);
            this.Controls.Add(this.Label_CalculaQuantidadeCli);
            this.Controls.Add(this.Label_QuantidadeClientes);
            this.Controls.Add(this.Btn_BuscarPorCachorro);
            this.Controls.Add(this.Txt_ClienteBusca);
            this.Controls.Add(this.Label_BuscaNomeCliente);
            this.Controls.Add(this.LstView_ListaCliente);
            this.Controls.Add(this.Btn_VoltarCadCli);
            this.Controls.Add(this.Btn_BuscarPorCliente);
            this.Name = "FormListarCliente";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Lista de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_BuscarPorCliente;
        private System.Windows.Forms.Button Btn_VoltarCadCli;
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
        private System.Windows.Forms.ListView LstView_ListaCliente;
        private System.Windows.Forms.Label Label_BuscaNomeCliente;
        private System.Windows.Forms.TextBox Txt_ClienteBusca;
        private System.Windows.Forms.Button Btn_BuscarPorCachorro;
        private System.Windows.Forms.Label Label_QuantidadeClientes;
        private System.Windows.Forms.Label Label_CalculaQuantidadeCli;
        private System.Windows.Forms.Button Btn_ExcluirCliente;
        private System.Windows.Forms.Button Btn_EditarCliente;
        private System.Windows.Forms.Label Label_BuscaNomeCachorro;
        private System.Windows.Forms.TextBox Txt_CachorroBusca;
        private System.Windows.Forms.Button Btn_BuscarTodosClientes;
    }
}