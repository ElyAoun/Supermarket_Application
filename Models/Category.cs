using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket_Application.Models
{
    public class Category
    {
        [Key] //Data annotation for primary key and identity
        public int CategoryID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Categroy name should be at least {2}", MinimumLength = 5)]

        public string Name { get; set; }
    }
}
