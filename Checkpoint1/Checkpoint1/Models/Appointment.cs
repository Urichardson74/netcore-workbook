using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Models
{
    public class Appointment //: IValidatableObject
    {
        [Required]
        public int ApptID { get; set; }
        public int CustomerID { get; set; }
        public int ProviderID { get; set; }
        public DateTime TimeDate{ get; set; }


    }
}