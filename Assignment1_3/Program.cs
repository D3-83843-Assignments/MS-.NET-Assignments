namespace Assignment1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int ch;

            do
            {
                Console.WriteLine("---------CALCULATOR----------");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Exit");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Enter your choice: ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Addition = " + (n1 + n2));
                        break;

                    case 2:
                        if (n1 > n2)
                            Console.WriteLine("Subtraction = " + (n1 - n2));
                        else
                            Console.WriteLine("Subtraction = " + (n2 - n1));
                        break;

                    case 3:
                        Console.WriteLine("Multiplication = " + (n1 * n2));
                        break;

                    case 4:
                        double div = Convert.ToDouble(n1)/Convert.ToDouble(n2);
                        Console.WriteLine("Division = " + div);
                        break;

                    case 5:
                        Console.WriteLine("Thank you..");
                        break;

                    default:
                        Console.WriteLine("Invalid choice..");
                        break ;
                }
            }
            while (ch != 5);
        }
    }
}
