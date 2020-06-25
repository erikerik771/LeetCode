using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShuffleArray
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            IList<int> rezultat = new List<int>(nums.Length);
            for(int i=0;i<nums.Length/2;i++)
            {
                rezultat.Add(nums[i]);
                rezultat.Add(nums[i + nums.Length / 2]);
            }
            return rezultat.ToArray();
        }
    }
}
