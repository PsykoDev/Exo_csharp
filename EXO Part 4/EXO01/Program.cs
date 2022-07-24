using System;

namespace EXO1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var mySealedClass = new MySealedClass();
            Console.WriteLine(mySealedClass.Test());
        }

    }

    sealed class MySealedClass // le tag Sealed veux dire que la classe ne peut pas être héritée
    {
        public string Test()
        {
            return "Meow";
        }
    }
    
    class TestClass : MySealedClass // vue que ma class est Sealed je ne peux pas hériter de cette classe
    {

    }
}


// Erreur
// Result : 1 Found et  1 not found