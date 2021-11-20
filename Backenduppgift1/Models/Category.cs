using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Backenduppgift1.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }


    }
}
