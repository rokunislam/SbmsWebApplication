using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SbmsWebApplication.DAL;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.BLL
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository =new CategoryRepository();
        public bool AddCategory(Category category)
        {
            bool isAdd = _categoryRepository.AddCategory(category);
            return isAdd;
        }
        public bool Delete(Category category)
        {
            return _categoryRepository.Delete(category);
        }


        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

    
        public Category GetById(int id)
        {
            var data = _categoryRepository.GetById(id);
            return data;
        }

        public bool Edit(Category category)
        {
            var IsUpdate = _categoryRepository.EditCategory(category);
            return IsUpdate;
        }
    }
}