using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backenduppgift1.Models
{
    public class ProductCreate
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; } 

        [Required]
        public int SubCategoryId { get; set; }

    }
}
