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
        public string Name { get; set; }
    }
}
