namespace Homework5;
class Program
{
    

        // Q1 _method
        // Method to return the largest of two integers
    static int GetLargest(int num1, int num2)
    {
        if (num1 > num2)
            return num1;
        else
            return num2;
    }


        //Q2 method
        static int GetLargestOfFour(int num1, int num2, int num3, int num4)
    {
        // First, find the largest of the first two numbers
        int largestOfFirstTwo = GetLargest(num1, num2);
        
         // Then, find the largest of the next two numbers
        int largestOfLastTwo = GetLargest(num3, num4);
        
        // Finally, find the largest of the two previous largest values
        return GetLargest(largestOfFirstTwo, largestOfLastTwo);
    }



        // Q3_method
         // Method to check if the person is 18 or older
        static bool CheckAge(int birth_year)
    {
        // Get the current year
        int currentYear = DateTime.Now.Year;

        // Calculate the age
        int age = currentYear - birth_year;

        // Return true if age is 18 or older, otherwise false
        return age >= 18;
    }


        static void CreateAccount()
    {
        // Ask user for username
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        // Ask user for password
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Ask user to confirm password
        Console.Write("Confirm your password: ");
        string confirmPassword = Console.ReadLine();

        // Ask user for birth year
        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());
    

        // Check if the user is old enough
        if (CheckAge(birthYear))
        {
            // If the age is valid, check if the passwords match
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully.");
            }
            else
            {
                Console.WriteLine("Wrong password.");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account. You must be 18 or older.");
        }
    }  



            static void Main(string [] args)   
    {
       // Call Q1_method()
        // Getting input from the user
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        // Calling the GetLargest method and storing the result
        int largest = GetLargest(num1, num2);

        // Printing the result
        Console.WriteLine($"The largest number is: {largest}");
    }

        
    {
        // Getting input from the user for four integers
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fourth number:");
        int num4 = int.Parse(Console.ReadLine());

        // Calling the GetLargestOfFour method and storing the result
        int largestOfFour = GetLargestOfFour(num1, num2, num3, num4);

        // Printing the result
        Console.WriteLine($"The largest number is: {largestOfFour}");
        }


    static void CreateAccount()
    {
        // Call CreateAccount method to start the account creation process
        CreateAccount();
    }


  }

