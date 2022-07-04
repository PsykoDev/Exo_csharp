using System;

namespace EXO12 {
    class Program {
        enum Level {
            Low = 4,
            Medium = 5,
            High = 6
        }
        static void Main(string[] args) {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }

    }
}


//ERREUR
//Result : 15