using System;
using System.Collections.Generic;
using System.Text;

namespace JewelsAndStones
{
    public class Solution
    {
        public static int NumJewelsInStones(string J, string S)
        {
            int numar = 0;
            foreach(char c in S)
            {
                if(J.Contains(c))
                {
                    numar++;
                }
            }
            return numar;
        }
    }
}
