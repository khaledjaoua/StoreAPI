using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI.Models.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}