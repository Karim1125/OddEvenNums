using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintNums("Numbers:",nums);
            PrintNums("Evens:", nums.Where(X=>IsEven(X)));
            PrintNums("Odds:", nums.Where(X => IsOdd(X)));
            Console.ReadKey();
        }
        static void PrintNums(string title, IEnumerable<int> Nums)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach (int num in Nums)
            {
                Console.Write($" {num}");
            }
            Console.Write(" ]");
            Console.WriteLine();
        }
        static bool IsEven(int num) => num % 2 == 0;
        static bool IsOdd(int num) => !IsEven(num);
    }
}
