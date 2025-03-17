﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetByCustomerId(int customerId);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        
    }
}
