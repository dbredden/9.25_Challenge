using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFACodeChallenge9._25
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = {"s", "u", "p", "e", "r", "c", "a", "l", "i", "f", "r", "a", "g", "i", "l", "i", "s", "t", "i", "c", "e", "x", "p", "i", "a", "l"
            , "i", "d", "o", "c", "i", "o", "u", "s"};
            foreach (string letter in letters)
            {
                Console.WriteLine(letter);
            }

            foreach (string letter in letters)
            {
                if (letter != "i")
                {
                    Console.WriteLine("this is not an I");
                }
                else
                {
                    Console.WriteLine(letter);
                }
            }
            Console.ReadKey();
        }
    }
}
