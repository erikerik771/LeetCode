using System;

namespace NumberOfStepsToReduceANumberToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar:");
            int numar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numarul de pasi pentru a ajunge la 0 este:" +Solution.NumberOfSteps(numar));
        }
    }
}
