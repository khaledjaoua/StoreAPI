using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI.Models.Models
{
    public class Product_Features
    {
        public int Product_Features_Id { get; set; }
        public int Brand_Id { get; set; }
        public int Color_Id { get; set; }
        public int Size_Id { get; set; }
        public int Dimension_Id { get; set; }
        public int Is_Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public virtual Unit un { get; set; }
        public virtual Unit Unit { get; set; }

    }
    public class Color
    {
        [Key]
        public int Color_Id { get; set; }
        public string Color_Value { get; set; }
        public bool IS_Active { get; set; }
    }
    public class Unit
    {
        [Key]
        public int Unit_Id { get; set; }
        public string Unit_ { get; set; }
        public bool IS_Active { get; set; }
    }
    public class Dimension
    {
        public int Dimension_Id { get; set; }
        public Unit Unit_Id { get; set; }
        [ForeignKey("Unit_Id")]
        public virtual Unit Unit { get; set; }
        public string dimension_value { get; set; }
        public bool IS_Active { get; set; }
    }
    public class Size
    {
        [Key]
        public int Size_Id { get; set; }
        public string Size_Value { get; set; }
        public bool IS_Active { get; set; }
    }

}
