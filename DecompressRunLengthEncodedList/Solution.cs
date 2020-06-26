using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecompressRunLengthEncodedList
{
    public class Solution
    {
        public static int[] DecompressRLElist(int[] nums)
        {
            IList<int> rezultat = new List<int>();
            for(int i =0;i<nums.Length;i+=2)
            {
                int freq = nums[i];
                int val = nums[i + 1];
                for(int j=0;j<freq;j++)
                {
                    rezultat.Add(val);
                }
            }
            return rezultat.ToArray();
        }
    }
}
