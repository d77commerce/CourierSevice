using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsel
{
    public class Parcel
    {

        private readonly List<PartOfParcel> _parcels;

        public Parcel()
        {
            
            _parcels = new List<PartOfParcel>();
        }
        public int Id { get; set; }

        public void AddParcel(PartOfParcel partOfParcel)
        {
            _parcels .Add(partOfParcel);
        }
    }
}
