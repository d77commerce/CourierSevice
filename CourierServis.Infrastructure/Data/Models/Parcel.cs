using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Models
{
    public class Parcel
    {
        public Parcel()
        {
            PartOfParcel = new List<PartOfParcel>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
       // public int PartOfParcelId { get; set; }
       // [ForeignKey(nameof(PartOfParcel))]
        //public ICollection<PartOfParcel> PartOfParcels { get; set; } = new List<PartOfParcel>();
        public List<PartOfParcel> PartOfParcel { get; set; }
    }
}
