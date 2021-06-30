using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama
            int x = 5;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2; // İşlemli atama
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantıksal Operatörler
            // ||, &&, !
            bool isSuccess = true;
            bool isCompleted = false;
        }
    }
}
