namespace ProjetoCasa
{
    partial class FormDespesa
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
            this.Label_Despesa = new System.Windows.Forms.Label();
            this.Label_Datas = new System.Windows.Forms.Label();
            this.Label_FormaPagamento = new System.Windows.Forms.Label();
            this.Label_StatusPagamento = new System.Windows.Forms.Label();
            this.Btn_SalvarDespesa = new System.Windows.Forms.Button();
            this.Btn_ListarDespesa = new System.Windows.Forms.Button();
            this.Date_Datas = new System.Windows.Forms.DateTimePicker();
            this.Txt_Despesa = new System.Windows.Forms.TextBox();
            this.Date_DataCartao = new System.Windows.Forms.DateTimePicker();
            this.Label_StatusPagamentoDesp = new System.Windows.Forms.Label();
            this.Label_FormaPgto = new System.Windows.Forms.Label();
            this.Msk_ValorDespesa = new System.Windows.Forms.MaskedTextBox();
            this.Cbo_FormaPgto = new System.Windows.Forms.ComboBox();
            this.Cbo_RespCartao = new System.Windows.Forms.ComboBox();
            this.Label_RespCartao = new System.Windows.Forms.Label();
            this.Cbo_StatusPgtoDesp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label_Despesa
            // 
            this.Label_Despesa.AutoSize = true;
            this.Label_Despesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Despesa.Location = new System.Drawing.Point(66, 64);
            this.Label_Despesa.Name = "Label_Despesa";
            this.Label_Despesa.Size = new System.Drawing.Size(56, 15);
            this.Label_Despesa.TabIndex = 11;
            this.Label_Despesa.Text = "Despesa";
            // 
            // Label_Datas
            // 
            this.Label_Datas.AutoSize = true;
            this.Label_Datas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Datas.Location = new System.Drawing.Point(89, 25);
            this.Label_Datas.Name = "Label_Datas";
            this.Label_Datas.Size = new System.Drawing.Size(33, 15);
            this.Label_Datas.TabIndex = 10;
            this.Label_Datas.Text = "Data";
            // 
            // Label_FormaPagamento
            // 
            this.Label_FormaPagamento.AutoSize = true;
            this.Label_FormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormaPagamento.Location = new System.Drawing.Point(18, 106);
            this.Label_FormaPagamento.Name = "Label_FormaPagamento";
            this.Label_FormaPagamento.Size = new System.Drawing.Size(104, 15);
            this.Label_FormaPagamento.TabIndex = 12;
            this.Label_FormaPagamento.Text = "Valor da Despesa";
            // 
            // Label_StatusPagamento
            // 
            this.Label_StatusPagamento.AutoSize = true;
            this.Label_StatusPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StatusPagamento.Location = new System.Drawing.Point(33, 188);
            this.Label_StatusPagamento.Name = "Label_StatusPagamento";
            this.Label_StatusPagamento.Size = new System.Drawing.Size(89, 15);
            this.Label_StatusPagamento.TabIndex = 14;
            this.Label_StatusPagamento.Text = "Data do Cartão";
            // 
            // Btn_SalvarDespesa
            // 
            this.Btn_SalvarDespesa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarDespesa.Location = new System.Drawing.Point(171, 318);
            this.Btn_SalvarDespesa.Name = "Btn_SalvarDespesa";
            this.Btn_SalvarDespesa.Size = new System.Drawing.Size(121, 38);
            this.Btn_SalvarDespesa.TabIndex = 9;
            this.Btn_SalvarDespesa.Text = "Salvar";
            this.Btn_SalvarDespesa.UseVisualStyleBackColor = false;
            this.Btn_SalvarDespesa.Click += new System.EventHandler(this.Btn_SalvarDespesa_Click);
            // 
            // Btn_ListarDespesa
            // 
            this.Btn_ListarDespesa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ListarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListarDespesa.Location = new System.Drawing.Point(26, 318);
            this.Btn_ListarDespesa.Name = "Btn_ListarDespesa";
            this.Btn_ListarDespesa.Size = new System.Drawing.Size(121, 38);
            this.Btn_ListarDespesa.TabIndex = 8;
            this.Btn_ListarDespesa.Text = "Listar";
            this.Btn_ListarDespesa.UseVisualStyleBackColor = false;
            this.Btn_ListarDespesa.Click += new System.EventHandler(this.Btn_ListarDespesa_Click);
            // 
            // Date_Datas
            // 
            this.Date_Datas.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Datas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Datas.Location = new System.Drawing.Point(128, 25);
            this.Date_Datas.Name = "Date_Datas";
            this.Date_Datas.Size = new System.Drawing.Size(154, 20);
            this.Date_Datas.TabIndex = 1;
            // 
            // Txt_Despesa
            // 
            this.Txt_Despesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Despesa.Location = new System.Drawing.Point(128, 62);
            this.Txt_Despesa.Name = "Txt_Despesa";
            this.Txt_Despesa.Size = new System.Drawing.Size(153, 21);
            this.Txt_Despesa.TabIndex = 2;
            // 
            // Date_DataCartao
            // 
            this.Date_DataCartao.Enabled = false;
            this.Date_DataCartao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataCartao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataCartao.Location = new System.Drawing.Point(128, 184);
            this.Date_DataCartao.Name = "Date_DataCartao";
            this.Date_DataCartao.Size = new System.Drawing.Size(154, 21);
            this.Date_DataCartao.TabIndex = 5;
            this.Date_DataCartao.DropDown += new System.EventHandler(this.Date_DataCartao_DropDown);
            // 
            // Label_StatusPagamentoDesp
            // 
            this.Label_StatusPagamentoDesp.AutoSize = true;
            this.Label_StatusPagamentoDesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StatusPagamentoDesp.Location = new System.Drawing.Point(14, 276);
            this.Label_StatusPagamentoDesp.Name = "Label_StatusPagamentoDesp";
            this.Label_StatusPagamentoDesp.Size = new System.Drawing.Size(108, 15);
            this.Label_StatusPagamentoDesp.TabIndex = 16;
            this.Label_StatusPagamentoDesp.Text = "Status Pagamento";
            // 
            // Label_FormaPgto
            // 
            this.Label_FormaPgto.AutoSize = true;
            this.Label_FormaPgto.Location = new System.Drawing.Point(14, 146);
            this.Label_FormaPgto.Name = "Label_FormaPgto";
            this.Label_FormaPgto.Size = new System.Drawing.Size(108, 13);
            this.Label_FormaPgto.TabIndex = 13;
            this.Label_FormaPgto.Text = "Forma de Pagamento";
            // 
            // Msk_ValorDespesa
            // 
            this.Msk_ValorDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_ValorDespesa.Location = new System.Drawing.Point(128, 106);
            this.Msk_ValorDespesa.Mask = "$####,##";
            this.Msk_ValorDespesa.Name = "Msk_ValorDespesa";
            this.Msk_ValorDespesa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Msk_ValorDespesa.Size = new System.Drawing.Size(154, 21);
            this.Msk_ValorDespesa.TabIndex = 3;
            this.Msk_ValorDespesa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_ValorDespesa_KeyDown);
            // 
            // Cbo_FormaPgto
            // 
            this.Cbo_FormaPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_FormaPgto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_FormaPgto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_FormaPgto.FormattingEnabled = true;
            this.Cbo_FormaPgto.Location = new System.Drawing.Point(128, 142);
            this.Cbo_FormaPgto.Name = "Cbo_FormaPgto";
            this.Cbo_FormaPgto.Size = new System.Drawing.Size(154, 23);
            this.Cbo_FormaPgto.TabIndex = 4;
            this.Cbo_FormaPgto.TextChanged += new System.EventHandler(this.Cbo_FormaPgto_TextChanged);
            // 
            // Cbo_RespCartao
            // 
            this.Cbo_RespCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_RespCartao.Enabled = false;
            this.Cbo_RespCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_RespCartao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_RespCartao.FormattingEnabled = true;
            this.Cbo_RespCartao.Location = new System.Drawing.Point(128, 225);
            this.Cbo_RespCartao.Name = "Cbo_RespCartao";
            this.Cbo_RespCartao.Size = new System.Drawing.Size(154, 23);
            this.Cbo_RespCartao.TabIndex = 6;
            // 
            // Label_RespCartao
            // 
            this.Label_RespCartao.AutoSize = true;
            this.Label_RespCartao.Location = new System.Drawing.Point(19, 229);
            this.Label_RespCartao.Name = "Label_RespCartao";
            this.Label_RespCartao.Size = new System.Drawing.Size(103, 13);
            this.Label_RespCartao.TabIndex = 15;
            this.Label_RespCartao.Text = "Responsável Cartão";
            // 
            // Cbo_StatusPgtoDesp
            // 
            this.Cbo_StatusPgtoDesp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_StatusPgtoDesp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_StatusPgtoDesp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_StatusPgtoDesp.FormattingEnabled = true;
            this.Cbo_StatusPgtoDesp.Location = new System.Drawing.Point(127, 268);
            this.Cbo_StatusPgtoDesp.Name = "Cbo_StatusPgtoDesp";
            this.Cbo_StatusPgtoDesp.Size = new System.Drawing.Size(154, 23);
            this.Cbo_StatusPgtoDesp.TabIndex = 7;
            // 
            // FormDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 375);
            this.Controls.Add(this.Cbo_StatusPgtoDesp);
            this.Controls.Add(this.Cbo_RespCartao);
            this.Controls.Add(this.Label_RespCartao);
            this.Controls.Add(this.Cbo_FormaPgto);
            this.Controls.Add(this.Msk_ValorDespesa);
            this.Controls.Add(this.Label_FormaPgto);
            this.Controls.Add(this.Label_StatusPagamentoDesp);
            this.Controls.Add(this.Date_DataCartao);
            this.Controls.Add(this.Txt_Despesa);
            this.Controls.Add(this.Date_Datas);
            this.Controls.Add(this.Btn_ListarDespesa);
            this.Controls.Add(this.Btn_SalvarDespesa);
            this.Controls.Add(this.Label_StatusPagamento);
            this.Controls.Add(this.Label_FormaPagamento);
            this.Controls.Add(this.Label_Datas);
            this.Controls.Add(this.Label_Despesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.FormDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Despesa;
        private System.Windows.Forms.Label Label_Datas;
        private System.Windows.Forms.Label Label_FormaPagamento;
        private System.Windows.Forms.Label Label_StatusPagamento;
        private System.Windows.Forms.Button Btn_SalvarDespesa;
        private System.Windows.Forms.Button Btn_ListarDespesa;
        private System.Windows.Forms.DateTimePicker Date_Datas;
        private System.Windows.Forms.TextBox Txt_Despesa;
        private System.Windows.Forms.DateTimePicker Date_DataCartao;
        private System.Windows.Forms.Label Label_StatusPagamentoDesp;
        private System.Windows.Forms.Label Label_FormaPgto;
        private System.Windows.Forms.MaskedTextBox Msk_ValorDespesa;
        private System.Windows.Forms.ComboBox Cbo_FormaPgto;
        private System.Windows.Forms.ComboBox Cbo_RespCartao;
        private System.Windows.Forms.Label Label_RespCartao;
        private System.Windows.Forms.ComboBox Cbo_StatusPgtoDesp;
    }
}