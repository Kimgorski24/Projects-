using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNick.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminController : Controller

    {

        // GET: AdMinontroller
        public ActionResult Index()
        {
            return View();
        }
    }
}