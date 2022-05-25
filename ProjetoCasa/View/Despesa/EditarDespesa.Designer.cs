namespace ProjetoCasa
{
    partial class FormEditarDespesa
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
            this.Label_DespesaEdit = new System.Windows.Forms.Label();
            this.Label_DatasEdit = new System.Windows.Forms.Label();
            this.Label_FormaPagamentoEdit = new System.Windows.Forms.Label();
            this.Label_StatusPagamentoEdit = new System.Windows.Forms.Label();
            this.Btn_SalvarEditDespesa = new System.Windows.Forms.Button();
            this.Date_DatasEdit = new System.Windows.Forms.DateTimePicker();
            this.Txt_DespesaEdit = new System.Windows.Forms.TextBox();
            this.Date_DataCartaoEdit = new System.Windows.Forms.DateTimePicker();
            this.Label_StatusPagamentoDespEdit = new System.Windows.Forms.Label();
            this.Label_FormaPgtoEdit = new System.Windows.Forms.Label();
            this.Label_CodigoDespesaEdit = new System.Windows.Forms.Label();
            this.Label_CodigoDespesa = new System.Windows.Forms.Label();
            this.Msk_ValorDespesaEdit = new System.Windows.Forms.MaskedTextBox();
            this.Cbo_FormaPgtoEdit = new System.Windows.Forms.ComboBox();
            this.Cbo_RespCartaoEdit = new System.Windows.Forms.ComboBox();
            this.Label_RespCartaoEdit = new System.Windows.Forms.Label();
            this.Cbo_StatusPgtoDespEdit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label_DespesaEdit
            // 
            this.Label_DespesaEdit.AutoSize = true;
            this.Label_DespesaEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DespesaEdit.Location = new System.Drawing.Point(65, 84);
            this.Label_DespesaEdit.Name = "Label_DespesaEdit";
            this.Label_DespesaEdit.Size = new System.Drawing.Size(56, 15);
            this.Label_DespesaEdit.TabIndex = 12;
            this.Label_DespesaEdit.Text = "Despesa";
            // 
            // Label_DatasEdit
            // 
            this.Label_DatasEdit.AutoSize = true;
            this.Label_DatasEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DatasEdit.Location = new System.Drawing.Point(88, 45);
            this.Label_DatasEdit.Name = "Label_DatasEdit";
            this.Label_DatasEdit.Size = new System.Drawing.Size(33, 15);
            this.Label_DatasEdit.TabIndex = 11;
            this.Label_DatasEdit.Text = "Data";
            // 
            // Label_FormaPagamentoEdit
            // 
            this.Label_FormaPagamentoEdit.AutoSize = true;
            this.Label_FormaPagamentoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FormaPagamentoEdit.Location = new System.Drawing.Point(16, 124);
            this.Label_FormaPagamentoEdit.Name = "Label_FormaPagamentoEdit";
            this.Label_FormaPagamentoEdit.Size = new System.Drawing.Size(104, 15);
            this.Label_FormaPagamentoEdit.TabIndex = 13;
            this.Label_FormaPagamentoEdit.Text = "Valor da Despesa";
            // 
            // Label_StatusPagamentoEdit
            // 
            this.Label_StatusPagamentoEdit.AutoSize = true;
            this.Label_StatusPagamentoEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StatusPagamentoEdit.Location = new System.Drawing.Point(32, 204);
            this.Label_StatusPagamentoEdit.Name = "Label_StatusPagamentoEdit";
            this.Label_StatusPagamentoEdit.Size = new System.Drawing.Size(89, 15);
            this.Label_StatusPagamentoEdit.TabIndex = 15;
            this.Label_StatusPagamentoEdit.Text = "Data do Cartão";
            // 
            // Btn_SalvarEditDespesa
            // 
            this.Btn_SalvarEditDespesa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarEditDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarEditDespesa.Location = new System.Drawing.Point(175, 343);
            this.Btn_SalvarEditDespesa.Name = "Btn_SalvarEditDespesa";
            this.Btn_SalvarEditDespesa.Size = new System.Drawing.Size(121, 37);
            this.Btn_SalvarEditDespesa.TabIndex = 9;
            this.Btn_SalvarEditDespesa.Text = "Salvar";
            this.Btn_SalvarEditDespesa.UseVisualStyleBackColor = false;
            this.Btn_SalvarEditDespesa.Click += new System.EventHandler(this.Btn_SalvarEditDespesa_Click);
            // 
            // Date_DatasEdit
            // 
            this.Date_DatasEdit.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DatasEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DatasEdit.Location = new System.Drawing.Point(127, 45);
            this.Date_DatasEdit.Name = "Date_DatasEdit";
            this.Date_DatasEdit.Size = new System.Drawing.Size(154, 20);
            this.Date_DatasEdit.TabIndex = 2;
            // 
            // Txt_DespesaEdit
            // 
            this.Txt_DespesaEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DespesaEdit.Location = new System.Drawing.Point(127, 82);
            this.Txt_DespesaEdit.Name = "Txt_DespesaEdit";
            this.Txt_DespesaEdit.Size = new System.Drawing.Size(153, 21);
            this.Txt_DespesaEdit.TabIndex = 3;
            // 
            // Date_DataCartaoEdit
            // 
            this.Date_DataCartaoEdit.Enabled = false;
            this.Date_DataCartaoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataCartaoEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataCartaoEdit.Location = new System.Drawing.Point(127, 204);
            this.Date_DataCartaoEdit.Name = "Date_DataCartaoEdit";
            this.Date_DataCartaoEdit.Size = new System.Drawing.Size(154, 21);
            this.Date_DataCartaoEdit.TabIndex = 6;
            this.Date_DataCartaoEdit.DropDown += new System.EventHandler(this.Date_DataCartaoEdit_DropDown);
            // 
            // Label_StatusPagamentoDespEdit
            // 
            this.Label_StatusPagamentoDespEdit.AutoSize = true;
            this.Label_StatusPagamentoDespEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StatusPagamentoDespEdit.Location = new System.Drawing.Point(13, 292);
            this.Label_StatusPagamentoDespEdit.Name = "Label_StatusPagamentoDespEdit";
            this.Label_StatusPagamentoDespEdit.Size = new System.Drawing.Size(108, 15);
            this.Label_StatusPagamentoDespEdit.TabIndex = 17;
            this.Label_StatusPagamentoDespEdit.Text = "Status Pagamento";
            // 
            // Label_FormaPgtoEdit
            // 
            this.Label_FormaPgtoEdit.AutoSize = true;
            this.Label_FormaPgtoEdit.Location = new System.Drawing.Point(12, 166);
            this.Label_FormaPgtoEdit.Name = "Label_FormaPgtoEdit";
            this.Label_FormaPgtoEdit.Size = new System.Drawing.Size(108, 13);
            this.Label_FormaPgtoEdit.TabIndex = 14;
            this.Label_FormaPgtoEdit.Text = "Forma de Pagamento";
            // 
            // Label_CodigoDespesaEdit
            // 
            this.Label_CodigoDespesaEdit.AutoSize = true;
            this.Label_CodigoDespesaEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoDespesaEdit.Location = new System.Drawing.Point(75, 10);
            this.Label_CodigoDespesaEdit.Name = "Label_CodigoDespesaEdit";
            this.Label_CodigoDespesaEdit.Size = new System.Drawing.Size(46, 15);
            this.Label_CodigoDespesaEdit.TabIndex = 10;
            this.Label_CodigoDespesaEdit.Text = "Código";
            // 
            // Label_CodigoDespesa
            // 
            this.Label_CodigoDespesa.AutoSize = true;
            this.Label_CodigoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoDespesa.Location = new System.Drawing.Point(124, 10);
            this.Label_CodigoDespesa.Name = "Label_CodigoDespesa";
            this.Label_CodigoDespesa.Size = new System.Drawing.Size(14, 15);
            this.Label_CodigoDespesa.TabIndex = 1;
            this.Label_CodigoDespesa.Text = "0";
            // 
            // Msk_ValorDespesaEdit
            // 
            this.Msk_ValorDespesaEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_ValorDespesaEdit.Location = new System.Drawing.Point(126, 122);
            this.Msk_ValorDespesaEdit.Mask = "$#####,##";
            this.Msk_ValorDespesaEdit.Name = "Msk_ValorDespesaEdit";
            this.Msk_ValorDespesaEdit.Size = new System.Drawing.Size(154, 21);
            this.Msk_ValorDespesaEdit.TabIndex = 4;
            this.Msk_ValorDespesaEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Msk_ValorDespesaEdit_KeyDown);
            // 
            // Cbo_FormaPgtoEdit
            // 
            this.Cbo_FormaPgtoEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_FormaPgtoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_FormaPgtoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_FormaPgtoEdit.FormattingEnabled = true;
            this.Cbo_FormaPgtoEdit.Location = new System.Drawing.Point(126, 162);
            this.Cbo_FormaPgtoEdit.Name = "Cbo_FormaPgtoEdit";
            this.Cbo_FormaPgtoEdit.Size = new System.Drawing.Size(154, 23);
            this.Cbo_FormaPgtoEdit.TabIndex = 5;
            this.Cbo_FormaPgtoEdit.TextChanged += new System.EventHandler(this.Cbo_FormaPgtoEdit_TextChanged);
            // 
            // Cbo_RespCartaoEdit
            // 
            this.Cbo_RespCartaoEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_RespCartaoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_RespCartaoEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_RespCartaoEdit.FormattingEnabled = true;
            this.Cbo_RespCartaoEdit.Location = new System.Drawing.Point(127, 245);
            this.Cbo_RespCartaoEdit.Name = "Cbo_RespCartaoEdit";
            this.Cbo_RespCartaoEdit.Size = new System.Drawing.Size(154, 23);
            this.Cbo_RespCartaoEdit.TabIndex = 7;
            // 
            // Label_RespCartaoEdit
            // 
            this.Label_RespCartaoEdit.AutoSize = true;
            this.Label_RespCartaoEdit.Location = new System.Drawing.Point(18, 249);
            this.Label_RespCartaoEdit.Name = "Label_RespCartaoEdit";
            this.Label_RespCartaoEdit.Size = new System.Drawing.Size(103, 13);
            this.Label_RespCartaoEdit.TabIndex = 16;
            this.Label_RespCartaoEdit.Text = "Responsável Cartão";
            // 
            // Cbo_StatusPgtoDespEdit
            // 
            this.Cbo_StatusPgtoDespEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_StatusPgtoDespEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_StatusPgtoDespEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_StatusPgtoDespEdit.FormattingEnabled = true;
            this.Cbo_StatusPgtoDespEdit.Location = new System.Drawing.Point(127, 290);
            this.Cbo_StatusPgtoDespEdit.Name = "Cbo_StatusPgtoDespEdit";
            this.Cbo_StatusPgtoDespEdit.Size = new System.Drawing.Size(154, 23);
            this.Cbo_StatusPgtoDespEdit.TabIndex = 8;
            // 
            // FormEditarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 408);
            this.Controls.Add(this.Cbo_StatusPgtoDespEdit);
            this.Controls.Add(this.Cbo_RespCartaoEdit);
            this.Controls.Add(this.Label_RespCartaoEdit);
            this.Controls.Add(this.Cbo_FormaPgtoEdit);
            this.Controls.Add(this.Msk_ValorDespesaEdit);
            this.Controls.Add(this.Label_CodigoDespesa);
            this.Controls.Add(this.Label_CodigoDespesaEdit);
            this.Controls.Add(this.Label_FormaPgtoEdit);
            this.Controls.Add(this.Label_StatusPagamentoDespEdit);
            this.Controls.Add(this.Date_DataCartaoEdit);
            this.Controls.Add(this.Txt_DespesaEdit);
            this.Controls.Add(this.Date_DatasEdit);
            this.Controls.Add(this.Btn_SalvarEditDespesa);
            this.Controls.Add(this.Label_StatusPagamentoEdit);
            this.Controls.Add(this.Label_FormaPagamentoEdit);
            this.Controls.Add(this.Label_DatasEdit);
            this.Controls.Add(this.Label_DespesaEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEditarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.FormEditarDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_DespesaEdit;
        private System.Windows.Forms.Label Label_DatasEdit;
        private System.Windows.Forms.Label Label_FormaPagamentoEdit;
        private System.Windows.Forms.Label Label_StatusPagamentoEdit;
        private System.Windows.Forms.Button Btn_SalvarEditDespesa;
        private System.Windows.Forms.DateTimePicker Date_DatasEdit;
        private System.Windows.Forms.TextBox Txt_DespesaEdit;
        private System.Windows.Forms.DateTimePicker Date_DataCartaoEdit;
        private System.Windows.Forms.Label Label_StatusPagamentoDespEdit;
        private System.Windows.Forms.Label Label_FormaPgtoEdit;
        private System.Windows.Forms.Label Label_CodigoDespesaEdit;
        private System.Windows.Forms.Label Label_CodigoDespesa;
        private System.Windows.Forms.MaskedTextBox Msk_ValorDespesaEdit;
        private System.Windows.Forms.ComboBox Cbo_FormaPgtoEdit;
        private System.Windows.Forms.ComboBox Cbo_RespCartaoEdit;
        private System.Windows.Forms.Label Label_RespCartaoEdit;
        private System.Windows.Forms.ComboBox Cbo_StatusPgtoDespEdit;
    }
}