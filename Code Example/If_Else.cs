namespace DefaultNamespace
{
    public class If_Else
    {
        
        public static void If_Else()
        {
            // Use if to specify a block of code to be executed, if a specified condition is true
            // Use else to specify a block of code to be executed, if the same condition is false
            // Use else if to specify a new condition to test, if the first condition is false
            // Use switch to specify many alternative blocks of code to be executed
            
            if (condition) 
            {
                // block of code to be executed if the condition is True
            }
            
            if (20 > 18) 
            {
                Console.WriteLine("20 is greater than 18");
            }
            
            int x = 20;
            int y = 18;
            if (x > y) 
            {
                Console.WriteLine("x is greater than y");
            }
            
            if (condition)
            {
                // block of code to be executed if the condition is True
            } 
            else 
            {
                // block of code to be executed if the condition is False
            }
            
            int time = 20;
            if (time < 18) 
            {
                Console.WriteLine("Good day.");
            } 
            else 
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."
            
            if (condition1)
            {
                // block of code to be executed if condition1 is True
            } 
            else if (condition2) 
            {
                // block of code to be executed if the condition1 is false and condition2 is True
            } 
            else
            {
                // block of code to be executed if the condition1 is false and condition2 is False
            }
        }       
    }
}

