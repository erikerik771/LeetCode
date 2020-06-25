using System;

namespace DefangingAnIPAdress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti IP ul:");
            string IP = Console.ReadLine();
            string noulIP=IP.Replace(".", "[.]");
            Console.WriteLine("IP ul este: "+noulIP);
        }
    }
}
