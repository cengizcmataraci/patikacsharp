using System;

namespace inheritance
{
  public class Hayvanlar : Canlılar
  {
    protected void Adaptasyon()
    {
      Console.WriteLine("Hayvanlar adaptasyon kurabilir!");
    }

    public override void UyaranlaraTepki()
    {
      base.UyaranlaraTepki();
      Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
  }

  public class Surungenler : Hayvanlar
  {
    public Surungenler()
    {
      base.Adaptasyon();
      base.Beslenme();
      base.Boşaltım();
      base.Solunum();
    }
    public void SurunerekHareket()
    {
      Console.WriteLine("Sürüngenler sürünerek hareket eder.");
    }
  }
  public class Kuslar : Hayvanlar
  {
    public Kuslar()
    {
      base.Adaptasyon();
      base.Beslenme();
      base.Boşaltım();
      base.Solunum();
      base.UyaranlaraTepki();
    }
    public void UcarakHareket()
    {
      Console.WriteLine("Kuşlar uçarak hareket eder.");
    }
  }
}