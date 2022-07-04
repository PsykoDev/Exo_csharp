using System;
using System.Collections.Generic;

namespace EXO6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dinosaurs = new List<int>();

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur[1]);
            }
        }
    }

}


//ERREUR
//Result : 
/*
        Tyrannosaurus
        Amargasaurus
        Mamenchisaurus
        Deinonychus
        Compsognathus
*/