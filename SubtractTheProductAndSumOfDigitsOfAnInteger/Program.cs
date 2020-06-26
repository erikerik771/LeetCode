using System;

namespace SubtractTheProductAndSumOfDigitsOfAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Produsul cifrelor - suma cifrelor din n este:");
            Console.WriteLine(Solution.SubtractProductAndSum(n));
        }
    }
}
