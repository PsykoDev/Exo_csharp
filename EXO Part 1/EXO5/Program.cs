using System;

namespace EXO5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TXT.Truc("des choses"));
        }


    }

    class TXT
    {
        private static string Truc(string txt)
        {
            return txt.Substring(0);
        }
    }
}


//ERREUR
//Result : choses