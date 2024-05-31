using System.Security.Cryptography.X509Certificates;

namespace Q5
{
    internal class Program
    {
        static Student[] student=null;
        public static void createArray()
        {
            Console.WriteLine("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            student = new Student[n];
        }

        public static void AcceptInfo()
        {
            for(int i=0;i<student.Length; i++) 
            {
                Student s = new Student();
                s.acceptDetails();
                student[i] = s;
            }
        }

        public static void PrintInfo()
        {
            for(int i=0;i<student.Length;i++)
            {
                Student s = student[i];
                s.PrintDetails();
            }
        }

        public static void ReverseArray()
        {
            Student[] RevStudent= new Student[student.Length];
            for(int i=0;i<student.Length;i++)
            {
                RevStudent[i] = student[student.Length-1 - i];
            }
            student = RevStudent;
        }

        static void Main(string[] args)
        {

           createArray();
            Console.WriteLine("Student array: ");
            AcceptInfo();
            PrintInfo();

            Console.WriteLine("Student array after reverse: ");
            ReverseArray();
            PrintInfo() ;
        }
    }

    public class Student
    {
        private string name;
        private string gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student()
        {
            name = "ABC";
            gender = "F";
            age = 18;
            std = 12;
            div = 'A';
            marks = 0;
        }
        public Student(string name, string gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string MyName
        {
            get { return name; }
            set { name = value; }
        }

        public string MyGender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int MyAge
        {
            get { return age; }
            set { age = value; }
        }

        public int MyStd
        {
            get { return std; }
            set { std = value; }
        }

        public char MyDiv
        {
            get { return div; }
            set { div = value; }
        }

        public double MyMarks
        {
            get { return marks; }
            set { marks = value; }
        }

        public void acceptDetails()
        {
            Console.WriteLine("Enter name: ");
            MyName = Console.ReadLine();
            Console.WriteLine("Enter gender: ");
            MyGender = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            MyAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter std: ");
            MyStd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter div: ");
            MyDiv = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter marks: ");
            MyMarks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + MyName);
            Console.WriteLine("gender: " + MyGender);
            Console.WriteLine("Age: " + MyAge);
            Console.WriteLine("Std: " + MyStd);+
            Console.WriteLine("Div: " + MyDiv);
            Console.WriteLine("Marks: " + MyMarks);
        }
    }
}
