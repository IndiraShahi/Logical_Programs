using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lets do some logical programs");
            Console.WriteLine("1.Fibonacci Series");
            Console.WriteLine("2. Perfect Number");
            Console.WriteLine("3. Prime Number");
            Console.WriteLine("4. Reverse a number");

            Console.WriteLine("Choose a number : ");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                     fibonacci.Fibonacci1();
                    break;
                case 2:
                    Perfect perfect = new Perfect();
                    perfect.PerfectNumber(8128);
                    break;
                default:
                    Console.WriteLine("Invalid, Please choose number from 1 to 4");
                    Program.Main();
                    break;
            }
        }
    }
}
