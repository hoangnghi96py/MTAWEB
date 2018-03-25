using MTAWEB.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MTAWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            newsDAO dao = new newsDAO();
            return View(dao.getListNews());
        }

   


    }
}