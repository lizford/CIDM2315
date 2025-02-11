namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1

        Console.WriteLine("Input an number/integer"); // User puts in a number
        int N =int.Parse(Console.ReadLine());

        if (IsPrime(N)) // function checks if the number is a prime number
        {
            Console.WriteLine("${N} is prime"); 
        }
        else
        {
            Console.WriteLine("${N} is not prime"); // is not a prime number
        }
    

        static bool IsPrime(int num)
     {
            if (num <= 1) // if a number is less than 2 it is not prime
        {
            return false; //false statement
        }
            for (int i = 2; i <= Math.Sqrt(num); i++) //finds divisibility of 2 and up to the square root of a number
         {
            if (num % i == 0)
            {
                return false; //not prime because there is a divisor

            }
         }
            return true; // no divisor so it is prime
     }
  

    
        // Code for Q2
        Console.Write("Please input a number"); // user puts in a number
        int N= int.Parse(Console.ReadLine());

        for (int r = 1; r <= N; r++) //loop for r rows
        {
            for (int c = 1; c <= N; c++) //loop for c columns
            {
                Console.Write(r+""); //rows
            }
                Console.WriteLine();
        }
    


        //Code for Q3
        for(int row = 0; row<5; row++){
            for (int col = 0; col <5; col++)
            {
                if (row>=col)
                // no {} if only one code line
                Console.Write('*');
            }
            Console.WriteLine("");
        



        // Code for Bonus Question
        }
    }
}