using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//my another effort to learn git. I lost it somewhere. ategory change. Fixes #3
namespace PartsUnlimited.Models
{
    public class Category
    { 
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}