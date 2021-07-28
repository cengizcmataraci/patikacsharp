using System;

namespace inheritance
{
  public class Canlılar
  {
    protected void Beslenme()
    {
      Console.WriteLine("Canlılar beslenir!");
    }

    protected void Solunum()
    {
      Console.WriteLine("Canlılar solunum yapar!");
    }

    protected void Boşaltım()
    {
      Console.WriteLine("Canlılar boşaltım yapar!");
    }

    public virtual void UyaranlaraTepki()
    {
      Console.WriteLine("Canlılar uyaranlara tepki verir.");
    }
  }
}