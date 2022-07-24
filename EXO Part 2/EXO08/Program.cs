using System;
using System.Collections.Generic;

namespace EXO8 {
    class Program {

        public static int[] blap0 = new int[] { 104, 101, 108, 108, 111 };

        public static List<string> meow = new List<string>();

        static void Main(string[] args) {

            Console.WriteLine(String.Join("", meow.ToArray()));
        }


        public static List<string> Trucnul(int[] rienici) {
            foreach(var s in rienici) {
                meow.Add(euh2(s));
            }
            return meow;
        }

        public static string euh2(int num) {
            char character = (char)num;
            string text = character.ToString();
            return text;
        }

    }

}


// MANQUE
//Result : Hello