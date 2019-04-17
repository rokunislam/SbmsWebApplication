using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SbmsWebApplication.BLL;
using SbmsWebApplication.DatabaseContext;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager _categoryManager = new CategoryManager();

        public ActionResult Save()
        {
            var datalist = _categoryManager.GetAll();
            return View(datalist);
        }

        [HttpPost]
        public ActionResult Save(Category category)
        {

            try
            {
                if (category.Name != null && category.Code != null)
                {

                    var IsAdd = _categoryManager.AddCategory(category);

                    if (IsAdd)
                    {
                        ViewBag.Smsg = " Save Successfully";

                    }
                    else
                    {
                        ViewBag.Fmsg = "Category Not Saved";
                    }
                }

                return View(_categoryManager.GetAll());

            }

            catch (Exception e)
            {

                ViewBag.Fmsg = e.Message;
            }

            return View(_categoryManager.GetAll());
        }

        public ActionResult Edit(int id)
        {
            var data = _categoryManager.GetById(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                var isUpdate = _categoryManager.Edit(category);
            }
            catch (Exception e)
            {
                ViewBag.Fmsg = e.Message;

            }
            return View();
        }


        public ActionResult Delete(int id)
        {
            bool isDeleted = false;
            Category category = _categoryManager.GetById(id);
            if (category != null)
            {
                isDeleted = _categoryManager.Delete(category);
            }

            if (isDeleted)
            {
                TempData["SMsg"] = "Deleted Successfully";
            }
            TempData["FMsg"] = "Not Deleted ";
            return RedirectToAction("Save");
        }
    }
}