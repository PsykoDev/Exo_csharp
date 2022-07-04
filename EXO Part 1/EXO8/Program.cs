using System;
using System.Collections.Generic;

namespace EXO8 {
    class Program {
        static void Main(string[] args) {
            Dictionary<int, string> dico = new Dictionary<int, string>();
            dico.Add(1, "Meow");
            dico.Add(2, "Chat");
            dico.Add(3, "Chien");

            foreach(KeyValuePair<int, string> kvp in dico) {
                if(kvp.Key != 0) {
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}

//ERREUR / MANQUE
//Result uniquement : Key = 2, Value = "Chat"