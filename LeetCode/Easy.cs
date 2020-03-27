using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Easy
    {
        //https://leetcode.com/problems/reverse-integer/

        public int Reverse(int x)
        {
            var mod = x % 10;
            var div = x / 10;

            long result = mod;
            while (div != 0)
            {
                mod = div % 10;
                div /= 10;
                var temp = result * 10 + mod;
                result = temp;
            }

            if (result < int.MinValue || result > int.MaxValue)
            {
                return 0;
            }
            else
            {
                return (int)result;
            }
        }

        //https://leetcode.com/problems/defanging-an-ip-address/

        public string DefangIPaddr(string address)
        {
            var arr = address.Split(".");
            var result = "";

            for (var index = 0; index < arr.Length; index++)
            {
                var sub = arr[index];
                if (index == arr.Length - 1)
                {
                    result += sub;
                }
                else
                {
                    result += sub + "[.]";
                }
            }

            return result;
        }

        //https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
        public int NumberOfSteps(int num)
        {
            var step = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    step++;
                }
                else
                {
                    num -= 1;
                    step++;
                }
            }

            return step;
        }

        //https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/submissions/

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            if (nums.Length > 500 || nums.Length < 2)
            {
                return null;
            }

            var result = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                var count = 0;
                foreach (var t in nums)
                {
                    if (t < 0 || t > 100)
                    {
                        return null;
                    }

                    if (nums[i] > t)
                    {
                        count++;
                    }
                }

                result[i] = count;
            }

            return result;
        }
    }
}