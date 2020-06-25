using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KidsWithTheGreatestNumberOfCandies
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> isMax = new List<bool>();
            for(int i=0;i<candies.Length;i++)
            {
                if(candies[i]+extraCandies >= candies.Max())
                {
                    isMax.Add(true);
                }
                else
                {
                    isMax.Add(false);
                }
            }
            return isMax;
        }
    }
}
