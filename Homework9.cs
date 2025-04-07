namespace Homework9;

    class Program
    {
        static void Main(string[] args)
        {
            // Creating 4 students
            Student student1 = new Student(111, "Alice");
            Student student2 = new Student(222, "Bob");
            Student student3 = new Student(333, "Cathy");
            Student student4 = new Student(444, "David");

            // Step 3: Create a Dictionary for gradebook
            Dictionary<string, double> gradebook = new Dictionary<string, double>
            {
                { "Alice", 4.0 },
                { "Bob", 3.6 },
                { "Cathy", 2.5 },
                { "David", 1.8 }
            };

            // Step 4: Check if "Tom" is in the gradebook and insert if not
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook.Add("Tom", 3.3);
                Console.WriteLine("\nTom GPA 3.3");
            }

            // Step 5: Calculate the average GPA (need more practice...took a long time to get this)
            double totalGPA = 0;
            foreach (var gpa in gradebook.Values)
            {
                totalGPA += gpa;
            }
            double averageGPA = totalGPA / gradebook.Count;

            // Print out the average GPA
            Console.WriteLine($"\nAverage GPA: {averageGPA:F2}");

            // Step 6: Print students whose GPA is greater than the average GPA
            Console.WriteLine("\nStudents with GPA greater than the average GPA:");
            foreach (var student in Student.studentList)
            {
                if (gradebook.ContainsKey(student.StudentName) && gradebook[student.StudentName] > averageGPA)
                {
                    student.PrintInfo(); // Print student info if GPA is greater than average
                }
            }

            // Keep the console window open
            Console.ReadLine();
    }
}


 class Student
    {
        private int studentID;
        private string studentName;
        
        // Static list to hold all students
        public static List<Student> studentList = new List<Student>();

        // Constructor to initialize a student and add them to the student list
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this); // Adds the student object to the list
        }

        // Method to print the student's ID and Name
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
        }

        // Properties to get the student details (ID and Name)
        public int StudentID => studentID;
        public string StudentName => studentName;
    }
