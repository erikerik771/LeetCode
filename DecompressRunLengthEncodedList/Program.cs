using System;

namespace DecompressRunLengthEncodedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea arrayului:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("elementul " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] rezultat=Solution.DecompressRLElist(arr);
            foreach(int element in rezultat)
            {
                Console.Write(element + " ");
            }    
        }
    }
}
