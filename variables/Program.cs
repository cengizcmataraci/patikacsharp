using System;

namespace variables
{
  class Program
  {
    static void Main(string[] args)
    {
      string degisken = null;
      string Degisken = null;  //case sensitive

      byte  b = 5;             // 1 byte 0-255
      sbyte sb = 5;            // 1 byte -128 * 127

      short  s = 5;            // 2 byte -32768 * 32768
      ushort u = 5;            // 2 byte  0 - 65365

      Int16 i16 = 2;           // 2 byte
      int   i = 2;             // 4 byte
      Int32 i32 = 2;           // 4 byte
      Int64 i64 = 2;           // 8 byte

      uint  ui = 2;            // 4 byte
      long  l = 4;             // 8 byte
      ulong ul = 4;            // 8 byte

      // reel sayılar
      float   f = 5;           // 4 byte
      double  d = 5;           // 8 byte
      decimal de = 5;          // 16 byte

      char   ch = '2';         // 2 byte
      string str = "Cengiz";   // sınırsız

      bool b1 = true;
      bool b2 = false;

      DateTime dt = DateTime.Now;
      Console.WriteLine(dt);

      object o1 = "x";
      object o2 = 'y';
      object o3 = 4;
      object o4 = 4.3;

      // string ifadeler
      string str1 = "";
      string str2 = null;
      string str3 = string.Empty;
      str1 = "Cengiz C. Mataracı";
      string ad = "Cengiz C.";
      string soyad = "Mataracı";
      string tamIsim = ad + " " + soyad;

      // integer tanımlama şekilleri
      int int1 = 5;
      int int2 = 3;
      int int3 = int1 * int2;

      // boolean
      bool bool1 = 10 < 2;
      bool bool2 = 10 > 2;

      // değişken dönüşümleri
      string str10 = "10";
      int int10 = 10;
      string yeniDeger = str10 + int10.ToString();
      Console.WriteLine(yeniDeger); // 1010

      int int20 = int10 + Convert.ToInt32(str10);
      Console.WriteLine(int20);     // 20

      int int21 = int20 + int.Parse(str10);
      Console.WriteLine(int21);     // 30

      // DateTime
      string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
      Console.WriteLine(dateTime);  // noktalı

      string dateTime1 = DateTime.Now.ToString("dd/MM/yyyy");
      Console.WriteLine(dateTime1); // slashli

      string dateTime2 = DateTime.Now.ToString("HH:mm");
      Console.WriteLine(dateTime2); // saat
    }
  }
}
