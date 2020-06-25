using System;

namespace XOROperationInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n este:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("start este:");
            int start = Convert.ToInt32(Console.ReadLine());
            Solution solutie = new Solution();
            int rezultat=solutie.XorOperation(n, start);
            Console.WriteLine("rezultatul este: "+rezultat); 
        }
    }
}
