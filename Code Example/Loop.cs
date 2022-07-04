namespace DefaultNamespace
{
    public class Loop
    {
        
        public static void While()
        {
            int i = 0;
            while (i < 10) // si i n'est pas = a 10, on continue
            {
                i++;
            }
        }      
        
        public static void Do_While()
        {
            int i = 0; // fait augmenter i de 1 à chaque tour de boucle et si i = 10 on stop
            do
            {
                i++;
            }while (i < 10)
        }   
        
        public static void For()
        {
           List<int> list = new List<int>();
           for (int i = 0; i < 10; i++) // ajoute les nombres de 0 à 9 dans la liste
           {
             list.Add(i);
           }
        }  
        
        public static void Foreach()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            foreach (var data in dict) // lis tous les éléments de la liste avec la key et la value
            {
                Console.WriteLine(data.Key  + " " + data.Value);
                // data.Key = 1
                // data.Value = one
            }
        } 
    }
}
