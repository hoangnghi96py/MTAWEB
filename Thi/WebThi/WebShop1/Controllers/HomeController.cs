using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Footer()
        {
            List<string> ls=new List<string>();
            ls.Add("A");
            ls.Add("B");
            ls.Add("C");
            return PartialView(ls);
        }
    }
       
}