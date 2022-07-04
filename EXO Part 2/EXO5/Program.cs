using System;

namespace EXO5
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine(TXT.Truc("des choses"));
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }


    }

    class TXT
    {
        public static int Truc(string txt)
        {
            txt = txt;
            if(!txt.Contains("des")) return txt.Length;
            else return "".Length;
        }
    }
}


//ERREUR / Manque
//Result : 6