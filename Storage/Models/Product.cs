using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "ProductName")]
        [StringLength(30, ErrorMessage = "Max 30 tecken")]
        public string Name { get; set; }

        [Range(0, 1000000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        public string Category { get; set; }
        public string Shelf { get; set; }
        
        public int Count { get; set; }
        public string Description { get; set; }
    }
}
