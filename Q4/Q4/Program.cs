namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
            student.acceptDetails();
            student.PrintDetails();
        }
    }

    public class Student
    {
        private string name;
        private Boolean gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student()
        {
            name = "ABC";
            gender = true;
            age = 18;
            std = 12;
            div = 'A';
            marks = 0;
        }
        public Student(string name, Boolean gender, int age, int std, char div, double marks)
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
        
        public Boolean MyGender
        { get { return gender; } 
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
            MyGender = Convert.ToBoolean(Console.ReadLine());
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
            Console.WriteLine("Std: " + MyStd);
            Console.WriteLine("Div: " + MyDiv);
            Console.WriteLine("Marks: " + MyMarks);
        }
    }
}
