using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsel
{
    public class Parcel
    {

        private readonly List<PartsOfParcel> partOfParcel;

        public Parcel(List<PartsOfParcel> _partsOfParcel)
        {

            partOfParcel = _partsOfParcel;
        }
        public List<PartsOfParcel> Parts
        {
            get { return partOfParcel; }
            set { }
        }
        public int Pieces
        {
            get { return Pieces; }
            set
            {
                int count = partOfParcel.Count;
                Pieces = count;
            }
        }
       

        public double TotalKg
        {
            get { return TotalKg; }
            set
            {
                double kg = 0.000;
               partOfParcel.ForEach(p =>p.Kg += kg);
                TotalKg = kg;
            }
        }


    }
}
