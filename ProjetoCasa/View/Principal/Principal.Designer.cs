namespace ProjetoCasa
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Clientes = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Produtos = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Pedidos = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Pagamento = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Despesas = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Relatorios = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Clientes,
            this.Tsb_Produtos,
            this.Tsb_Pedidos,
            this.Tsb_Pagamento,
            this.Tsb_Despesas,
            this.Tsb_Relatorios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsb_Clientes
            // 
            this.Tsb_Clientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Clientes.Image")));
            this.Tsb_Clientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Clientes.Name = "Tsb_Clientes";
            this.Tsb_Clientes.Size = new System.Drawing.Size(53, 22);
            this.Tsb_Clientes.Text = "Clientes";
            this.Tsb_Clientes.Click += new System.EventHandler(this.Tsb_Clientes_Click);
            // 
            // Tsb_Produtos
            // 
            this.Tsb_Produtos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Produtos.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Produtos.Image")));
            this.Tsb_Produtos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Produtos.Name = "Tsb_Produtos";
            this.Tsb_Produtos.Size = new System.Drawing.Size(59, 22);
            this.Tsb_Produtos.Text = "Produtos";
            this.Tsb_Produtos.Click += new System.EventHandler(this.Tsb_Produtos_Click);
            // 
            // Tsb_Pedidos
            // 
            this.Tsb_Pedidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Pedidos.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Pedidos.Image")));
            this.Tsb_Pedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Pedidos.Name = "Tsb_Pedidos";
            this.Tsb_Pedidos.Size = new System.Drawing.Size(53, 22);
            this.Tsb_Pedidos.Text = "Pedidos";
            this.Tsb_Pedidos.Click += new System.EventHandler(this.Tsb_Pedidos_Click);
            // 
            // Tsb_Pagamento
            // 
            this.Tsb_Pagamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Pagamento.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Pagamento.Image")));
            this.Tsb_Pagamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Pagamento.Name = "Tsb_Pagamento";
            this.Tsb_Pagamento.Size = new System.Drawing.Size(77, 22);
            this.Tsb_Pagamento.Text = "Pagamentos";
            this.Tsb_Pagamento.Click += new System.EventHandler(this.Tsb_Pagamento_Click);
            // 
            // Tsb_Despesas
            // 
            this.Tsb_Despesas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Despesas.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Despesas.Image")));
            this.Tsb_Despesas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Despesas.Name = "Tsb_Despesas";
            this.Tsb_Despesas.Size = new System.Drawing.Size(59, 22);
            this.Tsb_Despesas.Text = "Despesas";
            this.Tsb_Despesas.Click += new System.EventHandler(this.Tsb_Despesas_Click);
            // 
            // Tsb_Relatorios
            // 
            this.Tsb_Relatorios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Relatorios.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Relatorios.Image")));
            this.Tsb_Relatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Relatorios.Name = "Tsb_Relatorios";
            this.Tsb_Relatorios.Size = new System.Drawing.Size(63, 22);
            this.Tsb_Relatorios.Text = "Relatórios";
            this.Tsb_Relatorios.Click += new System.EventHandler(this.Tsb_Relatorios_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 375);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles das Camas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsb_Pedidos;
        private System.Windows.Forms.ToolStripButton Tsb_Despesas;
        private System.Windows.Forms.ToolStripButton Tsb_Clientes;
        private System.Windows.Forms.ToolStripButton Tsb_Produtos;
        private System.Windows.Forms.ToolStripButton Tsb_Pagamento;
        private System.Windows.Forms.ToolStripButton Tsb_Relatorios;
    }
}

