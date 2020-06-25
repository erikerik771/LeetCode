using System;

namespace TwoSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution two = new Solution();
            int[] nums ={2,7,11,5};
            int target = 13;
            int[] rez=two.TwoSum(nums, target);
            Console.WriteLine(string.Join(" , ",rez));
        }
    }
}
