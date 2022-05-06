using System;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv inn et tall: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Svriv inn enda et tall: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 * num2);
            Console.ReadLine();
        }
    }
}
