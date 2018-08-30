using System;
using System.Collections.Generic;
using BaseProject.Models;
using Checkpoint1.Controllers;
using System.Linq;


namespace BaseProject.Services
{   
    
    public class MockDatabaseA
    {
        public List<Appointment> AppointmentList;
        public MockDatabaseA()
        {
            AppointmentList = new List<Appointment>()
            {


            };
        }

        public class InvalidAppointmentException : Exception
        {
         
            public InvalidAppointmentException(string message) : base(message)
            {
              
            }
        }

        public List<Appointment> GetAllAppointments()
        {
            return AppointmentList;
        }

        public void Add(Appointment appointment)
        {
            var isInvalidAppointment = AppointmentList.Any(b => ((b.CustomerID == appointment.CustomerID
              || b.ProviderID == appointment.ProviderID)
              && b.Time == appointment.Time && b.Day == appointment.Day));
            if (isInvalidAppointment)
                throw new InvalidAppointmentException("Conflicting Appointment- That time is already taken");
            
            appointment.Id = Guid.NewGuid();
            var a = FetchID(Customer.ID);
         
            a.CustomerName = appointment.CustomerName;
           
            AppointmentList.Add(appointment);
            AppointmentList = AppointmentList.OrderBy(b => b.Day).ThenBy(b => b.Time).ToList();


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
            a.CustomerName = appointment.CustomerName;
            a.ProviderName = appointment.ProviderName;
            a.Day = appointment.Day;
            a.Time = appointment.Time;

           
            List<Appointment> appointments = this.AppointmentList;


            var isInvalidAppointment = AppointmentList.Any(b => ((b.CustomerID == appointment.CustomerID
                || b.ProviderID == appointment.ProviderID)
                && b.Time == appointment.Time && b.Day == appointment.Day));
            if (isInvalidAppointment)
                throw new InvalidAppointmentException("Invalid Appointment");
        }


    }
}

