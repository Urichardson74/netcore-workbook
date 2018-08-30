using System;
using Microsoft.AspNetCore.Mvc;
using BaseProject.Models;
using BaseProject.Services;
//using System.Collections.Generic.IEnumerable<out T>[BaseProject.Models.Appointment];


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
            ViewBag.ProviderList = _providerDatabase.GetAllProviders();
            return View();

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Appointment appointment)
       
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _appointmentDatabase.Add(appointment);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(String.Empty, ex.Message);
                }

            }
            ViewBag.CustomerList = _mockDatabase.GetAllCustomers();
            ViewBag.ProviderList = _providerDatabase.GetAllProviders();
            return View(appointment);
        }

        // GET: Appointments
        public IActionResult Index(Appointment appointment)
        {
            var appointments = _appointmentDatabase.GetAllAppointments();

            return View(appointments);
        }

        // GET: /<controller>/
        public IActionResult Delete(Guid ID)
        {
            var a = _appointmentDatabase.FetchID(ID);

            return View(a);
        }

        // GET: /<controller>/
        public IActionResult Edit(Guid ID)
        {

            var a = _appointmentDatabase.FetchID(ID);

            return View(a);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Appointment appointment)
        {
            if (ModelState.IsValid)
            {

                _appointmentDatabase.Update(appointment);
                return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete( Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _mockDatabase.Delete(appointment.Id);
                return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }

    }   
}

