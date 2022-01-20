using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummativeSums
{
    class Program
    {

        public static int ArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int @int in arr)   //foreach loop to iterate through the elements of the array
                sum += @int;            //computes the sum
            return sum;                 //returns the computed sum
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] arr2 = { 999, -60, -77, 14, 160, 301 };
            int[] arr3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };
            Console.WriteLine("#1 Array Sum: " + ArraySum(arr1));
            Console.WriteLine("#2 Array Sum: " + ArraySum(arr2));
            Console.WriteLine("#3 Array Sum: " + ArraySum(arr3));
            Console.Read();
        }
    }
}
