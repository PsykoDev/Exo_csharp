using System;
using System.Threading;

namespace EXO3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() => trouvemoi());

        }

        private static void trouvemoi()
        {
            Console.WriteLine("blap");
        }
    }
}


// print blap
//Result : blap