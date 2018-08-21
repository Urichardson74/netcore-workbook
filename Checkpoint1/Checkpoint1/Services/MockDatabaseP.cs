using System;
using System.Collections.Generic;
using BaseProject.Models;


namespace BaseProject.Services
{

    public class MockDatabaseP
    {
        private List<Provider> ProviderList;
        public MockDatabaseP()
        {
            ProviderList = new List<Provider>()
            {
                new Provider() { ProviderID = 1, FirstName = "John", LastName = "Doe"},


            };
        }
        public List<Provider> GetAllProviders()
        {
            return ProviderList;
        }

        public void Add(Provider provider)
        {
            ProviderList.Add(provider);
        }

        //public void Delete(Provider provider)
        //{
        //    CustomerList.Remove(provider);
        //}
    }
}
