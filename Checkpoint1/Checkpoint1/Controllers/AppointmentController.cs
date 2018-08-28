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
    public class AppointmentController : Controller
    {
        private MockDatabase _mockDatabase;
        private MockDatabaseA _appointmentDatabase;
        private MockDatabaseP _providerDatabase;
        public AppointmentController(MockDatabase mockData, MockDatabaseA appointmentData, MockDatabaseP providerData)
        {
            _mockDatabase = mockData;
            _appointmentDatabase = appointmentData;
            _providerDatabase = providerData;

        }
        // GET: /<controller>/
        public IActionResult Create()
        {
            ViewBag.CustomerList = _mockDatabase.GetAllCustomers();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _appointmentDatabase.Add(appointment);
                //return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }
    }
}
