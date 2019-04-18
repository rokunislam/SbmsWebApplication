using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SbmsWebApplication.BLL;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            try
            {

                var isAdd = _customerManager.Add(customer);
                if (isAdd)
                {
                    ViewBag.Smsg = "Customer Add Successfully";
                }
                else
                {
                    ViewBag.Smsg = "Customer Not Add";
                }
            }
            catch (Exception e)
            {
                ViewBag.Fmsg = "Action Failed";

            }
            return View();
        }


        public ActionResult Edit(int id)
        {
            var isEdit = _customerManager.GetById(id);
            return View();
        }

        public ActionResult Edit(Customer customer)
        {
            try
            {
                var isUpdate = _customerManager.Update(customer);
                if (isUpdate)
                {
                    ViewBag.Smsg = "Customer Update Successfully";
                }
                else
                {
                    ViewBag.Smsg = "Customer Not Update";
                }
            }
            catch (Exception e)
            {

                ViewBag.Fmsg = e.Message;
            }
            return View();
        }
    }
}