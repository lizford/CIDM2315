namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        //if-else statement
        Console.WriteLine("Please input a letter: ");

           string letter = Console.ReadLine();
           if(letter == "A"){
                Console.WriteLine("Grade: 4");
           }

           else if (letter == "B"){//3<=point4
                Console.WriteLine("Grade: 3");
           }

            else if (letter == "C"){//2<=point3
                 Console.WriteLine("Grade: 2");
            }

            else if (letter == "D"){//1<=point2
                Console.WriteLine("Grade: 1");
            }

            else if (letter == "F"){//0<=point1
                 Console.WriteLine("Grade: 0");
            }

            else {//any other letter
            
                Console.WriteLine("Wrong Letter Grade!");
            
            }

            //Code for Q2
            int n1 = 12, n2 = 11, n3 = 14;
            if(n1<n2){
                if(n1<n3){
                    Console.WriteLine("The smallest number is 12");
                }
                else{//n1>=n3
                Console.WriteLine("The smallest number is 14");
                }
             }
                else{//n2<=n1
                if(n2<n3){
                    Console.WriteLine("The smallest number is 11");
                }
                else{//n3<=n2
                Console.WriteLine("The smallest number is 14");
                }
            }
           
    

        //Code for Bonus Question
        Console.Write("Enter a year: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid year.");
     }
 }

} 
    

