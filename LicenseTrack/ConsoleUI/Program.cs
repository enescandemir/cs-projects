using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerGetTest();
        }
        private static void CustomerAddTest()
        {
            ICustomerDal customerDal = new EfCustomerDal();
            CustomerManager customerManager = new CustomerManager(customerDal);
                                  
            Customer customer = new Customer();
            customer.Name = "Novatech";
            customer.DBName = "NovatechDB";
            customer.Address = "192.168.1.9";

            customer.Port = 4099;
            customerManager.Add(customer);  
        }
        private static void CustomerGetTest()
        {
            ICustomerDal customerDal = new EfCustomerDal();
            CustomerManager customerManager = new CustomerManager(customerDal);

            List<Customer> customerList = new List<Customer>();
            customerList = customerManager.GetByCustomerId(2);
            foreach (Customer customer in customerList) {
                Console.WriteLine(customer.Name);
            }
        }

    }
}
