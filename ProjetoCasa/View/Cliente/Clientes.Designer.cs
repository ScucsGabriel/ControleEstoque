namespace ProjetoCasa
{
    partial class FormCliente
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
            this.Txt_NomeCachorro = new System.Windows.Forms.TextBox();
            this.Txt_TelefoneCliente = new System.Windows.Forms.Label();
            this.Label_EmailCliente = new System.Windows.Forms.Label();
            this.Txt_EmailCliente = new System.Windows.Forms.TextBox();
            this.Btn_SalvarCliente = new System.Windows.Forms.Button();
            this.Label_EnderecoCliente = new System.Windows.Forms.Label();
            this.Btn_ListarCliente = new System.Windows.Forms.Button();
            this.Txt_EnderecoCliente = new System.Windows.Forms.TextBox();
            this.Label_NomeCliente = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Masked_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Label_NomeCachorro
            // 
            this.Label_NomeCachorro.AutoSize = true;
            this.Label_NomeCachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NomeCachorro.Location = new System.Drawing.Point(41, 55);
            this.Label_NomeCachorro.Name = "Label_NomeCachorro";
            this.Label_NomeCachorro.Size = new System.Drawing.Size(111, 15);
            this.Label_NomeCachorro.TabIndex = 9;
            this.Label_NomeCachorro.Text = "Nome do Cachorro";
            // 
            // Txt_NomeCachorro
            // 
            this.Txt_NomeCachorro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeCachorro.Location = new System.Drawing.Point(158, 53);
            this.Txt_NomeCachorro.Name = "Txt_NomeCachorro";
            this.Txt_NomeCachorro.Size = new System.Drawing.Size(199, 21);
            this.Txt_NomeCachorro.TabIndex = 2;
            // 
            // Txt_TelefoneCliente
            // 
            this.Txt_TelefoneCliente.AutoSize = true;
            this.Txt_TelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TelefoneCliente.Location = new System.Drawing.Point(97, 87);
            this.Txt_TelefoneCliente.Name = "Txt_TelefoneCliente";
            this.Txt_TelefoneCliente.Size = new System.Drawing.Size(55, 15);
            this.Txt_TelefoneCliente.TabIndex = 10;
            this.Txt_TelefoneCliente.Text = "Telefone";
            // 
            // Label_EmailCliente
            // 
            this.Label_EmailCliente.AutoSize = true;
            this.Label_EmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EmailCliente.Location = new System.Drawing.Point(109, 122);
            this.Label_EmailCliente.Name = "Label_EmailCliente";
            this.Label_EmailCliente.Size = new System.Drawing.Size(43, 15);
            this.Label_EmailCliente.TabIndex = 11;
            this.Label_EmailCliente.Text = "E-mail";
            // 
            // Txt_EmailCliente
            // 
            this.Txt_EmailCliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailCliente.Location = new System.Drawing.Point(158, 121);
            this.Txt_EmailCliente.Name = "Txt_EmailCliente";
            this.Txt_EmailCliente.Size = new System.Drawing.Size(199, 20);
            this.Txt_EmailCliente.TabIndex = 4;
            // 
            // Btn_SalvarCliente
            // 
            this.Btn_SalvarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarCliente.Location = new System.Drawing.Point(236, 221);
            this.Btn_SalvarCliente.Name = "Btn_SalvarCliente";
            this.Btn_SalvarCliente.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarCliente.TabIndex = 7;
            this.Btn_SalvarCliente.Text = "Salvar";
            this.Btn_SalvarCliente.UseVisualStyleBackColor = false;
            this.Btn_SalvarCliente.Click += new System.EventHandler(this.Btn_SalvarCliente_Click);
            // 
            // Label_EnderecoCliente
            // 
            this.Label_EnderecoCliente.AutoSize = true;
            this.Label_EnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EnderecoCliente.Location = new System.Drawing.Point(92, 165);
            this.Label_EnderecoCliente.Name = "Label_EnderecoCliente";
            this.Label_EnderecoCliente.Size = new System.Drawing.Size(60, 15);
            this.Label_EnderecoCliente.TabIndex = 12;
            this.Label_EnderecoCliente.Text = "Endereço";
            // 
            // Btn_ListarCliente
            // 
            this.Btn_ListarCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ListarCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_ListarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListarCliente.Location = new System.Drawing.Point(24, 221);
            this.Btn_ListarCliente.Name = "Btn_ListarCliente";
            this.Btn_ListarCliente.Size = new System.Drawing.Size(121, 38);
            this.Btn_ListarCliente.TabIndex = 6;
            this.Btn_ListarCliente.Text = "Listar";
            this.Btn_ListarCliente.UseVisualStyleBackColor = false;
            this.Btn_ListarCliente.Click += new System.EventHandler(this.Btn_ListarCliente_Click);
            // 
            // Txt_EnderecoCliente
            // 
            this.Txt_EnderecoCliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EnderecoCliente.Location = new System.Drawing.Point(158, 153);
            this.Txt_EnderecoCliente.Multiline = true;
            this.Txt_EnderecoCliente.Name = "Txt_EnderecoCliente";
            this.Txt_EnderecoCliente.Size = new System.Drawing.Size(199, 46);
            this.Txt_EnderecoCliente.TabIndex = 5;
            // 
            // Label_NomeCliente
            // 
            this.Label_NomeCliente.AutoSize = true;
            this.Label_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NomeCliente.Location = new System.Drawing.Point(53, 21);
            this.Label_NomeCliente.Name = "Label_NomeCliente";
            this.Label_NomeCliente.Size = new System.Drawing.Size(99, 15);
            this.Label_NomeCliente.TabIndex = 8;
            this.Label_NomeCliente.Text = "Nome do Cliente";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeCliente.Location = new System.Drawing.Point(158, 19);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(199, 21);
            this.Txt_NomeCliente.TabIndex = 1;
            // 
            // Masked_Telefone
            // 
            this.Masked_Telefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masked_Telefone.Location = new System.Drawing.Point(158, 85);
            this.Masked_Telefone.Mask = "(##) # ####-####";
            this.Masked_Telefone.Name = "Masked_Telefone";
            this.Masked_Telefone.Size = new System.Drawing.Size(199, 21);
            this.Masked_Telefone.TabIndex = 3;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 272);
            this.Controls.Add(this.Masked_Telefone);
            this.Controls.Add(this.Txt_NomeCliente);
            this.Controls.Add(this.Label_NomeCliente);
            this.Controls.Add(this.Txt_EnderecoCliente);
            this.Controls.Add(this.Btn_ListarCliente);
            this.Controls.Add(this.Label_EnderecoCliente);
            this.Controls.Add(this.Btn_SalvarCliente);
            this.Controls.Add(this.Txt_EmailCliente);
            this.Controls.Add(this.Label_EmailCliente);
            this.Controls.Add(this.Txt_TelefoneCliente);
            this.Controls.Add(this.Txt_NomeCachorro);
            this.Controls.Add(this.Label_NomeCachorro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_NomeCachorro;
        private System.Windows.Forms.TextBox Txt_NomeCachorro;
        private System.Windows.Forms.Label Txt_TelefoneCliente;
        private System.Windows.Forms.Label Label_EmailCliente;
        private System.Windows.Forms.TextBox Txt_EmailCliente;
        private System.Windows.Forms.Button Btn_SalvarCliente;
        private System.Windows.Forms.Label Label_EnderecoCliente;
        private System.Windows.Forms.Button Btn_ListarCliente;
        private System.Windows.Forms.TextBox Txt_EnderecoCliente;
        private System.Windows.Forms.Label Label_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.MaskedTextBox Masked_Telefone;
    }
}