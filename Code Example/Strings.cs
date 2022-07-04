namespace DefaultNamespace
{
    public class String
    {
        
        public static void String()
        {
            string greeting = "Hello";
            
            Console.WriteLine("The length of the txt string is: " + greeting.Length); // prints the length of the string
            Console.WriteLine(greeting.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(greeting.ToLower());   // Outputs "hello world"
            
            
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name); // Outputs "John Doe"
            
            
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
            Console.WriteLine(myString[1]);  // Outputs "e"
        }       
    }
}
