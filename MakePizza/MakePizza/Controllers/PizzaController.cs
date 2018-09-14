using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakePizza.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Home()
        {
            return View();
        }
    }
}