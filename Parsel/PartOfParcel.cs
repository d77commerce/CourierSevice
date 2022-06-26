namespace Parsel
{
    public class PartOfParcel
    {
        int Id { get; set; }
        double Kg { get; set; }
        double Height { get; set; }
        double Width { get; set; }
        double Length { get; set; }
        bool IsFragile { get; set; } = false;
    }
}