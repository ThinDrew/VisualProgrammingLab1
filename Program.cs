using System;
using Task1;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1 test = new HW1();

            int[] arr1 = { 5, 3, 4 };
            int[] arr2 = { 10, 5, 6, 7 };
            int[] arr3 = { 2, 3, 10 };

            Console.WriteLine(test.QueueTime(arr1, 1));
            Console.WriteLine(test.QueueTime(arr2, 2));
            Console.WriteLine(test.QueueTime(arr3, 2));
        }
    }
}
