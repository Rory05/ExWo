using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Exсel_Word
{
    public class File
    {
        protected string filePath, folderPath, examplePath;
        protected string[] titles, values;

        protected Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
        protected Workbook book;
        protected _Worksheet sheet;
        protected Microsoft.Office.Interop.Excel.Range range;

        protected Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
        protected Microsoft.Office.Interop.Word.Document example;

        public File(string filePath, string folderPath, string examplePath) 
        {
            this.filePath = filePath;
            this.folderPath = folderPath;
            this.examplePath = examplePath;

        }

        public bool All()
        {
            OpenFiles();
            FindValues();
            CloseFiles();

            return true;
        }

        protected bool OpenFiles()
        {
            if (filePath != null && examplePath != null)
            {
                if (excelApp == null)
                {
                    return false;
                }

                book = excelApp.Workbooks.Add(filePath);
                sheet = book.Sheets[1];
                range = sheet.UsedRange;


                return true;
            }

            return false;
        }

        protected void CloseFiles()
        {
            
            example.Close();
            wordApp.Quit();

            book.Close();
            excelApp.Quit();

        }

        protected virtual void FindValues ()
        {
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            titles = new string[colCount];
            values = new string[colCount];
            //назва колонок
            for (int i = 0; i < colCount; i++)
            {
                titles[i] = range.Cells[1, i + 1].Value;
            }

            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (range.Cells[i, j].Value != null)
                        values[j - 1] = range.Cells[i, j].Value.ToString();
                }

                CreateNewFiles(titles, values);

            }

        }

        protected virtual void CreateNewFiles(string[] titles, string[] values)
        {
            example = new Document();
            example = wordApp.Documents.Add($"{examplePath}");

            int i;
            foreach (Field field in example.Fields)
            {
                i = 0;
                foreach (string title in titles)
                {
                    if (title != null && field.Code.Text.Contains(title))
                    {
                        field.Select();
                        wordApp.Selection.TypeText(values[i]);
                        break;
                    }
                    else { i++; }
                }

            }

            i = 0;
            foreach (string title in titles)
            {
                if (title != null && title.Equals("ПІБ"))
                    example.SaveAs(FileName: $"{folderPath}\\{values[i]}.doc");
                else { i++; }
            }
            
        }



    }
}
