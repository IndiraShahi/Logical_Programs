using System;

namespace Logical_Programs
{
    class Prime
    {
        public void PrimeNumber(int a)
        {
            int result = 0;
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    result = 0;
                }
                else
                {
                    result = 1;
                }
            }
            if (result == 0)
            {
                Console.WriteLine("Number is not Prime");
            }
            else
            {
                Console.WriteLine("Number is Prime");

            }
        }
    }
}