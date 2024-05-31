namespace Q7
{
    public class Date
    {
        public int year;
        public int month;
        public int day;

        public Date() { }

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine(day + "/" + month + "/" + year);
        }
    }
    public class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;

        public Person() {
            this.birth = new Date();
        }

        public Person(string name, bool gender, int day, int month, int year, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = new Date(year, month, day);
            this.address = address;
        }
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Date Birth
        {
            get { return birth; }
            set { birth = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void Accept()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Birth date: ");
            birth.AcceptDate();
            Console.WriteLine("Enter address: ");
            address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + gender);
            birth.PrintDate();
            Console.WriteLine("Age: " + (2024 - birth.year));
            Console.WriteLine("Address: " + address);
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Person p = new Person();
                p.Accept();
                p.Display();
            }
        }
    }
}
