using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Character.Controllers
{
    public class CharacterController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            if (DateTime.Now.Minute % 2 == 0)
            {
                var Index = "Index";
                return View(Index);
            }
            else
            {
                var Index = "_MyLayout";
                return View(Index);
            }
        }
    }
}
