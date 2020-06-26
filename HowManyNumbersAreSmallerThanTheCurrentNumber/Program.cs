using System;

namespace HowManyNumbersAreSmallerThanTheCurrentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea arrayului:");
            int lungime = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lungime];
            for(int i=0;i<lungime;i++)
            {
                Console.WriteLine("Elementul " + i + ":");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Solution solutie = new Solution();
            int[] sol=solutie.SmallerNumbersThanCurrent(array);
            Console.WriteLine("Numarul de elemente mai mici decat numarul curent este:");
            foreach( int element in sol)
            {
                Console.Write(element+" ");
            }
        }
    }
}
