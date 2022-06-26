using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsel
{
    public class WholeParcel
    {

        private readonly List<PartOfParcel> _parcels;

        public WholeParcel()
        {

            _parcels = new List<PartOfParcel>();
        }
        public int Id { get; set; }

        public void AddParcel()
        {
            _parcels .Add(new PartOfParcel());
        }
    }
}
