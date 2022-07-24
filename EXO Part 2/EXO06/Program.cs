using System;
using System.Collections.Generic;

namespace EXO6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOne = new();
            listOne.Add("One");
            listOne.Add("Two");
            listOne.Add("Three");
            listOne.Add("Four");
            listOne.Add("Five");


            List<string> listTwo = new();
            listTwo.Add("A");
            listTwo.Add("B");
            listTwo.Add("C");

            listOne.AddRange(listTwo);
            listOne.RemoveRange(0, 0);

            foreach (string list in listOne)
            {
                Console.WriteLine(list);
            }
        }
    }

}


//ERREUR
//Result : 
/*
        A
        B
        C
*/