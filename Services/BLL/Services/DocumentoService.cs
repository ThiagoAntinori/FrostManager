using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public class DocumentoService
    {
        public static void DescargarPdf<T>(string titulo, List<T> datos, string pathDescarga, Dictionary<string, string> mapeoNombres, List<string> propiedadesMoneda) where T : class
        {
            iText.Kernel.Colors.Color colorFondoHeader = new iText.Kernel.Colors.DeviceRgb(51, 153, 102);

            iText.Layout.Style estiloHeader = new iText.Layout.Style()
                .SetBackgroundColor(colorFondoHeader)
                .SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE)
                .SetFontSize(8);

            iText.Layout.Style estiloBody = new iText.Layout.Style()
                .SetFontColor(iText.Kernel.Colors.ColorConstants.BLACK)
                .SetFontSize(8);

            var culture = new CultureInfo("es-AR");

            PdfWriter writer = null;
            PdfDocument pdfDocument = null;
            Document document = null;

            try
            {
                writer = new PdfWriter(pathDescarga);
                pdfDocument = new PdfDocument(writer);
                document = new Document(pdfDocument, iText.Kernel.Geom.PageSize.A4);
                document.SetMargins(10, 10, 10, 10);

                document.Add(new Paragraph(titulo)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12));
                document.Add(new Paragraph("\n"));

                var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                int numColumns = properties.Length;
                Table table = new Table(numColumns);
                table.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (var prop in properties)
                {
                    string nombreColumna = mapeoNombres.TryGetValue(prop.Name, out string nombreEstetico) ? nombreEstetico : prop.Name;

                    Cell cell = new Cell()
                        .Add(new Paragraph(nombreColumna))
                        .AddStyle(estiloHeader)
                        .SetTextAlignment(TextAlignment.CENTER);

                    table.AddHeaderCell(cell);
                }

                foreach (var item in datos)
                {
                    foreach (var prop in properties)
                    {
                        object value = prop.GetValue(item, null);
                        string valorCelda;
                        TextAlignment alignment = new TextAlignment();

                        if (propiedadesMoneda.Contains(prop.Name) && (value is decimal || value is float || value is double))
                        {
                            valorCelda = string.Format(culture, "{0:C2}", value);
                        }
                        else
                        {
                            valorCelda = value?.ToString() ?? string.Empty;
                            alignment = TextAlignment.LEFT;
                        }

                        Cell pdfCell = new Cell()
                            .Add(new Paragraph(valorCelda))
                            .AddStyle(estiloBody)
                            .SetTextAlignment(alignment);

                        table.AddCell(pdfCell);
                    }
                }

                document.Add(table);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
            finally
            {
                if (document != null) document.Close();
                if (pdfDocument != null) pdfDocument.Close();
                if (writer != null) writer.Close();
            }
        }
    }
}
