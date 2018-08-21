
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Models
{
    public class Customer //: IValidatableObject
    {
        [Required]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    
    }
}

//code to use later to convert phone number
//string phone = i["MyPhone"].ToString();
//string area = phone.Substring(0, 3);
//string major = phone.Substring(3, 3);
//string minor = phone.Substring(6);
//string formatted = string.Format("{0}-{1}-{2}", area, major, minor);