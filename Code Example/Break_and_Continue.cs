namespace DefaultNamespace
{
    public class Break_and_Continue
    {
        
        public static void Break()
        {
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4) 
                {
                    break; // si i = 4 alors on sort de la boucle
                }
                Console.WriteLine(i);
            }
        }    
        
        public static void Continue()
        {
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4) 
                {
                    continue; // si i = 4 alors on continue jusqu'à la fin de la boucle soit 10
                }
                Console.WriteLine(i);
            }
        }
    }
}
