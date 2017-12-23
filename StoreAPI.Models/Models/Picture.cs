using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAPI.Models.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string AltText { get; set; }

        [DataType(DataType.Html)]
        public string Caption { get; set; }

        public string ImageUrl { get; } 

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        public Picture()
        {
            CreatedDate = DateTime.UtcNow;
        }
    }
}
