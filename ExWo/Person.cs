using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exсel_Word
{
    public class Person
    {
        private string name, surname, patronym;

        const string male_end = "ич";
        const string female_end = "на";
        public Person (string full_name)
        {
            try
            {
                string[] splited = full_name.Split();

                Surname = splited[0];
                Name = splited[1];
                Patronym = splited[2];
            }
            catch
            {
                MessageBox.Show("Помилка у ПІБ депутата.", "Попередження!", MessageBoxButtons.OK,
                         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronym
        {
            get { return patronym; }
            set { patronym = value; }
        }

        public bool IsMen ()
        {
            if(patronym.Contains(male_end))
                return true;
            else
            {
                if (patronym.Contains(female_end))
                    return false;
            }
                return true;

        }

        

    }
}
