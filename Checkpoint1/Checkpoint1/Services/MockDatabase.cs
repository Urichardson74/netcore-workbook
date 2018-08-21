using System;
using System.Collections.Generic;
using BaseProject.Models;


namespace BaseProject.Services
{   
    
    public class MockDatabase
    {
        private List<Customer> CustomerList;
        public MockDatabase()
        {
            CustomerList = new List<Customer>()
            {
                new Customer() { CustomerID = 1, FirstName = "John", LastName = "Doe"},
                

            };
        }
        public List<Customer> GetAllCustomers()
        {
            return CustomerList;
        }

        public void Add(Customer customer)
        {
            CustomerList.Add(customer);
        }

        //public void Delete(Customer customer)
        //{
        //    CustomerList.Remove(customer);
        //}
    }
}
