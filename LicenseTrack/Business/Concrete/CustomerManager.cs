﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            try
            {
                _customerDal.Add(customer);
                Console.WriteLine("Kullanıcı başarıyla eklendi.");
            }
            catch(Exception ex) 
            {
                throw new Exception("Kullanıcı eklenirken hata meydana geldi.", ex);

            }
            
        }
        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetByCustomerId(int customerId)
        {
            return _customerDal.GetAll(c => c.CustomerID == customerId);
        }
    }
}
