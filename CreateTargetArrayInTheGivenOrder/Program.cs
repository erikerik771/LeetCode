using System;

namespace CreateTargetArrayInTheGivenOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cate numere aveti in array?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numere = new int[n];
            int[] index = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("Numarul " + (i+1) + ":");
                numere[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Indexul numarului " + (i+1) + ":");
                index[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] rezultat=Solution.CreateTargetArray(numere, index);
            Console.Write("Elementele sortate sunt: ");
            foreach(int elem in rezultat)
            {
                Console.Write(elem + " ");
            }
        }
    }
}
