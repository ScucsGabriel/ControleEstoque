namespace ProjetoCasa.View.Relatorio
{
    partial class FormRelatorio
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
            this.Date_DataMaximaRelatorio = new System.Windows.Forms.DateTimePicker();
            this.Label_DataMaximaRelatorio = new System.Windows.Forms.Label();
            this.Date_DataMinimaRelatorio = new System.Windows.Forms.DateTimePicker();
            this.Label_DataMinimaRelatorio = new System.Windows.Forms.Label();
            this.Btn_GerarRelatorio = new System.Windows.Forms.Button();
            this.Btn_SalvarPdf = new System.Windows.Forms.Button();
            this.Btn_GerarFluxoCaixa = new System.Windows.Forms.Button();
            this.LstView_Relatorio = new System.Windows.Forms.ListView();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Salvar_Pdf = new System.Windows.Forms.SaveFileDialog();
            this.Btn_GerarItensPedidos = new System.Windows.Forms.Button();
            this.Btn_SalvarXls = new System.Windows.Forms.Button();
            this.Salvar_Xls = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Date_DataMaximaRelatorio
            // 
            this.Date_DataMaximaRelatorio.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataMaximaRelatorio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataMaximaRelatorio.Location = new System.Drawing.Point(421, 29);
            this.Date_DataMaximaRelatorio.Name = "Date_DataMaximaRelatorio";
            this.Date_DataMaximaRelatorio.Size = new System.Drawing.Size(237, 20);
            this.Date_DataMaximaRelatorio.TabIndex = 2;
            // 
            // Label_DataMaximaRelatorio
            // 
            this.Label_DataMaximaRelatorio.AutoSize = true;
            this.Label_DataMaximaRelatorio.Location = new System.Drawing.Point(346, 34);
            this.Label_DataMaximaRelatorio.Name = "Label_DataMaximaRelatorio";
            this.Label_DataMaximaRelatorio.Size = new System.Drawing.Size(69, 13);
            this.Label_DataMaximaRelatorio.TabIndex = 11;
            this.Label_DataMaximaRelatorio.Text = "Data Máxima";
            // 
            // Date_DataMinimaRelatorio
            // 
            this.Date_DataMinimaRelatorio.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DataMinimaRelatorio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_DataMinimaRelatorio.Location = new System.Drawing.Point(98, 29);
            this.Date_DataMinimaRelatorio.Name = "Date_DataMinimaRelatorio";
            this.Date_DataMinimaRelatorio.Size = new System.Drawing.Size(237, 20);
            this.Date_DataMinimaRelatorio.TabIndex = 1;
            // 
            // Label_DataMinimaRelatorio
            // 
            this.Label_DataMinimaRelatorio.AutoSize = true;
            this.Label_DataMinimaRelatorio.Location = new System.Drawing.Point(24, 35);
            this.Label_DataMinimaRelatorio.Name = "Label_DataMinimaRelatorio";
            this.Label_DataMinimaRelatorio.Size = new System.Drawing.Size(68, 13);
            this.Label_DataMinimaRelatorio.TabIndex = 10;
            this.Label_DataMinimaRelatorio.Text = "Data Mínima";
            // 
            // Btn_GerarRelatorio
            // 
            this.Btn_GerarRelatorio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_GerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_GerarRelatorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_GerarRelatorio.Location = new System.Drawing.Point(167, 64);
            this.Btn_GerarRelatorio.Name = "Btn_GerarRelatorio";
            this.Btn_GerarRelatorio.Size = new System.Drawing.Size(134, 34);
            this.Btn_GerarRelatorio.TabIndex = 4;
            this.Btn_GerarRelatorio.Text = "Gerar Relatório";
            this.Btn_GerarRelatorio.UseVisualStyleBackColor = false;
            this.Btn_GerarRelatorio.Click += new System.EventHandler(this.Btn_GerarRelatorio_Click);
            // 
            // Btn_SalvarPdf
            // 
            this.Btn_SalvarPdf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarPdf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_SalvarPdf.Location = new System.Drawing.Point(1200, 646);
            this.Btn_SalvarPdf.Name = "Btn_SalvarPdf";
            this.Btn_SalvarPdf.Size = new System.Drawing.Size(134, 34);
            this.Btn_SalvarPdf.TabIndex = 9;
            this.Btn_SalvarPdf.Text = "Salvar PDF";
            this.Btn_SalvarPdf.UseVisualStyleBackColor = false;
            this.Btn_SalvarPdf.Click += new System.EventHandler(this.Btn_SalvarPdf_Click);
            // 
            // Btn_GerarFluxoCaixa
            // 
            this.Btn_GerarFluxoCaixa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_GerarFluxoCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_GerarFluxoCaixa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_GerarFluxoCaixa.Location = new System.Drawing.Point(27, 64);
            this.Btn_GerarFluxoCaixa.Name = "Btn_GerarFluxoCaixa";
            this.Btn_GerarFluxoCaixa.Size = new System.Drawing.Size(134, 33);
            this.Btn_GerarFluxoCaixa.TabIndex = 3;
            this.Btn_GerarFluxoCaixa.Text = "Gerar Fluxo de Caixa";
            this.Btn_GerarFluxoCaixa.UseVisualStyleBackColor = false;
            this.Btn_GerarFluxoCaixa.Click += new System.EventHandler(this.Btn_GerarFluxoCaixa_Click);
            // 
            // LstView_Relatorio
            // 
            this.LstView_Relatorio.AllowColumnReorder = true;
            this.LstView_Relatorio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_Relatorio.HideSelection = false;
            this.LstView_Relatorio.Location = new System.Drawing.Point(26, 114);
            this.LstView_Relatorio.Name = "LstView_Relatorio";
            this.LstView_Relatorio.Size = new System.Drawing.Size(1308, 526);
            this.LstView_Relatorio.TabIndex = 7;
            this.LstView_Relatorio.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Voltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Voltar.Location = new System.Drawing.Point(447, 64);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(134, 33);
            this.Btn_Voltar.TabIndex = 6;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_GerarItensPedidos
            // 
            this.Btn_GerarItensPedidos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_GerarItensPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_GerarItensPedidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_GerarItensPedidos.Location = new System.Drawing.Point(307, 64);
            this.Btn_GerarItensPedidos.Name = "Btn_GerarItensPedidos";
            this.Btn_GerarItensPedidos.Size = new System.Drawing.Size(134, 34);
            this.Btn_GerarItensPedidos.TabIndex = 5;
            this.Btn_GerarItensPedidos.Text = "Gerar Itens Vendidos";
            this.Btn_GerarItensPedidos.UseVisualStyleBackColor = false;
            this.Btn_GerarItensPedidos.Click += new System.EventHandler(this.Btn_GerarItensPedidos_Click);
            // 
            // Btn_SalvarXls
            // 
            this.Btn_SalvarXls.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarXls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarXls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_SalvarXls.Location = new System.Drawing.Point(1060, 646);
            this.Btn_SalvarXls.Name = "Btn_SalvarXls";
            this.Btn_SalvarXls.Size = new System.Drawing.Size(134, 34);
            this.Btn_SalvarXls.TabIndex = 8;
            this.Btn_SalvarXls.Text = "Salvar XLS";
            this.Btn_SalvarXls.UseVisualStyleBackColor = false;
            this.Btn_SalvarXls.Click += new System.EventHandler(this.Btn_SalvarXls_Click);
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 692);
            this.Controls.Add(this.Btn_SalvarXls);
            this.Controls.Add(this.Btn_GerarItensPedidos);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.LstView_Relatorio);
            this.Controls.Add(this.Btn_GerarRelatorio);
            this.Controls.Add(this.Btn_SalvarPdf);
            this.Controls.Add(this.Btn_GerarFluxoCaixa);
            this.Controls.Add(this.Date_DataMaximaRelatorio);
            this.Controls.Add(this.Label_DataMaximaRelatorio);
            this.Controls.Add(this.Date_DataMinimaRelatorio);
            this.Controls.Add(this.Label_DataMinimaRelatorio);
            this.Name = "FormRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date_DataMaximaRelatorio;
        private System.Windows.Forms.Label Label_DataMaximaRelatorio;
        private System.Windows.Forms.DateTimePicker Date_DataMinimaRelatorio;
        private System.Windows.Forms.Label Label_DataMinimaRelatorio;
        private System.Windows.Forms.Button Btn_GerarRelatorio;
        private System.Windows.Forms.Button Btn_SalvarPdf;
        private System.Windows.Forms.Button Btn_GerarFluxoCaixa;
        private System.Windows.Forms.ListView LstView_Relatorio;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.SaveFileDialog Salvar_Pdf;
        private System.Windows.Forms.Button Btn_GerarItensPedidos;
        private System.Windows.Forms.Button Btn_SalvarXls;
        private System.Windows.Forms.SaveFileDialog Salvar_Xls;
    }
}