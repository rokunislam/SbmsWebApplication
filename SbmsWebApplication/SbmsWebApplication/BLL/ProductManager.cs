using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SbmsWebApplication.DAL;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.BLL
{
    public class ProductManager
    {
        ProductRepository _productRepository= new ProductRepository();
        public bool Add(Product product)
        {
            product.CategoryLookUp = _productRepository.GetCategorySelectListItems();
            bool isAdd = _productRepository.Add(product);
            return isAdd;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            var isUpdate = _productRepository.GetById(id);
            return isUpdate;
        }

        public bool Update(Product product)
        {
            bool isUpdate = _productRepository.Update(product);
            return isUpdate;
        }

        public bool Delete(Product product)
        {
            var isDelete = _productRepository.Delete(product);
            return isDelete;
        }

        public List<SelectListItem> GetCategorySelectListItems()
        {
            return _productRepository.GetCategorySelectListItems();
        }
    }
}