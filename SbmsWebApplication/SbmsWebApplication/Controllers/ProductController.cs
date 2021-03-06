﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SbmsWebApplication.BLL;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager = new ProductManager();
        Product product= new Product();

        [HttpGet]
        public ActionResult Add()
        {
            var product = new Product();
            product.CategoryLookUp = _productManager.GetCategorySelectListItems();
            
            return View(product);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Product product)
        {
            product.CategoryLookUp = _productManager.GetCategorySelectListItems();
            try
            {
                if (ModelState.IsValid)
                {
                    var IsAdd = _productManager.Add(product);

                    if (IsAdd)
                    {
                        ViewBag.Smsg = " Save Successfully";

                    }
                    else
                    {
                        ViewBag.Fmsg = "Category Not Saved";
                    }
                }
                
                 _productManager.GetAll();
                return View(product);

            }
            catch (Exception e)
            {
                ViewBag.Fmsg = e.Message;
            }
            _productManager.GetAll();
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            var data = _productManager.GetById(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                var isUpdate = _productManager.Update(product);
                
            }
            catch (Exception e)
            {
                ViewBag.Fmsg = e.Message;

            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var isDeleted = false;
            Product product = _productManager.GetById(id);
            if (product!=null)
            {
                isDeleted = _productManager.Delete(product);
            }
            if (isDeleted)
            {
                TempData["Smsg"] = "Succesfully Deleted";
            }
            TempData["FMsg"] = "Not Deleted";
            return RedirectToAction("Add");
        }
    }

}