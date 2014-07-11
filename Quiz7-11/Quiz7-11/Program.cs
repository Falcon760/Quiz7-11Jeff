using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz7_11
{
    class Program
    {
        class Deck
        {
            enum Suits
            {
                hearts,
                diamonds,
                clubs,
                spades
            }
        }
        class Cards : Deck
        {
           public string name { get; set; }
           public string suit { get; set; }

           static Random r = new Random();
           int[] deck = new int[5] { 1, 2, 3, 4, 5 };
           static public void Shuffle(int[] deck)
           {
               for (int i = deck.Length - 1; i > 0; --i)
               {
                   int k = r.Next(i + 1);
                   int temp = deck[i];
                   deck[i] = deck[k];
                   deck[k] = temp;

               }

           }

        }

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
            Cards cards1 = new Cards();


            Dictionary<int, Cards> list = new Dictionary<int, Cards>()
            {
            {2, new Cards{name="2"}},
            {3, new Cards{name="3"}},
            {4, new Cards{name="4"}},
            {5, new Cards{name="5"}},
            {6, new Cards{name="6"}},
            {7, new Cards{name="7"}},
            {8, new Cards{name="8"}},
            {9, new Cards{name="9"}},
            {10, new Cards{name="10"}},
            {11, new Cards{name="J"}},
            {12, new Cards{name="Q"}},
            {13, new Cards{name="K"}},
            {14, new Cards{name="A"}}
            };
            Random num = new Random();
            int rand = num.Next(1, 52);
            foreach (object x in list)
                Console.WriteLine();





            Console.ReadLine();

            //4
            //string s = "there is a cat";
            //Console.WriteLine(Return.Reverser(s));
            //Console.ReadLine();
            //Q: Reverse and return a string entered by a user.


            // 1 - class vs object - class is your template and the object is what you instantiate
            // 2 - Attribute class - the base class, defines everything about the children
            // 3 - what method is used to instantiate an object - a constructor is used to initialize an object

            // 4-

            /*

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            char[] a = name.ToArray();
            Array.Reverse(a);
            Console.WriteLine(a);
            Console.ReadLine();

            */
            /*
            Console.WriteLine("What is the string?");

            ArrayList myAL = new ArrayList();
            myAL.Add("The Blue");
        
            
          
            Console.WriteLine("The ArrayList initially contains the following values:");
            PrintValues(myAL);

            myAL.Sort();

           
            Console.WriteLine("After sorting:");
            PrintValues(myAL);
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();

            Console.ReadLine();
             * 
             */
              
 



            // 5- deck class, card class, method shuffle
            // 52 cards in a deck
           

        }
    }
}
