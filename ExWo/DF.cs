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
    public class DF: File
    {
        protected string[,] val;
        private DeputyFile deputy;

        public DF(string filePath, string folderPath, string examplePath, string deputyFilePath) :
            base(filePath, folderPath, examplePath) { deputy = new DeputyFile(deputyFilePath); }
        
        
        protected override void FindValues()
        {
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            titles = new string[colCount+1];
            values = new string[colCount+1];
            val = new string[colCount, rowCount];

            //отримуємо назви колонок
            for (int i = 0; i < colCount - 1; i++)
            {
                titles[i] = range.Cells[1, i + 1].Value;
            }
            //заповнюємо масив інформацією з таблиці
            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (range.Cells[i, j].Value != null)
                        val[j - 1, i - 2] = range.Cells[i, j].Value.ToString();
                }

            }
            //знаходимо номер колонки з назвою ПІБ 
            int p=0, k=0;
            foreach(string titlel in titles)
            {
                if(titlel.Equals("ПІБ"))
                {
                    break;
                }
                else { p++; }
            }
            //знаходимо номер колонки з назвою Категорія
            foreach (string title in titles)
            {
                if (title!= null && title.Equals("КАТЕГОРІЯ"))
                {
                    break;
                }
                else { k++; }
            }

            //формуємо список депутатів для однієї людини у форматі "Депутат1, Депутат2,..."
            RefreshArray(rowCount, colCount, p, k);


        }

        protected virtual void RefreshArray(int rowCount, int colCount, int p, int k)// p - колонка ПІБ, k - колонка Категорія 
        {
            int[] depCount = new int[rowCount];

            //створення списку всіх депутатів, що надають допомогу одному громадянину
            
            for (int i = 0; i < rowCount; i++)
            {
                depCount[i] = 1;
                if (val[k, i] != null)
                    val[k, i] = deputy.DFGenitive(val[k, i]);
                for (int j = 0; j < rowCount; j++)
                {
                    if (i != j && val[p, i] != null && val[p, i] == val[p, j])
                    {
                        depCount[i]++;
                        val[k, i] += ", " + deputy.DFGenitive(val[k, j]);
                        for (int n = 0; n < colCount; n++)
                            val[n, j] = null;
                    }
                }
            }
            titles[titles.Length-1] = "Закінчення";
            
            //створюємо файли
            for (int i = 0; i < rowCount; i++)
            {
                if (val[1, i] != null)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        values[j] = val[j, i];
                    }
                    if (depCount[i] == 1)
                    {
                        values[colCount] = "а";
                        values[k] = " " + values[k];
                    }
                    else
                    {
                        values[colCount] = "ів";
                        values[k] = ": " + values[k];
                    }
                        CreateNewFiles(titles, values);
                }
            }
        }

        protected override void CreateNewFiles( string[] titles, string[] values)
        { base.CreateNewFiles(titles, values); }
    }
}
