using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateTargetArrayInTheGivenOrder
{
    public class Solution
    {
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            IList<int> target = new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
                target.Insert(index[i], nums[i]);
            }
            return target.ToArray();
        }
    }
}
