using System;
using System.Collections.Generic;
using System.Text;

namespace SubtractTheProductAndSumOfDigitsOfAnInteger
{
    public class Solution
    {
        public static int SubtractProductAndSum(int n)
        {
            int prod = 1;
            int sum = 0;
            int digit = n;
            string numbers = n.ToString();
            for(int i=0;i<numbers.Length;i++)
            {
                digit = int.Parse(numbers[i].ToString());
                prod = prod * digit;
                sum= sum+digit;
            }
            return prod - sum;
        }
    }
}
