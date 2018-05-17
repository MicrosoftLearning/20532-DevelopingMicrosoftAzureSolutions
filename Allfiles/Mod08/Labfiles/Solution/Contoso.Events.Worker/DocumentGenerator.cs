using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.IO;

namespace Contoso.Events.Worker
{
    public class SignInDocumentGenerator : DocumentGenerator
    {
        public MemoryStream CreateSignInDocument(string eventTitle, IEnumerable<string> names)
        {
            MemoryStream stream = new MemoryStream();
            base.CreateDocument(stream, eventTitle, names);
            return stream;
        }
    }

    public abstract class DocumentGenerator
    {
        protected void CreateDocument(Stream stream, string eventName, IEnumerable<string> names)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document, true))
            {
                MainDocumentPart mainDocumentPart = doc.AddMainDocumentPart();

                mainDocumentPart.Document = new Document(
                    new Body()
                );

                mainDocumentPart.Document.Body.Append(
                    CreateHeaderParagraph(eventName)
                );

                Table table = CreateTable(names);

                mainDocumentPart.Document.Body.Append(table);

                mainDocumentPart.Document.Save();
            }
        }

        private Table CreateTable(IEnumerable<string> names)
        {
            Table table = new Table(
                new TableProperties(
                    new TableWidth()
                    {
                        Width = "5000",
                        Type = TableWidthUnitValues.Pct
                    }
                )
            );

            foreach (var name in names)
            {
                table.Append(
                    CreateTableRow(name)
                );
            }
            return table;
        }

        private TableRow CreateTableRow(string name)
        {
            return new TableRow(
                new TableCell(
                    new TableCellProperties(
                        new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Bottom },
                        new TableCellWidth() { Type = TableWidthUnitValues.Pct, Width = "1000" }
                    ),
                    new Paragraph(
                        new ParagraphProperties(
                            new SpacingBetweenLines() { After = "0" }
                        ),
                        new Run(
                            new RunProperties(
                                new FontSize()
                                {
                                    Val = new StringValue("18")
                                }
                            ),
                            new Text(name)
                        )
                    )
                ),
                new TableCell(
                    new TableCellProperties(
                        new TableCellWidth() { Type = TableWidthUnitValues.Pct, Width = "4000" },
                        new TableCellBorders() { BottomBorder = new BottomBorder { Val = BorderValues.Single, Size = 2 } }
                    ),
                    new Paragraph(
                        new Run()
                    )
                )
            );
        }

        private Paragraph CreateHeaderParagraph(string eventName)
        {
            return new Paragraph(
                new ParagraphProperties(
                    new Justification()
                    {
                        Val = JustificationValues.Center
                    }
                ),
                new Run(
                    new RunProperties(
                        new RunFonts()
                        {
                            Ascii = "Calibri Light"
                        },
                        new FontSize()
                        {
                            Val = new StringValue("48")
                        }
                    ),
                    new Text(eventName),
                    new CarriageReturn()
                )
            );
        }
    }
}