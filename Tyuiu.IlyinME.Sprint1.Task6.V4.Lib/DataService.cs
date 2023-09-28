using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IlyinME.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string[] a = value.Split(' ');
            List<string> wordsWithDoubleN = new List<string>();

            foreach (string word in a)
            {
                if (word.Contains("нн"))
                {
                    wordsWithDoubleN.Add(word);
                }
            }
            string result = string.Join(" ", wordsWithDoubleN);
            string b = result.Replace(",", "");
            string c = b.Replace(" ", ", ");
            return c;

        }
    }
}







