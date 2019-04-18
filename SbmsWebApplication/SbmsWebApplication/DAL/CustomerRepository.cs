using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SbmsWebApplication.DatabaseContext;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.DAL
{
    public class CustomerRepository
    {
        SbmsDbContext sbmsDb= new SbmsDbContext();


        public bool Add(Customer customer)
        {
            bool isAdd = false;
            sbmsDb.Customers.Add(customer);
            int rowAffected = sbmsDb.SaveChanges();
            if (rowAffected>0)
            {
                isAdd = true;
            }
            return isAdd;
        }

        public Customer GetById(int id)
        {
            Customer customer = sbmsDb.Customers.Where(c => c.Id == id).FirstOrDefault();
            return customer;
        }

        public bool Update(Customer customer)
        {
            bool isUpdate = false;
            sbmsDb.Entry(customer).State= EntityState.Modified;
            int rowAffected = sbmsDb.SaveChanges();
            if (rowAffected>0)
            {
                isUpdate = true;
            }
            return isUpdate;
        }
    }
}