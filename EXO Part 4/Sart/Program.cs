using System;

namespace EXO
{
    class Program
    {
        static void Main()
        {
            MyDerivedClass myDerivedClass = new MyDerivedClass();
            Console.WriteLine(myDerivedClass.Name);
            Console.WriteLine(myDerivedClass.Number);
            Console.WriteLine(myDerivedClass.Number2);
        }

    }
    
    class MyVitualClass // ici je fait une class virtuel 
    {
        public virtual string Name { get; set; } = "je suis un string"; // je fait un string de type virtual pour pouvoir l'override dans l'autre class

        private int _num = 5;
        public virtual int Number // je fait un get set int de type virtual pour pouvoir l'override dans l'autre class
        {
            get { return _num; }
            set { _num = value; }
        }
    }
    
    class MyDerivedClass : MyVitualClass // ici je fait une class qui hérite de la class virtuel et que je peux modifié a la volé 
    {
        public override string Name { get; set; } = "je suis un string mais après override"; // ici je retrouve le string de base mais je l'override avec une nouvelle value
        public override int Number { get; set; } = 10 + 10; // idem ici je retrouve le int de base mais je l'override avec une nouvelle value
        
        public  int Number2 { get; set; } = 5 + 12; // ici j'ajoute un int en plus dans la class
    }

}

// Erreur / change
// RESULT : My Point: x=2, y=3