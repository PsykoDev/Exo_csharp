using System;

namespace EXO3
{
    class Program
    {
        static void Main(string[] args)
        {
            if(byte.MaxValue >= int.MaxValue) {
                Console.WriteLine("OK");
            }else {
                Console.WriteLine("NOP");
            }
        }
    }
}


//ERREUR operateur logique
//Result : OK