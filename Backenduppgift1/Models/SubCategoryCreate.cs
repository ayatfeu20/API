using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backenduppgift1.Models
{
    public class SubCategoryCreate
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

    }
}
