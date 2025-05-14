using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1405
{
    internal class Program
    {
        //  count the number of consonants in a given string.
        static int ConsonantCount(string str)
        {
            string lowerStr = str.ToLower();
            int count = 0;
            foreach (char c in lowerStr)
            {
                if (!(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') && (c!=' '))
                {
                    count++;
                }
            }
            return(count);
        }

        static bool isLeter(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return true;
            }
            else if (c >= 'A' && c <= 'Z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }








        //Removes errors from string and changes first letter
        static string differentCases(string str)
        {
            List<string> strings = new List<string>();
            foreach (char c in str)
            {
                if (isLeter(c))
                {
                    string lower = c.ToString().ToLower();
                    strings.Add(lower);
                }
                else
                {
                    string a =" ";
                    strings.Add(a);
                }
            }

            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i] == " ")
                {
                    strings[i + 1] = strings[i + 1].ToUpper();
                    strings[i]= "";
                }

            }
            string fynelStr= "";
            foreach (string s in strings)
            {
                fynelStr += s;
            }
            return fynelStr;
        }
        

        static void Main(string[] args)
        {
            
            
            
        }
    }
}
