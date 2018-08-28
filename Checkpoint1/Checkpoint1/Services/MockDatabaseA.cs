using System;
using System.Collections.Generic;
using BaseProject.Models;
using Checkpoint1.Controllers;


namespace BaseProject.Services
{   
    
    public class MockDatabaseA
    {
        private List<Appointment> AppointmentList;
        public MockDatabaseA()
        {
            AppointmentList = new List<Appointment>()
            {
             

            };
        }
        public List<Appointment> GetAllAppointments()
        {
            return AppointmentList;
        }

        public void Add(Appointment appointment)
        {
            appointment.Id = Guid.NewGuid();
            AppointmentList.Add(appointment);
        }

        public void Delete(Guid IDtoDelete)
        {
            var c = AppointmentList.Find((item) => IDtoDelete == item.Id);
            AppointmentList.Remove(c);
        }

        public Appointment FetchID(Guid ID)
        {   
            return AppointmentList.Find((item) => ID == item.Id);
        }

        public void Update(Appointment appointment)
        {
            var a = FetchID(appointment.Id);
            //a.FirstName = appointment.FirstName;
            //a.LastName = appointment.LastName;
            //a.Phone = appointment.Phone;
            //a.Email = appointment.Email;
        }
    }
}
