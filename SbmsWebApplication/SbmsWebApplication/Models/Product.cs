using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SbmsWebApplication.Models
{
    public class Product
    {
       
        public int Id { get; set; }
  
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }
     
        public int ReorderLevel { get; set; }
     
        public string Description { get; set; }



    }
}