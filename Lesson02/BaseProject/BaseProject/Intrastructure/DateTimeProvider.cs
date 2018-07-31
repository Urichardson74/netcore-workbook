using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BaseProject.Intrastructure
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class DateTimeProvider
    {
        public DateTime Now 
        { 

            get
            {
                return DateTime.Now;
            }
        
        }

   
    }
}
