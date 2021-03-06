using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket_Application.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Length must be minimum {2} characters.", MinimumLength = 10)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Too Short.", MinimumLength = 50)]
        public string Details { get; set; }


        [Range(1, double.MaxValue)]
        public double Price { get; set; }

        public string Image { get; set; }

        [Display(Name = "Category")] //how it will be displayed in the browser
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")] //setting a relation with Category table, ti will automatically create a categoryID column
        public virtual Category Category { get; set; }
    }
}
