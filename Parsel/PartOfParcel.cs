using Parcel.Contracts;

namespace Parsel
{
    public class PartOfParcel : IParcel
    {
       public int Id { get; set; }
      public  double Kg { get; set; }
      public  double Height { get; set; }
       public double Width { get; set; }
      public  double Length { get; set; }
       public bool IsFragile { get; set; } = false;
    }
}