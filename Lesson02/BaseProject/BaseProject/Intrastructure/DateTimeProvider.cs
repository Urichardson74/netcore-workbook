using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

<<<<<<< HEAD

namespace BaseProject.Intrastructure
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class DateTimeProvider
    {
        public DateTime Now 
        { 

=======
namespace BaseProject.Intrastructure
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now
        {
>>>>>>> d2cabe8699f79eaeae611990f6a1049bed0b12a6
            get
            {
                return DateTime.Now;
            }
<<<<<<< HEAD
        
        }

   
=======
        }
>>>>>>> d2cabe8699f79eaeae611990f6a1049bed0b12a6
    }
}
