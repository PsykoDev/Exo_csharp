namespace DefaultNamespace
{
    public class Type_Casting
    {
        // Implicit Casting (automatically) - converting a smaller type to a larger type size
        // char -> int -> long -> float -> double
        
        // Explicit Casting (manually) - converting a larger type to a smaller size type
        // double -> float -> long -> int -> char
        
        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;

        static void funtion()
        {
            // Example 1
            Console.WriteLine(Convert.ToString(myInt)); // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt)); // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble)); // convert double to int
            Console.WriteLine(Convert.ToString(myBool)); // convert bool to string
            
            // Example 2
            Console.WriteLine(myInt.ToString()); // convert int to string
            Console.WriteLine((double)myInt); // convert int to double
            Console.WriteLine((int)myDouble); // convert double to int
            Console.WriteLine(myBool.ToString()); // convert bool to string
            
        }
    }
    
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
}
