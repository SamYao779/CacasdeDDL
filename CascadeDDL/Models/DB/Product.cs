using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CascadeDDLTest.Models.DB
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}