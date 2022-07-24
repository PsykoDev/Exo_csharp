using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EXO11 
{
    
    class Program 
    {
        
        static void Main(string[] args) 
        {
            ulong i = ulong.MaxValue;
            do
            {
                i--;
                Console.WriteLine(i);
                
            }while(true);
        }
    }
}


//MODIF
// Result : ne plus avoir de boucle infini dans le code et le programme s'arrête à la valeur max de l'int
