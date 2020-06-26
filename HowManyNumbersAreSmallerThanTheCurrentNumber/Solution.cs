using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace HowManyNumbersAreSmallerThanTheCurrentNumber
{
    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] numbers = new int[nums.Length];
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=0;j<nums.Length;j++)
                {
                    if(nums[i]>nums[j])
                    {
                        numbers[i] = numbers[i] + 1;
                    }
                }
            }
            return numbers;
        }
    }
}
