using System;

namespace Logical_Programs
{
    class Reverse
    {
        public int ReverseNumber(int n)
        {
            
            int reverse = 0, lastDigit;
            
            if (n <= 9)
            {
                Console.WriteLine($" {n} should be greater than 10. ");
                return 0;
            }
            Console.WriteLine($"Number entered: {n}");
           
            while (n != 0)
            {
                lastDigit = n % 10;
                reverse = (reverse * 10) + lastDigit;
                n /= 10;
            }
            Console.WriteLine($"Reverse Number: {reverse}");
            return 0;

        }
    }
}