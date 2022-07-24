using System;

namespace EXO2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

        }
    }
    
    internal class Ma1erClasse
    {
        static void mafunction1()
        {
            Console.WriteLine("Ma1erMethode");
        }
        
    }

    internal class MA2emeClasse : Ma1erClasse
    {

        static void mafunction1()
        {
            Console.WriteLine("Ma1erMethode");
        }
        
        public static void MA2emeMethode()
        {
            Console.WriteLine("MA2emeMethode");
        }
    }
}

