﻿using System;

namespace Logical_Programs
{
    class Fibonacci
    {
        
        public int firstNumber = 0, secondNumber = 1, thirdNumber;
        public void Fibonacci1()
        {
            Console.WriteLine("Enter the number of elements : ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNumber + "\n" + secondNumber);

            for (int i = 2; i < N; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                Console.WriteLine(thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }

        }
    }
}