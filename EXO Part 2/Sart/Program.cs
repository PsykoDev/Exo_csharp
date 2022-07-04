
using System;
using System.Text.RegularExpressions;

namespace EXO
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello World!";
            Regex regex = new("[0-9]");
            if(regex.IsMatch(data))
                Console.WriteLine("Hello World!");
            else
                Console.WriteLine("doesn't match");
        }
    }
}

// Erreur / change
// RESULT : Hello World!