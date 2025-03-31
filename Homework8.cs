namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
         
        // Creating Customer objects
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        // Creating customer_list
        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // Calling Q1 method
        TotalCredits(customer_list);

        // Calling Q2 method
        AmarilloAverageAge(customer_list);

        // Calling Q3 method
        CanyonAge(customer_list);
    }


     // Q1: Create a method to calculate and print the total credit of all customers in the customer_list.
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredits = 0; //default

        foreach (Customer customer in customer_list) //loops through customer object in cutomer list
        {
            totalCredits += customer.CustomerCredit; //adds up customer credit
        }

        Console.WriteLine($"Total credit of all customers: {totalCredits}");
    }


     // Q2: Create a method to calculate and print the average age of customers living in Amarillo.
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int totalAge = 0;
        int count = 0;

        foreach (Customer customer in customer_list)
        {
            if (customer.CustomerCity == "Amarillo") //If the city is Amarillo it will run the following:
            {
                totalAge += customer.CustomerAge; //customer age
                count++; //counts how many people in Amarillo
            }
        }
         if (count > 0) //if the sum is greater than 0
        {
            double averageAge = (double)totalAge / count;  //then it will take the age and divide by the number of people to find the average age
            Console.WriteLine($"Average age of customers in Amarillo: {averageAge:F2}");
        }
        else
        {
            Console.WriteLine("No customers found in Amarillo."); //If there is a 0 that means no Amarillo people
        }
    }

   // Q3: Create a method to print the names of customers who live in Canyon and are older than 30.
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.WriteLine("Customers in Canyon older than 30:");

        foreach (Customer customer in customer_list) 
        {
            if (customer.CustomerCity == "Canyon" && customer.CustomerAge > 30)//if the customer is from Canyon AND over 30
            {
                Console.WriteLine(customer.CustomerName); //then the customer name will be listed
            }
        }
    }
}

    
