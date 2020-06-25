using System;
using System.Collections.Generic;
using System.Text;

namespace NumberOfStepsToReduceANumberToZero
{
    public class Solution
    {
        public static int NumberOfSteps(int num)
        {
            int counter = 0;
            while(num!=0)
            {
                if(num%2==0)
                {
                    num = num / 2;
                    counter++;
                }
                if(num%2!=0)
                {
                    num = num - 1;
                    counter++;
                }
            }
            return counter;
        }
    }
}
