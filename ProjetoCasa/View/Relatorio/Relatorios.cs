using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using NHibernate.Mapping;
using ProjetoCasa.Controller;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProjetoCasa.View.Relatorio
{
    public partial class FormRelatorio : Form
    {
        private double pagamento = 0;
        private double despesa = 0;
        private double saldo = 0;
        public FormRelatorio()
        {
            InitializeComponent();
        }
        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_GerarFluxoCaixa_Click(object sender, EventArgs e)
        {
            string dataMinima = Date_DataMinimaRelatorio.Value.ToString();
            string dataMaxima = Date_DataMaximaRelatorio.Value.ToString();
            if (Convert.ToDateTime(dataMaxima) < Convert.ToDateTime(dataMinima))
            {
                MessageBox.Show("A Data Máxima não pode ser menor que a Data Mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GerarFluxoCaixa(Convert.ToDateTime(Date_DataMinimaRelatorio.Value), Convert.ToDateTime(Date_DataMaximaRelatorio.Value));
        }

        private void Btn_GerarRelatorio_Click(object sender, EventArgs e)
        {
            string dataMinima = Date_DataMinimaRelatorio.Value.ToString();
            string dataMaxima = Date_DataMaximaRelatorio.Value.ToString();
            if (Convert.ToDateTime(dataMaxima) < Convert.ToDateTime(dataMinima))
            {
                MessageBox.Show("A Data Máxima não pode ser menor que a Data Mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GerarRelatorio(Convert.ToDateTime(Date_DataMinimaRelatorio.Value), Convert.ToDateTime(Date_DataMaximaRelatorio.Value));
        }
        private void Btn_GerarItensPedidos_Click(object sender, EventArgs e)
        {
            string dataMinima = Date_DataMinimaRelatorio.Value.ToString();
            string dataMaxima = Date_DataMaximaRelatorio.Value.ToString();
            if (Convert.ToDateTime(dataMaxima) < Convert.ToDateTime(dataMinima))
            {
                MessageBox.Show("A Data Máxima não pode ser menor que a Data Mínima!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GerarItensPedido(Convert.ToDateTime(Date_DataMinimaRelatorio.Value), Convert.ToDateTime(Date_DataMaximaRelatorio.Value));
        }

        private void Btn_SalvarPdf_Click(object sender, EventArgs e)
        {
            if (LstView_Relatorio.Items.Count == 0)
            {
                MessageBox.Show("Necessário gerar dados para salvar em PDF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LstView_Relatorio.Columns.Count == 2)
            {
                if (LstView_Relatorio.Columns[0].Text == "Produto")
                {
                    if (!GerarPdf_ItensVendidos())
                        return;
                }
                else if (LstView_Relatorio.Columns[0].Text == "Controle")
                {
                    if (!GerarPdf_Relatorio())
                        return;
                }
            }

            else if (LstView_Relatorio.Columns.Count == 3)
            {
                if (!GerarPdf_FluxoCaixa())
                    return;
            }
        }

        private void Btn_SalvarXls_Click(object sender, EventArgs e)
        {
            if (LstView_Relatorio.Items.Count == 0)
            {
                MessageBox.Show("Necessário gerar dados para salvar em XLS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LstView_Relatorio.Columns.Count == 2)
            {
                if (LstView_Relatorio.Columns[0].Text == "Produto")
                {
                    if (!GerarXls_ItensVendidos())
                        return;
                }
                else if (LstView_Relatorio.Columns[0].Text == "Controle")
                {
                    if (!GerarXls_Relatorio())
                        return;
                }
            }

            else if (LstView_Relatorio.Columns.Count == 3)
            {
                if (!GerarXls_FluxoCaixa())
                    return;
            }
        }

        private bool GerarXls_ItensVendidos()
        {
            Salvar_Xls.Title = "Salvar Itens Vendidos";
            Salvar_Xls.Filter = "XLS file (*.xlsx)|*.xlsx";
            Salvar_Xls.FileName = "Itens Vendidos - " + Date_DataMaximaRelatorio.Value.ToString("MM-yyyy");
            Salvar_Xls.DefaultExt = ".xlsx";
            Salvar_Xls.InitialDirectory = @"C:\";
            Salvar_Xls.RestoreDirectory = true;
            DialogResult resultado = Salvar_Xls.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel não está instalado!");
                    return false;
                }
                string caminho = Salvar_Xls.FileName;

                try
                {
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

                    int row = 1;
                    
                    xlWorksheet.Cells[row, 1] = "Produtos";
                    xlWorksheet.Cells[row, 2] = "Quantidade";

                    xlWorksheet.get_Range("A1", "B1").Font.Bold = true;
                    xlWorksheet.get_Range("A1", "B1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                    {
                        row++;
                        int col = 1;
                        xlWorksheet.Cells[row, col] = LstView_Relatorio.Items[i].SubItems[0].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Relatorio.Items[i].SubItems[1].Text;
                        xlWorksheet.get_Range("A" + row, "B" + row).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    }

                    xlWorkbook.SaveAs(Salvar_Xls.FileName, XlFileFormat.xlOpenXMLWorkbook);
                    xlWorkbook.Close();

                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_Xls.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private bool GerarXls_Relatorio()
        {
            Salvar_Xls.Title = "Salvar Relatório";
            Salvar_Xls.Filter = "XLS file (*.xlsx)|*.xlsx";
            Salvar_Xls.FileName = "Relatório - " + Date_DataMaximaRelatorio.Value.ToString("MM-yyyy");
            Salvar_Xls.DefaultExt = ".xlsx";
            Salvar_Xls.InitialDirectory = @"C:\";
            Salvar_Xls.RestoreDirectory = true;
            DialogResult resultado = Salvar_Xls.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel não está instalado!");
                    return false;
                }
                string caminho = Salvar_Xls.FileName;

                try
                {
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

                    int row = 1;
                    xlWorksheet.Cells[row, 1] = "Controle";
                    xlWorksheet.Cells[row, 2] = "Total";

                    xlWorksheet.get_Range("A1", "B1").Font.Bold = true;
                    xlWorksheet.get_Range("A1", "B1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                    {
                        row++;
                        int col = 1;
                        xlWorksheet.Cells[row, col] = LstView_Relatorio.Items[i].SubItems[0].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Relatorio.Items[i].SubItems[1].Text;
                        xlWorksheet.get_Range("A" + row, "B" + row).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    }

                    xlWorkbook.SaveAs(Salvar_Xls.FileName, XlFileFormat.xlOpenXMLWorkbook);
                    xlWorkbook.Close();

                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_Xls.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    xlApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool GerarXls_FluxoCaixa()
        {
            Salvar_Xls.Title = "Salvar Fluxo de Caixa";
            Salvar_Xls.Filter = "XLS file (*.xlsx)|*.xlsx";
            Salvar_Xls.FileName = "Fluxo de Caixa - " + Date_DataMaximaRelatorio.Value.ToString("MM-yyyy");
            Salvar_Xls.DefaultExt = ".xlsx";
            Salvar_Xls.InitialDirectory = @"C:\";
            Salvar_Xls.RestoreDirectory = true;
            DialogResult resultado = Salvar_Xls.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel não está instalado!");
                    return false;
                }
                string caminho = Salvar_Xls.FileName;

                try
                {
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

                    int row = 1;
                    xlWorksheet.Cells[row, 1] = "Data";
                    xlWorksheet.Cells[row, 2] = "Transação";
                    xlWorksheet.Cells[row, 3] = "Valor";

                    xlWorksheet.get_Range("A1", "C1").Font.Bold = true;
                    xlWorksheet.get_Range("A1", "C1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                    {
                        row++;
                        int col = 1;
                        xlWorksheet.Cells[row, col] = "'" + LstView_Relatorio.Items[i].SubItems[0].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Relatorio.Items[i].SubItems[1].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Relatorio.Items[i].SubItems[2].Text;
                        xlWorksheet.get_Range("A" + row, "C" + row).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                        if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Despesa"))
                        {
                            xlWorksheet.get_Range("A" + row, "C" + row).Interior.Color = 
                                System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Tomato);
                        }
                        else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Pagamento"))
                        {
                            xlWorksheet.get_Range("A" + row, "C" + row).Interior.Color =
                                System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                        }
                        else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Saldo"))
                        {
                            xlWorksheet.get_Range("A" + row, "C" + row).Font.Bold = true;
                        }
                    }

                    xlWorkbook.SaveAs(Salvar_Xls.FileName, XlFileFormat.xlOpenXMLWorkbook);
                    xlWorkbook.Close();

                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_Xls.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    xlApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool GerarPdf_Relatorio()
        {

            Salvar_Pdf.Title = "Salvar Relatório";
            Salvar_Pdf.Filter = "PDF file (*.pdf)|*.pdf";
            Salvar_Pdf.FileName = "Relatório - " + Date_DataMaximaRelatorio.Value.ToString("MM-yyyy");
            Salvar_Pdf.DefaultExt = ".pdf";
            Salvar_Pdf.InitialDirectory = @"C:\";
            Salvar_Pdf.RestoreDirectory = true;
            DialogResult resultado = Salvar_Pdf.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                Document documento = new Document(PageSize.A4);
                documento.SetMargins(40, 40, 40, 80);
                documento.AddCreationDate();
                string caminho = Salvar_Pdf.FileName;

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));
                    documento.Open();

                    iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 22, Convert.ToInt32(FontStyle.Bold));
                    iTextSharp.text.Font fonteSubTitulos = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, Convert.ToInt32(FontStyle.Bold));

                    Paragraph titulo = new Paragraph();
                    Paragraph espacamento = new Paragraph();
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font = fonteTitulo;
                    titulo.Add("Posição " + Date_DataMaximaRelatorio.Value.Month.ToString() + "/" + Date_DataMaximaRelatorio.Value.Year.ToString());
                    espacamento.Add(" ");
                    documento.Add(titulo);
                    documento.Add(espacamento);

                    PdfPTable tabela = new PdfPTable(2);
                    Paragraph coluna1 = new Paragraph("Controle");
                    Paragraph coluna2 = new Paragraph("Total");

                    coluna1.Alignment = Element.ALIGN_CENTER;
                    coluna2.Alignment = Element.ALIGN_CENTER;

                    coluna1.Font = fonteSubTitulos;
                    coluna2.Font = fonteSubTitulos;

                    var cel1 = new PdfPCell();
                    var cel2 = new PdfPCell();

                    cel1.AddElement(coluna1);
                    cel2.AddElement(coluna2);

                    tabela.AddCell(cel1);
                    tabela.AddCell(cel2);

                    for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                    {
                        tabela.AddCell(LstView_Relatorio.Items[i].SubItems[0].Text);
                        tabela.AddCell(LstView_Relatorio.Items[i].SubItems[1].Text);
                    }

                    documento.Add(tabela);
                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_Pdf.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    documento.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool GerarPdf_ItensVendidos()
        {

            Salvar_Pdf.Title = "Salvar Itens Vendidos";
            Salvar_Pdf.Filter = "PDF file (*.pdf)|*.pdf";
            Salvar_Pdf.FileName = "Itens Vendidos - " + Date_DataMaximaRelatorio.Value.ToString("MM-yyyy");
            Salvar_Pdf.DefaultExt = ".pdf";
            Salvar_Pdf.InitialDirectory = @"C:\";
            Salvar_Pdf.RestoreDirectory = true;
            DialogResult resultado = Salvar_Pdf.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                Document documento = new Document(PageSize.A4);
                documento.SetMargins(40, 40, 40, 80);
                documento.AddCreationDate();
                string caminho = Salvar_Pdf.FileName;

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));
                    documento.Open();

                    iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 22, Convert.ToInt32(FontStyle.Bold));
                    iTextSharp.text.Font fonteSubTitulos = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, Convert.ToInt32(FontStyle.Bold));

                    Paragraph titulo = new Paragraph();
                    Paragraph espacamento = new Paragraph();
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font = fonteTitulo;
                    titulo.Add("Itens Vendidos");
                    espacamento.Add(" ");
                    documento.Add(titulo);
                    documento.Add(espacamento);

                    PdfPTable tabela = new PdfPTable(2);
                    Paragraph coluna1 = new Paragraph("Produtos");
                    Paragraph coluna2 = new Paragraph("Quantidade");

                    coluna1.Alignment = Element.ALIGN_CENTER;
                    coluna2.Alignment = Element.ALIGN_CENTER;

                    coluna1.Font = fonteSubTitulos;
                    coluna2.Font = fonteSubTitulos;

                    var cel1 = new PdfPCell();
                    var cel2 = new PdfPCell();

                    cel1.AddElement(coluna1);
                    cel2.AddElement(coluna2);

                    tabela.AddCell(cel1);
                    tabela.AddCell(cel2);

                    for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                    {
                        tabela.AddCell(LstView_Relatorio.Items[i].SubItems[0].Text);
                        tabela.AddCell(LstView_Relatorio.Items[i].SubItems[1].Text);                        
                    }

                    documento.Add(tabela);
                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_Pdf.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    documento.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool GerarPdf_FluxoCaixa()
        {

            Salvar_Pdf.Title = "Salvar Fluxo de Caixa";
            Salvar_Pdf.Filter = "PDF file (*.pdf)|*.pdf";
            Salvar_Pdf.FileName = "Fluxo de Caixa - " + Date_DataMaximaRelatorio.Value.ToString("MM-yyyy");
            Salvar_Pdf.DefaultExt = ".pdf";
            Salvar_Pdf.InitialDirectory = @"C:\";
            Salvar_Pdf.RestoreDirectory = true;
            DialogResult resultado = Salvar_Pdf.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                Document documento = new Document(PageSize.A4);
                documento.SetMargins(40, 40, 40, 80);
                documento.AddCreationDate();
                string caminho = Salvar_Pdf.FileName;

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));
                    documento.Open();

                    iTextSharp.text.Font fonteTitulo = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 22, Convert.ToInt32(FontStyle.Bold));
                    iTextSharp.text.Font fonteSubTitulos = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, Convert.ToInt32(FontStyle.Bold));
                    iTextSharp.text.Font fonteSaldo = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, Convert.ToInt32(FontStyle.Bold));

                    Paragraph titulo = new Paragraph();
                    Paragraph espacamento = new Paragraph();
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font = fonteTitulo;
                    titulo.Add("Fluxo de Caixa");
                    espacamento.Add(" ");
                    documento.Add(titulo);
                    documento.Add(espacamento);

                    PdfPTable tabela = new PdfPTable(3);
                    Paragraph coluna1 = new Paragraph("Data");
                    Paragraph coluna2 = new Paragraph("Transação");
                    Paragraph coluna3 = new Paragraph("Valor");

                    coluna1.Alignment = Element.ALIGN_CENTER;
                    coluna2.Alignment = Element.ALIGN_CENTER;
                    coluna3.Alignment = Element.ALIGN_CENTER;

                    coluna1.Font = fonteSubTitulos;
                    coluna2.Font = fonteSubTitulos;
                    coluna3.Font = fonteSubTitulos;

                    var cel1 = new PdfPCell();
                    var cel2 = new PdfPCell();
                    var cel3 = new PdfPCell();

                    cel1.AddElement(coluna1);
                    cel2.AddElement(coluna2);
                    cel3.AddElement(coluna3);

                    tabela.AddCell(cel1);
                    tabela.AddCell(cel2);
                    tabela.AddCell(cel3);

                    for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                    {
                        if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Despesa"))
                        {
                            Paragraph dataDespesa = new Paragraph(LstView_Relatorio.Items[i].SubItems[0].Text);
                            Paragraph despesa = new Paragraph(LstView_Relatorio.Items[i].SubItems[1].Text);
                            Paragraph valorDespesa = new Paragraph(LstView_Relatorio.Items[i].SubItems[2].Text);

                            var celDataDespesa = new PdfPCell();
                            var celDespesa = new PdfPCell();
                            var celValorDespesa = new PdfPCell();

                            celDataDespesa.AddElement(dataDespesa);
                            celDespesa.AddElement(despesa);
                            celValorDespesa.AddElement(valorDespesa);

                            celDataDespesa.BackgroundColor = BaseColor.RED;
                            celDespesa.BackgroundColor = BaseColor.RED;
                            celValorDespesa.BackgroundColor = BaseColor.RED;

                            tabela.AddCell(celDataDespesa);
                            tabela.AddCell(celDespesa);
                            tabela.AddCell(celValorDespesa);
                        }
                        else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Pagamento"))
                        {
                            Paragraph dataPagamento = new Paragraph(LstView_Relatorio.Items[i].SubItems[0].Text);
                            Paragraph pagamento = new Paragraph(LstView_Relatorio.Items[i].SubItems[1].Text);
                            Paragraph valorPagamento = new Paragraph(LstView_Relatorio.Items[i].SubItems[2].Text);

                            var celDataPagamento = new PdfPCell();
                            var celpagamento = new PdfPCell();
                            var celValorPagamento = new PdfPCell();

                            celDataPagamento.AddElement(dataPagamento);
                            celpagamento.AddElement(pagamento);
                            celValorPagamento.AddElement(valorPagamento);

                            celDataPagamento.BackgroundColor = BaseColor.GREEN;
                            celpagamento.BackgroundColor = BaseColor.GREEN;
                            celValorPagamento.BackgroundColor = BaseColor.GREEN;

                            tabela.AddCell(celDataPagamento);
                            tabela.AddCell(celpagamento);
                            tabela.AddCell(celValorPagamento);
                        }
                        else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Saldo"))
                        {
                            Paragraph dataSaldo = new Paragraph(LstView_Relatorio.Items[i].SubItems[0].Text);
                            Paragraph saldo = new Paragraph(LstView_Relatorio.Items[i].SubItems[1].Text);
                            Paragraph valorSaldo = new Paragraph(LstView_Relatorio.Items[i].SubItems[2].Text);

                            var celDataSaldo = new PdfPCell();
                            var celSaldo = new PdfPCell();
                            var celValorSaldo = new PdfPCell();

                            celDataSaldo.AddElement(dataSaldo);
                            celSaldo.AddElement(saldo);
                            celValorSaldo.AddElement(valorSaldo);

                            tabela.AddCell(celDataSaldo);
                            tabela.AddCell(celSaldo);
                            tabela.AddCell(celValorSaldo);
                        }
                    }

                    documento.Add(tabela);
                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_Pdf.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    documento.Close();
                }
            }
            else 
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void LimparFormLista()
        {
            LstView_Relatorio.Columns.Clear();
            LstView_Relatorio.Items.Clear();
            LstView_Relatorio.FullRowSelect = true;
            pagamento = 0;
            despesa = 0;
            saldo = 0;
        }

        private void GerarFluxoCaixa(DateTime dataMinimaRelatorio, DateTime dataMaximaRelatorio)
        {
            string stringDataMinimaRelatorio = dataMinimaRelatorio.ToString("yyyy-MM-dd");
            string stringDataMaximaRelatorio = dataMaximaRelatorio.ToString("yyyy-MM-dd");            
            PreencherListView_GerarFluxoCaixa(stringDataMinimaRelatorio, stringDataMaximaRelatorio);
            LstView_Relatorio.View = System.Windows.Forms.View.Details;
        }

        private void GerarRelatorio(DateTime dataMinimaRelatorio, DateTime dataMaximaRelatorio)
        {
            string stringDataMinimaRelatorio = dataMinimaRelatorio.ToString("yyyy-MM-dd");
            string stringDataMaximaRelatorio = dataMaximaRelatorio.ToString("yyyy-MM-dd");
            PreencherListView_GerarRelatorio(stringDataMinimaRelatorio, stringDataMaximaRelatorio);
            LstView_Relatorio.View = System.Windows.Forms.View.Details;
        }

        private void GerarItensPedido(DateTime dataMinimaRelatorio, DateTime dataMaximaRelatorio)
        {
            string stringDataMinimaRelatorio = dataMinimaRelatorio.ToString("yyyy-MM-dd");
            string stringDataMaximaRelatorio = dataMaximaRelatorio.ToString("yyyy-MM-dd");
            PreencherListView_ItensPedido(stringDataMinimaRelatorio, stringDataMaximaRelatorio);
            LstView_Relatorio.View = System.Windows.Forms.View.Details;
        }
        private void PreencherColumnHeader_GerarFluxoCaixa()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();

            columnHeader1.Text = "Data";
            columnHeader2.Text = "Transação";
            columnHeader3.Text = "Valor";

            LstView_Relatorio.Columns.Add(columnHeader1);
            LstView_Relatorio.Columns.Add(columnHeader2);
            LstView_Relatorio.Columns.Add(columnHeader3);

            LstView_Relatorio.GridLines = true;
        }

        private void PreencherColumnHeader_GerarRelatorio()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();

            columnHeader1.Text = "Controle";
            columnHeader2.Text = "Total";

            LstView_Relatorio.Columns.Add(columnHeader1);
            LstView_Relatorio.Columns.Add(columnHeader2);

            LstView_Relatorio.GridLines = true;
        }

        private void PreencherColumnHeader_GerarItensPedido()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();

            columnHeader1.Text = "Produto";
            columnHeader2.Text = "Quantidade";

            LstView_Relatorio.Columns.Add(columnHeader1);
            LstView_Relatorio.Columns.Add(columnHeader2);

            LstView_Relatorio.GridLines = true;
        }

        private void PreencherListView_GerarRelatorio(string stringDataMinimaRelatorio, string stringDataMaximaRelatorio)
        {
            LimparFormLista();
            PreencherColumnHeader_GerarRelatorio();
            RelatorioController gerarRelatorio = new RelatorioController();

            int resultadoBusca = gerarRelatorio.ContarPedidos(stringDataMinimaRelatorio, stringDataMaximaRelatorio).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var contarPedidos in gerarRelatorio.ContarPedidos(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    { "Quantidade de pedidos", contarPedidos.quantidadePedido.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                foreach (var contarItensPedidos in gerarRelatorio.ContarItensVendidos(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    { "Quantidade de itens vendidos", contarItensPedidos.quantidadeItensVendidos.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                foreach (var mediaItemCliente in gerarRelatorio.MediaItemCliente(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    { "Média item por cliente", mediaItemCliente.mediaItemPorCliente.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                foreach (var valorTotalVendasRecebidas in gerarRelatorio.ValorTotalVendasRecebidas(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    { "Valor total de vendas realizadas e recebidas com frete", 
                        "R$" + valorTotalVendasRecebidas.valorTotalVendasRecebidas.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                foreach (var valorTotalVendasNaoRecebidas in gerarRelatorio.ValorTotalVendasNaoRecebidas(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    { "Valor total de vendas realizadas e não recebidas",
                        "R$" + valorTotalVendasNaoRecebidas.valorTotalVendasNaoRecebidas.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                foreach (var mediaGastoPorCliente in gerarRelatorio.MediaGastoPorCliente(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    { "Média de gasto por cliente",
                        "R$" + mediaGastoPorCliente.mediaGastoPorCliente.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                foreach (var quantidadePedidosCancelados in gerarRelatorio.QuantidadePedidosCancelados(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    { "Quantidade de pedidos cancelados", quantidadePedidosCancelados.quantidadePedidoCancelados.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                foreach (var totalDespesasPagas in gerarRelatorio.TotalDespesasPagas(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    { "Total de despesas pagas no mês", "R$" + totalDespesasPagas.totalDespesasPagas.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
            }
        }

        private void PreencherListView_ItensPedido(string stringDataMinimaRelatorio, string stringDataMaximaRelatorio)
        {
            LimparFormLista();
            PreencherColumnHeader_GerarItensPedido();
            RelatorioController gerarFluxoCaixa = new RelatorioController();

            int resultadoBusca = gerarFluxoCaixa.GerarItensPedido(stringDataMinimaRelatorio, stringDataMaximaRelatorio).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in gerarFluxoCaixa.GerarItensPedido(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.pedido.produto.descricao, item.pedido.produto.quantidade.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
            }
        }

        private void PreencherListView_GerarFluxoCaixa(string stringDataMinimaRelatorio, string stringDataMaximaRelatorio)
        {
            LimparFormLista();
            PreencherColumnHeader_GerarFluxoCaixa();
            RelatorioController gerarFluxoCaixa = new RelatorioController();

            int resultadoBusca = gerarFluxoCaixa.GerarFluxoCaixa(stringDataMinimaRelatorio, stringDataMaximaRelatorio).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para o período selecionado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in gerarFluxoCaixa.GerarFluxoCaixa(stringDataMinimaRelatorio, stringDataMaximaRelatorio))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.pagamento.dataPagamento.ToString("dd/MM/yyyy"), item.transacao, item.transacao.Contains("Pagamento") ?
                     "R$+" + item.pagamento.valorPago.ToString() : "R$-" + item.pagamento.valorPago.ToString()});
                    LstView_Relatorio.Items.Add(listViewItem);
                }
                for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
                {
                    if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Despesa"))
                        despesa = despesa + double.Parse(LstView_Relatorio.Items[i].SubItems[2].Text.Replace("R$-", "").Replace(",", "."), CultureInfo.InvariantCulture);

                    else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Pagamento"))
                        pagamento = pagamento + double.Parse(LstView_Relatorio.Items[i].SubItems[2].Text.Replace("R$+", "").Replace(",", "."), CultureInfo.InvariantCulture);
                }

                saldo = pagamento - despesa;

                ListViewItem saldoFinal = new ListViewItem(new[]
                { Date_DataMaximaRelatorio.Value.ToString("dd/MM/yyyy"), "Saldo", "R$" + saldo.ToString()});
                LstView_Relatorio.Items.Add(saldoFinal);

                Colorir_FluxoCaixa();
            }
        }
        private void Colorir_FluxoCaixa()
        {
            for (int i = 0; i < LstView_Relatorio.Items.Count; i++)
            {
                if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Despesa"))
                    LstView_Relatorio.Items[i].BackColor = Color.Tomato;

                else if (LstView_Relatorio.Items[i].SubItems[1].Text.Contains("Pagamento"))
                    LstView_Relatorio.Items[i].BackColor = Color.LightGreen;
            }
        }        
    }
}
