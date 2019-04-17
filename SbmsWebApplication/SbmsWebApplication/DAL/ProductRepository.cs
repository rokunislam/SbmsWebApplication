using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SbmsWebApplication.DatabaseContext;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.DAL
{
    public class ProductRepository
    {
        SbmsDbContext sbmsDbContext= new SbmsDbContext();
        public bool Add(Product product)
        {
            bool isAdd = false;
            sbmsDbContext.Products.Add(product);
            int rowAffected = sbmsDbContext.SaveChanges();
            if (rowAffected>0)
            {
                isAdd = true;
            }
            return isAdd;
        }

        public List<Product> GetAll()
        {
            return sbmsDbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            Product product = sbmsDbContext.Products.Where(p => p.Id == id).FirstOrDefault();
            return product;
        }

        public bool Update(Product product)
        {
            bool isUpdate = false;
            sbmsDbContext.Entry(product).State= EntityState.Modified;
            int rowAffected = sbmsDbContext.SaveChanges();
            if (rowAffected>0)
            {
                isUpdate = true;
            }
            return isUpdate;
        }

        public bool Delete(Product product)
        {
            bool isDelete = false;
            sbmsDbContext.Products.Remove(product);
            int rowAffected = sbmsDbContext.SaveChanges();
            if (rowAffected>0)
            {
                isDelete = true;
            }
            return isDelete;
        }
    }
}