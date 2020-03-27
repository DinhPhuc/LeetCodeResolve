using System;

namespace LeetCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ez = new Easy();

            var data = new int[] { 8, 1, 2, 2, 3 };

            var nums = ez.SmallerNumbersThanCurrent(data);
            foreach (var t in nums)
            {
                Console.WriteLine($"Hello World! {t}");
            }
        }
    }
}