using System;
using System.Collections.Generic;

namespace KidsWithTheGreatestNumberOfCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numarul de copii:");
            int copii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bomboanele in plus:");
            int plus = Convert.ToInt32(Console.ReadLine());
            int[] bomboane = new int[copii];
            for(int i=0;i<copii;i++)
            {
                Console.WriteLine("copilul " + i + " are:");
                bomboane[i] = Convert.ToInt32(Console.ReadLine());
            }
            Solution solutie = new Solution();
            IList<bool> isTrue = new List<bool>();
            isTrue = solutie.KidsWithCandies(bomboane, plus);
            foreach(bool element in isTrue)
            {
                Console.WriteLine(element);
            }
        }
    }
}
