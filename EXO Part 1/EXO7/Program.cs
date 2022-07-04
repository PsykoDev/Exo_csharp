using System;
using System.Diagnostics;

namespace EXO7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre 10 ici: ");
            int returnValue = int.Parse(Console.ReadLine());
            if (returnValue != 10) return;
            Console.WriteLine(returnValue);
        }
    }
}


//Manque 
// Si tu ecris 10 tu recois 15 ( pas touche au if ) 
//Resuslt 15 