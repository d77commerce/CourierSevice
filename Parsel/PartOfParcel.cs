using Parcel.Contracts;

namespace Parsel
{
    public class PartOfParcel : IParcel
    {
        public PartOfParcel(int id, double kg, double height, double width, double length, bool isFragile)
        {
            Id = id;
            Kg = kg;
            Height = height;
            Width = width;
            Length = length;
            IsFragile = isFragile;
        }
        public int Id { get; set; }
      public  double Kg { get; set; }
      public  double Height { get; set; }
       public double Width { get; set; }
      public  double Length { get; set; }
       public bool IsFragile { get; set; } = false;
    }
}