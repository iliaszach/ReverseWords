using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = ReverseWords("ab cd fi gh rj");
            Console.WriteLine(a);

        }

        public static string ReverseWords(string str)
        {
            StringBuilder sb = new StringBuilder();
            string[] s = str.Split(' ');
            for (int i = s.Length - 1; i > -1; i--)
            {
                sb.Append(s[i]);
                if (!(sb.Length == str.Length))
                {
                    sb.Append(" ");
                }
            }
            var b = sb.ToString();

            return b;
        }
    }
}
