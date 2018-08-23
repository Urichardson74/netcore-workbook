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
                new Provider() { FirstName = "John", LastName = "Doe"},


            };
        }
        public List<Provider> GetAllProviders()
        {
            return ProviderList;
        }

        public void Add(Provider provider)
        {
            provider.ProviderID = Guid.NewGuid();
            ProviderList.Add(provider);
        }


        public void Delete(Guid IDtoDelete)
        {
            var c = ProviderList.Find((item) => IDtoDelete == item.ProviderID);
            ProviderList.Remove(c);
        }

        public Provider FetchID(Guid ID)
        {
            return ProviderList.Find((item) => ID == item.ProviderID);
        }

        public void Update(Provider provider)
        {
            var a = FetchID(provider.ProviderID);
            a.FirstName = provider.FirstName;
            a.LastName = provider.LastName;
            a.Specialty = provider.Specialty;
            a.Phone = provider.Phone;
            a.Email = provider.Email;
        }

    }
}


