using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            ValidateCustomer(customer);

            var existing = _customerDal.Get(c => c.Name.ToLower() == customer.Name.ToLower());
            if (existing != null)
            {
                throw new Exception("Bu isimde bir müşteri zaten mevcut.");
            }

            _customerDal.Add(customer);
            Console.WriteLine("Kullanıcı başarıyla eklendi.");
        }

        public void Update(Customer customer)
        {
            ValidateCustomer(customer);

            var existing = _customerDal.Get(c => c.Name.ToLower() == customer.Name.ToLower() && c.CustomerID != customer.CustomerID);
            if (existing != null)
            {
                throw new Exception("Bu isimde başka bir müşteri zaten mevcut.");
            }

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

        private void ValidateCustomer(Customer customer)
        {
            var validator = new CustomerValidator();
            var result = validator.Validate(customer);

            if (!result.IsValid)
            {
                var errorMessages = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                throw new ValidationException(errorMessages);
            }
        }
    }
}
