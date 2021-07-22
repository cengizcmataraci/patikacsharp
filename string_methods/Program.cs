using System;

namespace string_methods
{
  class Program
  {
    static void Main(string[] args)
    {
      string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
      string degisken2 = "CSharp";

      //Length
      Console.WriteLine(degisken.Length);

      //ToUpper - ToLower
      Console.WriteLine(degisken.ToUpper());
      Console.WriteLine(degisken.ToLower());

      //Concat
      Console.WriteLine(String.Concat(degisken, " Merhaba!")); //Sonuna birleştirir

      //CompareTo
      Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1

      //Compare
      Console.WriteLine(String.Compare(degisken, degisken2, true)); //Ignore case büyük küçük harf durumu
      Console.WriteLine(String.Compare(degisken, degisken2, false));

      //Contains
      Console.WriteLine(degisken.Contains(degisken2));
      Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
      Console.WriteLine(degisken.StartsWith("Merhaba!"));

      //IndexOf
      Console.WriteLine(degisken.IndexOf("CS"));
      Console.WriteLine(degisken.IndexOf("Cengiz"));

      //Insert
      Console.WriteLine(degisken.Insert(0,"Selam! "));

      //LastIndexOf
      Console.WriteLine(degisken.LastIndexOf("i"));

      //PadLeft, PadRight
      Console.WriteLine(degisken + degisken2.PadLeft(30)); //Sola boşluk ekler hiçbir şey yoksa
      Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
      Console.WriteLine(degisken.PadRight(50) + degisken2);
      Console.WriteLine(degisken.PadRight(50, '_') + degisken2);

      //Remove
      Console.WriteLine(degisken.Remove(10));
      Console.WriteLine(degisken.Remove(5,3));
      Console.WriteLine(degisken.Remove(0,1));

      //Replace
      Console.WriteLine(degisken.Replace("CSharp","C#"));
      Console.WriteLine(degisken.Replace(" ","*"));

      //Split
      Console.WriteLine(degisken.Split(' ')[1]);

      //Substring
      Console.WriteLine(degisken.Substring(4));
      Console.WriteLine(degisken.Substring(4,6));
    }
  }
}
