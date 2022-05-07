using System;
using System.Linq;

namespace Beltek66.MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İlk sayıyı girin: \t");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı girin: \t");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nsonuç: {Sum(num1, num2)}");

            int[] nums = new int[] { 4, 2, 3 };
            Console.WriteLine(nums.Sum());

        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        
        static int Sum(int[] numArray)
        {
            int sum = 0;
            foreach (int num in numArray)
            {
                sum += num;
            }
            return sum;
        }
    }
}
