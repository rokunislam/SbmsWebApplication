using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SbmsWebApplication.Models
{
    public class Product 
    {
       
        public int Id { get; set; } 
        public string Code { get; set; }      
        public string Name { get; set; }        
        public string CategoryName { get; set; }     
        public int ReorderLevel { get; set; }     
        public string Description { get; set; }
        [NotMapped]
        public List<SelectListItem> CategoryLookUp { get; set; }
        [NotMapped]
        public List<Product> Products { get; set; }


        
    }
}