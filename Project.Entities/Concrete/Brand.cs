using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Brand
    {
        [Required]
        public string Name { get; set; }
    }
}
