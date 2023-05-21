using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new int[10];
            var Maximum = 0;

            Numbers[0] = 4478;
            Numbers[1] = 67;
            Numbers[2] = 2;
            Numbers[3] = 13004;
            Numbers[4] = 0;
            Numbers[5] = 873846;
            Numbers[6] = 120;
            Numbers[7] = 479;
            Numbers[8] = 12;
            Numbers[9] = 873846;


            for (var i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine("Number {0,2}:{1, 10}", i + 1, Numbers[i]);
            }


            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Maximum < Numbers[i])
                    Maximum = Numbers[i];
            }

            Console.WriteLine("Maximum = {0}\n", Maximum);

            // Wait for user input
            Console.ReadKey();
        }
    }
}
