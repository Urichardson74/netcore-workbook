using System;
using System.Collections.Generic;
using BaseProject.Models;
using Checkpoint1.Controllers;


namespace BaseProject.Services
{   
    
    public class MockDatabase
    {
        private List<Customer> CustomerList;
        public MockDatabase()
        {
            CustomerList = new List<Customer>()
            {
                new Customer() {  FirstName = "John", LastName = "Doe"},

            };
        }
        public List<Customer> GetAllCustomers()
        {
            return CustomerList;
        }

        public void Add(Customer customer)
        {
            customer.CustomerID = Guid.NewGuid();
            CustomerList.Add(customer);
        }

        public void Delete(Guid IDtoDelete)
        {
            var c = CustomerList.Find((item) => IDtoDelete == item.CustomerID);
            CustomerList.Remove(c);
        }

        public Customer FetchID(Guid ID)
        {   
            return CustomerList.Find((item) => ID == item.CustomerID);
        }

        public void Update(Customer customer)
        {
            var a = FetchID(customer.CustomerID);
            a.FirstName = customer.FirstName;
            a.LastName = customer.LastName;
            a.Phone = customer.Phone;
            a.Email = customer.Email;
        }
    }
}
