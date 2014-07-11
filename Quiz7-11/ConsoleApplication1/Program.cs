using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        class Return
        {

            public static string Reverser(string x)
            {

                string[] words = x.Split(' ');
                Array.Reverse(words);
                return string.Join(" ", words);
            }
        }

        static void Main(string[] args)
        {
            string s = "there is a cat";
            Console.WriteLine(Return.Reverser(s));
            Console.ReadLine();

        }
    }
}
