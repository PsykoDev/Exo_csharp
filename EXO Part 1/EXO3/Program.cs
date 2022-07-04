using System;

namespace EXO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Truc(5,10f));
        }

        private static int Truc(int num, float num2)
        {
            int result = num + num2;
            return result;
        }
    }
}


//ERREUR
//Result : 15