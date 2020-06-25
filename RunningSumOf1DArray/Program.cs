using System;

namespace RunningSumOf1DArray
{
    class Program
    {
        public static int[] suma(int [] Arr)
        {
            int[] sum= new int[Arr.Length];
            sum[0] = 0;
            for(int i=0;i<Arr.Length;i++)
            {
                if (i == 0)
                {
                    sum[i] = Arr[i];
                }
                else
                {
                    sum[i] = sum[i - 1] + Arr[i];
                }
                Console.WriteLine(sum[i]);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("introduceti numarul de elemente din array:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("elementul " + i + " :");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma(a);
        }
    }
}
