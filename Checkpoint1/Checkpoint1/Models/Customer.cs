
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Models
{
    public class Customer //: IValidatableObject
    {


        public Guid CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}

