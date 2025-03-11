namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 and Q2
          
        Professor alice = new Professor("Alice", "Java", 9000);
        Professor bob = new Professor("Bob", "Math", 8000);

        Student lisa = new Student("Lisa", "Java", 90);
        Student tom = new Student("Tom", "Math", 80);

        alice.PrintDetails(); //takes the place of "Professor" as alice with print details
        bob.PrintDetails(); //takes the place of "Professor" as bob with print details

        lisa.PrintDetails(); //takes the place of "student" as lisa with print details
        tom.PrintDetails(); //takes the place of "student" as tom with print details

        // Calculate and print the difference in salary
        double salaryDifference = alice.GetSalary() - bob.GetSalary(); //pulls the salary of alice with GetSalary and subtracts salary of bob with GetSalary
        Console.WriteLine($"Difference in Salary between Alice and Bob: {salaryDifference}\n"); //Inputs the difference of alice and bob salary with salaryDifference

        // Calculate and print the total grade of Lisa and Tom
        double totalGrade = lisa.GetGrade() + tom.GetGrade(); //pulls lisa grade with GetGrade and adds tom grade with GetGrade
        Console.WriteLine($"Total Grade of Lisa and Tom: {totalGrade}\n"); //adds lisa and tom grade with totalGrade
    
    }
}   
   
    class Professor   //specifically for Professors
   {
    //code for Professor class
    private string profName;  //variable for Professor name
    private string classTeach; // variable for Proffesor class
    private double salary; //variable for Professor salary 

    public Professor(string name, string teach, double sal) //public information
     {
        profName = name;
        classTeach = teach;
        salary = sal;
    }

    public void SetSalary(double salary_amount) //set
    {
        salary = salary_amount;
    }

    public double GetSalary() //get what is returned/shown
    {
        return salary;
    }

    public void PrintDetails() //information that is printed
    {
        Console.WriteLine($"Professor Name: {profName}");
        Console.WriteLine($"Class Taught: {classTeach}");
        Console.WriteLine($"Salary: {salary}\n");
    }

   }

   class Student
   {
    //code for Student class
    private string studentName; //private variable for student name
    private string classEnroll;//private variable for student enrolled class
    private double studentGrade; //private variable for student grade in class

    public Student(string name, string enroll, double grade) //public information for student name, enrolled class, and grade
    {
        studentName = name; //changing from private name to public name
        classEnroll = enroll; //changing from private enrolled class to public
        studentGrade = grade; //changing from private grade to public
    }
        public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

     public double GetGrade()
    {
        return studentGrade;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Class Enrolled: {classEnroll}");
        Console.WriteLine($"Grade: {studentGrade}\n");
    }
   }




