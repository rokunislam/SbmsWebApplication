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

        public List<SelectListItem> GetCategorySelectListItems()
        {
            var dataList = sbmsDbContext.categories.ToList();
            var categorySelectListItems= new List<SelectListItem>();
            categorySelectListItems.AddRange(GetDefaultSelectListItem());
            if (dataList != null && dataList.Count>0)
            {
                foreach (var category in dataList)
                {
                    var selectListItem = new SelectListItem();
                    selectListItem.Text = category.Name;
                    selectListItem.Value = category.Name;
                    categorySelectListItems.Add(selectListItem);
                }
            }
            return categorySelectListItems;
        }

        public List<SelectListItem> GetDefaultSelectListItem()
        {
            var dataList = new List<SelectListItem>();
            var defaultSelectListItem = new SelectListItem();
            defaultSelectListItem.Text = "---Select---";
            defaultSelectListItem.Value = "";
            dataList.Add(defaultSelectListItem);
            return dataList;
        }
    }
}