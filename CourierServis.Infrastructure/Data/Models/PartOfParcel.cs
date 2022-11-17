using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Infrastructure.Data.Models
{
    public class PartOfParcel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0.0, 100)]
        public double Kg { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        [Required]
        public bool IsFragile { get; set; } = false;
    }
}
