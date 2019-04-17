using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SbmsWebApplication.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
  
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        
        public int CategoryId { get; set; }
        [Required]
        public int ReorderLevel { get; set; }
     
        public string Description { get; set; }



    }
}