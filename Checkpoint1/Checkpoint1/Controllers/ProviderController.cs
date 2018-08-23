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
        private MockDatabaseP _mockDatabaseP;
        public ProviderController(MockDatabaseP mockDataP)
        {
            _mockDatabaseP = mockDataP;
        }
        // GET: Customers
        public IActionResult Index()
        {
            var providers = _mockDatabaseP.GetAllProviders();

            return View(providers);
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
                _mockDatabaseP.Add(provider);
                return RedirectToAction(nameof(Index));
            }
            return View(provider);
        }

        // GET: /<controller>/
        public IActionResult Edit(Guid ID)
        {

            var a = _mockDatabaseP.FetchID(ID);

            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Provider provider)
        {
            if (ModelState.IsValid)
            {

                _mockDatabaseP.Update(provider);
                return RedirectToAction(nameof(Index));
            }
            return View(provider);
        }

        // GET: /<controller>/
        public IActionResult Delete(Guid ID)
        {
            var a = _mockDatabaseP.FetchID(ID);

            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([Bind("ProviderID,FirstName,LastName,Specialty,Phone,Email")] Provider provider)
        {
            if (ModelState.IsValid)
            {
                _mockDatabaseP.Delete(provider.ProviderID);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}

