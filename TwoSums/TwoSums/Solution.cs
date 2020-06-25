using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSums
{
    public class Solution
    {
        public int[] TwoSum(int[] numere,int target)
        {
            Dictionary<int,int> dic = new Dictionary<int, int>();
            for(int i=0;i<numere.Length;i++)
            {
                int rezultat = target - numere[i];
                if (dic.ContainsKey(rezultat))
                {
                    return new int[] { dic[rezultat], i };
                }
                else
                {
                    if (!dic.ContainsKey(numere[i]))
                        dic.Add(numere[i], i);
                }
            }
            return null;
        }
    }
}
