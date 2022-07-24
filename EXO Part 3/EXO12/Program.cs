using System;
using System.Security.Cryptography;

namespace EXO12 
{
    class Program 
    {
        static void Main(string[] args)
        {
            string work = "DES CHOSES";
            Console.WriteLine(Log.Back(work));
        }
    }

    public class Log
    {
        public static string Back(string rawData)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {
                //code ICI
            }
        }
    }

}


// Dev
//convertir un string en SHA256
// recherche internet ok
// RESULT : cfbda284b93b9a8af1ef848808f8983ecd81bf852b02201ce479ca230b08e19e
