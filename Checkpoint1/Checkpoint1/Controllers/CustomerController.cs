using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BaseProject.Models;
using BaseProject.Services;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Checkpoint1.Controllers
{
    public class CustomerController : Controller
    {
        private MockDatabase _mockDatabase;
        public CustomerController(MockDatabase mockData)
        {
            _mockDatabase = mockData;
        }
        // GET: Customers
        public IActionResult Index()         {
            var customers = _mockDatabase.GetAllCustomers();
                        return View(customers);         }
        // GET: /<controller>/
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]         [ValidateAntiForgeryToken]         public IActionResult Create([Bind("CustomerID,FirstName,LastName,Phone,Email")] Customer customer)         {             if (ModelState.IsValid)             {                 _mockDatabase.Add(customer);                 return RedirectToAction(nameof(Index));             }             return View(customer);         }

        // GET: /<controller>/
        public IActionResult Edit(Guid ID)
        {
            
                var a = _mockDatabase.FetchID(ID);

                return View(a);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {   
                
                _mockDatabase.Update(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }


        // GET: /<controller>/
        public IActionResult Delete(Guid ID)
        {
            var a = _mockDatabase.FetchID(ID);

            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([Bind("CustomerID,FirstName,LastName,Phone,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _mockDatabase.Delete(customer.CustomerID);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
    }

}
