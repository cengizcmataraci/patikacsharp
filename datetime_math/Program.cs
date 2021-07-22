using System;

namespace datetime_math
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DateTime.Now);
      Console.WriteLine(DateTime.Now.Date);
      Console.WriteLine(DateTime.Now.Day);
      Console.WriteLine(DateTime.Now.Month);
      Console.WriteLine(DateTime.Now.Year);
      Console.WriteLine(DateTime.Now.Hour);
      Console.WriteLine(DateTime.Now.Minute);
      Console.WriteLine(DateTime.Now.Second);

      Console.WriteLine(DateTime.Now.DayOfWeek);
      Console.WriteLine(DateTime.Now.DayOfYear);

      Console.WriteLine(DateTime.Now.ToLongDateString());
      Console.WriteLine(DateTime.Now.ToShortDateString());
      Console.WriteLine(DateTime.Now.ToLongTimeString());
      Console.WriteLine(DateTime.Now.ToShortTimeString());

      Console.WriteLine(DateTime.Now.AddDays(2));
      Console.WriteLine(DateTime.Now.AddHours(3));
      Console.WriteLine(DateTime.Now.AddSeconds(30));
      Console.WriteLine(DateTime.Now.AddMonths(5));
      Console.WriteLine(DateTime.Now.AddYears(10));
      Console.WriteLine(DateTime.Now.AddMilliseconds(50));

      //DateTime Format
      Console.WriteLine(DateTime.Now.ToString("dd")); //integer gün
      Console.WriteLine(DateTime.Now.ToString("ddd")); //string gün
      Console.WriteLine(DateTime.Now.ToString("dddd")); //string gün uzun

      Console.WriteLine(DateTime.Now.ToString("MM")); //integer ay
      Console.WriteLine(DateTime.Now.ToString("MMM")); //string ay kısa
      Console.WriteLine(DateTime.Now.ToString("MMMM")); //string ay uzun

      Console.WriteLine(DateTime.Now.ToString("yy")); //21
      Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

      Console.WriteLine("*** Math Kütüphanesi ***");
      //Math Kütüphanesi
      Console.WriteLine(Math.Abs(-25)); //Mutlak değer
      Console.WriteLine(Math.Sin(60)); //Sinüs
      Console.WriteLine(Math.Cos(60)); //Cosinüs
      Console.WriteLine(Math.Tan(60)); //Tanjant

      Console.WriteLine(Math.Ceiling(22.3)); //Yukarı yuvarlar
      Console.WriteLine(Math.Round(22.3)); //Hangisine daha yakınsa ona yuvarlar
      Console.WriteLine(Math.Round(22.7)); //Hangisine daha yakınsa ona yuvarlar
      Console.WriteLine(Math.Floor(22.7)); //Aşağı yuvarlar

      Console.WriteLine(Math.Min(2,6));
      Console.WriteLine(Math.Max(2,6));

      Console.WriteLine(Math.Pow(3,4)); //3^4 üs işlemi
      Console.WriteLine(Math.Sqrt(9)); //Karekök
      Console.WriteLine(Math.Log(9)); //Logaritma
      Console.WriteLine(Math.Exp(3)); //e^3 e üzeri 3
      Console.WriteLine(Math.Log10(10)); //Logaritma 10 tabanı
      

    }
  }
}
