using System;
using System.Collections.Generic;
using System.Text;

namespace XOROperationInAnArray
{
    public class Solution
    {
        public int XorOperation(int n, int start)
        {
            int rezultat = 0;
            for (int i = 0; i < n; i++)
            {
                rezultat = rezultat ^ (start + 2 * i);
            }
            return rezultat;
        }
    }
}
