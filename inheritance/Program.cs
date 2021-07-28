using System;

namespace inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      //                 Canlılar
      //                    |
      //     Bitkiler                Hayvanlar
      //    |       |             |           |
      // Tohumlu Tohumsuz   Sürüngenler     Kuşlar

      Console.WriteLine("*** Tohumlu Bitkiler ***");

      TohumluBitkiler tohumlubitki = new TohumluBitkiler();
      tohumlubitki.TohumlaCogalma();

      Console.WriteLine("*** Martı ***");

      Kuslar marti = new Kuslar();
      marti.UcarakHareket();
    }
  }
}
