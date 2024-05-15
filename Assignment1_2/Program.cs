using System.Numerics;

namespace Assignment1_2
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation to perform: ");
            string operation = Console.ReadLine();

            if (String.Equals(operation, "Add"))
               { Console.WriteLine("Addition: " + (n1 + n2)); }

            else if (String.Equals(operation,"Sub"))
            {
                if (n1 > n2)
                    Console.WriteLine(n1 - n2);
                else
                    Console.WriteLine(n2 - n1);
            }

            else if (String.Equals(operation, "Multiply"))
               { Console.WriteLine(n1 * n2); }

            else if (String.Equals(operation, "Div"))
            {
                double div = Convert.ToDouble(n1)/Convert.ToDouble(n2);
                Console.WriteLine(n1 / n2);
            }
            else
            { Console.WriteLine("Invalid.."); }
        }
    }
}
