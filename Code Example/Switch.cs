namespace DefaultNamespace
{
    public class Switch
    {
        
        public static void Switch()
        {
            int day = 4; // day = 4
            switch (day) 
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4: // donc on s'arrête ici et print Thursday puis on break pour ne pas check le reste du switch
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)
        }       
    }
}
