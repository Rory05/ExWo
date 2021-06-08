using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Exсel_Word
{
    public class DeputyFile
    {
        protected string[,] val;
        protected string[] titles;
        protected string deputyFilePath;
        private int d;
        int rowCount, colCount;
        Person person;


        protected Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
        protected Workbook book;
        protected _Worksheet sheet;
        protected Microsoft.Office.Interop.Excel.Range range;

        public DeputyFile(string deputyFilePath) 
        {
            this.deputyFilePath = deputyFilePath;
            ReadFile(); 
        }

        public Person CreatePerson (string cell)
        {
            string fullName = null;
            string[] partCell = cell.Split();
            for(int i=0; i<rowCount; i++)
            {
                if(val[d,i]!= null && val[d,i].Contains(partCell[0]))
                {
                    fullName = val[d, i];
                }
            }

            person = new Person(fullName);
            return person;
        }

        public string FieldDative()
        {
            string dative = person.Name.Substring(0, 1) + ". ";

            int dat = 0;
            //знаходимо номер колонки з назвою Давальний
            foreach (string titlel in titles)
            {
                if (titlel.Equals("ДАВАЛЬНИЙ"))
                {
                    break;
                }
                else { dat++; }
            }
            for(int i=0; i<rowCount; i++)
            {
                if(val[d,i].Contains(person.Surname))
                {
                    dative += val[dat, i];
                    break;
                }
            }

            return dative;
        }

        public string FieldGender()
        {
            if (person.IsMen())
                return "ий";
            else return "а";
        }

        public string FieldVocative()
        {
            return Vocative.NameVocative(person.Name, person.IsMen())+ " " + Vocative.PatronymVocative(person.Patronym, person.IsMen());
        }

        public string FieldEnd(int count, string[,] people, int p)
        {
            if(count > 1)
            {
                return "ям";
            }
            else
            {
                Person human = new Person(people[p, 0]);
                if (human.IsMen())
                    return "ю";
                else return "і";
            }
        }

        
        public string FileName()
        {
            return person.Surname;
        }


        public string DFGenitive(string name)
        {
            string[] split = name.Split();
            string genitive = null;

            int gen = 0;
            //знаходимо номер колонки з назвою Давальний
            foreach (string titlel in titles)
            {
                if (titlel.Equals("РОДОВИЙ"))
                {
                    break;
                }
                else { gen++; }
            }
            for (int i = 0; i < rowCount; i++)
            {
                if (val[d, i] != null && val[d, i].Contains(split[0]))
                {
                    genitive = val[gen, i] + " " + split[1];
                    break;
                }
            }

            return genitive;
        }

        
        private void ReadFile()
        {
            book = excelApp.Workbooks.Add(deputyFilePath);
            sheet = book.Sheets[1];
            range = sheet.UsedRange;


            rowCount = range.Rows.Count;
            colCount = range.Columns.Count;

            titles = new string[colCount];
            val = new string[colCount, rowCount];

            //отримуємо назви колонок
            try
            {
                for (int i = 0; i < colCount; i++)
                {
                    titles[i] = range.Cells[1, i + 1].Value;
                }
            }
            catch {
                book.Close();
                excelApp.Quit();
                MessageBox.Show("Вихід за межі масиву.", "Помилка!", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            //заповнюємо масив інформацією з таблиці
            try
            {
                for (int i = 2; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        if (range.Cells[i, j].Value != null)
                            val[j - 1, i - 2] = range.Cells[i, j].Value.ToString();
                    }

                }
            }
            catch
            {
                book.Close();
                excelApp.Quit();
                MessageBox.Show("Вихід за межі масиву.", "Помилка!", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            //знаходимо номер колонки з назвою ПІБ 
            d = 0;
            foreach (string titel in titles)
            {
                if (titel.Equals("ПІБ"))
                {
                    break;
                }
                else { d++; }
            }


            book.Close();
            excelApp.Quit();
        }

    }
}
