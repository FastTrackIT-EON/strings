using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string text1 = "abc".Trim();
            string text2 = "ABC".Trim();

            Console.WriteLine(text1 == text2);
            Console.WriteLine(text1.Equals(text2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(string.Equals(text1, text2, StringComparison.OrdinalIgnoreCase));
            
            string.Format("Hello {0} {1}", "world", 23);

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Hello {0} {1}", "world", 23);
            /*
            string text = "Hello world";
            StringBuilder sb = new StringBuilder("Hello world");
            Regex regex = new Regex("pattern", RegexOptions.Compiled);
            for(int i = 0; i < args.Length; i++)
            {
                regex.IsMatch(sb.ToString());
                sb.Replace("Hello ", "");
                // text = text.Replace("Hello ", "");
            }
            */

            Console.WriteLine(string.Join(",", new int[] { 1, 2, 3, 4 }));

            Console.ReadKey();
        }
    }
}
