﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Edc.Domain.Models;
using Document = Edc.Domain.Models.Document;
using Font = iTextSharp.text.Font;
using Section = Edc.Domain.Models.Section;

namespace Edc.Domain
{
    public static class PdfDocumentGenerator
    {
      
        public static MemoryStream GenerateComplexDocument(Document documentToBeGenerated)
        {
            using (var ms = new MemoryStream())
            {
                var doc = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                doc.Open();
                var path = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
                string arialuniTff = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
                FontFactory.Register(arialuniTff);

                var bfR = BaseFont.CreateFont(arialuniTff, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                var times = new Font(bfR, 12, Font.NORMAL, BaseColor.BLACK);
                doc.AddTitle(documentToBeGenerated.Title);
                doc.Add(new Paragraph(documentToBeGenerated.Title, times));
                doc.Add(new Paragraph(documentToBeGenerated.Author.ToString(), times));

                doc.Add(new Paragraph("Ключови думи: " + String.Join(", ", documentToBeGenerated.GetDocumentTopKeywords().Select(k => k.Name)), times));
                
                var sectionIndex = 1;
                foreach (var section in documentToBeGenerated.Sections)
                {
                    doc.NewPage();
                    doc.Add(new Paragraph("" + sectionIndex + ". " + section.Title, times));

                    var subsections = section.Subsections.Where(s => s.Content != null).ToList();
                    var subSectionIndex = 1;
                    foreach (var subsection in subsections)
                    {
                        doc.Add(new Paragraph("" + sectionIndex + "." +subSectionIndex +". " + subsection.Title, times));
                        subSectionIndex++;
                        doc.Add(new Paragraph(subsection.Content.MainText, times));
                    }

                    sectionIndex++;
                }
                doc.Close();
                
                return ms;
            }
        }

        public static MemoryStream GenerateSimpleDocument(SectionContent sectionToBeGenerated)
        {
            using (var ms = new MemoryStream())
            {
                var doc = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                doc.Open();
                var path = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
                string arialuniTff = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
                FontFactory.Register(arialuniTff);

                var bfR = BaseFont.CreateFont(arialuniTff, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                doc.AddTitle(sectionToBeGenerated.Title);
                var times = new Font(bfR, 12, Font.NORMAL, BaseColor.BLACK);
         
                doc.Add(new Paragraph(sectionToBeGenerated.Title, times));
                doc.Add(new LineSeparator());
                doc.Add(new Paragraph(sectionToBeGenerated.MainText, times));
                 
                doc.Close();

                return ms;
            }
        }
    }
}

