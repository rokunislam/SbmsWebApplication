using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SbmsWebApplication.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public int ContactPerson { get; set; }

    }
}