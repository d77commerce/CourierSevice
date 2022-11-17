using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Common.Parcel
{
    internal class ParcelRepository:Repository ,IParcelRepository
    {
        public ParcelRepository(ParcelDbContext context)
        {
            this.Context = context;

        }
    }
}
