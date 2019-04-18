using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.DatabaseContext
{
    public class SbmsDbContext:DbContext
    {
      public  DbSet<Category> categories { get; set; }
      public DbSet<Product> Products { get; set; }
      public DbSet<Customer> Customers { get; set; }
      public DbSet<Supplier> Suppliers { get; set; }

    }
}