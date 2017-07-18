using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asc_general.Controllers
{
    public class CartoonController : Controller
    {
        // GET: Cartoon
        public ActionResult Index()
        {
            return View();
        }
    }
}