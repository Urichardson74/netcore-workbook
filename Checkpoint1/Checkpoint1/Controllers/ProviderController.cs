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
    public class ProviderController : Controller
    {
        private MockDatabase _mockDatabase;
        public ProviderController(MockDatabase mockData)
        {
            _mockDatabase = mockData;
        }
        // GET: Customers
        public IActionResult Index()
        {
            var customers = _mockDatabase.GetAllCustomers();

            return View(customers);
        }
        // GET: /<controller>/
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ProviderID,FirstName,LastName,Specialty,Phone,Email")] Provider provider)
        {
            if (ModelState.IsValid)
            {
                //_mockDatabase.Add();
                return RedirectToAction(nameof(Index));
            }
            return View(provider);
        }

        // GET: /<controller>/
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([Bind("ProviderID,FirstName,LastName,Specialty,Phone,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                //_mockDatabase.Delete();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
    }
}
