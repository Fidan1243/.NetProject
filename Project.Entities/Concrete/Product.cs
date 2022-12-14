using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Product
    {
        [Required]
        public int Brand_Id { get; set; }
        [Required]
        public int Type_Id { get; set; }
        [Required]
        public int Material_Id { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
