using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a ");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b ");
            int a = Convert.ToInt32(Console.ReadLine());
            int v= a*a*a;
            int s = 6 * (a * a);
            Console.Write($"v: {v}  s: {s}");
        }
    }

}
