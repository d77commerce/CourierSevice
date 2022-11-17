using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Models
{
    public class Parcel
    {
      

        [Key]
        public int Id { get; set; }
        [Required]
        public ICollection<PartOfParcel> PartOfParcels { get; set; } = new List<PartOfParcel>();
    }
}
