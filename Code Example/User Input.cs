namespace DefaultNamespace
{
    public class User_Input
    {
        
        public static void User_Inputs()
        {
            // Print " Enter username: " 
            Console.Write("Enter username: ");

            // Attend la réponse de l'utilisateur et le met dans la variable username
            string userName = Console.ReadLine();

            // Print la variable username 
            Console.WriteLine("Username is: " + userName);
            // OU
            Console.WriteLine($"Username is: {userName}");
        }       
    }
}
