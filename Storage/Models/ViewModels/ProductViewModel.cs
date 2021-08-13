using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "ProductName")]
        [StringLength(30, ErrorMessage = "Max 30 tecken")]
        public string Name { get; set; }

        [Range(0, 1000000)]
        public int Price { get; set; }

        public int Count { get; set; }
        public int InventoryValue { get; set; }
    }
}
