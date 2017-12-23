﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreAPI.Models.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}