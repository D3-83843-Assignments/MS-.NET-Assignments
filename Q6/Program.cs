namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Date date1 = new Date();
            date1.AcceptDate();
            date1.PrintDate();
            Console.WriteLine(date1.ToString());

            Date date2 = new Date();
            date2.AcceptDate();
            date2.PrintDate();
            Console.WriteLine(date2.ToString());

            Console.WriteLine("Difference in years: "+ Date.DifferenceInYears(date1,date2));
            Console.WriteLine("Difference using operator overloading: " + (date1 - date2));

        }
    }

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

        public bool IsValid()
        {
            if(day>0 && day<31 && month > 0 && month <= 12 && year>2025)
              return true;
            else
               return false;
        }

        public string ToString()
        {
            return day + "/" + month + "/" + year;    
        }

        public static int DifferenceInYears(Date date1, Date date2)
        {
            int yearsDiff = date2.year - date1.year;
            if (date2.month < date1.month || (date2.month == date1.month && date2.day < date1.day))
                yearsDiff--;
            return yearsDiff;
        }

        public static int operator -(Date date1, Date date2)
        {
            return DifferenceInYears(date1, date2);
        }

    }
}
