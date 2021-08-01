using System;

namespace struct_kavrami
{
  class Program
  {
    static void Main(string[] args)
    {
      Dikdortgen dikdortgen = new Dikdortgen();
      dikdortgen.KisaKenar = 5;
      dikdortgen.UzunKenar = 10;
      Console.WriteLine("Class Alan:  " + dikdortgen.AlanHesapla());

      DikdortgenStruct dikdortgenStruct = new DikdortgenStruct(3,4);
      Console.WriteLine("Struct Alan: " + dikdortgenStruct.AlanHesapla());
    }
  }

  class Dikdortgen
  {
    public int KisaKenar;
    public int UzunKenar;

    public Dikdortgen(){
      KisaKenar = 5;
      UzunKenar = 10;
    }

    public long AlanHesapla()
    {
      return this.KisaKenar * this.UzunKenar;
    }
  }

  struct DikdortgenStruct
  {
    public int KisaKenar;
    public int UzunKenar;

    public DikdortgenStruct(int kisaKenar, int uzunKenar)
    {
      KisaKenar = 5;
      UzunKenar = 10;
      KisaKenar = kisaKenar;
      UzunKenar = uzunKenar;
    }

    public long AlanHesapla()
    {
      return this.KisaKenar * this.UzunKenar;
    }
  }
}
