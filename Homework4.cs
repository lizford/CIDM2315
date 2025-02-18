namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // How to get the largest of two numbers
        int a, b, largest; //variables
        Console.WriteLine("Please enter 1 number"); //User will input the first number
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter 2 number"); //User will input the second number
        b = Convert.ToInt32(Console.ReadLine());

        if (a > b) //if n1 is bigger than n2
            largest = a; //then number1 is the largest number


        else if (b > a)  // if number1 is not true and number2 is greater than number1 then
            largest = b; // number 2 is the largest number

        largest = (a >b) ? a:b;

            Console.WriteLine("The largest number is {0}", largest);
    

    //Question 2
    int number = 5; //number variable
        string shape = "left"; //left shape variable
        string shape2 = "right"; //right shape variable

        Console.WriteLine("Please enter a number");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter left or right");
        Console.ReadLine();

        if (number == 5 && shape == "left") //5 and left
        {
            PrintLeftTriangle(number);
        }
        else if (number ==5 && shape2 == "right") // 5 and right
        {
            PrintRightTriangle(number);
        }
    }

    static void PrintLeftTriangle(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

      public static void PrintRightTriangle(int number, string shape = "right")
    {
        if (number == 5 && shape == "right")
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();      
             }
        }   
    }
}
