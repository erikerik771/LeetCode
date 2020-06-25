using System;

namespace ShuffleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("numarul de elemente din array x2 este:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n * 2];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("elementul " + i + " :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Solution solutie = new Solution();
            Console.WriteLine("Solutia este:");
            int[] a =solutie.Shuffle(arr, n);
            foreach (var element in a)
            {
                Console.WriteLine(element.ToString());
            }
            }
        }
    }