using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Models
                     
{
    public class Appointment
    {
        public enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        public enum Times { Ten, Eleven, Twelve, One, Two, Three, Four, Five, Six };


        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public string ProviderName { get; set; }
        public Days Day { get; set; }
        public Times Time { get; set; }
    }
}