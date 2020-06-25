using System;

namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti pietrele pretioase:");
            string pretioase = Console.ReadLine();
            Console.WriteLine("Introduceti pietrele pe care le detineti:");
            string pietre = Console.ReadLine();
            int numar = Solution.NumJewelsInStones(pretioase, pietre);
            Console.WriteLine("Aveti "+numar+" Pietre pretioase pe care le detineti");
        }
    }
}
