using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcel.Contracts
{
    public interface IParcel
    {
        int Id { get; set; }
        double Kg { get; set; }
        double Height { get; set; }
        double Width { get; set; }
        double Length { get; set; }
        bool IsFragile { get; set; }
    }
}
