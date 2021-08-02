namespace abstract_sinif
{
  public class Civic : IOtomobil
  {
    public Marka HangiMarkaninAraci()
    {
      return Marka.Honda;
    }

    public int KacTekerlektenOlusur()
    {
      return 4;
    }

    public Renk StandartRengiNe()
    {
      return Renk.Gri;
    }
  }
}