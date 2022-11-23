using System;

namespace Delegate
{
    class Program
    {
       public delegate bool check(int n);
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(tekeded, 1,2,3,4,5,6));
            Console.WriteLine(Sum(cuteded, 1, 2, 3, 4, 5, 6));
        }
       public static bool tekeded(int n)
        {
            return n % 2 != 0;
        }
       public static bool cuteded(int n)
        {
            return n % 2 == 0;
        }
       public static int Sum(check yoxla, params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (yoxla(item))
                {
                    sum += item;
                }
                
            }
            return sum;
        }
    }
}
