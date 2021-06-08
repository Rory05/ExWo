using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Exсel_Word
{
    class Deputy: DF
    {
        private DeputyFile deputy;
        public Deputy(string filePath, string folderPath, string examplePath, string deputyFilePath) : 
            base(filePath, folderPath, examplePath, deputyFilePath) { deputy = new DeputyFile(deputyFilePath); }

        protected override void RefreshArray(int rowCount, int colCount, int p, int k)
        {

            int depCount;
            string[,] people;
            string deputy;

            try
            {
                for (int i = 0; i < rowCount; i++)
                {
                    depCount = 0;
                    foreach (string value in val)
                    {
                        if (value != null && value == val[k, i])
                            depCount++;
                    }
                    deputy = val[k, i];
                    people = new string[colCount, depCount];
                    if (depCount != 0)
                    {

                        for (int j = 0, d = 0; d < depCount; j++)
                        {
                            if (deputy == val[k, j])
                            {
                                for (int l = 0; l < colCount; l++)
                                {
                                    people[l, d] = val[l, j];
                                    val[l, j] = null;
                                }
                                d++;

                            }
                        }

                        CreateNewFiles(titles, people, p, k, depCount);
                    }

                }
            }
            catch
            {
                CloseFiles();
                MessageBox.Show("Вихід за межі масиву.", "Помилка!", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }


        }


        protected void CreateNewFiles(string[] titles, string[,] people, int p, int k, int count)
        {
            example = new Document();
            example = wordApp.Documents.Add($"{examplePath}");


            deputy.CreatePerson(people[k, 0]);

            string set_text;
            try
            {
                foreach (Field field in example.Fields)
                {
                    if (field.Code.Text.Contains("Давальний"))
                    {
                        field.Select();
                        set_text = deputy.FieldDative().ToUpper();
                        wordApp.Selection.TypeText(set_text);
                    }

                }
                foreach (Field field in example.Fields)
                {
                    if (field.Code.Text.Contains("Рід"))
                    {
                        field.Select();
                        set_text = deputy.FieldGender();
                        wordApp.Selection.TypeText(set_text);
                    }

                }
                foreach (Field field in example.Fields)
                {
                    if (field.Code.Text.Contains("Кличний"))
                    {
                        field.Select();
                        set_text = deputy.FieldVocative();
                        wordApp.Selection.TypeText(set_text);
                    }
                }
                foreach (Field field in example.Fields)
                {
                    if (field.Code.Text.Contains("Закінчення"))
                    {
                        field.Select();
                        set_text = deputy.FieldEnd(count, people, p);
                        wordApp.Selection.TypeText(set_text);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Поле не знайдено! \n Перевірте правильність прикладу!", "Помилка!", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            Object defaultTableBehavior = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow;
            //Добавляем таблицу и получаем объект wordtable 
            Microsoft.Office.Interop.Word.Table wordtable = example.Tables.Add(this.example.Paragraphs[31].Range, count+1, 3, ref defaultTableBehavior, ref autoFitBehavior);

            Object style = "Сетка таблицы 1";
            wordtable.set_Style(ref style);
            wordtable.Rows.SetHeight(20, Microsoft.Office.Interop.Word.WdRowHeightRule.wdRowHeightAuto);
            wordtable.Rows.HorizontalPosition = 10;
            
            wordtable.Columns[1].SetWidth( 220 , Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone);
            wordtable.Columns[2].SetWidth( 195, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone);
            wordtable.Columns[3].SetWidth( 60, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone);

            for (int m = 0; m < count; m++)
            {
                for (int n = 0; n < wordtable.Columns.Count; n++)
                {
                    wordtable.Cell(m + 1, n + 1).Range.Text = people[n, m].ToString();

                    if (n+1==wordtable.Columns.Count)
                        wordtable.Cell(m + 1, n + 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                    
                }
                wordtable.Rows[m + 1].Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalBottom;
            }
                
            wordtable.Cell(wordtable.Rows.Count, 1).Range.Text = "Разом";
            wordtable.Cell(wordtable.Rows.Count, 1).Range.Font.Bold = 20;
            wordtable.Cell(wordtable.Rows.Count, 3).Range.Text = Sum(people,titles);
            wordtable.Cell(wordtable.Rows.Count, 3).Range.Font.Bold = 20;
            wordtable.Cell(wordtable.Rows.Count, 3).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            wordtable.Rows[count+1].Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalBottom;

            example.SaveAs(FileName: $"{folderPath}\\{deputy.FileName()}.doc");

        }

        public string Sum(string[,] people, string[] titles)
        {
            int s = 0;
            foreach (string titel in titles)
            {
                if (titel.Equals("СУМА"))
                {
                    break;
                }
                else { s++; }
            }
            int sum = 0;
            for (int i = 0; i < people.GetLength(1); i++)
            {
                sum += Int32.Parse(people[s, i]);
            }
            return sum.ToString();
        }
    }
}
