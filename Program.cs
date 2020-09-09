using System;

namespace hienthiloichao
{
    class Program
    {
        static void Main(string[] args)
        {
            hthi();
        }
        static void hthi()
        {
            Console.WriteLine("Enter your name ?");
            String name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Hello :{0}  ", name);

        }
    }
}