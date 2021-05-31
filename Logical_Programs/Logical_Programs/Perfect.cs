using System;

namespace Logical_Programs
{
    class Perfect
    {
        public int PerfectNumber(int a)
        {
            
            int perfectnumber = 0, realnumber = a;
            
            if (a <= 0)
            {
                Console.WriteLine("Invalid number");
                return 0;
            }
            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                    perfectnumber += i;
            }
            if (perfectnumber == realnumber)
                Console.WriteLine($"{a} is a Perfect Number.");
            else
                Console.WriteLine($"{a} is not a Perfect Number.");
            return 0;

        }
    }
}