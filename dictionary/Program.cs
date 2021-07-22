using System;
using System.Collections.Generic;

namespace dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      //System.Collections.Generic
      Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

      kullanıcılar.Add(10, "Cengiz C. Mataracı");
      kullanıcılar.Add(12, "Elif Mine Kılıçaslan");
      kullanıcılar.Add(18, "Firdevs Nur Mataracı");
      kullanıcılar.Add(20, "Furkan Tolga Yüce");

      //Dizinin elemanlarına erişim
      Console.WriteLine("*** Elemanlara Erişim ***");
      Console.WriteLine(kullanıcılar[12]);
      foreach (var item in kullanıcılar)
        Console.WriteLine(item);

      //Count
      Console.WriteLine("*** Count ***");
      Console.WriteLine(kullanıcılar.Count);

      //Contains
      Console.WriteLine("*** Contains ***");
      Console.WriteLine(kullanıcılar.ContainsKey(16));
      Console.WriteLine(kullanıcılar.ContainsValue("Cengiz C. Mataracı"));

      //Eleman çıkarma
      Console.WriteLine("*** Remove ***");
      kullanıcılar.Remove(20);
      foreach (var item in kullanıcılar)
        Console.WriteLine(item);

      //Keys
      Console.WriteLine("*** Keys ***");
      foreach(var item in kullanıcılar.Keys)
        Console.WriteLine(item);
      //Values
      Console.WriteLine("*** Values ***");
      foreach (var item in kullanıcılar.Values)
        Console.WriteLine(item);

    }
  }
}
