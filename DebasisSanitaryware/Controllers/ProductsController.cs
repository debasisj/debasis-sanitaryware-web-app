using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebasisSanitaryware.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Hindware()
        {
            return View();
        }
    }
}
