using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SMS.WinApp
{
    class UiModel
    {
        public void AddEditColumn(DataGridView dgv)
        {
            DataGridViewImageColumn colName = new DataGridViewImageColumn();
            colName.HeaderText = "Edit";
            colName.Width = 60;
            colName.Image = Properties.Resources.edit;
            dgv.Columns.Add(colName);
        }
        public void AddDeleteColumn(DataGridView dgv)
        {
            DataGridViewImageColumn colName = new DataGridViewImageColumn();
            colName.HeaderText = "Delete";
            colName.Width = 60;
            colName.Image = Properties.Resources.delete;
            dgv.Columns.Add(colName);
        }
        public void ExportToPdf(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.NORMAL);
            //add Header
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(200, 200, 200);
                pdfTable.AddCell(cell);
            }
            //add row 
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveDialog = new SaveFileDialog();
            saveDialog.FileName = filename;
            saveDialog.DefaultExt = ".pdf";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4, 30f, 30f, 50f, 0f);
                    PdfWriter.GetInstance(pdfDocument, stream);
                    pdfDocument.Open();
                    pdfDocument.Add(pdfTable);
                    pdfDocument.Close();
                }
            }
        } //Method export pdf

        public void AddAutoIncrementColumn( DataGridView dgv)
        {
            int value = 0;
            int rowNum = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                value++;
                dgv.Rows[rowNum].Cells[0].Value = value;
                rowNum++;
            }
        } //Method for auto increment column;
    }
}
