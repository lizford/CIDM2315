namespace Homework7;

class Program
{
    static void Main(string[] args)
    {

       // Answer Q1 and Q2
        
        // Creating two Customer objects
        Customer customer1 = new Customer(110, "Alice", 28); //Alice ID, name and age
        Customer customer2 = new Customer(111, "Bob", 30); //Bob ID, name and age

        // Printing their initial information
        Console.WriteLine("Initial customer information:");
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Changing their customer IDs
        customer1.ChangeID(220); //changes Alice ID from 110 to 220
        customer2.ChangeID(221); //changes Bob ID from 111 to 221

        // Printing their updated information
        Console.WriteLine("\nUpdated customer information:");
        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        // Comparing their ages
        Console.WriteLine("\nAge comparison:");
        customer1.CompareAge(customer2);
        }
    }


class Customer 
 {
            // Code for Customer class
    
        private int cus_id;
        public string cus_name;
        public int cus_age;

    // Constructor to initialize the customer information
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

   // Method to change the customer ID
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    // Method to print customer information
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

        // Method to compare the ages of two customers
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age) 
        {
            Console.WriteLine($"{this.cus_name} is older."); //if customer age is older than obj customer age write this
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older."); //if customer age is less than obj customer age write this
        }
        else
        {
            Console.WriteLine("Both customers are of the same age."); //if they are the same age write this
        }


    }

    }

