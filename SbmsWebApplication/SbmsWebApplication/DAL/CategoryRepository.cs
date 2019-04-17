using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SbmsWebApplication.DatabaseContext;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.DAL
{
    public class CategoryRepository
    {
        SbmsDbContext sbmsDbContext= new SbmsDbContext();
        public bool AddCategory(Category category)
        {
            bool isSaved = false;

            sbmsDbContext.categories.Add(category);
            int rowAfected = sbmsDbContext.SaveChanges();

            if (rowAfected > 0)
               isSaved = true;

            return isSaved;
        }

        public bool Delete(Category category)
        {
            bool isDeleted = false;


            sbmsDbContext.categories.Remove(category);
            int rowAfected = sbmsDbContext.SaveChanges();

            if (rowAfected > 0)
                isDeleted = true;

            return isDeleted;
        }

       

        public bool Update(Category category)
        {
            bool isUpdated = false;

            sbmsDbContext.Entry(category).State = EntityState.Modified;

            int rowAfected = sbmsDbContext.SaveChanges();

            if (rowAfected > 0)
                isUpdated = true;

            return isUpdated;
        }

        public List<Category> GetAll()
        {
            return sbmsDbContext.categories.ToList();
        }

        public Category GetById(int id)
        {
            Category category = sbmsDbContext.categories.Where(c => c.Id == id).FirstOrDefault();
            return category;
        }


        public bool EditCategory(Category category)
        {
            var isUpdate = false;
            sbmsDbContext.Entry(category).State= EntityState.Modified;
            int rowAffected = sbmsDbContext.SaveChanges();
            if (rowAffected>0)
            {
                isUpdate = true;
            }

            return isUpdate;
        }
    }
}