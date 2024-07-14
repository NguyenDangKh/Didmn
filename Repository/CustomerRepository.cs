
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CustomerRepository : ICustomerRepository
    {
        private List<Customer> customers = new List<Customer>();

        public Customer GetCustomerById(int customerId)
        {
            return customers.FirstOrDefault(c => c.CustomerId == customerId);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = GetCustomerById(customer.CustomerId);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerFullName = customer.CustomerFullName;
                existingCustomer.Telephone = customer.Telephone;
                existingCustomer.EmailAddress = customer.EmailAddress;
                existingCustomer.CustomerStatus = customer.CustomerStatus;
                existingCustomer.Password = customer.Password;
            }
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = GetCustomerById(customerId);
            if (customer != null)
            {
                customers.Remove(customer);
            }
        }
    }
}
