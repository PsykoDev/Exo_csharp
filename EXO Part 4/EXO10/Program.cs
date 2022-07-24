using System;
using System.Collections.Generic;

namespace EXO10 {
    class Program {
        static void Main(string[] args) 
        {
            List<int> list = new List<int>();
            
            switch (list)
            {   
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
            }
        }
    }
}

// Dev
// ajouter 1, 2 ou 3 dans la list pour voir le résultat
// Result : 1 ou 2 ou 3 selon le cas
