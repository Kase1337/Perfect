using System;

class Program {
 static void Main(string[] args)
     {

       //Local variaables
      int increasenumber; 
      int divider;
       string perfectnum = "Perfect Number";
       string nonperfectnum = "Not A Perfect Number";
    
        Console.WriteLine("Checking for perfect numbers and non perfect numbers:");
       
// Enter a for loop to check for perfect numbers
   for (increasenumber = 1; increasenumber <= 10000; increasenumber++)
        {
           int increasevalueInsideloop = 0;  // define a local variable inside the loop "Need it else the program will skip the perfect numbers"
          
            for (divider = 1; divider < increasenumber; divider++)  // Run another loop to check for divisors
            {
               if (increasenumber % divider == 0) // Compares the divisors to the number using a if statement 
              {
                  increasevalueInsideloop += divider; // Adds the divisors to the local variable inside the loop
              }
            }

           if (increasevalueInsideloop == increasenumber) // Checks if the local variable inside the loop is equal to the number
             {
                
                // Prints the number if it is perfect 
                Console.WriteLine((increasenumber) + ": "+ perfectnum);
              
  
           }
          else // If the number is not perfect it will print the number as non perfect
           {
              // Prints the number if it is not perfect

               Console.WriteLine((increasenumber) + ": "+ nonperfectnum);
             

            
           

            } // End of the else statement
        }// End of the for loop
 
    } // End of the Main method
} // End of the Program class