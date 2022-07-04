using System;

namespace EXO1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            for (int i = 0; i < x; i++)
            {
                switch(i) {
                    case "1":
                    Console.WriteLine($"Your result: {x} + {i} = " + (x + i));
                    break;
                    default:
                    Console.WriteLine("Error");
                    break;
                }
            }
        }
    }
}


// Manquant
// Result : Your result: 15 + 1 = 16 