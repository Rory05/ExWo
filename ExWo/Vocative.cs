using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exсel_Word
{
    static class Vocative
    {

        static private char[] vowels = { 'а', 'е', 'и', 'і', 'о', 'у', 'я', 'ю', 'є', 'ї' };
        static private char[] soft = {'й', 'ь'};

        // кличний відмінок імен по-батькові
        static public string PatronymVocative(string patronym, bool gender) 
        {
            string vocative = null;
            if (gender)
                vocative = patronym + "у";  // додаємо закінчення "у"
            else vocative = patronym.Substring(0, patronym.Length - 1) + "о"; // змінюємо закінчення на "о"

            return vocative;
        }

        /* У іменах в Кличному відмінку
         1 - змінюємо закінчення на "о"
         2 - змінюємо закінчення на "е"
         3 - змінюємо закінчення на "є"
         4 - змінюємо закінчення на "ю"
         5 - додаємо закінчення "у"
         6 - додаємо закінчення "е"
         7 - додаємо закінчення "е" та змінюємо "і" на "о" (Антін - Антоне)
         */
        static public string NameVocative (string noun, bool gender) // n - номер правила
        {
            int n;
            if (gender) n = MaleNameVocative(noun);
            else n = FemaleNameVocative(noun);

            string vocative = null;
            switch(n)
            {
                case 1: vocative = noun.Substring(0, noun.Length - 1) + "о";
                    break;
                case 2: vocative = noun.Substring(0, noun.Length - 1) + "е";
                    break;
                case 3: vocative = noun.Substring(0, noun.Length - 1) + "є";
                    break;
                case 4: vocative = noun.Substring(0, noun.Length - 1) + "ю";
                    break;
                case 5: vocative = noun + "у";
                    break;
                case 6: vocative = noun + "е";
                    break;
                case 7: vocative = noun.Substring(0, noun.Length - 2) + "о" + noun.Substring(noun.Length - 1, noun.Length) + "е";
                    break;
            }

            return vocative;
        }

        // кличний відмінок чоловічих імен
        static private int MaleNameVocative(string noun) 
        {
            int n = 0;
             
            if(Contain_Letter(noun, noun.Length - 1, vowels)) // якщо ім'я закінчується на голосну
            {
                switch(noun.Substring(noun.Length - 1, 1))
                {
                    case "а": n = 1;      //якщо закінчення "а" змінюємо на "о"
                        break;
                    case "я": n = 2;      //якщо закінчення "я" замінюємо на "е"
                        break;
                    case "о": n = 2;      //якщо закінчення "о" замінюємо на "е"
                        break;
                }
            }
            else
            {
                if (noun.Substring(noun.Length - 1, 1) == "р") n = 6; // якщо ім'я закінчується на "р" додаємо "е"
                else
                {
                    if (Contain_Letter(noun, noun.Length - 1, soft)) n = 4; // якщо ім'я закінчується на м'який ("й" або "ь") заміняємо на "ю"
                    else
                    {
                        if (noun.Substring(noun.Length - 2, 1) == "і") n = 7; // якщо ім'я має передостанню літеру "і" (Антін, Тиміш, Нестір)
                        else n = 5;       // для вісх інших, якщо ім'я має нульове закінчення
                    }
                }
            }

            return n;
        }

        // кличний відмінок жіночих імен
        static private int FemaleNameVocative(string noun) 
        {
            int n = 0;

            if (noun.Substring(noun.Length - 1, 1) == "а") n = 1; //якщо закінчення "а" заміняємо на "о"
            else
            {
                if (noun.Substring(noun.Length - 1, 1) == "я") //якщо закінчення "я" 
                {
                    if (!Contain_Letter(noun, noun.Length - 2, vowels))
                        n = 2;              // заміняємо на "е"
                    else n = 3;             // заміняємо на "є" // Дар'я - Дар'є
                }
                else
                {
                    if (!Contain_Letter(noun, noun.Length - 1, vowels)) //якщо нульове закінчення
                        n = 6;              // додаємо "е"
                }
            }

            return n;
        }

        //перевірка, чи містить масив літеру
        static private bool Contain_Letter(string noun, int position, char [] letters)
        {
            
            for(int i=0; i<letters.Length; i++)
            {
                if(noun[position] == letters[i])
                {
                    return true;
                }    
            }
            return false;
        }
    }
}
