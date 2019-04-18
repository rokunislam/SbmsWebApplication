using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SbmsWebApplication.DAL;
using SbmsWebApplication.Models;

namespace SbmsWebApplication.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository= new CustomerRepository();

        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);


        }
    }
}