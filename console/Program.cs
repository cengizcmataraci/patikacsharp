using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi girin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı girin: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"Selam, {name} {surname}"); //string interpolation
            Console.ReadKey();
        }
    }
}
